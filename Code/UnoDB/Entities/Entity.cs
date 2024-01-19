using System.ComponentModel.DataAnnotations;
namespace Uno.Entities;

public record IEntity
{
    [Key]
    public int Id { get; set; }
}