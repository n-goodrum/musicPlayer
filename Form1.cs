using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using TagLib;
using TagLib.Id3v2;

namespace musicPlayer
{
    public partial class window : Form
    {
        public window()
        {
            InitializeComponent();
        }

        //CHANGE THIS STRINGS TO EDIT FILE LOCATIONS
        string folderLocation = @"D:\MTSU Repository\CSCI3037\musicPlayer";
        //location of the folder that holds all data files called "PlayLists"
        //THIS CAN NOT BE AN EMPTY STRING, MUST ENTER A VALUE

        OpenFileDialog ofd = new OpenFileDialog();

        List<string> files = new List<string>();        //locations of each song
        List<string> playlists = new List<string>();    //locations of each playlist
        List<string> songsList = new List<string>();    //locations of each song in the current playlist
        bool inPlaylist = false;

        string currentList = "";

        //general music control start
        private void playButton_Click(object sender, EventArgs e)
        {
            player.Ctlcontrols.play();
        }

        private void pauseButton_Click(object sender, EventArgs e)
        {
            player.Ctlcontrols.pause();
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            if(songBox.SelectedIndex < songBox.Items.Count-1)
            {
                songBox.SelectedIndex = songBox.SelectedIndex + 1;
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            if (songBox.SelectedIndex > 0)
            {
                songBox.SelectedIndex = songBox.SelectedIndex - 1;
            }
        }

        private void songBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (songBox.SelectedItem != null)
            {
                player.URL = files[songBox.SelectedIndex];
                player.Ctlcontrols.play();

                try
                {
                    var file = TagLib.File.Create(files[songBox.SelectedIndex]);
                    var bin = (byte[])(file.Tag.Pictures[0].Data.Data);
                    songArt.Image = Image.FromStream(new MemoryStream(bin));
                }
                catch
                {

                }

            }
        }
        //volume slider
        private void volume_Scroll(object sender, EventArgs e)
        {
            player.settings.volume = volume.Value;
        }

        private void songProgress_MouseDown(object sender, MouseEventArgs e)
        {
            player.Ctlcontrols.currentPosition = player.currentMedia.duration * e.X / songProgress.Width;
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            player.Ctlcontrols.stop();
        }

        //general music controls end

        //buton adds new songs to the total song list
        private void songButton_Click(object sender, EventArgs e)
        {
            ofd.Multiselect = true;

            if(ofd.ShowDialog() == DialogResult.OK)
            {
                int tempsize = files.Count;
                files.AddRange(ofd.FileNames);
                for(int x =tempsize; x < files.Count; x++)
                {
                    songBox.Items.Add(files[x]);
                }
                StreamWriter sw = new StreamWriter(folderLocation+@"\PlayLists\AllSongs.txt", true);
                for (int x = tempsize; x < files.Count; x++)
                {
                    sw.WriteLine(files[x]);
                    this.Refresh();
                }
                sw.Close();
            }
        }
        //refreshes the current playlist boxlist with the given list of strings
        private void refreshPlaylist(List<string> l)
        {
            playlistBox.Items.Clear();
            for (int x = 0; x < l.Count; x++)
            {
                playlistBox.Items.Add(l[x]);
            }
        }
        //populates the list of songs in the current playlist from the playlist file
        private void populateSongList()
        {
            StreamReader sr = new StreamReader(currentList);
            while (!sr.EndOfStream)
            {
                string tempSong = sr.ReadLine();
                songsList.Add(tempSong);
                playlistBox.Items.Add(tempSong);
            }
            sr.Close();
        }
        //creates a new empty playlist
        private void listButton_Click(object sender, EventArgs e)
        {
            string newPlaylist = Interaction.InputBox("Enter New Playlist Name", "Adding Playlist", "");
            currentList = folderLocation+ @"\PlayLists\" + newPlaylist + ".txt";
            StreamWriter stream = new StreamWriter(currentList, true);
            this.Refresh();
            stream.Close();
            playlists.Add(currentList);
            refreshPlaylist(playlists);
            StreamWriter streamWriter = new StreamWriter(folderLocation + @"\PlayLists\AllPlaylists.txt", true);
            streamWriter.WriteLine(currentList);
            this.Refresh();
            streamWriter.Close();
        }
        //adds a song to the current playlist
        private void addList_Click(object sender, EventArgs e)
        {
            if(inPlaylist)
            {
                System.IO.File.AppendAllText(currentList, player.URL + Environment.NewLine);
                songsList.Add(player.URL);
                refreshPlaylist(songsList);
            }
        }
        //removes the current song from the playlist
        private void removeList_Click(object sender, EventArgs e)
        {
            if(playlistBox.SelectedItems.Count > 0)
            {
                songsList.Remove(playlistBox.SelectedItem.ToString());
                playlistBox.SelectedItems.Remove(playlistBox.SelectedItem);
                System.IO.File.Delete(currentList);
                StreamWriter sw = new StreamWriter(currentList);
                foreach (var item in songsList)
                {
                    sw.WriteLine(item);
                    this.Refresh();
                }
                sw.Close();
                refreshPlaylist(songsList);
                player.Ctlcontrols.stop();
            }

        }
        //deletes the playlist
        private void deleteList_Click(object sender, EventArgs e)
        {
            System.IO.File.Delete(currentList);
            inPlaylist = false;
            playlists.Remove(currentList);
            currentList = null;
            refreshPlaylist(playlists);
            player.Ctlcontrols.stop();
            StreamWriter sw = new StreamWriter(folderLocation + @"\PlayLists\AllPlaylists.txt");
            foreach (var item in playlists)
            {
                sw.WriteLine(item);
                this.Refresh();
            }
            sw.Close();

        }
        //selects a playlist
        private void playlistBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!inPlaylist)
            {
                if(playlistBox.SelectedItem != null)
                {
                    currentList = playlists[playlistBox.SelectedIndex];
                    selectedList.Text = currentList;
                    populateSongList();
                    refreshPlaylist(songsList);
                    inPlaylist = true;
                }
                
            }
            else
            {
                
                if (playlistBox.SelectedItem != null)
                {
                    player.URL = songsList[playlistBox.SelectedIndex];
                    player.Ctlcontrols.play();

                    try
                    {
                        var file = TagLib.File.Create(songsList[playlistBox.SelectedIndex]);
                        var bin = (byte[])(file.Tag.Pictures[0].Data.Data);
                        songArt.Image = Image.FromStream(new MemoryStream(bin));
                    }
                    catch
                    {

                    }
                }
            }
        }
        //return to the list of playlists
        private void resetButton_Click(object sender, EventArgs e)
        {
            songsList.Clear();
            inPlaylist = false;
            refreshPlaylist(playlists);
            currentList = null;
            selectedList.Text = "Playlists";
        }
        //loads the song list upon opening the program
        private void window_Load(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader(folderLocation + @"\PlayLists\AllSongs.txt");
            while (!sr.EndOfStream)
            {
                string tempSong = sr.ReadLine();
                songBox.Items.Add(tempSong);
                files.Add(tempSong);
            }
            sr.Close();
            StreamReader reader = new StreamReader(folderLocation + @"\PlayLists\AllPlaylists.txt");
            while (!reader.EndOfStream)
            {
                string templist = reader.ReadLine();
                playlistBox.Items.Add(templist);
                playlists.Add(templist);
            }
            reader.Close();
            volume.Value = 50;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(player.playState==WMPLib.WMPPlayState.wmppsPlaying)
            {
                songProgress.Maximum = (int)player.Ctlcontrols.currentItem.duration;
                songProgress.Value = (int)player.Ctlcontrols.currentPosition;
            }
        }
    }
}
