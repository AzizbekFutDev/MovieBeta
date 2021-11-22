namespace movie.Mappers;

public static class ModelEntityMappers
{
    public static Genre ToEntity(this NewGenre genre)
        => new Genre(name: genre.Name);
    public static Actor ToEntity(this NewActor actor)
        => new Actor(
            fullname: actor.Fullname,
            birthdate: actor.Birthdate,
            movies: default);
    public static Movie ToEntity(this NewMovie movie, IEnumerable<Actor> actors, IEnumerable<Genre> genres)
        => new Movie(
            title: movie.Title,
            description: movie.Description,
            rating: movie.Rating,
            realiseDate: movie.RealiseDate,
            actors: actors.ToList(),
            genres: genres.ToList());

    public static Image ToEntity(this ImageReview image, byte[] imageData)
        => new Image(
                title: image.Title,
                data: imageData);
}