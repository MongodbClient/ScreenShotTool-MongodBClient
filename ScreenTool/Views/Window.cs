using ScreenTool.API;

namespace ScreenTool.Views
{
    public partial class Window : Form
    {

        private string SelectedFilePath = null;
        private int activeScreenIndex = 0;

        public Window()
        {
            InitializeComponent();

            Screen[] screens = Screen.AllScreens;
            for (int i = 1; i <= screens.Length; i++)
            {
                listBox1.Items.Add("Screen | " + i);
            }
            for (int i = 0; i < Screen.AllScreens.Length; i++)
            {
                if (Screen.AllScreens[i] == Screen.PrimaryScreen)
                {
                    listBox1.SelectedIndex = i;
                    UpdateStatusPicture(i);
                    break;
                }
            }
            StartPosition = FormStartPosition.CenterScreen;
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
                    screenshot.Dispose();
                    ImgurAPI imgurAPI = new ImgurAPI();
                    string url = await imgurAPI.GetAPICallback(filePath);
                    MessageBox.Show($"Screenshot URL: {url}\nScreenshot saved as {filePath}", "Screenshot Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Clipboard.SetText(url);
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
    }
}
