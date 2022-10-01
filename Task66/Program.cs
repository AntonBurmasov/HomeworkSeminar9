// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму 
// натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


int ReadNumber(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

void PrintSumMtoN(int m, int n, int sum)
{

    sum = sum + m;
    m = m + 1;
    if (m > n)
    {
        Console.WriteLine(sum);
        return;

    }

    else
    {
        PrintSumMtoN(m, n, sum);

    }

}

int numberM = ReadNumber("Введите M");
int numberN = ReadNumber("Введите N");
int sum = 0;

if (numberM > numberN)
{
    Console.WriteLine("Число M не должно быть больше числа N.");
    return;
}


PrintSumMtoN(numberM, numberN, sum);