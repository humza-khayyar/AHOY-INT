using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookingApi.ParameterModel
{
    public class CustomerReservation
    {
        public int Customer_Id { get; set; }
        public List<int> vehicle_Id{ get; set; }
    }
}
