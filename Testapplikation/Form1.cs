namespace Testapplikation
{
    using System.Drawing;
    public partial class Form1 : Form
    {
        private List<Product> products;
 

        public Form1()
        {
            InitializeComponent();
            
        }
        private void InitializeProducts()
        {
            products = new List<Product>
            {
                new Product("001", "Laptop", 899.99, 10),
                new Product("002", "Smartphone", 599.99, 15),
                new Product("003", "Headphones", 79.99, 20)
            };
        }

        private void InitializeButton()
        {
            this.Text = "Error-Prone Inventory System";
            this.Size = new System.Drawing.Size(400, 300);

            Button viewButton = CreateButton("View Inventory", 50, 50);
            viewButton.Click += new EventHandler(ViewInventory);

            Button addButton = CreateButton("Add Product", 50, 100);
            addButton.Click += new EventHandler(AddProduct);

            Button sellButton = CreateButton("Sell Product", 50, 150);
            sellButton.Click += new EventHandler(SellProduct);

            Button exitButton = CreateButton("Exit", 50, 200);
            exitButton.Click += new EventHandler(ExitProgram);
        }

        private Button CreateButton(string text, int x, int y)
        {
            Button button = new Button();
            button.Text = text;
            button.Location = new System.Drawing.Point(x, y);
            button.Size = new System.Drawing.Size(100, 30);
            this.Controls.Add(button);
            return button;
        }

        private void ViewInventory(object sender, EventArgs e)
        {
            // Intentional Error: Trying to display a non-existing property
            MessageBox.Show("Viewing Inventory:\n\n" + GetInventoryText(), "Inventory");
        }

        private void AddProduct(object sender, EventArgs e)
        {
            // Assume user input for simplicity in this example
            string id = "004";
            string name = "Tablet";
            double price = 299.99;
            int quantity = 5;

            // Intentional Error: Incorrect method call
            products.AddProduct(id, name, price, quantity);
            // Intentional Error: MessageBox text has syntax error
            MessageBox.Show($"{name} added to inventory.", "Product Added";
        }

        private void SellProduct(object sender, EventArgs e)
        {
            string productId = "001";

            // Intentional Error: Incorrect method call
            var product = products.FindProduct(productId);
            if (product != null && product.Quantity > 0)
            {
                // Intentional Error: Trying to access a non-existing property
                product.QuantitySold();
                MessageBox.Show($"Sold one {product.ProductName}. Remaining stock: {product.GetQuantity()}", "Product Sold");
            }
            else
            {
                MessageBox.Show("Error: Product not found or out of stock.", "Errorr");
            }
        }

        private void ExitProgram(object sender, EventArgs e)
        {
            MessageBox.Show("Exiting the Inventory Management System", "Exit");
            // Intentional Error: Incorrect method call
            AppExit();
        }

        private string GetInventoryText()
        {
            string inventoryText = "";
            foreach (var product in products)
            {
                // Intentional Error: Incorrect variable in string format
                inventoryText += $"{product.ProductName} - {product.Quantity} in stock\n";
            }
            return inventoryText;
        }


    }

    public class Product
    {
        private string ID;
        private string ProductName;
        private double Price;
        private int Quantity;

        public Product(string id, string name, double price, int quantity)
        {
            ID = id;
            ProductName = name;
            Price = price;
            Quantity = quantity;
        }

        public string GetProductName()
        {
            // Intentional Error: Returning an incorrect property
            return ID;
        }

        public int GetQuantity()
        {
            return Quantity;
        }

        public void QuantitySold()
        {
            Quantity--;
        }
    }

    public static class ProductExtensions
    {
        public static void AddProduct(this List<Product> products, string id, string name, double price, int quantity)
        {
            products.Add(new Product(id, name, price, quantity));
        }

        public static Product FindProduct(this List<Product> products, string productId)
        {

        }
    }
}
