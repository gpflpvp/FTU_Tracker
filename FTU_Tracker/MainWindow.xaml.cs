using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using System.Diagnostics;
using System.ComponentModel;


namespace FTU_Tracker
{
 
  
    public sealed partial class MainWindow : Window
    {
        public MainViewModel Viewmodel { get; set; } = new();

        public MainWindow()
        {
            InitializeComponent();
            RootGrid.RequestedTheme = ElementTheme.Dark;
        }

       private void btn_theme_switcher(object sender, RoutedEventArgs e)
        {
            if(this.Content is FrameworkElement root)
            {
                if (root.RequestedTheme == ElementTheme.Dark)
                {
                    root.RequestedTheme = ElementTheme.Light;
                    Debug.WriteLine("Switched to Light Theme");
                }
                else
                {
                    root.RequestedTheme = ElementTheme.Dark;
                    Debug.WriteLine("Switched to Dark Theme");
                }
            }
        }


    }
}
