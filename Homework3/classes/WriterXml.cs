using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Homework3
{
    public class WriterXml : Writer
    {
        public override void Write()
        {
            using (StreamWriter sw = new StreamWriter("Write.txt")) // Создание объекта файла, в который будут записываться данные
            {
                sw.WriteLine(Data); // Получение данных через свойство Data и запись их в файл
            }
        }
    }
}
