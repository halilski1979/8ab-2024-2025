using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WebAvtosalon.Models;

public partial class Client
{
    [Key]
    public int Id { get; set; }

    [StringLength(50)]
    public string FirstName { get; set; } = null!;

    [StringLength(50)]
    public string LastName { get; set; } = null!;

    [Column("GSM")]
    [StringLength(50)]
    [Unicode(false)]
    public string Gsm { get; set; } = null!;

    [InverseProperty("Client")]
    public virtual ICollection<Sale> Sales { get; set; } = new List<Sale>();
}
