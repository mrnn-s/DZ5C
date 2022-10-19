// Написать программу копирования массива

void FillArray (int[] array)
{
     for (int i = 0; i < array.Length; i++)    
       array[i] = new Random().Next(1,20);       
}

void PrintArray (int[] array)
{
    for (int i = 0; i < array.Length; i++)
    Console.Write ($"{array[i]} ");     
}
void CopyArray (int[] array)
{
    for (int i = 0; i < array.Length; i++)
       array[i] = array[i];  
}

int [] array = new int [8];
FillArray (array);
Console.WriteLine("array:");
PrintArray (array);
Console.WriteLine();
CopyArray(array);
Console.WriteLine ("A copy of your array:");
PrintArray(array);