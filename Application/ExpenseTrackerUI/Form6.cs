using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ExpenseTrackerUI
{
    public partial class CommitChange : Form
    {
        ExpenseTrackerCode.ExpenseTrackerCode eT = new ExpenseTrackerCode.ExpenseTrackerCode();

        //Setting Global Variables
        DateTime expenseDate;
        Double expenseAmount;
        bool expenseSharedStatus;
        string expenseUser;
        int storeID;
        int catID;


        public CommitChange(DataTable validExpense, DateTime date, String oldAmount, bool shared, string user, int store, int cat)
        {
            InitializeComponent();

            //Add DataTable to gridview
            viewExpense.DataSource = validExpense;

            //Sets column header of gridview
            viewExpense.Columns["store_name"].HeaderText = "Store";
            viewExpense.Columns["expense_cat"].HeaderText = "Expense Category";
            viewExpense.Columns["amount"].HeaderText = "Amount";
            viewExpense.Columns["shared_expense"].HeaderText = "Expense Shared";
            viewExpense.Columns["percent_shared"].HeaderText = "Percent Shared";
            viewExpense.Columns["recurring_charge"].HeaderText = "Recurring Charge";
            viewExpense.Columns["shared_amount"].HeaderText = "Shared Amount";
            viewExpense.AutoResizeColumns();
            viewExpense.AutoSize = true;

            //Set variables passed in from EditCharge form
            expenseDate = date;
            expenseAmount = Double.Parse(oldAmount);
            expenseSharedStatus = shared;
            expenseUser = user;
            storeID = store;
            catID = cat;
        }


        //When Change Amount is clicked, calls function in ExpenseTracker class to edit the amount of the recurring charge
        private void changeAmount_Click(object sender, EventArgs e)
        {
            //New variable accepted in form
            Double newExpenseAmount = Double.Parse(amount.Text.ToString());

            //Calls function in ExpenseTracker class to change the amount: return status - cannot find expense or amount changed
            string status = eT.ChangeRecurringAmount(expenseDate, expenseAmount, expenseUser, newExpenseAmount, storeID, catID);

            MessageBox.Show(status);
        }


        //When Change Date is clicked, calls function in ExpenseTracker class to change the date of the recurring charge
        private void changeDate_Click(object sender, EventArgs e)
        {
            //calls function in ExpenseTracker class to change the date of charge - return status - cannot find expense or date changed
            string changeDateStatus = eT.ChangeRecurringDate(expenseDate, expenseAmount, expenseUser, dateChange.Value, storeID, catID);

            MessageBox.Show(changeDateStatus);
        }


        //CLOSE button clicked: closes window
        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
