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

        public string GetRusWeekDay()
        {
            switch (weekDay)
            {
                case WeekDays.Monday:
                    return "Понедельник";
                case WeekDays.Tuesday:
                    return "Вторник";
                case WeekDays.Wednesday:
                    return "Среда";
                case WeekDays.Thursday:
                    return "Четверг";
                case WeekDays.Friday:
                    return "Пятница";
                case WeekDays.Saturday:
                    return "Суббота";
                case WeekDays.Sunday:
                    return "Воскресенье";
            }
            return "";
        }
        public override string ToString()
        {
            var weekDayRus = GetRusWeekDay();
            return $"{label}., {number} пара {weekDayRus}., {groupNumber} группа, {weekNumber}";
        }
    }
}
