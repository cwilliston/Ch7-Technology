﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch7_Exercises
{
    public abstract class AbstractEntity
    {
        public int Id { get; set; }
        private static int nextId = 1;

        public AbstractEntity()
        {
            Id = nextId;
            nextId++;
        }
    }
}
