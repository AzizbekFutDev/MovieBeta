namespace movie.Services;
public interface IGenreService
{
    Task<bool> ExistsAsync(Guid id);
    Task<bool> ExistsAsync(string name);
    Task<Genre> GetAsync(Guid id);
    Task<List<Genre>> GetAllAsync();
    Task<(bool IsSuccess, Exception Exception, Genre Genre)> CreateAsync(Genre genre);
    Task<(bool IsSuccess, Exception Exception)> DeleteAsync(Guid id);
}