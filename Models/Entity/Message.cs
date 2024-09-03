using System.ComponentModel.DataAnnotations;

namespace Belliso.Models.Entity;


public class Message
{
    [Key]
    public int Id { get; set; }
    public int CustomerId { get; set; }
    public int ManagerId { get; set; }
    public string Content { get; set; } = null!;
    public DateTime Timestamp { get; set; }
    public string? ImageUrl { get; set; }
    public virtual Customer Customer { get; set; } = null!;
    public virtual Manager Manager { get; set; } = null!;
}
