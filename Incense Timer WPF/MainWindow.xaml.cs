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
            checksTimer.Tick += new EventHandler(checksTimer_Tick);
            checksTimer.Interval = new TimeSpan(0, 0, 0, 0, 25);
            checksTimer.Start();
            //-----

            //setup stopwatch timer
            dt.Tick += new EventHandler(dt_Tick);
            dt.Interval = new TimeSpan(0, 0, 0, 0, 1);
            //-----

            // setup keyhook 
            HotkeysManager.SetupSystemHook();

            HotkeysManager.AddHotkey(ModifierKeys.None, Key.F6, () =>
            {
                if (clockLayout == false)
                {
                    startstopButton.Content = "Stop (F7)";
                }
                else
                {
                    smudgedatLabel.Text = "Smudged at: " + DateTime.Now.ToString("mm") + "m " + DateTime.Now.ToString("ss") + "s";
                }
                if (sw.IsRunning == false && soundEffects == true || clockLayout == true && soundEffects == true)
                {
                    startSound.Play();
                }
                sw.Start();
                dt.Start();
            });

            HotkeysManager.AddHotkey(ModifierKeys.None, Key.F7, () =>
            {
                if (clockLayout == false)
                {
                    sw.Stop();
                    startstopButton.Content = "Start (F6)";
                }
            });

            HotkeysManager.AddHotkey(ModifierKeys.None, Key.F8, () =>
            {
                sw.Reset();
                if (clockLayout == false)
                {
                    startstopButton.Content = "Start (F6)";
                    timeLabel.Text = "00:00.00";
                }
                else
                {
                    smudgedatLabel.Text = "Smudged at: 00m 00s";
                }
            });
            //-----

            //check registry keys
            if (registryKeyLocation.GetValue("Topmost") == null)
            {
                registryKeyLocation.SetValue("Topmost", "false");
                Topmost = false;
                topMost = false;
            }
            else
            {
                if (registryKeyLocation.GetValue("Topmost").ToString() == "true")
                {
                    Topmost = true;
                    topMost = true;
                }
                else
                {
                    Topmost = false;
                    topMost = false;
                }
            }

            if (registryKeyLocation.GetValue("ClockLayout") == null)
            {
                registryKeyLocation.SetValue("ClockLayout", "false");
                clockLayout = false;
            }
            else
            {
                if (registryKeyLocation.GetValue("ClockLayout").ToString() == "true")
                {
                    clockLayout = true;
                }
                else
                {
                    clockLayout = false;
                }
            }

            if (registryKeyLocation.GetValue("Sounds") == null)
            {
                registryKeyLocation.SetValue("Sounds", "true");
                soundEffects = true;
            }
            else
            {
                if (registryKeyLocation.GetValue("Sounds").ToString() == "true")
                {
                    soundEffects = true;
                }
                else
                {
                    soundEffects = false;
                }
            }
            //-----
        }

        DispatcherTimer checksTimer = new DispatcherTimer();

        void checksTimer_Tick(object sender, EventArgs e)
        {
            if (clockLayout == true && smudgedatLabel.IsVisible == false)
            {
                smudgedatLabel.Visibility = Visibility.Visible;
            }
            else
            {
                if (clockLayout == false)
                {
                    smudgedatLabel.Visibility = Visibility.Collapsed;
                }
            }

            if (clockLayout == false && startstopButton.Content.ToString() == "Smudged (F6)")
            {
                sw.Reset();
                timeLabel.Text = "00:00.00";
                startstopButton.Content = "Start (F6)";
            }

            if (clockLayout == true)
            {
                startstopButton.Content = "Smudged (F6)";
            }

            if (clockLayout == true)
            {
                timeLabel.Text = DateTime.Now.ToString("mm") + "m  " + DateTime.Now.ToString("ss") + "s";
            }
            if (topMost == true && Topmost == false)
            {
                Topmost = true;
            }
            else if (topMost == false && Topmost == true)
            {
                Topmost = false;
            }

            TimeSpan ts = sw.Elapsed;
            if (ts.Minutes > 0)
            {
                if (demonLabel.Foreground != Brushes.LimeGreen && soundEffects == true)
                {
                    newGhostCanHunt.Play();
                }
                demonLabel.Foreground = Brushes.LimeGreen;
            }
            else
            {
                demonLabel.Foreground = Brushes.Red;
            }
            if (ts.Minutes > 2)
            {
                if (spiritLabel.Foreground != Brushes.LimeGreen && soundEffects == true)
                {
                    newGhostCanHunt.Play();
                }
                spiritLabel.Foreground = Brushes.LimeGreen;
            }
            else
            {
                spiritLabel.Foreground = Brushes.Red;
            }
            if (ts.Minutes > 0 && ts.Seconds > 29 || ts.Minutes > 1)
            {
                if (regularLabel.Foreground != Brushes.LimeGreen && soundEffects == true)
                {
                    newGhostCanHunt.Play();
                }
                regularLabel.Foreground = Brushes.LimeGreen;
            }
            else
            {
                regularLabel.Foreground = Brushes.Red;
            }
        }

        DispatcherTimer dt = new DispatcherTimer();
        public static Stopwatch sw = new Stopwatch();
        string currentTime = string.Empty;
        void dt_Tick(object sender, EventArgs e)
        {

            if (sw.IsRunning)
            {
                TimeSpan ts = sw.Elapsed;
                currentTime = String.Format("{0:00}:{1:00}.{2:00}", ts.Minutes, ts.Seconds, ts.Milliseconds / 10);
                if (clockLayout == false)
                {
                    timeLabel.Text = currentTime;
                }
            }
        }

        private void movePanel_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
            {
                this.DragMove();
            }
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
            if (clockLayout == true)
            {
                smudgedatLabel.Text = "Smudged at: " + DateTime.Now.ToString("mm") + "m " + DateTime.Now.ToString("ss") + "s";
                sw.Start();
                dt.Start();
                if (soundEffects == true)
                {
                    startSound.Play();
                }
            }
            else
            {
                if (sw.IsRunning == true)
                {
                    sw.Stop();
                    startstopButton.Content = "Start (F6)";
                }
                else
                {
                    if (soundEffects == true)
                    {
                        startSound.Play();
                    }
                    sw.Start();
                    dt.Start();
                    startstopButton.Content = "Stop (F7)";
                }
            }
        }

        private void resetButton_Click(object sender, RoutedEventArgs e)
        {
            sw.Reset();
            if (clockLayout == true)
            {
                smudgedatLabel.Text = "Smudged at: 00m 00s";
            }
            else
            {
                startstopButton.Content = "Start (F6)";
                timeLabel.Text = "00:00.00";
            }
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            HotkeysManager.ShutdownSystemHook();
        }

        private void scratchamophobiaLabel_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Process? process = Process.Start(new ProcessStartInfo("https://turbowarp.org/992603556?fps=60&clones=Infinity&offscreen&limitless&interpolate")
            {
                UseShellExecute = true,
            });
        }

        private void settingsButton_Click(object sender, RoutedEventArgs e)
        {
            retry:
            if (settingsMenu == false)
            {
                settingsMenu = true;
                Settings settings = new Settings();
                settings.Show();
            }
            else if (settingsMenu == true)
            {
                if (soundEffects == true)
                {
                    negativeSound.Play();
                }
                MessageBoxResult dialog = MessageBox.Show("Settings is already open. Retry?", "Error", MessageBoxButton.YesNo, MessageBoxImage.Error);
                if (dialog == MessageBoxResult.Yes)
                {
                    goto retry;
                }
                else
                {
                    return;
                }
            }
        }
    }
}