int[] CreateArrayRndInt(int size,int min,int max)
{
    int [] array = new int[size];
    var rnd = new Random();

    for (int i = 0; i < size; i++)
    {
        array[i] = rnd.Next(min,max+1);
    }
    return array;
}

void PrintArray (int[] array)
{
    Console.Write("[");
    for (int i = 0; i <= array.Length - 2;i++) Console.Write($"{array[i]},");
    Console.WriteLine($"{array[array.Length - 1]}]");
}
int [] arrayGlobal = CreateArrayRndInt(4,-100,100);


int EvenNumbers (int[] array)
{
    int sumOfNumber = 0;
    for (int i = 0; i < array.Length; i++)
    {
      if (i % 2 == 1)
        {
        sumOfNumber = sumOfNumber  + array[i]; 
        }
    }
    return sumOfNumber;
}
int oddPositions = EvenNumbers(arrayGlobal);
Console.WriteLine($"Сумма элементов на нечётных позициях = {oddPositions}");
EvenNumbers(arrayGlobal);
PrintArray( arrayGlobal);
