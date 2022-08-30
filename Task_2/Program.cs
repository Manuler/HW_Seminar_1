//Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.WriteLine("Введите 1е число: ");
int number_0 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите 2е число: ");
int number_1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите 3е число: ");
int number_2 = int.Parse(Console.ReadLine());
int max = number_0;
if (number_1 > max)
{
    max = number_1;
}
if (number_2 > max)
{
    max = number_2;
}
Console.WriteLine($"Максимальное число {max}");
