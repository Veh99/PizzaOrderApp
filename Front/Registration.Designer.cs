namespace Front
{
    partial class Registration
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            loginRegBox = new TextBox();
            passwordRegBox = new TextBox();
            phoneRegBox = new TextBox();
            addressRegBox = new TextBox();
            label4 = new Label();
            label5 = new Label();
            signUpButton = new Button();
            label6 = new Label();
            signInFormButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(173, 19);
            label1.Name = "label1";
            label1.Size = new Size(101, 15);
            label1.TabIndex = 0;
            label1.Text = "Registration Form";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(89, 89);
            label2.Name = "label2";
            label2.Size = new Size(34, 15);
            label2.TabIndex = 1;
            label2.Text = "login";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(89, 133);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 2;
            label3.Text = "password";
            // 
            // loginRegBox
            // 
            loginRegBox.Location = new Point(173, 81);
            loginRegBox.Name = "loginRegBox";
            loginRegBox.Size = new Size(100, 23);
            loginRegBox.TabIndex = 3;
            // 
            // passwordRegBox
            // 
            passwordRegBox.Location = new Point(173, 125);
            passwordRegBox.Name = "passwordRegBox";
            passwordRegBox.Size = new Size(100, 23);
            passwordRegBox.TabIndex = 4;
            // 
            // phoneRegBox
            // 
            phoneRegBox.Location = new Point(173, 215);
            phoneRegBox.Name = "phoneRegBox";
            phoneRegBox.Size = new Size(100, 23);
            phoneRegBox.TabIndex = 8;
            // 
            // addressRegBox
            // 
            addressRegBox.Location = new Point(173, 171);
            addressRegBox.Name = "addressRegBox";
            addressRegBox.Size = new Size(100, 23);
            addressRegBox.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(89, 223);
            label4.Name = "label4";
            label4.Size = new Size(41, 15);
            label4.TabIndex = 6;
            label4.Text = "phone";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(89, 179);
            label5.Name = "label5";
            label5.Size = new Size(47, 15);
            label5.TabIndex = 5;
            label5.Text = "address";
            // 
            // signUpButton
            // 
            signUpButton.Location = new Point(182, 262);
            signUpButton.Name = "signUpButton";
            signUpButton.Size = new Size(75, 23);
            signUpButton.TabIndex = 9;
            signUpButton.Text = "Sign Up";
            signUpButton.UseVisualStyleBackColor = true;
            signUpButton.Click += signUpButton_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(129, 288);
            label6.Name = "label6";
            label6.Size = new Size(175, 15);
            label6.TabIndex = 10;
            label6.Text = "or if you have already signed up";
            // 
            // signInFormButton
            // 
            signInFormButton.Location = new Point(182, 306);
            signInFormButton.Name = "signInFormButton";
            signInFormButton.Size = new Size(75, 23);
            signInFormButton.TabIndex = 11;
            signInFormButton.Text = "Sign In";
            signInFormButton.UseVisualStyleBackColor = true;
            signInFormButton.Click += signInFormButton_Click;
            // 
            // Registration
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(444, 356);
            Controls.Add(signInFormButton);
            Controls.Add(label6);
            Controls.Add(signUpButton);
            Controls.Add(phoneRegBox);
            Controls.Add(addressRegBox);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(passwordRegBox);
            Controls.Add(loginRegBox);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            MaximumSize = new Size(460, 395);
            MinimumSize = new Size(460, 395);
            Name = "Registration";
            Text = "Registration";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox loginRegBox;
        private TextBox passwordRegBox;
        private TextBox phoneRegBox;
        private TextBox addressRegBox;
        private Label label4;
        private Label label5;
        private Button signUpButton;
        private Label label6;
        private Button signInFormButton;
    }
}