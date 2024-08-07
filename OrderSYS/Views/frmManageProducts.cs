﻿using OrderSYS.Models;
using OrderSYS.Views.Interfaces;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace OrderSYS.Views
{
    public partial class frmManageProducts : Form, IManageProductsView, IProductView
    {
        public frmManageProducts()
        {
            InitializeComponent();
            AssociateAndRaiseViewEvents();
        }

        // IProductView properties
        public int Id { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }
        public string Status { get; set; }
        public string Category { get; set; }

        // IManageProductsView events
        public event EventHandler LoadProducts;
        public event EventHandler AddProduct;
        public event EventHandler UpdateProduct;
        public event EventHandler DeleteProduct;
        public event EventHandler SaveProduct;

        public void AssociateAndRaiseViewEvents()
        {
            btnRegister.Click += (sender, e) => AddProduct?.Invoke(sender, e);
            btnUpdate.Click += (sender, e) => UpdateProduct?.Invoke(sender, e);
            btnDiscontinue.Click += (sender, e) => DeleteProduct?.Invoke(sender, e);
            Load += (sender, e) => LoadProducts?.Invoke(sender, e);
        }

        public void DisplayProducts(IEnumerable<Product> products)
        {
            grdProducts.DataSource = products;
        }

        public void ShowErrorMessage(string message)
        {
            MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public Product GetSelectedProduct()
        {
            if (grdProducts.SelectedRows.Count > 0)
            {
                var selectedRow = grdProducts.SelectedRows[0];
                return new Product
                {
                    Id = Convert.ToInt32(selectedRow.Cells["Id"].Value),
                    Brand = selectedRow.Cells["Brand"].Value.ToString(),
                    Model = selectedRow.Cells["Model"].Value.ToString(),
                    Description = selectedRow.Cells["Description"].Value.ToString(),
                    Price = Convert.ToDecimal(selectedRow.Cells["Price"].Value),
                    Stock = Convert.ToInt32(selectedRow.Cells["Stock"].Value),
                    Status = selectedRow.Cells["Status"].Value.ToString(),
                    Category = selectedRow.Cells["Category"].Value.ToString()
                };
            }
            return null;
        }

        public Product GetProductDetailsFromInput()
        {
            return new Product
            {
                Id = Id,
                Brand = Brand,
                Model = Model,
                Description = Description,
                Price = Price,
                Stock = Stock,
                Status = Status,
                Category = Category
            };
        }
    }
}
