using FirmenABC_Crawler.Gui.ViewModel;
using System.Windows;

namespace FirmenABC_Crawler.Gui.View
{
    public partial class MainWindow : Window
    {
        private MainWindowViewModel _mainWindowViewModel = new MainWindowViewModel();
        public MainWindow()
        {
            InitializeComponent();
            DataContext = _mainWindowViewModel;
        }

        private void CheckBox_Click(object sender, RoutedEventArgs e)
        {
            _mainWindowViewModel.FilterChanged(sender);
        }
    }
}
