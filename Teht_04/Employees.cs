﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht_04
{
    class Employees
    {
    public string Name { get; set; }
    public Employees(string name) {
            Name = name;
    }
        public override string ToString()
        {
            return "Name: " + Name;
        }
    }
}
