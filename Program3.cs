Console.WriteLine("Введите длину ряда чисел");
int lenght = Convert.ToInt32(Console.ReadLine());
int sum = 0;
for (int i = 0; i < lenght; i++)
{
    if (i % 5 == 0 || i % 7 == 0)
    {
        sum = sum + i;
    }
}
Console.WriteLine($"Сумма чисел будет равна {sum}");
