using System;

namespace КАЛкулятор
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            int i = 1;
            double operant1 = 0;
            double operant2 = 0;

            while (i > 0)
            {
                bool o = true;
                while (o)
                {
                    Console.WriteLine("Введите первое число!");
                    string operantStr1 = Console.ReadLine();

                    try
                    {
                        operant1 = double.Parse(operantStr1);
                        o = false;                    
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Введите корректное число");

                    }
                }
                
                bool p = true;
                while (p)
                {
                    Console.WriteLine("Введите второе число!");
                    string operantStr2 = Console.ReadLine();

                    try
                    {
                        operant2 = double.Parse(operantStr2);
                        p = false;
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Введите корректное число");

                    }
                }
                

            string operation;
            Console.WriteLine("Выберите арифм действие "  +
                "\nНапример + или - или * или /");
            operation = Console.ReadLine();


                double answer = 0; 
                switch (operation)
                {
                    case "+":
                        answer = operant1 + operant2;
                        break;
                    case "-":
                        answer = operant1 - operant2;
                        break;
                    case "*":
                        answer = operant1 * operant2;
                        break;
                    case "/":
                        if (operant2 == 0)
                            Console.WriteLine("На ноль делить нельзя");
                        else
                            answer = operant1 / operant2;
                        break;

                    default:
                        Console.WriteLine("Неправильно выбрано действие");
                        break;
                       
                }
                Console.WriteLine(answer);
            }
            */
            Console.ReadKey();
        }
    }
}


