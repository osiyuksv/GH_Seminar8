// Задать двумерный массив и поменять местами его первую и последнюю строку

Console.WriteLine("Задайте число строк массива m");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Задайте число колонок массива n");
int columns = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

int[,] matrix = new int[rows, columns];
FillMatrixRandomNunmbers(matrix);

void FillMatrixRandomNunmbers( int[,] matrix0)
{
  for (int i = 0; i < matrix0.GetLength(0); i++)
  {
    for (int j = 0; j < matrix0.GetLength(1); j++)
    {
      matrix0[i, j] = new Random().Next(10);
      Console.Write(matrix0[i, j] + " ");
    }
    Console.WriteLine();
  }
}

Console.WriteLine();

  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
      if( i == 0 ) 
      {
         int tempFirst =  matrix[i, j];
         matrix[i, j] = matrix[matrix.GetLength(0)-1, j];
         matrix[matrix.GetLength(0)-1, j] = tempFirst;
      }

    Console.Write(matrix[i, j] + " ");
    }
    Console.WriteLine();
  }


