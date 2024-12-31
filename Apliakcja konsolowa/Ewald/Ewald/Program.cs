using System;

internal class Program
{
    private static void Wypelnij(int[] tab)
    {
        for (int i = 0; i < tab.Length; i++)
        {
            tab[i] = i + 2;
        }
    }

    private static void Main(string[] args)
    {
        int[] ints = new int[99];
        Wypelnij(ints);

        int max = (int)Math.Sqrt(ints[ints.Length - 1]);

        for (int i = 0; i < ints.Length; i++)
        {
            if (ints[i] != 0 && ints[i] <= max)
            {
                int current = ints[i];
                for (int j = current * current - 2; j < ints.Length; j += current)
                {
                    ints[j] = 0;
                }
            }
        }

        Console.Write("Liczby pierwsze (od 2 do 100): ");

        foreach (int i in ints)
        {
            if (i != 0) Console.Write(i + " ");
        }
    }
}
