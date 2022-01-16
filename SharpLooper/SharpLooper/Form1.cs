using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
//using System.Windows.Media;
using System.IO;

namespace SharpLooper
{
    public partial class Form1 : Form
    {
        private Player mediaPlayer;
        //private bool isPlaying;
        //private bool isPaused;
        private TimeSpan startTime;
        private TimeSpan endTime;
        private TimeSpan currentTime;
        private double speed;
        Thread t;

        public Form1()
        {
            InitializeComponent();
            //mediaPlayer = new MediaPlayer();
            mediaPlayer = new Player(new ExampleCallback(ResultCallback));
            //isPlaying = false;
            //isPaused = false;
            PauseB.Enabled = false;
            //startTimeSet = false;
            //endTimeSet = false;
            speed = 1.0;
            timeLbl.Text = "Not playing";
            //fileBox.Text = @"C:\progr\Music\test.mp3";

            t = new Thread(new ThreadStart(mediaPlayer.ThreadProc));
            t.IsBackground = true;
            t.Start();

        }

        private void startB_Click(object sender, EventArgs e)
        {
            if (mediaPlayer.status == Status.Playing || mediaPlayer.status == Status.Pausing)
            {
                StopPlay();
                //isPlaying = false;
            }
            else
            {
                if (StartPlay())
                {
                    startB.Text = "Stop";
                    PauseB.Enabled = true;
                    PauseB.Text = "Pause";
                }
                //isPlaying = true;
            }
        }

        private void StopPlay()
        {
            mediaPlayer.status = Status.Stop;
            startB.Text = "Start";
            PauseB.Enabled = false;
        }

        private bool StartPlay()
        {
            bool success = false;
            if(fileBox.Text.Length>0)
            {
                if(File.Exists(fileBox.Text))
                {
                    mediaPlayer.filename = fileBox.Text;
                    mediaPlayer.status = Status.PlayNew;
                    //isPlaying = true;
                    startBox.Text = TimeSpan.Zero.ToString();
                    endBox.Text = mediaPlayer.duration.ToString();
                    success = true;
                }
                else
                {
                    timeLbl.Text = "File not found";
                }

            }
            else
            {
                timeLbl.Text = "No file selected";
            }
            return success;
        }
        public void ResultCallback(TimeSpan time)
        {
            currentTime = time;
            //timeLbl.Text = time.ToString();
            SetText(time.ToString());
            CheckStatus();
        }

        private void CheckStatus()
        {
            //SetText(mediaPlayer.status.ToString());
            if(mediaPlayer.status==Status.Ended)
            {
                SetStartText("Start");
                PauseB.Enabled = false;

            }
            else if(mediaPlayer.status==Status.Error)
            {
                SetStartText("Start");
                //PauseB.Enabled = false;
                SetText("Playback error");

            }
        }

        delegate void SetStartTextCallback(string text);

        private void SetStartText(string text)
        {
            // InvokeRequired required compares the thread ID of the
            // calling thread to the thread ID of the creating thread.
            // If these threads are different, it returns true.
            if (this.startB.InvokeRequired)
            {
                SetStartTextCallback d = new SetStartTextCallback(SetStartText);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                this.startB.Text = text;
                this.PauseB.Enabled = false;
            }
        }

        delegate void SetTextCallback(string text);

        private void SetText(string text)
        {
            // InvokeRequired required compares the thread ID of the
            // calling thread to the thread ID of the creating thread.
            // If these threads are different, it returns true.
            if (this.timeLbl.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetText);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                this.timeLbl.Text = text;
            }
        }

        private void PauseB_Click(object sender, EventArgs e)
        {
            if(mediaPlayer.status==Status.Pausing)
            {
                //mediaPlayer.Play();
                mediaPlayer.status = Status.Resume;
                PauseB.Text = "Pause";
                //isPaused = false;
            }
            else
            {
                mediaPlayer.status=Status.Pause;
                PauseB.Text = "Resume";
                //isPaused = true;
            }
        }

        private void setStartB_Click(object sender, EventArgs e)
        {
            startTime = currentTime;
            //startTimeSet = true;
            startBox.Text = startTime.ToString();
            mediaPlayer.startTime = startTime;
        }

        private void setEndB_Click(object sender, EventArgs e)
        {
            endTime = currentTime;
            //endTimeSet = true;
            endBox.Text = endTime.ToString();
            mediaPlayer.endTime = endTime;
        }

        private void fileBox_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                //e.Effect = DragDropEffects.All;
                string[] path = (string[])e.Data.GetData(DataFormats.FileDrop);
                fileBox.Text = path[0];
                StopPlay();

            }
            else e.Effect = DragDropEffects.None;

        }

        private void fileBox_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;

            }

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            mediaPlayer.status = Status.Stop;
            t.Abort();
        }

        private void startBox_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void endBox_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void fasterB_Click(object sender, EventArgs e)
        {
            speed += 0.05;
            SetSpeed(speed);

        }

        private void slowerB_Click(object sender, EventArgs e)
        {
            if(speed>=0.05) speed -= 0.05;
            SetSpeed(speed);
        }

        private void s05B_Click(object sender, EventArgs e)
        {
            SetSpeed(0.5);
        }

        private void SetSpeed(double speed)
        {
            this.speed = speed;
            mediaPlayer.speed = speed;
            speedLbl.Text = speed.ToString("F2");
        }

        private void s075B_Click(object sender, EventArgs e)
        {
            SetSpeed(0.75);
        }

        private void s1B_Click(object sender, EventArgs e)
        {
            SetSpeed(1.0);
        }

        private void s125B_Click(object sender, EventArgs e)
        {
            SetSpeed(1.25);
        }

        private void s15B_Click(object sender, EventArgs e)
        {
            SetSpeed(1.5);
        }

        private void fileOpenB_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.RestoreDirectory = true;
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                fileBox.Text = dialog.FileName;
                StopPlay();
            }
        }

        private void min30B_Click(object sender, EventArgs e)
        {
            mediaPlayer.jump = -30;
        }

        private void min10B_Click(object sender, EventArgs e)
        {
            mediaPlayer.jump = -10;
        }

        private void plus10B_Click(object sender, EventArgs e)
        {
            mediaPlayer.jump = 10;
        }

        private void plus30B_Click(object sender, EventArgs e)
        {
            mediaPlayer.jump = 30;
        }

        private void clearStartB_Click(object sender, EventArgs e)
        {
            startTime = TimeSpan.Zero;
            startBox.Text = startTime.ToString();
            mediaPlayer.startTime = startTime;
        }

        private void clearEndB_Click(object sender, EventArgs e)
        {
            endTime = TimeSpan.Zero;
            endBox.Text = endTime.ToString();
            mediaPlayer.endTime = TimeSpan.MaxValue;
        }

        private void fileBox_DragLeave(object sender, EventArgs e)
        {
            //fileBox.Clear();
        }

        private void startBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void startBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                startTime = TimeSpan.Parse(startBox.Text);
                mediaPlayer.startTime = startTime;
                e.SuppressKeyPress = true;
            }

        }

        private void endBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                endTime = TimeSpan.Parse(endBox.Text);
                mediaPlayer.endTime = endTime;
                e.SuppressKeyPress = true;
            }

        }
    }
}
