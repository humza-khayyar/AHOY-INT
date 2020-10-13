using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BookingApi.Models
{
    [Table("Tbl_Order")]
    public class Orders
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Order_Id { get; set; }
        public int Cust_Id { get; set; }

        [ForeignKey("Cust_Id")]
        public virtual Customers oderCustomer { get; set; }
    }
}
