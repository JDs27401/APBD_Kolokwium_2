using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Models;

[Table("Artists")]

public class Artist {
    [Key]
    public int ArtistId { get; set; }
    
    [Column(TypeName = "VARCHAR(100)")]
    [MaxLength(100)]
    public string FristName { get; set; }
    
    [Column(TypeName = "VARCHAR(100)")]
    [MaxLength(100)]
    public string LastName { get; set; }
    
    public DateTime BirthDate { get; set; }
    
    public ICollection<Artwork> Artworks { get; set; }
}