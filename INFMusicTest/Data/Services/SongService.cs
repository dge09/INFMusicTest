using INFMusicTest.Data.Entitys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INFMusicTest.Data.Services
{
    public static class SongService
    {
        public static void AddSong(string title, int genreID, int authorID)
        {
            Song song = new Song(title, genreID ,authorID);

            using (var db = new MusicDBContext()) // using so it is better in resourcefullness
            {
                db.Add(song);

                db.SaveChanges();
            }


        }

        public static List<Song> GetAllSongs()
        {
            List<Song> list = new List<Song>();

            using (var db = new MusicDBContext())
            {
                var song = from a in db.Songs
                             select a;

                list.AddRange(song.ToList());
            }

            return list;
        }

    }
}
