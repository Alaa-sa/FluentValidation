using static FluentValidationDemo.Enums.Data;

namespace FluentValidationDemo.Models;

public class GameType
{
    public int Id { get; set; }
    public int MinAge { get; set; }
    public GamePlatform Platform { get; set; }
    public List<GameTag> Tags { get; set; }
}
