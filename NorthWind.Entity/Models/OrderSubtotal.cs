﻿using NorthWind.Entity.Base;
using System;
using System.Collections.Generic;

#nullable disable

namespace NorthWind.Entity.Models
{
    public partial class OrderSubtotal:EntityBase
    {
        public int OrderId { get; set; }
        public decimal? Subtotal { get; set; }
    }
}
