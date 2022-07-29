class Program
{
    static void Main(string[] args)
    {
        //Fibonacci(5); 

        Console.WriteLine(Fatorial(5));
    }

    static void Fibonacci(int n)
    {
        int a = 1;
        int b = 0;
        int aux = 0;
        int resultado = 0;
        for (int i = 0; i < n; i++)
        {
            resultado = a;
            aux = a;
            a = a + b;
            b = aux;
        }
        Console.WriteLine($"O {n}º valor da sequência de Fibonacci é {resultado}");
    }

    static int Fatorial(int n)
    {
        if (n == 1)
        {
            return 1;
        }
        else
        {
            return n * Fatorial(n - 1);
        }
    }
}