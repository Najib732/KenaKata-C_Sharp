
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
            SearchTextBox = new TextBox();
            SearchButton = new Button();
            UpdateButton = new Button();
            DeleteButton = new Button();
            AddButton = new Button();
            Namelabel = new Label();
            ProductIdLabel = new Label();
            ProductQuantityLabel = new Label();
            SellingPriceLabel = new Label();
            BuyingPriceLabel = new Label();
            BackButton = new Button();
            ProductIdTextBox = new TextBox();
            ProductSellingPriceTextBox = new TextBox();
            ProductNameTextBox = new TextBox();
            ProductQuantityTextBox = new TextBox();
            ProductBuyingPriceTextBox = new TextBox();
            MaindataGridView = new DataGridView();
            SellingProductQuantityTextBox = new TextBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)MaindataGridView).BeginInit();
            SuspendLayout();
            // 
            // SearchTextBox
            // 
            SearchTextBox.BorderStyle = BorderStyle.FixedSingle;
            SearchTextBox.Location = new Point(464, 55);
            SearchTextBox.Multiline = true;
            SearchTextBox.Name = "SearchTextBox";
            SearchTextBox.Size = new Size(390, 63);
            SearchTextBox.TabIndex = 1;
            // 
            // SearchButton
            // 
            SearchButton.Location = new Point(882, 55);
            SearchButton.Name = "SearchButton";
            SearchButton.Size = new Size(92, 63);
            SearchButton.TabIndex = 2;
            SearchButton.Text = "Search";
            SearchButton.UseVisualStyleBackColor = true;
            // 
            // UpdateButton
            // 
            UpdateButton.Location = new Point(659, 807);
            UpdateButton.Name = "UpdateButton";
            UpdateButton.Size = new Size(242, 77);
            UpdateButton.TabIndex = 8;
            UpdateButton.Text = "Update";
            UpdateButton.UseVisualStyleBackColor = true;
            UpdateButton.Click += UpdateButton_Click;
            // 
            // DeleteButton
            // 
            DeleteButton.Location = new Point(927, 807);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(202, 77);
            DeleteButton.TabIndex = 9;
            DeleteButton.Text = "Delete";
            DeleteButton.UseVisualStyleBackColor = true;
            DeleteButton.Click += DeleteButton_Click;
            // 
            // AddButton
            // 
            AddButton.Location = new Point(432, 807);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(206, 77);
            AddButton.TabIndex = 10;
            AddButton.Text = "Add";
            AddButton.UseVisualStyleBackColor = true;
            AddButton.Click += AddButton_Click;
            // 
            // Namelabel
            // 
            Namelabel.AutoSize = true;
            Namelabel.Location = new Point(773, 512);
            Namelabel.Name = "Namelabel";
            Namelabel.Size = new Size(104, 20);
            Namelabel.TabIndex = 11;
            Namelabel.Text = "Product Name";
            // 
            // ProductIdLabel
            // 
            ProductIdLabel.AutoSize = true;
            ProductIdLabel.Location = new Point(363, 512);
            ProductIdLabel.Name = "ProductIdLabel";
            ProductIdLabel.Size = new Size(79, 20);
            ProductIdLabel.TabIndex = 12;
            ProductIdLabel.Text = "Product ID";
            // 
            // ProductQuantityLabel
            // 
            ProductQuantityLabel.AutoSize = true;
            ProductQuantityLabel.Location = new Point(362, 603);
            ProductQuantityLabel.Name = "ProductQuantityLabel";
            ProductQuantityLabel.Size = new Size(120, 20);
            ProductQuantityLabel.TabIndex = 13;
            ProductQuantityLabel.Text = "Product Quantity";
            // 
            // SellingPriceLabel
            // 
            SellingPriceLabel.AutoSize = true;
            SellingPriceLabel.Location = new Point(363, 680);
            SellingPriceLabel.Name = "SellingPriceLabel";
            SellingPriceLabel.Size = new Size(90, 20);
            SellingPriceLabel.TabIndex = 14;
            SellingPriceLabel.Text = "Selling Price";
            // 
            // BuyingPriceLabel
            // 
            BuyingPriceLabel.AutoSize = true;
            BuyingPriceLabel.Location = new Point(772, 598);
            BuyingPriceLabel.Name = "BuyingPriceLabel";
            BuyingPriceLabel.Size = new Size(90, 20);
            BuyingPriceLabel.TabIndex = 15;
            BuyingPriceLabel.Text = "Buying Price";
            // 
            // BackButton
            // 
            BackButton.Location = new Point(12, 12);
            BackButton.Name = "BackButton";
            BackButton.Size = new Size(52, 52);
            BackButton.TabIndex = 16;
            BackButton.Text = "Back";
            BackButton.UseVisualStyleBackColor = true;
            BackButton.Click += BackButton_Click;
            // 
            // ProductIdTextBox
            // 
            ProductIdTextBox.BorderStyle = BorderStyle.FixedSingle;
            ProductIdTextBox.Location = new Point(363, 550);
            ProductIdTextBox.Name = "ProductIdTextBox";
            ProductIdTextBox.Size = new Size(227, 27);
            ProductIdTextBox.TabIndex = 17;
            ProductIdTextBox.TextChanged += ProductIdTextBox_TextChanged;
            // 
            // ProductSellingPriceTextBox
            // 
            ProductSellingPriceTextBox.BorderStyle = BorderStyle.FixedSingle;
            ProductSellingPriceTextBox.Location = new Point(363, 716);
            ProductSellingPriceTextBox.Multiline = true;
            ProductSellingPriceTextBox.Name = "ProductSellingPriceTextBox";
            ProductSellingPriceTextBox.Size = new Size(227, 27);
            ProductSellingPriceTextBox.TabIndex = 21;
            ProductSellingPriceTextBox.TextChanged += ProductSellingPriceTextBox_TextChanged;
            // 
            // ProductNameTextBox
            // 
            ProductNameTextBox.BorderStyle = BorderStyle.FixedSingle;
            ProductNameTextBox.Location = new Point(773, 535);
            ProductNameTextBox.Name = "ProductNameTextBox";
            ProductNameTextBox.Size = new Size(173, 27);
            ProductNameTextBox.TabIndex = 22;
            ProductNameTextBox.TextChanged += ProductNameTextBox_TextChanged;
            // 
            // ProductQuantityTextBox
            // 
            ProductQuantityTextBox.BorderStyle = BorderStyle.FixedSingle;
            ProductQuantityTextBox.Location = new Point(363, 626);
            ProductQuantityTextBox.Multiline = true;
            ProductQuantityTextBox.Name = "ProductQuantityTextBox";
            ProductQuantityTextBox.Size = new Size(227, 27);
            ProductQuantityTextBox.TabIndex = 23;
            ProductQuantityTextBox.TextChanged += ProductQuantityTextBox_TextChanged;
            // 
            // ProductBuyingPriceTextBox
            // 
            ProductBuyingPriceTextBox.BorderStyle = BorderStyle.FixedSingle;
            ProductBuyingPriceTextBox.Location = new Point(773, 621);
            ProductBuyingPriceTextBox.Multiline = true;
            ProductBuyingPriceTextBox.Name = "ProductBuyingPriceTextBox";
            ProductBuyingPriceTextBox.Size = new Size(173, 27);
            ProductBuyingPriceTextBox.TabIndex = 24;
            ProductBuyingPriceTextBox.TextChanged += ProductBuyingPriceTextBox_TextChanged;
            // 
            // MaindataGridView
            // 
            MaindataGridView.AllowUserToResizeColumns = false;
            MaindataGridView.AllowUserToResizeRows = false;
            MaindataGridView.BackgroundColor = SystemColors.ButtonHighlight;
            MaindataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            MaindataGridView.Location = new Point(12, 171);
            MaindataGridView.Name = "MaindataGridView";
            MaindataGridView.ReadOnly = true;
            MaindataGridView.RowHeadersWidth = 51;
            MaindataGridView.Size = new Size(1853, 299);
            MaindataGridView.TabIndex = 0;
            MaindataGridView.CellContentClick += MaindataGridView_CellContentClick;
            // 
            // SellingProductQuantityTextBox
            // 
            SellingProductQuantityTextBox.BorderStyle = BorderStyle.FixedSingle;
            SellingProductQuantityTextBox.Location = new Point(762, 709);
            SellingProductQuantityTextBox.Multiline = true;
            SellingProductQuantityTextBox.Name = "SellingProductQuantityTextBox";
            SellingProductQuantityTextBox.Size = new Size(245, 34);
            SellingProductQuantityTextBox.TabIndex = 25;
            SellingProductQuantityTextBox.TextChanged += SellingProductQuantityTextBox_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(762, 686);
            label1.Name = "label1";
            label1.Size = new Size(161, 20);
            label1.TabIndex = 26;
            label1.Text = "SellingProductQuantity";
            // 
            // ProductAdd
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1902, 1033);
            Controls.Add(label1);
            Controls.Add(SellingProductQuantityTextBox);
            Controls.Add(ProductBuyingPriceTextBox);
            Controls.Add(ProductQuantityTextBox);
            Controls.Add(ProductNameTextBox);
            Controls.Add(ProductSellingPriceTextBox);
            Controls.Add(ProductIdTextBox);
            Controls.Add(BackButton);
            Controls.Add(BuyingPriceLabel);
            Controls.Add(SellingPriceLabel);
            Controls.Add(ProductQuantityLabel);
            Controls.Add(ProductIdLabel);
            Controls.Add(Namelabel);
            Controls.Add(AddButton);
            Controls.Add(DeleteButton);
            Controls.Add(UpdateButton);
            Controls.Add(SearchButton);
            Controls.Add(SearchTextBox);
            Controls.Add(MaindataGridView);
            Name = "ProductAdd";
            Text = " ";
            Load += ProductAdd_Load;
            ((System.ComponentModel.ISupportInitialize)MaindataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox SearchTextBox;
        private Button SearchButton;
        private Button UpdateButton;
        private Button DeleteButton;
        private Button AddButton;
        private Label Namelabel;
        private Label ProductIdLabel;
        private Label ProductQuantityLabel;
        private Label SellingPriceLabel;
        private Label BuyingPriceLabel;
        private Button BackButton;
        private TextBox ProductIdTextBox;
        private TextBox ProductSellingPriceTextBox;
        private TextBox ProductNameTextBox;
        private TextBox ProductQuantityTextBox;
        private TextBox ProductBuyingPriceTextBox;
        private DataGridView MaindataGridView;
        private TextBox SellingProductQuantityTextBox;
        private Label label1;
    }
}