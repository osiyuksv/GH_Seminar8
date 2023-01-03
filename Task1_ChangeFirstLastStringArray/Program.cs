// Задать двумерный массив и поменять местами его первую и последнюю строку

Console.WriteLine("Задайте число строк массива m");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Задайте число колонок массива n");
int columns = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

int[,] FillMatrixRandomNunmbers()
{
  int[,] matrix0 = new int[rows, columns];

  for (int i = 0; i < matrix0.GetLength(0); i++)
  {
    for (int j = 0; j < matrix0.GetLength(1); j++)
    {
      matrix0[i, j] = new Random().Next(10);
    }
  }
  return(matrix0);
}

int[,] ChangeFirstLastRows(int[,] matrix0)
{
    for (int j = 0; j < matrix0.GetLength(1); j++)
    {
      int tempFirst =  matrix0[0, j];
      matrix0[0, j] = matrix0[matrix0.GetLength(0)-1, j];
      matrix0[matrix0.GetLength(0)-1, j] = tempFirst;
    }
   return(matrix0);
}

void PrintMatrix(int[,] matrix0)
{
  for (int i = 0; i < matrix0.GetLength(0); i++)
  {
    for (int j = 0; j < matrix0.GetLength(1); j++)
    {
      Console.Write(matrix0[i, j] + " ");
    }
    Console.WriteLine();
  }
}

int[,] matrix = FillMatrixRandomNunmbers();
PrintMatrix(matrix);
Console.WriteLine();

PrintMatrix(ChangeFirstLastRows(matrix));
Console.WriteLine();
