using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFCardApplication.Model
{
	// MODEL

	public class Card
	{
        public string CardName { get; set; }
        public string Rarity { get; set; }

		public Card(string cardName, string cardType)
		{
			CardName = cardName;
			Rarity = cardType;
        }
    }
}
