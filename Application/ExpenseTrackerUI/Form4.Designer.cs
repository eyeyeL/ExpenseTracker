namespace ExpenseTrackerUI
{
    partial class MonthlyReport
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
            this.viewMonth = new System.Windows.Forms.DataGridView();
            this.inforLabel = new System.Windows.Forms.Label();
            this.dateRange = new System.Windows.Forms.Label();
            this.closeButton = new System.Windows.Forms.Button();
            this.totalLabel = new System.Windows.Forms.Label();
            this.totalExpense = new System.Windows.Forms.Label();
            this.sumByCatLabel = new System.Windows.Forms.Label();
            this.sumByCat = new System.Windows.Forms.DataGridView();
            this.totalSharedAmountLabel = new System.Windows.Forms.Label();
            this.totalSharedAmount = new System.Windows.Forms.Label();
            this.totalSharedWithLabel = new System.Windows.Forms.Label();
            this.totalSharedWith = new System.Windows.Forms.Label();
            this.summingBySharedLabel = new System.Windows.Forms.Label();
            this.sumByShared = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.viewMonth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sumByCat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sumByShared)).BeginInit();
            this.SuspendLayout();
            // 
            // viewMonth
            // 
            this.viewMonth.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.viewMonth.Location = new System.Drawing.Point(53, 73);
            this.viewMonth.Margin = new System.Windows.Forms.Padding(4);
            this.viewMonth.Name = "viewMonth";
            this.viewMonth.Size = new System.Drawing.Size(948, 362);
            this.viewMonth.TabIndex = 0;
            this.viewMonth.Text = "dataGridView1";
            // 
            // inforLabel
            // 
            this.inforLabel.AutoSize = true;
            this.inforLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.inforLabel.Location = new System.Drawing.Point(53, 39);
            this.inforLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.inforLabel.Name = "inforLabel";
            this.inforLabel.Size = new System.Drawing.Size(266, 21);
            this.inforLabel.TabIndex = 1;
            this.inforLabel.Text = "You\'re viewing montly expense from:";
            // 
            // dateRange
            // 
            this.dateRange.AutoSize = true;
            this.dateRange.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateRange.Location = new System.Drawing.Point(402, 39);
            this.dateRange.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dateRange.Name = "dateRange";
            this.dateRange.Size = new System.Drawing.Size(52, 21);
            this.dateRange.TabIndex = 2;
            this.dateRange.Text = "label1";
            // 
            // closeButton
            // 
            this.closeButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.closeButton.Location = new System.Drawing.Point(852, 780);
            this.closeButton.Margin = new System.Windows.Forms.Padding(4);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(117, 33);
            this.closeButton.TabIndex = 3;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.totalLabel.Location = new System.Drawing.Point(53, 459);
            this.totalLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(105, 21);
            this.totalLabel.TabIndex = 4;
            this.totalLabel.Text = "Total Expense:";
            // 
            // totalExpense
            // 
            this.totalExpense.AutoSize = true;
            this.totalExpense.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.totalExpense.Location = new System.Drawing.Point(166, 459);
            this.totalExpense.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.totalExpense.Name = "totalExpense";
            this.totalExpense.Size = new System.Drawing.Size(52, 21);
            this.totalExpense.TabIndex = 5;
            this.totalExpense.Text = "label1";
            // 
            // sumByCatLabel
            // 
            this.sumByCatLabel.AutoSize = true;
            this.sumByCatLabel.Cursor = System.Windows.Forms.Cursors.No;
            this.sumByCatLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.sumByCatLabel.Location = new System.Drawing.Point(53, 491);
            this.sumByCatLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.sumByCatLabel.Name = "sumByCatLabel";
            this.sumByCatLabel.Size = new System.Drawing.Size(180, 21);
            this.sumByCatLabel.TabIndex = 6;
            this.sumByCatLabel.Text = "Summing By Categories:";
            // 
            // sumByCat
            // 
            this.sumByCat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sumByCat.Location = new System.Drawing.Point(53, 515);
            this.sumByCat.Name = "sumByCat";
            this.sumByCat.Size = new System.Drawing.Size(300, 168);
            this.sumByCat.TabIndex = 7;
            this.sumByCat.Text = "dataGridView1";
            // 
            // totalSharedAmountLabel
            // 
            this.totalSharedAmountLabel.AutoSize = true;
            this.totalSharedAmountLabel.Location = new System.Drawing.Point(428, 459);
            this.totalSharedAmountLabel.Name = "totalSharedAmountLabel";
            this.totalSharedAmountLabel.Size = new System.Drawing.Size(158, 21);
            this.totalSharedAmountLabel.TabIndex = 8;
            this.totalSharedAmountLabel.Text = "Total Shared Amount:";
            // 
            // totalSharedAmount
            // 
            this.totalSharedAmount.AutoSize = true;
            this.totalSharedAmount.Location = new System.Drawing.Point(592, 459);
            this.totalSharedAmount.Name = "totalSharedAmount";
            this.totalSharedAmount.Size = new System.Drawing.Size(52, 21);
            this.totalSharedAmount.TabIndex = 9;
            this.totalSharedAmount.Text = "label1";
            // 
            // totalSharedWithLabel
            // 
            this.totalSharedWithLabel.AutoSize = true;
            this.totalSharedWithLabel.Location = new System.Drawing.Point(718, 459);
            this.totalSharedWithLabel.Name = "totalSharedWithLabel";
            this.totalSharedWithLabel.Size = new System.Drawing.Size(208, 21);
            this.totalSharedWithLabel.TabIndex = 10;
            this.totalSharedWithLabel.Text = "Total others shared with you:";
            // 
            // totalSharedWith
            // 
            this.totalSharedWith.AutoSize = true;
            this.totalSharedWith.Location = new System.Drawing.Point(932, 459);
            this.totalSharedWith.Name = "totalSharedWith";
            this.totalSharedWith.Size = new System.Drawing.Size(52, 21);
            this.totalSharedWith.TabIndex = 11;
            this.totalSharedWith.Text = "label1";
            // 
            // summingBySharedLabel
            // 
            this.summingBySharedLabel.AutoSize = true;
            this.summingBySharedLabel.Location = new System.Drawing.Point(428, 491);
            this.summingBySharedLabel.Name = "summingBySharedLabel";
            this.summingBySharedLabel.Size = new System.Drawing.Size(213, 21);
            this.summingBySharedLabel.TabIndex = 12;
            this.summingBySharedLabel.Text = "Summing By Shared Persons:";
            // 
            // sumByShared
            // 
            this.sumByShared.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sumByShared.Location = new System.Drawing.Point(428, 515);
            this.sumByShared.Name = "sumByShared";
            this.sumByShared.Size = new System.Drawing.Size(270, 168);
            this.sumByShared.TabIndex = 13;
            this.sumByShared.Text = "dataGridView1";
            // 
            // MonthlyReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1045, 906);
            this.Controls.Add(this.sumByShared);
            this.Controls.Add(this.summingBySharedLabel);
            this.Controls.Add(this.totalSharedWith);
            this.Controls.Add(this.totalSharedWithLabel);
            this.Controls.Add(this.totalSharedAmount);
            this.Controls.Add(this.totalSharedAmountLabel);
            this.Controls.Add(this.sumByCat);
            this.Controls.Add(this.sumByCatLabel);
            this.Controls.Add(this.totalExpense);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.dateRange);
            this.Controls.Add(this.inforLabel);
            this.Controls.Add(this.viewMonth);
            this.Cursor = System.Windows.Forms.Cursors.No;
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MonthlyReport";
            this.Text = "Summing By Categories:";
            ((System.ComponentModel.ISupportInitialize)(this.viewMonth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sumByCat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sumByShared)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView viewMonth;
        private System.Windows.Forms.Label inforLabel;
        private System.Windows.Forms.Label dateRange;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Label totalExpense;
        private System.Windows.Forms.Label sumByCatLabel;
        private System.Windows.Forms.DataGridView sumByCat;
        private System.Windows.Forms.Label totalSharedAmountLabel;
        private System.Windows.Forms.Label totalSharedAmount;
        private System.Windows.Forms.Label totalSharedWithLabel;
        private System.Windows.Forms.Label totalSharedWith;
        private System.Windows.Forms.Label summingBySharedLabel;
        private System.Windows.Forms.DataGridView sumByShared;
    }
}