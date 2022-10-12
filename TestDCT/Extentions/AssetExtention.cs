using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using TestDCT.Models;

namespace TestDCT.Extentions
{
    public static class AssetExtention
    {
        public static IEnumerable<T> ToModelList<T>(this object list) where T : class
        {
            var temp = new DataListTemp<T>();
            temp = JsonConvert.DeserializeObject<DataListTemp<T>>(list.ToString());
            return temp.data;
        }

        public static T ToModel<T>(this object entity) where T : class
        {
            var temp = new DataTemp<T>();
            temp = JsonConvert.DeserializeObject<DataTemp<T>>(entity.ToString());
            return temp.data;
        }


        public static async Task<IEnumerable<T>> SendRequest<T>(this string endpoint) where T : class
        {
            const string path = "https://api.coincap.io/v2/";
            IEnumerable<T> entitiess = new List<T>();
            HttpClient client = new HttpClient { BaseAddress = new Uri(path) };
            JsonSerializer serializer = JsonSerializer.CreateDefault();          
            var json = client.GetAsync(endpoint);
            var fromJson = await json.Result.Content.ReadAsStringAsync();
            using (StringReader reader = new StringReader(fromJson))
            {
                using (JsonTextReader jsonReader = new JsonTextReader(reader))
                {
                    entitiess = serializer.Deserialize(jsonReader).ToModelList<T>();
                }
            }
            return entitiess;
        }

        public static async Task<T> SendRequestSipleData<T>(this string endpoint) where T : class
        {
            const string path = "https://api.coincap.io/v2/";
            T entity;
            HttpClient client = new HttpClient { BaseAddress = new Uri(path) };
            JsonSerializer serializer = JsonSerializer.CreateDefault();
            var json = client.GetAsync(endpoint);
            var fromJson = await json.Result.Content.ReadAsStringAsync();
            using (StringReader reader = new StringReader(fromJson))
            {
                using (JsonTextReader jsonReader = new JsonTextReader(reader))
                {
                    entity = serializer.Deserialize(jsonReader).ToModel<T>();
                }
            }
            return entity;
        }

        class DataListTemp<T>
        {
            public List<T> data { get; set; }            
        }

        class DataTemp<T>
        {
            public T data { get; set; }
        }
    }
}
