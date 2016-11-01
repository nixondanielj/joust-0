using System;

namespace DotNetCore.Joust
{
    public class Program : IJoust
    {
        public static void Main(string[] args)
        {
            var prog = new Program();
            int result = prog.Add(2, 2);
            Console.WriteLine($"2 + 2 = {result}");
            Console.ReadKey();
        }
        public int Add(int a, int b)
        {
            return a + b;
        }
    }
}
