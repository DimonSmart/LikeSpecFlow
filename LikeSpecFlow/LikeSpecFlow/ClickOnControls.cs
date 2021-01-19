namespace LikeSpecFlow
{
    public static class ClickOnControls
    {
        public static Test ClickOn_Control(this Test test, string selector)
        {
            test.Report(selector);
            var wrapper = test.Get<SeleniumWrapper>();
            wrapper.Click(selector);
            return test;
        }
    }
}
