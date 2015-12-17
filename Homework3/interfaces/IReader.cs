using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Homework3
{
    public interface IReader
    {
        string Data { get; } // Свойство для храннения считанных данных
        void Read(); // Метод считывания данных
    }
}
