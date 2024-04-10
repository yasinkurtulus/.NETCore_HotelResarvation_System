using AutoMapper;
using HotelProjectEntityLayer.Concrate;
using HotelResarvationDtoLayer.Dtos.RoomDtos;

namespace HotelResarvationWebApı.Mapping
{
    public class AutoMapperProfile:Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<AddRoomDto, Room>().ReverseMap();
            CreateMap<UpdateRoomDto, Room>().ReverseMap();
        }
    }
}
