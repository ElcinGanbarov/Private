using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject.Models
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime OrderDate { get; set; }
        public decimal TotalPrice { get; set; }
        public virtual ICollection<ProductOrder> ProductOrders { get; set; }
        public string UserId { get; set; }
        [ForeignKey("UserId")]
        public virtual AppUser  User { get; set; }


    }
}
