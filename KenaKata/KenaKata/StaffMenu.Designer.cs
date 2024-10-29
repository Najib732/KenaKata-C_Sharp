namespace KenaKata
{
    partial class StaffMenu
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
            ProductAdd = new Button();
            Sell = new Button();
            LogOutButton = new Button();
            SuspendLayout();
            // 
            // ProductAdd
            // 
            ProductAdd.Location = new Point(31, 46);
            ProductAdd.Name = "ProductAdd";
            ProductAdd.Size = new Size(141, 59);
            ProductAdd.TabIndex = 3;
            ProductAdd.Text = "Product Add";
            ProductAdd.UseVisualStyleBackColor = true;
            ProductAdd.Click += ProductAdd_Click;
            // 
            // Sell
            // 
            Sell.Location = new Point(31, 135);
            Sell.Name = "Sell";
            Sell.Size = new Size(141, 59);
            Sell.TabIndex = 2;
            Sell.Text = "Sell";
            Sell.UseVisualStyleBackColor = true;
            Sell.Click += Sell_Click;
            // 
            // LogOutButton
            // 
            LogOutButton.Location = new Point(31, 223);
            LogOutButton.Name = "LogOutButton";
            LogOutButton.Size = new Size(177, 74);
            LogOutButton.TabIndex = 4;
            LogOutButton.Text = "LogOut";
            LogOutButton.UseVisualStyleBackColor = true;
            LogOutButton.Click += LogOutButton_Click;
            // 
            // StaffMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1902, 1033);
            Controls.Add(LogOutButton);
            Controls.Add(ProductAdd);
            Controls.Add(Sell);
            Name = "StaffMenu";
            Text = "StaffMenu";
            Load += StaffMenu_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button ProductAdd;
        private Button Sell;
        private Button LogOutButton;
    }
}