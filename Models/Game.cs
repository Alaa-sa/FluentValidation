namespace FluentValidationDemo.Models;

public class Game
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public GameType Genre { get; set; }
    public Studio Manufacturer { get; set; }
    public DateOnly DateOfProduction { get; set; }
}
