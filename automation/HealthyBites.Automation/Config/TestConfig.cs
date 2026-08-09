namespace HealthyBites.Automation.Config
{
    public static class TestConfig
    {
        // Walks up from the test output folder until it finds index.html —
        // works on any machine, no matter where the repo is cloned to.
        public static string GetPageUrl(string fileName)
        {
            var dir = new DirectoryInfo(AppContext.BaseDirectory);

            while (dir != null && !File.Exists(Path.Combine(dir.FullName, "index.html")))
            {
                dir = dir.Parent;
            }

            if (dir == null)
                throw new DirectoryNotFoundException(
                    "Could not locate the website root (index.html) above the test output folder.");

            var filePath = Path.Combine(dir.FullName, fileName);
            return new Uri(filePath).AbsoluteUri;
        }
    }
}
