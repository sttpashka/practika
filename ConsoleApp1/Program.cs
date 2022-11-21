// See https://aka.ms/new-console-template for more information
Console.WriteLine("1. Сложение 2 чисел");
Console.WriteLine("2. Вычитание");
Console.WriteLine("3. Умножение первого числа на второе");
Console.WriteLine("4. Деление");
Console.WriteLine("5. Возвести в степень N число");
Console.WriteLine("6. Найти квадратный корень из числа");
Console.WriteLine("7. Найти 1 процент от числа");
Console.WriteLine("8. Найти факториал числа");
Console.WriteLine("9. Выйти из программы");
int oper = 0;
do
{
    Console.WriteLine("Введите номер команды");
    oper = Convert.ToInt32(Console.ReadLine());
    if (oper == 1)
    {
        Console.WriteLine("Введите первое число");
        int pervoeChislo = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите второе число");
        int vtoroeChislo = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Сумма чисел = " + (pervoeChislo + vtoroeChislo));
    }
    else if (oper == 2)
    {
        Console.WriteLine("Введите первое число");
        int pervoeChislo = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите второе число");
        int vtoroeChislo = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Разность чисел = " + (pervoeChislo - vtoroeChislo));
    }
    else if (oper == 3)
    {
        Console.WriteLine("Введите первое число");
        Double pervoeChislo = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите второе число");
        Double vtoroeChislo = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Произведение чисел = " + (pervoeChislo * vtoroeChislo));
    }
    else if (oper == 4)
    {
        Console.WriteLine("Введите первое число");
        Double pervoeChislo = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите второе число");
        Double vtoroeChislo = Convert.ToDouble(Console.ReadLine());
        if (vtoroeChislo == 0)
        {
            Console.WriteLine("Заново");
        }
        else
        {
            Console.WriteLine("Частное чисел = " + (pervoeChislo / vtoroeChislo));
        }
    }
    else if (oper == 5)
    {
        Console.WriteLine("Введите число");
        int pervoeChislo = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите степень, в которую необходимо возвести число");
        int vtoroeChislo = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(vtoroeChislo + " Степень числа " + pervoeChislo + " = " + (Math.Pow(pervoeChislo, vtoroeChislo)));
    }
    else if (oper == 6)
    {
        Console.WriteLine("Введите число");
        int pervoeChislo = Convert.ToInt32(Console.ReadLine());
        if (pervoeChislo < 0)
        {
            Console.WriteLine("Заново");
        }
        else
        {
            Console.WriteLine("Квадратный корень из числа " + pervoeChislo + " = " + (Math.Sqrt(pervoeChislo)));
        }
    }
    else if (oper == 7)
    {
        Console.WriteLine("Введите число");
        Double pervoeChislo = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("1 процент от числа " + pervoeChislo + " = " + (pervoeChislo / 100));
    }
    else if (oper == 8)
    {
        Console.WriteLine("Что такое факториал?");
    }
    else if (oper != 9)
    {
        Console.WriteLine("Только от 1 до 9");
    }
} while (oper != 9);
if (oper == 9)
{
    Console.WriteLine("ББ");
}