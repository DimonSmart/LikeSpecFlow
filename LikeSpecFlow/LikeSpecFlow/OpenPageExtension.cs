namespace LikeSpecFlow
{
    public static class OpenPageExtension
    {
        public static Test OpenPage(this Test test, string pageName)
        {
            test.Report(pageName);
            var wrapper = test.Get<SeleniumWrapper>();
            wrapper.Open(pageName);
            return test;
        }
    }
}
