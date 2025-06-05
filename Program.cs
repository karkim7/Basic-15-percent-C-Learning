using System;
class Program
{ 
   static double CalculateAverage(int[] marks) 
   {
    
    int sum=0;
    
    foreach (int mark in marks)
    {
        
        sum += mark;
    }
    
    
    return (double) sum /marks.Length;
    
    
}

    static void Main(string[] args)
    {

        Console.WriteLine("Please, enter your name: ");
        string name = Console.ReadLine();
        
        Console.WriteLine("Please, enter the number of subjects: ");
        int n = int.Parse(Console.ReadLine());
        
        int[] marks = new int[n];
        
        
        
        //taking marks input
        
        for (int i=0; i < n; i++)
        {
            Console.WriteLine($"Please, enter the marks of {i+1} :  ");
            marks[i] = int.Parse(Console.ReadLine());
        }
        
        //calculat average
        double avg = CalculateAverage(marks);
        
        //Display the result
        
        Console.WriteLine($"\nThe average of {name} is: {avg} ");
        
        //Now, determining grades
        if (avg >= 80)
        Console.WriteLine(" Your grade is : A ");
        else if (avg >=60)
         Console.WriteLine( " Your grade is : B ");
         else if (avg >= 40 )
          Console.WriteLine(" Your grade is : C ");
          else
          Console.WriteLine(" Your grade is : F ");
    }
}
        
        
   
    
