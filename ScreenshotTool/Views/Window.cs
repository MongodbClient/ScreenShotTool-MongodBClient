using ScreenshotTool.API;
using ScreenTool.API;

namespace ScreenTool.Views
{
    public partial class Window : Form
    {

        private string SelectedFilePath = null;
        private int activeScreenIndex = 0;
        private bool Uploading = false;

        public Window()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;

            panel1.Visible = false;

            for (int i = 0; i < Screen.AllScreens.Length; i++)
            {
                listBox1.Items.Add("Screen | " + i);
                if (Screen.AllScreens[i] == Screen.PrimaryScreen)
                {
                    listBox1.SelectedIndex = i;
                    UpdateStatusPicture(i);
                }
            }

            checkBox1.Checked = Program.AutoUpload;

        }

        private void ScreenBoxIndexChange(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != activeScreenIndex)
            {
                UpdateStatusPicture(listBox1.SelectedIndex);
                activeScreenIndex = listBox1.SelectedIndex;
            }
        }

        private async void ScreenShotButtonOnClick(object sender, EventArgs e)
        {

            if (Uploading) return;

            int screenIndex = listBox1.SelectedIndex;
            Screen screen = Screen.AllScreens[screenIndex];
            Bitmap screenshot = new Bitmap(screen.Bounds.Width, screen.Bounds.Height);
            using (Graphics graphics = Graphics.FromImage(screenshot))
            {
                graphics.CopyFromScreen(screen.Bounds.X, screen.Bounds.Y, 0, 0, screen.Bounds.Size);
            }

            string filePath = $"{(SelectedFilePath != null ? SelectedFilePath : Program.ProgramPath)}\\screenshot_{DateTime.Now.ToString("yyyy-MM-dd_HH-mm-ss")}.png";
            try
            {

                screenshot.Save(filePath, System.Drawing.Imaging.ImageFormat.Png);
                if (!checkBox1.Checked)
                {
                    Clipboard.SetImage(screenshot);
                    screenshot.Dispose();
                    MessageBox.Show($"Screenshot saved as {filePath}", "Screenshot Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    Uploading = true;
                    screenshot.Dispose();
                    ImgurAPI imgurAPI = new ImgurAPI();
                    string url = await imgurAPI.GetAPICallback(filePath);
                    MessageBox.Show($"Screenshot URL: {url}\nScreenshot saved as {filePath}", "Screenshot Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Clipboard.SetText(url);
                    Uploading = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void SelectFolderButtonOnClick(object sender, EventArgs e)
        {
            folderBrowserDialog1.Description = "Select a folder to save the screenshots in";
            folderBrowserDialog1.RootFolder = Environment.SpecialFolder.Desktop;
            DialogResult result = folderBrowserDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                SelectedFilePath = folderBrowserDialog1.SelectedPath;
            }
        }

        private void RefreshButtonOnClick(object sender, EventArgs e)
        {
            UpdateStatusPicture(listBox1.SelectedIndex);
        }

        private void UpdateStatusPicture(int screenIndex)
        {
            Screen screen = Screen.AllScreens[screenIndex];
            Bitmap screenshot = new Bitmap(screen.Bounds.Width, screen.Bounds.Height);
            using (Graphics graphics = Graphics.FromImage(screenshot))
            {
                graphics.CopyFromScreen(screen.Bounds.X, screen.Bounds.Y, 0, 0, screen.Bounds.Size);
            }

            float aspectRatio = (float)screenshot.Width / screenshot.Height;
            int targetHeight = (int)(pictureBox1.Width / aspectRatio);

            Bitmap resizedScreenshot = new Bitmap(pictureBox1.Width, targetHeight);
            using (Graphics graphics = Graphics.FromImage(resizedScreenshot))
            {
                graphics.DrawImage(screenshot, 0, 0, pictureBox1.Width, targetHeight);
            }
            pictureBox1.Image = resizedScreenshot;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void SettingsButtonOnClick(object sender, EventArgs e)
        {

            panel1.Visible = true;
            pictureBox1.Visible = false;
            textBox2.Text = Program.config.Imgur_ClientID;
            textBox1.Text = Program.config.Imgur_Token;
        }


        private void ChangeButtonClick(object sender, EventArgs e)
        {
            var config = new ConfigAPI.ConfigModel();
            config.Imgur_Token = textBox1.Text;
            config.Imgur_ClientID = textBox2.Text;
            Program.ConfigAPI.SaveConfig(config);
            Program.config = config;
            Program.Imgure_ClientID = config.Imgur_ClientID;
            Program.Imgure_Token = config.Imgur_Token;
            panel1.Visible = false;
            pictureBox1.Visible = true;
        }


        private void BackButtonClick(object sender, EventArgs e)
        {
            panel1.Visible = false;
            pictureBox1.Visible = true;
        }



        private void UploadCheckBoxOnCheckedChanged(object sender, EventArgs e)
        {
            Program.AutoUpload = checkBox1.Checked;
            Program.config.AutoUpload = checkBox1.Checked;
            Program.ConfigAPI.SaveConfig(Program.config);
        }
    }
}
