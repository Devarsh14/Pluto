using System;
using System.Collections.Generic;

namespace MarketApp.Models
{
    public partial class QuarterlyResultBrief
    {
        public string SecurityName { get; set; }
        public string SecurityNumber { get; set; }
        public string Quarter { get; set; }
        public string Revenue { get; set; }
        public string OtherIncome { get; set; }
        public string TotalIncome { get; set; }
        public string Expenditure { get; set; }
        public string Interest { get; set; }
        public string Pbdt { get; set; }
        public string Depereciation { get; set; }
        public string Pbt { get; set; }
        public string Tax { get; set; }
        public string NetProfit { get; set; }
        public string Equity { get; set; }
        public string Eps { get; set; }
        public string Ceps { get; set; }
        public string Opm { get; set; }
        public string Npm { get; set; }
        public Guid Id { get; set; }
    }
}
