using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SimplePOS_GUI
{
    public partial class Form1 : Form
    {
        Dictionary<string, double> products = new Dictionary<string, double>()
        {
            {"Burger", 50.00},
            {"Fries", 30.00},
            {"Spaghetti", 50.00},
            {"Coffee", 20.00},
            {"Chocolate", 20.00}
        };

        public Form1()
        {
            InitializeComponent();

            // Fill dropdown with products
            foreach (var item in products)
            {
                comboProducts.Items.Add($"{item.Key} - ₱{item.Value:F2}");
            }
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (comboProducts.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a product");
                return;
            }

            if (!int.TryParse(txtQty.Text, out int qty) || qty <= 0)
            {
                MessageBox.Show("Invalid quantity.");
                return;
            }

            string selected = comboProducts.SelectedItem.ToString();
            string productName = selected.Split('-')[0].Trim();

            double price = products[productName];
            double subtotal = price * qty;
            double tax = subtotal * 0.12;
            double total = subtotal + tax;

            txtReceipt.Text =
                "===== RECEIPT =====\r\n" +
                $"Product : {productName}\r\n" +
                $"Price   : ₱{price:F2}\r\n" +
                $"Quantity: {qty}\r\n" +
                $"Subtotal: ₱{subtotal:F2}\r\n" +
                $"Tax 12% : ₱{tax:F2}\r\n" +
                $"TOTAL   : ₱{total:F2}\r\n" +
                "===================";
        }
    }
}
