namespace LikeSpecFlow
{
    public static class TypeOnControls
    {
        public static Test Type_OnControl_(this Test test, string selector, string text)
        {
            test.Report(new string[] { text, selector });
            var wrapper = test.Get<SeleniumWrapper>();
            wrapper.SetText(selector, text);
            return test;
        }
    }
}
