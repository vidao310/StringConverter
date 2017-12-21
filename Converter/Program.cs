using System;

namespace Converter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string!");
            string input;
            do 
            {
                input = Console.ReadLine();
                if(input != "--force-exit")
                {
                    var result = StringConverter.Convert(input);
                    Console.WriteLine("Result: "+result+ "\nEnter another string or '--force-exit' to exit.");
                }
            }
            while (input != "--force-exit");
        }
    }
}
