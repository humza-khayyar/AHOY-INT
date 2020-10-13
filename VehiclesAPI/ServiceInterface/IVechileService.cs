using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VehiclesAPI.Model;
using VehiclesAPI.ReturnModels;

namespace VehiclesAPI.ServiceInterface
{
   public interface IVechileService
    {

        Task<List<VehicleReturnModel>> GetVehiclesForCustomers();
    }
}
