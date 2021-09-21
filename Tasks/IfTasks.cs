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
            else
            {
                return 10;
            }

        }
        /*If9. Даны две переменные вещественного типа: A, B. Перераспределить значения данных переменных так, чтобы в A оказалось меньшее из значений,
а в B — большее. Вывести новые значения переменных A и B.*/
        public static void IfTask9(float a, float b)
        {
            float aResult = a;
            float bResult = b;
            if (a < b)
            {
                aResult = b;
                bResult = a;
            }
        }

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
                throw new ArgumentOutOfRangeException();
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
                throw new ArgumentOutOfRangeException("Ошибка");
            }
        }


        /*Дано целое число K. Вывести строку-описание оценки, соответствующей числу K (1 — «плохо», 2 — «неудовлетворительно», 3 — «удовлетворительно», 4 — «хорошо», 5 — «отлично»). Если K не лежит в диапазоне 1–5,
то вывести строку «ошибка».*/
        public enum score
        {
            Плохо = 1,
            Неудовлетворительно,
            Удовлетворительно,
            Хорошо,
            Отлично
        }
        public static score STask2(int k) 
        {
            if ((k < 1) || (k > 5)) throw new ArgumentOutOfRangeException("Ошибка");

            switch (k)
            {
                case 1:
                    return score.Плохо;
                case 2:
                    return score.Неудовлетворительно;
                case 3:
                    return score.Удовлетворительно;
                case 4:
                    return score.Хорошо;
                case 5:
                    return score.Отлично;
                default:
                    throw new ArgumentOutOfRangeException("Ошибка");
            }
        }

        /*Мастям игральных карт присвоены порядковые номера: 1 — пики,
2 — трефы, 3 — бубны, 4 — червы. Достоинству карт, старших десятки,
присвоены номера: 11 — валет, 12 — дама, 13 — король, 14 — туз. Даны
два целых числа: N — достоинство (6 ≤ N ≤ 14) и M — масть карты
(1 ≤ M ≤ 4). Вывести название соответствующей карты вида «шестерка
бубен», «дама червей», «туз треф» и т. п.*/
        public enum nominal
        {
            Шестерка = 6,
            Семерка,
            Восьмерка,
            Девятка,
            Десятка,
            Валет,
            Дама,
            Король,
            Туз
        }
        public enum suit
        {
            пик = 1,
            треф,
            бубен,
            червей
        }
        public static (nominal, suit) STask15(int n, int m)
        {
            if ((( 6 > n ) || ( n > 14 ))||(m < 1) || ( m > 4 ))
            throw new ArgumentOutOfRangeException("Ошибка");
            nominal nominal;
            suit suit;
            switch (n)
            {
                case 6:;
                    nominal = nominal.Шестерка;
                    break;
                case 7:
                    nominal = nominal.Семерка;
                    break;
                case 8:
                    nominal = nominal.Восьмерка;
                    break;
                case 9:
                    nominal = nominal.Девятка;
                    break;
                case 10:
                    nominal = nominal.Десятка;
                    break;
                case 11:
                    nominal = nominal.Валет;
                    break;
                case 12:
                    nominal = nominal.Дама;
                    break;
                case 13:
                    nominal = nominal.Король;
                    break;
                case 14:
                    nominal = nominal.Туз;
                    break;
                default:
                    throw new ArgumentOutOfRangeException("Ошибка");
            }
            switch (m)
            {
                case 1:
                    suit = suit.пик;
                    break;
                case 2:
                    suit = suit.треф;
                    break;
                case 3:
                    suit = suit.бубен;
                    break;
                case 4:
                    suit = suit.червей;
                    break;
                default:
                    throw new ArgumentOutOfRangeException("Ошибка");
            }
            return (nominal, suit);
        }
    }
}
