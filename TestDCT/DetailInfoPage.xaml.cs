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

        AssetViewModel vm;
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
                FileName = vm.SelectedAsset.explorer,
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
            vm.Markets.ToList().ForEach(v => list.Add(v.exchangeId + " " + v.priceUsd));
            comboBox.ItemsSource = list;
        }

        private void comboBox_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            
        }

        private void comboBox_DataContextChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            
        }

        private void comboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            vm.SelectMarketCommand.Execute(vm.SelectedAsset.id);
            var list = vm.Exchanges.Select(x => vm.Markets.Where(x1 => x1.exchangeId == x.exchangeId));
        }
    }
}
