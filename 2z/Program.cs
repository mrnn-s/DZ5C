// Написать программу масштабирования фигуры  
//в лекции от 16.10 (4) что то было
void FillMatrix (double[,] matrix, int min, int max)
{
    Random random = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)       
        matrix[i,j] = random.Next(min, max);
    }
}

void PrintMatrix (double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
       Console.Write($"({matrix[i,0]}; {matrix[i,1]}) ");
       Console.WriteLine ();
    
    }
}

void MashMatrix(double[,] matrix, double k)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
           matrix[i,j] = matrix[i,j] * k;    
    }
}

double [,] matrix = new double [4,2];
Console.WriteLine("Коориднаты исходной фигуры: ");
FillMatrix(matrix, -8, 8);
PrintMatrix(matrix);
Console.WriteLine("Введите коэффициент масштабирования k");
double k = double.Parse (Console.ReadLine() ?? "0");
Console.WriteLine("Координаты фигуры после масштаирования: ");
MashMatrix(matrix, k);
PrintMatrix(matrix);