using System.IO;

namespace Forms.Driving.Infrastructure
{
    public static class DirectoryHelper
    {
        public static void CreateDirectoryForFile(string fullFilename)
        {
            var path = Path.GetDirectoryName(fullFilename);

            if (path != null)
                Directory.CreateDirectory(path);
        }
    }
}