namespace WindowsFormsApplication7
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.playButton = new System.Windows.Forms.Button();
            this.stopButton = new System.Windows.Forms.Button();
            this.playlistButton = new System.Windows.Forms.Button();
            this.playlist = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.volumeBar = new MB.Controls.ColorSlider();
            this.progressMusicBar = new MB.Controls.ColorSlider();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.prevBtn = new System.Windows.Forms.Button();
            this.nextBtn = new System.Windows.Forms.Button();
            this.pauseBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.repSng = new System.Windows.Forms.CheckBox();
            this.randomSng = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // playButton
            // 
            this.playButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("playButton.BackgroundImage")));
            this.playButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.playButton.Location = new System.Drawing.Point(13, 107);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(29, 32);
            this.playButton.TabIndex = 0;
            this.playButton.UseVisualStyleBackColor = true;
            this.playButton.Click += new System.EventHandler(this.playButton_Click);
            // 
            // stopButton
            // 
            this.stopButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("stopButton.BackgroundImage")));
            this.stopButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.stopButton.Location = new System.Drawing.Point(48, 107);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(31, 32);
            this.stopButton.TabIndex = 2;
            this.stopButton.UseVisualStyleBackColor = true;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // playlistButton
            // 
            this.playlistButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("playlistButton.BackgroundImage")));
            this.playlistButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.playlistButton.Location = new System.Drawing.Point(360, 107);
            this.playlistButton.Name = "playlistButton";
            this.playlistButton.Size = new System.Drawing.Size(36, 32);
            this.playlistButton.TabIndex = 3;
            this.playlistButton.UseVisualStyleBackColor = true;
            this.playlistButton.Click += new System.EventHandler(this.playlistButton_Click);
            // 
            // playlist
            // 
            this.playlist.FormattingEnabled = true;
            this.playlist.Location = new System.Drawing.Point(12, 12);
            this.playlist.Name = "playlist";
            this.playlist.Size = new System.Drawing.Size(276, 43);
            this.playlist.TabIndex = 4;
            this.playlist.SelectedIndexChanged += new System.EventHandler(this.playlist_SelectedIndexChanged);
            this.playlist.DoubleClick += new System.EventHandler(this.playButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(347, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "00:00:00";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(292, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "00:00:00";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Multiselect = true;
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // volumeBar
            // 
            this.volumeBar.BackColor = System.Drawing.Color.Transparent;
            this.volumeBar.BarInnerColor = System.Drawing.Color.OldLace;
            this.volumeBar.BarOuterColor = System.Drawing.Color.OldLace;
            this.volumeBar.BarPenColor = System.Drawing.Color.Silver;
            this.volumeBar.BorderRoundRectSize = new System.Drawing.Size(8, 8);
            this.volumeBar.ElapsedInnerColor = System.Drawing.Color.Yellow;
            this.volumeBar.ElapsedOuterColor = System.Drawing.Color.DarkOrange;
            this.volumeBar.LargeChange = ((uint)(5u));
            this.volumeBar.Location = new System.Drawing.Point(251, 111);
            this.volumeBar.Name = "volumeBar";
            this.volumeBar.Size = new System.Drawing.Size(103, 21);
            this.volumeBar.SmallChange = ((uint)(1u));
            this.volumeBar.TabIndex = 7;
            this.volumeBar.Text = "colorSlider3";
            this.volumeBar.ThumbOuterColor = System.Drawing.Color.Black;
            this.volumeBar.ThumbRoundRectSize = new System.Drawing.Size(8, 8);
            this.volumeBar.Value = 100;
            this.volumeBar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.volumeBar_Scroll);
            // 
            // progressMusicBar
            // 
            this.progressMusicBar.BackColor = System.Drawing.Color.Transparent;
            this.progressMusicBar.BarInnerColor = System.Drawing.Color.OldLace;
            this.progressMusicBar.BarOuterColor = System.Drawing.Color.OldLace;
            this.progressMusicBar.BarPenColor = System.Drawing.Color.Silver;
            this.progressMusicBar.BorderRoundRectSize = new System.Drawing.Size(8, 8);
            this.progressMusicBar.ElapsedInnerColor = System.Drawing.Color.Yellow;
            this.progressMusicBar.ElapsedOuterColor = System.Drawing.Color.Goldenrod;
            this.progressMusicBar.LargeChange = ((uint)(5u));
            this.progressMusicBar.Location = new System.Drawing.Point(12, 84);
            this.progressMusicBar.Name = "progressMusicBar";
            this.progressMusicBar.Size = new System.Drawing.Size(384, 17);
            this.progressMusicBar.SmallChange = ((uint)(1u));
            this.progressMusicBar.TabIndex = 5;
            this.progressMusicBar.Text = "colorSlider1";
            this.progressMusicBar.ThumbOuterColor = System.Drawing.Color.Black;
            this.progressMusicBar.ThumbRoundRectSize = new System.Drawing.Size(8, 8);
            this.progressMusicBar.Value = 0;
            this.progressMusicBar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.progressMusicBar_Scroll);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // prevBtn
            // 
            this.prevBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("prevBtn.BackgroundImage")));
            this.prevBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.prevBtn.Location = new System.Drawing.Point(125, 108);
            this.prevBtn.Name = "prevBtn";
            this.prevBtn.Size = new System.Drawing.Size(34, 31);
            this.prevBtn.TabIndex = 10;
            this.prevBtn.UseVisualStyleBackColor = true;
            this.prevBtn.Click += new System.EventHandler(this.prevBtn_Click);
            // 
            // nextBtn
            // 
            this.nextBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("nextBtn.BackgroundImage")));
            this.nextBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.nextBtn.Location = new System.Drawing.Point(165, 108);
            this.nextBtn.Name = "nextBtn";
            this.nextBtn.Size = new System.Drawing.Size(34, 31);
            this.nextBtn.TabIndex = 11;
            this.nextBtn.UseVisualStyleBackColor = true;
            this.nextBtn.Click += new System.EventHandler(this.nextBtn_Click);
            // 
            // pauseBtn
            // 
            this.pauseBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pauseBtn.BackgroundImage")));
            this.pauseBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pauseBtn.Location = new System.Drawing.Point(85, 108);
            this.pauseBtn.Name = "pauseBtn";
            this.pauseBtn.Size = new System.Drawing.Size(34, 31);
            this.pauseBtn.TabIndex = 12;
            this.pauseBtn.UseVisualStyleBackColor = true;
            this.pauseBtn.Click += new System.EventHandler(this.pauseBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "songName";
            // 
            // repSng
            // 
            this.repSng.AutoSize = true;
            this.repSng.Location = new System.Drawing.Point(295, 29);
            this.repSng.Name = "repSng";
            this.repSng.Size = new System.Drawing.Size(46, 17);
            this.repSng.TabIndex = 14;
            this.repSng.Text = "repit";
            this.repSng.UseVisualStyleBackColor = true;
            // 
            // randomSng
            // 
            this.randomSng.AutoSize = true;
            this.randomSng.Location = new System.Drawing.Point(348, 29);
            this.randomSng.Name = "randomSng";
            this.randomSng.Size = new System.Drawing.Size(61, 17);
            this.randomSng.TabIndex = 15;
            this.randomSng.Text = "random";
            this.randomSng.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 144);
            this.Controls.Add(this.randomSng);
            this.Controls.Add(this.repSng);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pauseBtn);
            this.Controls.Add(this.nextBtn);
            this.Controls.Add(this.prevBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.volumeBar);
            this.Controls.Add(this.progressMusicBar);
            this.Controls.Add(this.playlist);
            this.Controls.Add(this.playlistButton);
            this.Controls.Add(this.stopButton);
            this.Controls.Add(this.playButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "MyPlayer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected System.Windows.Forms.Button playButton;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.Button playlistButton;
        private System.Windows.Forms.ListBox playlist;
        private MB.Controls.ColorSlider progressMusicBar;
        private MB.Controls.ColorSlider volumeBar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button prevBtn;
        private System.Windows.Forms.Button nextBtn;
        private System.Windows.Forms.Button pauseBtn;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.CheckBox repSng;
        private System.Windows.Forms.CheckBox randomSng;
    }
}

