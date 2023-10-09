using System;

class Calculator
{
    static void Main(string[] args)
    {
        double num1, num2, result;
        char operation;
        bool exit = false;

        Console.WriteLine("давай я посчитаю за тебя");
        do
        {
            Console.Write("Перове число: ");
            num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("операция (+, -, *, /): ");
            operation = Convert.ToChar(Console.ReadLine());

            Console.Write("Второе число: ");
            num2 = Convert.ToDouble(Console.ReadLine());

            switch (operation)
            {
                case '+':
                    result = num1 + num2;
                    Console.WriteLine("Результат: " + result);
                    break;

                case '-':
                    result = num1 - num2;
                    Console.WriteLine("Результат: " + result);
                    break;

                case '*':
                    result = num1 * num2;
                    Console.WriteLine("Результат: " + result);
                    break;

                case '/':
                    if (num2 != 0)
                    {
                        result = num1 / num2;
                        Console.WriteLine("Результат: " + result);
                    }
                    else
                    {
                        Console.WriteLine("Ошибка: деление на ноль");
                    }
                    break;

                default:
                    Console.WriteLine("Ошибка: неверная операция");
                    break;
            }

            Console.WriteLine("Хотите провести еще один расчет? (y/n)");
            char choice = Convert.ToChar(Console.ReadLine());

            if (choice == 'n' || choice == 'N')
            {
                exit = true;
            }

        } while (!exit);

        Console.WriteLine("Программа завершена.");
        Console.ReadLine();
    }
}