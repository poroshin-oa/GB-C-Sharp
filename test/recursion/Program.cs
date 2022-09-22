// Рекурсия на примере вычисления факториала
double Factorial(int n)
{
    if (n == 1 || n == 0)
    {
        return 1;
    }
    else
    {
        return n * Factorial(n - 1);
    }
}

Console.WriteLine(Factorial(39));

// Рекурсия на примере чисел Фибоначчи
int Fibonacci(int n)
{
    if (n == 1 || n == 2)
    {
        return 1;
    }
    else
    {
        return Fibonacci(n - 1) + Fibonacci(n - 2);
    }
}

Console.WriteLine(Fibonacci(5));