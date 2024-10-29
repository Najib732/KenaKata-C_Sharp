using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KenaKata
{
    public partial class ProductAdd : Form
    {
        public ProductAdd()
        {
            InitializeComponent();
            LoadProductAddData();
         //MaindataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }


        public void LoadProductAddData()
        {
            
                // Connection string

                string connectionString = "Data Source=Najib;Initial Catalog=KenaKata;Integrated Security=True;Encrypt=False";
                SqlConnection con = new SqlConnection(connectionString);
                con.Open();
                string query = "Select * From ProductRecords ";
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                MaindataGridView.DataSource = dt;
               //MaindataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                 con.Close();
            
        }


        private void MaindataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = MaindataGridView.Rows[e.RowIndex];

                ProductIdTextBox.Text = row.Cells["productid"].Value.ToString();
                ProductNameTextBox.Text = row.Cells["productname"].Value.ToString();
               // databaseTotalProductQuantity = row.Cells["ProductQuantity"].Value.ToString();
               // databaseSellingProductQuantity = row.Cells["sellingProductQuantity"].Value.ToString();
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            // Retrieve values from textboxes
            string productId = ProductIdTextBox.Text.Trim();
            string productName = ProductNameTextBox.Text.Trim();
            decimal buyingPrice, sellingPrice, stockQuantity, totalBuyingBalance;

            // Validate inputs
            if (string.IsNullOrWhiteSpace(productId) || string.IsNullOrWhiteSpace(productName) ||
                !decimal.TryParse(BuyingPriceTextBox.Text.Trim(), out buyingPrice) ||
                !decimal.TryParse(SellingPriceTextBox.Text.Trim(), out sellingPrice) ||
                !decimal.TryParse(StockQuantityTextBox.Text.Trim(), out stockQuantity))
            {
                MessageBox.Show("Please ensure all fields are correctly filled.");
                return;
            }

            // Calculate the total buying balance
            totalBuyingBalance = stockQuantity * buyingPrice;

            // Database connection string
            string connectionString = "Data Source=Najib;Initial Catalog=KenaKata;Integrated Security=True;Encrypt=False";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();

                    // SQL query to insert the product into ProductRecords
                    string productInsertQuery = @"
            INSERT INTO ProductRecords 
            (ProductId, ProductName, BuyingPrice, SellingPrice, StockQuantity, TotalBuyingBalance, PurchaseCount, LastPurchaseNumber, LastAddedBy) 
            VALUES (@ProductId, @ProductName, @BuyingPrice, @SellingPrice, @StockQuantity, @TotalBuyingBalance, 1, 1, @LastAddedBy)";

                    using (SqlCommand cmd = new SqlCommand(productInsertQuery, con))
                    {
                        // Add parameters
                        cmd.Parameters.AddWithValue("@ProductId", productId);
                        cmd.Parameters.AddWithValue("@ProductName", productName);
                        cmd.Parameters.AddWithValue("@BuyingPrice", buyingPrice);
                        cmd.Parameters.AddWithValue("@SellingPrice", sellingPrice);
                        cmd.Parameters.AddWithValue("@StockQuantity", stockQuantity);
                        cmd.Parameters.AddWithValue("@TotalBuyingBalance", totalBuyingBalance);
                        cmd.Parameters.AddWithValue("@LastAddedBy", "Najib"); // By default

                        // Execute query
                        cmd.ExecuteNonQuery();
                        LoadProductAddData();
                    }

                    // Insert into SellRecorder
                    string sellRecordInsertQuery = @"
            INSERT INTO SellRecorder (ProductId, ProductName, ExistedPieces, SellingTime) 
            VALUES (@ProductId, @ProductName, @ExistedPieces, 0)";

                    using (SqlCommand cmd = new SqlCommand(sellRecordInsertQuery, con))
                    {
                        // Add parameters
                        cmd.Parameters.AddWithValue("@ProductId", productId);
                        cmd.Parameters.AddWithValue("@ProductName", productName);
                        cmd.Parameters.AddWithValue("@ExistedPieces", stockQuantity);

                        // Execute the second insert
                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Product added successfully.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }

            // Optionally clear the textboxes after adding the product
            ProductIdTextBox.Clear();
            ProductNameTextBox.Clear();
            BuyingPriceTextBox.Clear();
            SellingPriceTextBox.Clear();
            StockQuantityTextBox.Clear();
        }


        private void UpdateButton_Click(object sender, EventArgs e)
        {
            // Retrieve values from textboxes
            string productId = ProductIdTextBox.Text.Trim();
            string productName = ProductNameTextBox.Text.Trim();
            decimal buyingPrice, sellingPrice, lastPurchasedQuantity;

            // Validate inputs
            if (string.IsNullOrWhiteSpace(productId) || string.IsNullOrWhiteSpace(productName) ||
                !decimal.TryParse(BuyingPriceTextBox.Text.Trim(), out buyingPrice) ||
                !decimal.TryParse(SellingPriceTextBox.Text.Trim(), out sellingPrice) ||
                !decimal.TryParse(LastPurchasedQuantityTextBox.Text.Trim(), out lastPurchasedQuantity))
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

                    // SQL query to update the product
                    string query = @"
                UPDATE ProductRecords
                SET BuyingPrice = @BuyingPrice, 
                    SellingPrice = @SellingPrice,
                    StockQuantity = StockQuantity + @LastPurchasedQuantity,
                    LastPurchasedQuantity = @LastPurchasedQuantity,
                    TotalBuyingBalance = TotalBuyingBalance + (@BuyingPrice * @LastPurchasedQuantity),
                    LastPurchaseNumber = PurchaseCount,
                    PurchaseCount = PurchaseCount + 1,
                    LastAddedBy = 'Najib'
                WHERE ProductId = @ProductId AND ProductName = @ProductName";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        // Add parameters
                        cmd.Parameters.AddWithValue("@ProductId", productId);
                        cmd.Parameters.AddWithValue("@ProductName", productName);
                        cmd.Parameters.AddWithValue("@BuyingPrice", buyingPrice);
                        cmd.Parameters.AddWithValue("@SellingPrice", sellingPrice);
                        cmd.Parameters.AddWithValue("@LastPurchasedQuantity", lastPurchasedQuantity);

                        // Execute query
                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            ResortData(productId, productName);
                           
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }

            // Optionally reload the product records data to reflect the update
            LoadProductAddData();
        }

        void ResortData(string productId, string productName)
        {
            string connectionString = "Data Source=Najib;Initial Catalog=KenaKata;Integrated Security=True;Encrypt=False";

            // Step 1: Check if the product exists and fetch its ExistedPieces quantity
            string checkProductQuery = @"SELECT ExistedPieces
                                 FROM SellRecorder 
                                 WHERE ProductId = @ProductId AND ProductName = @ProductName";

            decimal existedQuantity = 0;

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();

                using (SqlCommand cmd = new SqlCommand(checkProductQuery, con))
                {
                    cmd.Parameters.Add("@ProductId", SqlDbType.VarChar).Value = productId;
                    cmd.Parameters.Add("@ProductName", SqlDbType.VarChar).Value = productName;

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            existedQuantity = reader.GetDecimal(0); // Get the existing quantity from the SellRecorder table
                        }
                        else
                        {
                            MessageBox.Show("Product not found in SellRecorder.");
                            return;
                        }
                    }
                }

                // Step 2: Calculate the new quantity based on LastPurchasedQuantity
                decimal purchasedQuantity = Convert.ToDecimal(LastPurchasedQuantityTextBox.Text);
                decimal newExistedPieces = existedQuantity + purchasedQuantity;

                // Step 3: Update the ExistedPieces in the SellRecorder table
                string updateSellRecordQuery = @"
            UPDATE SellRecorder
            SET ExistedPieces = @NewExistedPieces
            WHERE ProductId = @ProductId AND ProductName = @ProductName";

                using (SqlCommand cmd = new SqlCommand(updateSellRecordQuery, con))
                {
                    cmd.Parameters.Add("@NewExistedPieces", SqlDbType.Decimal).Value = newExistedPieces;
                    cmd.Parameters.Add("@ProductId", SqlDbType.VarChar).Value = productId;
                    cmd.Parameters.Add("@ProductName", SqlDbType.VarChar).Value = productName;

                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show(" updated successfully.");
                    }
                    else
                    {
                        MessageBox.Show("Failed to update.");
                        return;
                    }
                }
            }
        }


        private void next_Click(object sender, EventArgs e)
        {
            SellingProduct s = new SellingProduct();
            s.Show();
            this.Close();   
        }

        private void ProductAdd_Load(object sender, EventArgs e)
        {

        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            // Retrieve the ProductId from the textbox
            string productId = ProductIdTextBox.Text.Trim();

            // Validate input
            if (string.IsNullOrWhiteSpace(productId))
            {
                MessageBox.Show("Please enter a valid Product ID.");
                return;
            }

            // Database connection string
            string connectionString = "Data Source=Najib;Initial Catalog=KenaKata;Integrated Security=True;Encrypt=False";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();

                    // SQL query to delete the product
                    string deleteProductQuery = @"DELETE FROM ProductRecords 
                                           WHERE ProductId = @ProductId";

                    using (SqlCommand cmd = new SqlCommand(deleteProductQuery, con))
                    {
                        cmd.Parameters.Add("@ProductId", SqlDbType.VarChar).Value = productId;

                        // Execute the delete command and check the number of affected rows
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Product deleted successfully.");
                        }
                        else
                        {
                            MessageBox.Show("Product not found.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }

            // Clear the ProductId textbox after deletion
            ProductIdTextBox.Clear();

            // Optionally, refresh the records displayed in the UI (if applicable)
            LoadProductAddData();
        }

        private void ProductNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void SellingPriceTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void BuyingPriceTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void StockQuantityTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void ProductIdTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void LastPurchasedQuantityTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void SaveDataToFile_Click(object sender, EventArgs e)
        {
            Save();


        }
        void Save()
        {
            // Database connection string
            string connectionString = "Data Source=Najib;Initial Catalog=KenaKata;Integrated Security=True;Encrypt=False";

            // SQL query to retrieve data
            string query = "SELECT * FROM ProductRecords";

            // Create a FolderBrowserDialog to let the user select a folder
            using (FolderBrowserDialog folderBrowser = new FolderBrowserDialog())
            {
                folderBrowser.Description = "Select a folder to save the CSV file";
                if (folderBrowser.ShowDialog() == DialogResult.OK)
                {
                    string folderPath = folderBrowser.SelectedPath;

                    // Create the CSV file name (with current timestamp)
                    string filePath = Path.Combine(folderPath, "ProductRecords_" + DateTime.Now.ToString("yyyyMMdd_HHmmss") + ".csv");

                    using (SqlConnection con = new SqlConnection(connectionString))
                    {
                        try
                        {
                            con.Open();

                            // Execute the query to get data
                            SqlCommand cmd = new SqlCommand(query, con);
                            SqlDataReader reader = cmd.ExecuteReader();

                            // Write data to CSV
                            using (StreamWriter sw = new StreamWriter(filePath))
                            {
                                // Write column headers
                                for (int i = 0; i < reader.FieldCount; i++)
                                {
                                    sw.Write(reader.GetName(i));
                                    if (i < reader.FieldCount - 1)
                                        sw.Write(",");  // Add comma between headers
                                }
                                sw.WriteLine();  // Move to the next line after headers

                                // Write rows of data
                                while (reader.Read())
                                {
                                    for (int i = 0; i < reader.FieldCount; i++)
                                    {
                                        sw.Write(reader[i].ToString());
                                        if (i < reader.FieldCount - 1)
                                            sw.Write(",");  // Add comma between values
                                    }
                                    sw.WriteLine();  // Move to the next line after each row
                                }
                            }

                            MessageBox.Show($"Data saved successfully to {filePath}");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error: " + ex.Message);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Folder selection was cancelled.");
                }
            }

        }
       /* void Save()
        {
            // Connection string
            string connectionString = "Data Source=Najib;Initial Catalog=KenaKata;Integrated Security=True;Encrypt=False";

            // Query to get the data
            string query = "SELECT * FROM ProductRecords";  // You can modify this to suit your needs

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    // Open the connection
                    con.Open();

                    // Execute the query
                    SqlCommand cmd = new SqlCommand(query, con);
                    SqlDataReader reader = cmd.ExecuteReader();

                    // Prompt user to select file location and name
                    using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                    {
                        saveFileDialog.Filter = "CSV files (*.csv)|*.csv|All files (*.*)|*.*";
                        saveFileDialog.FilterIndex = 1;
                        saveFileDialog.RestoreDirectory = true;

                        if (saveFileDialog.ShowDialog() == DialogResult.OK)
                        {
                            // Create a StreamWriter to write the CSV data
                            using (StreamWriter sw = new StreamWriter(saveFileDialog.FileName))
                            {
                                // Write the column headers
                                for (int i = 0; i < reader.FieldCount; i++)
                                {
                                    sw.Write(reader.GetName(i));
                                    if (i < reader.FieldCount - 1)
                                        sw.Write(","); // Separate columns with commas
                                }
                                sw.WriteLine();

                                // Write the data rows
                                while (reader.Read())
                                {
                                    for (int i = 0; i < reader.FieldCount; i++)
                                    {
                                        sw.Write(reader[i].ToString());
                                        if (i < reader.FieldCount - 1)
                                            sw.Write(","); // Separate columns with commas
                                    }
                                    sw.WriteLine();
                                }
                            }

                            MessageBox.Show("Database data saved successfully to CSV.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }*/

    }
}
