using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Belliso.Models.Entity;

public class ImportProduct
{
    [Key]
    public int ReceiptId { get; set; }

    public DateOnly DateImport { get; set; }

    public string PersonChange { get; set; } = null!;

    public double Payment { get; set; }
}
