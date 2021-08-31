using System;

namespace LikeSpecFlow
{
    public class ColoredTestConsole : IColoredTestConsole
    {
        public void WriteLine(string s = "")
        {
            Console.WriteLine(s);
        }

        public ConsoleColor ForegroundColor
        {
            get => Console.ForegroundColor;
            set => Console.ForegroundColor = value;
        }

        public void Write(char c)
        {
            Console.Write(c);
        }
    }
}