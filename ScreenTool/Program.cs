namespace ScreenTool
{
    internal static class Program
    {
        public static string ProgramPath { get; } = @"C:\Mongo";
        public static string Imgure_ClientID = "";
        public static string Imgure_Token = "";

        [STAThread]
        static void Main()
        {
            if (!Directory.Exists(ProgramPath))
            {
                Directory.CreateDirectory(ProgramPath);
            }
            ApplicationConfiguration.Initialize();
            Application.Run(new Views.Window());
        }
    }
}