namespace KenaKata
{
    partial class SellingProduct
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
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ProductNameTextBox = new System.Windows.Forms.TextBox();
            this.QuantitySoldTextBox = new System.Windows.Forms.TextBox();
            this.SellingPriceTextBox = new System.Windows.Forms.TextBox();
            this.ProductIdTextBox = new System.Windows.Forms.TextBox();
            this.SellButton = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.next = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(582, 270);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Selling Price";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(316, 270);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Quantity";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(582, 182);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Product Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(316, 192);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Product ID";
            // 
            // ProductNameTextBox
            // 
            this.ProductNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ProductNameTextBox.Location = new System.Drawing.Point(585, 210);
            this.ProductNameTextBox.Name = "ProductNameTextBox";
            this.ProductNameTextBox.Size = new System.Drawing.Size(211, 20);
            this.ProductNameTextBox.TabIndex = 13;
            // 
            // QuantitySoldTextBox
            // 
            this.QuantitySoldTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.QuantitySoldTextBox.Location = new System.Drawing.Point(319, 295);
            this.QuantitySoldTextBox.Name = "QuantitySoldTextBox";
            this.QuantitySoldTextBox.Size = new System.Drawing.Size(211, 20);
            this.QuantitySoldTextBox.TabIndex = 12;
            // 
            // SellingPriceTextBox
            // 
            this.SellingPriceTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SellingPriceTextBox.Location = new System.Drawing.Point(585, 286);
            this.SellingPriceTextBox.Name = "SellingPriceTextBox";
            this.SellingPriceTextBox.Size = new System.Drawing.Size(211, 20);
            this.SellingPriceTextBox.TabIndex = 11;
            // 
            // ProductIdTextBox
            // 
            this.ProductIdTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ProductIdTextBox.Location = new System.Drawing.Point(319, 210);
            this.ProductIdTextBox.Name = "ProductIdTextBox";
            this.ProductIdTextBox.Size = new System.Drawing.Size(211, 20);
            this.ProductIdTextBox.TabIndex = 10;
            // 
            // SellButton
            // 
            this.SellButton.Location = new System.Drawing.Point(388, 364);
            this.SellButton.Name = "SellButton";
            this.SellButton.Size = new System.Drawing.Size(148, 41);
            this.SellButton.TabIndex = 19;
            this.SellButton.Text = "Sell Button";
            this.SellButton.UseVisualStyleBackColor = true;
            this.SellButton.Click += new System.EventHandler(this.SellButton_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(145, 38);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(829, 110);
            this.dataGridView.TabIndex = 20;
            // 
            // next
            // 
            this.next.Location = new System.Drawing.Point(12, 23);
            this.next.Name = "next";
            this.next.Size = new System.Drawing.Size(75, 23);
            this.next.TabIndex = 21;
            this.next.Text = "Prev";
            this.next.UseVisualStyleBackColor = true;
            this.next.Click += new System.EventHandler(this.next_Click);
            // 
            // SellingProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1052, 494);
            this.Controls.Add(this.next);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.SellButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ProductNameTextBox);
            this.Controls.Add(this.QuantitySoldTextBox);
            this.Controls.Add(this.SellingPriceTextBox);
            this.Controls.Add(this.ProductIdTextBox);
            this.Name = "SellingProduct";
            this.Text = "SellingProduct";
            this.Load += new System.EventHandler(this.SellingProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ProductNameTextBox;
        private System.Windows.Forms.TextBox QuantitySoldTextBox;
        private System.Windows.Forms.TextBox SellingPriceTextBox;
        private System.Windows.Forms.TextBox ProductIdTextBox;
        private System.Windows.Forms.Button SellButton;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button next;
    }
}