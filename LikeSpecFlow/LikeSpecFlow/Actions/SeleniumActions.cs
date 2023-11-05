using LikeSpecFlow.Selenium;

namespace LikeSpecFlow.Actions;

public static class SeleniumActions
{
    public static TestSession InitializeSeleniumWith_Parameter(
        this TestSession test,
        string seleniumParameters)
    {
        test.Report(seleniumParameters);
        var wrapper = new SeleniumWrapper();
        test.State["selenium"] = wrapper;
        return test;
    }
}