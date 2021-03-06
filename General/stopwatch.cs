using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Exercise1_Stopwatch
{
    public class Stopwatch
    {
        public DateTime StartTime;
        public TimeSpan Duration;

        public DateTime Start()
        {
            StartTime = DateTime.Now;
            return StartTime;
        }

        public TimeSpan Stop()

        {
            var stopTime = DateTime.Now;
            var Duration = stopTime - StartTime;
            return Duration;
        }

        public void Reset()
        {
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var casio = new Stopwatch();
            var rolling = true;
            var counting = false;
            while (rolling)
            {
                Console.WriteLine("Stopwatch. 'start', 'stop', or 'exit': ");
                while (true)
                {
                    var input = Console.ReadLine().ToLower();
                    if (input == "start")
                    {
                        if (counting == false)
                        {
                            casio.Start();
                            counting = true;
                            Console.WriteLine(casio.Start());
                        }
                        else
                        {
                            throw new InvalidOperationException();
                        }

                    }
                    else if (input == "stop")
                    {
                        Console.WriteLine("Duration: " + casio.Stop());
                        counting = false;
                        break;
                    }
                    else if (input == "exit")
                    {
                        rolling = false;
                        break;
                    }
                }

            }

        }
    }
}
