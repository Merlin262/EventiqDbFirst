using System;
using System.Collections.Generic;

namespace EventiqDBFirst.Models;

public partial class User
{
    public int Id { get; set; }

    public string CpfCnpj { get; set; } = null!;

    public string Name { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string Phone { get; set; } = null!;

    public string Password { get; set; } = null!;

    public string Role { get; set; } = null!;

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual ICollection<Event> Events { get; set; } = new List<Event>();

    public virtual ICollection<Purchase> Purchases { get; set; } = new List<Purchase>();

    public virtual ICollection<Ticket> Tickets { get; set; } = new List<Ticket>();
}
