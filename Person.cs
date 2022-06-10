using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parsing_File_Xml_JSON
{
    public class Person
    {
        public string Name { get; set; } = "Undefined";
        public int Age { get; set; } = 1;

        public Person() { }
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }
}
