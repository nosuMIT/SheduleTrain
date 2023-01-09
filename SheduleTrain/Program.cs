using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SheduleTrain
{
    class Program
    {
        static void Main(string[] args)
        {
            GenerateData.Generate();
            Schedule newSchedule = GenerateData.scheduleFMCS;
            newSchedule.ToString();
            var col = newSchedule.Count("12");
            Console.WriteLine("Кол-во пар у 12 группы по дням:");
            foreach (var item in col)
            {
                Console.WriteLine($"{item.Key}:{item.Value}");
            }
            Console.ReadKey();
        }
    }
}
