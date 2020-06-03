using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
	public class JamesCat
	{
		private int happpiness { get; set; }
		public int movingspeed { get; set; }
		private int hungerlevel { get; set; }
		public string haircolor { get; set; }
		private string meowText { get; set; }

		public JamesCat()
		{
			happpiness = 0;
			movingspeed = 0;
			hungerlevel = 0;
			haircolor = "black";
		}

		public void feed()
		{
			hungerlevel++;
			happpiness++;
			movingspeed = 0;

			Console.WriteLine($"the cats hunger level is {hungerlevel}, the cats happiness is {happpiness} the cats movingspeed is {movingspeed}");
		}

		private string meow()
		{
			if (hungerlevel < 2)
			{
				meowText = "the cat meowed cause it was hungry";

			}
			else
			{
				meowText = "the cat meowed cause it wants to play";
			}
			return meowText;
		}



		public class WhatIsUpWithJamessCat
		{
			JamesCat myCat { get; set; }

			WhatIsUpWithJamessCat()
			{
				myCat = new JamesCat();
			}

			public void TellMeAboutTheCat()
			{
				myCat.feed();
			}


		}
	}
}
