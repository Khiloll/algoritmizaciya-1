using System;

class Program
{
    static int F(int n)
    {
        if (n == 0)
        {
            return 0;
        }
        if (n % 3 == 2 && n > 0)
        {
            return F(n - 1) + 1;
        }
        if (n % 3 < 2)
        {
            return F((n - n % 3) / 3);
        }
        return 0;
    }

    static void Main(string[] args)
    {
        int i = 0;
        while (F(i) != 6)
        {
            i++;
        }
        Console.WriteLine(i);
    }
}