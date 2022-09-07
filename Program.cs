/*
 Author: Stavya Singh
 Date: 9/6/2022
 Description: This is a C# Console application code to provide a conditional statement.
*/



using System; // calling System Library


namespace ConditionalStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            // IF/ELSE IF/ELSE
            try
            { 
                Console.WriteLine("Enter number grade you expect to get for ISM 4300:");
                int n1 = Convert.ToInt32(Console.ReadLine());

                if ((n1 >= 98) && (n1 <= 100))
                {
                    Console.WriteLine("Letter Grade: A+");
                    Console.ReadKey(true);
                }

                else if ((n1 >= 92) && (n1 <= 97))
                {
                    Console.WriteLine("Letter Grade: A");
                    Console.ReadKey(true);
                }

                else if ((n1 >= 90) && (n1 <= 91))
                {
                    Console.WriteLine("Letter Grade: A-");
                    Console.ReadKey(true);
                }

                else if ((n1 >= 88) && (n1 <= 89))
                {
                    Console.WriteLine("Letter Grade: B+");
                    Console.ReadKey(true);
                }

                else if ((n1 >= 82) && (n1 <= 87))
                {
                    Console.WriteLine("Letter Grade: B");
                    Console.ReadKey(true);
                }

                else if ((n1 >= 80) && (n1 <= 81))
                {
                    Console.WriteLine("Letter Grade: B-");
                    Console.ReadKey(true);
                }

                else if ((n1 >= 78) && (n1 <= 79))
                {
                    Console.WriteLine("Letter Grade: C+");
                    Console.ReadKey(true);
                }

                else if ((n1 >= 72) && (n1 <= 77))
                {
                    Console.WriteLine("Letter Grade: C");
                    Console.ReadKey(true);
                }

                else if ((n1 >= 70) && (n1 <= 71))
                {
                    Console.WriteLine("Letter Grade: C-");
                    Console.ReadKey(true);
                }

                else if ((n1 >= 68) && (n1 <= 69))
                {
                    Console.WriteLine("Letter Grade: D+");
                    Console.ReadKey(true);
                }

                else if ((n1 >= 62) && (n1 <= 67))
                {
                    Console.WriteLine("Letter Grade: D");
                    Console.ReadKey(true);
                }

                else if ((n1 >= 60) && (n1 <= 61))
                {
                    Console.WriteLine("Letter Grade: D-");
                    Console.ReadKey(true);
                }

                else if (n1 < 60)
                {
                    Console.WriteLine("Letter Grade: F");
                    Console.ReadKey(true);
                }

                else
                {
                    Console.WriteLine("Input is invalid, please enter a number between 0-100");
                    Console.ReadKey(true);
                }
            }
            catch
            {
                Console.WriteLine("Invalid Input");
            };


































            





         










        }
    }
}