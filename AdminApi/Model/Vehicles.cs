using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AdminApi.Model
{
    [Table("TblVehicle")]
    public class Vehicles
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Veh_Id { get; set; }

        public string Registration_No { get; set; }
        public string Plate_No { get; set; }
        public string Brand { get; set; }
        public string Maker { get; set; }
        public string Model { get; set; }

        public string Status { get; set; }
        public decimal Rent { get; set; }

        public bool isActive { get; set; }
    }
}
