﻿using System;
using System.Collections.Generic;

namespace EventiqDBFirst.Models;

public partial class Purchase
{
    public int Id { get; set; }

    public int? UserId { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }

    public virtual User? User { get; set; }
}
