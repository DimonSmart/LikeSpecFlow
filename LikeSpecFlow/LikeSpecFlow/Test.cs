using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

namespace LikeSpecFlow
{
    public class Test
    {
        public readonly string TestName;
        public int StepNumber;
        public Test(string testName)
        {
            TestName = testName;
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

            WriteColored($"Step {StepNumber++}:{string.Join(" ", sb)}");
        }

        public void WriteColored(string s)
        {
            const ConsoleColor defaultColor = ConsoleColor.Yellow;
            const ConsoleColor parameterColor = ConsoleColor.Green;
            Console.ForegroundColor = defaultColor;
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

                Console.Write(c);
            }
            Console.WriteLine();
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

        internal object SeleniumAssert(Action<object> p)
        {
            throw new NotImplementedException();
        }
    }
}
