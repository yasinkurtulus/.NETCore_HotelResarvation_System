using AutoMapper;
using HotelProjectEntityLayer.Concrate;
using HotelResarvationBusinessLayer.Abstract;
using HotelResarvationDtoLayer.Dtos.RoomDtos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelResarvationWebApı.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Room2Controller : ControllerBase
    {
        private IRoomService _roomService;
        private IMapper mapper;

        public Room2Controller(IRoomService roomService, IMapper mapper)
        {
            this._roomService = roomService;
            this.mapper = mapper;

        }
        [HttpGet]
        public IActionResult RoomList()
        {
            var result = _roomService.TGetAll();
            return Ok(result);
        }
        [HttpPost]
        public IActionResult AddRoom(AddRoomDto roomAddDto)
        {
          /*  if (!ModelState.IsValid)
            {
                return BadRequest("model stateden geçmesi");
            }*/
            var result = mapper.Map<Room>(roomAddDto);
            _roomService.TInsert(result);
            return Ok();
        }
        [HttpPut]
        public IActionResult UpdateRoom(UpdateRoomDto roomUpdateDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            var result = mapper.Map<Room>(roomUpdateDto);
            _roomService.TUpdate(result);
            return Ok();
        }
    }
}
