using System;

namespace whileloop
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 5;
            while(counter < 5){
                Console.WriteLine("{0}- Hello ",counter+1);
                counter++;
            }
            
           
        }
    }
}
