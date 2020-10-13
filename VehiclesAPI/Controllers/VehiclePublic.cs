using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using VehiclesAPI.ServiceInterface;

namespace VehiclesAPI.Controllers
{

   


    [Route("api/[controller]")]
    [ApiController]
    public class VehiclePublic : ControllerBase
    {
        private IVechileService  _vehservice;

        public VehiclePublic(IVechileService vechileService)
        {
            _vehservice = vechileService;
        }


        [HttpGet]
        [Route("[action]")]
        [ResponseCache(Duration =20,Location =ResponseCacheLocation.Client)]
        public async   Task<IActionResult> VehicleForPublic()
        {
            try
            {

                var data = await _vehservice.GetVehiclesForCustomers();
                if (data!=null && data.Count() >0)
                {
                    return StatusCode(StatusCodes.Status200OK, data);
                }
                else
                {   
                    return StatusCode(StatusCodes.Status404NotFound, data);
                }
            }
            catch (Exception ex)
            {
                string error = ex.ToString() + " " + ex.InnerException?.ToString();
                return StatusCode(StatusCodes.Status400BadRequest, error);
            }
        }


    }
}
