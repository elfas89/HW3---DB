using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Homework3
{
    public class ReadWriteLogic
    {
        public List<Employee> Data { get; set; }
        public string File { get; set; }

        //свойства для инъекции зависимости
        public IReader Reader { get; set; }
        public IWriter Writer { get; set; }

        //пустой конструктор
        public ReadWriteLogic() { }
        //конструктор для инъекции зависимости
        public ReadWriteLogic(IReader reader, IWriter writer)
        {
            Reader = reader;
            Writer = writer;
        }

        public void Read()
        {
            Reader.File = File;
            Reader.Read();
            Data = Reader.Data;

        }

        public void Write()
        {
            Writer.File = File;
            Writer.Data = Data;
            Writer.Write();
        }

    }
}
