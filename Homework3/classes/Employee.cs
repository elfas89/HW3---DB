using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Homework3
{
    [Serializable]
    public class Employee
    {
        private string name;
        private int empNumber;
        private string empPosition;

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

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

        //пустой конструктор для XML-сериализации
        public Employee() { }

        public Employee(string name, string position, int number)
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
