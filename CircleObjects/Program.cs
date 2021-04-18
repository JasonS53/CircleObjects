using System;

namespace CircleObjects
{
    class Program
    {
        static void Main(string[] args)
        {            
            Circle circle1 = new Circle(0);

            double circumference = 0;
            double area = 0;
            string circumferenceF = "";
            string areaF = "";

            int count = 0;

            bool runProgram = true;
            while (runProgram)
               
            try
                {
                    Console.WriteLine("Please enter a radius to be calculated");
                    double radius = double.Parse(Console.ReadLine());
                    if (radius < 0)
                    {
                        throw new Exception("Cannot be less than 0");
                    }
                    else
                    {
                        count += 1;

                        circumference = circle1.CalculateCircumference(radius);
                        circumferenceF = circle1.CalculateFormattedCircumference(circumference);
                        Console.WriteLine($"Formatted circumference of the circle is: {circumferenceF}");
                        area = circle1.CalculateArea(radius)
                        areaF = circle1.CalculateFormattedArea(area);
                        Console.WriteLine($"Formatted area is : {areaF}");

                        Console.WriteLine("Do you want to continue? y/n)");
                        
                        

                        while (true)
                        {
                            string yesno = Console.ReadLine();
                                             
                            if (yesno == "y")
                            {
                                break;
                            }
                            else if (yesno == "n")
                            {
                                Console.WriteLine($"Goodbye.  You created {count} circles.");
                                runProgram = false;
                                break;
                            }
                            else
                            {
                                Console.WriteLine("That was not a valid entry.");
                            }
                        }
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
            }            
        }
    }
}





