using AutoMapper;
using HotelProjectEntityLayer.Concrate;
using HotelResarvationWebUI.Dtos.ServiceDto;

namespace HotelResarvationWebUI.Mapping
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<AddServiceDto,Service>().ReverseMap();
            CreateMap<UpdateServiceDto, Service>().ReverseMap();
            CreateMap<ListServiceDto, Service>().ReverseMap();
        }
    }
}
