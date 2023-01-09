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
            //newSchedule.ToString();

            Lesson les1 = new Lesson();
            Lesson les2 = new Lesson();
            Lesson les3 = new Lesson();
            Lesson lesMat = new Lesson("Матан", 1, 0, WeekDays.Monday, "11");
            Lesson lesAlg = new Lesson("Алгебра", 2, 1, WeekDays.Monday, "11");
            Lesson lesAlgPract = new Lesson("Алгебра", 2, 1, WeekDays.Monday, "21");

            newSchedule.ShowCountResult("12");
        }
    }
}
