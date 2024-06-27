namespace Front
{
    partial class UserCRUD
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
            label4 = new Label();
            loginBox = new TextBox();
            addressBox = new TextBox();
            phoneBox = new TextBox();
            passwordBox = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(37, 15);
            label1.TabIndex = 0;
            label1.Text = "Login";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 36);
            label2.Name = "label2";
            label2.Size = new Size(49, 15);
            label2.TabIndex = 1;
            label2.Text = "Address";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 61);
            label3.Name = "label3";
            label3.Size = new Size(41, 15);
            label3.TabIndex = 3;
            label3.Text = "Phone";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 85);
            label4.Name = "label4";
            label4.Size = new Size(57, 15);
            label4.TabIndex = 2;
            label4.Text = "Password";
            // 
            // loginBox
            // 
            loginBox.Location = new Point(90, 1);
            loginBox.Name = "loginBox";
            loginBox.Size = new Size(141, 23);
            loginBox.TabIndex = 4;
            // 
            // addressBox
            // 
            addressBox.Location = new Point(90, 28);
            addressBox.Name = "addressBox";
            addressBox.Size = new Size(141, 23);
            addressBox.TabIndex = 5;
            // 
            // phoneBox
            // 
            phoneBox.Location = new Point(90, 53);
            phoneBox.Name = "phoneBox";
            phoneBox.Size = new Size(141, 23);
            phoneBox.TabIndex = 6;
            // 
            // passwordBox
            // 
            passwordBox.Location = new Point(90, 77);
            passwordBox.Name = "passwordBox";
            passwordBox.Size = new Size(141, 23);
            passwordBox.TabIndex = 7;
            // 
            // button1
            // 
            button1.Location = new Point(93, 114);
            button1.Name = "button1";
            button1.Size = new Size(75, 20);
            button1.TabIndex = 8;
            button1.Text = "Edit";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(12, 220);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 9;
            button2.Text = "<<back";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(12, 114);
            button3.Name = "button3";
            button3.Size = new Size(75, 20);
            button3.TabIndex = 10;
            button3.Text = "Delete";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(184, 111);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 11;
            button4.Text = "Create";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // UserCRUD
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(284, 261);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(passwordBox);
            Controls.Add(phoneBox);
            Controls.Add(addressBox);
            Controls.Add(loginBox);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            MaximumSize = new Size(300, 300);
            MinimumSize = new Size(300, 300);
            Name = "UserCRUD";
            Text = "UserCRUD";
            Load += UserCRUD_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox loginBox;
        private TextBox addressBox;
        private TextBox phoneBox;
        private TextBox passwordBox;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
    }
}