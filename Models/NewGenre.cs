namespace movie.Models;
public class NewGenre
{
    [MaxLength(20)]
    [Required]
    public string Name { get; set; }
}