﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Entity
{
    public class User : BaseEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
