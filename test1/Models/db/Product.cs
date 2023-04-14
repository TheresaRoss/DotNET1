using System;
using System.Collections.Generic;

namespace test1.Models.db;

public partial class Product
{
    public int ProductId { get; set; }

    public string? ProductName { get; set; }

    public double? ProductPrice { get; set; }

    public int? CategoryId { get; set; }

    public virtual Category? Category { get; set; }
}
