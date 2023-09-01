using System.Security.Cryptography.X509Certificates;

namespace MyPoem
{
    internal class Program
    {
         

       static void Main(string[] args)
        {
         String name = ("Will");
         int seconds = 1;
         float radius = 1f;
         double width = 4.5;
         double length = 16.2;

//Write Name then prints Seconds in year 
         Console.WriteLine(name);
           
            seconds = 365 * 24 * 60 * 60;
            Console.WriteLine(seconds);
            
            
            Console.WriteLine("nothing");
            
// Prints perimeter

            Console.WriteLine("Perimeter = " + width*2 + length*2);


        for (int i = 0; i < 4;  i++)
            {
                Console.WriteLine(i);
            }
        

        

        }
    }
}