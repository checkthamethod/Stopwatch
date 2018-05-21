
using System;
using System.Runtime.InteropServices;

namespace Stopwatch
{
    class Program
    {
        static void Main(string[] args)
        {
            var stopwatch = new Stopwatch();
            string userInput;
            bool appRunning = true;
            
            Console.WriteLine("Bryan's Stopwatch");
            while (appRunning == true)
            {
                Console.WriteLine("Press s to start the watch; st to stop the watch; press r to reset stopwatch; press e to exit");
                userInput = Console.ReadLine();
                switch (userInput.ToLower())
                {
                    case "s":
                        try
                        {
                            stopwatch.Start();
                            Console.WriteLine("Stopwatch started...");
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e.Message);
                        }

                        break;
                    case "st":
                        try
                        {
                            stopwatch.Stop();
                            Console.WriteLine("Stopwatch stopped...");
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e.Message);
                        }

                        break;
                    case "e":
                        try
                        {
                            appRunning = false;
                            Console.WriteLine("Stopwatch stopped...");
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e.Message);
                        }

                        break;
                    case "r":
                        try
                        {
                            stopwatch.Reset();
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e.Message);
                        }

                        break;
                    default:
                        Console.WriteLine("Error! Please press a button listed above");
                        break;
                }


            }

            Console.ReadKey();



        }
    }
}
