using System.ComponentModel.DataAnnotations;

namespace HotelResarvationWebUI.Dtos.ServiceDto
{
    public class AddServiceDto
    {
        [Required(ErrorMessage ="Please enter service ıcon")]
        public string ServiceIcon { get; set; }
        [Required(ErrorMessage = "Please enter Title")]
        [StringLength(50,ErrorMessage ="Title must be lower than 50 character")]
        public string Title { get; set; }
        public string Description { get; set; }
    }
}
