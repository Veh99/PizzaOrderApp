namespace Front
{
    partial class AccountSettings
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
            backButton = new Button();
            logOutButton = new Button();
            label1 = new Label();
            login = new Label();
            adress = new Label();
            phone = new Label();
            password = new Label();
            loginBox = new TextBox();
            addressBox = new TextBox();
            phoneBox = new TextBox();
            passwordBox = new TextBox();
            changeData = new Button();
            orderGrid = new DataGridView();
            PizzasList = new DataGridViewTextBoxColumn();
            Price = new DataGridViewTextBoxColumn();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)orderGrid).BeginInit();
            SuspendLayout();
            // 
            // backButton
            // 
            backButton.Location = new Point(12, 452);
            backButton.Name = "backButton";
            backButton.Size = new Size(75, 23);
            backButton.TabIndex = 0;
            backButton.Text = "<<back";
            backButton.UseVisualStyleBackColor = true;
            backButton.Click += backButton_Click;
            // 
            // logOutButton
            // 
            logOutButton.BackColor = Color.Brown;
            logOutButton.Location = new Point(415, 452);
            logOutButton.Name = "logOutButton";
            logOutButton.Size = new Size(75, 23);
            logOutButton.TabIndex = 1;
            logOutButton.Text = "Log out";
            logOutButton.UseVisualStyleBackColor = false;
            logOutButton.Click += logOutButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(211, 9);
            label1.Name = "label1";
            label1.Size = new Size(118, 15);
            label1.TabIndex = 2;
            label1.Text = "Account Information";
            // 
            // login
            // 
            login.AutoSize = true;
            login.Location = new Point(12, 44);
            login.Name = "login";
            login.Size = new Size(37, 15);
            login.TabIndex = 3;
            login.Text = "Login";
            // 
            // adress
            // 
            adress.AutoSize = true;
            adress.Location = new Point(12, 68);
            adress.Name = "adress";
            adress.Size = new Size(49, 15);
            adress.TabIndex = 4;
            adress.Text = "Address";
            // 
            // phone
            // 
            phone.AutoSize = true;
            phone.Location = new Point(12, 93);
            phone.Name = "phone";
            phone.Size = new Size(41, 15);
            phone.TabIndex = 5;
            phone.Text = "Phone";
            // 
            // password
            // 
            password.AutoSize = true;
            password.Location = new Point(12, 117);
            password.Name = "password";
            password.Size = new Size(57, 15);
            password.TabIndex = 6;
            password.Text = "Password";
            // 
            // loginBox
            // 
            loginBox.Location = new Point(81, 36);
            loginBox.Name = "loginBox";
            loginBox.Size = new Size(409, 23);
            loginBox.TabIndex = 7;
            // 
            // addressBox
            // 
            addressBox.Location = new Point(81, 60);
            addressBox.Name = "addressBox";
            addressBox.Size = new Size(409, 23);
            addressBox.TabIndex = 8;
            // 
            // phoneBox
            // 
            phoneBox.Location = new Point(81, 85);
            phoneBox.Name = "phoneBox";
            phoneBox.Size = new Size(409, 23);
            phoneBox.TabIndex = 9;
            // 
            // passwordBox
            // 
            passwordBox.Location = new Point(81, 109);
            passwordBox.Name = "passwordBox";
            passwordBox.Size = new Size(409, 23);
            passwordBox.TabIndex = 10;
            // 
            // changeData
            // 
            changeData.Location = new Point(415, 138);
            changeData.Name = "changeData";
            changeData.Size = new Size(75, 23);
            changeData.TabIndex = 11;
            changeData.Text = "Edit";
            changeData.UseVisualStyleBackColor = true;
            changeData.Click += changeData_Click;
            // 
            // orderGrid
            // 
            orderGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            orderGrid.Columns.AddRange(new DataGridViewColumn[] { PizzasList, Price });
            orderGrid.Location = new Point(12, 194);
            orderGrid.Name = "orderGrid";
            orderGrid.Size = new Size(478, 217);
            orderGrid.TabIndex = 13;
            orderGrid.CellContentClick += orderGrid_CellContentClick;
            // 
            // PizzasList
            // 
            PizzasList.HeaderText = "PizzasList";
            PizzasList.Name = "PizzasList";
            PizzasList.ReadOnly = true;
            // 
            // Price
            // 
            Price.HeaderText = "Price";
            Price.Name = "Price";
            Price.ReadOnly = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(243, 165);
            label2.Name = "label2";
            label2.Size = new Size(55, 15);
            label2.TabIndex = 14;
            label2.Text = "Order list";
            // 
            // AccountSettings
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(529, 487);
            Controls.Add(label2);
            Controls.Add(orderGrid);
            Controls.Add(changeData);
            Controls.Add(passwordBox);
            Controls.Add(phoneBox);
            Controls.Add(addressBox);
            Controls.Add(loginBox);
            Controls.Add(password);
            Controls.Add(phone);
            Controls.Add(adress);
            Controls.Add(login);
            Controls.Add(label1);
            Controls.Add(logOutButton);
            Controls.Add(backButton);
            MaximumSize = new Size(545, 526);
            MinimumSize = new Size(545, 526);
            Name = "AccountSettings";
            Text = "AccountSettings";
            Load += AccountSettings_Load;
            ((System.ComponentModel.ISupportInitialize)orderGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button backButton;
        private Button logOutButton;
        private Label label1;
        private Label login;
        private Label adress;
        private Label phone;
        private Label password;
        private TextBox loginBox;
        private TextBox addressBox;
        private TextBox phoneBox;
        private TextBox passwordBox;
        private Button changeData;
        private DataGridView orderGrid;
        private Label label2;
        private DataGridViewTextBoxColumn PizzasList;
        private DataGridViewTextBoxColumn Price;
    }
}