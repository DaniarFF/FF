namespace Bolian
{
    public class BooleanTasks
    {

        /*Boolean1◦
        . Дано целое число A.Проверить истинность высказывания: «Число A является положительным».*/
       public static bool Bolian1(int value1)
        {
            bool result = value1 > 0;
            return result;
        }
        //Дано целое число A. Проверить истинность высказывания: «Число A является нечетным»
        public static bool IsNumberOdd(int value1)
        {
            int valueOdd = value1 % 2;
            bool result = valueOdd != 0;
            return result;
        }
        //Дано целое число A. Проверить истинность высказывания: «Число A является четным»
        static bool IsNumberEven(int value1)
        {
            return !IsNumberOdd(value1);
        }
        /*Даны два целых числа: A, B.Проверить истинность высказывания:
          «Справедливы неравенства A > 2 и B ≤ 3»*/
        static bool Bolian4(int a , int b)
        {
            bool result = (a > 2 && b <= 3);
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
            bool result = (a < b && b < c);
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
        static bool Bolian8(int a, int b)
        {
            return IsNumberOdd(a) && IsNumberOdd(b);
        }

        /*Даны два целых числа: A, B.Проверить истинность высказывания:
        «Хотя бы одно из чисел A и B нечетное»*/
        static bool Bolian9(int a, int b)
        {
            return IsNumberOdd(a) || IsNumberOdd(b);
        }
        /*Даны два целых числа: A, B.Проверить истинность высказывания: «Ровно одно из чисел A и B нечетное».*/
        public static bool Bolian10(int a, int b)
        {
            return (!IsNumberOdd(a) && IsNumberOdd(b)) || (IsNumberOdd(a) && !IsNumberOdd(b));
            
        }
        /*Даны два целых числа: A, B.Проверить истинность высказывания: «Числа A и B имеют одинаковую четность»*/
        public static bool Bolian11( int a, int  b)
        {
            return (IsNumberOdd(a) && IsNumberOdd(b)) || (IsNumberEven(a) && IsNumberEven(b));
        }
        /*Даны три целых числа: A, B, C.Проверить истинность высказывания: «Каждое из чисел A, B, C положительное».*/
        static bool Bolian12(int a, int b, int c)
        {
            bool result = ((a > 0) && ( b > 0) && (c > 0));
            return result;
        }
        /*Даны три целых числа: A, B, C.Проверить истинность высказывания: «Хотя бы одно из чисел A, B, C положительное»*/
        public static bool Bolian13(int a, int b, int c)
        {
            bool result = ((a > 0) || (b > 0) || (c > 0));
            return result;
        }
        /*Даны три целых числа: A, B, C.Проверить истинность высказывания: «Ровно одно из чисел A, B, C положительное»*/
        public static bool Bolian14(int a, int b, int c)
        {
            bool result = 
                ((a > 0)&&(b <= 0)&&(c <= 0))
                ||((a <= 0) && (b > 0) && (c <= 0))
                ||((a <= 0) && (b <= 0) && (c > 0)) ;
            return result;
        }
        /*Даны три целых числа: A, B, C.Проверить истинность высказывания: «Ровно два из чисел A, B, C являются положительными».*/
        public static bool Bolian15(int a, int b, int c)
        {
            bool case1 = (a > 0)&&(b > 0)&&(c<0);
            bool case2 = (c > 0)&&(b > 0)&&(a<0);
            bool case3 = (b > 0)&&(a > 0)&&(b<0);
            bool result = (case1 || case2 || case3);
            return result;
        }
        /*Дано целое положительное число.Проверить истинность высказывания: «Данное число является четным двузначным»*/
        public static bool Bolian16(int a)
        {
            bool IsNumTwoDigit = (a > 9) && (a < 100);
            return IsNumTwoDigit && IsNumberEven(a);
        }
        /*Дано целое положительное число.Проверить истинность высказывания: «Данное число является нечетным трехзначным»*/
        static bool Bolian17(int a)
        {
            bool isNumThreeDigit = (a > 99) && (a < 1000);
            return IsNumberOdd(a)&& isNumThreeDigit;
        }
        /*Проверить истинность высказывания: «Среди трех данных целых чисел есть хотя бы одна пара совпадающих»*/
        public static bool Bolian18(int a, int b, int c)
        {
            bool case1 = (a == b)&&(a != c)&&(b != c) ;
            bool case2 = (a == c)&&(a != b) && (b != c);
            bool case3 = (b == c)&&(a != c) && (b != a);
            bool result = (case1||case2||case3);
            return result;
        }
    }
}
