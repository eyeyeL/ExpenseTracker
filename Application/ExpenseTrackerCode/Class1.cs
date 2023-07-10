using System;
using System.Collections.Generic;
using System.Data;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Crypto.Signers;
using Renci.SshNet.Security.Cryptography;

namespace ExpenseTrackerCode
{
    public class ExpenseTrackerCode
    {
        private const int V = 1;

        //setup for MySQL
        String connStr = "server=localhost;user=root;database=testdb;password=********";

        //
        //
        //New Expense Functions
        //
        //


        //Setting global variables
        List<(string, int)> storeNames = new List<(string, int)>();
        List<(string, int)> categoryNames = new List<(string, int)>();
        int numCatId = 0;
        int numStoreId = 0;
        List<String> listOfNames = new List<string>(); //list of names of people whom the expense is shared with
        double numSharedPercent;


        //Check if username exist and insert new username to username table, returns status: welcome new user or welcome back
        public string InsertUsername(string user)
        {   
            //Set up connection to MySQL
            MySqlConnection conn = new MySqlConnection(connStr);
            conn.Open();

            //Setting Stored Procedure
            String storedName = "check_username";
            MySqlCommand cmd = new MySqlCommand(storedName, conn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            //Add IN parameter
            cmd.Parameters.AddWithValue("username", user);

            //Add OUT parameter
            cmd.Parameters.Add(new MySqlParameter("?check_status", MySqlDbType.VarChar));
            cmd.Parameters["?check_status"].Direction = System.Data.ParameterDirection.Output;

            //Execute the Query
            cmd.ExecuteNonQuery();

            string returnStatus = (string)cmd.Parameters["?check_status"].Value;

            conn.Close();

            return returnStatus;
        }


        //Get all store names and its id from stores table in MySQL, put in a list as a tuple, returns that list
        public List<(string, int)> CheckStoreName()
        {
            //Set up connection to MySQL
            MySqlConnection conn = new MySqlConnection(connStr);
            conn.Open();

            //Setting Stored Procedure
            String storedName = "get_store_names";
            MySqlCommand cmd = new MySqlCommand(storedName, conn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            //Retrieveing store names from MySQL
            MySqlDataReader reader = cmd.ExecuteReader();

            //Read data from reader and insert into list
            while (reader.Read())
            {
                storeNames.Add((reader.GetString(0), reader.GetInt16(1)));
            }

            conn.Close();

            return storeNames;
        }


        //Get all expense category and its id from expense_categories table in MySQL, put in a list as a tuple, returns that list
        public List<(string, int)> CheckExpenseCategory()
        {
            //Set up connection to MySQL
            MySqlConnection conn = new MySqlConnection(connStr);
            conn.Open();

            //Setting Stored Procedure
            String storedName = "fetch_expense_categories";
            MySqlCommand cmd = new MySqlCommand(storedName, conn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            //Retrieveing store names from MySQL
            MySqlDataReader reader = cmd.ExecuteReader();
            
            //Read data from reader and insert into list
            while (reader.Read())
            {
                categoryNames.Add((reader.GetString(0), reader.GetInt16(1)));
            }

            conn.Close();
            return categoryNames;
        }

        
        //Obtain category id based on category name, checked against list of tuple created above, if not found, add the new category to expense_categories table in MySQL
        public int SetCatId(String category)
        {
            //Obtain category id, matched based on category name
            for (int i = 0; i < categoryNames.Count; i++)
            {
                String catNameTemp = categoryNames[i].Item1.ToString();
                if (catNameTemp == category)
                {
                    numCatId = categoryNames[i].Item2;
                }
            }

            //If category does not exist, adds new category to expense_categories table in MySQL and get new ID
            if (numCatId == 0)
            {
                //Set up connection to MySQL
                MySqlConnection conn = new MySqlConnection(connStr);
                conn.Open();

                //Setting Stored Procedure
                String storedName = "get_category_id";
                MySqlCommand cmd = new MySqlCommand(storedName, conn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                //Add IN parameter
                cmd.Parameters.AddWithValue("category_name", category);

                //Add OUT parameter
                //brl: if you change the type to MySqlDbType.Int32 you likely shouldn't have to cast as string then parse into int
                cmd.Parameters.Add(new MySqlParameter("?result_cat", MySqlDbType.VarChar));
                cmd.Parameters["?result_cat"].Direction = System.Data.ParameterDirection.Output;

                //Execute the Query
                cmd.ExecuteScalar();

                numCatId = Int32.Parse((string)cmd.Parameters["?result_cat"].Value);

                conn.Close();
                
            }
            return numCatId;
        }


        //Obtain store id based on store name, checked against list of tuple created above, if not found, add the new store name to stores table in MySQL
        public int SetStoreId(String store)
        {
            //Obtain store id, matched based on store name
            for (int i = 0; i < storeNames.Count; i++)
            {
                String storeNameTemp = storeNames[i].Item1.ToString();
                if (storeNameTemp == store)
                {
                    numStoreId = storeNames[i].Item2;
                }
            }
            //If store name does not exist, adds new store to stores table in MySQL and get new ID
            if (numStoreId == 0)
            {
                //Set up connection to MySQL
                MySqlConnection conn = new MySqlConnection(connStr);
                conn.Open();

                //Setting Stored Procedure
                String storedName = "get_store_id";
                MySqlCommand cmd = new MySqlCommand(storedName, conn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                //Add IN parameter
                cmd.Parameters.AddWithValue("storename", store);

                //Add OUT parameter
                cmd.Parameters.Add(new MySqlParameter("?result_store", MySqlDbType.VarChar));
                cmd.Parameters["?result_store"].Direction = System.Data.ParameterDirection.Output;

                //Execute the Query
                cmd.ExecuteScalar();

                numStoreId = Int32.Parse((string)cmd.Parameters["?result_store"].Value);

                conn.Close();
                
            }
            return numStoreId;
        }


        //Calculate amount each person owes in a shared expense
        public double calcAmountPerPerson(double numPeople, double amount)
        {
            //Calculate percent division per person
            numSharedPercent = (1 / numPeople) * 100;
            double divider = numSharedPercent / 100;

            //Calculate amount per person
            double amountPerPerson = amount * divider;
            return (double)Math.Round(amountPerPerson, 2, (MidpointRounding)V);
        }


        //Convert a string of names of people in the shared expense into a list
        public void sharedNamesIntoList(string names)
        {
            String namesOfPeople;

            namesOfPeople = "";

            foreach (char letter in names)
            {
                if (letter != ',')
                {
                    if (letter != ' ')
                    {
                        namesOfPeople += letter;
                    }
                }
                else
                {
                    //Adding the name to the list
                    listOfNames.Add(namesOfPeople);
                    namesOfPeople = "";
                }
            }
            //Adding the final name to the list
            listOfNames.Add(namesOfPeople);
        }


        //Inserting shared expense with names of people the expense is shared with into shared_person table in MySQL
        public void sharedPerson(DateTime expenseDate, double expenseAmountShared, int storeID)
        {
            //Inserting n number of names of people that the expense is shared with
            foreach(string name in listOfNames)
            {
                //Set up connection to MySQL
                MySqlConnection conn = new MySqlConnection(connStr);
                conn.Open();

                //Setting Stored Procedure
                String storedName = "shared_amount_person";
                MySqlCommand cmd = new MySqlCommand(storedName, conn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                //Add IN parameter
                cmd.Parameters.AddWithValue("shared_name", name);
                cmd.Parameters.AddWithValue("exp_date", expenseDate);
                cmd.Parameters.AddWithValue("amount", expenseAmountShared);
                cmd.Parameters.AddWithValue("store_id", storeID);
                cmd.Prepare();

                //Execute the Query
                cmd.ExecuteNonQuery();
                conn.Close();
            }
        }


        //Insert the new expense to the expense table in MySQL
        public String InsertExpense(double amount, DateTime date, String user, bool sharedStatus, int numShared, bool recurChargeStatus)
        {
            //Setting variables
            double expenseAmount = amount;
            DateTime expenseDate = date;
            String expenseUser = user;
            bool expenseSharedStatus = sharedStatus;
            int expenseNumShared = numShared;
            double expenseNumSharedPercent = numSharedPercent;
            bool expenserecurCharge = recurChargeStatus;
            List<String> expenseSharedPersonNames = listOfNames;
            double expenseAmountShared;

            //Calculate amount shared by each person if the expense is a shared expense
            if (expenseSharedStatus == true)
            {
                expenseAmountShared = calcAmountPerPerson(numShared, amount);

                //Insert expense for each shared person into shared__expense table in MySQL
                sharedPerson(expenseDate, expenseAmountShared, numStoreId);
            }
            else
            {
                expenseAmountShared = 0;
            }

            //Storing the new expense to expense table in MySQL
            //Set up connection to MySQL
            MySqlConnection conn = new MySqlConnection(connStr);
            conn.Open();

            //Setting Stored Procedure
            String storedName = "store_new_expense";
            MySqlCommand cmd = new MySqlCommand(storedName, conn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            //Add IN parameter
            cmd.Parameters.AddWithValue("store_id", numStoreId);
            cmd.Parameters.AddWithValue("amount", expenseAmount);
            cmd.Parameters.AddWithValue("shared_expense", expenseSharedStatus);
            cmd.Parameters.AddWithValue("shared_num", expenseNumShared);
            cmd.Parameters.AddWithValue("percent_shared", numSharedPercent);
            cmd.Parameters.AddWithValue("category_id", numCatId);
            cmd.Parameters.AddWithValue("recurring_value", expenserecurCharge);
            cmd.Parameters.AddWithValue("shared_amount", expenseAmountShared);
            cmd.Parameters.AddWithValue("expense_date", date);
            cmd.Parameters.AddWithValue("user_id", user);
            cmd.Prepare();

            //Execute the Query
            cmd.ExecuteNonQuery();
            conn.Close();

            return "Data Stored";
        }

        //
        //
        //Monthly and MonthlyReport Functions
        //
        //

        //Returns expenses in between the start and end date 
        public DataTable GetExpenses(DateTime startRange, DateTime endRange, string username)
        {

            //Obtain data from expense table in MySQL
            //Set up connection to MySQL
            MySqlConnection conn = new MySqlConnection(connStr);
            conn.Open();

            //Setting Stored Procedure
            String storedName = "month_expense";
            MySqlCommand cmd = new MySqlCommand(storedName, conn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            //Adding In Values
            cmd.Parameters.AddWithValue("start_date", startRange);
            cmd.Parameters.AddWithValue("end_date", endRange);
            cmd.Parameters.AddWithValue("user_id", username);

            //Note: this will only handle one result set
            MySqlDataReader reader = cmd.ExecuteReader();
            var dataTable = new DataTable();
            dataTable.Load(reader);

            conn.Close();

            return dataTable;
        }


        //Sums the total amount for the expenses in between the input dates
        public String SumMonthTotal(DateTime startRange, DateTime endRange, string username)
        {
            String Value; //total amount
            String statusExist; //Status of the expenses - if exist, equals "yes"

            //Set up connection to MySQL
            MySqlConnection conn = new MySqlConnection(connStr);
            conn.Open();

            //Setting Stored Procedure
            String storedName = "sum_month";
            MySqlCommand cmd = new MySqlCommand(storedName, conn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            //Adding In Values
            cmd.Parameters.AddWithValue("start_date", startRange);
            cmd.Parameters.AddWithValue("end_date", endRange);
            cmd.Parameters.AddWithValue("user_name", username);

            //Add OUT parameter
            cmd.Parameters.Add(new MySqlParameter("?sum_amount", MySqlDbType.VarChar));
            cmd.Parameters["?sum_amount"].Direction = System.Data.ParameterDirection.Output;
            cmd.Parameters.Add(new MySqlParameter("?status_exist", MySqlDbType.VarChar));
            cmd.Parameters["?status_exist"].Direction = System.Data.ParameterDirection.Output;

            //Execute the Query
            cmd.ExecuteScalar();

            Value = (string)cmd.Parameters["?sum_amount"].Value;
            statusExist = (string)cmd.Parameters["?status_exist"].Value;

            conn.Close();

            if(statusExist == "yes")
            {
                return Value;
            }
            else
            {
                return statusExist; //This indicates that the expense does not exist.
            }
        }



        //Getting total amount by expense category
        public DataTable GetSumByCat(DateTime startRange, DateTime endRange, String username)
        {
            //Obtain data from expense table in MySQL
            //Set up connection to MySQL
            MySqlConnection conn = new MySqlConnection(connStr);
            conn.Open();

            //Setting Stored Procedure
            String storedName = "sum_by_categories";
            MySqlCommand cmd = new MySqlCommand(storedName, conn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            //Adding In Values
            cmd.Parameters.AddWithValue("startDate", startRange);
            cmd.Parameters.AddWithValue("endDate", endRange);
            cmd.Parameters.AddWithValue("user_id", username);

            //Note: this will only handle one result set
            MySqlDataReader reader = cmd.ExecuteReader();
            var dataTable = new DataTable();
            dataTable.Load(reader);

            conn.Close();

            return dataTable;
        }


        //Calculating the total shared amount - amount of the expense is shared with others
        public String SumSharedAmount(DateTime startRange, DateTime endRange, string username)
        {
            //Set up connection to MySQL
            MySqlConnection conn = new MySqlConnection(connStr);
            conn.Open();

            //Setting Stored Procedure
            String storedName = "total_shared_amount";
            MySqlCommand cmd = new MySqlCommand(storedName, conn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            //Adding In Values
            cmd.Parameters.AddWithValue("startDate", startRange);
            cmd.Parameters.AddWithValue("endDate", endRange);
            cmd.Parameters.AddWithValue("user_id", username);

            //Execute the Query
            String totalShared = cmd.ExecuteScalar().ToString(); //Total Amount of the shared expenses

            conn.Close();
            return totalShared;
        }


        //Calculating the amount of the expenses others shared with user
        public String SumOtherShared(DateTime startRange, DateTime endRange, string username)
        {
            //Set up connection to MySQL
            MySqlConnection conn = new MySqlConnection(connStr);
            conn.Open();

            //Setting Stored Procedure
            String storedName = "expense_from_others";
            MySqlCommand cmd = new MySqlCommand(storedName, conn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            //Adding In Values
            cmd.Parameters.AddWithValue("start_date", startRange);
            cmd.Parameters.AddWithValue("end_date", endRange);
            cmd.Parameters.AddWithValue("user_id", username);

            //Execute the Query
            String value = cmd.ExecuteScalar().ToString(); //total amount of expenses others shared with user

            conn.Close();

            if (String.IsNullOrEmpty(value))
            {
                return "0.00"; //This is when there's no shared expenses from others shared with the user, therefore, value of 0.00 is returned
            }
            else
            {
                return value;
            } 
        }


        //Calculating the total shared amount by person of the expenses are shared with
        public DataTable GetSumByPerson(DateTime startRange, DateTime endRange, String username)
        {
            //obtain data from expense table in MySQL
            //Set up connection to MySQL
            MySqlConnection conn = new MySqlConnection(connStr);
            conn.Open();

            //Setting Stored Procedure
            String storedName = "sum_by_shared_person";
            MySqlCommand cmd = new MySqlCommand(storedName, conn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            //Adding In Values
            cmd.Parameters.AddWithValue("startDate", startRange);
            cmd.Parameters.AddWithValue("endDate", endRange);
            cmd.Parameters.AddWithValue("user_id", username);

            //Note: this will only handle one result set
            MySqlDataReader reader = cmd.ExecuteReader();
            var newTable = new DataTable();
            newTable.Load(reader);

            conn.Close();

            return newTable;
        }


        //
        //
        //EditCharge and CommitChange Functions
        //
        //


        //Connect to MySQL to check if the input expense exist and returns the expense if it exists
        public DataTable CheckRowExist(DateTime date, String amount, bool shared, string user)
        {
            //Variables: convert to respective data
            DateTime expenseDate = date;
            Double expenseAmount = Double.Parse(amount);
            bool expenseShared = shared;
            string username = user;

            //obtain data from expense table in MySQL
            //Set up connection to MySQL
            MySqlConnection conn = new MySqlConnection(connStr);
            conn.Open();

            //Setting Stored Procedure
            String storedName = "check_valid_expense";
            MySqlCommand cmd = new MySqlCommand(storedName, conn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            //Adding In Values
            cmd.Parameters.AddWithValue("expenseDate", expenseDate);
            cmd.Parameters.AddWithValue("storeID", numStoreId);
            cmd.Parameters.AddWithValue("catID", numCatId);
            cmd.Parameters.AddWithValue("amount", expenseAmount);
            cmd.Parameters.AddWithValue("shared", shared);
            cmd.Parameters.AddWithValue("username", username);


            //Note: this will only handle one result set
            MySqlDataReader reader = cmd.ExecuteReader();
            var status = new DataTable(); //DataTable of the expense if exist
            status.Load(reader);

            conn.Close();

            return status;
        }


        //Connect to MySQL to change the amount of a particular recurring charge
        public String ChangeRecurringAmount(DateTime date, Double amount, string user, Double newAmount, int storeID, int catID)
        {
            //Set up connection to MySQL
            MySqlConnection conn = new MySqlConnection(connStr);
            conn.Open();

            //Setting Stored Procedure
            String storedName = "new_change_recurring_amount";
            MySqlCommand cmd = new MySqlCommand(storedName, conn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            //Adding In Values
            cmd.Parameters.AddWithValue("charge_date", date);
            cmd.Parameters.AddWithValue("storeID", storeID);
            cmd.Parameters.AddWithValue("old_amount", amount);
            cmd.Parameters.AddWithValue("new_amount", newAmount);
            cmd.Parameters.AddWithValue("catID", catID);
            cmd.Parameters.AddWithValue("username", user);

            //Adding OUT value
            cmd.Parameters.Add(new MySqlParameter("?status_exist", MySqlDbType.VarChar));
            cmd.Parameters["?status_exist"].Direction = System.Data.ParameterDirection.Output;

            //Execute the Query
            cmd.ExecuteScalar();

            String statusExist = (string)cmd.Parameters["?status_exist"].Value; //status returned from MySQL – either that the expense doesn’t exist or amount is changed

            conn.Close();

            return statusExist;
        }


        //Connect to MySQL to change the date of a particular recurring charge
        public String ChangeRecurringDate(DateTime date, Double amount, string user, DateTime newDate, int store, int cat)
        {
            //Set up connection to MySQL
            MySqlConnection conn = new MySqlConnection(connStr);
            conn.Open();

            //Setting Stored Procedure
            String storedName = "new_change_recurring_date";
            MySqlCommand cmd = new MySqlCommand(storedName, conn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            //Adding In Values
            cmd.Parameters.AddWithValue("old_date", date);
            cmd.Parameters.AddWithValue("new_date", newDate);
            cmd.Parameters.AddWithValue("storeID", store);
            cmd.Parameters.AddWithValue("old_amount", amount);
            cmd.Parameters.AddWithValue("catID", cat);
            cmd.Parameters.AddWithValue("username", user);

            //Adding OUT value
            cmd.Parameters.Add(new MySqlParameter("?status_exist", MySqlDbType.VarChar));
            cmd.Parameters["?status_exist"].Direction = System.Data.ParameterDirection.Output;

            //Execute the Query
            cmd.ExecuteScalar();

            String statusExist = (string)cmd.Parameters["?status_exist"].Value; //status returned from MySQL – either that the expense doesn’t exist or date is changed

            conn.Close();

            return statusExist;
        }


        //Connect to MySQL to delete particular recurring charge
        public String DeleteRecurringCharge(DateTime date, Double amount, string user, int store, int cat)
        {
            //Set up connection to MySQL
            MySqlConnection conn = new MySqlConnection(connStr);
            conn.Open();

            //Setting Stored Procedure
            String storedName = "new_delete_recurring_charge";
            MySqlCommand cmd = new MySqlCommand(storedName, conn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            //Adding In Values
            cmd.Parameters.AddWithValue("old_date", date);
            cmd.Parameters.AddWithValue("storeID", store);
            cmd.Parameters.AddWithValue("old_amount", amount);
            cmd.Parameters.AddWithValue("catID", cat);
            cmd.Parameters.AddWithValue("username", user);

            //Adding OUT value
            cmd.Parameters.Add(new MySqlParameter("?status_exist", MySqlDbType.VarChar));
            cmd.Parameters["?status_exist"].Direction = System.Data.ParameterDirection.Output;

            //Execute the Query
            cmd.ExecuteScalar();

            String statusExist = (string)cmd.Parameters["?status_exist"].Value; //status returned from MySQL – either that the expense doesn’t exist or the expense was deleted

            conn.Close();

            return statusExist;
        }
    }
}

