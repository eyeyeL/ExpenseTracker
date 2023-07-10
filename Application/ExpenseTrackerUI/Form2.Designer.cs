namespace ExpenseTrackerUI
{
    partial class NewExpense
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.informUser = new System.Windows.Forms.Label();
            this.storeName = new System.Windows.Forms.ComboBox();
            this.storeLabel = new System.Windows.Forms.Label();
            this.expenseCatLabel = new System.Windows.Forms.Label();
            this.expenseCats = new System.Windows.Forms.ComboBox();
            this.amountLabel = new System.Windows.Forms.Label();
            this.amount = new System.Windows.Forms.TextBox();
            this.dateLabel = new System.Windows.Forms.Label();
            this.expenseDate = new System.Windows.Forms.DateTimePicker();
            this.recurringChargeLabel = new System.Windows.Forms.Label();
            this.recurYes = new System.Windows.Forms.RadioButton();
            this.recurNo = new System.Windows.Forms.RadioButton();
            this.recurMonthsLabel = new System.Windows.Forms.Label();
            this.recurMonths = new System.Windows.Forms.TextBox();
            this.sharedExpenseLabel = new System.Windows.Forms.Label();
            this.sharedYes = new System.Windows.Forms.RadioButton();
            this.sharedNo = new System.Windows.Forms.RadioButton();
            this.numSharedLabel = new System.Windows.Forms.Label();
            this.numShared = new System.Windows.Forms.TextBox();
            this.submit = new System.Windows.Forms.Button();
            this.sharedNameLabel = new System.Windows.Forms.Label();
            this.sharedNames = new System.Windows.Forms.TextBox();
            this.recurChargePanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.recurChargePanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // informUser
            // 
            this.informUser.AutoSize = true;
            this.informUser.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.informUser.Location = new System.Drawing.Point(27, 52);
            this.informUser.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.informUser.Name = "informUser";
            this.informUser.Size = new System.Drawing.Size(629, 30);
            this.informUser.TabIndex = 0;
            this.informUser.Text = "Please input the following information to log your new expense:";
            // 
            // storeName
            // 
            this.storeName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.storeName.FormattingEnabled = true;
            this.storeName.Location = new System.Drawing.Point(223, 122);
            this.storeName.Margin = new System.Windows.Forms.Padding(4);
            this.storeName.Name = "storeName";
            this.storeName.Size = new System.Drawing.Size(154, 29);
            this.storeName.TabIndex = 1;
            this.storeName.Validating += new System.ComponentModel.CancelEventHandler(this.storeName_Validating);
            // 
            // storeLabel
            // 
            this.storeLabel.AutoSize = true;
            this.storeLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.storeLabel.Location = new System.Drawing.Point(42, 130);
            this.storeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.storeLabel.Name = "storeLabel";
            this.storeLabel.Size = new System.Drawing.Size(46, 21);
            this.storeLabel.TabIndex = 2;
            this.storeLabel.Text = "Store";
            // 
            // expenseCatLabel
            // 
            this.expenseCatLabel.AutoSize = true;
            this.expenseCatLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.expenseCatLabel.Location = new System.Drawing.Point(42, 170);
            this.expenseCatLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.expenseCatLabel.Name = "expenseCatLabel";
            this.expenseCatLabel.Size = new System.Drawing.Size(133, 21);
            this.expenseCatLabel.TabIndex = 3;
            this.expenseCatLabel.Text = "Expense Category";
            // 
            // expenseCats
            // 
            this.expenseCats.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.expenseCats.FormattingEnabled = true;
            this.expenseCats.Location = new System.Drawing.Point(223, 167);
            this.expenseCats.Margin = new System.Windows.Forms.Padding(4);
            this.expenseCats.Name = "expenseCats";
            this.expenseCats.Size = new System.Drawing.Size(154, 29);
            this.expenseCats.TabIndex = 4;
            this.expenseCats.Validating += new System.ComponentModel.CancelEventHandler(this.expenseCats_Validating);
            // 
            // amountLabel
            // 
            this.amountLabel.AutoSize = true;
            this.amountLabel.Location = new System.Drawing.Point(42, 215);
            this.amountLabel.Name = "amountLabel";
            this.amountLabel.Size = new System.Drawing.Size(89, 21);
            this.amountLabel.TabIndex = 5;
            this.amountLabel.Text = "Amount ($)";
            // 
            // amount
            // 
            this.amount.Location = new System.Drawing.Point(223, 210);
            this.amount.Name = "amount";
            this.amount.Size = new System.Drawing.Size(100, 29);
            this.amount.TabIndex = 6;
            this.amount.Validating += new System.ComponentModel.CancelEventHandler(this.amount_Validating);
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Location = new System.Drawing.Point(42, 261);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(146, 21);
            this.dateLabel.TabIndex = 7;
            this.dateLabel.Text = "Date of the Expense";
            // 
            // expenseDate
            // 
            this.expenseDate.Location = new System.Drawing.Point(223, 250);
            this.expenseDate.Name = "expenseDate";
            this.expenseDate.Size = new System.Drawing.Size(200, 29);
            this.expenseDate.TabIndex = 8;
            // 
            // recurringChargeLabel
            // 
            this.recurringChargeLabel.AutoSize = true;
            this.recurringChargeLabel.Location = new System.Drawing.Point(42, 309);
            this.recurringChargeLabel.Name = "recurringChargeLabel";
            this.recurringChargeLabel.Size = new System.Drawing.Size(132, 21);
            this.recurringChargeLabel.TabIndex = 9;
            this.recurringChargeLabel.Text = "Recurring Charge";
            // 
            // recurYes
            // 
            this.recurYes.AutoSize = true;
            this.recurYes.Location = new System.Drawing.Point(20, 9);
            this.recurYes.Name = "recurYes";
            this.recurYes.Size = new System.Drawing.Size(51, 25);
            this.recurYes.TabIndex = 10;
            this.recurYes.TabStop = true;
            this.recurYes.Text = "Yes";
            this.recurYes.UseVisualStyleBackColor = true;
            this.recurYes.CheckedChanged += new System.EventHandler(this.recurYes_CheckedChanged);
            // 
            // recurNo
            // 
            this.recurNo.AutoSize = true;
            this.recurNo.Location = new System.Drawing.Point(94, 9);
            this.recurNo.Name = "recurNo";
            this.recurNo.Size = new System.Drawing.Size(49, 25);
            this.recurNo.TabIndex = 11;
            this.recurNo.TabStop = true;
            this.recurNo.Text = "No";
            this.recurNo.UseVisualStyleBackColor = true;
            // 
            // recurMonthsLabel
            // 
            this.recurMonthsLabel.AutoSize = true;
            this.recurMonthsLabel.Location = new System.Drawing.Point(42, 352);
            this.recurMonthsLabel.Name = "recurMonthsLabel";
            this.recurMonthsLabel.Size = new System.Drawing.Size(355, 21);
            this.recurMonthsLabel.TabIndex = 12;
            this.recurMonthsLabel.Text = "How many months (>0) for this recurring charge?";
            // 
            // recurMonths
            // 
            this.recurMonths.Location = new System.Drawing.Point(419, 344);
            this.recurMonths.Name = "recurMonths";
            this.recurMonths.Size = new System.Drawing.Size(100, 29);
            this.recurMonths.TabIndex = 13;
            this.recurMonths.Validating += new System.ComponentModel.CancelEventHandler(this.recurMonths_Validating);

            // 
            // sharedExpenseLabel
            // 
            this.sharedExpenseLabel.AutoSize = true;
            this.sharedExpenseLabel.Location = new System.Drawing.Point(522, 122);
            this.sharedExpenseLabel.Name = "sharedExpenseLabel";
            this.sharedExpenseLabel.Size = new System.Drawing.Size(119, 21);
            this.sharedExpenseLabel.TabIndex = 14;
            this.sharedExpenseLabel.Text = "Shared Expense";
            // 
            // sharedYes
            // 
            this.sharedYes.AutoSize = true;
            this.sharedYes.Location = new System.Drawing.Point(12, 8);
            this.sharedYes.Name = "sharedYes";
            this.sharedYes.Size = new System.Drawing.Size(51, 25);
            this.sharedYes.TabIndex = 15;
            this.sharedYes.TabStop = true;
            this.sharedYes.Text = "Yes";
            this.sharedYes.UseVisualStyleBackColor = true;
            this.sharedYes.CheckedChanged += new System.EventHandler(this.sharedYes_CheckedChanged);
            // 
            // sharedNo
            // 
            this.sharedNo.AutoSize = true;
            this.sharedNo.Location = new System.Drawing.Point(69, 8);
            this.sharedNo.Name = "sharedNo";
            this.sharedNo.Size = new System.Drawing.Size(49, 25);
            this.sharedNo.TabIndex = 16;
            this.sharedNo.TabStop = true;
            this.sharedNo.Text = "No";
            this.sharedNo.UseVisualStyleBackColor = true;
            // 
            // numSharedLabel
            // 
            this.numSharedLabel.AutoSize = true;
            this.numSharedLabel.Location = new System.Drawing.Point(522, 175);
            this.numSharedLabel.Name = "numSharedLabel";
            this.numSharedLabel.Size = new System.Drawing.Size(323, 21);
            this.numSharedLabel.TabIndex = 17;
            this.numSharedLabel.Text = "Number of people the expense is shared with";
            // 
            // numShared
            // 
            this.numShared.Location = new System.Drawing.Point(879, 172);
            this.numShared.Name = "numShared";
            this.numShared.Size = new System.Drawing.Size(100, 29);
            this.numShared.TabIndex = 18;
            this.numShared.Validating += new System.ComponentModel.CancelEventHandler(this.numShared_Validating);
            // 
            // submit
            // 
            this.submit.Location = new System.Drawing.Point(832, 384);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(123, 30);
            this.submit.TabIndex = 19;
            this.submit.Text = "Submit";
            this.submit.UseVisualStyleBackColor = true;
            this.submit.Click += new System.EventHandler(this.submit_Click_1);
            // 
            // sharedNameLabel
            // 
            this.sharedNameLabel.AutoSize = true;
            this.sharedNameLabel.Location = new System.Drawing.Point(522, 215);
            this.sharedNameLabel.Name = "sharedNameLabel";
            this.sharedNameLabel.Size = new System.Drawing.Size(505, 21);
            this.sharedNameLabel.TabIndex = 20;
            this.sharedNameLabel.Text = "Name of person(s) expense is shared with (separate with \" , \" no spaces)";
            // 
            // sharedNames
            // 
            this.sharedNames.Location = new System.Drawing.Point(569, 253);
            this.sharedNames.Name = "sharedNames";
            this.sharedNames.Size = new System.Drawing.Size(132, 29);
            this.sharedNames.TabIndex = 21;
            this.sharedNames.Validating += new System.ComponentModel.CancelEventHandler(this.sharedNames_Validating);
            // 
            // recurChargePanel
            // 
            this.recurChargePanel.Controls.Add(this.recurYes);
            this.recurChargePanel.Controls.Add(this.recurNo);
            this.recurChargePanel.Location = new System.Drawing.Point(223, 294);
            this.recurChargePanel.Name = "recurChargePanel";
            this.recurChargePanel.Size = new System.Drawing.Size(167, 44);
            this.recurChargePanel.TabIndex = 24;
            this.recurChargePanel.Tag = "";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.sharedYes);
            this.panel1.Controls.Add(this.sharedNo);
            this.panel1.Location = new System.Drawing.Point(688, 112);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(126, 39);
            this.panel1.TabIndex = 25;
            // 
            // NewExpense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1196, 622);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.recurChargePanel);
            this.Controls.Add(this.sharedNames);
            this.Controls.Add(this.sharedNameLabel);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.numShared);
            this.Controls.Add(this.numSharedLabel);
            this.Controls.Add(this.sharedExpenseLabel);
            this.Controls.Add(this.recurMonths);
            this.Controls.Add(this.recurMonthsLabel);
            this.Controls.Add(this.recurringChargeLabel);
            this.Controls.Add(this.expenseDate);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.amount);
            this.Controls.Add(this.amountLabel);
            this.Controls.Add(this.expenseCats);
            this.Controls.Add(this.expenseCatLabel);
            this.Controls.Add(this.storeLabel);
            this.Controls.Add(this.storeName);
            this.Controls.Add(this.informUser);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "NewExpense";
            this.Text = "Store";
            this.recurChargePanel.ResumeLayout(false);
            this.recurChargePanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label informUser;
        private System.Windows.Forms.ComboBox storeName;
        private System.Windows.Forms.Label storeLabel;
        private System.Windows.Forms.Label expenseCatLabel;
        private System.Windows.Forms.ComboBox expenseCats;
        private System.Windows.Forms.Label amountLabel;
        private System.Windows.Forms.TextBox amount;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.DateTimePicker expenseDate;
        private System.Windows.Forms.Label recurringChargeLabel;
        private System.Windows.Forms.RadioButton recurYes;
        private System.Windows.Forms.RadioButton recurNo;
        private System.Windows.Forms.Label recurMonthsLabel;
        private System.Windows.Forms.TextBox recurMonths;
        private System.Windows.Forms.Label sharedExpenseLabel;
        private System.Windows.Forms.RadioButton sharedYes;
        private System.Windows.Forms.RadioButton sharedNo;
        private System.Windows.Forms.Label numSharedLabel;
        private System.Windows.Forms.TextBox numShared;
        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.Label sharedNameLabel;
        private System.Windows.Forms.TextBox sharedNames;
        private System.Windows.Forms.Panel recurChargePanel;
        private System.Windows.Forms.Panel panel1;
    }
}