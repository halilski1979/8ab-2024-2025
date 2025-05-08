using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WebHotel.Models;

public partial class Room
{
    [Key]
    public int Id { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string NumberRoom { get; set; } = null!;

    public int Beds { get; set; }

    public int TypeId { get; set; }

    [Column(TypeName = "decimal(10, 2)")]
    public decimal PriceRoom { get; set; }

    [InverseProperty("Room")]
    public virtual ICollection<Reservation> Reservations { get; set; } = new List<Reservation>();

    [ForeignKey("TypeId")]
    [InverseProperty("Rooms")]
    public virtual TypeRoom? Type { get; set; } = null!;
}
