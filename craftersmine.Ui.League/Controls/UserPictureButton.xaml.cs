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
    /// Represents a button-like user profile picture container
    /// </summary>
    public partial class UserPictureButton : Button, INotifyPropertyChanged
    {
        /// <summary>
        /// Identifies <see cref="ImageSource"/> dependency property
        /// </summary>
        public static readonly DependencyProperty ImageSourceProperty = DependencyProperty.Register(nameof(ImageSource), typeof(ImageSource), typeof(UserPictureButton));

        /// <summary>
        /// Gets or sets user profile picture source
        /// </summary>
        public ImageSource? ImageSource
        {
            get => (ImageSource)GetValue(ImageSourceProperty); set
            {
                SetValue(ImageSourceProperty, value);
                OnPropertyChanged(nameof(ImageSource));
            }
        }

        /// <summary>
        /// Instantiates a new instance of <see cref="UserPictureButton"/>
        /// </summary>
        public UserPictureButton()
        {
            InitializeComponent();
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
}
