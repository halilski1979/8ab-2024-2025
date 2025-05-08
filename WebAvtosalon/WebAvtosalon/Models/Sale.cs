using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WebAvtosalon.Models;

public partial class Sale
{
    [Key]
    public int Id { get; set; }

    public int CarId { get; set; }

    public int ClientId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime SaleDate { get; set; }

    [ForeignKey("CarId")]
    [InverseProperty("Sales")]
    public virtual Car? Car { get; set; } = null!;

    [ForeignKey("ClientId")]
    [InverseProperty("Sales")]
    public virtual Client? Client { get; set; } = null!;
}
