using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDCT.Models
{
    public class Market
    {
        public string exchangeId { get; set; }
        public string rank { get; set; }
        public string baseSymbol { get; set; }
        public string baseId { get; set; }
        public string quoteSymbol { get; set; }
        public string quoteId { get; set; }
        public string priceQuote { get; set; }
        public string priceUsd { get; set; }
        public string volumeUsd24Hr { get; set; }
        public string percentExchangeVolume { get; set; }
        public string tradesCount24Hr { get; set; }
    }
}
