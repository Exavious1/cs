class Program
{
    static int SumRecursive(int m, int n)
    {
        if (m > n)
        {
            return 0;
        }
        else
        {
            return m + SumRecursive(m + 1, n);
        }
    }

    static void Main(string[] args)
    {
        int M = 1;
        int N = 15;
        Console.WriteLine(SumRecursive(M, N));

        M = 4;
        N = 8;
        Console.WriteLine(SumRecursive(M, N));
    }
}
