using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WebAvtosalon.Models;

public partial class Engine
{
    [Key]
    public int Id { get; set; }

    [StringLength(50)]
    public string EngineName { get; set; } = null!;

    [InverseProperty("Engine")]
    public virtual ICollection<Car> Cars { get; set; } = new List<Car>();
}
