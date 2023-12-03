using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
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
    public partial class StatusPoint : Border, INotifyPropertyChanged
    {
        /// <summary>
        /// Identifies <see cref="StatusType"/> dependency property
        /// </summary>
        public static readonly DependencyProperty StatusTypeProperty = DependencyProperty.Register(nameof(StatusType), typeof(StatusType), typeof(StatusPoint), new PropertyMetadata(Controls.StatusType.Offline, OnStatusChanged));

        private static void OnStatusChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            StatusPoint point = d as StatusPoint;
            point.UpdateStatusPoint(point.StatusType);
        }

        /// <summary>
        /// Gets or sets type of status to show
        /// </summary>
        public StatusType StatusType
        {
            get => (StatusType)GetValue(StatusTypeProperty);
            set => SetValue(StatusTypeProperty, value);
        }

        /// <summary>
        /// Instantiates a new instance of <see cref="StatusPoint"/>
        /// </summary>
        public StatusPoint()
        {
            InitializeComponent();
        }

        private void UpdateStatusPoint(StatusType status)
        {
            switch (status)
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
                default:
                    BorderBrush = (SolidColorBrush)TryFindResource("LeagueStatusBorderOffline");
                    Background = (SolidColorBrush)TryFindResource("LeagueStatusBackgroundOffline");
                    break;
            }
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string? propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetField<T>(ref T field, T value, [CallerMemberName] string? propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value)) return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
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
