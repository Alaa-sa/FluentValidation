using FluentValidation.Results;
using FluentValidationDemo.Models;
using FluentValidationDemo.Validators;
using static FluentValidationDemo.Enums.Data;

Studio epicGames = new Studio
{
    Name = "Epic Games",
    TotalRevenue = 1000000000,
    YearOfEstablishment = 1991,
    Address = new Address
    {
        City = "Los Angeles",
        Country = "USA",
        Street = "123 Main Street",
        ZipCode = "12345"
    }
};
Game fortnite = new Game
{
    Id = 1,
    Name = "Fortnite",
    Description = "Shooting game for kids",
    Manufacturer = epicGames,
    Genre = new GameType
    {
        MinAge = 6,
        Tags = new List<GameTag> { GameTag.TPS, GameTag.Survival},
        Platform = GamePlatform.PC
    }
};

// validators
GameValidator gv = new GameValidator();

ValidationResult result = gv.Validate(fortnite);

if (result.IsValid)
{
    Console.WriteLine("Game is valid");
}
else
{
    Console.WriteLine("Game is invalid");
    foreach (var error in result.Errors)
    {
        Console.WriteLine(error.ErrorMessage);
    }
}

// check the documentation from https://docs.fluentvalidation.net/en/latest/index.html
