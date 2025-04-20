using System;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media.Animation;
using Incense_Timer_WPF.Classes;

namespace Incense_Timer_WPF
{
    public partial class Settings : Window
    {
        private TextBox activeKeybindTextBox;

        public Settings()
        {
            InitializeComponent();

            clockLayoutCheckbox.IsChecked = MainWindow.registryKeyLocation.GetValue("ClockLayout")?.ToString() == "true";
            topmostCheckbox.IsChecked = MainWindow.registryKeyLocation.GetValue("Topmost")?.ToString() == "true";
            soundsCheckbox.IsChecked = MainWindow.registryKeyLocation.GetValue("Sounds")?.ToString() == "true";

            StartKeybind_textBox.Text = MainWindow.StartKey.ToString();
            StopKeybind_textBox.Text = MainWindow.StopKey.ToString();
            ResetKeybind_textBox.Text = MainWindow.ResetKey.ToString();

            StartKeybind_textBox.PreviewMouseDown += KeybindTextBox_MouseDown;
            StopKeybind_textBox.PreviewMouseDown += KeybindTextBox_MouseDown;
            ResetKeybind_textBox.PreviewMouseDown += KeybindTextBox_MouseDown;

            StartKeybind_textBox.PreviewKeyUp += KeybindTextBox_KeyUp;
            StopKeybind_textBox.PreviewKeyUp += KeybindTextBox_KeyUp;
            ResetKeybind_textBox.PreviewKeyUp += KeybindTextBox_KeyUp;

            Animations.Fade(main_grid);
        }

        private void KeybindTextBox_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton != MouseButton.Left) return;
            activeKeybindTextBox = (TextBox)sender;
            activeKeybindTextBox.Text = "...";
            activeKeybindTextBox.Focus();
            e.Handled = true;
        }

        private void KeybindTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (activeKeybindTextBox == null) return;

            var key = e.Key == Key.System ? e.SystemKey : e.Key;
            var keyName = key.ToString();
            activeKeybindTextBox.Text = keyName;

            var reg = MainWindow.registryKeyLocation;
            if (activeKeybindTextBox == StartKeybind_textBox)
            {
                reg.SetValue("StartKey", keyName);
                MainWindow.StartKey = key;
            }
            else if (activeKeybindTextBox == StopKeybind_textBox)
            {
                reg.SetValue("StopKey", keyName);
                MainWindow.StopKey = key;
            }
            else if (activeKeybindTextBox == ResetKeybind_textBox)
            {
                reg.SetValue("ResetKey", keyName);
                MainWindow.ResetKey = key;
            }

            activeKeybindTextBox = null;
            e.Handled = true;

            if (Application.Current.MainWindow is MainWindow main)
                main.SetupHotkeys();
        }

        private async void exitButton_Click(object sender, RoutedEventArgs e)
        {
            Animations.FadeOut(main_grid);
            await Task.Delay(250);
            MainWindow.settingsMenu = false;
            Close();
        }

        private void Border_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
                DragMove();
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

        private void resetKeyBindButton_Click(object sender, RoutedEventArgs e)
        {
            var reg = MainWindow.registryKeyLocation;
            reg.SetValue("StartKey", "f6");
            MainWindow.StartKey = Key.F6;
            StartKeybind_textBox.Text = "F6";

            reg.SetValue("StopKey", "f7");
            MainWindow.StopKey = Key.F7;
            StopKeybind_textBox.Text = "F7";

            reg.SetValue("ResetKey", "f8");
            MainWindow.ResetKey = Key.F8;
            ResetKeybind_textBox.Text = "F8";

            if (Application.Current.MainWindow is MainWindow main)
                main.SetupHotkeys();
        }
    }
}