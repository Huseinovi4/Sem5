void PrintArray(int[,] matrix)
{
  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
      Console.Write(matrix[i, j] + " ");
    }
    Console.WriteLine();
  }
}
void FillArray(int[,] matr)
{
  Console.WriteLine("Введите вершины фигуры:");
  for (int i = 0; i < matr.GetLength(0); i++)
  {
    for (int j = 0; j < matr.GetLength(1); j++)
    {
      matr[i, j] = Convert.ToInt32(Console.ReadLine());

    }
  }
}
void FigureScaling(int[,] matrix)
{
  Console.WriteLine("Введите коофицент k:");
  int k = int.Parse(Console.ReadLine()!);
  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
      matrix[i, j] *= k;
    }

  }
}

int[,] array = new int[4, 2];//в зависимости от фигуры изменяем размер массива
FillArray(array);
Console.WriteLine();
PrintArray(array);
Console.WriteLine();
FigureScaling(array);
Console.WriteLine();
PrintArray(array);

Console.ReadKey();

