using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INFMusicTest.Data.Entitys
{
    public class Genre
    {
        [Key]
        public int GenreID { get; set; }

        [MaxLength(100)]
        public string Name { get; set; }

        List<Song> Songs = new List<Song>();

        public Genre(int id, string name)
        {
            GenreID = id;
            Name = name;
        }

        public Genre(string name)
        {
            Name = name;
        }
    }
}
