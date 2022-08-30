Console.WriteLine("Введите число: ");
int number_0 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int number_1 = int.Parse(Console.ReadLine());
if (number_0 == number_1)
    {
        Console.WriteLine("Числа равны");
    }
else 
    {
        if (number_0 > number_1)
            {
                Console.WriteLine($"Число {number_0} больше числа {number_1}");
            }
        else
            {
                Console.WriteLine($"Число {number_1} больше числа {number_0}");
            }
    }
