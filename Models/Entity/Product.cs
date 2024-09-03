using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Belliso.Models.Entity;

public class Product
{
    [Key]
    public string ProId { get; set; } = null!;

    public int CateId { get; set; }

    public int BrandId { get; set; }

    public string ProName { get; set; } = null!;

    public int ProQuan { get; set; }

    public double ProPrice { get; set; }

    public string ProDes { get; set; } = null!;

    public int Discount { get; set; }

    public bool IsAvailable { get; set; }

    public virtual Brand Brand { get; set; } = null!;

    public virtual Category Cate { get; set; } = null!;
}
