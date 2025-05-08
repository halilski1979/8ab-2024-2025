using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WebAvtosalon.Models;

public partial class Car
{
    [Key]
    public int Id { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string Brand { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string Model { get; set; } = null!;

    public int CategoryId { get; set; }

    public int EngineId { get; set; }

    [StringLength(50)]
    public string Color { get; set; } = null!;

    public int YearOfManufactur { get; set; }

    [Column(TypeName = "decimal(12, 2)")]
    public decimal PriceCar { get; set; }

    [ForeignKey("CategoryId")]
    [InverseProperty("Cars")]
    public virtual Category? Category { get; set; } = null!;

    [ForeignKey("EngineId")]
    [InverseProperty("Cars")]
    public virtual Engine? Engine { get; set; } = null!;

    [InverseProperty("Car")]
    public virtual ICollection<Sale> Sales { get; set; } = new List<Sale>();
}
