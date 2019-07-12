using MyLibrary;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;

namespace Chinook.Data
{
    public class TrackData : EntityData<Track>
    {
        internal TrackData()
        {
        }

        public int GetCountByAlbumId(int albumId)
        {
            using (ChinookEntities context = 
                DbContextFactory.Create<ChinookEntities>())
            {
                var query = from x in context.Tracks
                            where x.AlbumId ==albumId
                            select x;

                return query.Count();
            }
        }
    }
}
