namespace backend.DTOs;
public record ActorDto(int Id, string Name, string Bio);
public record MovieDto(int Id, string Title, int ReleaseYear, List&lt;ActorDto&gt; Actors);
// Нов DTO за Create / Update
public record CreateMovieDto(string Title, int ReleaseYear, List&lt;int&gt;? ActorIds);