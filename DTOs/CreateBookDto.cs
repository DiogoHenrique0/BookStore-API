using BookStore.Enums;
using System.ComponentModel.DataAnnotations;

namespace BookStore.DTOs;

public class CreateBookDto
{
    [Required]
    [StringLength(120, MinimumLength = 2)]
    public string Title { get; set; } = string.Empty;

    [Required]
    [StringLength(120, MinimumLength = 2)]
    public string Author { get; set; }

    [Required]
    public Genre Genre { get; set; }

    [Required]
    [Range(0, double.MaxValue)]
    public decimal Price { get; set; }

    [Required]
    [Range(0, double.MaxValue)]
    public int Stock { get; set; }

}
