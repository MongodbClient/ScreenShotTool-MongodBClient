using ScreenshotTool.API;
using System.Configuration;
using static ScreenshotTool.API.ConfigAPI;

namespace ScreenTool
{
    internal static class ScreenshotTool
    {
        public static string ProgramPath = @"C:\Mongo";
        public static string Imgure_ClientID = "";
        public static string Imgure_Token = "";
        public static bool AutoUpload = false;
        public static int StyleIndex = 0;
        public static ConfigAPI ConfigAPI { get; set; }
        public static ConfigModel config;

        [STAThread]
        static void Main()
        {
            if (!Directory.Exists(ProgramPath))
            {
                Directory.CreateDirectory(ProgramPath);
            }

            ConfigAPI = new ConfigAPI();
            config = ConfigAPI.Initialize();
            AutoUpload = config.AutoUpload;
            StyleIndex = config.StyleIndex;

            ApplicationConfiguration.Initialize();
            Application.Run(new Views.Window());
        }
    }
}