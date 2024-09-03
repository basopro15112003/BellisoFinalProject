using System.ComponentModel.DataAnnotations;

namespace Belliso.Models.Entity;

public class Order
{
    [Key]
    public string OrderId { get; set; } = null!;

    public int? ManagerId { get; set; }

    public string Username { get; set; } = null!;

    public double TotalPrice { get; set; }

    public DateOnly StartDate { get; set; }

    public DateOnly? EndDate { get; set; }

    public string? OrderDes { get; set; }

    public int Status { get; set; }

    public string Address { get; set; } = null!;

    public string PaymentMethod { get; set; } = null!;

    public int PaymentConfirm {  get; set; }             

    public virtual Manager? Manager { get; set; }

    public virtual Customer UsernameNavigation { get; set; } = null!;
}
