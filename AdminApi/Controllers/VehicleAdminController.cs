using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AdminApi.ServiceInterface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AdminApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VehicleAdminController : ControllerBase
    {

        private IVechileService _vehservice;

     
        public VehicleAdminController(IVechileService vechileService)
        {
            _vehservice = vechileService;
        }

        [HttpGet]
        [Route("[action]")]
        [ResponseCache(Duration = 20, Location = ResponseCacheLocation.Client)]
        public async Task<IActionResult> VehicleForAdmin()
        {
            try
            {

                var data = await _vehservice.GetVehiclesForAdmins();
                if (data != null && data.Count() > 0)
                {
                    return StatusCode(StatusCodes.Status400BadRequest, data);
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
