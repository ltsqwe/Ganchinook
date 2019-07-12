using MyLibrary;
using MyLibrary.Helpers;
using System.Collections.Generic;
using System.Linq;

namespace Chinook.Data
{
    public class AlbumData : EntityData<Album>
    {



        internal AlbumData()
        {
        }

        public Album GetByPK(int albumId)
        {
            using (ChinookEntities context = DbContextFactory.Create<ChinookEntities>())
            {
                return context.Albums.FirstOrDefault(x => x.AlbumId == albumId);
            }
        }

        public List<Album> Search(string title, int? artistId)
        {
            using (ChinookEntities context = DbContextFactory.Create<ChinookEntities>())
            {
                var query = from x in context.Albums
                            select x;

                if (title.HasValue())
                //if (string.IsNullOrEmpty(title) == false)
                    query = query.Where(x => x.Title.Contains(title));


                if (artistId.HasValue)
                    query = query.Where(x => x.ArtistId == artistId.Value);

                var albums = query.ToList();

                Dictionary<int, string> artistNames = context.Artists.ToDictionary(x => x.ArtistId, x => x.Name);

                foreach (var x in albums)
                {
                    string artistName = artistNames[x.ArtistId];
                    
                    x.ArtistName = artistName;
                }

                return albums;
            }
        }

        public List<Album> Search2(string title, int? artistId)
        {
            using (ChinookEntities context = DbContextFactory.Create<ChinookEntities>())
            {
                var query = from x in context.Albums
                            select new {
                                Album = x,
                                ArtistName = x.Artist.Name
                            };

                if (title.HasValue())
                //if (string.IsNullOrEmpty(title) == false)
                    query = query.Where(x => x.Album.Title.Contains(title));


                if (artistId.HasValue)
                    query = query.Where(x => x.Album.ArtistId == artistId.Value);


                var list = query.ToList();

                foreach (var x in list)
                {
                    x.Album.ArtistName = x.ArtistName;
                }

                return list.ConvertAll(x => x.Album);
            }
        }
    }
}
