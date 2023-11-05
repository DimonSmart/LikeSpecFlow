using LikeSpecFlow.Selenium;

namespace LikeSpecFlow.Actions;

public static class Navigation
{
    public static TestSession OpenWebPage(this TestSession test, string url)
    {
        test.Report(url);
        var wrapper = test.Get<SeleniumWrapper>();
        wrapper.Open(url);
        return test;
    }
}