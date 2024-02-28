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
    public class RoomManager : IRoomService
    {
        public IRoomDal _roomDal;
        public RoomManager(IRoomDal roomdal)
        {
            _roomDal = roomdal;
        }
        public void TDelete(Room entity)
        {
           _roomDal.Delete(entity);
        }

        public List<Room> TGetAll()
        {
          return  _roomDal.GetAll();
        }

        public Room TGetById(int id)
        {
            return _roomDal.GetById(id);
        }

        public void TInsert(Room entity)
        {
           _roomDal.Insert(entity);
        }

        public void TUpdate(Room entity)
        {
            _roomDal.Update(entity);
        }
    }
}
