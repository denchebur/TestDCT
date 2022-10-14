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
using TestDCT.Command;
using TestDCT.Extentions;
using TestDCT.ViewModels;

namespace TestDCT
{
    /// <summary>
    /// Interaction logic for DetailnfoPage.xaml
    /// </summary>
    public partial class DetailInfoPage : Page
    {

        private AssetViewModel vm;

        private double xmin = 0;

        private double xmax = 6.5;
        private double ymin = -1.1;
        private double ymax = 1.1;
        private Polyline polyline;


        public DetailInfoPage()
        {
            InitializeComponent();
            vm = new AssetViewModel();
        }

        private void searchButton_Click(object sender, RoutedEventArgs e)
        {
            vm = new AssetViewModel();
            vm.SearchCommand.Execute(textBox.Text);            
            assetsList.ItemsSource = vm.Assets;
            
        }      

        private void buttonLink_Click(object sender, RoutedEventArgs e)
        {
            
            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
            {
                FileName = vm.SelectedExchange.exchangeUrl,
                UseShellExecute = true
            });

        }

        private void assetsList_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {           
            vm.SelectedAsset = (Models.Asset)assetsList.SelectedItem;
            textBoxPrice.Text = vm.SelectedAsset.priceUsd;
            textBoxVolume.Text = vm.SelectedAsset.volumeUsd24Hr;
            textBoxChange.Text = vm.SelectedAsset.changePercent24Hr;
            vm.SelectAssetCommand.Execute(vm.SelectedAsset.id);
            List<string> list = new List<string>();
            vm.Exchanges.ToList().ForEach(v => list.Add(v.name ));
            comboBox.ItemsSource = list;

            AddChart();
        }

       

        private void comboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            vm.SelectMarketCommand.Execute(vm.SelectedAsset.id);
            vm.SelectedExchange = vm.Exchanges.ToList().ElementAt(comboBox.SelectedIndex);                                        
        }





       


        private void AddChart()
        {
            // Draw sine chart:
            polyline = new Polyline { Stroke = Brushes.Red };

            for (int i = 0; i < 70; i++)
            {
                var x = i / 5.0;
                var y = Math.Sin(x);
                polyline.Points.Add(CorrespondingPoint(new Point(x, y)));
            }
            drawCanvas.Children.Add(polyline);
            // Draw cosine chart:
            polyline = new Polyline
            {
                Stroke = Brushes.Black,
                //StrokeDashArray = new DoubleCollection(new double[] { 4, 3 })
            };
            for (int i = 0; i < 70; i++)
            {
                var x = i / 5.0;
                var y = Math.Cos(x);
                polyline.Points.Add(CorrespondingPoint(new Point(x, y)));
            }
            drawCanvas.Children.Add(polyline);
        }
        private Point CorrespondingPoint(Point pt)
        {
            var result = new Point
            {
                X = (pt.X - xmin) * drawCanvas.Width / (xmax - xmin),
                Y = drawCanvas.Height - (pt.Y - ymin) * drawCanvas.Height
                    / (ymax - ymin)
            };
            return result;
        }

    }
}
