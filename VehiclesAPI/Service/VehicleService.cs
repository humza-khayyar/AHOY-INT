using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VehiclesAPI.Context;
using VehiclesAPI.Model;
using VehiclesAPI.ReturnModels;
using VehiclesAPI.ServiceInterface;

namespace VehiclesAPI.Service
{
    public class VehicleService : IVechileService
    {
        private ApiDBContext _context;

        public VehicleService(ApiDBContext context)
        {
            _context = context;
        }
        public async Task<List<VehicleReturnModel>> GetVehiclesForCustomers()
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
                        Rent = item.Rent

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
