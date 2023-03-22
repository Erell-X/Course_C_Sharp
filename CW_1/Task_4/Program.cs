// Напишите программу, которая на вход принимает одно число (N),
// а на выходе показывает все целые числа в промежутке от -N до N.

Console.Clear();

int R = int.Parse(Console.ReadLine()!);

int K = -R;

  while(K<R)

  {
  Console.Write(K);
  Console.Write(", ");
  K++;
  }

  if(K==R)
  {
  Console.Write(K);
  Console.Write(".");
  }
