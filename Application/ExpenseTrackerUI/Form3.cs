using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ExpenseTrackerUI
{
    public partial class Monthly : Form
    {
        ExpenseTrackerCode.ExpenseTrackerCode eT = new ExpenseTrackerCode.ExpenseTrackerCode();

        //Defining global variables
        DateTime startRange;
        DateTime endRange;
        string username;
        DataTable monthExpenseData;


        public Monthly(string user)
        {
            InitializeComponent();
            username = user;
 
            //Set format to expense DateTime value
            expenseStartRange.Format = DateTimePickerFormat.Short;
            expenseEndRange.Format = DateTimePickerFormat.Short;

            this.AutoSize = true;

            //DataTable dt = new DataTable();
            //this is just for demo, you can remove it later
            //dt.Columns.Add("store_name");
            //dt.Columns.Add("store_id");
            //dt.Rows.Add("costco", "1");
            //dt.Rows.Add("superstore", "2");

            //ComboBox cbx = new ComboBox();
            //cbx.DataSource = dt;
            //cbx.DisplayMember = "store_name";
            //cbx.ValueMember = "store_id";
            //cbx.SelectedValueChanged += Cbx_SelectedValueChanged;

            //this.Controls.Add(cbx);

            //dataGridView1.DataSource = dt;
        }

        //private void Cbx_SelectedValueChanged(object sender, EventArgs e)
        //{
            //ComboBox cbx = sender as ComboBox;
            //here you could check the id value
            //cbx.SelectedValue
        //}


        //Window closes if user click the CLOSE button
        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        //Shows the report of the expense within the specified range when user click SUBMIT button
        private void submitButton_Click(object sender, EventArgs e)
        {
            //Stores the start and end Range specified by user
            startRange = expenseStartRange.Value;
            endRange = expenseEndRange.Value;

            //Calls the ExpenseTracker class to get the expense for the speficied range
            monthExpenseData = eT.GetExpenses(startRange, endRange, username);

            //Opens a new form showing the returned expenses
            Form form4 = new MonthlyReport(monthExpenseData, startRange, endRange, username);
            form4.ShowDialog();

        }
    }
}
