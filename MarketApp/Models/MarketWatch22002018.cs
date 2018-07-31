using System;
using System.Collections.Generic;

namespace MarketApp.Models
{
    public partial class MarketWatch22002018
    {
        public string SecurityCode { get; set; }
        public string SecurityName { get; set; }
        public string SecurityGroup { get; set; }
        public string Open { get; set; }
        public string High { get; set; }
        public string Low { get; set; }
        public string Ltp { get; set; }
        public string NoOfSharesTraded { get; set; }
        public string TotalTurnoverImgSrcIncludeImagesRsGifAltMyImageLac { get; set; }
        public string NoOfTrades { get; set; }
        public Guid Id { get; set; }
    }
}
