using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WebHotel.Models;

public partial class Client
{
    [Key]
    public int Id { get; set; }

    [StringLength(100)]
    public string ClientName { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string IdCard { get; set; } = null!;

    [StringLength(100)]
    public string Address { get; set; } = null!;

    [StringLength(25)]
    [Unicode(false)]
    public string Phone { get; set; } = null!;

    [StringLength(50)]
    public string Nationality { get; set; } = null!;

    [InverseProperty("Client")]
    public virtual ICollection<Reservation> Reservations { get; set; } = new List<Reservation>();
}
