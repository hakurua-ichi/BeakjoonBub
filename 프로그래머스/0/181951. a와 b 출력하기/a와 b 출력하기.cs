using System;

public class Example
{
    public static void Main()
    {
        String[] s;

        Console.Clear();
        s = Console.ReadLine().Split(' ');

        int a = Int32.Parse(s[0]);
        int b = Int32.Parse(s[1]);
        if ((a >= -100000 && a <= 100000) || (b >= -100000 && b <= 100000))
        {
            Console.WriteLine("a = " + a);
            Console.WriteLine("b = " + b);
        }
    }
}