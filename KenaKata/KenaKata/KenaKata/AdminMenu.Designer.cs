namespace KenaKata
{
    partial class AdminMenu
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
            Sell = new Button();
            ProductAdd = new Button();
            LogOutButton = new Button();
            StaffRegButton = new Button();
            SuspendLayout();
            // 
            // Sell
            // 
            Sell.Location = new Point(50, 146);
            Sell.Name = "Sell";
            Sell.Size = new Size(141, 59);
            Sell.TabIndex = 0;
            Sell.Text = "Sell";
            Sell.UseVisualStyleBackColor = true;
            Sell.Click += Sell_Click;
            // 
            // ProductAdd
            // 
            ProductAdd.Location = new Point(50, 59);
            ProductAdd.Name = "ProductAdd";
            ProductAdd.Size = new Size(141, 59);
            ProductAdd.TabIndex = 1;
            ProductAdd.Text = "Product Add";
            ProductAdd.UseVisualStyleBackColor = true;
            ProductAdd.Click += ProductAdd_Click;
            // 
            // LogOutButton
            // 
            LogOutButton.Location = new Point(50, 232);
            LogOutButton.Name = "LogOutButton";
            LogOutButton.Size = new Size(141, 59);
            LogOutButton.TabIndex = 2;
            LogOutButton.Text = "LogOut";
            LogOutButton.UseVisualStyleBackColor = true;
            LogOutButton.Click += LogOutButton_Click;
            // 
            // StaffRegButton
            // 
            StaffRegButton.Location = new Point(50, 327);
            StaffRegButton.Name = "StaffRegButton";
            StaffRegButton.Size = new Size(142, 59);
            StaffRegButton.TabIndex = 3;
            StaffRegButton.Text = "Staff Information";
            StaffRegButton.UseVisualStyleBackColor = true;
            // 
            // AdminMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1902, 1033);
            Controls.Add(StaffRegButton);
            Controls.Add(LogOutButton);
            Controls.Add(ProductAdd);
            Controls.Add(Sell);
            Name = "AdminMenu";
            Text = "AdminMenu";
            Load += AdminMenu_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button Sell;
        private Button ProductAdd;
        private Button LogOutButton;
        private Button StaffRegButton;
    }
}