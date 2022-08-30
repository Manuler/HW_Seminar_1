//Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.Write("Введите число: ");
int number_0 = int.Parse(Console.ReadLine());
int x = 2;
    if (number_0 >= x)
    {
        while (x <= number_0)
        { 
            Console.WriteLine(x);
            x += 2;
        }
    }
    else
    {
        Console.WriteLine("Введенное число меньше 2");
    }