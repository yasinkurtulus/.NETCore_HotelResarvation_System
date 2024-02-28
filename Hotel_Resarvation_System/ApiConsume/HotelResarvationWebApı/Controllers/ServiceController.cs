using HotelProjectEntityLayer.Concrate;
using HotelResarvationBusinessLayer.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelResarvationWebApı.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ServiceController : ControllerBase
    {
        IServiceService _serviceservice;
        public ServiceController(IServiceService serviceservice)
        {
            _serviceservice = serviceservice;
        }
        [HttpGet]
        public IActionResult ServiceList()
        {
            var result = _serviceservice.TGetAll();
            return Ok(result);
        }
        [HttpPost]
        public IActionResult AddService(Service service)
        {
            _serviceservice.TInsert(service);
            return Ok();
        }
        [HttpPut]
        public IActionResult UpdateService(Service service)
        {
            _serviceservice.TUpdate(service);
            return Ok();
        }
        [HttpDelete]
        public IActionResult DeleteService(int id)
        {
            var result = _serviceservice.TGetById(id);
            _serviceservice.TDelete(result);
            return Ok();
        }
        [HttpGet("{id}")]
        public IActionResult GetService(int id)
        {
            var result = _serviceservice.TGetById(id);
            return Ok(result);
        }
    }
}
