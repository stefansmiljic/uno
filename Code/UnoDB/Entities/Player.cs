using System.ComponentModel.DataAnnotations;

namespace Uno.Entities;

public record Player : IEntity
{
    public List<string> Hand { get; init; }
}