using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Homework3
{
    public interface IWriter
    {
        string Data { set; } // Свойство для хранения данных, которые будут записываться
        void Write(); // Метод записи данных
    }
}
