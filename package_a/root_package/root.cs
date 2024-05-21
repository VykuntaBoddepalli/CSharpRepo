using System;

class Program
{
    static void Main()
    {
        int result1 = Add(3, 5); // Example usage of Add method
        Console.WriteLine("Add result: " + result1);

        int result2 = Sub(7, 2); // Example usage of Sub method
        Console.WriteLine("Sub result: " + result2);

        TimePass(10, 3); // Example usage of TimePass method
    }

    static int Add(int a, int b)
    {
        return a + b;
    }

    static int Sub(int a, int b)
    {
        return a - b;
    }

    static void TimePass(int a, int b)
    {
        Add(a, b); // Call Add method
        Sub(a, b); // Call Sub method
    }
}
