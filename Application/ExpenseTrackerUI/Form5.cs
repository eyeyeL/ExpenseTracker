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
    public partial class EditCharge : Form
    {
        ExpenseTrackerCode.ExpenseTrackerCode eT = new ExpenseTrackerCode.ExpenseTrackerCode();

        //Define global variables
        String username;
        List<(string, int)> stores = new List<(string, int)>();
        List<(string, int)> categories = new List<(string, int)>();
        bool sharedStatus; //user's input if the expense is a shared expense
        int storeID;
        int catID;

        public EditCharge(string user)
        {
            InitializeComponent();

            //Calls function to obtain the store names for ComboBox
            StoreNameLabel();
            //Calls function to obtain the exense categories for ComboBox
            CategoryLabel();

            expenseDate.Format = DateTimePickerFormat.Short;
            username = user;
        }


        //Calls function in ExpenseTracker class to obtain all store names and add to ComboBox
        public void StoreNameLabel()
        {
            stores = eT.CheckStoreName();

            for (int i = 0; i < stores.Count(); i++)
            {
                store.Items.Add(stores[i].Item1);
            }
        }


        //Calls function in ExpenseTracker class to obtain all expense categories and add to ComboBox
        public void CategoryLabel()
        {
            categories = eT.CheckExpenseCategory();

            for (int i = 0; i < categories.Count(); i++)
            {
                expenseCategory.Items.Add(categories[i].Item1);
            }
        }


        //Shows the form that allows the user to edit the amount and date of the recurring charge after the Change button is click
        private void change_Click(object sender, EventArgs e)
        {
            //Calls functions in ExpenseTracker class to obtain the store and category ID
            storeID = eT.SetStoreId(store.Text.ToString());
            catID = eT.SetCatId(expenseCategory.Text.ToString());

            //Setting the status of the shared expense
            if (changeSharedYes.Checked == true)
            {
                sharedStatus = true;
            }
            else if (changeSharedNo.Checked == true)
            {
                sharedStatus = false;
            }
            
            //Calls function from ExpenseTracker Class to check and obtain the particular charge from MySQL
            DataTable expenseRow = eT.CheckRowExist(expenseDate.Value, amount.Text.ToString(), sharedStatus, username);

            //Opens a new form if the expense exist
            Form form6 = new CommitChange(expenseRow, expenseDate.Value, amount.Text.ToString(), sharedStatus, username, storeID, catID);
            form6.ShowDialog();
        }


        //Delete the particular recurring expense after user clicks DELETE button
        private void delete_Click(object sender, EventArgs e)
        {
            storeID = eT.SetStoreId(store.Text.ToString()); 
            catID = eT.SetCatId(expenseCategory.Text.ToString());

            String deleteStatus = eT.DeleteRecurringCharge(expenseDate.Value, Double.Parse(amount.Text.ToString()), username, storeID, catID);
            MessageBox.Show(deleteStatus);
        }


        //When CLOSE button is click, closes the window
        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
