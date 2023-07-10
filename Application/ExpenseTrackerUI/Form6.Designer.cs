namespace ExpenseTrackerUI
{
    partial class CommitChange
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
            this.inforLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.amountLabel = new System.Windows.Forms.Label();
            this.amount = new System.Windows.Forms.TextBox();
            this.dateLabel = new System.Windows.Forms.Label();
            this.dateChange = new System.Windows.Forms.DateTimePicker();
            this.changeAmount = new System.Windows.Forms.Button();
            this.viewExpense = new System.Windows.Forms.DataGridView();
            this.changeDate = new System.Windows.Forms.Button();
            this.close = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.viewExpense)).BeginInit();
            this.SuspendLayout();
            // 
            // inforLabel
            // 
            this.inforLabel.AutoSize = true;
            this.inforLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.inforLabel.Location = new System.Drawing.Point(12, 39);
            this.inforLabel.Name = "inforLabel";
            this.inforLabel.Size = new System.Drawing.Size(122, 21);
            this.inforLabel.TabIndex = 1;
            this.inforLabel.Text = "Inquired Charge";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(8, 44);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(629, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Please input the following information to log your new expense:";
            // 
            // amountLabel
            // 
            this.amountLabel.AutoSize = true;
            this.amountLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.amountLabel.Location = new System.Drawing.Point(23, 239);
            this.amountLabel.Name = "amountLabel";
            this.amountLabel.Size = new System.Drawing.Size(89, 21);
            this.amountLabel.TabIndex = 5;
            this.amountLabel.Text = "Amount ($)";
            // 
            // amount
            // 
            this.amount.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.amount.Location = new System.Drawing.Point(194, 236);
            this.amount.Name = "amount";
            this.amount.Size = new System.Drawing.Size(100, 29);
            this.amount.TabIndex = 6;
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateLabel.Location = new System.Drawing.Point(23, 285);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(146, 21);
            this.dateLabel.TabIndex = 7;
            this.dateLabel.Text = "Date of the Expense";
            // 
            // dateChange
            // 
            this.dateChange.CalendarFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateChange.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateChange.Location = new System.Drawing.Point(194, 283);
            this.dateChange.Name = "dateChange";
            this.dateChange.Size = new System.Drawing.Size(200, 29);
            this.dateChange.TabIndex = 8;
            // 
            // changeAmount
            // 
            this.changeAmount.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.changeAmount.Location = new System.Drawing.Point(442, 230);
            this.changeAmount.Name = "changeAmount";
            this.changeAmount.Size = new System.Drawing.Size(172, 35);
            this.changeAmount.TabIndex = 19;
            this.changeAmount.Text = "Change Amount";
            this.changeAmount.UseVisualStyleBackColor = true;
            this.changeAmount.Click += new System.EventHandler(this.changeAmount_Click);
            // 
            // viewExpense
            // 
            this.viewExpense.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.viewExpense.Location = new System.Drawing.Point(12, 77);
            this.viewExpense.Name = "viewExpense";
            this.viewExpense.Size = new System.Drawing.Size(947, 81);
            this.viewExpense.TabIndex = 27;
            this.viewExpense.Text = "dataGridView1";
            // 
            // changeDate
            // 
            this.changeDate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.changeDate.Location = new System.Drawing.Point(442, 279);
            this.changeDate.Name = "changeDate";
            this.changeDate.Size = new System.Drawing.Size(172, 33);
            this.changeDate.TabIndex = 28;
            this.changeDate.Text = "Change Date";
            this.changeDate.UseVisualStyleBackColor = true;
            this.changeDate.Click += new System.EventHandler(this.changeDate_Click);
            // 
            // close
            // 
            this.close.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.close.Location = new System.Drawing.Point(725, 352);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(99, 31);
            this.close.TabIndex = 29;
            this.close.Text = "Close";
            this.close.UseVisualStyleBackColor = true;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // CommitChange
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(986, 554);
            this.Controls.Add(this.close);
            this.Controls.Add(this.changeDate);
            this.Controls.Add(this.viewExpense);
            this.Controls.Add(this.changeAmount);
            this.Controls.Add(this.dateChange);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.amount);
            this.Controls.Add(this.amountLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.inforLabel);
            this.Name = "CommitChange";
            this.Text = "Form6";
            ((System.ComponentModel.ISupportInitialize)(this.viewExpense)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label inforLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label amountLabel;
        private System.Windows.Forms.TextBox amount;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.DateTimePicker dateChange;
        private System.Windows.Forms.Button changeAmount;
        private System.Windows.Forms.DataGridView viewExpense;
        private System.Windows.Forms.Button changeDate;
        private System.Windows.Forms.Button close;
    }
}