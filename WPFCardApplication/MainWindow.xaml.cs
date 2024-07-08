using System.Windows;
using System.Windows.Controls;
using WPFCardApplication.Data;
using WPFCardApplication.ViewModel;

namespace WPFCardApplication
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
	/// 

	// View
    public partial class MainWindow : Window
	{
		private CardViewModel _viewModel;

		public MainWindow()
		{
			InitializeComponent();
			_viewModel = new CardViewModel(new CardDataProvider());
			DataContext = _viewModel;
			Loaded += MainWindow_Loaded;
		}

		private async void MainWindow_Loaded(object sender, RoutedEventArgs e)
		{
			await _viewModel.LoadAsync().ConfigureAwait(true);
		}
	}
}