using ScreenTool;
using Newtonsoft.Json;

namespace ScreenshotTool.API
{
    public class ConfigAPI
    {

        public ConfigModel Initialize()
        {
            if (!File.Exists(Program.ProgramPath + "\\config.json"))
            {
                File.Create(Program.ProgramPath + "\\config.json").Close();
                File.WriteAllText(Program.ProgramPath + "\\config.json", JsonConvert.SerializeObject(new ConfigModel()));
                return new ConfigModel();
            }
            else
            {
                var config = JsonConvert.DeserializeObject<ConfigModel>(File.ReadAllText(Program.ProgramPath + "\\config.json"));
                Program.Imgure_ClientID = config.Imgur_ClientID;
                Program.Imgure_Token = config.Imgur_Token;
               
                return config;
            }
        }

        public void SaveConfig(ConfigModel config)
        {
            File.WriteAllText(Program.ProgramPath + "\\config.json", JsonConvert.SerializeObject(config));
        }

        public class ConfigModel
        {
            public string Imgur_ClientID { get; set; } = "";
            public string Imgur_Token { get; set; } = "";
            public bool AutoUpload { get; set; } = false;
        }   

    }
}
