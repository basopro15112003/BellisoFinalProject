using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Belliso.Models.Entity;

public class OrderDetail
{
    [Key]
    public string OrderId { get; set; } = null!;

    public string ProId { get; set; } = null!;

    public string ProName { get; set; } = null!;

    public int Quantity { get; set; }

    public double Price { get; set; }

    public virtual Order Order { get; set; } = null!;

    public virtual Product Pro { get; set; } = null!;
}
