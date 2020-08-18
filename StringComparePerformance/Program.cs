using System;
using System.Diagnostics;
using System.Linq;

namespace StringComparePerformance
{
    static class Program
    {
        static void Main(string[] args)
        {
            var alphabet = "abcdefghijklmnopqrstuvwxyz";
            var passShort = "The quick brown fox jumps over the lazy dog".ToLower();
            var failShort = "The quick brown fox jump over the lazy dog".ToLower();
            var failLong = "The quick brown fox jump over the lazy dogThe quick brown fox jump over the lazy dogThe quick brown fox jump over the lazy dogThe quick brown fox jump over the lazy dogThe quick brown fox jump over the lazy dogThe quick brown fox jump over the lazy dogThe quick brown fox jump over the lazy dogThe quick brown fox jump over the lazy dogThe quick brown fox jump over the lazy dogThe quick brown fox jump over the lazy dogThe quick brown fox jump over the lazy dogThe quick brown fox jump over the lazy dogThe quick brown fox jump over the lazy dogThe quick brown fox jump over the lazy dogThe quick brown fox jump over the lazy dogThe quick brown fox jump over the lazy dogThe quick brown fox jump over the lazy dogThe quick brown fox jump over the lazy dogThe quick brown fox jump over the lazy dogThe quick brown fox jump over the lazy dogThe quick brown fox jump over the lazy dogThe quick brown fox jump over the lazy dogThe quick brown fox jump over the lazy dogThe quick brown fox jump over the lazy dog".ToLower();
            var passEarlyLong = "The quick brown fox jumps over the lazy dogThe quick brown fox jumps over the lazy dogThe quick brown fox jumps over the lazy dogThe quick brown fox jumps over the lazy dogThe quick brown fox jumps over the lazy dogThe quick brown fox jumps over the lazy dogThe quick brown fox jumps over the lazy dogThe quick brown fox jumps over the lazy dogThe quick brown fox jumps over the lazy dogThe quick brown fox jumps over the lazy dogThe quick brown fox jumps over the lazy dogThe quick brown fox jumps over the lazy dogThe quick brown fox jumps over the lazy dogThe quick brown fox jumps over the lazy dogThe quick brown fox jumps over the lazy dogThe quick brown fox jumps over the lazy dogThe quick brown fox jumps over the lazy dogThe quick brown fox jumps over the lazy dogThe quick brown fox jumps over the lazy dogThe quick brown fox jumps over the lazy dogThe quick brown fox jumps over the lazy dogThe quick brown fox jumps over the lazy dogThe quick brown fox jumps over the lazy dogThe quick brown fox jumps over the lazy dog".ToLower();
            //passLateLong removes 's' until last character
            var passLateLong = "The quick brown fox jump over the lazy dogThe quick brown fox jump over the lazy dogThe quick brown fox jump over the lazy dogThe quick brown fox jump over the lazy dogThe quick brown fox jump over the lazy dogThe quick brown fox jump over the lazy dogThe quick brown fox jump over the lazy dogThe quick brown fox jump over the lazy dogThe quick brown fox jump over the lazy dogThe quick brown fox jump over the lazy dogThe quick brown fox jump over the lazy dogThe quick brown fox jump over the lazy dogThe quick brown fox jump over the lazy dogThe quick brown fox jump over the lazy dogThe quick brown fox jump over the lazy dogThe quick brown fox jump over the lazy dogThe quick brown fox jump over the lazy dogThe quick brown fox jump over the lazy dogThe quick brown fox jump over the lazy dogThe quick brown fox jump over the lazy dogThe quick brown fox jump over the lazy dogThe quick brown fox jump over the lazy dogThe quick brown fox jump over the lazy dogThe quick brown fox jump over the lazy dogs".ToLower();
            
            bool result = false;
            var sw = new Stopwatch();

            var calcs = 1;
            TestLogicSets(alphabet, passShort, result, sw, calcs);
            TestLogicSets(alphabet, failShort, result, sw, calcs);
            TestLogicSets(alphabet, failLong, result, sw, calcs);
            TestLogicSets(alphabet, passEarlyLong, result, sw, calcs);
            TestLogicSets(alphabet, passLateLong, result, sw, calcs);

            calcs = 100;
            TestLogicSets(alphabet, passShort, result, sw, calcs);
            TestLogicSets(alphabet, failShort, result, sw, calcs);
            TestLogicSets(alphabet, failLong, result, sw, calcs);
            TestLogicSets(alphabet, passEarlyLong, result, sw, calcs);
            TestLogicSets(alphabet, passLateLong, result, sw, calcs);

            calcs = 10000;
            TestLogicSets(alphabet, passShort, result, sw, calcs);
            TestLogicSets(alphabet, failShort, result, sw, calcs);
            TestLogicSets(alphabet, failLong, result, sw, calcs);
            TestLogicSets(alphabet, passEarlyLong, result, sw, calcs);
            TestLogicSets(alphabet, passLateLong, result, sw, calcs);

            Console.ReadKey();
        }

        public static void TestLogicSets(string alphabet, string input, bool result, Stopwatch sw, int calcs)
        {
            Console.WriteLine($"-------- BEGIN COMPARISON TEST --------");
            Console.WriteLine($"Input: {input}\nNumber of Calculations: {calcs}\n");
            Test1(alphabet, input, result, sw, calcs);
            Test2(alphabet, input, result, sw, calcs);
            Test3(alphabet, input, result, sw, calcs);
            Console.WriteLine($"--------  END COMPARISON TEST  --------\n");
        }

        public static void Test1(string alphabet, string input, bool result, Stopwatch sw, int calcs)
        {
            sw.Start();
            for (int x = 0; x < calcs; x++)
            {
                result = alphabet.Intersect(input).Count() == 26;
            }

            sw.Stop();
            Console.WriteLine($"Test 1\nTotal Time: {sw.ElapsedTicks}\nResult: {result}\n");
            sw.Reset();
        }

        public static void Test2(string alphabet, string input, bool result, Stopwatch sw, int calcs)
        {
            sw.Start();
            for (int x = 0; x < calcs; x++)
            {
                result = alphabet.All(x => input.Any(y => y == x));
            }

            sw.Stop();
            Console.WriteLine($"Test 2\nTotal Time: {sw.ElapsedTicks}\nResult: {result}\n");
            sw.Reset();
        }

        public static void Test3(string alphabet, string input, bool result, Stopwatch sw, int calcs)
        {            
            sw.Start();
            for (int x = 0; x < calcs; x++)
            {
                bool exit = false;
                for (int i = 0; i < alphabet.Length; i++)
                {
                    if (exit) break;
                    for (int j = 0; j < input.Length; j++)
                    {
                        if (alphabet[i] == input[j])
                            break;

                        if (j == input.Length - 1)
                        {
                            exit = true;
                            break;
                        }
                    }
                }
                result = !exit;
            }

            sw.Stop();
            Console.WriteLine($"Test 3\nTotal Time: {sw.ElapsedTicks}\nResult: {result}\n");
            sw.Reset();
        }        
    }
}
