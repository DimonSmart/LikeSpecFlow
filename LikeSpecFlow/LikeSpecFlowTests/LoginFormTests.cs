using FluentAssertions;
using LikeSpecFlow;
using Xunit;

namespace LikeSpecFlowTests
{
    public class LoginFormTests
    {
        [Fact]
        public void LoginSuccessTest()
        {
            var test =
                new Test("Login test")
                   .InitializeSelenumWith_Parameter("/nocache")
                   .OpenPage("mail.ru")
                   .WaitWorElement_Clickable("loginButton")
                   .Type_OnControl_("Name", "Jon@mail.ru")
                   .Type_OnControl_("Password", "123")
                   .ClickOn_Control("Login")
                   .AssertForElement_Exists("logo", i => { i.Should().BeOfType<Imagelement>().Which.LogoName.Should().BeNull(); });
        }

        [Theory]
        [InlineData("Jon@mail.ru", "123", null)]
        [InlineData("Jon@mail.ru", "123", "Error")]
        public void LoginSuccessTestDataDriven(string name, string password, string expectedLogoName)
        {
            new Test("Data driven Login test")
               .InitializeSelenumWith_Parameter("/nocache")
               .OpenPage("mail.ru")
               .WaitWorElement_Clickable("loginButton")
               .Type_OnControl_("Name", name)
               .Type_OnControl_("Password", password)
               .ClickOn_Control("Login")
               .AssertForElement_Exists("logo", i => { i.Should().BeOfType<Imagelement>().Which.LogoName.Should().Be(expectedLogoName); });
        }
    }
}
