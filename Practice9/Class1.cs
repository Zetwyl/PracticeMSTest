using System;
using System.Linq;

namespace Practice9
{
    public class Variant4
    {
        public int f(int x)
        {
            if (x >= 10 && x < 100)
            {
                int num = x * x;
                return num;
            }
            return x;
        }

        public bool IsPalindrom(string w)
        {
            if (w.Length == 0)
            {
                throw new ArgumentException("Строка не должна быть пустой");
            }

            string lower = w.ToLower();
            string reversed = new string(lower.Reverse().ToArray());

            return lower == reversed;
        }

        public string LessonTime(int lesson)
        {
            if (lesson > 15)
            {
                throw new ArgumentException("уроки не должны быть больше 15");
            }

            if (lesson < 0)
            {
                throw new ArgumentException("уроки не должны быть меньше 0");
            }

            TimeSpan current = TimeSpan.FromHours(8);

            for (int i = 1; i <= lesson; i++)
            {
                current = current.Add(TimeSpan.FromMinutes(45));

                if (i == lesson)
                    return current.ToString(@"hh\ mm"); // формат "HH mm"

                current = current.Add(TimeSpan.FromMinutes(5));
            }

            return current.ToString(@"hh\ mm");
        }
    }
}
