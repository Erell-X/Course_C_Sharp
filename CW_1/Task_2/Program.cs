// Напишите программу, которая на вход принимает два числа и проверяет,
// является ли первое число квадратом второго.

Console.Clear();

int A = int.Parse(Console.ReadLine()!);

int B = int.Parse(Console.ReadLine()!);

int BB = B*B;
Console.WriteLine(BB);

if(A==BB)
{
Console.WriteLine("Да");
}

else 
{
Console.WriteLine("Нет");
}