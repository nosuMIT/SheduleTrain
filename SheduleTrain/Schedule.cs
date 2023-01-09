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
    public enum RussianDays
    {
        Понедельник,
        Вторник,
        Среда,
        Четверг,
        Пятница,
        Суббота,
        Воскресенье
    }
    public class Schedule
    {
        public string nameDepartment;
        List<Lesson> listLessons = new List<Lesson>();
        public Dictionary<RussianDays, int> count = new Dictionary<RussianDays, int>();
        public bool IsExists(Lesson t, List<Lesson> l)
        {
            for (int i = 0; i < l.Count; i++)
            {
                if (t.weekDay == l[i].weekDay && t.groupNumber == l[i].groupNumber) return true;
            }
            return false;
        }
        public Dictionary<RussianDays, int> Count(string groupNumber)
        {
            Dictionary<RussianDays, int> table = new Dictionary<RussianDays, int>();
            List<Lesson> content = new List<Lesson>();
            for (int i = 0; i < listLessons.Count; i++) //пока занулим всё
            {
                RussianDays day = listLessons[i].weekDay;
                table.Add(day, 1);
            }
            for (int i = 0; i < listLessons.Count; i++)
            {
                for (int j = i; j < listLessons.Count; j++)
                {
                    if (listLessons[i].groupNumber == groupNumber && listLessons[i].weekDay == listLessons[j].weekDay && listLessons[j].groupNumber == groupNumber && !IsExists(listLessons[i], content))
                    {
                        table[listLessons[i].weekDay]++;
                    }
                }
                content.Add(listLessons[i]);
            }
            return table;
        }
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
        public RussianDays weekDay;
        public string groupNumber;

        private static char symb = 'A';
        private Random random = new Random();

        public Lesson()
        {
            label = symb.ToString();
            symb++;
            number = random.Next(1, 4);
            weekNumber = random.Next(0, 2);
            weekDay = (RussianDays)random.Next(1, 7);
            groupNumber = random.Next(11, 13).ToString();
        }

        public Lesson(string label, int number, int weekNumber, RussianDays weekDay, string groupNumber)
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
