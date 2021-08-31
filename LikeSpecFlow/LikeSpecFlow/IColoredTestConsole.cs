using System;

namespace LikeSpecFlow
{
    public interface IColoredTestConsole : ITestConsole
    {
        public ConsoleColor ForegroundColor { get; set; }
        public void Write(char c);

    }
}