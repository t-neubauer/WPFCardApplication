using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFCardApplication
{
	internal class DataObject
	{
        public string CardName { get; set; }
        public string Rarity { get; set; }

		public DataObject(string cardName, string cardType)
		{
			CardName = cardName;
			Rarity = cardType;
        }
    }
}
