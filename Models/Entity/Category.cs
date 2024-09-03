using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Belliso.Models.Entity;

public class Category
{
    [Key]
    public int CateId { get; set; }

    public string CateName { get; set; } = null!;

    public string Keyword { get; set; } = null!;

    public bool IsAvailable { get; set; }

    public virtual ICollection<Product> Products { get; set; } = new List<Product>();
}
