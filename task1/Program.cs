void CrossPoint(double k1, double b1, double k2, double b2)
{
  double x = (b1 - b2) / (k2 - k1);
  double y = (k2 * b1 - k1 * b2) / (k2 - k1);
  if (k1 == k2) Console.Write("Заданные прямые не пересекаются!");
  else
    Console.Write($"Точка пересечения заданных прямых: ({x}; {y})");
}

Console.WriteLine("Input b1: ");
double b1 = double.Parse(Console.ReadLine()!);
Console.WriteLine("Input k1: ");
double k1 = double.Parse(Console.ReadLine()!);
Console.WriteLine("Input b2: ");
double b2 = double.Parse(Console.ReadLine()!);
Console.WriteLine("Input k2: ");
double k2 = double.Parse(Console.ReadLine()!);
CrossPoint(k1, b1, k2, b2);
