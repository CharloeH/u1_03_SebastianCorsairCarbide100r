/* Sebastian Horton
 * Thursday Febuary 15th, 2018
 * u1_03_SebastianCorsairCarbideSeries100R
 * Users can create a Computer and calculate the total price(with tax)
 * */
/* LINKS: 
 * CASES:
 * https://www.newegg.ca/Product/Product.aspx?Item=N82E16811146190
 * https://www.newegg.ca/Product/Product.aspx?Item=N82E16811139058
 * https://www.newegg.ca/Product/Product.aspx?Item=N82E16811139024
 * GPUs
 * https://www.newegg.ca/Product/Product.aspx?Item=N82E16814487265
 * https://www.newegg.ca/Product/Product.aspx?Item=9SIAFMA6U35563
 * https://www.newegg.ca/Product/Product.aspx?Item=9SIA5SC5BE9895
 * CPUs/APUs
 *  https://www.newegg.ca/Product/Product.aspx?Item=N82E16819113430
 *  https://www.newegg.ca/Product/Product.aspx?Item=N82E16819113429
 *  https://www.newegg.ca/Product/Product.aspx?Item=N82E16819113435
 *  MOTHERBOARDS
 *  https://www.newegg.ca/Product/Product.aspx?Item=N82E16813132988
 *  https://www.newegg.ca/Product/Product.aspx?Item=N82E16813144117
 *  https://www.newegg.ca/Product/Product.aspx?Item=N82E16813144019
 *  PSUs
 *  https://www.newegg.ca/Product/Product.aspx?Item=9SIA9H557G2611
 *  https://www.newegg.ca/Product/Product.aspx?Item=N82E16817139200
 *   https://www.newegg.ca/Product/Product.aspx?Item=N82E16817438084
 *  RAM
 *  https://www.newegg.ca/Product/Product.aspx?Item=N82E16820232476
 *  https://www.newegg.ca/Product/Product.aspx?Item=N82E16820233852
 *  https://www.newegg.ca/Product/Product.aspx?Item=N82E16820233992
 *  STORAGE
 *  https://www.newegg.ca/Product/Product.aspx?Item=N82E16822178993
 *  https://www.newegg.ca/Product/Product.aspx?item=N82E16820147674
 *  https://www.newegg.ca/Product/Product.aspx?Item=N82E16820242399
 * */
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
using System.Diagnostics;

namespace sliderExample
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        double dblCPUPrice = 449.99;
        double dblCasePrice = 94.99;
        double dblGPUPrice = 674.99;
        double dblMotherBoardPrice = 149.99;
        double dblPSUPrice = 107.00;
        double dblRAMPrice = 255.99;
        double dblStoragePrice = 73.99;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void sliderPick_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e) ///Case
        {
            if (sliderPick1.Value == 0)
            {
                lblOutput.Content = "NZXT s340 Glossy Black"; ///$94.99 
                BitmapImage bi = new BitmapImage(new Uri("https://images10.newegg.com/ProductImageCompressAll1280/11-146-190-03.jpg"));
                imgPicture.Source = bi;
                dblCasePrice = 94.99;
            }
            else if (sliderPick1.Value == 1)
            {
                lblOutput.Content = "Corsiar Carbide Series 100R Silent Edition"; ///$74.99
                BitmapImage bi = new BitmapImage(new Uri("https://images10.newegg.com/NeweggImage/ProductImage/11-139-058-01.jpg"));
                imgPicture.Source = bi;
                dblCasePrice = 74.99;
            }


            else if (sliderPick1.Value == 2)
            {
                lblOutput.Content = "Corsair Obsidian Series 750D"; ///179.99
                BitmapImage bi = new BitmapImage(new Uri("https://images10.newegg.com/NeweggImage/ProductImage/11-139-024-02.jpg"));
                imgPicture.Source = bi;
                dblCasePrice = 179.99;
            }
        }

        private void sliderPick2_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e) ///GPU
        {

            if (sliderPick2.Value == 0)
            {
                lblOutput2.Content = "EVGA GeForce GTX 1070 SC"; ///$674.99  
                BitmapImage bi = new BitmapImage(new Uri("https://images10.newegg.com/ProductImage/14-487-265-S99.jpg"));
                imgPicture2.Source = bi;
                dblGPUPrice = 674.99;
            }
            else if (sliderPick2.Value == 1)
            {
                lblOutput2.Content = ""; ///379.99 
                BitmapImage bi = new BitmapImage(new Uri("https://images10.newegg.com/ProductImage/14-487-260-S99.jpg"));
                imgPicture2.Source = bi;
                dblGPUPrice = 379.99;
            }
            else if (sliderPick2.Value == 2)
            {
                lblOutput2.Content = "EVGA GeForce GTX 1050 Ti"; ///$404.82 
                BitmapImage bi = new BitmapImage(new Uri("https://images10.newegg.com/NeweggImage/ProductImage/14-487-290-01.jpg"));
                imgPicture2.Source = bi;
                dblGPUPrice = 404.82;
            }
        }

        private void sliderPick3_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e) ///APU/CPU
        {
            if (sliderPick3.Value == 0)
            {
                lblOutput3.Content = "AMD RYZEN 7 1800X 8-Core"; ///$449.99
                BitmapImage bi = new BitmapImage(new Uri("https://images10.newegg.com/NeweggImage/ProductImage/19-113-430-S01.jpg"));
                imgPicture3.Source = bi;
                dblCPUPrice = 449.99;
                
            }
            else if (sliderPick3.Value == 1)
            {
                lblOutput3.Content = "AMD RYZEN 7 1700X 8-Core"; ///$454.99 
                BitmapImage bi = new BitmapImage(new Uri("https://images10.newegg.com/NeweggImage/ProductImage/19-113-429-S01.jpg"));
                imgPicture3.Source = bi;
                dblCPUPrice = 454.99; 
            }
            else if (sliderPick3.Value == 2)
            {
                lblOutput3.Content = "AMD RYZEN 5 1600 6-Core"; ///$239.99 
                BitmapImage bi = new BitmapImage(new Uri("https://images10.newegg.com/NeweggImage/ProductImage/19-113-435-Z01.jpg"));
                imgPicture3.Source = bi;
                dblCPUPrice = 239.99;
            }
        }

        private void imgPicture_Scroll(object sender, System.Windows.Controls.Primitives.ScrollEventArgs e)
        {

        }

        private void imgPicture_Scroll_1(object sender, System.Windows.Controls.Primitives.ScrollEventArgs e)
        {

        }

        private void sliderPick4_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e) ///Motherbaord
        {
            if (sliderPick4.Value == 0)
            {
                lblOutput4.Content = "ASUS ROG STRIX B350-F GAMING AM4 Motherboard"; ///$149.99
                BitmapImage bi = new BitmapImage(new Uri("https://images10.newegg.com/NeweggImage/ProductImage/13-132-988-V01.jpg"));
                imgPicture4.Source = bi;
                dblMotherBoardPrice = 149.99;
            }
            else if (sliderPick4.Value == 1)
            {
                lblOutput4.Content = "MSI B350 TOMAHAWK PLUS AM4 AMD Motherboard"; ///$134.99 
                BitmapImage bi = new BitmapImage(new Uri("https://images10.newegg.com/NeweggImage/ProductImage/13-144-117-V03.jpg"));
                imgPicture4.Source = bi;
                dblMotherBoardPrice = 134.99;
            }
            else if (sliderPick4.Value == 2)
            {
                lblOutput4.Content = "MSI B350M Gaming PRO AM4 AMD B350 Motherboard"; ///$101.99 
                BitmapImage bi = new BitmapImage(new Uri("https://images10.newegg.com/NeweggImage/ProductImage/13-144-019-V01.jpg"));
                imgPicture4.Source = bi;
                dblMotherBoardPrice = 101.99;
            }
        }

        private void sliderPick5_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (sliderPick5.Value == 0)
            { 
                lblOutput5.Content = "Thermaltake Toughpower Grand RGB 650W"; ///$116.99 
                BitmapImage bi = new BitmapImage(new Uri("https://images10.newegg.com/NeweggImage/ProductImage/17-153-310-Z01.jpg"));
            imgPicture5.Source = bi;
                dblPSUPrice = 116.99;
        }
        else if (sliderPick5.Value == 1)
            { lblOutput5.Content = "CORSAIR CX Series CX650 650W ATX12V"; ///$89.99 
                BitmapImage bi = new BitmapImage(new Uri("https://images10.newegg.com/NeweggImage/ProductImage/17-139-200-V08.jpg"));
                imgPicture5.Source = bi;
                dblPSUPrice = 89.99;
            }
            else if (sliderPick5.Value == 2)
            { lblOutput.Content = "EVGA 650 BQ 110-BQ-0650-V1 80+ BRONZE 650W "; ///$107.00
                BitmapImage bi = new BitmapImage(new Uri("https://images10.newegg.com/ProductImage/17-438-084-17.jpg"));
                imgPicture5.Source = bi;
                dblPSUPrice = 107.00;
            }


        }
        private void sliderPick6_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (sliderPick6.Value == 0)
            { lblOutput6.Content = "G.SKILL TridentZ RGB Series 16GB";
            BitmapImage bi = new BitmapImage(new Uri("https://images10.newegg.com/NeweggImage/ProductImage/20-232-476-S01.jpg"));
                imgPicture6.Source = bi;
                dblRAMPrice = 255.99;
            }else if (sliderPick6.Value == 1)
            { lblOutput6.Content = "CORSAIR Vengeance LPX 16GB ";
                BitmapImage bi = new BitmapImage(new Uri("https://images10.newegg.com/NeweggImage/ProductImage/20-233-852-01.jpg"));
                imgPicture6.Source = bi;
                dblRAMPrice = 249.99;
            }else if (sliderPick6.Value ==2)
            { lblOutput6.Content = "CORSAIR Dominator Platinum 32GB";
                BitmapImage bi = new BitmapImage(new Uri("https://images10.newegg.com/NeweggImage/ProductImage/20-233-885-01.jpg"));
                imgPicture6.Source = bi;
                dblRAMPrice = 518.00;
            }

        }
        private void sliderPick7_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (sliderPick7.Value == 0)
            {
                lblOutput7.Content = "Seagate BarraCuda 2TB HDD";
                BitmapImage bi = new BitmapImage(new Uri("https://images10.newegg.com/ProductImage/22-178-993-V01.jpg"));
                imgPicture6.Source = bi;
                dblStoragePrice = 73.99;
            }
            else if (sliderPick7.Value == 1)
            {
                lblOutput7.Content = "SAMSUNG 860 EVO Series 2.5 500GB SSD";
                BitmapImage bi = new BitmapImage(new Uri("https://images10.newegg.com/NeweggImage/ProductImage/20-147-674-V01.jpg"));
                imgPicture7.Source = bi;
                dblStoragePrice = 209.99;
            }else if (sliderPick7.Value == 2)
            { lblOutput7.Content = "Kingston A400 2.5 120GB SSD";
            BitmapImage bi = new BitmapImage(new Uri("https://images10.newegg.com/NeweggImage/ProductImage/20-242-399-V06.jpg"));
                imgPicture7.Source = bi;
                dblStoragePrice = 52.99;
            }

        }
        private void btnPrice_Click(object sender, RoutedEventArgs e)
        {
            double total = (dblCPUPrice * 1.13) + (dblCasePrice * 1.13) + (dblGPUPrice * 1.13) + (dblMotherBoardPrice * 1.13) + (dblPSUPrice * 1.13) + (dblRAMPrice * 1.13) +(dblStoragePrice * 1.13) ;
            MessageBox.Show("Your total price is: \n" + total.ToString("$0.00"));
        }

        private void btnPurchase_Click(object sender, RoutedEventArgs e)
        {
          
        }

        private void hyperLinkCase_RequestNavigate(object sender, RequestNavigateEventArgs e)
        {
            Process.Start(new ProcessStartInfo(e.Uri.AbsoluteUri));
            e.Handled = true;
        }

        private void HyperLinkGPU_RequestNavigate(object sender, RequestNavigateEventArgs e)
        {
            Process.Start(new ProcessStartInfo(e.Uri.AbsoluteUri));
            e.Handled = true;
        }

        private void HyperLinkCPU_RequestNavigate(object sender, RequestNavigateEventArgs e)
        {
            Process.Start(new ProcessStartInfo(e.Uri.AbsoluteUri));
            e.Handled = true;
        }

        private void HyperLinkMoBo_RequestNavigate(object sender, RequestNavigateEventArgs e)
        {
            Process.Start(new ProcessStartInfo(e.Uri.AbsoluteUri));
            e.Handled = true;
        }

        private void HyperLinkPSU_RequestNavigate(object sender, RequestNavigateEventArgs e)
        {
            Process.Start(new ProcessStartInfo(e.Uri.AbsoluteUri));
            e.Handled = true;
        }

       

        
    }
}
