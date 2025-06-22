using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Models;

[Table("Artwork")]

public class Artwork {
    [Key]
    public int ArtworkId { get; set; }
    
    [ForeignKey(nameof(Artist))]
    public int ArtistId { get; set; }
    
    [Column(TypeName = "VARCHAR(100)")]
    [MaxLength(100)]
    public string Title { get; set; }
    
    public int YearCreated { get; set; }
    
    public ICollection<Exhibition_Artworks> Exhibition_Artworks { get; set; }
}