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
            //string path = @"D:\!_C#\!_Projects\Homework3\Homework3\bin\Debug\Workers.dat";
            //FileInfo fileInfo = new FileInfo(path);


            List<Employee> WorkersList = new List<Employee>();
            WorkersList.Add(new Employee("John", "Lead Victim", 0001));
            WorkersList.Add(new Employee("Steve", "Tech Victim", 2));

            //foreach (Employee e in WorkersList)
            //{
            //    Console.WriteLine(e.ToString());
            //}




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
                    //запись в файл
                    return;
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


                //if (commands[0].ToLower() == "info" && commands.Length == 3)

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
            Console.WriteLine("Какой-то хелп");
            Console.WriteLine("Нажмите любую клавишу для продолжения");
            Console.ReadLine();
        }


    }
}
