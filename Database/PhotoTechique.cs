﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database
{
    public class PhotoTechique:Item
    {
        public PhotoTechique(string description, int price, string name, int Id) :
           base(description, price, name, Id)
        { }
    }
}
