﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract_Classes_Assignment
{
    class Employee : Person
    {
        public override void SayName()
        {
            Console.WriteLine("Name: {0} {1} ", firstName, lastName);
        }

    }
}
