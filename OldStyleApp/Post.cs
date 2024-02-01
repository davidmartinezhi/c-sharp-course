using System;
namespace OldStyleApp
{
	public class Post
	{
		private static int currentID;

		//properties
		protected int ID { get; set; }
		protected string Title { get; set; }
		protected string SendByUsername { get; set; }
		protected bool IsPublic { get; set; }


		//default constructor
        public Post()
		{
			ID = GetNextID(); //generate ID
            Title = "My first post";
			IsPublic = true;
			SendByUsername = "David";
		}

		public Post(string title, bool isPublic, string sendByUsername)
		{
			this.ID = GetNextID(); //generate ID
			this.Title = title;
			this.IsPublic = isPublic;
			this.SendByUsername = sendByUsername;
		}

		protected int GetNextID()
		{
			return ++currentID; //will add 1 to currentID then return it
		}

		public void Update(string title, bool isPublic)
		{
			//we are skipping edge cases for the demo
			this.Title = title;
			this.IsPublic = isPublic;
		}

        public override string ToString()
        {
			return string.Format($"{this.ID} - {this.Title} - by {this.SendByUsername}");
        }

    }
}

