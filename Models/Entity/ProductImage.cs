using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Belliso.Models.Entity;

public class ProductImage
{
    [Key]
    public string ProId { get; set; } = null!;

    public string ProImg { get; set; } = null!;

    public virtual Product Pro { get; set; } = null!;
}
