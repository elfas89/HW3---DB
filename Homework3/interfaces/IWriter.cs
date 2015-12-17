using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Homework3
{
    public interface IWriter
    {
        List<Employee> Data { set; } // Свойство для хранения данных, которые будут записываться
        string File { get; set; }   // свойство для имени файла
        void Write(); // Метод записи данных
    }
}
