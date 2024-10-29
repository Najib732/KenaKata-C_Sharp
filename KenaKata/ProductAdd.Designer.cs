namespace KenaKata
{
    partial class ProductAdd
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
            this.MaindataGridView = new System.Windows.Forms.DataGridView();
            this.ProductIdLabel = new System.Windows.Forms.Label();
            this.Namelabel = new System.Windows.Forms.Label();
            this.BuyingPriceLabel = new System.Windows.Forms.Label();
            this.SellingPriceLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ProductIdTextBox = new System.Windows.Forms.TextBox();
            this.ProductNameTextBox = new System.Windows.Forms.TextBox();
            this.BuyingPriceTextBox = new System.Windows.Forms.TextBox();
            this.SellingPriceTextBox = new System.Windows.Forms.TextBox();
            this.StockQuantityTextBox = new System.Windows.Forms.TextBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.LastPurchasedQuantityTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.next = new System.Windows.Forms.Button();
            this.SaveDataToFile = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.MaindataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // MaindataGridView
            // 
            this.MaindataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MaindataGridView.Location = new System.Drawing.Point(37, 26);
            this.MaindataGridView.Name = "MaindataGridView";
            this.MaindataGridView.Size = new System.Drawing.Size(1121, 132);
            this.MaindataGridView.TabIndex = 0;
            this.MaindataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.MaindataGridView_CellContentClick);
            // 
            // ProductIdLabel
            // 
            this.ProductIdLabel.AutoSize = true;
            this.ProductIdLabel.Location = new System.Drawing.Point(116, 203);
            this.ProductIdLabel.Name = "ProductIdLabel";
            this.ProductIdLabel.Size = new System.Drawing.Size(58, 13);
            this.ProductIdLabel.TabIndex = 1;
            this.ProductIdLabel.Text = "Product ID";
            // 
            // Namelabel
            // 
            this.Namelabel.AutoSize = true;
            this.Namelabel.Location = new System.Drawing.Point(561, 203);
            this.Namelabel.Name = "Namelabel";
            this.Namelabel.Size = new System.Drawing.Size(75, 13);
            this.Namelabel.TabIndex = 2;
            this.Namelabel.Text = "Product Name";
            // 
            // BuyingPriceLabel
            // 
            this.BuyingPriceLabel.AutoSize = true;
            this.BuyingPriceLabel.Location = new System.Drawing.Point(116, 279);
            this.BuyingPriceLabel.Name = "BuyingPriceLabel";
            this.BuyingPriceLabel.Size = new System.Drawing.Size(66, 13);
            this.BuyingPriceLabel.TabIndex = 4;
            this.BuyingPriceLabel.Text = "Buying Price";
            // 
            // SellingPriceLabel
            // 
            this.SellingPriceLabel.AutoSize = true;
            this.SellingPriceLabel.Location = new System.Drawing.Point(561, 279);
            this.SellingPriceLabel.Name = "SellingPriceLabel";
            this.SellingPriceLabel.Size = new System.Drawing.Size(65, 13);
            this.SellingPriceLabel.TabIndex = 5;
            this.SellingPriceLabel.Text = "Selling Price";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(116, 372);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Stock Quantity";
            // 
            // ProductIdTextBox
            // 
            this.ProductIdTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ProductIdTextBox.Location = new System.Drawing.Point(119, 219);
            this.ProductIdTextBox.Multiline = true;
            this.ProductIdTextBox.Name = "ProductIdTextBox";
            this.ProductIdTextBox.Size = new System.Drawing.Size(254, 40);
            this.ProductIdTextBox.TabIndex = 7;
            this.ProductIdTextBox.TextChanged += new System.EventHandler(this.ProductIdTextBox_TextChanged);
            // 
            // ProductNameTextBox
            // 
            this.ProductNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ProductNameTextBox.Location = new System.Drawing.Point(564, 219);
            this.ProductNameTextBox.Multiline = true;
            this.ProductNameTextBox.Name = "ProductNameTextBox";
            this.ProductNameTextBox.Size = new System.Drawing.Size(313, 40);
            this.ProductNameTextBox.TabIndex = 8;
            this.ProductNameTextBox.TextChanged += new System.EventHandler(this.ProductNameTextBox_TextChanged);
            // 
            // BuyingPriceTextBox
            // 
            this.BuyingPriceTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BuyingPriceTextBox.Location = new System.Drawing.Point(119, 295);
            this.BuyingPriceTextBox.Multiline = true;
            this.BuyingPriceTextBox.Name = "BuyingPriceTextBox";
            this.BuyingPriceTextBox.Size = new System.Drawing.Size(254, 36);
            this.BuyingPriceTextBox.TabIndex = 10;
            this.BuyingPriceTextBox.TextChanged += new System.EventHandler(this.BuyingPriceTextBox_TextChanged);
            // 
            // SellingPriceTextBox
            // 
            this.SellingPriceTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SellingPriceTextBox.Location = new System.Drawing.Point(564, 295);
            this.SellingPriceTextBox.Multiline = true;
            this.SellingPriceTextBox.Name = "SellingPriceTextBox";
            this.SellingPriceTextBox.Size = new System.Drawing.Size(313, 36);
            this.SellingPriceTextBox.TabIndex = 11;
            this.SellingPriceTextBox.TextChanged += new System.EventHandler(this.SellingPriceTextBox_TextChanged);
            // 
            // StockQuantityTextBox
            // 
            this.StockQuantityTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.StockQuantityTextBox.Location = new System.Drawing.Point(119, 394);
            this.StockQuantityTextBox.Multiline = true;
            this.StockQuantityTextBox.Name = "StockQuantityTextBox";
            this.StockQuantityTextBox.Size = new System.Drawing.Size(254, 37);
            this.StockQuantityTextBox.TabIndex = 12;
            this.StockQuantityTextBox.TextChanged += new System.EventHandler(this.StockQuantityTextBox_TextChanged);
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(95, 513);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(185, 55);
            this.AddButton.TabIndex = 13;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // UpdateButton
            // 
            this.UpdateButton.Location = new System.Drawing.Point(313, 513);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(185, 55);
            this.UpdateButton.TabIndex = 14;
            this.UpdateButton.Text = "Update";
            this.UpdateButton.UseVisualStyleBackColor = true;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(526, 513);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(185, 55);
            this.DeleteButton.TabIndex = 15;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // LastPurchasedQuantityTextBox
            // 
            this.LastPurchasedQuantityTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LastPurchasedQuantityTextBox.Location = new System.Drawing.Point(564, 394);
            this.LastPurchasedQuantityTextBox.Multiline = true;
            this.LastPurchasedQuantityTextBox.Name = "LastPurchasedQuantityTextBox";
            this.LastPurchasedQuantityTextBox.Size = new System.Drawing.Size(313, 37);
            this.LastPurchasedQuantityTextBox.TabIndex = 16;
            this.LastPurchasedQuantityTextBox.TextChanged += new System.EventHandler(this.LastPurchasedQuantityTextBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(561, 372);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "LastPurchase";
            // 
            // next
            // 
            this.next.Location = new System.Drawing.Point(1024, 558);
            this.next.Name = "next";
            this.next.Size = new System.Drawing.Size(134, 55);
            this.next.TabIndex = 18;
            this.next.Text = "Next";
            this.next.UseVisualStyleBackColor = true;
            this.next.Click += new System.EventHandler(this.next_Click);
            // 
            // SaveDataToFile
            // 
            this.SaveDataToFile.Location = new System.Drawing.Point(983, 221);
            this.SaveDataToFile.Name = "SaveDataToFile";
            this.SaveDataToFile.Size = new System.Drawing.Size(104, 70);
            this.SaveDataToFile.TabIndex = 19;
            this.SaveDataToFile.Text = "save";
            this.SaveDataToFile.UseVisualStyleBackColor = true;
            this.SaveDataToFile.Click += new System.EventHandler(this.SaveDataToFile_Click);
            // 
            // ProductAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1185, 644);
            this.Controls.Add(this.SaveDataToFile);
            this.Controls.Add(this.next);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LastPurchasedQuantityTextBox);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.StockQuantityTextBox);
            this.Controls.Add(this.SellingPriceTextBox);
            this.Controls.Add(this.BuyingPriceTextBox);
            this.Controls.Add(this.ProductNameTextBox);
            this.Controls.Add(this.ProductIdTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.SellingPriceLabel);
            this.Controls.Add(this.BuyingPriceLabel);
            this.Controls.Add(this.Namelabel);
            this.Controls.Add(this.ProductIdLabel);
            this.Controls.Add(this.MaindataGridView);
            this.Name = "ProductAdd";
            this.Text = "ProductAdd";
            this.Load += new System.EventHandler(this.ProductAdd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MaindataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView MaindataGridView;
        private System.Windows.Forms.Label ProductIdLabel;
        private System.Windows.Forms.Label Namelabel;
        private System.Windows.Forms.Label BuyingPriceLabel;
        private System.Windows.Forms.Label SellingPriceLabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox ProductIdTextBox;
        private System.Windows.Forms.TextBox ProductNameTextBox;
        private System.Windows.Forms.TextBox BuyingPriceTextBox;
        private System.Windows.Forms.TextBox SellingPriceTextBox;
        private System.Windows.Forms.TextBox StockQuantityTextBox;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.TextBox LastPurchasedQuantityTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button next;
        private System.Windows.Forms.Button SaveDataToFile;
    }
}