using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Xml.Serialization;

namespace Homework3
{
    public class ReaderXml : Reader
    {
        public override void Read()
        {
            XmlSerializer formatter = new XmlSerializer(typeof(List<Employee>));
            FileInfo fileInfo = new FileInfo(File);
            if (fileInfo.Exists)
            {
                if (fileInfo.Length > 0)
                {
                    using (FileStream fs = new FileStream(File, FileMode.Open))
                    {
                        Data = (List<Employee>)formatter.Deserialize(fs);
                    }
                }
            }  
        }
    }
}
