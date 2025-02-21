using CommunityToolkit.Mvvm.ComponentModel;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace GasTrans
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new MainVM();
        }
    }

    public partial class MainVM : ObservableObject
    {
        [ObservableProperty]
        bool isStarted;
        partial void OnIsStartedChanged(bool value)
        {
            Opacity = value ? 1 : 0;
        }
        [ObservableProperty]
        double opacity;
    }
}