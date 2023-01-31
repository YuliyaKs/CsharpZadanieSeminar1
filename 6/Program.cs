// Задача 6: Напишите программу, которая на вход принимает 
// число и выдает, является ли число четным (делится ли оно на 
// два без остатка).

Console.Clear();
Console.Write("Введите целое число: ");
int numb = int.Parse(Console.ReadLine());

if (numb % 2 == 0)
{
    Console.WriteLine("ДА");
    Console.WriteLine($"Число {numb} - четное");
}
else
{
    Console.WriteLine("НЕТ");
    Console.WriteLine($"Число {numb} - нечетное");
}


