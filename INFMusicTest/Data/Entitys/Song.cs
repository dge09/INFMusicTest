using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INFMusicTest.Data.Entitys
{
    public class Song
    {
        [Key]
        public int SongID { get; set; }

        [Required, MaxLength(100)]
        public string Title { get; set; }

        [Required]
        public int GenreID { get; set; }

        [Required]
        public int AuthorID { get; set; }

        public DateOnly ReleaseDate { get; set; } = new DateOnly();

        public int SongLength { get; set; }

        // for easy default data addition
        public Song(int id, string title, int genreID, int authorID)
        {
            SongID = id;
            Title = title;
            GenreID = genreID;
            AuthorID = authorID;
            ReleaseDate = DateOnly.FromDateTime(DateTime.Now);
            SongLength = 278;
        }

        public Song(string title, int genreID, int authorID)
        {
            Title = title;
            GenreID = genreID;
            AuthorID = authorID;
            ReleaseDate = DateOnly.FromDateTime(DateTime.Now);
            SongLength = 278;
        }

    }
}
