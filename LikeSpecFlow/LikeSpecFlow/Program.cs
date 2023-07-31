namespace LikeSpecFlow;

internal static class Program
{
    private static void Main(string[] _)
    {
        new Test("Login test")
            .InitializeSeleniumWith_Parameter("/nocache")
            .OpenPage("mail.ru")
            .WaitWorElement_Clickable("loginButton")
            .Type_OnControl_("Name", "Jon@mail.ru")
            .Type_OnControl_("Password", "123")
            .ClickOn_Control("Login")
            .AssertForElement_Exists("logo");
    }
}