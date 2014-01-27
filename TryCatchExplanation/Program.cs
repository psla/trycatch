namespace TryCatchExplanation
{
    using System;
    using System.Diagnostics;

    class Program
    {
        private const int IterationCount = 100000;

        static void Main()
        {
            int[] data = { 1 };
            var sw = new Stopwatch();
            
            sw.Start();
            SumTryCatch(data);
            sw.Stop();
            Console.WriteLine("{0} ms - try catch sum", sw.Elapsed.TotalMilliseconds);

            sw.Restart();
            SumSafe(data);
            sw.Stop();
            Console.WriteLine("{0} ms - checked sum", sw.Elapsed.TotalMilliseconds);
        }

        private static int SumTryCatch(int[] data)
        {
            int sum = 0;
            for (int i = 0; i < IterationCount; i++)
            {
                try
                {
                    sum += data[i];
                }
                catch
                {
                }
            }

            return sum;
        }

        private static int SumSafe(int[] data)
        {
            int sum = 0;
            for (int i = 0; i < IterationCount; i++)
            {
                if (i < data.Length)
                {
                    sum += data[i];
                }
            }

            return sum;
        }
    }
}
