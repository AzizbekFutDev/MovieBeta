namespace movie.Models;
public class NewFormFile
{
    [Required]
    [MaxLength(255)]
    public string Title { get; set; }

    [Required]
    public IFormFile File { get; set; }
}