namespace movie.Services;
public interface IMovieService
{
    Task<bool> ExistsAsync(Guid id);
    Task<Movie> GetAsync(Guid id);
    Task<List<Movie>> GetAllAsync();
    Task<List<Movie>> GetAllAsync(string title);
    Task<(bool IsSuccess, Exception Exception, Movie Movie)> CreateAsync(Movie movie);
    Task<(bool IsSuccess, Exception Exception)> UpdateAsync(Movie movie);
    Task<(bool IsSuccess, Exception Exception)> DeleteAsync(Guid id);
}