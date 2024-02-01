using System;
namespace OldStyleApp
{
	public class ImagePost : Post
	{
		public string ImageURL { get; set; }

		//default constructor of base class is called implicitly
		public ImagePost(): base()
		{
            this.ImageURL = "";
        }

		public ImagePost(string title, string sendByUsername, string imageURL, bool isPublic): base(title, isPublic, sendByUsername)
		{
			//image post property
			this.ImageURL = imageURL;
		}

        public override string ToString()
        {
            return string.Format($"{this.ID} - {this.Title} - {this.ImageURL} - by {this.SendByUsername}");
        }
    }
}

