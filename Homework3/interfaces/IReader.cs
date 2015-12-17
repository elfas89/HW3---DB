using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Homework3
{
    public interface IReader
    {
        List<Employee> Data { get; } // Свойство для храннения считанных данных
        string File { get; set; }
        void Read(); // Метод считывания данных
    }
}
