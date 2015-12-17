using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Homework3
{
    public class ReaderBin : Reader
    {
        public override void Read()
        {
            using (StreamReader sr = new StreamReader("Read.txt")) // Создание объекта файла, с которого будут считываться данные
            {
                Data = sr.ReadToEnd(); // Получение данных с файла и запись в хранилище через свойство Data
            }
        }
    }
}
