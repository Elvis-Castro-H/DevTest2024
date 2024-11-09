namespace PollAPI.Models;

public class Vote : BaseEntity<int>
{
    public string VoterEmail { get; set; } = null!;
    public int OptionId { get; set; }
    //public int OptionId { get; set; }

    public Option Option { get; set; }
}