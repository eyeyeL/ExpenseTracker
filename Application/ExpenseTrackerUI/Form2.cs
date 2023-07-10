using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;


namespace ExpenseTrackerUI
{
    public partial class NewExpense : Form
    {
        ExpenseTrackerCode.ExpenseTrackerCode eT = new ExpenseTrackerCode.ExpenseTrackerCode();

        //Set Global Variables
        String user;
        List<(string, int)> storeNames = new List<(string, int)>();
        List<(string, int)> categoryNames = new List<(string, int)>();
        bool recurStatus;
        bool numSharedStatus;
        int numPerson;
        DateTime currentDate;


        public NewExpense(string username)
        {
            user = username;
            InitializeComponent();

            //Function to call ExpenseTracker class to obtain all the store names in database, use to fill ComboBox for store's name
            StoreNameLabel();

            //Function to call ExpenseTracker class to obtain all the store names in database, use to fill ComboBox for expense category
            CategoryLabel();

            //Setting default values to "No" for recurring charge and shared expense
            recurNo.Checked = true;
            sharedNo.Checked = true;

            //throw new Exception("I love you wife. - Old Man");

            //Set format to expense DateTime value
            expenseDate.Format = DateTimePickerFormat.Short;

            //Hide the label and textbox asking for how many months for recurring charges
            recurMonthsLabel.Hide();
            recurMonths.Hide();

            //Hide label and textbox for number of shared expense
            numSharedLabel.Hide();
            numShared.Hide();
            sharedNameLabel.Hide();
            sharedNames.Hide();

            this.AutoSize = true;
        }


        //Function to call ExpenseTracker class to obtain all the store names in database, use to fill ComboBox for store's name
        public void StoreNameLabel()
        {
            //Calls function in ExpenseTracker class
            storeNames = eT.CheckStoreName();

            //Adding store names into ComboBox
            for (int i = 0; i < storeNames.Count(); i++)
            {
                storeName.Items.Add(storeNames[i].Item1);
            }
        }


        //Validates that the user pick or input a store name
        private void storeName_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(storeName.Text.ToString()) || String.IsNullOrWhiteSpace(storeName.Text.ToString()))
            {
                MessageBox.Show("Please insert or select a store.");
            }
        }


        //Function to call ExpenseTracker class to obtain all the store names in database, use to fill ComboBox for expense category
        public void CategoryLabel()
        {
            //Calls function in ExpenseTracker class
            categoryNames = eT.CheckExpenseCategory();

            //Adding store names into ComboBox
            for (int i = 0; i < categoryNames.Count(); i++)
            {
                expenseCats.Items.Add(categoryNames[i].Item1);
            }
        }


        //Validates if user pick or input expense category
        private void expenseCats_Validating(object sender, CancelEventArgs e)
        {
            if(String.IsNullOrEmpty(expenseCats.Text.ToString()) || String.IsNullOrWhiteSpace(expenseCats.Text.ToString()))
            {
                MessageBox.Show("Please insert or select a expense category.");
            }
        }


        //Validates that user input amount for the expense
        private void amount_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(amount.Text.ToString()) || String.IsNullOrWhiteSpace(amount.Text.ToString()))
            {
                MessageBox.Show("Please insert the amount.");
            }
        }


        //Shows the Textbox for user to input the amount of recurring months if user choose YES for recurring charge
        private void recurYes_CheckedChanged(object sender, EventArgs e)
        {
            //If user picked YES, prompt user to input number of months for this particuarly recurring charge
            if (recurYes.Checked == true)
            {
                recurMonthsLabel.Show();
                recurMonths.Show();
                //Setting the recurring charge status to TRUE
                recurStatus = true;
            }
            //If user picked NO, hide the textbox for number of months
            else
            {
                recurMonthsLabel.Hide();
                recurMonths.Hide();
                //Setting the recurring charge status to FALSE
                recurStatus = false;
            }
        }


        //Validates if user input number of months for the recurring charge
        private void recurMonths_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(recurMonths.Text.ToString()) || String.IsNullOrWhiteSpace(recurMonths.Text.ToString()))
            {
                MessageBox.Show("Please insert or select a number months for this recurring charge.");
            }
            
        }


        //If the user select YES, shows the textboxes for number of people and names of people the charge is shared with
        private void sharedYes_CheckedChanged(object sender, EventArgs e)
        {
            //User Selection: YES - prompts user to input number of people and name(s) of people for the shared expense
            if (sharedYes.Checked == true)
            {
                numSharedLabel.Show();
                numShared.Show();
                sharedNameLabel.Show();
                sharedNames.Show();
                //Setting the shared expense status to TRUE
                numSharedStatus = true;
            }
            //User Selection: NO - hide textboxes for user's input
            else
            {
                numSharedLabel.Hide();
                numShared.Hide();
                sharedNameLabel.Hide();
                sharedNames.Hide();
                //Setting the shared expense status to FALSE
                numSharedStatus = false;
            }
        }


        //Validates that the user input number of people the expense is shared with
        private void numShared_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(numShared.Text.ToString()) || String.IsNullOrWhiteSpace(numShared.Text.ToString()))
            {
                MessageBox.Show("Please insert the number of people for this shared expense.");
            }
        }


        //Validates that the user input and have the correct number of name(s) of people for the shared expense
        private void sharedNames_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(sharedNames.Text.ToString()) || String.IsNullOrWhiteSpace(sharedNames.Text.ToString()))
            {
                MessageBox.Show("Please insert the name(s) of people for this shared expense.");
            }
            //if the textbox is not empty, the code verifies that the number of names inputted equals to the number of people for the shared expense
            else
            {
                String sharedNamesString = sharedNames.Text.ToString();
                //count number of comas the string has
                int numComas = sharedNamesString.Count(f => f == ',');
                numPerson = Int16.Parse(numShared.Text);

                if ((numComas) != numPerson - 2)
                {
                    MessageBox.Show("Please fill in the correct number of names!");
                }

                //Call function in ExpenseTracker class to conver the string of names into a List
                eT.sharedNamesIntoList(sharedNamesString);
            }
        }


        //Expense is saved to the database after the user click the submit button
        private void submit_Click_1(object sender, EventArgs e)
        {
            //Calls ExpenseTracker class to get store id from MySQL
            int storeID = eT.SetStoreId(storeName.Text.ToString());
            //Calls ExpenseTracker class to get category id from MySQL
            int catID = eT.SetCatId(expenseCats.Text.ToString());
            //set currentDate to date user inputs
            currentDate = expenseDate.Value;

            //if user selects YES for recurring charge, the program automatically stores the expense for a particular number of months(user define)
            if (recurYes.Checked == true)
            {
                //Auto add recurring charge to expense table in MySQL
                int totalRecurMonths = Int16.Parse(recurMonths.Text);
                int numberOfMonths = Int16.Parse(recurMonths.Text);

                while (numberOfMonths > 0)
                {
                    //Adds one month to the current date
                    currentDate = currentDate.AddMonths(1);
                    //Calls ExpenseTracker class to store recurring charge
                    eT.InsertExpense(double.Parse(amount.Text, System.Globalization.CultureInfo.InvariantCulture), currentDate, user, numSharedStatus, numPerson, recurStatus);
                    numberOfMonths--;
                } 
            }

            //Calls ExpenseTracker class to insert expense for the date user specified
            string status = eT.InsertExpense(double.Parse(amount.Text, System.Globalization.CultureInfo.InvariantCulture), expenseDate.Value, user, numSharedStatus, numPerson, recurStatus);
            MessageBox.Show(status);

            //Window is closed after the expense is inserted 
            this.Close();

        }

        
    }    
}
