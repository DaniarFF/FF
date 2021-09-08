using System;

namespace КАЛкулятор
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1;
            while (i > 0)
            {

            double operant1;
            Console.WriteLine("Введите первое число!");
            operant1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Ведите второе число!");
            double operant2;
            operant2 = double.Parse(Console.ReadLine());
           

            string operation;
            Console.WriteLine("Выберите арифм действие "  +
                "\nНапример + или - или * или /");
            operation = Console.ReadLine();

                double answer;

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
                        answer = operant1 / operant2;
                        break;
                    default:
                        Console.WriteLine("Неправильно выбрано действие");
                        break;
                }
            }
            Console.ReadKey();
        }
    }
}
