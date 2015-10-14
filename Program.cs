using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/**
* Review with Tom
*/
namespace Lesson7_Part_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int prompt  = 0;    // initialize prompt
            const int MAX_TURNS = 100;
            const int MIN_TURNS = 10;

            while(prompt != 4)
            {
                Console.WriteLine("++++++++++++++++++++++++++");
                Console.WriteLine("+    1. Say Hello        +");
                Console.WriteLine("+    2. Say Goodbye      +");
                Console.WriteLine("+    3. Take a Turn      +");
                Console.WriteLine("+                        +");
                Console.WriteLine("+    4. EXIT PROGRAM     +");
                Console.WriteLine("+                        +");
                Console.WriteLine("++++++++++++++++++++++++++");
                Console.Write( "Please choose and option above (1 -4): " );

                prompt = Convert.ToInt32(Console.ReadLine());

                switch (prompt)
                {
                    case 1:
                        Console.WriteLine( "Say Hello!" );
                        PressKey();
                        Console.Clear();
                        break;
                    case 2:
                        Console.WriteLine( "Say Goodbye!" );
                        PressKey();
                        Console.Clear();
                        break;
                    case 3:
                        Console.WriteLine();
                        for (int count = 0; count <= MAX_TURNS ; count++)
                        {
                            // Print out count everytime we increment by 5
                            if (count % 5 == 0)
                            {
                                Console.WriteLine(count);
                            }
                        }
                        PressKey();
                        break;
                    case 4:
                        Console.WriteLine();
                        break;
                    default:
                        Console.WriteLine( "Please select a valid option!" );
                        break;
                }
            }
            PressKey();
        }

        private static void PressKey()  
        {
            Console.WriteLine( "\n++++++++++++++++++++++++++++++++" );
            Console.WriteLine( "Press any key to exit..." );
            Console.ReadKey();
        }
    }
}
