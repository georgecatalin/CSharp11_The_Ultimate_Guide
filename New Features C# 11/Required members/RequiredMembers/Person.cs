using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RequiredMembers
{
    internal class Person
    {
        public required string Name { get; set; }
        public int Age { get; set; }

        [SetsRequiredMembers]
        public Person() //parameterless constructor
        {
            Name = "Anonymous";
        }

        [SetsRequiredMembers]
        public Person(string name) //parameterized constructor
        { this.Name = name; }
    }
}
