using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using System.Windows.Interop;
using craftersmine.Ui.League.Controls;

namespace craftersmine.Ui.League
{
    partial class LeagueUi : ResourceDictionary
    {
        private void TitleBarMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ClickCount > 1)
            {
                MaxButtonClick(sender, e);
            }
            else if (e.LeftButton == MouseButtonState.Pressed)
            {
                sender.ForWindowFromTemplate(w => w.DragMove());
            }
        }

        private void CloseButtonClick(object sender, RoutedEventArgs e)
        {
            sender.ForWindowFromTemplate(w => SystemCommands.CloseWindow(w));
        }

        private void MinButtonClick(object sender, RoutedEventArgs e)
        {
            sender.ForWindowFromTemplate(w => SystemCommands.MinimizeWindow(w));
        }

        private void MaxButtonClick(object sender, RoutedEventArgs e)
        {
            sender.ForWindowFromTemplate(w =>
            {
                if (w.WindowState == WindowState.Maximized) SystemCommands.RestoreWindow(w);
                else SystemCommands.MaximizeWindow(w);
            });
        }

        private void HelpButtonClick(object sender, RoutedEventArgs e)
        {
            sender.ForWindowFromTemplate(w => ((LeagueWindow)w).RaiseHelpRequested(sender, e));
        }

        private void SettingsButtonClick(object sender, RoutedEventArgs e)
        {
            sender.ForWindowFromTemplate(w => ((LeagueWindow)w).RaiseSettingsRequested(sender, e));
        }
    }
}
