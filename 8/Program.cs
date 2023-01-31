// Задача 8: Напишите программу, которая на вход принимает
// число (N), а на выходе показывает все чётные числа от 1 до N.

Console.Clear();
Console.Write("Введите число: ");
int numberN = int.Parse(Console.ReadLine());
if (numberN < 0) numberN = -1 * numberN;
int index = 1;

while (index <= numberN)
{
    if (index % 2 == 0)
    {
        Console.Write($"{index}, ");
    }    
    index++;
}