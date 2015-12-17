using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Xml.Serialization;

namespace Homework3
{
    public class WriterXml : Writer
    {
        public override void Write()
        {
            XmlSerializer formatter = new XmlSerializer(typeof(List<Employee>));
            // Получаем поток, куда будем записывать сериализованный объект
            using (FileStream fs = new FileStream(File, FileMode.Create))
            {
                formatter.Serialize(fs, Data);
            }
        }
    }
}
