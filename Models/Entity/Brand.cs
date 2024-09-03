using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Belliso.Models.Entity;

public class Brand
{
    [Key]
    public int BrandId { get; set; }

    public string BrandName { get; set; } = null!;

    public string BrandLogo { get; set; } = null!;

    public bool IsAvailable { get; set; }

    public virtual ICollection<Product> Products { get; set; } = new List<Product>();
}
