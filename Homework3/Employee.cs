using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Homework3
{
    class Employee : Person
    {
        private int empNumber;
        private string empPosition;

        public int EmpNumber
        {
            get
            {
                return empNumber;
            }
        }

        public string EmpPosition
        {
            get
            {
                return empPosition;
            }
            set
            {
                empPosition = value;
            }
        }


        public Employee(string name, string position, int number)
            : base(name)
        {
            Name = name;
            empPosition = position;
            empNumber = number;
        }

        public override string ToString()
        {
            return "Работник " + Name + ", должность " + empPosition + ", номер в базе " + empNumber;
        }
        
    }
}
