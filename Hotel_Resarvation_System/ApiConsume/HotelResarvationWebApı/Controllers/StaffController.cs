using HotelProjectEntityLayer.Concrate;
using HotelResarvationBusinessLayer.Abstract;
using HotelResarvationDataAccessLayer.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelResarvationWebUI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StaffController : ControllerBase
    {
        IStaffService _staffservice;
        public StaffController(IStaffService staffservice)
        {
            _staffservice = staffservice;
        }
        [HttpGet]
        public IActionResult StaffList()
        {
            var result = _staffservice.TGetAll();
            return Ok(result);
        }
        [HttpPost]
        public IActionResult AddStaff(Staff staff)
        {
            _staffservice.TInsert(staff);
            return Ok();
        }
        [HttpPut]
        public IActionResult UpdateStaff(Staff staff)
        {
            _staffservice.TUpdate(staff);
            return Ok();
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteStaff(int id)
        {
            var result=_staffservice.TGetById(id);
            _staffservice.TDelete(result);
            return Ok();
        }
        [HttpGet("{id}")]
        public IActionResult GetStaff(int id) { 
            var result=_staffservice.TGetById(id);
            return Ok(result);
        }
    }
}
