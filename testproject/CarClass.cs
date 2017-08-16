using System;

namespace testproject
{
	public abstract class CarClass
	{
		public int weight {
			get;
			set;
		} = 0;

		public int height {
			get;
			set;
		} = 0;

		public int maxspeed {
			get;
			set;
		} = 0;

		public bool handbrake {
			get;
			set;
		} = false;

		public int speed {
			get;
			set;
		} = 0;

		public CarClass (int weight, int height, int maxspeed)
		{
			this.weight = weight;
			this.height = height;
			this.maxspeed = maxspeed;
		}

		public bool canMove()
		{
			return this.handbrake ? true : false;
		}
	}
}