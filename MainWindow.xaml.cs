using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace sliderExample
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

        private void sliderPick_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            lblOutput.Content = sliderPick.Value;
            if (sliderPick.Value == 0)
            {
                lblOutput.Content = "yo I was 0";
                BitmapImage bi = new BitmapImage(new Uri("http://cdn-img.health.com/sites/default/files/styles/medium_16_9/public/styles/main/public/how-take-care-cat-400x400.jpg"));
                imgPicture.Source = bi;
            }
            else if (sliderPick.Value == 1) {
                lblOutput.Content = "1 is the lonelinest number";
                BitmapImage bi = new BitmapImage(new Uri("https://upload.wikimedia.org/wikipedia/commons/thumb/3/3a/Cat03.jpg/1200px-Cat03.jpg"));
                imgPicture.Source = bi;
            }
        }
    }
}
