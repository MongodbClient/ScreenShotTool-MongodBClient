namespace ScreenTool
{
    internal static class Program
    {
        public readonly static string ProgramPath = @"C:\Mongo";
        public readonly static string Imgure_ClientID = "";
        public readonly static string Imgure_Token = "";

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