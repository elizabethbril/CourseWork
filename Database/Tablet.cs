﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database
{
    public class Tablet:Item
    {
        public Tablet(string description, int price, string name) :
           base(description, price, name)
        { }
    }
}