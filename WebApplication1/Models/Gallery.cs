using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Models;

[Table("Gallery")]

public class Gallery {
    [Key]
    public int GalleryId { get; set; }
    
    [Column(TypeName = "VARCHAR(50)")]
    [MaxLength(50)]
    public string Name { get; set; }
    
    public DateTime EstablishedDate { get; set; }
    
    public ICollection<Exhibition> Exhibitions { get; set; }
}