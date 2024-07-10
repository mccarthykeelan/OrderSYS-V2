using System;
using System.Collections.Generic;
using OrderSYS.Models;

namespace OrderSYS.Views.Interfaces
{
    public interface IManageProductsView
    {
        event EventHandler LoadProducts;
        event EventHandler AddProduct;
        event EventHandler UpdateProduct;
        event EventHandler DeleteProduct;

        void AssociateAndRaiseViewEvents();
    }
}
