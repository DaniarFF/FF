using System;
using System.Collections.Generic;
using System.Text;

namespace Tasks
{
    public class IfTasks
    {
        /*If3. Дано целое число. Если оно является положительным, то прибавить к
        нему 1; если отрицательным, то вычесть из него 2; если нулевым, то
заменить его на 10. Вывести полученное число.*/

        public static int IfTask3(int value1)
        {
            if (value1 > 0)
            {
                return ++value1;
            }
            if (value1 < 0)
            {
                return (value1 - 2);
            }
            if (value1 == 0)
            {
                return 10;
            }
            else // можно ли было считать это условие введенным нулем и убрать if(value1 == 0)?
                return 10;
        }
        /*If9. Даны две переменные вещественного типа: A, B. Перераспределить значения данных переменных так, чтобы в A оказалось меньшее из значений,
а в B — большее. Вывести новые значения переменных A и B.*/
        public static string IfTask9(float a, float b)
        {
            string result = "a= " + a + "и b= " + b;
            if (a < b)
            {
                result = "a= " + b + " и b= " + a;
            }
            return result;
            // Ярик не души(
        }
        public static float[] IfTask9_1(float a, float b)
        {
            if (a < b)
            {
                return new float[] { b, a };
            }
            return new float[] { a, b };
        }//не работает должным образом :(


        /*If12◦  Даны три числа. Найти наименьшее из них*/
        public static float IfTask12(float a, float b, float c)
        {
            if ((a < b) && (b < c))
            {
                return a;
            }
            if ((b < a) && (a < c))
            {
                return b;
            }
            if ((c < b) && (b < a))
            {
                return c;
            }
            else
            {
                return 0;
            }
        }
        /*If22◦
. Даны координаты точки, не лежащей на координатных осях OX и OY.
Определить номер координатной четверти, в которой находится данная
точка*/
        public static double IfTask22(double x, double y)
        {
            if (x == 0 || y == 0)
            {
                return 0;
            }
            if ((x > 0) && (y > 0))
            {
                return 1;
            }
            if ((x < 0) && (y > 0))
            {
                return 2;
            }
            if ((x < 0) && (y < 0))
            {
                return 3;
            }
            if ((x > 0) && (y < 0))
            {
                return 4;
            }
            else
            {
                return 0;
            }
        }
        /*Дано целое число K. Вывести строку-описание оценки, соответствующей числу K (1 — «плохо», 2 — «неудовлетворительно», 3 — «удовлетворительно», 4 — «хорошо», 5 — «отлично»). Если K не лежит в диапазоне 1–5,
то вывести строку «ошибка».*/
        public static string STask2(int k)
        {
            string score = "";
            switch (k)   
            {

                case 1:
                    score = "Плохо";
                    break;
                case 2:
                    score = "Неудовлетворительно";
                    break;
                case 3:
                    score = "удовлетворительно";
                    break;
                case 4:
                    score = "хорошо";
                    break;
                case 5:
                    score = "отлично";
                    break;
                default:
                    score = "Ошибка";
                    break;
            }
            return score;
        }
        /*Мастям игральных карт присвоены порядковые номера: 1 — пики,
2 — трефы, 3 — бубны, 4 — червы. Достоинству карт, старших десятки,
присвоены номера: 11 — валет, 12 — дама, 13 — король, 14 — туз. Даны
два целых числа: N — достоинство (6 ≤ N ≤ 14) и M — масть карты
(1 ≤ M ≤ 4). Вывести название соответствующей карты вида «шестерка
бубен», «дама червей», «туз треф» и т. п.*/
        public static string STask15(int n, int m)
        {
            string nominal = "";
            string suit = "";
            switch (n)
            {
                case 6:
                    nominal = "Шестерка";
                    break;
                case 7:
                    nominal = "Семерка";
                    break;
                case 8:
                    nominal = "Восьмерка";
                    break;
                case 9:
                    nominal = n.ToString("Девятка");
                    break;
                case 10:
                    nominal = n.ToString("Десятка");
                    break;
                case 11:
                    nominal = n.ToString("Валет");
                    break;
                case 12:
                    nominal = n.ToString("Дама");
                    break;
                case 13:
                    nominal = n.ToString("Король");
                    break;
                case 14:
                    nominal = n.ToString("Туз");
                    break;
                default:
                    nominal = n.ToString("Неопознанная карта");
                    break;
            }
            switch (m)
            {
                case 1:
                    suit = m.ToString("пик");
                    break;
                case 2:
                    suit = m.ToString("треф");
                    break;
                case 3:
                    suit = m.ToString("бубнов");
                    break;
                case 4:
                    suit = m.ToString("червей");
                    break;
                default:
                    suit = m.ToString("неопознанной масти");
                   break;

            }
            return (nominal + " " + suit + ".");

        }
    }
}
