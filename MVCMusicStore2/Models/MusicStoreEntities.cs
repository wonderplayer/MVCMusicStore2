using System.Data.Entity;

namespace MVCMusicStore2.Models
{
    public class MusicStoreEntities : DbContext
    {
        public DbSet<Album> Albums { get; set; }
        public DbSet<Genre> Genres { get; set; }

        public System.Data.Entity.DbSet<MVCMusicStore2.Models.Artist> Artists { get; set; }
    }
}