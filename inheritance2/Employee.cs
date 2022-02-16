using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance2
{
    internal class Employee:Human
    {
        private double salary;

        public Employee(string fName,string lName,double salary):base(fName,lName)
        {
            this.salary = salary;
        }
        public Employee(string fName, string lName,DateTime birth, double salary) : base(fName,lName,birth)
        {
            this.salary = salary;
        }
    }
}
