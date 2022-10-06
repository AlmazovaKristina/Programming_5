double[] CreateArrayRndInt(int size,double min,double max)
{
    double [] array = new double[size];
    var rnd = new Random();

    for (int i = 0; i < size; i++)
    {
        array[i] = rnd.NextDouble()*(max - min) + min;
        array[i] = Math.Round(array[i],1,MidpointRounding.ToZero);
    }
    return array;
}

double [] arrayGlobal = CreateArrayRndInt(4,1,10);


double EvenNumbers (double[] array)
{
    double maxNumber = array[0];
    double minNumber = array[0];
    double Difference  = 0;
    for (int i = 1; i < array.Length; i++)
    {
      if (maxNumber<array[i])
        {
        maxNumber= array[i];
        }
        else if (minNumber > array[i])
         {
         minNumber= array[i];
         }
    }
    Difference = maxNumber - minNumber;
    return Difference;
}
double elementDifferens = EvenNumbers(arrayGlobal);
elementDifferens = Math.Round(elementDifferens,1,MidpointRounding.ToZero);
Console.WriteLine($"Разница между масимальным и минимальным элементом массива = {elementDifferens}");
EvenNumbers(arrayGlobal);


