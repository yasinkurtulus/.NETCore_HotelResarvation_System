using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelResarvationDtoLayer.Dtos.RoomDtos
{
    public class UpdateRoomDto
    {
        public int RoomId { get; set; }
        public string RoomCoverImage { get; set; }
        [Required(ErrorMessage = "Please enter price information")]
        public int Price { get; set; }
        [Required(ErrorMessage = "Please enter title")]
        [StringLength(50,ErrorMessage ="You can use max 50 character")]
        public string Title { get; set; }
        [Required(ErrorMessage = "Please enter bed count information")]
        public string BedCount { get; set; }
        [Required(ErrorMessage = "Please enter bath count information")]
        public string BathCount { get; set; }
        public string Wifi { get; set; }
        [Required(ErrorMessage = "Please enter description")]
        [StringLength(200, ErrorMessage = "You can use max 200 character")]
        public string Description { get; set; }
    }
}
