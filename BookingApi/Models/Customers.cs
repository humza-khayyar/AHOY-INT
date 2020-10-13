using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BookingApi.Models
{
    [Table("Tbl_Customer")]
    public class Customers
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Cust_Id { get; set; }
        public string Cust_name { get; set; }
        public string Contact_No { get; set; }
        public string Cust_Address { get; set; }
    }
}
