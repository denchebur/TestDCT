using Microsoft.Windows.Themes;
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
using TestDCT.ViewModels;

namespace TestDCT
{
    /// <summary>
    /// Interaction logic for MainPage.xaml
    /// </summary>
    public partial class MainPage : Page
    {
        AssetViewModel assetViewModel;
        public MainPage()
        {
            
            InitializeComponent();
            
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            int n = Convert.ToInt32(slider.Value);
            assetViewModel = new AssetViewModel();
            assetsListTopN.ItemsSource = assetViewModel.GetTopNAssets(n).Result;
        }
    }
}
