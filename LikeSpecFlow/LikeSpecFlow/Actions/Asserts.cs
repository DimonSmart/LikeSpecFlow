using LikeSpecFlow.Selenium;
using Xunit;

namespace LikeSpecFlow.Actions;

/// <summary>
/// NB! Not real Selenium. Just a demo
/// </summary>
public static class Asserts
{
    public static TestSession AssertFor_HeaderExists(
        this TestSession test,
        string elementName)
    {
        test.Report(elementName);
        var wrapper = test.Get<SeleniumWrapper>();
        var element = wrapper.Find(elementName);
        Assert.NotNull(element);
        return test;
    }
}