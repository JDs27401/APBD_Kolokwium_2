using System.ComponentModel.DataAnnotations;
using WebApplication1.Models;

namespace WebApplication1.DTOs;

public class GalleryDTO {
    [Required]
    public int GalleryId { get; set; }
    [Required]
    public string Name { get; set; }
    [Required]
    public DateTime DateCreated { get; set; }
    
    public ICollection<Exhibition> Exhibitions { get; set; }
}

public class ExhibitionDTO {
    [Required]
    public int GalleryId { get; set; }
    [Required]
    public string Title { get; set; }
    [Required]
    public DateTime StartDate { get; set; }
    [Required]
    public DateTime EndDate { get; set; }
    [Required]
    public int NumberOfArtworks { get; set; }
    
    public Exhibition_ArtworksDTO Exhibitions_Artworks { get; set; }
}

public class Exhibition_ArtworksDTO {
    [Required]
    public int ExhibitionId { get; set; }
    [Required]
    public int ArtworkId { get; set; }
    [Required]
    public decimal Price { get; set; }
    [Required]
    public ArtworkDTO Artwork { get; set; }
    
}

public class ArtworkDTO {
    [Required]
    public int ArtworkId { get; set; }
    [Required]
    public int ArtistId { get; set; }
    [Required]
    public string Title { get; set; }
    [Required]
    public int YearCreated { get; set; }
}