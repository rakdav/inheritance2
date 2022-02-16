using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance2
{
    internal class Human
    {
        private string _firstName;
        private string _lastName;
        private DateTime _birthDay;

        public Human(string firstName, string lastName)
        {
            _firstName = firstName;
            _lastName = lastName;
        }

        public Human(string firstName, string lastName, DateTime birthDay) : this(firstName, lastName)
        {
            _birthDay = birthDay;
        }
        public void Show()
        {
            Console.WriteLine($"Фамилия:{_firstName}\n" +
                $"Имя:{_lastName}\n" +
                $"Дата рождения:{_birthDay}");
        }
    }
}
