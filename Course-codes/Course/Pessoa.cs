using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course
{
    internal class Pessoa
    {
        public string Name { get; set; }
        public double Salary { get; set; }

        public Pessoa()
        {
        }

        public Pessoa(string name, int age)
        {
            this.Name = name;
            this.Salary = age;
        }

    }
}