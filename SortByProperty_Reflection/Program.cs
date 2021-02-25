using BenchmarkDotNet.Running;
using System;
using System.Linq;

namespace SortByProperty_Reflection
{
    class Program
    {
        static void Main(string[] args)
        {
            var summary = BenchmarkRunner.Run<ReflectionSortByPropertyName_VS_LINQSort>();
        }

        public static string RandomStringGenerate(int length)
        {
            Random random = new Random();

            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }
    }
}
