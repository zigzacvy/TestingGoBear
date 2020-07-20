using System;

namespace ConsoleApp3
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            ICaculator caculator = new Caculator();
            var data = caculator.Creation();
            var strInput = "CABBAGE";
            var total = caculator.TotalPoints(data, strInput);
            Console.WriteLine(total);
        }
    }
}