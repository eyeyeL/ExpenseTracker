namespace ExpenseTrackerUI
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.submitButton = new System.Windows.Forms.Button();
            this.newWelcome = new System.Windows.Forms.Label();
            this.usernameInput = new System.Windows.Forms.TextBox();
            this.choiceLabel = new System.Windows.Forms.Label();
            this.userChoices = new System.Windows.Forms.ComboBox();
            this.enterChoice = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.AutoSize = true;
            this.welcomeLabel.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.welcomeLabel.Location = new System.Drawing.Point(150, 26);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(435, 40);
            this.welcomeLabel.TabIndex = 0;
            this.welcomeLabel.Text = "Welcome to the Expense Tracker!";
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.usernameLabel.Location = new System.Drawing.Point(25, 102);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(250, 25);
            this.usernameLabel.TabIndex = 1;
            this.usernameLabel.Text = "Please input your username:";
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(509, 100);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(76, 25);
            this.submitButton.TabIndex = 3;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // newWelcome
            // 
            this.newWelcome.AutoSize = true;
            this.newWelcome.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.newWelcome.Location = new System.Drawing.Point(150, 29);
            this.newWelcome.Name = "newWelcome";
            this.newWelcome.Size = new System.Drawing.Size(90, 37);
            this.newWelcome.TabIndex = 4;
            this.newWelcome.Text = "label1";
            // 
            // usernameInput
            // 
            this.usernameInput.Location = new System.Drawing.Point(281, 102);
            this.usernameInput.Name = "usernameInput";
            this.usernameInput.Size = new System.Drawing.Size(212, 23);
            this.usernameInput.TabIndex = 2;
            this.usernameInput.TextChanged += new System.EventHandler(this.usernameInput_TextChanged);
            this.usernameInput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.usernameInput_KeyDown);
            // 
            // choiceLabel
            // 
            this.choiceLabel.AutoSize = true;
            this.choiceLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.choiceLabel.Location = new System.Drawing.Point(25, 102);
            this.choiceLabel.Name = "choiceLabel";
            this.choiceLabel.Size = new System.Drawing.Size(357, 25);
            this.choiceLabel.TabIndex = 5;
            this.choiceLabel.Text = "Please choose what you would like to do:";
            // 
            // userChoices
            // 
            this.userChoices.FormattingEnabled = true;
            this.userChoices.Location = new System.Drawing.Point(119, 140);
            this.userChoices.Name = "userChoices";
            this.userChoices.Size = new System.Drawing.Size(121, 23);
            this.userChoices.TabIndex = 6;
            // 
            // enterChoice
            // 
            this.enterChoice.Location = new System.Drawing.Point(281, 139);
            this.enterChoice.Name = "enterChoice";
            this.enterChoice.Size = new System.Drawing.Size(75, 23);
            this.enterChoice.TabIndex = 7;
            this.enterChoice.Text = "Enter";
            this.enterChoice.UseVisualStyleBackColor = true;
            this.enterChoice.Click += new System.EventHandler(this.enterChoice_Click);
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(615, 186);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(75, 23);
            this.closeButton.TabIndex = 8;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.enterChoice);
            this.Controls.Add(this.userChoices);
            this.Controls.Add(this.choiceLabel);
            this.Controls.Add(this.newWelcome);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.usernameInput);
            this.Controls.Add(this.usernameLabel);
            this.Controls.Add(this.welcomeLabel);
            this.Name = "Form1";
            this.Text = "Expense Tracker";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label welcomeLabel;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.Label newWelcome;
        private System.Windows.Forms.TextBox usernameInput;
        private System.Windows.Forms.Label choiceLabel;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox userChoices;
        private System.Windows.Forms.Button enterChoice;
        private System.Windows.Forms.Button closeButton;
    }
}

