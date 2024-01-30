using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastFood.Models
{
    public class OrderHeader
    {
        public int Id { get; set; }
        public string ApplicationUserId {  get; set; }
        public ApplicationUser ApplicationUser { get; set; }
        [DataType(DataType.Date)]
        public DateTime OrderData { get; set; }
        public DateTime TimeofPick { get; set; }
        public DateTime DateofPick { get; set; }
        public double subTotal {  get; set; }
        public double OrderCode { get; set; }
        public double CouponDis { get; set; }
        public double CouponTotal { get; set; }
        public double TransId { get; set; }
        public string OrderStatus { get; set; }
        public string PaymentStatus { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }






    }
}
