using System;
using System.Diagnostics;
using System.Threading;

namespace OldStyleApp
{

    //public delegate void VideoPostCallback(string message);

    public class VideoPost: Post
	{

        //member fields
        private bool IsPlaying = false;
        private int CurrDuration = 0;
        Timer timer;

        //properties
		protected string VideoURL { get; set; }
		protected int Length { get; set; }
		//private Stopwatch _StopWatch;
        //private VideoPostCallback _callback; // Callback variable


        public VideoPost() : base()
        {
            this.VideoURL = "";
            //this._StopWatch = new Stopwatch();
        }

		public VideoPost(string title, string sendByUserName, string videoURL, int length, bool isPublic) : base(title, isPublic, sendByUserName)
		{
			this.VideoURL = videoURL;
			this.Length = length;
            //this._StopWatch = new Stopwatch();
        }

        public override string ToString()
        {
            return string.Format($"{this.ID} - {this.Title} - {this.VideoURL} - {this.Length} - by {this.SendByUsername}");
        }

        //public void RegisterCallback(VideoPostCallback callback)
        //{
        //    _callback = callback;
        //}

        // Solo falta lo del timer y callback
        //timer
        public void Play()
		{
            if (IsPlaying)
            {
                Console.WriteLine("Video already playing");
                return;
            }


            IsPlaying = true;
            Console.WriteLine("Playing!");
            timer = new Timer(TimerCallback, null, 0, 1000);

        }

        private void TimerCallback(Object o)
        {
            if(CurrDuration < Length)
            {
                CurrDuration++;
                Console.WriteLine($"Video at {CurrDuration}s");
                GC.Collect();
            }
            else
            {
                Stop();
            }
        }

        public void Stop()
        {
            if (!IsPlaying)
            {
                Console.WriteLine("Video already stopped");
                return;
            }

            IsPlaying = false;
            Console.WriteLine($"Stopped at {CurrDuration}s");
            CurrDuration = 0;
            timer.Dispose();
        }

    }
}

