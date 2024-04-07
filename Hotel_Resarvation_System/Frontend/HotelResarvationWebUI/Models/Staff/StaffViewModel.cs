using System.ComponentModel.DataAnnotations;

namespace HotelResarvationWebUI.Models.Staff
{
    public class StaffViewModel
    {
        public int StaffId { get; set; }
        public string Name { get; set; }
        public string Position { get; set; }
    }
}
