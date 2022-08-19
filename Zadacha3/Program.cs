// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

// m = 2, n = 3 -> A(m,n) = 29

int M = InputNumbers("Введите значение M: ");
int N = InputNumbers("Введите значение N: ");

int functionAkkerman = Akk(M, N);

Console.Write($"Функция Аккермана = {functionAkkerman} ");

int InputNumbers(string input)
{
    Console.Write(input);
    int output = Convert.ToInt32(Console.ReadLine());
    return output;
}

int Akk(int M, int N)
{
  if (M == 0) return N + 1;
  else if (N == 0) return Akk(M - 1, 1);
  else return Akk(M - 1, Akk(M, N - 1));
}







