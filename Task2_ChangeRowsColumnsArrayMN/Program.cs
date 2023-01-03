// Задать двумерный массив и поменять местами его столбцы
// со строками, и если не возмжно - сообщить об этом

Console.WriteLine("Задайте количество строк массива m");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Задайте количество столбцов массива n");
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

int[,] ChangeRowsColumns(int[,] matrix0)
{
  if (rows == columns)
  {
    for (int i = 0; i < matrix0.GetLength(0); i++)
      {
      for (int j = 0; j < matrix0.GetLength(1); j++)
        {
          if(i < j)
          {
            int temp = matrix0[i, j];
            matrix0[i, j] = matrix0[j, i];
            matrix0[j, i] = temp;
          }
        }
      }
  }
  else Console.WriteLine("Невозможно поменять строки со столбцами местами, потому что их количество не совпадает");
  
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

PrintMatrix(ChangeRowsColumns(matrix));
Console.WriteLine();
