// Задача 38: Задайте массив вещественных чисел.
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());

double[] FillArray(int length)
{
    double[] array = new double[length];
    for (int i = 0; i < length; i++)
    {
        array[i] = Math.Round(new Random().NextDouble() * 40 - 20, 1);
    }
    return array;
}

void PrintArray(double[] array)
{
    Console.Write("[ ");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1)
            Console.Write($"{array[i]}  ");
        else
            Console.WriteLine($"{array[i]} ]\n");
    }
}

string DiffMinMax(double[] array)
{
    double min = array[0];
    double max = array[0];
    double diff = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max)
            max = array[i];
        else if (array[i] < min)
            min = array[i];
    }
    diff = Math.Round((max - min),2);
    return $"MAX элемент массива = {max}\nMIN элемент массива = {min}\nРазница между элементами массива равна: {diff}\n";
}

Console.WriteLine();
double[] massiv = FillArray(size);
PrintArray(massiv);
Console.WriteLine(DiffMinMax(massiv));

