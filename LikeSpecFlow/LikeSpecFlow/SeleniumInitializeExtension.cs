namespace LikeSpecFlow
{
    public static class SeleniumInitializeExtension
    {
        public static Test InitializeSelenumWith_Parameter(this Test test, string seleniumParameters)
        {
            var wrapper = new SeleniumWrapper();
            test.State["selenum"] = wrapper;
            test.Report(seleniumParameters);
            return test;
        }
    }
}
