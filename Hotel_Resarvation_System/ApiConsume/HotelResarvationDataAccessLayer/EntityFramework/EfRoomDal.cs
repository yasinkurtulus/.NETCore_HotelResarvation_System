using HotelProjectEntityLayer.Concrate;
using HotelResarvationDataAccessLayer.Abstract;
using HotelResarvationDataAccessLayer.Concrate;
using HotelResarvationDataAccessLayer.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelResarvationDataAccessLayer.EntityFramework
{
    public class EfRoomDal:GenericRepository<Room>,IRoomDal
    {
        public EfRoomDal(Context context):base(context)
        {
            
        }
    }
}
