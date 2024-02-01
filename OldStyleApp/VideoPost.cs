using System;
namespace OldStyleApp
{
	public class VideoPost: Post
	{
		public string VideoURL { get; set; }
		public int Length { get; set; }

		public VideoPost(){}

		public VideoPost(string title, string sendByUserName, string videoURL, int length, bool isPublic) : base(title, isPublic, sendByUserName)
		{
			this.VideoURL = videoURL;
			this.Length = length;
		}

        public override string ToString()
        {
            return string.Format($"{this.ID} - {this.Title} - {this.VideoURL} - {this.Length} - by {this.SendByUsername}");
        }

    }
}

