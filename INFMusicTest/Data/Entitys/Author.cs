using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INFMusicTest.Data.Entitys
{
    public class Author
    {
        [Key]
        public int AuthorID { get; set; }

        [MaxLength(200)]
        public string Name { get; set; }

        List<Song> Songs = new List<Song>();

        // for easy default data addition
        public Author(int id, string name)
        {
            AuthorID = id;
            Name = name;
        }

        public Author(string name)
        {
            Name = name;
        }


    }
}
