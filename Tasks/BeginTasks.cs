using System;

namespace Tasks
{
    public class BeginTasks
    {
        //Begin1 Дана сторона квадрата a.Найти его периметр P = 4·a.
        static int Begin1(int value1)
        {  
            return value1 * 4;
        }

        //Begin2◦ Дана сторона квадрата a.Найти его площадь S = a2
        static int Begin2(int value1)
        {
            int Square = value1 * value1;
            return Square;
        }

        /*Begin3◦ Даны стороны прямоугольника a и b.Найти его площадь S = a·b и
         периметр P = 2·(a + b).*/
        static void Begin3(int value1, int value2)
        {
            int Sqare = value1 * value1;
            int Perimeter = 2 * (value1 + value2);
          
        }

        /*Begin4◦ Дан диаметр окружности d.Найти ее длину L = π·d.В качестве
        значения π использовать 3.14.*/
        static double Begin4(double value1)
        {
            double Lenght = value1 * Math.PI;
            return Lenght;
        }

        /*Begin5◦ Дана длина ребра куба a.Найти объем куба V = a
        3 и площадь его поверхности S = 6·a2*/
        static void Begin5(double value1)
        {
            double Volume = Math.Pow(value1,3);
            double Sqare = 6 * Math.Pow(value1,2);
            
        }

        /*Begin6◦ Даны длины ребер a, b, c прямоугольного параллелепипеда.Найти
        его объем V = a·b·c и площадь поверхности S = 2·(a·b + b·c + a·c).*/
        static void Begin6(int value1, int value2, int value3)
        {
            int Volume = value1 * value2 * value3;
            int Square = 2 * ((value1 * value2) + (value2 * value3) + (value1 * value3));
        }

        /*Begin7◦ Найти длину окружности L и площадь круга S заданного радиуса R:
L = 2·π·R, S = π·R2*/
        static void Begin7(double value1)
        {
            double SolBegin7L = value1 * 2 * Math.PI;
            double SolBegin7S = Math.PI * value1 * value1;
           
        }
        //Begin8◦Даны два числа a и b.Найти их среднее арифметическое: (a + b)/2.
        static int Begin8(int value1, int value2)
        {
            int SolBegin8 = (value1 + value2) / 2;
            return SolBegin8;
        }
        /*Begin9◦Даны два неотрицательных числа a и b.Найти их среднее геометрическое, то есть квадратный корень из их произведения: 
        √a·b.*/
        static double Begin9(double value1, double value2)
        {
            double SolBegin9 = System.Math.Sqrt((value1 * value2));
            return SolBegin9;

        }

        /*Begin10◦Даны два ненулевых числа.Найти сумму, разность, произведение и
частное их квадратов.*/
        static void Begin10(double value1, double value2)
        {
            if (value1 == 0 || value2 == 0)
                Console.WriteLine("Ошибка.Введите другое число");
            else
            {
                double SolBegin101 = Math.Pow(value1, 2) + Math.Pow(value2, 2);
                double SolBegin102 = Math.Pow(value1, 2) - Math.Pow(value2, 2);
                double SolBegin103 = Math.Pow(value1, 2) * Math.Pow(value2, 2);
                double SolBegin104 = Math.Pow(value1, 2) / Math.Pow(value2, 2);
            }
        }
    }
}