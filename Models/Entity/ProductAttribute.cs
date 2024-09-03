using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Belliso.Models.Entity;

public class ProductAttribute
{
    [Key]
    public string ProId { get; set; } = null!;

    public string Feature { get; set; } = null!;

    public string Description { get; set; } = null!;

    public virtual Product Pro { get; set; } = null!;
}
