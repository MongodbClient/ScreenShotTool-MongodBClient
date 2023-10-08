namespace ScreenTool.Views
{
    partial class Window
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            listBox1 = new ListBox();
            label1 = new Label();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            button2 = new Button();
            folderBrowserDialog1 = new FolderBrowserDialog();
            checkBox1 = new CheckBox();
            button3 = new Button();
            errorProvider1 = new ErrorProvider(components);
            panel1 = new Panel();
            button6 = new Button();
            button5 = new Button();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label3 = new Label();
            label2 = new Label();
            button4 = new Button();
            contextMenuStrip1 = new ContextMenuStrip(components);
            colorDialog1 = new ColorDialog();
            contextMenuStrip2 = new ContextMenuStrip(components);
            menuStrip1 = new MenuStrip();
            stylesToolStripMenuItem = new ToolStripMenuItem();
            darkToolStripMenuItem = new ToolStripMenuItem();
            lightToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            panel1.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(12, 28);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(144, 94);
            listBox1.TabIndex = 0;
            listBox1.SelectedIndexChanged += ScreenBoxIndexChange;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 5);
            label1.Name = "label1";
            label1.RightToLeft = RightToLeft.Yes;
            label1.Size = new Size(47, 15);
            label1.TabIndex = 1;
            label1.Text = "Screens";
            // 
            // button1
            // 
            button1.Location = new Point(12, 128);
            button1.Name = "button1";
            button1.Size = new Size(120, 34);
            button1.TabIndex = 2;
            button1.Text = "Screenshot";
            button1.UseVisualStyleBackColor = true;
            button1.Click += ScreenShotButtonOnClick;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(162, 28);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(612, 395);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // button2
            // 
            button2.Location = new Point(12, 168);
            button2.Name = "button2";
            button2.Size = new Size(120, 32);
            button2.TabIndex = 4;
            button2.Text = "Directory";
            button2.UseVisualStyleBackColor = true;
            button2.Click += SelectFolderButtonOnClick;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(20, 282);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(112, 19);
            checkBox1.TabIndex = 5;
            checkBox1.Text = "Upload? (Imgur)";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += UploadCheckBoxOnCheckedChanged;
            // 
            // button3
            // 
            button3.Location = new Point(12, 206);
            button3.Name = "button3";
            button3.Size = new Size(120, 32);
            button3.TabIndex = 6;
            button3.Text = "Refresh";
            button3.UseVisualStyleBackColor = true;
            button3.Click += RefreshButtonOnClick;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // panel1
            // 
            panel1.Controls.Add(button6);
            panel1.Controls.Add(button5);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(321, 49);
            panel1.Name = "panel1";
            panel1.Size = new Size(339, 252);
            panel1.TabIndex = 7;
            // 
            // button6
            // 
            button6.Location = new Point(81, 217);
            button6.Name = "button6";
            button6.Size = new Size(75, 23);
            button6.TabIndex = 5;
            button6.Text = "Back";
            button6.UseVisualStyleBackColor = true;
            button6.Click += BackButtonClick;
            // 
            // button5
            // 
            button5.Location = new Point(0, 217);
            button5.Name = "button5";
            button5.Size = new Size(75, 23);
            button5.TabIndex = 4;
            button5.Text = "Change";
            button5.UseVisualStyleBackColor = true;
            button5.Click += ChangeButtonClick;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(3, 63);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(322, 23);
            textBox2.TabIndex = 3;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(3, 161);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(314, 23);
            textBox1.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(0, 133);
            label3.Name = "label3";
            label3.Size = new Size(119, 25);
            label3.TabIndex = 1;
            label3.Text = "Imgur Secret";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(0, 35);
            label2.Name = "label2";
            label2.Size = new Size(134, 25);
            label2.TabIndex = 0;
            label2.Text = "Imgur ClientID";
            // 
            // button4
            // 
            button4.BackColor = SystemColors.Control;
            button4.Location = new Point(12, 244);
            button4.Name = "button4";
            button4.Size = new Size(120, 32);
            button4.TabIndex = 8;
            button4.Text = "Settings";
            button4.UseVisualStyleBackColor = false;
            button4.Click += SettingsButtonOnClick;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // contextMenuStrip2
            // 
            contextMenuStrip2.Name = "contextMenuStrip2";
            contextMenuStrip2.Size = new Size(61, 4);
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { stylesToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 10;
            menuStrip1.Text = "menuStrip1";
            // 
            // stylesToolStripMenuItem
            // 
            stylesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { darkToolStripMenuItem, lightToolStripMenuItem });
            stylesToolStripMenuItem.Name = "stylesToolStripMenuItem";
            stylesToolStripMenuItem.Size = new Size(49, 20);
            stylesToolStripMenuItem.Text = "Styles";
            // 
            // darkToolStripMenuItem
            // 
            darkToolStripMenuItem.Name = "darkToolStripMenuItem";
            darkToolStripMenuItem.Size = new Size(101, 22);
            darkToolStripMenuItem.Text = "Dark";
            darkToolStripMenuItem.Click += DarkThemeChangeListener;
            // 
            // lightToolStripMenuItem
            // 
            lightToolStripMenuItem.Checked = true;
            lightToolStripMenuItem.CheckState = CheckState.Checked;
            lightToolStripMenuItem.Name = "lightToolStripMenuItem";
            lightToolStripMenuItem.Size = new Size(101, 22);
            lightToolStripMenuItem.Text = "Light";
            lightToolStripMenuItem.Click += LightThemeChangeListener;
            // 
            // Window
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            Controls.Add(button4);
            Controls.Add(panel1);
            Controls.Add(button3);
            Controls.Add(checkBox1);
            Controls.Add(button2);
            Controls.Add(pictureBox1);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(listBox1);
            MainMenuStrip = menuStrip1;
            Name = "Window";
            Text = "ScreenshotTool by MongodbClient";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBox1;
        private Label label1;
        private Button button1;
        private PictureBox pictureBox1;
        private Button button2;
        private FolderBrowserDialog folderBrowserDialog1;
        private CheckBox checkBox1;
        private Button button3;
        private ErrorProvider errorProvider1;
        private Panel panel1;
        private Label label2;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label3;
        private Button button4;
        private Button button5;
        private Button button6;
        private ContextMenuStrip contextMenuStrip1;
        private ColorDialog colorDialog1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem stylesToolStripMenuItem;
        private ToolStripMenuItem darkToolStripMenuItem;
        private ToolStripMenuItem lightToolStripMenuItem;
        private ContextMenuStrip contextMenuStrip2;
    }
}