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

namespace TestDCT.ViewModels
{
    public class AssetViewModel : INotifyPropertyChanged
    {

        private const string path = "https://api.coincap.io/v2/assets";
        private IEnumerable<Asset> assets = new List<Asset>();
        private Asset selectedAsset;
        public Asset SelectedAsset
        {
            get { return selectedAsset; }
            set 
            {
                selectedAsset = value;
                OnPropertyChanged("SelectedAsset");
            }
        }

        public AssetViewModel()
        {
            LoadAssets();
        }

        public IEnumerable<Asset> Assets { 
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

        public async Task<IEnumerable<Asset>> GetTop10Assets()
        {
            HttpClient client = new HttpClient { BaseAddress = new Uri(path) };
            var json = await client.GetAsync("?limit=10");
            JsonSerializer serializer = JsonSerializer.CreateDefault();
            var fromJson = await json.Content.ReadAsStringAsync();
           // assets = JsonConvert.DeserializeObject<List<Asset>>(fromJson);
            using (StringReader reader = new StringReader(fromJson))
            { 
                using (JsonTextReader jsonReader = new JsonTextReader(reader))
                {                   
                    assets = serializer.Deserialize(jsonReader).ToModelList();
                }
            }              
            return assets;
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
