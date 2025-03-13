using System;
using System.IO;

namespace DemoTemplateMethod
{
    public static class ImagePathHelper
    {
        public static string GetImagePath(string imageName)
        {
            string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
            DirectoryInfo directory = new DirectoryInfo(baseDirectory);

            // Go up two levels
            DirectoryInfo projectDirectory = directory.Parent.Parent.Parent;

            return Path.Combine(projectDirectory.FullName, "images", imageName);
        }
    }
}