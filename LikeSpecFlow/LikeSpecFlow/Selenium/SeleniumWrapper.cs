using System;

namespace LikeSpecFlow.Selenium;

public class SeleniumWrapper
{
    public void Open(string pageName)
    {
        Log($"Selenium. Open:{pageName}");
    }

    public string GetText(string selector)
    {
        Log($"Selenium. GetText:{selector}");
        return "sample";
    }

    public void SetText(string selector, string text)
    {
        Log($"Selenium. SetText:{text} For:{selector}");
    }

    public void Click(string selector)
    {
        Log($"Selenium. Click element:{selector}");
    }

    public void Log(string s)
    {
        Console.WriteLine(s);
    }

    public void WaitFor(string selector)
    {
        Log($"Selenium. Wait for element:{selector}");
    }

    public IWebElement Find(string selector)
    {
        Log($"Selenium. Find element:{selector}");
        return new ImageElement();
    }
}