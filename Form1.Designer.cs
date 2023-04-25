namespace musicPlayer
{
    partial class window
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(window));
            this.playButton = new System.Windows.Forms.Button();
            this.pauseButton = new System.Windows.Forms.Button();
            this.nextButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.songBox = new System.Windows.Forms.ListBox();
            this.playlistBox = new System.Windows.Forms.ListBox();
            this.listButton = new System.Windows.Forms.Button();
            this.player = new AxWMPLib.AxWindowsMediaPlayer();
            this.songButton = new System.Windows.Forms.Button();
            this.volume = new System.Windows.Forms.TrackBar();
            this.addList = new System.Windows.Forms.Button();
            this.removeList = new System.Windows.Forms.Button();
            this.deleteList = new System.Windows.Forms.Button();
            this.selectedList = new System.Windows.Forms.Label();
            this.resetButton = new System.Windows.Forms.Button();
            this.songProgress = new System.Windows.Forms.ProgressBar();
            this.songArt = new System.Windows.Forms.PictureBox();
            this.stopButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.volume)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.songArt)).BeginInit();
            this.SuspendLayout();
            // 
            // playButton
            // 
            this.playButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.playButton.Font = new System.Drawing.Font("Courant", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playButton.Location = new System.Drawing.Point(447, 621);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(65, 63);
            this.playButton.TabIndex = 0;
            this.playButton.Text = "Play";
            this.playButton.UseVisualStyleBackColor = false;
            this.playButton.Click += new System.EventHandler(this.playButton_Click);
            // 
            // pauseButton
            // 
            this.pauseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.pauseButton.Font = new System.Drawing.Font("Courant", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pauseButton.Location = new System.Drawing.Point(376, 621);
            this.pauseButton.Name = "pauseButton";
            this.pauseButton.Size = new System.Drawing.Size(65, 63);
            this.pauseButton.TabIndex = 1;
            this.pauseButton.Text = "Pause";
            this.pauseButton.UseVisualStyleBackColor = false;
            this.pauseButton.Click += new System.EventHandler(this.pauseButton_Click);
            // 
            // nextButton
            // 
            this.nextButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.nextButton.Font = new System.Drawing.Font("Courant", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nextButton.Location = new System.Drawing.Point(305, 621);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(65, 63);
            this.nextButton.TabIndex = 2;
            this.nextButton.Text = "Next";
            this.nextButton.UseVisualStyleBackColor = false;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.backButton.Font = new System.Drawing.Font("Courant", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backButton.Location = new System.Drawing.Point(234, 621);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(65, 63);
            this.backButton.TabIndex = 3;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // songBox
            // 
            this.songBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.songBox.Font = new System.Drawing.Font("Courant", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.songBox.FormattingEnabled = true;
            this.songBox.ItemHeight = 12;
            this.songBox.Location = new System.Drawing.Point(849, 9);
            this.songBox.Name = "songBox";
            this.songBox.ScrollAlwaysVisible = true;
            this.songBox.Size = new System.Drawing.Size(310, 676);
            this.songBox.TabIndex = 5;
            this.songBox.SelectedIndexChanged += new System.EventHandler(this.songBox_SelectedIndexChanged);
            // 
            // playlistBox
            // 
            this.playlistBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.playlistBox.Font = new System.Drawing.Font("Courant", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playlistBox.ForeColor = System.Drawing.Color.Black;
            this.playlistBox.FormattingEnabled = true;
            this.playlistBox.ItemHeight = 12;
            this.playlistBox.Location = new System.Drawing.Point(12, 60);
            this.playlistBox.Name = "playlistBox";
            this.playlistBox.ScrollAlwaysVisible = true;
            this.playlistBox.Size = new System.Drawing.Size(568, 340);
            this.playlistBox.TabIndex = 6;
            this.playlistBox.SelectedIndexChanged += new System.EventHandler(this.playlistBox_SelectedIndexChanged);
            // 
            // listButton
            // 
            this.listButton.BackColor = System.Drawing.Color.Green;
            this.listButton.Font = new System.Drawing.Font("Courant", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.listButton.Location = new System.Drawing.Point(12, 590);
            this.listButton.Name = "listButton";
            this.listButton.Size = new System.Drawing.Size(198, 25);
            this.listButton.TabIndex = 7;
            this.listButton.Text = "New Playlist";
            this.listButton.UseVisualStyleBackColor = false;
            this.listButton.Click += new System.EventHandler(this.listButton_Click);
            // 
            // player
            // 
            this.player.Enabled = true;
            this.player.Location = new System.Drawing.Point(12, 409);
            this.player.Name = "player";
            this.player.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("player.OcxState")));
            this.player.Size = new System.Drawing.Size(831, 175);
            this.player.TabIndex = 4;
            this.player.TabStop = false;
            // 
            // songButton
            // 
            this.songButton.BackColor = System.Drawing.Color.Green;
            this.songButton.Font = new System.Drawing.Font("Courant", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.songButton.Location = new System.Drawing.Point(684, 622);
            this.songButton.Name = "songButton";
            this.songButton.Size = new System.Drawing.Size(158, 63);
            this.songButton.TabIndex = 8;
            this.songButton.Text = "Add Song";
            this.songButton.UseVisualStyleBackColor = false;
            this.songButton.Click += new System.EventHandler(this.songButton_Click);
            // 
            // volume
            // 
            this.volume.BackColor = System.Drawing.Color.Green;
            this.volume.Location = new System.Drawing.Point(633, 590);
            this.volume.Maximum = 100;
            this.volume.Name = "volume";
            this.volume.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.volume.Size = new System.Drawing.Size(45, 104);
            this.volume.TabIndex = 9;
            this.volume.TickFrequency = 10;
            this.volume.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.volume.Scroll += new System.EventHandler(this.volume_Scroll);
            // 
            // addList
            // 
            this.addList.BackColor = System.Drawing.Color.Green;
            this.addList.Font = new System.Drawing.Font("Courant", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addList.Location = new System.Drawing.Point(12, 621);
            this.addList.Name = "addList";
            this.addList.Size = new System.Drawing.Size(198, 25);
            this.addList.TabIndex = 10;
            this.addList.Text = "Add Song to Playlist";
            this.addList.UseVisualStyleBackColor = false;
            this.addList.Click += new System.EventHandler(this.addList_Click);
            // 
            // removeList
            // 
            this.removeList.BackColor = System.Drawing.Color.Green;
            this.removeList.Font = new System.Drawing.Font("Courant", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeList.Location = new System.Drawing.Point(12, 652);
            this.removeList.Name = "removeList";
            this.removeList.Size = new System.Drawing.Size(198, 25);
            this.removeList.TabIndex = 11;
            this.removeList.Text = "Remove Song from Playlist";
            this.removeList.UseVisualStyleBackColor = false;
            this.removeList.Click += new System.EventHandler(this.removeList_Click);
            // 
            // deleteList
            // 
            this.deleteList.BackColor = System.Drawing.Color.Green;
            this.deleteList.Font = new System.Drawing.Font("Courant", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteList.Location = new System.Drawing.Point(12, 683);
            this.deleteList.Name = "deleteList";
            this.deleteList.Size = new System.Drawing.Size(198, 25);
            this.deleteList.TabIndex = 12;
            this.deleteList.Text = "Delete Playlist";
            this.deleteList.UseVisualStyleBackColor = false;
            this.deleteList.Click += new System.EventHandler(this.deleteList_Click);
            // 
            // selectedList
            // 
            this.selectedList.AutoSize = true;
            this.selectedList.Font = new System.Drawing.Font("Courant", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectedList.ForeColor = System.Drawing.Color.Lime;
            this.selectedList.Location = new System.Drawing.Point(12, 9);
            this.selectedList.Name = "selectedList";
            this.selectedList.Size = new System.Drawing.Size(127, 22);
            this.selectedList.TabIndex = 13;
            this.selectedList.Text = "Playlists";
            // 
            // resetButton
            // 
            this.resetButton.BackColor = System.Drawing.Color.Green;
            this.resetButton.Font = new System.Drawing.Font("Courant", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetButton.Location = new System.Drawing.Point(12, 34);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(85, 21);
            this.resetButton.TabIndex = 14;
            this.resetButton.Text = "Return";
            this.resetButton.UseVisualStyleBackColor = false;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // songProgress
            // 
            this.songProgress.BackColor = System.Drawing.Color.Black;
            this.songProgress.ForeColor = System.Drawing.Color.Lime;
            this.songProgress.Location = new System.Drawing.Point(13, 540);
            this.songProgress.Name = "songProgress";
            this.songProgress.Size = new System.Drawing.Size(830, 44);
            this.songProgress.TabIndex = 15;
            this.songProgress.MouseDown += new System.Windows.Forms.MouseEventHandler(this.songProgress_MouseDown);
            // 
            // songArt
            // 
            this.songArt.Location = new System.Drawing.Point(586, 144);
            this.songArt.Name = "songArt";
            this.songArt.Size = new System.Drawing.Size(256, 256);
            this.songArt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.songArt.TabIndex = 16;
            this.songArt.TabStop = false;
            // 
            // stopButton
            // 
            this.stopButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.stopButton.Font = new System.Drawing.Font("Courant", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stopButton.Location = new System.Drawing.Point(562, 622);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(65, 63);
            this.stopButton.TabIndex = 17;
            this.stopButton.Text = "Stop";
            this.stopButton.UseVisualStyleBackColor = false;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1171, 711);
            this.Controls.Add(this.stopButton);
            this.Controls.Add(this.songArt);
            this.Controls.Add(this.songProgress);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.selectedList);
            this.Controls.Add(this.deleteList);
            this.Controls.Add(this.removeList);
            this.Controls.Add(this.addList);
            this.Controls.Add(this.volume);
            this.Controls.Add(this.songButton);
            this.Controls.Add(this.listButton);
            this.Controls.Add(this.playlistBox);
            this.Controls.Add(this.songBox);
            this.Controls.Add(this.player);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.pauseButton);
            this.Controls.Add(this.playButton);
            this.Name = "window";
            this.Text = "Music Player";
            this.Load += new System.EventHandler(this.window_Load);
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.volume)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.songArt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button playButton;
        private System.Windows.Forms.Button pauseButton;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.Button backButton;
        private AxWMPLib.AxWindowsMediaPlayer player;
        private System.Windows.Forms.ListBox songBox;
        private System.Windows.Forms.ListBox playlistBox;
        private System.Windows.Forms.Button listButton;
        private System.Windows.Forms.Button songButton;
        private System.Windows.Forms.TrackBar volume;
        private System.Windows.Forms.Button addList;
        private System.Windows.Forms.Button removeList;
        private System.Windows.Forms.Button deleteList;
        private System.Windows.Forms.Label selectedList;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.ProgressBar songProgress;
        private System.Windows.Forms.PictureBox songArt;
        private System.Windows.Forms.Button stopButton;
    }
}

