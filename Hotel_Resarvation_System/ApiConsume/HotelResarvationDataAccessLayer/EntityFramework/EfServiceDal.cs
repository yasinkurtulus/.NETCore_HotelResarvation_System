using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelProjectEntityLayer.Concrate;
using HotelResarvationDataAccessLayer.Abstract;
using HotelResarvationDataAccessLayer.Concrate;
using HotelResarvationDataAccessLayer.Repositories;

namespace HotelResarvationDataAccessLayer.EntityFramework
{
    public class EfServiceDal:GenericRepository<Service>,IServiceDal
    {
        public EfServiceDal(Context context):base(context)
        {
            
        }
    }
}
