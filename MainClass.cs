using System;

namespace MathemeticsTable
{
    class MainClass
    {
        
        static void Main()
        {
            Console.Write("Enter Starting Number: ");
            int start = int.Parse(Console.ReadLine());

            Console.Write("Enter Last Number: ");
            int last = int.Parse(Console.ReadLine());

            for (int i = start; i <= last; i++)
            {
                for(int j=1;j<=5;j++)
                {
                    Console.WriteLine("{0}*{1}={2}",i,j,i*j);
                }
                Console.WriteLine("-----------------------");
            }
           
        }
    }
}
