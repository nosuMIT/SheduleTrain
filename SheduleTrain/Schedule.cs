using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SheduleTrain
{
    public enum WeekDays
    {
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday
    }

    public class Schedule
    {
        public string nameDepartment;
        List<Lesson> listLessons = new List<Lesson>();

        public Schedule(string name)
        {
            nameDepartment = name;
        }

        public void Add(Lesson lesson)
        {
            listLessons.Add(lesson);
        }

        public new void ToString()
        {
            foreach (var item in listLessons)
            {
                Console.WriteLine(item.ToString());
            }
        }

        public Dictionary<string, int> Count(string groupNum)
        {
            var result = new Dictionary<string, int>();
            foreach (var lesson in this.listLessons)
            {
                if (!result.ContainsKey(lesson.weekDay.ToString()))
                {
                    result.Add(lesson.weekDay.ToString(), 1);
                }
                else
                {
                    if(groupNum == lesson.groupNumber)
                        result[lesson.weekDay.ToString()]++;
                }
            }

            //this.listLessons.ToDictionary(key => key.weekDay, num => this.listLessons.Count(p => p.weekDay == num.weekDay));

            return result;
        }

        public void ShowCountResult(string groupNum)
        {
            var result = Count(groupNum);
            foreach (var item in result)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
        }
    }

    public class Lesson
    {

        public string label;
        public int number;
        public int weekNumber;
        public WeekDays weekDay;
        public string groupNumber;

        private static char symb = 'A';
        private Random random = new Random();

        public Lesson()
        {
            label = symb.ToString();
            symb++;
            number = random.Next(1, 4);
            weekNumber = random.Next(0, 2);
            weekDay = (WeekDays)random.Next(1, 7);
            groupNumber = random.Next(11, 13).ToString();
        }

        public Lesson(string label, int number, int weekNumber, WeekDays weekDay, string groupNumber)
        {
            this.label = label;
            this.number = number;
            this.weekNumber = weekNumber;
            this.weekDay = weekDay;
            this.groupNumber = groupNumber;
        }


        public override string ToString()
        {
            return $"{label}., {number} пара {weekDay}., {groupNumber} группа, {weekNumber}";
        }
    }
}
