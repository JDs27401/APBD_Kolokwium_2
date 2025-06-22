using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WebApplication1.Models;

[Table("Exhibition_Artworks")]

public class Exhibition_Artworks {
    [ForeignKey(nameof(Exhibition))]
    public int ExhibitionId { get; set; }
    
    [ForeignKey(nameof(Artwork))]
    public int ArtworkId { get; set; }
    
    [Precision(10, 2)]
    public decimal InsuranceValue { get; set; } 
}