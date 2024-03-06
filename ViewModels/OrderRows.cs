using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NorthwindMVC2._0.ViewModels
{
    public class OrderRows
    {
        public int OrderID { get; set; }
        public int? ProductID { get; set; }
        public float UnitPrice { get; set; }
        public int Quantity { get; set; }
        public float Discount { get; set; }
        public string ProductName { get; set; }
        public int? SupplierID { get; set; }
        public int? CategoryID { get; set; }
        public string QuantityPerUnit { get; set; }
        public int UnitsInStock { get; set; }
        public int UnitsOnOrder { get; set; }
        public int ReorderLevel { get; set; }
        public bool Discontinued { get; set; }
        public string ImageLink { get; set; }
        public string CategoryName { get; set; }
        public string Description { get; set; }
        public int? OrderDetailsID { get; set; }
    }
}