using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Homework3
{
    public abstract class Writer : IWriter
    {
        public string Data { protected get; set; }
        public abstract void Write();
    }
}
