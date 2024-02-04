using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class Inventory
    {
        public int Id { get; set; }
        public int Quantity { get; set; }
        public decimal PurchasePrice { get; set; }
        public DateTime PurchaseDate { get; set; }


        // Navigation Property
        [ForeignKey("Product")]
        public int ProductId { get; set; }
        public Product? Product { get; set; } 
    }
}
