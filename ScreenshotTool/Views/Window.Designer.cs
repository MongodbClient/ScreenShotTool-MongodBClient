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
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(12, 28);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(144, 94);
            listBox1.TabIndex = 0;
            listBox1.SelectedIndexChanged += ScreenBoxIndexChange;
            label1.AutoSize = true;
            label1.Location = new Point(12, 5);
            label1.Name = "label1";
            label1.RightToLeft = RightToLeft.Yes;
            label1.Size = new Size(47, 15);
            label1.TabIndex = 1;
            label1.Text = "Screens";
            button1.Location = new Point(12, 128);
            button1.Name = "button1";
            button1.Size = new Size(120, 34);
            button1.TabIndex = 2;
            button1.Text = "Screenshot";
            button1.UseVisualStyleBackColor = true;
            button1.Click += ScreenShotButtonOnClick;
            pictureBox1.Location = new Point(162, 28);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(612, 395);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            button2.Location = new Point(12, 168);
            button2.Name = "button2";
            button2.Size = new Size(120, 32);
            button2.TabIndex = 4;
            button2.Text = "Directory";
            button2.UseVisualStyleBackColor = true;
            button2.Click += SelectFolderButtonOnClick;
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(29, 254);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(112, 19);
            checkBox1.TabIndex = 5;
            checkBox1.Text = "Upload? (Imgur)";
            checkBox1.UseVisualStyleBackColor = true;
            button3.Location = new Point(12, 206);
            button3.Name = "button3";
            button3.Size = new Size(120, 32);
            button3.TabIndex = 6;
            button3.Text = "Refresh";
            button3.UseVisualStyleBackColor = true;
            button3.Click += RefreshButtonOnClick;
            errorProvider1.ContainerControl = this;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button3);
            Controls.Add(checkBox1);
            Controls.Add(button2);
            Controls.Add(pictureBox1);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(listBox1);
            Name = "Window";
            Text = "ScreenshotTool by MongodbClient";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
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
    }
}