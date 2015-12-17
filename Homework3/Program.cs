using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Homework3
{
    class Program
    {
        static void Main(string[] args)
        {
            //определяем формат для сериализации
            string formatType = "";
            string path = "options.ini";
            FileInfo file = new FileInfo(path);
            if (file.Exists)
            {
                using (StreamReader sr = new StreamReader(path))
                {
                    formatType = sr.ReadToEnd();
                   // Console.WriteLine(formatType);
                }
            }
            else
            {
                Console.WriteLine("Файл настроек \"options.ini\" не найден! Программа завершает работу");
                return;
            }



            //Console.WriteLine(formatType);

            ReadWriteLogic process = new ReadWriteLogic();
            switch (formatType)
            {
                case "BIN":
                    ReaderBin binRead = new ReaderBin();
                    WriterBin binWrite = new WriterBin();
                    process.Reader = binRead;
                    process.Writer = binWrite;
                    process.File = "workers.dat";
                    Console.WriteLine("файл BIN");
                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                    Console.ReadLine();
                    break;
                case "XML":
                    ReaderXml xmlRead = new ReaderXml();
                    WriterXml xmlWrite = new WriterXml();
                    process.Reader = xmlRead;
                    process.Writer = xmlWrite;
                    process.File = "workers.xml";
                    Console.WriteLine("файл XML");
                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                    Console.ReadLine();
                    break;
                default:
                    Console.WriteLine("Недопустимая настройка в файле \"options.ini\", программа завершает работу");
                    return;
            }



            //коллекция работников
            List<Employee> WorkersList = new List<Employee>();
            //WorkersList.Add(new Employee("John", "Lead Victim", 1));
            //WorkersList.Add(new Employee("Steve", "Tech Victim", 2));

            //проверка наличия данных при запуске
            process.Read();
            if (process.Data != null)
            {
                WorkersList = process.Data;
            }


            while (true)
            {
                //Console.Clear();
                //foreach (var w in WorkersList)
                //{
                //    Console.WriteLine(w.ToString());
                //}
                //Console.WriteLine();

                Console.Write("Введите команду: ");

                string[] commands = Console.ReadLine().Split(' ');

                if (commands[0].ToLower() == "exit" & commands.Length == 1)
                {
                    //запись в свойство
                    process.Data = WorkersList;
                    //запись в файл
                    process.Write();
                    return;
                }

                if (commands[0].ToLower() == "help" && commands.Length == 1)
                {
                    Help();
                }


                if (commands[0].ToLower() == "add" && commands.Length == 4)
                {
                    int number;
                    if (Int32.TryParse(commands[3], out number))
                    {
                        WorkersList.Add(new Employee(commands[1], commands[2], number));
                    }
                    else
                    {
                        Console.WriteLine("Неверный номер работника!");
                        Help();
                    }
                }

                if (commands[0].ToLower() == "del" && commands.Length == 2)
                {
                        IEnumerable<int> res = 
                           from t in WorkersList // Определяем каждый объект как t
                           where t.Name == commands[1] // Фильтрация по критерию
                           orderby t // Упорядочиваем по возрастанию
                           select WorkersList.IndexOf(t); // Выбираем индекс объекта

                        foreach (int i in res)
                        {
                            WorkersList.RemoveAt(i);
                            //Console.WriteLine(i);
                        }
                        Console.WriteLine("удаление работника: " + commands[1]);
                }

                if (commands[0].ToLower() == "info" && commands.Length == 2)
                {
                    IEnumerable<Employee> res = from t in WorkersList where t.Name == commands[1] orderby t 
                       select t;

                    foreach (Employee e in res)
                    {
                        Console.WriteLine(e.ToString());
                    }
                }

                if (commands[0].ToLower() == "list")
                {
                    foreach (var w in WorkersList)
                    {
                        Console.WriteLine(w.ToString());
                    }
                }

            }

        }


        static void Help()
        {
            Console.WriteLine("Доступные команды:");
            Console.WriteLine("\tlist - список сотрудников");
            Console.WriteLine("\tadd (имя) (должность) (номер) - добавить сотрудника");
            Console.WriteLine("\tdel (имя) - удалить сотрудника");
            Console.WriteLine("\tinfo (имя) - информация о сотруднике");
            Console.WriteLine("\texit - выход");
            Console.WriteLine("Нажмите любую клавишу для продолжения");
            //Console.ReadLine();
        }


    }
}
