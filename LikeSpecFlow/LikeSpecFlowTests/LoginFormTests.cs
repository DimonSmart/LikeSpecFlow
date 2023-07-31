using FluentAssertions;
using LikeSpecFlow;
using Xunit;
using Xunit.Abstractions;

namespace LikeSpecFlowTests
{
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
                .OpenPage("mail.ru")
                .WaitWorElement_Clickable("loginButton")
                .Type_OnControl_("Name", "Jon@mail.ru")
                .Type_OnControl_("Password", "123")
                .ClickOn_Control("Login")
                .AssertForElement_Exists("logo",
                    i => i.Should()
                        .BeOfType<ImageElement>()
                        .Which
                        .LogoName
                        .Should().BeNull()); // Check for right logo
        }

        [Theory]
        [InlineData("Jon@mail.ru", "123", null)]
        [InlineData("Jon1@mail.ru", "1234", null)]
        public void LoginSuccessTestDataDriven(string name, string password, string expectedLogoName)
        {
            CreateTest("Data driven Login test")
                .InitializeSeleniumWith_Parameter("/nocache")
                .OpenPage("mail.ru")
                .WaitWorElement_Clickable("loginButton")
                .Type_OnControl_("Name", name)
                .Type_OnControl_("Password", password)
                .ClickOn_Control("Login")
                .AssertForElement_Exists("logo",
                    i => i.Should().BeOfType<ImageElement>().Which.LogoName.Should().Be(expectedLogoName));
        }

        private Test CreateTest(string testName)
        {
            return new Test(testName, _testConsole);
        }
    }
}