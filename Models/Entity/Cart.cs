using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Belliso.Models.Entity;

public class Cart
{
    [Key]
    public string Username { get; set; } = null!;

    public string ProId { get; set; } = null!;

    public string ProName { get; set; } = null!;

    public int Quantity { get; set; }

    public double Price { get; set; }

    public virtual Product Pro { get; set; } = null!;

    public virtual Customer UsernameNavigation { get; set; } = null!;
}
