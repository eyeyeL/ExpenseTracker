namespace ExpenseTrackerUI
{
    partial class EditCharge
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
            this.infoLable = new System.Windows.Forms.Label();
            this.dateLabel = new System.Windows.Forms.Label();
            this.storeNameLabel = new System.Windows.Forms.Label();
            this.expenseDate = new System.Windows.Forms.DateTimePicker();
            this.expenseCatLabel = new System.Windows.Forms.Label();
            this.amountLabel = new System.Windows.Forms.Label();
            this.store = new System.Windows.Forms.ComboBox();
            this.expenseCategory = new System.Windows.Forms.ComboBox();
            this.amount = new System.Windows.Forms.TextBox();
            this.sharedNo = new System.Windows.Forms.RadioButton();
            this.sharedPanel = new System.Windows.Forms.Panel();
            this.sharedYes = new System.Windows.Forms.RadioButton();
            this.sharedExpenseLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.changeSharedNo = new System.Windows.Forms.RadioButton();
            this.changeSharedYes = new System.Windows.Forms.RadioButton();
            this.change = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.close = new System.Windows.Forms.Button();
            this.sharedPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // infoLable
            // 
            this.infoLable.AutoSize = true;
            this.infoLable.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.infoLable.Location = new System.Drawing.Point(15, 32);
            this.infoLable.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.infoLable.Name = "infoLable";
            this.infoLable.Size = new System.Drawing.Size(766, 30);
            this.infoLable.TabIndex = 0;
            this.infoLable.Text = "Please input the information of the recurring charge you would like to change.";
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateLabel.Location = new System.Drawing.Point(15, 116);
            this.dateLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(42, 21);
            this.dateLabel.TabIndex = 1;
            this.dateLabel.Text = "Date";
            // 
            // storeNameLabel
            // 
            this.storeNameLabel.AutoSize = true;
            this.storeNameLabel.Location = new System.Drawing.Point(15, 160);
            this.storeNameLabel.Name = "storeNameLabel";
            this.storeNameLabel.Size = new System.Drawing.Size(92, 21);
            this.storeNameLabel.TabIndex = 3;
            this.storeNameLabel.Text = "Store Name";
            // 
            // expenseDate
            // 
            this.expenseDate.Location = new System.Drawing.Point(154, 108);
            this.expenseDate.Name = "expenseDate";
            this.expenseDate.Size = new System.Drawing.Size(200, 29);
            this.expenseDate.TabIndex = 4;
            // 
            // expenseCatLabel
            // 
            this.expenseCatLabel.AutoSize = true;
            this.expenseCatLabel.Location = new System.Drawing.Point(15, 203);
            this.expenseCatLabel.Name = "expenseCatLabel";
            this.expenseCatLabel.Size = new System.Drawing.Size(133, 21);
            this.expenseCatLabel.TabIndex = 5;
            this.expenseCatLabel.Text = "Expense Category";
            // 
            // amountLabel
            // 
            this.amountLabel.AutoSize = true;
            this.amountLabel.Location = new System.Drawing.Point(15, 242);
            this.amountLabel.Name = "amountLabel";
            this.amountLabel.Size = new System.Drawing.Size(89, 21);
            this.amountLabel.TabIndex = 7;
            this.amountLabel.Text = "Amount ($)";
            // 
            // store
            // 
            this.store.FormattingEnabled = true;
            this.store.Location = new System.Drawing.Point(154, 152);
            this.store.Name = "store";
            this.store.Size = new System.Drawing.Size(121, 29);
            this.store.TabIndex = 8;
            // 
            // expenseCategory
            // 
            this.expenseCategory.FormattingEnabled = true;
            this.expenseCategory.Location = new System.Drawing.Point(154, 195);
            this.expenseCategory.Name = "expenseCategory";
            this.expenseCategory.Size = new System.Drawing.Size(121, 29);
            this.expenseCategory.TabIndex = 9;
            // 
            // amount
            // 
            this.amount.Location = new System.Drawing.Point(154, 239);
            this.amount.Name = "amount";
            this.amount.Size = new System.Drawing.Size(100, 29);
            this.amount.TabIndex = 10;
            // 
            // sharedNo
            // 
            this.sharedNo.AutoSize = true;
            this.sharedNo.Location = new System.Drawing.Point(74, 14);
            this.sharedNo.Name = "sharedNo";
            this.sharedNo.Size = new System.Drawing.Size(41, 19);
            this.sharedNo.TabIndex = 13;
            this.sharedNo.TabStop = true;
            this.sharedNo.Text = "No";
            this.sharedNo.UseVisualStyleBackColor = true;
            // 
            // sharedPanel
            // 
            this.sharedPanel.Controls.Add(this.sharedNo);
            this.sharedPanel.Location = new System.Drawing.Point(322, 389);
            this.sharedPanel.Name = "sharedPanel";
            this.sharedPanel.Size = new System.Drawing.Size(131, 21);
            this.sharedPanel.TabIndex = 14;
            // 
            // sharedYes
            // 
            this.sharedYes.AutoSize = true;
            this.sharedYes.Location = new System.Drawing.Point(339, 375);
            this.sharedYes.Name = "sharedYes";
            this.sharedYes.Size = new System.Drawing.Size(51, 25);
            this.sharedYes.TabIndex = 12;
            this.sharedYes.TabStop = true;
            this.sharedYes.Text = "Yes";
            this.sharedYes.UseVisualStyleBackColor = true;
            // 
            // sharedExpenseLabel
            // 
            this.sharedExpenseLabel.AutoSize = true;
            this.sharedExpenseLabel.Location = new System.Drawing.Point(15, 293);
            this.sharedExpenseLabel.Name = "sharedExpenseLabel";
            this.sharedExpenseLabel.Size = new System.Drawing.Size(119, 21);
            this.sharedExpenseLabel.TabIndex = 11;
            this.sharedExpenseLabel.Text = "Shared Expense";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.changeSharedNo);
            this.panel1.Controls.Add(this.changeSharedYes);
            this.panel1.Location = new System.Drawing.Point(151, 285);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(134, 39);
            this.panel1.TabIndex = 12;
            // 
            // changeSharedNo
            // 
            this.changeSharedNo.AutoSize = true;
            this.changeSharedNo.Location = new System.Drawing.Point(75, 6);
            this.changeSharedNo.Name = "changeSharedNo";
            this.changeSharedNo.Size = new System.Drawing.Size(49, 25);
            this.changeSharedNo.TabIndex = 1;
            this.changeSharedNo.TabStop = true;
            this.changeSharedNo.Text = "No";
            this.changeSharedNo.UseVisualStyleBackColor = true;
            // 
            // changeSharedYes
            // 
            this.changeSharedYes.AutoSize = true;
            this.changeSharedYes.Location = new System.Drawing.Point(12, 6);
            this.changeSharedYes.Name = "changeSharedYes";
            this.changeSharedYes.Size = new System.Drawing.Size(51, 25);
            this.changeSharedYes.TabIndex = 0;
            this.changeSharedYes.TabStop = true;
            this.changeSharedYes.Text = "Yes";
            this.changeSharedYes.UseVisualStyleBackColor = true;
            // 
            // change
            // 
            this.change.Location = new System.Drawing.Point(151, 354);
            this.change.Name = "change";
            this.change.Size = new System.Drawing.Size(75, 33);
            this.change.TabIndex = 13;
            this.change.Text = "Change";
            this.change.UseVisualStyleBackColor = true;
            this.change.Click += new System.EventHandler(this.change_Click);
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(290, 354);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(75, 33);
            this.delete.TabIndex = 14;
            this.delete.Text = "Delete";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // close
            // 
            this.close.Location = new System.Drawing.Point(432, 354);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(75, 32);
            this.close.TabIndex = 15;
            this.close.Text = "Close";
            this.close.UseVisualStyleBackColor = true;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // EditCharge
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1029, 640);
            this.Controls.Add(this.close);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.change);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.sharedExpenseLabel);
            this.Controls.Add(this.amount);
            this.Controls.Add(this.expenseCategory);
            this.Controls.Add(this.store);
            this.Controls.Add(this.amountLabel);
            this.Controls.Add(this.expenseCatLabel);
            this.Controls.Add(this.expenseDate);
            this.Controls.Add(this.storeNameLabel);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.infoLable);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "EditCharge";
            this.Text = "Form5";
            this.sharedPanel.ResumeLayout(false);
            this.sharedPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label infoLable;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Label storeNameLabel;
        private System.Windows.Forms.DateTimePicker expenseDate;
        private System.Windows.Forms.Label expenseCatLabel;
        private System.Windows.Forms.Label amountLabel;
        private System.Windows.Forms.ComboBox store;
        private System.Windows.Forms.ComboBox expenseCategory;
        private System.Windows.Forms.TextBox amount;
        private System.Windows.Forms.RadioButton sharedNo;
        private System.Windows.Forms.Panel sharedPanel;
        private System.Windows.Forms.RadioButton sharedYes;
        private System.Windows.Forms.Label sharedExpenseLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton changeSharedNo;
        private System.Windows.Forms.RadioButton changeSharedYes;
        private System.Windows.Forms.Button change;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button close;
    }
}