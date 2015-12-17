using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Homework3
{
    public class ReaderBin : Reader
    {
        public override void Read()
        {
            BinaryFormatter formatter = new BinaryFormatter();
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
