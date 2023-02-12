void FillArray (int[,] matr)
{
  Random rand = new Random();
  for(int i = 0;i < matr.GetLength(0);i++)
  {
    for(int j = 0;j < matr.GetLength(1);j++)
    {
      matr[i,j] = rand.Next(1,101);
    }
  }
}

void PrintArray(int [,] matrix)
{
  for(int i = 0;i < matrix.GetLength(0);i++)
  {
    for(int j = 0;j < matrix.GetLength(1);j++)
    {
      Console.Write(matrix[i,j] + "  ");
    }
    Console.WriteLine();
  }
}

void CoppyArray(int [,] arr,int[,]matr)
{
  for(int i = 0; i < arr.GetLength(0);i++)
  {
    for(int j = 0;j < arr.GetLength(1);j++)
    {
      arr[i,j] = matr[i,j];
    }
  }
}
int [,] array = new int[4,4];
FillArray(array);
PrintArray(array);
int[,] arrayCoppy = new int [array.GetLength(0),array.GetLength(1)];
CoppyArray(arrayCoppy,array);
Console.WriteLine();
PrintArray(arrayCoppy);
