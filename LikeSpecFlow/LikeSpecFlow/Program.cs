using FluentAssertions;

namespace LikeSpecFlow
{
    class Program
    {
        static void Main(string[] args)
        {
            var test =
                new Test("Login test")
                   .InitializeSelenumWith_Parameter("/nocache")
                   .OpenPage("mail.ru")
                   .WaitWorElement_Clickable("loginButton")
                   .Type_OnControl_("Name", "Jon@mail.ru")
                   .Type_OnControl_("Password", "123")
                   .ClickOn_Control("Login")
                   .AssertForElement_Exists("logo");
            
            // test
            //       .AssertForElement_Exists("logo", i => { i.Should().BeOfType<Imagelement>().Which.LogoName.Should().BeNull(); });
            //test.Get<SeleniumWrapper>().Find("asdasd");
        }
    }
}
