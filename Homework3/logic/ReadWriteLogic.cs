using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Homework3
{
    public class ReadWriteLogic
    {
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

        public void ReadWriteProcess()
        {
            Reader.Read();
            Writer.Data = Reader.Data;
            Writer.Write();
        }

    }
}
