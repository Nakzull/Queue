using System;
using System.Collections.Generic;
using System.Text;

namespace Queue
{
    class Customer
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Customer(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }
}
