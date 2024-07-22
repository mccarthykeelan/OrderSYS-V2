using OrderSYS.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace OrderSYS.Views
{
    public partial class frmOrder : Form
    {
        public frmOrder()
        {
            InitializeComponent();
        }

        public int Id { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public DateTime OrderDate { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Status { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public decimal Total { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int AccountId { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public IEnumerable<Product> Products { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
