using System;
using System.Collections.Generic;

namespace EventiqDBFirst.Models;

public partial class Ticket
{
    public int Id { get; set; }

    public int? BatchId { get; set; }

    public int? UserId { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }

    public virtual Batch? Batch { get; set; }

    public virtual ICollection<CheckIn> CheckIns { get; set; } = new List<CheckIn>();

    public virtual User? User { get; set; }
}
