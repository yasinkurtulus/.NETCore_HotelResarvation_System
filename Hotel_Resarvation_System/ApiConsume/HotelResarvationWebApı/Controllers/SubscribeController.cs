using HotelProjectEntityLayer.Concrate;
using HotelResarvationBusinessLayer.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelResarvationWebApı.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SubscribeController : ControllerBase
    {
        ISubscribeService _subscribeservice;
        public SubscribeController(ISubscribeService subscribeservice)
        {
            _subscribeservice = subscribeservice;
        }
        [HttpGet]
        public IActionResult SubscribeList()
        {
            var result = _subscribeservice.TGetAll();
            return Ok(result);
        }
        [HttpPost]
        public IActionResult AddSubscribe(Subscribe subscribe)
        {
            _subscribeservice.TInsert(subscribe);
            return Ok();
        }
        [HttpPut]
        public IActionResult UpdateSubscribe(Subscribe subscribe)
        {
            _subscribeservice.TUpdate(subscribe);
            return Ok();
        }
        [HttpDelete]
        public IActionResult DeleteSubscribe(int id)
        {
            var result = _subscribeservice.TGetById(id);
            _subscribeservice.TDelete(result);
            return Ok();
        }
        [HttpGet("{id}")]
        public IActionResult GetSubscribe(int id)
        {
            var result = _subscribeservice.TGetById(id);
            return Ok(result);
        }
    }
}
