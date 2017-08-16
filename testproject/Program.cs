using System;
namespace testproject
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			PersVeichle tesla = new PersVeichle (1000, 1, 240, 5);

			while (true) {
				switch (Console.ReadLine ()) {
				case "B":
					tesla.handbrake ^= true;
					if (!tesla.handbrake)
						tesla.speed = 0;
					printThis(tesla.handbrake);
					drawMenu ();
					break;
				case "S":
					printThis (tesla.speed);
					drawMenu ();
					break;
				case "+":
					tesla.speedUp ();
					printThis("speed is now : " + tesla.speed);
					drawMenu ();
					break;
				case "-":
					tesla.slowDown ();
					printThis("speed is now : " + tesla.speed);
					drawMenu ();
					break;
				default:
					break;
				}
			}
		}
		public static void drawMenu()
		{
			for (int i = 0; i < 10; i++) {
				Console.WriteLine ();
			}
			printThis ("--SPEED UP[+]--SPEED DOWN[-]--HANDBRAKE[B]--CURRENT SPEED[S]--");
		}
		public static void printThis(string print)
		{
			Console.Clear ();
			Console.WriteLine (print);
		}
		public static void printThis(int print)
		{
			Console.Clear ();
			Console.WriteLine (print);
		}
		public static void printThis(float print)
		{
			Console.Clear ();
			Console.WriteLine (print);
		}public static void printThis(double print)
		{
			Console.Clear ();
			Console.WriteLine (print);
		}
		public static void printThis(char print)
		{
			Console.Clear ();
			Console.WriteLine (print);
		}
		public static void printThis(bool print)
		{
			Console.Clear ();
			Console.WriteLine (print);
		}
		public static void printThis(byte print)
		{
			Console.Clear ();
			Console.WriteLine (print);
		}
	}
}