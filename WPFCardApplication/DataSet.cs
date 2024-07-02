using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFCardApplication
{
    internal class DataSet : ObservableCollection<DataObject>
	{																		
		string[] names = { "Blue Eyes White Dragon", "Dark Magician", "Time Wizard", "Red Eyes B. Dragon" };
		string[] types = { "monster", "trap", "spell", "ritual", "synchro", "xyz", "fusion" };
		string[] edition = { "lob", "mrd", "srl", "mrl", "pgd", "psv", "mfc" };
		string[] rarity = { "common", "rare", "super rare", "ultra rare", "ultimate rare", "secret rare" };

        public DataSet() : base() 
        {
			Random random = new Random();
			Add(new DataObject(names[random.Next(names.Length)],
					rarity[random.Next(rarity.Length)]));
			Add(new DataObject(names[random.Next(names.Length)],
					rarity[random.Next(rarity.Length)]));
			Add(new DataObject(names[random.Next(names.Length)],
					rarity[random.Next(rarity.Length)]));
			Add(new DataObject(names[random.Next(names.Length)],
					rarity[random.Next(rarity.Length)]));
			Add(new DataObject(names[random.Next(names.Length)],
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
