using System;
using System.Data;

class Program
{
    static void Main()
    {
        Console.Write("Enter expression: ");
        string expression = Console.ReadLine();

        try
        {
            DataTable table = new DataTable();
            var result = table.Compute(expression, null);
            Console.WriteLine($"The result is: {result}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error evaluating expression: {ex.Message}");
        }
    }
}
