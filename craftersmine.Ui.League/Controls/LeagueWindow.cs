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
    }
}
