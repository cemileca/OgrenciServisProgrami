using System.Windows;

namespace OgrenciServis.WPForm
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnYeniOgrenciKayit_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Test");
        }
    }
}
