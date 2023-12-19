using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INFMusicTest.Data.Entitys
{
    public class Offer
    {
        [Key]
        public int OfferID { get; set; }

        [Required]
        public int SongID { get; set; }

        public bool Availability { get; set; }

        public Offer(int offerid, int songID, bool availability)
        {
            OfferID = offerid;
            SongID = songID;
            Availability = availability;
        }


        public Offer(int songID, bool availability)
        {
            SongID = songID;
            Availability = availability;
        }
    }
}
