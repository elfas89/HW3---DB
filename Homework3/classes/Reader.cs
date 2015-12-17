using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Homework3
{
    public abstract class Reader : IReader
    {
        public string Data { get; protected set; }
        public abstract void Read();
    }
}
