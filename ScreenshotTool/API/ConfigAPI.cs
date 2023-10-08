using ScreenTool;
using Newtonsoft.Json;

namespace ScreenshotTool.API
{
    public class ConfigAPI
    {

        public ConfigModel Initialize()
        {
            if (!File.Exists(ScreenTool.ScreenshotTool.ProgramPath + "\\config.json"))
            {
                File.Create(ScreenTool.ScreenshotTool.ProgramPath + "\\config.json").Close();
                File.WriteAllText(ScreenTool.ScreenshotTool.ProgramPath + "\\config.json", JsonConvert.SerializeObject(new ConfigModel()));
                return new ConfigModel();
            }
            else
            {
                var config = JsonConvert.DeserializeObject<ConfigModel>(File.ReadAllText(ScreenTool.ScreenshotTool.ProgramPath + "\\config.json"));
                ScreenTool.ScreenshotTool.Imgure_ClientID = config.Imgur_ClientID;
                ScreenTool.ScreenshotTool.Imgure_Token = config.Imgur_Token;
               
                return config;
            }
        }

        public void SaveConfig(ConfigModel config)
        {
            File.WriteAllText(ScreenTool.ScreenshotTool.ProgramPath + "\\config.json", JsonConvert.SerializeObject(config));
        }

        public class ConfigModel
        {
            public string Imgur_ClientID { get; set; } = "";
            public string Imgur_Token { get; set; } = "";
            public bool AutoUpload { get; set; } = false;
            public int StyleIndex { get; set; } = 0;
        }   

    }
}
