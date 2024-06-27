namespace Front
{
    partial class UserMain
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
            accountSettingsButton = new Button();
            menuGrid = new DataGridView();
            CheckBox = new DataGridViewCheckBoxColumn();
            label1 = new Label();
            amountBox = new TextBox();
            button1 = new Button();
            chatBox = new ListBox();
            messageBox = new TextBox();
            SendMessage = new Button();
            ((System.ComponentModel.ISupportInitialize)menuGrid).BeginInit();
            SuspendLayout();
            // 
            // accountSettingsButton
            // 
            accountSettingsButton.Location = new Point(306, 19);
            accountSettingsButton.Name = "accountSettingsButton";
            accountSettingsButton.Size = new Size(131, 23);
            accountSettingsButton.TabIndex = 0;
            accountSettingsButton.Text = "Account Settings";
            accountSettingsButton.UseVisualStyleBackColor = true;
            accountSettingsButton.Click += accountSettingsButton_Click;
            // 
            // menuGrid
            // 
            menuGrid.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            menuGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            menuGrid.Columns.AddRange(new DataGridViewColumn[] { CheckBox });
            menuGrid.Location = new Point(12, 75);
            menuGrid.Name = "menuGrid";
            menuGrid.Size = new Size(425, 420);
            menuGrid.TabIndex = 3;
            // 
            // CheckBox
            // 
            CheckBox.HeaderText = "Cart";
            CheckBox.Name = "CheckBox";
            CheckBox.Resizable = DataGridViewTriState.True;
            CheckBox.ToolTipText = "Click to add";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(153, 543);
            label1.Name = "label1";
            label1.Size = new Size(80, 15);
            label1.TabIndex = 5;
            label1.Text = "Total amount:";
            // 
            // amountBox
            // 
            amountBox.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            amountBox.Location = new Point(239, 535);
            amountBox.Name = "amountBox";
            amountBox.ReadOnly = true;
            amountBox.Size = new Size(100, 23);
            amountBox.TabIndex = 6;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button1.Location = new Point(362, 535);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 7;
            button1.Text = "Make order";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // chatBox
            // 
            chatBox.FormattingEnabled = true;
            chatBox.ItemHeight = 15;
            chatBox.Location = new Point(523, 75);
            chatBox.Name = "chatBox";
            chatBox.Size = new Size(392, 424);
            chatBox.TabIndex = 8;
            // 
            // messageBox
            // 
            messageBox.Location = new Point(523, 535);
            messageBox.Name = "messageBox";
            messageBox.Size = new Size(354, 23);
            messageBox.TabIndex = 9;
            // 
            // SendMessage
            // 
            SendMessage.Location = new Point(883, 531);
            SendMessage.Name = "SendMessage";
            SendMessage.Size = new Size(32, 27);
            SendMessage.TabIndex = 10;
            SendMessage.Text = ">";
            SendMessage.UseVisualStyleBackColor = true;
            SendMessage.Click += SendMessage_Click;
            // 
            // UserMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(927, 594);
            Controls.Add(SendMessage);
            Controls.Add(messageBox);
            Controls.Add(chatBox);
            Controls.Add(button1);
            Controls.Add(amountBox);
            Controls.Add(label1);
            Controls.Add(menuGrid);
            Controls.Add(accountSettingsButton);
            Name = "UserMain";
            Text = "UserPanel";
            Load += UserMain_Load;
            ((System.ComponentModel.ISupportInitialize)menuGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button accountSettingsButton;
        private DataGridView menuGrid;
        private Label label1;
        private TextBox amountBox;
        private Button button1;
        private DataGridViewCheckBoxColumn CheckBox;
        private ListBox chatBox;
        private TextBox messageBox;
        private Button SendMessage;
    }
}