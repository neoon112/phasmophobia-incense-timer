using System.Windows;
using System.Windows.Input;
using Incense_Timer_WPF.Classes;

namespace Incense_Timer_WPF
{
    public partial class Settings : Window
    {
        public Settings()
        {
            InitializeComponent();

            scratchamophobiaCheckbox.IsChecked = true; // making sure scratchamophobia checkbox is checked

            //load checkboxes keys
            if (MainWindow.registryKeyLocation.GetValue("ClockLayout").ToString() == "true")
            {
                clockLayoutCheckbox.IsChecked = true;
            }
            else
            {
                clockLayoutCheckbox.IsChecked = false;
            }

            if (MainWindow.registryKeyLocation.GetValue("Topmost").ToString() == "true")
            {
                topmostCheckbox.IsChecked = true;
            }
            else
            {
                topmostCheckbox.IsChecked = false;
            }

            if (MainWindow.registryKeyLocation.GetValue("Sounds").ToString() == "true")
            {
                soundsCheckbox.IsChecked = true;
            }
            else
            {
                soundsCheckbox.IsChecked = false;
            }
            //-----

            Animations.Fade(main_grid);
        }

        private async void exitButton_Click(object sender, RoutedEventArgs e)
        {
            Animations.FadeOut(main_grid);
            await Task.Delay(250);
            MainWindow.settingsMenu = false;
            this.Close();
        }

        private void scratchamophobiaCheckbox_Unchecked(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("No. Getting. Rid. Of. Scratchamophobia.", "Warning", MessageBoxButton.OK, MessageBoxImage.Warning);
            scratchamophobiaCheckbox.IsChecked = true;
        }

        private void Border_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
            {
                this.DragMove();
            }
        }

        private void topmostCheckbox_Checked(object sender, RoutedEventArgs e)
        {
            MainWindow.registryKeyLocation.SetValue("Topmost", "true");
            Application.Current.MainWindow.Topmost = true;
            MainWindow.topMost = true;
            Topmost = true;
        }

        private void topmostCheckbox_Unchecked(object sender, RoutedEventArgs e)
        {
            MainWindow.registryKeyLocation.SetValue("Topmost", "false");
            Application.Current.MainWindow.Topmost = false;
            MainWindow.topMost = false;
            Topmost = false;
        }

        private void clockLayoutCheckbox_Checked(object sender, RoutedEventArgs e)
        {
            MainWindow.clockLayout = true;
            MainWindow.registryKeyLocation.SetValue("ClockLayout", "true");
        }

        private void clockLayoutCheckbox_Unchecked(object sender, RoutedEventArgs e)
        {
            MainWindow.clockLayout = false;
            MainWindow.registryKeyLocation.SetValue("ClockLayout", "false");
        }

        private void soundsCheckbox_Checked(object sender, RoutedEventArgs e)
        {
            MainWindow.soundEffects = true;
            MainWindow.registryKeyLocation.SetValue("Sounds", "true");
        }

        private void soundsCheckbox_Unchecked(object sender, RoutedEventArgs e)
        {
            MainWindow.soundEffects = false;
            MainWindow.registryKeyLocation.SetValue("Sounds", "false");
        }
    }
}
