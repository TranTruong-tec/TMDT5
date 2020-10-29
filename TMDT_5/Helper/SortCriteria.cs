using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;

namespace TMDT_5.Helper
{
    public enum SortCriteria
    {
        [Description("Relevance")]
        Relevance = 0,
        [Description("Price: Low to High")]
        PriceLowToHigh = 1,
        [Description("Price: High to Low")]
        PriceHighToLow = 2
    }
}