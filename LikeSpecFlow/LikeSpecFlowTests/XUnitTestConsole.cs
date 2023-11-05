using LikeSpecFlow.Consoles;
using Xunit.Abstractions;

namespace LikeSpecFlowTests;

public class XUnitTestConsole : ITestConsole
{
    private readonly ITestOutputHelper _outputHelper;

    public XUnitTestConsole(ITestOutputHelper outputHelper)
    {
        _outputHelper = outputHelper;
    }

    public void WriteLine(string s = "")
    {
        _outputHelper.WriteLine(s);
    }
}