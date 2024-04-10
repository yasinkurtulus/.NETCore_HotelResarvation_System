using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelResarvationDtoLayer.Dtos.RoomDtos
{
    public class AddRoomDto
    {
        public string RoomCoverImage { get; set; }
        [Required(ErrorMessage ="Please enter price information")]
        public int Price { get; set; }
        [Required(ErrorMessage = "Please enter title")]
        public string Title { get; set; }
        [Required(ErrorMessage = "Please enter bed count information")]
        public string BedCount { get; set; }
        public string BathCount { get; set; }
        public string Wifi { get; set; }
        public string Description { get; set; }
    }
}
