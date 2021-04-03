using System.IO;

namespace NoTenKeeTest2
{
    class TestUtil
    {
        public static string CreateOutputPath(string basePath, string testPath)
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