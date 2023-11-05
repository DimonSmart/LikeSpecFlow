using LikeSpecFlow.Actions;

namespace LikeSpecFlow;

internal static class Program
{
    private static void Main(string[] _)
    {
        new TestSession("Login test")
            .InitializeSeleniumWith_Parameter("/nocache")
            .OpenWebPage("mail.ru")
            .Type_On_Control("UserName", "Jon@mail.ru")
            .Type_On_Control("Password", "123")
            .ClickOn_Button("Login")
            .AssertFor_HeaderExists("Welcome logo");
    }
}