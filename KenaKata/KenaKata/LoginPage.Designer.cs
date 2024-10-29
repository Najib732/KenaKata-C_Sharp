namespace KenaKata
{
    partial class LoginPage
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
            AdminButton = new Button();
            StaffButton = new Button();
            SuspendLayout();
            // 
            // AdminButton
            // 
            AdminButton.Location = new Point(72, 87);
            AdminButton.Name = "AdminButton";
            AdminButton.Size = new Size(262, 72);
            AdminButton.TabIndex = 0;
            AdminButton.Text = "Admin";
            AdminButton.UseVisualStyleBackColor = true;
            AdminButton.Click += AdminButton_Click;
            // 
            // StaffButton
            // 
            StaffButton.Location = new Point(72, 230);
            StaffButton.Name = "StaffButton";
            StaffButton.Size = new Size(262, 72);
            StaffButton.TabIndex = 1;
            StaffButton.Text = "Staff";
            StaffButton.UseVisualStyleBackColor = true;
            StaffButton.Click += StaffButton_Click;
            // 
            // LoginPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1902, 1033);
            Controls.Add(StaffButton);
            Controls.Add(AdminButton);
            Name = "LoginPage";
            Text = "LoginPage";
            Load += LoginPage_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button AdminButton;
        private Button StaffButton;
    }
}