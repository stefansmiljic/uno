using System.ComponentModel.DataAnnotations;

public class PlayerState
{
    [Key]
    public string PlayerId { get; set; }
    public List<string> Hand { get; set; }
}