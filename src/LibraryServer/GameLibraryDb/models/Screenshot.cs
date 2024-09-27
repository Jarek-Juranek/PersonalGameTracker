namespace GameLibraryDb.models;

public class Screenshot
{
    public int Id { get; set; }
    public string? Description { get; set; }
    public string ImgName { get; set; }

    public int GameId { get; set; }
    public Game Game { get; set; } = null!;
}