double Fibonacci(int n)
{
  if (n == 1 || n == 2) return 1;
  else  return Fibonacci(n - 1) + Fibonacci(n - 2);
}
Console.WriteLine("Введите число:");
int n = int.Parse(Console.ReadLine()!);
for(int i =1;i<n+1;i++)
{
  Console.WriteLine($"({i})={Fibonacci(i)}");
}