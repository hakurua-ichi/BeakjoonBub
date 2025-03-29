using System;

public class Example
{
    public static void Main()
    {
        Console.Clear();
        String s = Console.ReadLine();

        Console.WriteLine(s + (int.Parse(s)%2 == 0? " is even" : " is odd"));
    }
}