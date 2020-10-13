using AdminApi.Context;
using AdminApi.ReturnModel;
using AdminApi.ServiceInterface;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdminApi.Service
{
    public class VehicleService :IVechileService    
    {
        private ApiDBContext _context;
        public VehicleService(ApiDBContext context)
        {
            _context = context;
        }
        public async Task<List<VehicleReturnModel>> GetVehiclesForAdmins()
        {
            List<VehicleReturnModel> _list = new List<VehicleReturnModel>();
            try
            {
                var dbitem = await _context.dbb_Vehicles.Where(x => x.isActive && x.Status.ToLower() == "available").ToListAsync();
                foreach (var item in dbitem)
                {
                    _list.Add(new VehicleReturnModel
                    {
                        Brand = item.Brand,
                        Maker = item.Maker,
                        Model = item.Model,
                        Plate_No = item.Plate_No,
                        Rent = item.Rent,
                        Id = item.Veh_Id,
                        IsActive = item.isActive,
                        Registration_No = item.Registration_No,
                        Status = item.Status

                    });


                }
                return _list;
            }
            catch (Exception ex)
            {
                return _list;


            }
        }
    }
}
