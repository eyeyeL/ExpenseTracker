using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ExpenseTrackerCode;

namespace ExpenseTrackerUI
{
    public partial class Form1 : Form
    {
        ExpenseTrackerCode.ExpenseTrackerCode eT = new ExpenseTrackerCode.ExpenseTrackerCode();

        //Defining global variables
        String user;


        public Form1()
        {
            InitializeComponent();

            //Hide user's choice
            newWelcome.Hide();
            choiceLabel.Hide();
            userChoices.Hide();
            enterChoice.Hide();
            //MessageBox.Show("I love you so much wife. You can do it! -  Husband");
            this.AutoSize = true;
        }

        
        //Changing user's input to string
        public void usernameInput_TextChanged(object sender, EventArgs e)
        {
            user = usernameInput.Text.ToString();
   
        }


        //User press enter after entering their username, Show the choices for user to choose
        private void usernameInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                //check to see if the textbox is empty. Ask user to input username if text box is empty
                if (String.IsNullOrEmpty(user))
                    MessageBox.Show("Please input your username!");
                else
                {
                    //Calling Expense Tracker class: to input username into database
                    //Return status: either welcome new user or welcome back 
                    string status = eT.InsertUsername(user);
                    MessageBox.Show(status);

                    //Show welcome message custom to user's name
                    newWelcome_Click();
                    //Hide username input textbox and label
                    hideUsernameInsertBox();
                    //Show user the choices for different transactions
                    userChoicesBox();
                }
            }
        }


        //User click submit button after entering their username, Show the choices for user to choose
        private void submitButton_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(user))
                MessageBox.Show("Please input your username!");
            else
            {
                string status = eT.InsertUsername(user);
                MessageBox.Show(status);
                newWelcome_Click();
                hideUsernameInsertBox();
                userChoicesBox();
            }
        }


        //Show welcome message custom to user's name
        public void newWelcome_Click()
        {
            welcomeLabel.Hide();
            string newLabel = "Welcome " + user + ", to your Expense Tracker!";
            newWelcome.Text = newLabel;
            newWelcome.TextAlign = ContentAlignment.MiddleCenter;
            newWelcome.Show();
        }


        //Hide username input textbox and label
        public void hideUsernameInsertBox()
        {
            usernameLabel.Hide();
            usernameInput.Hide();
            submitButton.Hide();

        }


        //Show user the choices for different transactions
        const string NEW_EXPENSE_TEXT = "New Expense";
        const string reportText = "Report";
        const string editRecurringChargeText = "Edit Recurring Charge";
        public void userChoicesBox()
        {
            //Adding Choices to ComboBox
            userChoices.Items.Add(NEW_EXPENSE_TEXT);
            userChoices.Items.Add(reportText);
            userChoices.Items.Add(editRecurringChargeText);
            userChoices.SelectedIndex = 0;
            choiceLabel.Show();
            userChoices.Show();
            enterChoice.Show();
        }


        //After user submit choice by clicking button: shows different form dependent of user's choice
        private void enterChoice_Click(object sender, EventArgs e)
        {
            //selection choice: New Expense
            if (userChoices.SelectedItem.ToString() == NEW_EXPENSE_TEXT)
            {
                Form form2 = new NewExpense(user);
                form2.ShowDialog();
            }
            //selection choice: Report
            else if (userChoices.SelectedItem.ToString() == reportText)
            {
                Form form3 = new Monthly(user);
                form3.ShowDialog();
            }
            //selection choice: Edit Charge
            else if (userChoices.SelectedItem.ToString() == editRecurringChargeText)
            {
                Form form5 = new EditCharge(user);
                form5.ShowDialog();
            }
        }

        //Closes the form if the user press the close button
        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }    
}
