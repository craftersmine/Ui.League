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
    /// Represents a status indicator
    /// </summary>
    public partial class StatusPoint : Border
    {
        /// <summary>
        /// Identifies <see cref="StatusType"/> dependency property
        /// </summary>
        public static readonly DependencyProperty StatusTypeProperty = DependencyProperty.Register(nameof(StatusType), typeof(StatusType), typeof(StatusPoint));

        /// <summary>
        /// Gets or sets type of status to show
        /// </summary>
        public StatusType StatusType
        {
            get => (StatusType)GetValue(StatusTypeProperty);
            set
            {
                SetValue(StatusTypeProperty, value);
                switch ((StatusType) GetValue(StatusTypeProperty))
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

        /// <summary>
        /// Instantiates a new instance of <see cref="StatusPoint"/>
        /// </summary>
        public StatusPoint()
        {
            InitializeComponent();
        }
    }

    /// <summary>
    /// Contains possible variants for <see cref="StatusPoint"/>
    /// </summary>
    public enum StatusType
    {
        /// <summary>
        /// Online variant
        /// </summary>
        Online,
        /// <summary>
        /// In-game variant
        /// </summary>
        InGame,
        /// <summary>
        /// Busy variant
        /// </summary>
        Busy,
        /// <summary>
        /// Offline variant
        /// </summary>
        Offline
    }
}
