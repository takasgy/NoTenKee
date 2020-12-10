using System.IO;

namespace NoTenKeeTest
{
    class TestUtil
    {
        public static string  CreateOutputPath(string basePath, string testPath)
        {
            string outputPath = basePath + testPath;
            if (!Directory.Exists(outputPath))
            {
                Directory.CreateDirectory(outputPath);
            }
            return outputPath;
        }
    }
}
