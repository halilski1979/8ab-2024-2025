using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WebHotel.Models;

public partial class Reservation
{
    [Key]
    public int Id { get; set; }

    public int ClientId { get; set; }

    public int RoomId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime DateReservation { get; set; }

    public int StayDuration { get; set; }

    [ForeignKey("ClientId")]
    [InverseProperty("Reservations")]
    public virtual Client? Client { get; set; } = null!;

    [ForeignKey("RoomId")]
    [InverseProperty("Reservations")]
    public virtual Room? Room { get; set; } = null!;
}
