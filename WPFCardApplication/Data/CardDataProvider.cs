using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPFCardApplication.Model;

namespace WPFCardApplication.Data
{

    public interface ICardDataProvider
    {
        Task<IEnumerable<Card>?> GetAllAsync();
    }

	// DataProvider
	public class CardDataProvider : ICardDataProvider
	{
		string[] names = { "Blue Eyes White Dragon", "Dark Magician", "Time Wizard", "Red Eyes B. Dragon" };
		string[] rarity = { "common", "rare", "super rare", "ultra rare", "ultimate rare", "secret rare" };

		public async Task<IEnumerable<Card>?> GetAllAsync()
		{
			await Task.Delay(100); //Simulate Server Work

			Random random = new Random();

			return new List<Card>{
                new (names[random.Next(names.Length)], rarity[random.Next(rarity.Length)]),
				new (names[random.Next(names.Length)], rarity[random.Next(rarity.Length)]),
				new (names[random.Next(names.Length)], rarity[random.Next(rarity.Length)]),
				new (names[random.Next(names.Length)], rarity[random.Next(rarity.Length)]),
				new (names[random.Next(names.Length)], rarity[random.Next(rarity.Length)])
			};
		}
	}
}
