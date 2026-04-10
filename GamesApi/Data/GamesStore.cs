using GameApi.Models;
namespace GameApi.Data;

public static class GameStore
{
    private static int _nextId = 4;
    public static List<Game> Games { get; } = new()
    {
        new Game
        {
            Id = 1,
    Title = "Super Igra",
    Genre = "RPG",
    ReleaseYear = 2006,
        },
        new Game
        {
            Id = 2,
            Title = "Krytaia Igra: 2",
            Genre = "RPG",
            ReleaseYear = 2015,
        },
        new Game
        {
            Id = 3,
            Title = "WOW Igra: 3",
            Genre = "Action-Adventure",
            ReleaseYear = 2004,
        },
    };
    public static int NextId() => _nextId++;
}