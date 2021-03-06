// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using kolokwium2.Models;

namespace kolokwium2.Migrations
{
    [DbContext(typeof(MusicDbContext))]
    [Migration("20220609125900_dodano wartosci do tabel")]
    partial class dodanowartoscidotabel
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.16")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("kolokwium2.Models.Album", b =>
                {
                    b.Property<int>("IdAlbum")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AlbumName")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<int>("IdMusicLabel")
                        .HasColumnType("int");

                    b.Property<int?>("MusicLabelIdMusicLabel")
                        .HasColumnType("int");

                    b.Property<DateTime>("PublishDate")
                        .HasColumnType("datetime2");

                    b.HasKey("IdAlbum");

                    b.HasIndex("MusicLabelIdMusicLabel");

                    b.ToTable("Album");

                    b.HasData(
                        new
                        {
                            IdAlbum = 1,
                            AlbumName = "Kotki dwa",
                            IdMusicLabel = 1,
                            PublishDate = new DateTime(2000, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("kolokwium2.Models.MusicLabel", b =>
                {
                    b.Property<int>("IdMusicLabel")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("IdMusicLabel");

                    b.ToTable("MusicLabel");

                    b.HasData(
                        new
                        {
                            IdMusicLabel = 1,
                            Name = "Kotkowa"
                        });
                });

            modelBuilder.Entity("kolokwium2.Models.Musician", b =>
                {
                    b.Property<int>("IdMusician")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Nickname")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("IdMusician");

                    b.ToTable("Musician");

                    b.HasData(
                        new
                        {
                            IdMusician = 1,
                            FirstName = "Ala",
                            LastName = "Kot",
                            Nickname = "SłodkiKotek"
                        });
                });

            modelBuilder.Entity("kolokwium2.Models.Musician_Track", b =>
                {
                    b.Property<int>("IdMusician")
                        .HasColumnType("int");

                    b.Property<int?>("TrackIdTrack")
                        .HasColumnType("int");

                    b.HasKey("IdMusician");

                    b.HasIndex("TrackIdTrack");

                    b.ToTable("Musician_Track");
                });

            modelBuilder.Entity("kolokwium2.Models.Track", b =>
                {
                    b.Property<int>("IdTrack")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("AlbumIdAlbum")
                        .HasColumnType("int");

                    b.Property<double>("Duration")
                        .HasColumnType("float");

                    b.Property<int>("IdMusicAlbum")
                        .HasColumnType("int");

                    b.Property<string>("TrackName")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("IdTrack");

                    b.HasIndex("AlbumIdAlbum");

                    b.ToTable("Track");

                    b.HasData(
                        new
                        {
                            IdTrack = 1,
                            Duration = 3.5,
                            IdMusicAlbum = 1,
                            TrackName = "Ładne kotki"
                        });
                });

            modelBuilder.Entity("kolokwium2.Models.Album", b =>
                {
                    b.HasOne("kolokwium2.Models.MusicLabel", "MusicLabel")
                        .WithMany("Albums")
                        .HasForeignKey("MusicLabelIdMusicLabel");

                    b.Navigation("MusicLabel");
                });

            modelBuilder.Entity("kolokwium2.Models.Musician_Track", b =>
                {
                    b.HasOne("kolokwium2.Models.Musician", "Musician")
                        .WithMany("Musician_Tracks")
                        .HasForeignKey("IdMusician")
                        .OnDelete(DeleteBehavior.ClientCascade)
                        .IsRequired();

                    b.HasOne("kolokwium2.Models.Track", "Track")
                        .WithMany("Musician_Tracks")
                        .HasForeignKey("TrackIdTrack");

                    b.Navigation("Musician");

                    b.Navigation("Track");
                });

            modelBuilder.Entity("kolokwium2.Models.Track", b =>
                {
                    b.HasOne("kolokwium2.Models.Album", "Album")
                        .WithMany("Tracks")
                        .HasForeignKey("AlbumIdAlbum");

                    b.Navigation("Album");
                });

            modelBuilder.Entity("kolokwium2.Models.Album", b =>
                {
                    b.Navigation("Tracks");
                });

            modelBuilder.Entity("kolokwium2.Models.MusicLabel", b =>
                {
                    b.Navigation("Albums");
                });

            modelBuilder.Entity("kolokwium2.Models.Musician", b =>
                {
                    b.Navigation("Musician_Tracks");
                });

            modelBuilder.Entity("kolokwium2.Models.Track", b =>
                {
                    b.Navigation("Musician_Tracks");
                });
#pragma warning restore 612, 618
        }
    }
}
