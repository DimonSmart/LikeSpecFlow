using LikeSpecFlow;
using LikeSpecFlow.Actions;
using LikeSpecFlow.Consoles;
using Xunit;
using Xunit.Abstractions;

namespace LikeSpecFlowTests;

public class LoginFormTests
{
    private readonly ITestConsole _testConsole;

    public LoginFormTests(ITestOutputHelper outputHelper)
    {
        _testConsole = new XUnitTestConsole(outputHelper);
    }

    [Fact]
    public void LoginSuccessTest()
    {
        CreateTest("Login test")
            .InitializeSeleniumWith_Parameter("/nocache")
            .OpenWebPage("mail.ru")
            .Type_On_Control("Name", "Jon@mail.ru")
            .Type_On_Control("Password", "123")
            .ClickOn_Button("Login")
            .AssertFor_HeaderExists("Welcome logo");
    }

    [Theory]
    [InlineData("Jon@mail.ru", "123", "Welcome John")]
    [InlineData("Alex@mail.ru", "1234", "Welcome Alex")]
    public void LoginSuccessTestDataDriven(string userName, string password, string expectedLogoName)
    {
        CreateTest("Data driven Login test")
            .InitializeSeleniumWith_Parameter("/nocache")
            .OpenWebPage("mail.ru")
            .Type_On_Control("UserName", userName)
            .Type_On_Control("Password", password)
            .ClickOn_Button("Login")
            .AssertFor_HeaderExists(expectedLogoName);
    }

    private TestSession CreateTest(string testName)
    {
        return new TestSession(testName, _testConsole);
    }
}