using System;

namespace testproject
{
	public class TruckVeichle : CarClass
	{
		public int maxPullWeight {
			get;
			set;
		}

		public TruckVeichle (int weight, int height, int maxspeed,int maxPullWeight) : base (weight, height, maxspeed)
		{
			this.maxPullWeight = maxPullWeight;
		}
	}
}

