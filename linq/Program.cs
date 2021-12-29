using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linq
{
    internal class Program
    {

        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>()
            {
                new Employee(){ModelCode=1, ModelName="Дом", ModelCPU="celeron", Processor=1.7, SummRAM= 512, VolumeHD=20, MemoryVideo=32, CostComputer= 78, VolumeModel =  10 },
                new Employee(){ModelCode=2, ModelName="Учеба", ModelCPU="intel", Processor=2.3, SummRAM=1024,VolumeHD=30, MemoryVideo=32, CostComputer= 85, VolumeModel = 2},
                new Employee(){ModelCode=3, ModelName="Бизнес", ModelCPU="huawei", Processor=2.5, SummRAM=2048,VolumeHD=35, MemoryVideo=32, CostComputer= 120, VolumeModel =5},
                new Employee(){ModelCode=4, ModelName="Графика", ModelCPU="celeron", Processor=2.3, SummRAM=2048,VolumeHD=60, MemoryVideo=128, CostComputer= 115, VolumeModel =1},
                new Employee(){ModelCode=5, ModelName="Игры", ModelCPU="huawei", Processor=2.8, SummRAM=2560,VolumeHD=50, MemoryVideo=128, CostComputer= 160, VolumeModel =0},
                new Employee(){ModelCode=6, ModelName="Пользователь", ModelCPU="intel", Processor=1.7, SummRAM=1024,VolumeHD=25, MemoryVideo=256, CostComputer= 95, VolumeModel =15},
                new Employee(){ModelCode=7, ModelName="Кино", ModelCPU="huawei", Processor=2.3, SummRAM=1536,VolumeHD=100, MemoryVideo=64, CostComputer= 60, VolumeModel =4},
                new Employee(){ModelCode=8, ModelName="Музыка", ModelCPU="celeron", Processor=1.7, SummRAM=512,VolumeHD=70, MemoryVideo=16, CostComputer= 50, VolumeModel =3}

            };
            Console.WriteLine("Задайте метод поиска :");
            Console.WriteLine(" 1 - поиск компьютера по модели процессора ");
            Console.WriteLine(" 2 - все компьютеры с объемом ОЗУ не ниже, чем ");
            Console.WriteLine(" 3 - вывести весь список, отсортированный по увеличению стоимости");
            Console.WriteLine(" 4 - вывести весь список, сгруппированный по типу процессора");
            Console.WriteLine(" 5 - найти самый дорогой и самый бюджетный компьютер;");
            Console.WriteLine(" 6- есть ли хотя бы один компьютер в количестве не менее ");


            int n = Convert.ToInt32(Console.ReadLine());
            switch (n)
            {
                case 1:
                    {
                        Console.WriteLine("модель процессора celeron intel huawei");
                        string modelName = Console.ReadLine();
                        List<Employee> employees1 = employees.Where(x => x.ModelName == modelName).ToList();
                        Print(employees1);

                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("Введите объем ОЗУ");
                        int summRAM = Convert.ToInt32(Console.ReadLine());
                        List<Employee> employees2 = employees.Where(x => x.SummRAM >= summRAM).ToList();
                        Print(employees2);
                        break;
                    }
                case 3:
                    {
                        List<Employee> employees3 = employees.OrderBy(x => x.CostComputer).ToList();
                        Print(employees3);

                        IEnumerable<IGrouping<int, Employee>> employees4 = employees.GroupBy(x => x.CostComputer);
                        foreach (IGrouping<int, Employee> gr in employees4)
                        {
                            Console.WriteLine(gr.Key);
                            foreach (Employee e in gr)
                            {
                                Console.WriteLine($"{e.ModelCode} {e.ModelName} {e.ModelCPU} {e.Processor} {e.SummRAM} {e.VolumeHD} {e.MemoryVideo} {e.CostComputer} {e.VolumeModel}");
                            }
                        }
                        break;
                    }
                case 4:
                    {
                        List<Employee> employees3 = employees.OrderBy(x => x.Processor).ToList();
                        Print(employees3);

                        IEnumerable<IGrouping<double, Employee>> employees4 = employees.GroupBy(x => x.Processor);
                        foreach (IGrouping<double, Employee> gr in employees4)
                        {
                            Console.WriteLine(gr.Key);
                            foreach (Employee e in gr)
                            {
                                Console.WriteLine($"{e.ModelCode} {e.ModelName} {e.ModelCPU} {e.Processor} {e.SummRAM} {e.VolumeHD} {e.MemoryVideo} {e.CostComputer} {e.VolumeModel}");
                            }
                        }
                        break;
                    }
                case 5:
                    {
                        Employee employee5 = employees.OrderByDescending(x => x.CostComputer).FirstOrDefault();
                        Console.WriteLine($"{employee5.ModelCode} {employee5.ModelName} {employee5.ModelCPU} {employee5.Processor} {employee5.SummRAM} {employee5.VolumeHD} {employee5.MemoryVideo} {employee5.CostComputer} {employee5.VolumeModel}");
                        break;
                    }
                case 6:
                    {
                        Console.WriteLine(employees.Any(x => x.CostComputer > 100));
                        break;
                    }

            }
            Console.ReadKey();
        }
        static void Print(List<Employee> employees)
       {
            foreach (Employee e in employees)
            {
                Console.WriteLine($"{e.ModelCode} {e.ModelName} {e.ModelCPU} {e.Processor} {e.SummRAM} {e.VolumeHD} {e.MemoryVideo} {e.CostComputer} {e.VolumeModel}");
            }
            Console.WriteLine();
        }
    }
}







