namespace LikeSpecFlow
{
    public static class WaitForPageExtension
    {
        public static Test WaitWorElement_Clickable(this Test test, string selector)
        {
            test.Report(selector);
            var wrapper = test.Get<SeleniumWrapper>();
            wrapper.WaitFor(selector);
            return test;
        }
    }
}
