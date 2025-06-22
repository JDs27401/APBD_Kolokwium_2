using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Models;

[Table("Exhibitions")]

public class Exhibition {
    [Key]
    public int ExhibitionId { get; set; }
    
    [ForeignKey(nameof(Gallery))]
    public int GalleryId { get; set; }
    
    [Column(TypeName = "VARCHAR(50)")]
    [MaxLength(50)]
    public string Title { get; set; }
    
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    
    public int NumberOfArtworks { get; set; }
    
    public ICollection<Exhibition_Artworks> Exhibition_Artworks { get; set; }
}