using BookingApi.ParameterModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookingApi.ServiceInterface
{
    public interface CustomerOrderInterface
    {
        Task<bool> AddCustomerOrder(CustomerReservation reservation);

    }
}
