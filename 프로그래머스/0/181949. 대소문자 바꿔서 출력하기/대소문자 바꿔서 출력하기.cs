using System;

public class Example
{
    public static void Main()
    {
        String s;

        Console.Clear();
        s = Console.ReadLine();

        for (int i = 0; i < s.Length; i++)
        {
            if ((int)s[i] >= 65 && (int)s[i] <= 90)
            {
                Console.Write(s[i].ToString().ToLower());
            }
            else if ((int)s[i] >= 97 && (int)s[i] <= 122)
            {
                Console.Write(s[i].ToString().ToUpper());
            }
            else
            {
                Console.Write(s[i]);
            }
        }
    }
}