using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using System.Diagnostics;
using System.ComponentModel;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace FTU_Tracker
{
    /// <summary>
    /// An empty window that can be used on its own or navigated to within a Frame.
    /// </summary>
  
    public sealed partial class MainWindow : Window
    {
        public MainViewModel Viewmodel { get; set; } = new();

        public MainWindow()
        {
            InitializeComponent();
        }

        //



        //
    }
}
