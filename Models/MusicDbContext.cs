using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace kolokwium2.Models
{
    public class MusicDbContext : DbContext
    {
        public MusicDbContext(DbContextOptions options) : base(options) 
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder) 
        {
            var defaultMusicianData = new List<Musician> { new Musician {
                
                IdMusician = 1,
                FirstName = "Ala",
                LastName = "Kot",
                Nickname = "SłodkiKotek"
            } };
            var defaultTrackData = new List<Track> { new Track {

                IdTrack = 1,
                TrackName = "Ładne kotki",
                Duration = 3.5,
                IdMusicAlbum = 1
            } };
            var defaultAlbumData = new List<Album> { new Album {

                IdAlbum = 1,
                AlbumName = "Kotki dwa",
                PublishDate = DateTime.ParseExact("2000-05-05", "yyyy-MM-dd", null ),
                IdMusicLabel = 1
            } };
            var defaultMusicLabelData = new List<MusicLabel> { new MusicLabel {

                IdMusicLabel = 1,
                Name = "Kotkowa"
            } };



            modelBuilder.Entity<Musician>(e =>
            {
                e.HasKey(e => e.IdMusician);

                e.Property(e => e.FirstName).HasMaxLength(30).IsRequired();
                e.Property(e => e.LastName).HasMaxLength(50).IsRequired();
                e.Property(e => e.Nickname).HasMaxLength(20);

                e.ToTable("Musician");
                e.HasData(defaultMusicianData);

            });

            modelBuilder.Entity<Musician_Track>(e =>
            {
                e.HasKey(e => e.IdMusician);

                e.HasOne(e => e.Musician).WithMany(e => e.Musician_Tracks).HasForeignKey(e => e.IdMusician).OnDelete(DeleteBehavior.ClientCascade);

                e.ToTable("Musician_Track");
                
            });


            modelBuilder.Entity<Track>(e =>
            {
                e.HasKey(e => e.IdTrack);

                e.Property(e => e.TrackName).HasMaxLength(30).IsRequired();
                e.Property(e => e.Duration).IsRequired();
             

                e.ToTable("Track");
                e.HasData(defaultTrackData);

            });


            modelBuilder.Entity<Album>(e =>
            {
                e.HasKey(e => e.IdAlbum);

                e.Property(e => e.AlbumName).HasMaxLength(30).IsRequired();
                e.Property(e => e.PublishDate).IsRequired();
              

                e.ToTable("Album");
                e.HasData(defaultAlbumData);

            });

            modelBuilder.Entity<MusicLabel>(e =>
            {
                e.HasKey(e => e.IdMusicLabel);

                e.Property(e => e.Name).HasMaxLength(50).IsRequired();
               

                e.ToTable("MusicLabel");
                e.HasData(defaultMusicLabelData);
            });

        }
    }
}
