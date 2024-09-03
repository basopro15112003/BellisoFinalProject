using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace Belliso.Models.Entity;

public class ReceiptProduct
{
    [Key]
    public int ReceiptId { get; set; }

    public string ProId { get; set; } = null!;

    public string ProName { get; set; } = null!;

    public int Amount { get; set; }

    public double Price { get; set; }

    public virtual Product Pro { get; set; } = null!;

    public virtual ImportProduct Receipt { get; set; } = null!;
}
