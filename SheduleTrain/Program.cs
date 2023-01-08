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

        }
    }
}
