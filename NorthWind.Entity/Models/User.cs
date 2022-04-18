﻿using NorthWind.Entity.Base;
using System;
using System.Collections.Generic;

#nullable disable

namespace NorthWind.Entity.Models
{
    public partial class User:EntityBase
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string UserLastName { get; set; }
        public string UserCode { get; set; }
        public string Password { get; set; }
    }
}
