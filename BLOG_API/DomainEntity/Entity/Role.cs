﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDomain.Entity
{
    public class Role : BaseEntity
    {
        public required int Id { get; set; }
        public required string  Name { get; set; }
    }
}
