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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace craftersmine.Ui.League.Controls
{
    /// <summary>
    /// Логика взаимодействия для StatusPoint.xaml
    /// </summary>
    public partial class StatusPoint : Border
    {
        private StatusType statusType;

        public StatusType StatusType
        {
            get => statusType;
            set
            {
                statusType = value;
                switch (statusType)
                {
                    case StatusType.Online:
                        BorderBrush = (SolidColorBrush)TryFindResource("LeagueStatusBorderOnline");
                        Background = (SolidColorBrush)TryFindResource("LeagueStatusBackgroundOnline");
                        break;
                    case StatusType.InGame:
                        BorderBrush = (SolidColorBrush)TryFindResource("LeagueStatusBorderInGame");
                        Background = (SolidColorBrush)TryFindResource("LeagueStatusBackgroundInGame");
                        break;
                    case StatusType.Busy:
                        BorderBrush = (SolidColorBrush)TryFindResource("LeagueStatusBorderBusy");
                        Background = (SolidColorBrush)TryFindResource("LeagueStatusBackgroundBusy");
                        break;
                    case StatusType.Offline:
                        BorderBrush = (SolidColorBrush)TryFindResource("LeagueStatusBorderOffline");
                        Background = (SolidColorBrush)TryFindResource("LeagueStatusBackgroundOffline");
                        break;
                }
            }
        }

        public StatusPoint()
        {
            InitializeComponent();
        }
    }

    public enum StatusType
    {
        Online,
        InGame,
        Busy,
        Offline
    }
}
