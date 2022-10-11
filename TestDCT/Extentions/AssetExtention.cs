using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestDCT.Models;

namespace TestDCT.Extentions
{
    public static class AssetExtention
    {
        public static IEnumerable<Asset> ToModelList(this object list)
        {
            var temp = new DataTemp();
            temp = JsonConvert.DeserializeObject<DataTemp>(list.ToString());
            return temp.data;
        }

        class DataTemp
        {
            public List<Asset> data { get; set; }
        }

    }
}
