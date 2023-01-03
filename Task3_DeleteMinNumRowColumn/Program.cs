// В зааданном дыухменром массиве удалять
// строку и столбец с наименьшим элементом в нём

// Задать двумерный массив и поменять местами его столбцы
// со строками, и если не возмжно - сообщить об этом

Console.WriteLine("Задайте количество строк массива m");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Задайте количество столбцов массива n");
int columns = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

int minNum = int.MaxValue;
int minIndexRows = 0;
int minIndexColumns = 0;

int[,] FillMatrixRandomNunmbers()
{
  int[,] matrix0 = new int[rows, columns];

  for (int i = 0; i < matrix0.GetLength(0); i++)
  {
    for (int j = 0; j < matrix0.GetLength(1); j++)
    {
      matrix0[i, j] = new Random().Next(10);
      if(matrix0[i, j] < minNum)
      {
        minNum = matrix0[i, j];
        minIndexRows = i;
        minIndexColumns = j;
      }
    }
  }
  return(matrix0);
}

void PrintChangeArray(int[,] matrix0)
{
   for (int i = 0; i < matrix0.GetLength(0); i++)
   {
      if(i != minIndexRows)
      {
        for (int j = 0; j < matrix0.GetLength(1); j++)
        {
          if(j != minIndexColumns) Console.Write(matrix0[i, j] + "\t");
        }
        Console.WriteLine();
      }
   }
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

PrintChangeArray(matrix);
Console.WriteLine();

