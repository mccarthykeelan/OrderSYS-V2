using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace OrderSYS.Models
{
    public class Order
    {
        [DisplayName("Order ID")]
        [Required(ErrorMessage = "Order ID is required")]
        public int Id { get; set; }

        [DisplayName("Order Date")]
        [Required(ErrorMessage = "Order Date is required")]
        public DateTime OrderDate { get; set; }

        [DisplayName("Status")]
        [Required(ErrorMessage = "Status is required")]
        [StringLength(50, ErrorMessage = "Status cannot exceed 50 characters")]
        public string Status { get; set; }

        [DisplayName("Total Amount")]
        [Required(ErrorMessage = "Total Amount is required")]
        [Range(0, double.MaxValue, ErrorMessage = "Total must be a positive value")]
        public decimal Total { get; set; }

        [DisplayName("Account ID")]
        [Required(ErrorMessage = "Account ID is required")]
        public int AccountID { get; set; }

        [DisplayName("Products")]
        public IEnumerable<Product> Products { get; set; }
    }
}
