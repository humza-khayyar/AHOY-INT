using AdminApi.ReturnModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdminApi.ServiceInterface
{
    public interface IVechileService
    {
        Task<List<VehicleReturnModel>> GetVehiclesForAdmins();
    }
}
