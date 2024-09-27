namespace PersonalGameLibrary.Database.models;

public class Game
{
    public int Id { get; set; }
    public string? Name { get; set; } = null!;
    public string? ApiId { get; set; }
    public string? CoverUrl { get; set; }
    public DateOnly StartDate { get; set; } = DateOnly.FromDateTime(DateTime.Now);
    public DateOnly? EndDate { get; set; }

    public ICollection<Screenshot> Screenshots { get; set; } = new List<Screenshot>();
    public Review? Review { get; set; }
}