namespace KenaKata
{
    partial class Sell
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sell));
            SearchButton = new Button();
            SearchBox = new TextBox();
            MaindataGridView = new DataGridView();
            IdTextBox = new TextBox();
            QuantityTextBox = new TextBox();
            Idlabel = new Label();
            Qusntitylabel = new Label();
            AddButton = new Button();
            panel1 = new Panel();
            panel2 = new Panel();
            PriceTextBox2 = new TextBox();
            QuantityTextBox2 = new TextBox();
            IdTextBox2 = new TextBox();
            ConfirmButton = new Button();
            DeleteButton = new Button();
            UpdateButton = new Button();
            ConfirmDataGridView = new DataGridView();
            TotalSell = new Label();
            Total = new Label();
            BackButton = new Button();
            ((System.ComponentModel.ISupportInitialize)MaindataGridView).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ConfirmDataGridView).BeginInit();
            SuspendLayout();
            // 
            // SearchButton
            // 
            SearchButton.Image = (Image)resources.GetObject("SearchButton.Image");
            SearchButton.Location = new Point(629, 26);
            SearchButton.Name = "SearchButton";
            SearchButton.Size = new Size(53, 46);
            SearchButton.TabIndex = 1;
            SearchButton.UseVisualStyleBackColor = true;
            // 
            // SearchBox
            // 
            SearchBox.BorderStyle = BorderStyle.FixedSingle;
            SearchBox.Location = new Point(272, 26);
            SearchBox.Multiline = true;
            SearchBox.Name = "SearchBox";
            SearchBox.Size = new Size(342, 50);
            SearchBox.TabIndex = 0;
            SearchBox.Text = "ENTER YOU DATA";
            // 
            // MaindataGridView
            // 
            MaindataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            MaindataGridView.Location = new Point(43, 115);
            MaindataGridView.Name = "MaindataGridView";
            MaindataGridView.RowHeadersWidth = 51;
            MaindataGridView.Size = new Size(870, 341);
            MaindataGridView.TabIndex = 2;
            // 
            // IdTextBox
            // 
            IdTextBox.BorderStyle = BorderStyle.FixedSingle;
            IdTextBox.Location = new Point(75, 534);
            IdTextBox.Name = "IdTextBox";
            IdTextBox.Size = new Size(346, 27);
            IdTextBox.TabIndex = 3;
            // 
            // QuantityTextBox
            // 
            QuantityTextBox.BorderStyle = BorderStyle.FixedSingle;
            QuantityTextBox.Location = new Point(75, 612);
            QuantityTextBox.Name = "QuantityTextBox";
            QuantityTextBox.Size = new Size(346, 27);
            QuantityTextBox.TabIndex = 4;
            // 
            // Idlabel
            // 
            Idlabel.AutoSize = true;
            Idlabel.Location = new Point(75, 511);
            Idlabel.Name = "Idlabel";
            Idlabel.Size = new Size(77, 20);
            Idlabel.TabIndex = 5;
            Idlabel.Text = "Product Id";
            // 
            // Qusntitylabel
            // 
            Qusntitylabel.AutoSize = true;
            Qusntitylabel.Location = new Point(75, 589);
            Qusntitylabel.Name = "Qusntitylabel";
            Qusntitylabel.Size = new Size(120, 20);
            Qusntitylabel.TabIndex = 6;
            Qusntitylabel.Text = "Product Quantity";
            // 
            // AddButton
            // 
            AddButton.Location = new Point(453, 699);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(121, 47);
            AddButton.TabIndex = 7;
            AddButton.Text = "ADD";
            AddButton.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Controls.Add(AddButton);
            panel1.Controls.Add(Qusntitylabel);
            panel1.Controls.Add(Idlabel);
            panel1.Controls.Add(QuantityTextBox);
            panel1.Controls.Add(IdTextBox);
            panel1.Controls.Add(MaindataGridView);
            panel1.Controls.Add(SearchBox);
            panel1.Controls.Add(SearchButton);
            panel1.Location = new Point(60, 147);
            panel1.Name = "panel1";
            panel1.Size = new Size(960, 848);
            panel1.TabIndex = 2;
            panel1.Paint += panel1_Paint;
            // 
            // panel2
            // 
            panel2.Controls.Add(PriceTextBox2);
            panel2.Controls.Add(QuantityTextBox2);
            panel2.Controls.Add(IdTextBox2);
            panel2.Controls.Add(ConfirmButton);
            panel2.Controls.Add(DeleteButton);
            panel2.Controls.Add(UpdateButton);
            panel2.Controls.Add(ConfirmDataGridView);
            panel2.Location = new Point(1037, 149);
            panel2.Name = "panel2";
            panel2.Size = new Size(833, 846);
            panel2.TabIndex = 3;
            // 
            // PriceTextBox2
            // 
            PriceTextBox2.BorderStyle = BorderStyle.FixedSingle;
            PriceTextBox2.Location = new Point(82, 594);
            PriceTextBox2.Name = "PriceTextBox2";
            PriceTextBox2.Size = new Size(356, 27);
            PriceTextBox2.TabIndex = 6;
            PriceTextBox2.Text = "price";
            // 
            // QuantityTextBox2
            // 
            QuantityTextBox2.BorderStyle = BorderStyle.FixedSingle;
            QuantityTextBox2.Location = new Point(81, 541);
            QuantityTextBox2.Name = "QuantityTextBox2";
            QuantityTextBox2.Size = new Size(359, 27);
            QuantityTextBox2.TabIndex = 5;
            QuantityTextBox2.Text = "Quantity";
            // 
            // IdTextBox2
            // 
            IdTextBox2.BorderStyle = BorderStyle.FixedSingle;
            IdTextBox2.Location = new Point(79, 493);
            IdTextBox2.Name = "IdTextBox2";
            IdTextBox2.Size = new Size(361, 27);
            IdTextBox2.TabIndex = 4;
            IdTextBox2.Text = "ID";
            // 
            // ConfirmButton
            // 
            ConfirmButton.Location = new Point(521, 729);
            ConfirmButton.Name = "ConfirmButton";
            ConfirmButton.Size = new Size(164, 65);
            ConfirmButton.TabIndex = 3;
            ConfirmButton.Text = "Confirm";
            ConfirmButton.UseVisualStyleBackColor = true;
            // 
            // DeleteButton
            // 
            DeleteButton.Location = new Point(333, 729);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(164, 65);
            DeleteButton.TabIndex = 2;
            DeleteButton.Text = "Delete";
            DeleteButton.UseVisualStyleBackColor = true;
            // 
            // UpdateButton
            // 
            UpdateButton.Location = new Point(146, 729);
            UpdateButton.Name = "UpdateButton";
            UpdateButton.Size = new Size(164, 65);
            UpdateButton.TabIndex = 1;
            UpdateButton.Text = "Update";
            UpdateButton.UseVisualStyleBackColor = true;
            // 
            // ConfirmDataGridView
            // 
            ConfirmDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ConfirmDataGridView.Location = new Point(27, 113);
            ConfirmDataGridView.Name = "ConfirmDataGridView";
            ConfirmDataGridView.RowHeadersWidth = 51;
            ConfirmDataGridView.Size = new Size(785, 341);
            ConfirmDataGridView.TabIndex = 0;
            // 
            // TotalSell
            // 
            TotalSell.AutoSize = true;
            TotalSell.Location = new Point(274, 40);
            TotalSell.Name = "TotalSell";
            TotalSell.Size = new Size(87, 20);
            TotalSell.TabIndex = 4;
            TotalSell.Text = "TOTAL SELL:";
            // 
            // Total
            // 
            Total.AutoSize = true;
            Total.BackColor = Color.Red;
            Total.Location = new Point(366, 41);
            Total.Name = "Total";
            Total.Size = new Size(72, 20);
            Total.TabIndex = 5;
            Total.Text = "Loading...";
            // 
            // BackButton
            // 
            BackButton.Location = new Point(28, 24);
            BackButton.Name = "BackButton";
            BackButton.Size = new Size(52, 52);
            BackButton.TabIndex = 6;
            BackButton.Text = "Back";
            BackButton.UseVisualStyleBackColor = true;
            BackButton.Click += BackButton_Click;
            // 
            // Sell
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1902, 1033);
            Controls.Add(BackButton);
            Controls.Add(Total);
            Controls.Add(TotalSell);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Sell";
            Text = "Sell";
            Load += Sell_Load;
            ((System.ComponentModel.ISupportInitialize)MaindataGridView).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ConfirmDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button SearchButton;
        private TextBox SearchBox;
        private DataGridView MaindataGridView;
        private TextBox IdTextBox;
        private TextBox QuantityTextBox;
        private Label Idlabel;
        private Label Qusntitylabel;
        private Button AddButton;
        private Panel panel1;
        private Panel panel2;
        private DataGridView ConfirmDataGridView;
        private Button ConfirmButton;
        private Button DeleteButton;
        private Button UpdateButton;
        private TextBox PriceTextBox2;
        private TextBox QuantityTextBox2;
        private TextBox IdTextBox2;
        private Label TotalSell;
        private Label Total;
        private Button BackButton;
    }
}