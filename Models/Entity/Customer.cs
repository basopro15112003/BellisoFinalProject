using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Belliso.Models.Entity;

public class Customer
{
    [Key]
    public string Username { get; set; } = null!;

    public string Password { get; set; } = null!;

    public string Fullname { get; set; } = null!;

    public string Phone { get; set; } = null!;

    public string Email { get; set; } = null!;
    public string? Avatar { get; set; }

    public virtual ICollection<DeliveryAddress> DeliveryAddresses { get; set; } = new List<DeliveryAddress>();

    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();
}
