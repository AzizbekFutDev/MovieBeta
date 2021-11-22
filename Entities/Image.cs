namespace movie.Entities
{
    public class Image
    {
        public Image(string title, byte[] data)
        {
            Id = Guid.NewGuid();
            Title = title;
            Data = data;
            // MovieId = movieId;
        }

        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        public Guid Id { get; set; }

        [Required]
        [MaxLength(255)]
        public string Title { get; set; }

        [Required]
        public byte[] Data { get; set; }


        // public ICollection<Guid> MovieId { get; set; }
    }
}