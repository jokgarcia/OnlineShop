using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineShop.Web.Models
{
    public class Order
    {
        public int OrderID { get; set; }
        public int CustomerID { get; set; }
        public int PaymentID { get; set; }
        public int ShippingID { get; set; }
        public int Discount { get; set; }
        public  int Taxes { get; set; }
        public decimal TotalAmount { get; set; }
        public bool isCompleted { get; set; }
        public DateTime OrderDate { get; set; }
        public bool Dispatched { get; set; }
        public DateTime DispatchedDate { get; set; }
        public bool Shipped { get; set; }
        public DateTime ShippingDate { get; set; }
        public bool Deliver { get; set; }
        public DateTime DeliveryDate { get; set; }
        public string Notes { get; set; }
        public bool CancelOrder { get; set; }
    }
}
