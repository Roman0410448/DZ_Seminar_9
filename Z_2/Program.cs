// Задача 66: Задайте значения M и N. Напишите программу,
// которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 3

Console.Write("Введите число M: ");
int M = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());

int SumNaturalNumbers (int start, int end)
{
if (start > end) 
{
    return 0;
}
else
{
    return start + SumNaturalNumbers(start + 1, end);
}   
}

Console.WriteLine($"Сумма натуральных чисел равна:  {SumNaturalNumbers(M, N)}");