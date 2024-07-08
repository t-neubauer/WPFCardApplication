using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPFCardApplication.Model;

namespace WPFCardApplication
{
    internal class DataSet : ObservableCollection<Card>
	{																		
		string[] names = { "Blue Eyes White Dragon", "Dark Magician", "Time Wizard", "Red Eyes B. Dragon" };
		string[] rarity = { "common", "rare", "super rare", "ultra rare", "ultimate rare", "secret rare" };

        public DataSet() : base() 
        {
			Random random = new Random();
			Add(new Card(names[random.Next(names.Length)],
					rarity[random.Next(rarity.Length)]));
			Add(new Card(names[random.Next(names.Length)],
					rarity[random.Next(rarity.Length)]));
			Add(new Card(names[random.Next(names.Length)],
					rarity[random.Next(rarity.Length)]));
			Add(new Card(names[random.Next(names.Length)],
					rarity[random.Next(rarity.Length)]));
			Add(new Card(names[random.Next(names.Length)],
					rarity[random.Next(rarity.Length)]));
        }
	}

	public enum Rarity{ Common, Rare, SuperRare, UltraRare, UltimateRare, SecretRare }

	public static class EnumHelper
	{
		public static Array GetValues(Type enumType) {
			return Enum.GetValues(enumType);	
		}
	}
}
