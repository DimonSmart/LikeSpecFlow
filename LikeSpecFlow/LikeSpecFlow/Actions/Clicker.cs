using LikeSpecFlow.Selenium;

namespace LikeSpecFlow.Actions;

public static class Clicker
{
    public static TestSession ClickOn_Button(this TestSession test, string controlName)
    {
        test.Report(controlName);
        var wrapper = test.Get<SeleniumWrapper>();
        wrapper.Click(controlName);
        return test;
    }
}