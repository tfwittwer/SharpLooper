using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using System.Threading;
using System.Windows.Threading;

namespace SharpLooper
{
    public enum Status
    {
        Idle,
        PlayNew,
        Playing,
        Pause,
        Pausing,
        Resume,
        Stop,
        Ended,
        Error
    }

    public sealed class Player
    {
        private ExampleCallback callback;
        private MediaPlayer mediaPlayer=null;

        public Status status;
        public string filename;
        public TimeSpan duration;

        public double speed;
        private double oldSpeed;

        public int jump;

        public TimeSpan startTime;
        public TimeSpan endTime;

        // The constructor obtains the state information and the
        // callback delegate.
        public Player(ExampleCallback callbackDelegate)
        {
            callback = callbackDelegate;
            status = 0;
            jump = 0;
        }

        private void FileEnd(object sender, EventArgs e)
        {
            status = Status.Ended;
        }

        private void Error(object sender, EventArgs e)
        {
            status = Status.Error;
        }

        // The thread procedure performs the task, such as
        // formatting and printing a document, and then invokes
        // the callback delegate with the number of lines printed.
        public void ThreadProc()
        {
            mediaPlayer = new MediaPlayer();
            mediaPlayer.MediaEnded += FileEnd;
            mediaPlayer.MediaFailed += Error;
            while (true)
            {
                if (status == Status.PlayNew) Start();
                else if (status == Status.Pause) Pause();
                else if (status == Status.Resume) Play();
                else if (status == Status.Stop) Stop();
                if(status==Status.Playing||status==Status.Ended)
                {
                    if (callback != null)
                        callback(mediaPlayer.Position);
                    CheckPosition();
                    CheckSpeed();
                }
                Thread.Sleep(10);
            }
        }

        private void CheckPosition()
        {
            if(jump!=0)
            {
                mediaPlayer.Position += TimeSpan.FromSeconds(Convert.ToDouble(jump));
                jump = 0;
            }
            if (mediaPlayer.Position > endTime) mediaPlayer.Position = startTime;
        }
        private void CheckSpeed()
        {
            if (speed!=oldSpeed)
            {
                mediaPlayer.SpeedRatio = speed;
                oldSpeed = speed;
            }
        }

        private void Start()
        {
            startTime = TimeSpan.Zero;
            mediaPlayer.Open(new Uri(filename));
            endTime = TimeSpan.MaxValue;
            mediaPlayer.Play();
            status = Status.Playing;
            if(mediaPlayer.NaturalDuration.HasTimeSpan)
                duration = mediaPlayer.NaturalDuration.TimeSpan;
        }

        private void Play()
        {
            mediaPlayer.Play();
            status = Status.Playing;
        }

        private void Pause()
        {
            mediaPlayer.Pause();
            status = Status.Pausing;
        }

        private void Stop()
        {
            mediaPlayer.Stop();
            status = Status.Idle;
        }

    }

    public delegate void ExampleCallback(TimeSpan time);
}
