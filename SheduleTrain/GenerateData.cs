using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace SheduleTrain
{
    class GenerateData
    {
        public static Schedule scheduleFMCS;
        public static Dictionary<RussianDays, int> newcount = new Dictionary<RussianDays, int>();
        public static void Generate()
        {

            Lesson les1 = new Lesson();
            Lesson les2 = new Lesson();
            Lesson les3 = new Lesson();
            Lesson lesMat = new Lesson("Матан", 1, 0, RussianDays.Понедельник, "11");
            Lesson lesAlg = new Lesson("Алгебра", 2, 1, RussianDays.Понедельник, "11");
            Lesson lesAlgPract = new Lesson("Алгебра", 2, 1, RussianDays.Понедельник, "21");

            scheduleFMCS = new Schedule("ФМиКН");
            scheduleFMCS.Add(les3);
            scheduleFMCS.Add(les2);
            scheduleFMCS.Add(les1);
            scheduleFMCS.Add(lesAlg);
            scheduleFMCS.Add(new Lesson("Прога", 2, 2, RussianDays.Понедельник, "21"));
            scheduleFMCS.Add(new Lesson("Прога", 1, 0, RussianDays.Вторник, "21"));
            scheduleFMCS.Add(new Lesson("Прога", 1, 0, RussianDays.Вторник, "21"));
            Console.WriteLine();
            newcount = scheduleFMCS.Count("11 группа");
            foreach(var c in newcount)
            {
                Console.WriteLine(newcount);
            }
        }
    }
}
