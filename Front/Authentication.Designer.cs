namespace Front
{
    partial class Authentication
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
            signInButton = new Button();
            loginTextBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            passwordTextBox = new TextBox();
            SuspendLayout();
            // 
            // signInButton
            // 
            signInButton.Location = new Point(103, 195);
            signInButton.Name = "signInButton";
            signInButton.Size = new Size(75, 23);
            signInButton.TabIndex = 0;
            signInButton.Text = "Sign in";
            signInButton.UseVisualStyleBackColor = true;
            signInButton.Click += signInButton_Click;
            // 
            // loginTextBox
            // 
            loginTextBox.Location = new Point(75, 68);
            loginTextBox.Name = "loginTextBox";
            loginTextBox.Size = new Size(140, 23);
            loginTextBox.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Location = new Point(75, 9);
            label1.Name = "label1";
            label1.Size = new Size(107, 15);
            label1.TabIndex = 3;
            label1.Text = "Enter your account";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(8, 76);
            label2.Name = "label2";
            label2.Size = new Size(34, 15);
            label2.TabIndex = 4;
            label2.Text = "login";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(8, 105);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 5;
            label3.Text = "password";
            // 
            // passwordTextBox
            // 
            passwordTextBox.Location = new Point(75, 97);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.PasswordChar = '●';
            passwordTextBox.Size = new Size(140, 23);
            passwordTextBox.TabIndex = 6;
            // 
            // Authentication
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(251, 249);
            Controls.Add(passwordTextBox);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(loginTextBox);
            Controls.Add(signInButton);
            MaximumSize = new Size(267, 288);
            MinimumSize = new Size(267, 288);
            Name = "Authentication";
            Text = "Authentication";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button signInButton;
        private TextBox loginTextBox;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox passwordTextBox;
    }
}
