using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Configuration;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Net.WebSockets;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using TestDCT.Models;
using Newtonsoft.Json.Serialization;
using Newtonsoft.Json;
using System.Windows;
using Newtonsoft.Json.Linq;
using System.IO;
using TestDCT.Extentions;
using TestDCT.Command;

namespace TestDCT.ViewModels
{
    public class AssetViewModel : INotifyPropertyChanged
    {
       
        private IEnumerable<Asset> assets;      
        private Asset selectedAsset;
        private IEnumerable<Market> markets;
        private IEnumerable<Exchange> exchanges;
        private Exchange selectedExchange;


        private RelayCommand selectMarketCommand;
        private RelayCommand selectAssetCommand;
        private RelayCommand searchCommand;


        public AssetViewModel()
        {
            LoadAssets();
        }

        public RelayCommand SelectMarketCommand
        {
            get
            {
                return selectMarketCommand ??
                    (selectMarketCommand = new RelayCommand(o => SelectedExchange = GetExchangeById((string)o).Result));
            }
            
        }

        public RelayCommand SearchCommand
        {
            get
            {                                
                return searchCommand ??
                    (searchCommand = new RelayCommand(o => Assets = SearchAssets((string)o).Result));
            }
        }

        public RelayCommand SelectAssetCommand
        {
            get
            {
                return selectAssetCommand ??
                    (selectAssetCommand = new RelayCommand(o => { 
                        Markets = GetMarketsByAsset((string)o).Result;
                        Exchanges = GetExchanges().Result;
                    }));
            }
        }

        public Asset SelectedAsset
        {
            get { return selectedAsset; }
            set 
            {
                selectedAsset = value;
                OnPropertyChanged("SelectedAsset");
            }
        }

        public Exchange SelectedExchange
        {
            get 
            { 
                return selectedExchange; 
            }
            set
            {
                selectedExchange = value;
                OnPropertyChanged("SelectedExchange");
            }
        }

        public IEnumerable<Market> Markets
        {
            get
            {
                return markets;
            }
            set
            {
                markets = value;
                OnPropertyChanged("Markets");
            }
        }

        public IEnumerable<Exchange> Exchanges
        {
            get
            {
                return exchanges;
            }
            set
            {
                exchanges = value;
                OnPropertyChanged("Exchanges");
            }
        }

        public IEnumerable<Asset> Assets 
        { 
            get
            {
                return assets;
            }
            set
            {
                assets = value;
                OnPropertyChanged("Assets");
            }
        }



        public async Task LoadAssets()
        {
            Assets = await GetTop10Assets();
        }

        public async Task<Exchange> GetExchangeById(string id)
        {
            selectedExchange = await ("exchanges/" + id).SendRequestSipleData<Exchange>();
            return selectedExchange;
        }

        public async Task<IEnumerable<Market>> GetMarketsByAsset(string id)
        {
            markets = await ("markets?baseId=" + id).SendRequest<Market>();
            return markets;
        }

        public async Task<IEnumerable<Exchange>> GetExchanges()
        {
            exchanges = await ("exchanges").SendRequest<Exchange>();
            return exchanges;
        }

        public async Task<IEnumerable<Asset>> GetTop10Assets()
        {
            assets = await "assets?limit=10".SendRequest<Asset>();       
            return assets;
        }


        public async Task<IEnumerable<Asset>> SearchAssets(string key)
        {

            assets = await ("assets?search=" + key).SendRequest<Asset>();
            return assets;
        }

        public async Task GetHistory(string id)
        {

        }

        public event PropertyChangedEventHandler? PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName]string propertyName = "")
        {
            if(this.PropertyChanged != null)
            {
                var e = new PropertyChangedEventArgs(propertyName);
                this.PropertyChanged(this, e);
            }
        }
    }
}
