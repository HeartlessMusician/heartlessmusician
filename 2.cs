using System;

namespace ConsoleApp4
{
    class Symbol1
    {
        static void Main(string[] args)
        {
            var charWriter = new Symbol();
            charWriter.OnKeyPressed += (sender, ch) => Console.WriteLine(ch);
            charWriter.Run();
        }
    }
}
