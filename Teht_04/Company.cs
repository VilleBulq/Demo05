﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht_04
{
    class Company
    {
        public List<Employees> employees;
        public Company() {
            employees = new List<Employees>();
        }
        public void Hire(string name) {
            employees.Add(new Employees(name));
        }
        StringBuilder lista = new StringBuilder();
        public void ShowEmps()
        {
            employees.ForEach(item => Console.WriteLine(item.ToString() + ""));
        }



    }
}
