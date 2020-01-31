using System;
					
public class Program
{
	public static void Main()
	{
        Console.WriteLine("Type an integer from 1 to 93: ");
        string inputString = Console.ReadLine();
        try
        {
            int inputValue = Convert.ToInt32(inputString);
            if (inputValue < 1 || inputValue > 93)
            {
                Console.WriteLine("Wrong input " + inputString);
            }
            else
            {
                long[] sequence = new long[inputValue];
                CalculateFibonacciSequence(sequence);
                
                string result = string.Join(",", sequence);
                
                Console.WriteLine("Fibonacci sequence for length " + inputValue + " is " + result);
            }
        }
        catch
        {
            Console.WriteLine("Wrong input " + inputString);
        } 
	}
    private static void CalculateFibonacciSequence(long[] sequence)
    {
        for(int i = 0; i <= sequence.Length - 1; i++)
        {
            if(i == 0 || i == 1)
            {
                sequence[i] = i;
            }
            else
            {
                sequence[i] = sequence[i - 1] + sequence[i - 2];
            }
        }
    }
}