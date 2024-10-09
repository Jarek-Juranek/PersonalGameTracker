namespace GameLibraryDB.Database.models;

public class Review
{
    public int Id { get; set; }
    public string Text { get; set; }
    public double Score { get; set; }

    public int GameId { get; set; }
    public Game Game { get; set; } = null!;
}