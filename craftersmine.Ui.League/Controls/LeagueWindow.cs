using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace craftersmine.Ui.League.Controls
{
    public class LeagueWindow : Window
    {
        public static readonly DependencyProperty HeaderTemplateProperty =
            DependencyProperty.Register(
                nameof(HeaderTemplate),
                typeof(DataTemplate),
                typeof(ContentControl),
                new FrameworkPropertyMetadata((DataTemplate) null));
        
        public static readonly DependencyProperty HeaderProperty =
            DependencyProperty.Register(
                nameof(Header), typeof(object), 
                typeof(ContentControl), new FrameworkPropertyMetadata((object)null));
        
        public static readonly DependencyProperty IsSettingsButtonVisibleProperty =
            DependencyProperty.Register(
                nameof(IsSettingsButtonVisible), typeof(bool), 
                typeof(ContentControl), new FrameworkPropertyMetadata((object)false));

        public static readonly DependencyProperty IsHelpButtonVisibleProperty =
            DependencyProperty.Register(
                nameof(IsHelpButtonVisible), typeof(bool), 
                typeof(ContentControl), new FrameworkPropertyMetadata((object)false));

        public event RoutedEventHandler HelpRequested;
        public event RoutedEventHandler SettingsRequested;

        [Bindable(true)]
        public object Header
        {
            get { return GetValue(ContentProperty); }
            set { SetValue(ContentProperty, value); }
        }

        [Bindable(true)]
        public DataTemplate HeaderTemplate
        {
            get { return (DataTemplate) GetValue(ContentTemplateProperty); }
            set { SetValue(ContentTemplateProperty, value); }
        }

        [Bindable(true)]
        public bool IsSettingsButtonVisible
        {
            get { return (bool) GetValue(IsSettingsButtonVisibleProperty); }
            set { SetValue(IsSettingsButtonVisibleProperty, value); }
        }

        [Bindable(true)]
        public bool IsHelpButtonVisible
        {
            get { return (bool) GetValue(IsHelpButtonVisibleProperty); }
            set { SetValue(IsHelpButtonVisibleProperty, value); }
        }

        internal void RaiseHelpRequested(object sender, RoutedEventArgs e)
        {
            HelpRequested?.Invoke(this, e);
        }

        internal void RaiseSettingsRequested(object sender, RoutedEventArgs e)
        {
            SettingsRequested?.Invoke(this, e);
        }
    }
}
