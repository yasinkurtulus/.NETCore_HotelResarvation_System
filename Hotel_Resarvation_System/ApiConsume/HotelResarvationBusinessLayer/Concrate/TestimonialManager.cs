using HotelProjectEntityLayer.Concrate;
using HotelResarvationBusinessLayer.Abstract;
using HotelResarvationDataAccessLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelResarvationBusinessLayer.Concrate
{
    public class TestimonialManager : ITestimonialService
    {
        ITestimonialDal _testimonialDal;
        public TestimonialManager(ITestimonialDal testimonialdal)
        {
            _testimonialDal = testimonialdal;
        }
        public void TDelete(Testimonial entity)
        {
          _testimonialDal.Delete(entity);
        }

        public List<Testimonial> TGetAll()
        {
           return _testimonialDal.GetAll();
        }

        public Testimonial TGetById(int id)
        {
          return _testimonialDal.GetById(id);
        }

        public void TInsert(Testimonial entity)
        {
            _testimonialDal.Insert(entity);
        }

        public void TUpdate(Testimonial entity)
        {
            _testimonialDal.Update(entity);
        }
    }
}
