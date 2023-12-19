using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INFMusicTest.Data.Entitys
{
    public class Offer
    {
        public int OfferID { get; set; }

        public int SongID { get; set; }

        public bool Availability { get; set; }
    }
}
