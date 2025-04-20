using Incense_Timer_WPF.Classes;
using Microsoft.Win32;
using Microsoft.Xaml.Behaviors.Media;
using System.Diagnostics;
using System.Media;
using System.Reflection;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Threading;

namespace Incense_Timer_WPF
{
    public partial class MainWindow : Window
    {
        //settings
        public static bool topMost;
        public static bool clockLayout;
        public static bool settingsMenu;
        public static bool soundEffects;
        public static RegistryKey registryKeyLocation = Registry.CurrentUser.CreateSubKey(@"SOFTWARE\Incense Timer WPF");
        public static Key StartKey;
        public static Key StopKey;
        public static Key ResetKey;
        //-----

        SoundPlayer newGhostCanHunt = new SoundPlayer();
        public static SoundPlayer positiveSound = new SoundPlayer();
        SoundPlayer negativeSound = new SoundPlayer();
        SoundPlayer startSound = new SoundPlayer();

        public MainWindow()
        {
            InitializeComponent();

            //loading sounds
            newGhostCanHunt.Stream = Properties.Resources.new_ghost_can_hunt;
            positiveSound.Stream = Properties.Resources.positive;
            negativeSound.Stream = Properties.Resources.negative;
            startSound.Stream = Properties.Resources.start;

            newGhostCanHunt.Load();
            positiveSound.Load();
            negativeSound.Load();
            startSound.Load();
            //-----

            //setup checks timer
            checksTimer.Tick += checksTimer_Tick;
            checksTimer.Interval = new TimeSpan(0, 0, 0, 0, 25);
            checksTimer.Start();
            //-----

            //setup stopwatch timer
            dt.Tick += dt_Tick;
            dt.Interval = new TimeSpan(0, 0, 0, 0, 1);
            //-----

            loadRegistryKeys();
            SetupHotkeys();
        }

        void loadRegistryKeys()
        {
            var topmostVal = registryKeyLocation.GetValue("Topmost");
            Topmost = topMost = topmostVal != null && topmostVal.ToString() == "true";
            if (topmostVal == null)
                registryKeyLocation.SetValue("Topmost", "false");

            var layoutVal = registryKeyLocation.GetValue("ClockLayout");
            clockLayout = layoutVal != null && layoutVal.ToString() == "true";
            if (layoutVal == null)
                registryKeyLocation.SetValue("ClockLayout", "false");

            var soundsVal = registryKeyLocation.GetValue("Sounds");
            soundEffects = soundsVal == null || soundsVal.ToString() == "true";
            if (soundsVal == null)
                registryKeyLocation.SetValue("Sounds", "true");

            string startVal = registryKeyLocation.GetValue("StartKey") as string ?? "F6";
            registryKeyLocation.SetValue("StartKey", startVal);
            StartKey = (Key)Enum.Parse(typeof(Key), startVal, true);

            string stopVal = registryKeyLocation.GetValue("StopKey") as string ?? "F7";
            registryKeyLocation.SetValue("StopKey", stopVal);
            StopKey = (Key)Enum.Parse(typeof(Key), stopVal, true);

            string resetVal = registryKeyLocation.GetValue("ResetKey") as string ?? "F8";
            registryKeyLocation.SetValue("ResetKey", resetVal);
            ResetKey = (Key)Enum.Parse(typeof(Key), resetVal, true);
        }

        public void SetupHotkeys()
        {
            HotkeysManager.ShutdownSystemHook();
            HotkeysManager.SetupSystemHook();

            HotkeysManager.AddHotkey(ModifierKeys.None, StartKey, () =>
            {
                if (!clockLayout)
                    startstopButton.Content = "Stop (" + StopKey + ")";
                else
                    smudgedatLabel.Text = "Smudged at: " + DateTime.Now.ToString("mm") + "m " + DateTime.Now.ToString("ss") + "s";

                if ((!sw.IsRunning || clockLayout) && soundEffects)
                    startSound.Play();
                sw.Start();
                dt.Start();
            });

            HotkeysManager.AddHotkey(ModifierKeys.None, StopKey, () =>
            {
                if (!clockLayout)
                    sw.Stop();
                startstopButton.Content = "Start (" + StartKey + ")";
            });

            HotkeysManager.AddHotkey(ModifierKeys.None, ResetKey, () =>
            {
                sw.Reset();
                if (!clockLayout)
                {
                    startstopButton.Content = "Start (" + StartKey + ")";
                    timeLabel.Text = "00:00.00";
                }
                else
                    smudgedatLabel.Text = "Smudged at: 00m 00s";
            });
        }

        public void resetTimeLabel()
        {
            timeLabel.Text = "00:00.00";
        }

        public void resetSmudgedAtLabel()
        {
            smudgedatLabel.Text = "Smudged at: 00m 00s";
        }

        public static DispatcherTimer checksTimer = new DispatcherTimer();

        public void checksTimer_Tick(object sender, EventArgs e)
        {
            if (clockLayout && !smudgedatLabel.IsVisible)
                smudgedatLabel.Visibility = Visibility.Visible;
            else if (!clockLayout)
                smudgedatLabel.Visibility = Visibility.Collapsed;

            if (clockLayout)
            {
                startstopButton.Content = "Smudged (" + StartKey + ")";
                timeLabel.Text = DateTime.Now.ToString("mm") + "m  " + DateTime.Now.ToString("ss") + "s";
            }
            else
            {
                if (!startstopButton.Content.ToString().StartsWith("Stop"))
                    startstopButton.Content = "Start (" + StartKey + ")";
            }

            resetButton.Content = "Reset (" + ResetKey + ")";

            Topmost = topMost;

            TimeSpan ts = sw.Elapsed;
            if (ts.Minutes > 0)
            {
                if (demonLabel.Foreground != Brushes.LimeGreen && soundEffects)
                    newGhostCanHunt.Play();
                demonLabel.Foreground = Brushes.LimeGreen;
            }
            else
                demonLabel.Foreground = Brushes.Red;

            if (ts.Minutes > 2)
            {
                if (spiritLabel.Foreground != Brushes.LimeGreen && soundEffects)
                    newGhostCanHunt.Play();
                spiritLabel.Foreground = Brushes.LimeGreen;
            }
            else
                spiritLabel.Foreground = Brushes.Red;

            if ((ts.Minutes > 0 && ts.Seconds > 29) || ts.Minutes > 1)
            {
                if (regularLabel.Foreground != Brushes.LimeGreen && soundEffects)
                    newGhostCanHunt.Play();
                regularLabel.Foreground = Brushes.LimeGreen;
            }
            else
                regularLabel.Foreground = Brushes.Red;
        }

        DispatcherTimer dt = new DispatcherTimer();
        public static Stopwatch sw = new Stopwatch();
        string currentTime = string.Empty;
        void dt_Tick(object sender, EventArgs e)
        {
            if (sw.IsRunning)
            {
                TimeSpan ts = sw.Elapsed;
                currentTime = string.Format("{0:00}:{1:00}.{2:00}", ts.Minutes, ts.Seconds, ts.Milliseconds / 10);
                if (!clockLayout)
                    timeLabel.Text = currentTime;
            }
        }

        private void movePanel_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
                DragMove();
        }

        private async void exitButton_Click(object sender, RoutedEventArgs e)
        {
            Animations.FadeOut(main_grid);
            await Task.Delay(250);
            Application.Current.Shutdown();
        }

        private async void minimiseButton_Click(object sender, RoutedEventArgs e)
        {
            await Task.Delay(250);
            WindowState = WindowState.Minimized;
        }

        private void questionButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Once ghosts have been smudged, there is a period before they can hunt again.\n\nDemon: 60 Seconds\nRegular Ghost: 90 Seconds\nSpirit: 180 Seconds", "Incense Help", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void startstopButton_Click(object sender, RoutedEventArgs e)
        {
            if (clockLayout)
            {
                smudgedatLabel.Text = "Smudged at: " + DateTime.Now.ToString("mm") + "m " + DateTime.Now.ToString("ss") + "s";
                sw.Start();
                dt.Start();
                if (soundEffects)
                    startSound.Play();
            }
            else
            {
                if (sw.IsRunning)
                {
                    sw.Stop();
                    startstopButton.Content = "Start (" + StartKey + ")";
                }
                else
                {
                    if (soundEffects)
                        startSound.Play();
                    sw.Start();
                    dt.Start();
                    startstopButton.Content = "Stop (" + StopKey + ")";
                }
            }
        }

        public void resetButton_Click(object sender, RoutedEventArgs e)
        {
            sw.Reset();
            if (clockLayout)
                smudgedatLabel.Text = "Smudged at: 00m 00s";
            else
            {
                startstopButton.Content = "Start (" + StartKey + ")";
                timeLabel.Text = "00:00.00";
            }
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            HotkeysManager.ShutdownSystemHook();
        }

        /*private void scratchamophobiaLabel_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Process.Start(new ProcessStartInfo("https://turbowarp.org/992603556?fps=60&clones=Infinity&offscreen&limitless&interpolate") { UseShellExecute = true });
        }*/

        private void settingsButton_Click(object sender, RoutedEventArgs e)
        {
        retry:
            if (!settingsMenu)
            {
                settingsMenu = true;
                var settings = new Settings();
                settings.Show();
            }
            else
            {
                if (soundEffects)
                    negativeSound.Play();
                var dialog = MessageBox.Show("Settings is already open. Retry?", "Error", MessageBoxButton.YesNo, MessageBoxImage.Error);
                if (dialog == MessageBoxResult.Yes)
                    goto retry;
                else
                    return;
            }
        }

        private void questionButton_MouseDown(object sender, MouseButtonEventArgs e)
        {

        }
    }
}
