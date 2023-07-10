namespace ExpenseTrackerUI
{
    partial class Monthly
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
            this.infoLabel = new System.Windows.Forms.Label();
            this.expenseStartRangeLabel = new System.Windows.Forms.Label();
            this.expenseStartRange = new System.Windows.Forms.DateTimePicker();
            this.expenseEndRangeLabel = new System.Windows.Forms.Label();
            this.expenseEndRange = new System.Windows.Forms.DateTimePicker();
            this.submitButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // infoLabel
            // 
            this.infoLabel.AutoSize = true;
            this.infoLabel.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.infoLabel.Location = new System.Drawing.Point(15, 41);
            this.infoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(681, 30);
            this.infoLabel.TabIndex = 0;
            this.infoLabel.Text = "Please input the following information to view your monthly expense:";
            // 
            // expenseStartRangeLabel
            // 
            this.expenseStartRangeLabel.AutoSize = true;
            this.expenseStartRangeLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.expenseStartRangeLabel.Location = new System.Drawing.Point(15, 113);
            this.expenseStartRangeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.expenseStartRangeLabel.Name = "expenseStartRangeLabel";
            this.expenseStartRangeLabel.Size = new System.Drawing.Size(78, 21);
            this.expenseStartRangeLabel.TabIndex = 1;
            this.expenseStartRangeLabel.Text = "Start Date";
            // 
            // expenseStartRange
            // 
            this.expenseStartRange.CalendarFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.expenseStartRange.Location = new System.Drawing.Point(123, 111);
            this.expenseStartRange.Margin = new System.Windows.Forms.Padding(4);
            this.expenseStartRange.Name = "expenseStartRange";
            this.expenseStartRange.Size = new System.Drawing.Size(256, 29);
            this.expenseStartRange.TabIndex = 2;
            // 
            // expenseEndRangeLabel
            // 
            this.expenseEndRangeLabel.AutoSize = true;
            this.expenseEndRangeLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.expenseEndRangeLabel.Location = new System.Drawing.Point(15, 165);
            this.expenseEndRangeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.expenseEndRangeLabel.Name = "expenseEndRangeLabel";
            this.expenseEndRangeLabel.Size = new System.Drawing.Size(72, 21);
            this.expenseEndRangeLabel.TabIndex = 3;
            this.expenseEndRangeLabel.Text = "End Date";
            // 
            // expenseEndRange
            // 
            this.expenseEndRange.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.expenseEndRange.Location = new System.Drawing.Point(123, 157);
            this.expenseEndRange.Margin = new System.Windows.Forms.Padding(4);
            this.expenseEndRange.Name = "expenseEndRange";
            this.expenseEndRange.Size = new System.Drawing.Size(256, 29);
            this.expenseEndRange.TabIndex = 4;
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(328, 206);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(78, 32);
            this.submitButton.TabIndex = 5;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(424, 206);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(70, 32);
            this.closeButton.TabIndex = 6;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // Monthly
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1029, 630);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.expenseEndRange);
            this.Controls.Add(this.expenseEndRangeLabel);
            this.Controls.Add(this.expenseStartRange);
            this.Controls.Add(this.expenseStartRangeLabel);
            this.Controls.Add(this.infoLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Monthly";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label infoLabel;
        private System.Windows.Forms.Label expenseStartRangeLabel;
        private System.Windows.Forms.DateTimePicker expenseStartRange;
        private System.Windows.Forms.Label expenseEndRangeLabel;
        private System.Windows.Forms.DateTimePicker expenseEndRange;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.Button closeButton;
    }
}