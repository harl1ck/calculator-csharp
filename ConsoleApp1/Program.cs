string menu;

do 
{
    Console.WriteLine("Выберете операцию, которую хотите выполнить:");
    Console.WriteLine("1. Сложение");
    Console.WriteLine("2. Вычитание");
    Console.WriteLine("3. Умножение");
    Console.WriteLine("4. Деление");
    Console.WriteLine("5. Возведение в степень");
    Console.WriteLine("6. Квадратный корень");
    Console.WriteLine("7. Процент от числа");
    Console.WriteLine("8. Факториал");
    Console.WriteLine("9. Выход из калькулятора");
    menu = Console.ReadLine();

    switch (menu)
    {
        case "1":
            Console.WriteLine("Введите первое число:");
            var a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите второе число:");
            var b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Итог:" + (a + b));
            break;
        case "2":
            Console.WriteLine("Введите первое число:");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите второе число:");
            b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Итог:" + (a - b));
            break;
        case "3":
            Console.WriteLine("Введите первое число:");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите второе число:");
            b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Итог:" + (a * b));
            break;
        case "4":
            Console.WriteLine("Введите первое число:");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите второе число:");
            b = Convert.ToDouble(Console.ReadLine());
            if (b == 0)
            {
                Console.WriteLine("Деление на 0 не возможно!");
                break;
            }
            else
            {
                Console.WriteLine("Итог:" + (a / b));
            }
            break;
        case "5":
            Console.WriteLine("Введите первое число:");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите второе число:");
            b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Итог:" + (System.Math.Pow(a, b)));
            break;
        case "6":
            Console.WriteLine("Введите число:");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Итог:" + (System.Math.Sqrt(a)));
            break;
        case "7":
            Console.WriteLine("Введите процент:");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите число:");
            b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Итог:" + ((a /100) * b) + "%");
            break;
        case "8":
            static long factorial(long n) 
            {
                if (n == 1 || n == 0)
                    return 1;
                else 
                {
                    long r = 1;
                    for (int i = 1; i <= n; i++) 
                    { 
                        r *= i;
                    }
                    return r;
                }
            }
            Console.WriteLine("Введите число:");
            a = Convert.ToDouble(Console.ReadLine());
            long x = factorial(Convert.ToInt64(a));
            Console.WriteLine("Итог:" + x);
            break;
        default:
            Console.WriteLine("Пока.");
            break;
    }
} while (menu != "9");