using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
// string connectionString = "Data Source=LAPTOP-CTF04D67\\SQLEXPRESS;Initial Catalog=KenaKata;Integrated Security=True;Encrypt=False";
namespace KenaKata
{

    public partial class ProductAdd : Form
    {
        public string buttonNo;
        string databaseTotalProductQuantity, databaseSellingProductQuantity;
        

        public ProductAdd()
        {
            InitializeComponent();
            LoadProductAddData();

            MaindataGridView.CellClick += MaindataGridView_CellClick;
            MaindataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }

        public void ButtonNo(string no)
        {
            buttonNo = no;
        }

        public void LoadProductAddData()
        {
            // Connection string
            string connectionString = "Data Source=LAPTOP-CTF04D67\\SQLEXPRESS;Initial Catalog=KenaKata;Integrated Security=True;Encrypt=False;";

            // Create SqlConnection object
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                // Open the connection
                con.Open();

                // SQL query to retrieve all data from Product_Add
                string query = "SELECT * FROM [Product_Add]";

                // Create SqlDataAdapter and pass the query and connection
                using (SqlDataAdapter da = new SqlDataAdapter(query, con))
                {
                    // Create DataTable to hold the results
                    DataTable table = new DataTable();

                    // Fill the DataTable with data from the query
                    da.Fill(table);

                    // Set the DataGridView's DataSource to the DataTable
                    MaindataGridView.DataSource = table;

                    // Automatically resize the columns to fit the content
                    MaindataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
            }
        }



     


        private void BackButton_Click(object sender, EventArgs e)
        {
            if (buttonNo == "1")
            {
                AdminMenu adminMenu = new AdminMenu();
                adminMenu.ShowDialog();
                this.Close();

            }
            else if (buttonNo == "2")
            {
                StaffMenu staffMenu = new StaffMenu();
                staffMenu.ShowDialog();
                this.Close();
            }

        }

        private void ProductAdd_Load(object sender, EventArgs e)
        {

        }

        private void MaindataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void ProductIdTextBox_TextChanged(object sender, EventArgs e)
        {

        }
        private void ProductNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }



        private void ProductQuantityTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void ProductBuyingPriceTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void ProductSellingPriceTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            // Retrieve values from text boxes
            string productId = ProductIdTextBox.Text.Trim();
            string productName = ProductNameTextBox.Text.Trim();
            int productQuantity;
            decimal buyingPrice;  // Change to decimal for accuracy
            decimal sellingPrice;  // Change to decimal for accuracy

            // Validate input
            if (string.IsNullOrWhiteSpace(productId) || string.IsNullOrWhiteSpace(productName) ||
                !int.TryParse(ProductQuantityTextBox.Text, out productQuantity) ||
                !decimal.TryParse(ProductBuyingPriceTextBox.Text, out buyingPrice) || // Use decimal
                !decimal.TryParse(ProductSellingPriceTextBox.Text, out sellingPrice)) // Use decimal
            {
                MessageBox.Show("Please ensure all fields are filled in correctly. " +
                                "Product ID and name must be provided, and quantities and prices must be numbers.");
                return;
            }

            // Calculate total price of buying product
            decimal totallPriceOfBuyingProduct = buyingPrice * productQuantity;

            string connectionString = "Data Source=LAPTOP-CTF04D67\\SQLEXPRESS;Initial Catalog=KenaKata;Integrated Security=True;Encrypt=False;";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();

                // Check if the product already exists
                string checkQuery = "SELECT COUNT(*) FROM \"Product_Add\" WHERE productid = @ProductId OR productname = @ProductName";

                using (SqlCommand checkCmd = new SqlCommand(checkQuery, con))
                {
                    checkCmd.Parameters.AddWithValue("@ProductId", productId);
                    checkCmd.Parameters.AddWithValue("@ProductName", productName);

                    int existingCount = (int)checkCmd.ExecuteScalar();

                    if (existingCount > 0)
                    {
                        MessageBox.Show("A product with the same ID or name already exists. Please use a different ID or name.");
                        return;
                    }
                }

                // If not exists, insert the new product including total price of buying
                string insertQuery = $@"INSERT INTO [Product_Add] (productid, productname, productquantity, buying_price, selling_price, totallPriceOfBuyingProduct) VALUES (@ProductId, @ProductName, @ProductQuantity, @BuyingPrice, @SellingPrice, @TotallPriceOfBuyingProduct)";

                using (SqlCommand insertCmd = new SqlCommand(insertQuery, con))
                {
                    insertCmd.Parameters.AddWithValue("@ProductId", productId);
                    insertCmd.Parameters.AddWithValue("@ProductName", productName);
                    insertCmd.Parameters.AddWithValue("@ProductQuantity", productQuantity);
                    insertCmd.Parameters.AddWithValue("@BuyingPrice", buyingPrice);
                    insertCmd.Parameters.AddWithValue("@SellingPrice", sellingPrice);
                    insertCmd.Parameters.AddWithValue("@TotallPriceOfBuyingProduct", totallPriceOfBuyingProduct); // Add the total price

                    insertCmd.ExecuteNonQuery(); // Execute the insert command
                }

                MessageBox.Show("Product added successfully.");
            }

            // Optionally reload the data to reflect the new entry in the DataGridView
            LoadProductAddData();
        }

       
        private void MaindataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = MaindataGridView.Rows[e.RowIndex];

                ProductIdTextBox.Text = row.Cells["productid"].Value.ToString();
                ProductNameTextBox.Text = row.Cells["productname"].Value.ToString();
                databaseTotalProductQuantity = row.Cells["ProductQuantity"].Value.ToString(); 
                databaseSellingProductQuantity= row.Cells["sellingProductQuantity"].Value.ToString();
            }
        }
        private void UpdateButton_Click(object sender, EventArgs e)
        {
            // Retrieve values from text boxes
            string productId = ProductIdTextBox.Text.Trim();
            string productName = ProductNameTextBox.Text.Trim();
            int productQuantityToAdd = 0; // Default to 0
            decimal buyingPrice = 0; // Default
            decimal sellingPrice = 0; // Default
            int existingProductQuantity;
            decimal previousTotalBuyingPrice = 0;
            decimal previousTotalSellingPrice = 0;

            // Validate input for productId and productName
            if (string.IsNullOrWhiteSpace(productId) || string.IsNullOrWhiteSpace(productName))
            {
                MessageBox.Show("Please ensure all fields are filled in correctly.");
                return;
            }

            // Check if the quantity is provided
            if (!string.IsNullOrWhiteSpace(ProductQuantityTextBox.Text))
            {
                if (!int.TryParse(ProductQuantityTextBox.Text, out productQuantityToAdd))
                {
                    MessageBox.Show("Please enter a valid quantity.");
                    return;
                }
            }

            string connectionString = "Data Source=LAPTOP-CTF04D67\\SQLEXPRESS;Initial Catalog=KenaKata;Integrated Security=True;Encrypt=False;MultipleActiveResultSets=True;";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();

                // Check if the product exists and get previous totals
                string checkQuery = "SELECT productquantity, buying_price, selling_price, ISNULL(totallPriceOfBuyingProduct, 0), ISNULL(totallPriceOfSellingProduct, 0) FROM [Product_Add] WHERE productid = @ProductId";

                using (SqlCommand checkCmd = new SqlCommand(checkQuery, con))
                {
                    checkCmd.Parameters.AddWithValue("@ProductId", productId);
                    using (SqlDataReader reader = checkCmd.ExecuteReader())
                    {
                        if (!reader.Read())
                        {
                            MessageBox.Show("No product found with the specified ID. Please check and try again.");
                            return;
                        }

                        existingProductQuantity = reader.GetInt32(0);
                        decimal previousBuyingPrice = reader.IsDBNull(1) ? 0 : reader.GetDecimal(1);
                        decimal previousSellingPrice = reader.IsDBNull(2) ? 0 : reader.GetDecimal(2);
                        previousTotalBuyingPrice = reader.IsDBNull(3) ? 0 : reader.GetDecimal(3);
                        previousTotalSellingPrice = reader.IsDBNull(4) ? 0 : reader.GetDecimal(4);

                        // Determine buying price
                        if (decimal.TryParse(ProductBuyingPriceTextBox.Text, out decimal buyingPriceInput))
                        {
                            buyingPrice = buyingPriceInput;
                        }
                        else
                        {
                            buyingPrice = previousBuyingPrice; // Use the previous buying price if not provided
                        }

                        // Determine selling price
                        if (decimal.TryParse(ProductSellingPriceTextBox.Text, out decimal sellingPriceInput))
                        {
                            sellingPrice = sellingPriceInput;
                        }
                        else
                        {
                            sellingPrice = previousSellingPrice; // Use the previous selling price if not provided
                        }

                        // Calculate updated values
                        int updatedProductQuantity = existingProductQuantity + productQuantityToAdd; // Update quantity if provided
                        decimal totalPriceOfBuyingProduct = previousTotalBuyingPrice + (productQuantityToAdd * buyingPrice);
                        decimal totalPriceOfSellingProduct = previousTotalSellingPrice; // This can be adjusted as needed

                        // Update the product details
                        string updateQuery = "UPDATE [Product_Add] SET productname = @ProductName, productquantity = @ProductQuantity, buying_price = @BuyingPrice, selling_price = @SellingPrice, totallPriceOfBuyingProduct = @TotallPriceOfBuyingProduct, totallPriceOfSellingProduct = @TotallPriceOfSellingProduct WHERE productid = @ProductId";

                        using (SqlCommand updateCmd = new SqlCommand(updateQuery, con))
                        {
                            updateCmd.Parameters.AddWithValue("@ProductId", productId);
                            updateCmd.Parameters.AddWithValue("@ProductName", productName);
                            updateCmd.Parameters.AddWithValue("@ProductQuantity", updatedProductQuantity); // Update quantity
                            updateCmd.Parameters.AddWithValue("@BuyingPrice", buyingPrice);
                            updateCmd.Parameters.AddWithValue("@SellingPrice", sellingPrice);
                            updateCmd.Parameters.AddWithValue("@TotallPriceOfBuyingProduct", totalPriceOfBuyingProduct);
                            updateCmd.Parameters.AddWithValue("@TotallPriceOfSellingProduct", totalPriceOfSellingProduct);

                            int rowsAffected = updateCmd.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Product updated successfully.");
                            }
                            else
                            {
                                MessageBox.Show("Failed to update product. Please try again.");
                            }
                        }
                    } // The reader is disposed here
                } // End of checkCmd
            }

            // Reload the data to reflect the updated entry in the DataGridView
            LoadProductAddData();
        }






        private void DeleteButton_Click(object sender, EventArgs e)
        {
            // Retrieve the selected product ID from the text box
            string productId = ProductIdTextBox.Text.Trim();

            // Validate input
            if (string.IsNullOrWhiteSpace(productId))
            {
                MessageBox.Show("Please select a product to delete.");
                return;
            }

            // Confirmation dialog
            var confirmResult = MessageBox.Show("Are you sure you want to delete this product? " +
                                                 "You will not be able to recover this information once deleted.",
                                                 "Confirm Delete",
                                                 MessageBoxButtons.YesNo,
                                                 MessageBoxIcon.Warning);

            if (confirmResult == DialogResult.Yes)
            {
                string connectionString = "Data Source=LAPTOP-CTF04D67\\SQLEXPRESS;Initial Catalog=KenaKata;Integrated Security=True;Encrypt=False;";

                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();

                    // Check if the product exists
                    string checkQuery = "SELECT COUNT(*) FROM [Product_Add] WHERE productid = @ProductId";

                    using (SqlCommand checkCmd = new SqlCommand(checkQuery, con))
                    {
                        checkCmd.Parameters.AddWithValue("@ProductId", productId);
                        int existingCount = (int)checkCmd.ExecuteScalar();

                        if (existingCount == 0)
                        {
                            MessageBox.Show("No product found with the specified ID. Please check and try again.");
                            return;
                        }
                    }

                    // Delete the product
                    string deleteQuery = "DELETE FROM [Product_Add] WHERE productid = @ProductId";

                    using (SqlCommand deleteCmd = new SqlCommand(deleteQuery, con))
                    {
                        deleteCmd.Parameters.AddWithValue("@ProductId", productId);
                        int rowsAffected = deleteCmd.ExecuteNonQuery(); // Execute the delete command

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Product deleted successfully.");
                        }
                        else
                        {
                            MessageBox.Show("Failed to delete product. Please try again.");
                        }
                    }
                }

                // Reload the data to reflect the deletion in the DataGridView
                LoadProductAddData();
            }
        }


        private void SellingProductQuantityTextBox_TextChanged(object sender, EventArgs e)
{

}
}
}


