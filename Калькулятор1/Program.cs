string txt;
do
{
    Console.WriteLine("Выберите операцию, которую хотите выполнить: ");
    Console.WriteLine("1. Сложение");
    Console.WriteLine("2. Вычитание");
    Console.WriteLine("3. Умножение");
    Console.WriteLine("4. Деление");
    Console.WriteLine("5. Возведение в степень");
    Console.WriteLine("6. Найти квадратный корень");
    Console.WriteLine("7. Найти процент");
    Console.WriteLine("8. Найти факториал");
    Console.WriteLine("9. Выйти из программы");
    txt = Console.ReadLine();

    if (txt == "1")
    {
        Console.WriteLine("Введите первое число: ");
        int num1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Введите второе число: ");
        int num2 = int.Parse(Console.ReadLine());
        int сумма = num1 + num2;
        Console.WriteLine("Результат сложения: " + сумма);
    }
    else if (txt == "2")
    {
        Console.WriteLine("Введите первое число: ");
        int num1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Введите второе число: ");
        int num2 = int.Parse(Console.ReadLine());
        int вычитание = num1 - num2;
        Console.WriteLine("Результат вычитания: " + вычитание);
    }
    else if (txt == "3")
    {
        Console.WriteLine("Введите первое число: ");
        int num1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Введите второе число: ");
        int num2 = int.Parse(Console.ReadLine());
        int умножение = num1 * num2;
        Console.WriteLine("Результат умножения: " + умножение);
    }
    else if (txt == "4")
    {
        Console.WriteLine("Введите первое число: ");
        int num1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Введите второе число: ");
        int num2 = int.Parse(Console.ReadLine());
        if (num2 != 0)
        {
            int деление = num1 / num2;
            Console.WriteLine("Результат деления: " + деление);
        }
        else
        {
            Console.WriteLine("Ошибка! Деление на ноль невозможно.");
        }
    }
    else if (txt == "5")
    {
        Console.WriteLine("Введите число: ");
        int num1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Введите степень: ");
        int num2 = int.Parse(Console.ReadLine());
        int степень = (int)Math.Pow(num1, num2);
        Console.WriteLine("Результат возведения в степень: " + степень);
    }
    else if (txt == "6")
    {
        Console.WriteLine("Введите число: ");
        double num = double.Parse(Console.ReadLine());

        if (num >= 0)
        {
            double squareRoot = Math.Sqrt(num);
            Console.WriteLine("Квадратный корень из числа {0} равен {1}", num, squareRoot);
        }
        else
        {
            Console.WriteLine("Ошибка! Квадратный корень из отрицательного числа невозможен.");
        }
    }
    else if (txt == "7")
    {
        Console.WriteLine("Введите число: ");
        double number = double.Parse(Console.ReadLine());

        Console.WriteLine("Введите процент: ");
        double процент = double.Parse(Console.ReadLine());

        double результат = (number * процент) / 100;
        Console.WriteLine("Результат вычисления процента: " + результат);
    }
    else if (txt == "8")
    {
        Console.WriteLine("Введите число: ");
        int num = int.Parse(Console.ReadLine());

        int factorial = 1;
        for (int i = 1; i <= num; i++)
        {
            factorial *= i;
        }

        Console.WriteLine("Факториал числа {0} равен {1}", num, factorial);
    }
} while (txt != "9");