namespace movie.Services;
public interface IActorService
{
    Task<bool> ExistsAsync(Guid id);
    Task<Actor> GetAsync(Guid id);
    Task<List<Actor>> GetAllAsync();
    Task<List<Actor>> GetAllAsync(string fullname);
    Task<(bool IsSuccess, Exception Exception, Actor Actor)> CreateAsync(Actor actor);
    Task<(bool IsSuccess, Exception Exception)> UpdateAsync(Actor actor);
    Task<(bool IsSuccess, Exception Exception)> DeletAsync(Guid id);
}