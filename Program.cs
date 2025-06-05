using System;

class Program
{
    // Function to calculate average of marks
    static double CalculateAverage(int[] marks)
    {
        int sum = 0;
        foreach (int mark in marks)
        {
            sum += mark;
        }
        return (double)sum / marks.Length;
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Enter your name:");
        string name = Console.ReadLine();

        Console.WriteLine("Enter number of subjects:");
        int n = int.Parse(Console.ReadLine());

        int[] marks = new int[n];

        // Taking marks input
        for (int i = 0; i < n; i++)
        {
            Console.Write($"Enter marks for subject {i + 1}: ");
            marks[i] = int.Parse(Console.ReadLine());
        }

        // Calculate average
        double avg = CalculateAverage(marks);

        // Display result
        Console.WriteLine($"\nHello {name}, your average mark is: {avg}");

        // Simple grade logic
        if (avg >= 80)
            Console.WriteLine("Grade: A");
        else if (avg >= 60)
            Console.WriteLine("Grade: B");
        else if (avg >= 40)
            Console.WriteLine("Grade: C");
        else
            Console.WriteLine("Grade: F");
    }
}
