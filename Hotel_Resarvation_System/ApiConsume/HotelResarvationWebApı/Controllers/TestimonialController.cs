using HotelProjectEntityLayer.Concrate;
using HotelResarvationBusinessLayer.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelResarvationWebApı.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestimonialController : ControllerBase
    {
        ITestimonialService _testimonialservice;
        public TestimonialController(ITestimonialService testimonialservice)
        {
            _testimonialservice = testimonialservice;
        }
        [HttpGet]
        public IActionResult TestimonialList()
        {
            var result = _testimonialservice.TGetAll();
            return Ok(result);
        }
        [HttpPost]
        public IActionResult AddTestimonial(Testimonial testimonial)
        {
            _testimonialservice.TInsert(testimonial);
            return Ok();
        }
        [HttpPut]
        public IActionResult UpdateTestimonial(Testimonial testimonial)
        {
            _testimonialservice.TUpdate(testimonial);
            return Ok();
        }
        [HttpDelete]
        public IActionResult DeleteTestimonial(int id)
        {
            var result = _testimonialservice.TGetById(id);
            _testimonialservice.TDelete(result);
            return Ok();
        }
        [HttpGet("{id}")]
        public IActionResult GetTestimonial(int id)
        {
            var result = _testimonialservice.TGetById(id);
            return Ok(result);
        }
    }
}
