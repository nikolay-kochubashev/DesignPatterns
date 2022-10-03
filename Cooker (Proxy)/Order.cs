﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cooker;

public struct Order
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public string? Name { get; set; }
    public int StatusId = 0;
}

