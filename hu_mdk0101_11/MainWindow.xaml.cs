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
using System.IO;
using System.Linq;

namespace hu_mdk0101_11
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string filepath = "films.txt";
        public MainWindow()
        {
            InitializeComponent();
        }

        private void film_click(object sender, RoutedEventArgs e)
        {
            if (File.Exists(filepath))
                {
                string fileContent = File.ReadAllText(filepath);
                Filmstextbox.Text = fileContent;
                }
            else
            {
                MessageBox.Show("файл не найден.");
            }
        }

        private void showfilms_click(object sender, RoutedEventArgs e)
        {
            if(File.Exists(filepath))
            {
                string[] lines= File.ReadAllLines(filepath);
                var filmsbydirector =lines.Where(Line => Line.Contains("Гофман")).ToList();
                directfilmtextbox.Text = string.Join(Environment.NewLine, filmsbydirector);
            }
            else
            {
                MessageBox.Show("файл не найден.");
            }
        }
    }
}