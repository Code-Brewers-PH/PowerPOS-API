using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public decimal TotalAmount { get; set; }
        public string PaymentMethod { get; set; } = string.Empty;



        // Navigation Property
        [ForeignKey("ApplicationUser")]
        public int? UserId { get; set; } 
        public ApplicationUser? User { get; set; }
        public List<Product>? Products { get; set; } 
    }
}
