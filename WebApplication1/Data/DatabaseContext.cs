using Microsoft.EntityFrameworkCore;
using WebApplication1.Models;

namespace WebApplication1.Data;

public class DatabaseContext : DbContext {
    public DbSet<Gallery> Galleries { get; set; }
    public DbSet<Artwork> Artworks { get; set; }
    public DbSet<Artist> Artists { get; set; }
    public DbSet<Exhibition> Exhibitions { get; set; }
    public DbSet<Exhibition_Artworks> Exhibition_Artworks { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
        optionsBuilder.UseSqlServer("Data Source=localhost, 1433; User=SA; Password=yourStrong(!)Password; Initial Catalog=apbd; Integrated Security=False;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False");
    }

    protected DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options) {
    }

    public DatabaseContext(DbContextOptions options) : base(options) {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder) {
        modelBuilder.Entity<Artist>().HasData(new List<Artist>() {
            new Artist() {ArtistId = 1, FristName = "Jan", LastName = "Matejko", BirthDate = new DateTime(1920, 1, 1) },
            new Artist() {ArtistId = 2, FristName = "Van", LastName = "Goth", BirthDate = new DateTime(1940, 2, 2) },
            new Artist() {ArtistId = 3, FristName = "Pablo", LastName = "Picasso", BirthDate = new DateTime(1960, 3, 3) },    
            }
        );

        modelBuilder.Entity<Exhibition>().HasData(new List<Exhibition>() {
            new Exhibition() {ExhibitionId = 1, Title = "Wystawa 1", StartDate = new DateTime(2025, 1 ,1), 
                EndDate = new DateTime(2025, 12, 1), NumberOfArtworks = 1, GalleryId = 1},
            new Exhibition() {ExhibitionId = 2, Title = "Wystawa 2", StartDate = new DateTime(2025, 2 ,2),
                EndDate = new DateTime(2025, 12, 2), NumberOfArtworks = 1, GalleryId = 2},
        });

        modelBuilder.Entity<Exhibition_Artworks>().HasData(new List<Exhibition_Artworks>() {
            new Exhibition_Artworks() {ArtworkId = 1, ExhibitionId = 1, InsuranceValue = 100000},
            new Exhibition_Artworks() {ArtworkId = 2, ExhibitionId = 2, InsuranceValue = 200000},
        });

        modelBuilder.Entity<Gallery>().HasData(new List<Gallery>()
            {
                new Gallery() {GalleryId = 1, Name = "Muzem Sztuki Nowoczesnej", EstablishedDate = new DateTime(2020, 1, 1)},
                new Gallery() {GalleryId = 2, Name = "Muzem Sztuki Narodowej", EstablishedDate = new DateTime(1933, 2, 2)},
            }
        );

        modelBuilder.Entity<Artwork>().HasData(new List<Artwork>()
            {
                new Artwork() {ArtistId = 1, ArtworkId = 1, Title = "Artwork 1", YearCreated = 1990},
                new Artwork() {ArtistId = 1, ArtworkId = 1, YearCreated = 1991, Title = "Artwork 2"},
            }
        );
    }
    
    
}