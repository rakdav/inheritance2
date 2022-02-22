using System;
using System.Collections.Generic;
using System.Linq;

namespace inheritance2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Human human = new Human("Петр", "Петров",
                new DateTime(1989, 10, 3));
            human.Show();
            Employee employee = new Employee("Семен", "Сидоров",
                    new DateTime(1980, 07, 12), 100000);
            employee.Show();
        }
    }
}
