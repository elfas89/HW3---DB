using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Homework3
{
    public abstract class Reader : IReader
    {
        public List<Employee> Data { get; protected set; }
        public string File { get; set; }
        public abstract void Read();
    }
}
