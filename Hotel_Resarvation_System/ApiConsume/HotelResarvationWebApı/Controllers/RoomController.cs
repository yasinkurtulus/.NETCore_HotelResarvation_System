using HotelProjectEntityLayer.Concrate;
using HotelResarvationBusinessLayer.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelResarvationWebUI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoomController : Controller
    {
        IRoomService _roomservice;
        public RoomController(IRoomService roomservice)
        {
            _roomservice = roomservice;
        }
        [HttpGet]
        public IActionResult RoomList()
        {
            var result = _roomservice.TGetAll();
            return Ok(result);
        }
        [HttpPost]
        public IActionResult AddRoom(Room room)
        {
            _roomservice.TInsert(room);
            return Ok();
        }
        [HttpPut]
        public IActionResult UpdateRoom(Room room)
        {
            _roomservice.TUpdate(room);
            return Ok();
        }
        [HttpDelete]
        public IActionResult DeleteRoom(int id)
        {
            var result = _roomservice.TGetById(id);
            _roomservice.TDelete(result);
            return Ok();
        }
        [HttpGet("{id}")]
        public IActionResult GetRoom(int id)
        {
            var result = _roomservice.TGetById(id);
            return Ok(result);
        }


    }
}
