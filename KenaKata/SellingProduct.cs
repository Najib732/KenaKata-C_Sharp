using System;

using System.Data;
using System.Data.SqlClient; // Make sure this is included
using System.Windows.Forms;

// Other using directives

using System.Collections.Generic;
using System.ComponentModel;

using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace KenaKata
{
    public partial class SellingProduct : Form
    {
        public SellingProduct()
        {
            InitializeComponent();
            LoadSellingRecords();
            //dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        public void LoadSellingRecords()
        {
            // Connection string

            string connectionString = "Data Source=Najib;Initial Catalog=KenaKata;Integrated Security=True;Encrypt=False";
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            string query = "Select * From SellRecorder";
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView.DataSource = dt;
           // dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            con.Close();
        }

        private void SellButton_Click(object sender, EventArgs e)
        {
            // Retrieve values from textboxes
            string productId = ProductIdTextBox.Text.Trim();
            string productName = ProductNameTextBox.Text.Trim();
            decimal sellingPrice, quantitySold;

            // Validate inputs
            if (string.IsNullOrWhiteSpace(productId) || string.IsNullOrWhiteSpace(productName) ||
                !decimal.TryParse(SellingPriceTextBox.Text.Trim(), out sellingPrice) ||
                !decimal.TryParse(QuantitySoldTextBox.Text.Trim(), out quantitySold))
            {
                MessageBox.Show("Please ensure all fields are correctly filled.");
                return;
            }

            // Database connection string
            string connectionString = "Data Source=Najib;Initial Catalog=KenaKata;Integrated Security=True;Encrypt=False";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();

                    // Step 1: Check if the product exists and fetch its stock quantity
                    string checkProductQuery = @"SELECT StockQuantity
                                                FROM ProductRecords  
                                                WHERE ProductId = @ProductId AND ProductName = @ProductName";

                    decimal stockQuantity = 0;
                   

                    using (SqlCommand cmd = new SqlCommand(checkProductQuery, con))
                    {
                        cmd.Parameters.Add("@ProductId", SqlDbType.VarChar).Value = productId;
                        cmd.Parameters.Add("@ProductName", SqlDbType.VarChar).Value = productName;
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                stockQuantity = reader.GetDecimal(0); // Get current stock quantity
                               
                            }
                            else
                            {
                                MessageBox.Show("Product not found 1.");
                               
                                return;
                            }
                        }
                    }

                    // Check existing pieces
                    string checkExistedPiecesQuery = @"SELECT ExistedPieces, SellingTime
                                                FROM SellRecorder
                                                WHERE ProductId = @ProductId AND ProductName = @ProductName";
                    decimal existedPieces = 0;
                    decimal sellingTime = 0; 

                    using (SqlCommand cmd = new SqlCommand(checkExistedPiecesQuery, con))
                    {
                        cmd.Parameters.Add("@ProductId", SqlDbType.VarChar).Value = productId;
                        cmd.Parameters.Add("@ProductName", SqlDbType.VarChar).Value = productName;
                      
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                existedPieces = reader.GetDecimal(0); // Get ExistedPieces
                                sellingTime = reader.GetDecimal(1); // Change this index to 1 to get the second column (if sellingTime is the second column)
                            }
                            else
                            {
                                MessageBox.Show("Product not found 2.");
                                return;
                            }
                        }
                    }

                    // Step 2: Check quantity availability
                    decimal quantitySOld = 0; // Ensure variable is declared and initialized

                     if (sellingTime >= 0)
                    {
                        if (decimal.TryParse(QuantitySoldTextBox.Text, out decimal inputQuantity))
                        {
                            quantitySOld = inputQuantity; // Keep the original variable name
                            existedPieces = existedPieces- quantitySOld; // Reduce existed pieces
                        }
                        else
                        {
                            MessageBox.Show("Invalid quantity sold value.");
                            return;
                        }
                    }
                    decimal totalSellingPrice=0;

                    // Calculate total selling price
                    if (existedPieces < quantitySold)
                    {
                        return;
                    }
                    
                        totalSellingPrice = quantitySold * sellingPrice;
               

                    // Insert or update sell record
                    string insertSellRecordQuery = @"
                MERGE INTO SellRecorder AS target
                USING (SELECT @ProductId AS ProductId, @ProductName AS ProductName) AS source
                ON (target.ProductId = source.ProductId AND target.ProductName = source.ProductName)
                WHEN MATCHED THEN 
                    UPDATE SET 
                        TotalPiecesSelling = TotalPiecesSelling + @QuantitySold,
                        TotalSellingPrice = TotalSellingPrice + @TotalSellingPrice,
                        ExistedPieces = @ExistedPieces, 
                        SellingTime = SellingTime + 1
                WHEN NOT MATCHED THEN 
                    INSERT (ProductId, ProductName, TotalPiecesSelling, TotalSellingPrice, ExistedPieces, SellingTime, SoldBy)
                    VALUES (@ProductId, @ProductName, @QuantitySold, @TotalSellingPrice, @ExistedPieces, 1, @SoldBy);";

                    using (SqlCommand cmd = new SqlCommand(insertSellRecordQuery, con))
                    {
                        cmd.Parameters.AddWithValue("@ProductId", productId);
                        cmd.Parameters.AddWithValue("@ProductName", productName);
                        cmd.Parameters.AddWithValue("@QuantitySold", quantitySold);
                        cmd.Parameters.AddWithValue("@TotalSellingPrice", totalSellingPrice);
                        cmd.Parameters.AddWithValue("@ExistedPieces", existedPieces);
                        cmd.Parameters.AddWithValue("@SoldBy", "Najib");

                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Product sold successfully.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                    MessageBox.Show("najib");
                }
            }

            // Clear the textboxes after selling the product
            ProductIdTextBox.Clear();
            ProductNameTextBox.Clear();
            SellingPriceTextBox.Clear();
            QuantitySoldTextBox.Clear();

            LoadSellingRecords();
        }


        private void SellingProduct_Load(object sender, EventArgs e)
        {

        }

        private void next_Click(object sender, EventArgs e)
        {
            ProductAdd p = new ProductAdd();
            p.Show();
            this.Close();
        }
    }
}


/* // Step 4: Update the stock quantity in ProductRecords
                    string updateProductQuery = @"UPDATE ProductRecords 
                                                 SET StockQuantity = StockQuantity - @QuantitySold 
                                                 WHERE ProductId = @ProductId";
       
       

                    using (SqlCommand cmd = new SqlCommand(updateProductQuery, con))
                    {
                        cmd.Parameters.AddWithValue("@QuantitySold", quantitySold);
                        cmd.Parameters.AddWithValue("@ProductId", productId);
                        cmd.ExecuteNonQuery();
                    }
                   */