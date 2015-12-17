using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Homework3
{
    public class WriterBin : Writer
    {
        public override void Write()
        {
            // Создаем объект BinaryFormatter
            BinaryFormatter formatter = new BinaryFormatter();
            // Получаем поток, куда будем записывать сериализованный объект
            using (FileStream fs = new FileStream(File, FileMode.Create))
            {
                formatter.Serialize(fs, Data);
            }
        }
    }
}
