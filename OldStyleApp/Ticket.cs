using System;
namespace OldStyleApp
{
	public class Ticket : IEquatable<Ticket>
	{
		public int DurationHours { get; set; }

		public Ticket(int durationHours)
		{
			this.DurationHours = durationHours;
		}

		//this method should be in here due to the interface
		public bool Equals(Ticket other)
		{
            if (other == null)
            {
                return false;
            }

            return this.DurationHours == other.DurationHours;
		}
	}
}

