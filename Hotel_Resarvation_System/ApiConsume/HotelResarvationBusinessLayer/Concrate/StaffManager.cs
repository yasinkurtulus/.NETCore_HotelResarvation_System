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
    public class StaffManager : IStaffService
    {
        IStaffDal _staffDal;
        public StaffManager(IStaffDal staffdal)
        {
            _staffDal = staffdal;
        }
        public void TDelete(Staff entity)
        {
           _staffDal.Delete(entity);
        }

        public List<Staff> TGetAll()
        {
           return _staffDal.GetAll();
        }

        public Staff TGetById(int id)
        {
           return _staffDal.GetById(id);
        }

        public void TInsert(Staff entity)
        {
           _staffDal.Insert(entity);
        }

        public void TUpdate(Staff entity)
        {
           _staffDal.Update(entity);
        }
    }
}
