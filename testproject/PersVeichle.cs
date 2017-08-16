using System;

namespace testproject
{
	public class PersVeichle : CarClass
	{
		public int seatCount {
			get;
			set;
		} = 2;

		public PersVeichle (int weight, int height, int maxspeed, int seatCount) : base (weight, height, maxspeed)
		{
			this.seatCount = seatCount;
		}
		  
		public void speedUp ()
		{
			if (this.canMove() && speed <= maxspeed)
				this.speed++;
		}

		public void slowDown()
		{
			if (this.canMove())
				this.speed--;
		}
	}
}
