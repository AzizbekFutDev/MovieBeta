using System.ComponentModel.DataAnnotations.Schema;
namespace movie.Entities;
public class EnFormFile
{
    [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
    public Guid Id { get; set; }

    [Required]
    [MaxLength(255)]
    public string Title { get; set; }

    [Required]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public IFormFile File { get; set; }

    [Obsolete("Used only for Entities binding.", true)]
    public EnFormFile() { }

    public EnFormFile(string title, IFormFile file)
    {
        Id = Guid.NewGuid();
        Title = title;
        File = file;
    }
}