using INFMusicTest.Data.Entitys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INFMusicTest.Data.Services
{
    public static class AuthorService
    {
        public static void AddAuthor(string name)
        {
            Author author = new Author(name);

            using (var db = new MusicDBContext())
            {
                db.Add(author);

                db.SaveChanges();
            }

            
        }

        public static List<Author> GetAllAuthors()
        {
            List<Author> list = new List<Author>();

            using (var db = new MusicDBContext())
            {
                var author = from a in db.Authors
                             select a;

                list.AddRange(author.ToList());
            }

            return list;
        }
    }
}
