using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INFMusicTest.Data.Entitys
{
    public class Booking
    {
        [Key]
        public int BookingID { get; set; }

        [Required]
        public DateOnly TakenSince { get; set; } = new DateOnly();

        public DateOnly TakenTill { get; set; } = new DateOnly();

        public string TakenFrom { get; set; }
    }
}
