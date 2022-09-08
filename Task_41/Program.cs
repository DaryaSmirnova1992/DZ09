Console.Write("Введите числа через запятую: ");
int[] array = Array.ConvertAll(Console.ReadLine().Split(','), int.Parse);
int num = 0;
 
for (int i = 0; i < array.Length; i++)
{
    if (array[i] > 0)
    {
        num++;
    }
}
 
Console.WriteLine($"Кол-во чисел > 0: {num}");
