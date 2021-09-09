using System;

namespace Решение_задач_из_учебника
{
    class Program
    {

        //Begin1 Дана сторона квадрата a.Найти его периметр P = 4·a.
        static int Begin1(int value_1)
        {
            int SolBegin1 = value_1 * 4;
            return SolBegin1;
        }

        //Begin2◦ Дана сторона квадрата a.Найти его площадь S = a2
        static int Begin2(int value_1)
        {
            int SolBegin2 = value_1 * value_1;
            return SolBegin2;
        }

        /*Begin3◦ Даны стороны прямоугольника a и b.Найти его площадь S = a·b и
         периметр P = 2·(a + b).*/
        static int Begin3(int value_1, int value_2)
        {
            int SolBegin3S = value_1 * value_1;
            int SolBegin3P = 2 * (value_1 + value_2);
            return SolBegin3S + SolBegin3P;
        }

        /*Begin4◦ Дан диаметр окружности d.Найти ее длину L = π·d.В качестве
        значения π использовать 3.14.*/
        static double Begin4(double value_1)
        {
            double SolBegin4 = value_1 * 3.14;
            return SolBegin4;
        }

        /*Begin5◦ Дана длина ребра куба a.Найти объем куба V = a
        3 и площадь его поверхности S = 6·a2*/
        static int Begin5(int value_1)
        {
            int SolBegin5V = value_1 * value_1 * value_1;
            int SolBegin5S = 6 * (value_1 * value_1);
            return SolBegin5S + SolBegin5V;
        }

        /*Begin6◦ Даны длины ребер a, b, c прямоугольного параллелепипеда.Найти
        его объем V = a·b·c и площадь поверхности S = 2·(a·b + b·c + a·c).*/
        static int Begin6(int value_1, int value_2, int value_3)
        {
            int SolBegin6V = value_1 * value_2 * value_3;
            int SolBegin6S = 2 * ((value_1 * value_2) + (value_2 * value_3) + (value_1 * value_3));
            return SolBegin6S + SolBegin6V;
        }

        /*Begin7◦ Найти длину окружности L и площадь круга S заданного радиуса R:
L = 2·π·R, S = π·R2*/
        static double Begin7(double value_1)
        {
            double SolBegin7L = value_1 * 2 * 3.14;
            double SolBegin7S = 3.14 * value_1 * value_1;
            return SolBegin7S + SolBegin7L;
        }
        //Begin8◦Даны два числа a и b.Найти их среднее арифметическое: (a + b)/2.
        static int Begin8(int value_1, int value_2)
        {
            int SolBegin8 = (value_1 + value_2) / 2;
            return SolBegin8;
        }
        /*Begin9◦Даны два неотрицательных числа a и b.Найти их среднее геометрическое, то есть квадратный корень из их произведения: 
        √a·b.*/
        static double Begin9(double value_1, double value_2)
        {
            double SolBegin9 = System.Math.Sqrt((value_1 + value_2));
            return SolBegin9;

        }

        /*Begin10◦Даны два ненулевых числа.Найти сумму, разность, произведение и
частное их квадратов.*/
        static uint Begin10(uint value_1, uint value_2)
        {
            uint SolBegin101 = (value_1 * value_1) + (value_2* value_2);
            uint SolBegin102 = (value_1 * value_1) - (value_2 * value_2);
            uint SolBegin103 = (value_1 * value_1) * (value_2 * value_2);
            uint SolBegin104 = (value_1 * value_1) / (value_2 * value_2);
            return SolBegin101 + SolBegin102 + SolBegin103 + SolBegin104;
        }
    }
}
