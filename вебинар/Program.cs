﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace вебинар

   /* new Employee() { NameCPU = "intel", SummRAM = 256, Summa = 100, City = "Москва"},
                new Employee() { NameCPU = "celeron", SummRAM = 512, Summa = 110, City = "СПб"},
                new Employee() { NameCPU = "huawei", SummRAM = 1024, Summa = 60, City = "Сочи"},
                new Employee() { NameCPU = "huawei", SummRAM = 640, Summa = 150, City = "Иркутск"},
                new Employee() { NameCPU = "intel", SummRAM = 128, Summa = 200, City = "Москва"},
                new Employee() { NameCPU = "huawei", SummRAM = 512, Summa = 500, City = "СПб"},
                new Employee() { NameCPU = "intel", SummRAM = 2048, Summa = 90, City = "Сочи"},
                new Employee()
    {
        NameCPU = "celeron", SummRAM = 1024
    internal class Program
    
        static void Main(string[] args)
        {
            
                List<Employee> employees = new List<Employee>()
            {
                new Employee(){Num=1, Name="Иванов", Summa=100, City="Москва"},
                new Employee(){Num=2, Name="Петров", Summa=110, City="СПб"},
                new Employee(){Num=3, Name="Сидоров", Summa=60, City="Сочи"},
                new Employee(){Num=4, Name="Кузнецов", Summa=150, City="Иркутск"},
                new Employee(){Num=5, Name="Васильев", Summa=200, City="Москва"},
                new Employee(){Num=6, Name="Бендер", Summa=500, City="СПб"},
                new Employee(){Num=7, Name="Воробьянинов", Summa=90, City="Сочи"},
                new Employee(){Num=8, Name="Балаганов", Summa=120, City="Екатеринбург"}
            };

                Console.WriteLine("Введите город");
                string city = Console.ReadLine();
                List<Employee> employees1 = employees.Where(x => x.City == city).ToList();
                Print(employees1);

                Console.WriteLine("Введите зп");
                int summa = Convert.ToInt32(Console.ReadLine());
                List<Employee> employees2 = employees.Where(x => x.Summa >= summa).ToList();
                Print(employees2);

                List<Employee> employees3 = employees.OrderBy(x => x.Name).ToList();
                Print(employees3);

                IEnumerable<IGrouping<string, Employee>> employees4 = employees.GroupBy(x => x.City);
                foreach (IGrouping<string, Employee> gr in employees4)
                {
                    Console.WriteLine(gr.Key);
                    foreach (Employee e in gr)
                    {
                        Console.WriteLine($"{e.Num} {e.Name} {e.Summa} {e.City}");
                    }
                }

                Employee employee5 = employees.OrderByDescending(x => x.Summa).FirstOrDefault();
                Console.WriteLine($"{employee5.Num} {employee5.Name} {employee5.Summa} {employee5.City}");

                Console.WriteLine(employees.Any(x => x.Summa > 200));

                Console.ReadKey();

            }

            static void Print(List<Employee> employees)
            {
                foreach (Employee e in employees)
                {
                    Console.WriteLine($"{e.Num} {e.Name} {e.Summa} {e.City}");
                }
                Console.WriteLine();
            }
        class Employee
        {
            public int Num { get; set; }
            public string Name { get; set; }
            public int Summa { get; set; }
            public string City { get; set; }

        }
    }
    }*/

