using System;
using System.Collections.Generic;

namespace EventiqDBFirst.Models;

public partial class Event
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public DateTime Date { get; set; }

    public string Description { get; set; } = null!;

    public string Location { get; set; } = null!;

    public string PhotoUrl { get; set; } = null!;

    public int UserId { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual ICollection<Batch> Batches { get; set; } = new List<Batch>();

    public virtual User User { get; set; } = null!;
}
