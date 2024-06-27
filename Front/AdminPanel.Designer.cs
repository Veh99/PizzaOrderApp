namespace Front
{
    partial class AdminPanel
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
            usersGrid = new DataGridView();
            EditUser = new DataGridViewButtonColumn();
            menuGrid = new DataGridView();
            EditMenu = new DataGridViewButtonColumn();
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            ordersGrid = new DataGridView();
            Edit = new DataGridViewButtonColumn();
            PizzaList = new DataGridViewTextBoxColumn();
            Total = new DataGridViewTextBoxColumn();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)usersGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)menuGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ordersGrid).BeginInit();
            SuspendLayout();
            // 
            // usersGrid
            // 
            usersGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            usersGrid.Columns.AddRange(new DataGridViewColumn[] { EditUser });
            usersGrid.Location = new Point(12, 38);
            usersGrid.Margin = new Padding(10, 3, 10, 3);
            usersGrid.Name = "usersGrid";
            usersGrid.Size = new Size(387, 308);
            usersGrid.TabIndex = 0;
            usersGrid.CellContentClick += usersGrid_CellContentClick;
            // 
            // EditUser
            // 
            EditUser.HeaderText = "Edit";
            EditUser.Name = "EditUser";
            // 
            // menuGrid
            // 
            menuGrid.Anchor = AnchorStyles.Top;
            menuGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            menuGrid.Columns.AddRange(new DataGridViewColumn[] { EditMenu });
            menuGrid.Location = new Point(419, 38);
            menuGrid.Margin = new Padding(10, 3, 10, 3);
            menuGrid.Name = "menuGrid";
            menuGrid.Size = new Size(383, 308);
            menuGrid.TabIndex = 2;
            menuGrid.CellContentClick += menuGrid_CellContentClick;
            // 
            // EditMenu
            // 
            EditMenu.HeaderText = "Edit";
            EditMenu.Name = "EditMenu";
            EditMenu.Resizable = DataGridViewTriState.True;
            EditMenu.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(178, 20);
            label1.Name = "label1";
            label1.Size = new Size(35, 15);
            label1.TabIndex = 3;
            label1.Text = "Users";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.Location = new Point(574, 20);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 4;
            label2.Text = "Menu";
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            button1.Location = new Point(12, 351);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 5;
            button1.Text = "<<back";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // ordersGrid
            // 
            ordersGrid.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            ordersGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ordersGrid.Columns.AddRange(new DataGridViewColumn[] { Edit, PizzaList, Total });
            ordersGrid.Location = new Point(821, 38);
            ordersGrid.Margin = new Padding(10, 3, 10, 3);
            ordersGrid.Name = "ordersGrid";
            ordersGrid.Size = new Size(385, 308);
            ordersGrid.TabIndex = 6;
            ordersGrid.CellContentClick += ordersGrid_CellContentClick;
            // 
            // Edit
            // 
            Edit.HeaderText = "Edit Status";
            Edit.Name = "Edit";
            // 
            // PizzaList
            // 
            PizzaList.HeaderText = "PizzaList";
            PizzaList.Name = "PizzaList";
            // 
            // Total
            // 
            Total.HeaderText = "Total";
            Total.Name = "Total";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Location = new Point(969, 20);
            label3.Name = "label3";
            label3.Size = new Size(42, 15);
            label3.TabIndex = 7;
            label3.Text = "Orders";
            // 
            // AdminPanel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1234, 386);
            Controls.Add(label3);
            Controls.Add(ordersGrid);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(menuGrid);
            Controls.Add(usersGrid);
            MaximumSize = new Size(1250, 425);
            MinimumSize = new Size(1215, 425);
            Name = "AdminPanel";
            Text = "AdminPanel";
            Load += AdminPanel_Load;
            ((System.ComponentModel.ISupportInitialize)usersGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)menuGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)ordersGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView usersGrid;
        private DataGridView menuGrid;
        private DataGridViewButtonColumn EditUser;
        private Label label1;
        private Label label2;
        private Button button1;
        private DataGridView ordersGrid;
        private DataGridViewButtonColumn Edit;
        private DataGridViewTextBoxColumn PizzaList;
        private DataGridViewTextBoxColumn Total;
        private DataGridViewButtonColumn EditMenu;
        private Label label3;
    }
}