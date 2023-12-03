using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using craftersmine.Ui.League.Controls;

namespace craftersmine.Ui.League
{
    /// <summary>
    /// Логика взаимодействия для TestWindow.xaml
    /// </summary>
    public partial class TestWindow : LeagueWindow
    {
        public TestWindow()
        {
            InitializeComponent();
        }

        private void OnSettingsRequested(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Settings button clicked!", "Event raised!", MessageBoxButton.OK, MessageBoxImage.Information);
        }
        
        private void OnHelpRequested(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Help button clicked!", "Event raised!", MessageBoxButton.OK, MessageBoxImage.Question);
        }
    }
}
