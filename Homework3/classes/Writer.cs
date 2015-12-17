using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Homework3
{
    public abstract class Writer : IWriter
    {
        public List<Employee> Data { protected get; set; }
        public string File { get; set; }
        public abstract void Write();
    }

}
