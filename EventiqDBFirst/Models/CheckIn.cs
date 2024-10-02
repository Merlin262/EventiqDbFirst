using System;
using System.Collections.Generic;
using EventiqDBFirst.Models;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.OpenApi;
using Microsoft.EntityFrameworkCore;

namespace EventiqDBFirst.Models;

public partial class CheckIn
{
    public int Id { get; set; }

    public int TicketId { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }

    public virtual Ticket Ticket { get; set; } = null!;
}