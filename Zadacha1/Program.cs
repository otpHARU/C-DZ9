// Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.

// M = 1; N = 5. -> ""1, 2, 3, 4, 5""
// M = 4; N = 8. -> ""4, 6, 7, 8""

int M = InputNumbers("Введите значение M: ");
int N = InputNumbers("Введите значение N: ");
Console.WriteLine();
Console.WriteLine($"M={M}, N={N}");
Console.WriteLine();
Console.Write($"Натуральные числа от {M} до {N}: ");
PrintNumber(M, N);
Console.WriteLine();

int InputNumbers(string input)
{
    Console.Write(input);
    int output = Convert.ToInt32(Console.ReadLine());
    return output;
}

void PrintNumber(int M, int N)
{
    if (N > M)
    for (int i = M; i <= N; i++) Console.Write($"{i} ");
    else
        for (int i = N; i <= M; i++) Console.Write($"{i} ");
}


