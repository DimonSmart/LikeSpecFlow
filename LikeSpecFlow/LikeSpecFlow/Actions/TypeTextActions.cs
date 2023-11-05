using LikeSpecFlow.Selenium;

namespace LikeSpecFlow.Actions;

public static class TypeTextActions
{
    public static TestSession Type_On_Control(this TestSession test, string controlName, string textToType)
    {
        test.Report(new[] { textToType, controlName });
        var wrapper = test.Get<SeleniumWrapper>();
        wrapper.SetText(controlName, textToType);
        return test;
    }
}