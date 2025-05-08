using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WebHotel.Models;

public partial class TypeRoom
{
    [Key]
    public int Id { get; set; }

    [StringLength(50)]
    public string RoomName { get; set; } = null!;

    [InverseProperty("Type")]
    public virtual ICollection<Room> Rooms { get; set; } = new List<Room>();
}
