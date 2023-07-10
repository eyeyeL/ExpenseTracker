using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ExpenseTrackerUI
{
    public partial class MonthlyReport : Form
    {
        ExpenseTrackerCode.ExpenseTrackerCode eT = new ExpenseTrackerCode.ExpenseTrackerCode();

        //Define Global Variables
        DataTable monthlyExpenses;

        public MonthlyReport(DataTable monthly, DateTime start, DateTime end, string userName)
        {
            InitializeComponent();

            //Get date only for the start and end range
            DateTime startDate = start.Date;
            DateTime endDate = end.Date;

            //Set text of label to show the start and end date of the expense
            dateRange.Text = startDate.ToString("d") + " to " + endDate.ToString("d");

            //Set gridview data source to the datatable passed in from Monthly form
            monthlyExpenses = monthly;
            viewMonth.DataSource = monthlyExpenses;

            //Set the column header names
            viewMonth.Columns["store_name"].HeaderText = "Store";
            viewMonth.Columns["expense_cat"].HeaderText = "Expense Category";
            viewMonth.Columns["amount"].HeaderText = "Amount";
            viewMonth.Columns["shared_expense"].HeaderText = "Expense Shared";
            viewMonth.Columns["percent_shared"].HeaderText = "Percent Shared";
            viewMonth.Columns["recurring_charge"].HeaderText = "Recurring Charge";
            viewMonth.Columns["shared_amount"].HeaderText = "Shared Amount";
            viewMonth.AutoResizeColumns();
            this.AutoSize = true;

            //Calls function from Expense Tracker class for sum of total amount
            double sumAmount = Math.Round(Double.Parse(eT.SumMonthTotal(start, end, userName)), 2);
            totalExpense.Text = sumAmount.ToString();

            //Calls function from Expense Tracker class for sum by categories
            DataTable sumCat = eT.GetSumByCat(start, end, userName);
            sumByCat.DataSource = sumCat;
            sumByCat.Columns["Expense_cat"].HeaderText = "Expense Categories";
            sumByCat.Columns["Round(sum(expense.amount), 2)"].HeaderText = "Sum Amount";
            sumByCat.AutoSize = true;

            //Calls function from Expense Tracker class to get Total Shared Amount
            String sumSharedAmount = eT.SumSharedAmount(start, end, userName);
            totalSharedAmount.Text = sumSharedAmount;

            //Calls function from Expense Tracker class to get Total Other Shares With You
            String sumOtherShared = eT.SumOtherShared(start, end, userName);
            totalSharedWith.Text = sumOtherShared;

            //Calls function from expense Tracker class to get sum by shared person
            DataTable sumPerson = eT.GetSumByPerson(start, end, userName);
            sumByShared.DataSource = sumPerson;
            sumByShared.Columns["name"].HeaderText = "Name";
            sumByShared.Columns["ROUND(SUM(shared_person.amount), 2)"].HeaderText = "Sum Amount";
            sumByShared.AutoSize = true;

        }


        //When user clicks the CLOSE button, closes the window
        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
