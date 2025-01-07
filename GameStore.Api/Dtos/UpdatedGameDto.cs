namespace GameStore.Api.Dtos;

public record class UpdatedGameDto(
    string Name, 
    string Genre, 
    decimal Price,
    DateOnly ReleaseDate
);
