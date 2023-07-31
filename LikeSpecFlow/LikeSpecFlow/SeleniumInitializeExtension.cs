namespace LikeSpecFlow
{
    public static class SeleniumInitializeExtension
    {
        public static Test InitializeSeleniumWith_Parameter(
            this Test test,
            string seleniumParameters)
        {
            test.Report(seleniumParameters);
            var wrapper = new SeleniumWrapper();
            test.State["selenium"] = wrapper;
            return test;
        }
    }
}
