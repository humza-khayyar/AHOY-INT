using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BookingApi.Models
{
    [Table("Tbl_OrderDetails")]
    public class OrderDetails
    {
        [Key]
        public int Order_DetailID { get; set; }

        public int Order_Id { get; set; }

        [ForeignKey("Order_Id")]
        public virtual Orders oderMain { get; set; }

        public int Veh_Id { get; set; }
               
        [ForeignKey("Veh_Id")]
        public virtual Vehicle oderVehicle { get; set; }
    }
}
