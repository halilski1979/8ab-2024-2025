using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WebAvtosalon.Models;

public partial class Category
{
    [Key]
    public int Id { get; set; }

    [StringLength(50)]
    public string CategoryName { get; set; } = null!;

    [InverseProperty("Category")]
    public virtual ICollection<Car> Cars { get; set; } = new List<Car>();
}
