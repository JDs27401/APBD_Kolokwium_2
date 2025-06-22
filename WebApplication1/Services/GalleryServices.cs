using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Data;
using WebApplication1.DTOs;
using WebApplication1.Models;

namespace WebApplication1;

public class GalleryServices : IGalleryServices {
    private readonly DatabaseContext _context;

    public GalleryServices(DatabaseContext context) {
        _context = context;
    }

    public async Task<Gallery> GetGallery(int id) {
        var result = await _context.Galleries.Where(g => g.GalleryId == id)
            .Select(g => new GalleryDTO() {
                    GalleryId = g.GalleryId,
                    Name = g.Name,
                    DateCreated = g.EstablishedDate,
                    Exhibitions = g.Exhibitions
                        .Select(ex => new ExhibitionDTO() {
                                Title = ex.Title,
                                StartDate = ex.StartDate,
                                EndDate = ex.EndDate,
                                NumberOfArtworks = ex.NumberOfArtworks,
                                Exhibitions_Artworks = ex.Exhibition_Artworks
                                    .Select(a => new Artwork() {
                                            ArtworkId = a.ArtworkId,
                                            Title = a.Title,
                                        })
                            }
                        ).ToList()
                }
            ).ToListAsync();
        return result;
    } 
}