using System;
using System.IO;

class Program
{
    static void Main()
    {
        int count = 0;
        int m = 0;
        
        using (StreamReader reader = new StreamReader("17.txt"))
        {
            string[] lines = File.ReadAllLines("17.txt");
            int[] l = Array.ConvertAll(lines, int.Parse);

            for (int i = 0; i < l.Length - 1; i++)
            {
                for (int j = i + 1; j < l.Length; j++)
                {
                    if ((l[i] + l[j]) % 10 == 0)
                    {
                        count++;
                        m = Math.Max(m, l[i] + l[j]);
                    }
                }
            }
        }
        
        Console.WriteLine(count + " " + m);
    }
}