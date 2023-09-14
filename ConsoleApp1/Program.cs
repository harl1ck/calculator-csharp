string menu;
int a;
int b;

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
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите второе число:");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Итог:" + (a + b));
            break;
        case "2":
            Console.WriteLine("Введите первое число:");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите второе число:");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Итог:" + (a - b));
            break;
        case "3":
            Console.WriteLine("Введите первое число:");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите второе число:");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Итог:" + (a * b));
            break;
        case "4":
            Console.WriteLine("Введите первое число:");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите второе число:");
            b = Convert.ToInt32(Console.ReadLine());
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
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите второе число:");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Итог:" + (System.Math.Pow(a, b)));
            break;
        case "6":
            Console.WriteLine("Введите число:");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Итог:" + (System.Math.Sqrt(a)));
            break;
        case "7":
            Console.WriteLine("Введите первое число:");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите второе число:");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Итог:" + (((a + b) * 100) / 200) + "%"); // честно говоря, не оч понятно вообще как считать процент от числа :,(
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
            a = Convert.ToInt32(Console.ReadLine());
            long x = factorial(a);
            Console.WriteLine("Итог:" + x);
            break;
        case "9":
            Console.WriteLine("До свидания.");
            break;
        default:
            Console.WriteLine("Пока.");
            break;
    }
} while (menu != "9");