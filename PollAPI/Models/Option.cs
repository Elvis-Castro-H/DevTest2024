namespace PollAPI.Models;

public class Option : BaseEntity<int>
{
    public string Name { get; set; } = null!;
    public int Votes { get; set; }
}