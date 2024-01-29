using System;
using System.Diagnostics;
namespace OldStyleApp
{
	public class Members
	{

		//member - private field
		private string memberName;
		private string jobTitle;
		private int salary;

		//member - public field
		public int age;

		//member - property - exposes jobTitle safely
		public string JobTitle
		{
			get { return jobTitle; }
			set { jobTitle = value; }
		}

		//public member methods can be called from other classes
		public void Introducing(bool isFriend)
		{
			if (isFriend) SharingPrivateInfo();
			else Console.WriteLine($"Hi, my name is {this.memberName} and my job title is {this.jobTitle}, I'm {this.age} years old");

		}

		private void SharingPrivateInfo()
		{
			Console.WriteLine($"My Salary is {this.salary}");
		}


		//member - constructor
		public Members()
		{
			age = 30;
			memberName = "Lucy";
			salary = 60000;
			jobTitle = "developer";
			Console.WriteLine("Object created");
		}

		//member - finalizer/destructor, this is only for classes
		//it can only have one finalizer
		// only use it when it does something (cleanup)
		~Members()
		{
			//cleanup statement
			Console.WriteLine("Deconstruction of Members object");
			Debug.Write("Destruction of Members object");

		}
    }
}

