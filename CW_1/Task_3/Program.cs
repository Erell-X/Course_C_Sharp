// Напишите программу, которая будет выдавать название дня недели
// по заданному номеру.

Console.Clear();

int Day = int.Parse(Console.ReadLine()!);
  
if(Day == 1)
{
Console.WriteLine("Понедельник");
}

if(Day == 2)
{
Console.WriteLine("Вторник");
}

if(Day == 3)
{
Console.WriteLine("Среда");
}

if(Day == 4)
{
Console.WriteLine("Четверг");
}

if(Day == 5)
{
Console.WriteLine("Пятница");
}

if(Day == 6)
{
Console.WriteLine("Суббота");
}

if(Day == 7)
{
Console.WriteLine("Воскресенье");
}

else
{
Console.WriteLine("Ошибка");
}
