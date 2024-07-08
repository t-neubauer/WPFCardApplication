using System.Collections.ObjectModel;
using WPFCardApplication.Data;
using WPFCardApplication.Model;

namespace WPFCardApplication.ViewModel
{
    public class CardViewModel
    {
        private readonly ICardDataProvider _cardDataProvider;

        public CardViewModel(ICardDataProvider cardDataProvider)
        {
            _cardDataProvider = cardDataProvider;
        }

        public CardViewModel()
        {
            _cardDataProvider = new CardDataProvider();
        }

        public ObservableCollection<Card> Cards { get; } = new();

        public async Task LoadAsync()
        {
            if(Cards.Any()) 
                return;
            
            var cards = await _cardDataProvider.GetAllAsync().ConfigureAwait(true);
            
            if (cards is not null)
            {
				foreach (var card in cards)
				{
					Cards.Add(card);
				}
			}
        }
    }
}
