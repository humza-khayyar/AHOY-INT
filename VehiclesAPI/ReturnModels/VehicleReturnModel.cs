﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VehiclesAPI.ReturnModels
{
    public class VehicleReturnModel
    {
        public string Registration_No { get; set; }
        public string Plate_No { get; set; }
        public string Brand { get; set; }
        public string Maker { get; set; }
        public string Model { get; set; }

        public string Status { get; set; }
        public decimal Rent { get; set; }
    }
}
