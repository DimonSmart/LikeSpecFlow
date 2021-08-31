using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

namespace LikeSpecFlow
{
    public class Test
    {
        public readonly string TestName;
        private readonly ITestConsole _testConsole;
        public int StepNumber;
        public Test(string testName, ITestConsole testConsole = null)
        {
            TestName = testName;
            _testConsole = testConsole ?? new ColoredTestConsole();
        }

        public readonly Dictionary<string, object> State = new Dictionary<string, object>();

        public void Report(string parameter, [CallerMemberName] string stepName = "")
        {
            Report(new string[] { parameter }, stepName);
        }

        public void Report(string[] parameters, [CallerMemberName] string stepName = "")
        {
            stepName = stepName.SplitByCapitalLetters();
            var splitted = stepName.Split("_");
            var sb = new List<string>();
            for (int i = 0; i < Math.Max(splitted.Length, parameters.Length); i++)
            {
                if (splitted.Length > i)
                {
                    sb.Add(splitted[i].Trim());
                }
                if (parameters.Length > i)
                {
                    sb.Add("<" + parameters[i] + ">");
                }
            }

            Write($"Step {StepNumber++}:{string.Join(" ", sb)}");
        }

        private void Write(string s)
        {
            if (_testConsole is IColoredTestConsole coloredTestConsole)
            {
                WriteColored(s, coloredTestConsole);
            }
            else
            {
                _testConsole.WriteLine(s);
            }
        }

        private static void WriteColored(string s, IColoredTestConsole coloredTestConsole)
        {
            const ConsoleColor defaultColor = ConsoleColor.Yellow;
            const ConsoleColor parameterColor = ConsoleColor.Green;
            coloredTestConsole.ForegroundColor = defaultColor;
            foreach (var c in s)
            {
                if (c == '<')
                {
                    Console.ForegroundColor = parameterColor;
                    continue;
                }

                if (c == '>')
                {
                    Console.ForegroundColor = defaultColor;
                    continue;
                }

                coloredTestConsole.Write(c);
            }
            coloredTestConsole.WriteLine();
            Console.ResetColor();
        }

        public T Get<T>()
        {
            return State.Values.OfType<T>().First();
        }
        public T Get<T>(string name)
        {
            return (T)State[name];
        }
    }
}
