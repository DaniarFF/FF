using System;

namespace Bolian
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
/*НЕ СДЕЛАНЫ
. Проверить истинность высказывания: «Среди трех данных целых
чисел есть хотя бы одна пара взаимно противоположных».
Boolean20◦
. Дано трехзначное число.Проверить истинность высказывания:
«Все цифры данного числа различны».
Boolean21◦
. Дано трехзначное число.Проверить истинность высказывания:
«Цифры данного числа образуют возрастающую последовательность».
Boolean22◦
. Дано трехзначное число.Проверить истинность высказывания:
«Цифры данного числа образуют возрастающую или убывающую последовательность»*/


        /*Boolean1◦
        . Дано целое число A.Проверить истинность высказывания: «Число A является положительным».*/
        static bool Bolian1(int value1)
        {
            bool result = value1 > 0;
            return result;
        }
        //Дано целое число A. Проверить истинность высказывания: «Число A является нечетным»
        static bool Bolian2(double value1)
        {
            double valueOdd = value1 % 2;
            bool result = valueOdd > 0;
            return result;
        }
        //Дано целое число A. Проверить истинность высказывания: «Число A является четным»
        static bool Bolian3(double value1)
        {
            double valueEven = value1 % 2;
            bool result = valueEven == 0;
            return result;

        }
        /*Даны два целых числа: A, B.Проверить истинность высказывания:
          «Справедливы неравенства A > 2 и B ≤ 3»*/
        static bool Bolian4(int a , int b)
        {
            bool result = (a>2 && b<=3);
            return result;

        }
        /*Даны два целых числа: A, B.Проверить истинность высказывания:
        «Справедливы неравенства A ≥ 0 или B < −2».*/
        static bool Bolian5(int a, int b)
        {
            bool result = (a >= 0 || b < -2);
            return result;

        }
        /*Даны три целых числа: A, B, C.Проверить истинность высказывания: «Справедливо двойное неравенство A<B<C».*/
        static bool Bolian6(int a, int b, int c)
        {
            bool result = (a<b && b<c);
            return result;
        }
        /*Даны три целых числа: A, B, C.Проверить истинность высказывания: «Число B находится между числами A и C». */
        static bool Bolian7(int a, int b, int c)
        {
            bool result = (a < b && b < c);
            return result;
        }
        /*Даны два целых числа: A, B.Проверить истинность высказывания:
        «Каждое из чисел A и B нечетное».*/
        static bool Bolian8(double a, double b)
        {
            double ValueOddA = a % 2;
            double ValueOddB = b % 2;
            bool result =(ValueOddA>0 && ValueOddB>0);
            return result;
        }
        /*Даны два целых числа: A, B.Проверить истинность высказывания:
        «Хотя бы одно из чисел A и B нечетное»*/
        static bool Bolian9(double a, double b)
        {
            double ValueOddA = a % 2;
            double ValueOddB = b % 2;
            bool result = (ValueOddA > 0 || ValueOddB > 0);
            return result;
        }
        /*Даны два целых числа: A, B.Проверить истинность высказывания: «Ровно одно из чисел A и B нечетное».*/
        static bool Bolian10(double a, double b)
        {
            double ValueOddA = a % 2;
            double ValueOddB = b % 2;
            bool result = ((ValueOddA > 0 && ValueOddB == 0)&&(ValueOddA == 0 && ValueOddB > 0));
            return result;
        }
        /*Даны два целых числа: A, B.Проверить истинность высказывания: «Числа A и B имеют одинаковую четность»*/
        static bool Bolian11(double a, double b)
        {
            double ValueOddA = a % 2;
            double ValueOddB = b % 2;
            bool result = ((ValueOddA == 0 && ValueOddB == 0) && (ValueOddA > 0 && ValueOddB > 0));
            return result;
        }
        /*Даны три целых числа: A, B, C.Проверить истинность высказывания: «Каждое из чисел A, B, C положительное».*/
        static bool Bolian12(int a, int b, int c)
        {
            bool result = ((a>0)&&(b>0)&&(c>0));
            return result;
        }
        /*Даны три целых числа: A, B, C.Проверить истинность высказывания: «Хотя бы одно из чисел A, B, C положительное»*/
        static bool Bolian13(int a, int b, int c)
        {
            bool result = ((a > 0) || (b > 0) || (c > 0));
            return result;
        }
        /*Даны три целых числа: A, B, C.Проверить истинность высказывания: «Ровно одно из чисел A, B, C положительное»*/
        static bool Bolian14(int a, int b, int c)
        {
            bool result = ((a > 0)&&(b <= 0)&&(c <= 0))&&((a <= 0) && (b > 0) && (c <= 0))&&((a <= 0) && (b <= 0) && (c > 0)) ;
            return result;
        }
        /*Даны три целых числа: A, B, C.Проверить истинность высказывания: «Ровно два из чисел A, B, C являются положительными».*/
        static bool Bolian15(int a, int b, int c)
        {
            bool case1 = (a > 0)&&(b > 0)&&(c<0);
            bool case2 = (c > 0)&&(b > 0)&&(a<0);
            bool case3 = (b > 0)&&(a > 0)&&(b<0);
            bool result = (case1 && case2 && case3);
            return result;
        }
        /*Дано целое положительное число.Проверить истинность высказывания: «Данное число является четным двузначным»*/
        static bool Bolian16(int a)
        {
            bool criterion1 = (a>9)&&(a<100);
            double ValueEven = a % 2;
            bool criterion2 = ValueEven==0 ;

            bool result = criterion1 && criterion2;
            return result;
        }
        /*Дано целое положительное число.Проверить истинность высказывания: «Данное число является нечетным трехзначным»*/
        static bool Bolian17(int a)
        {
            bool criterion1 = (a > 99) && (a < 1000);
            double ValueEven = a % 2;
            bool criterion2 = ValueEven > 0;

            bool result = criterion1 && criterion2;
            return result;
        }
        /*Проверить истинность высказывания: «Среди трех данных целых чисел есть хотя бы одна пара совпадающих»*/
        static bool Bolian18(int a, int b, int c)
        {
            bool case1 = (a == b)&&(a!=c)&&(b!=c) ;
            bool case2 = (a == c)&&(a != b) && (b != c);
            bool case3 = (b == c)&&(a != c) && (b != a);
            bool result = (case1||case2||case3);
            return result;
        }


    }
}
