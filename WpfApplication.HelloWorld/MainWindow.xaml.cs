using System.Windows;

namespace WpfApplication.HelloWorld
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        public MainWindow()
        {
            InitializeComponent();
            btnClickMe.Click += (s, e) => MessageBox.Show("Hello World!");
            btnClickMe.Click += (s, e) => MessageBox.Show("I will also get popped up!");
        }
    }
}
