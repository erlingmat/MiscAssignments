using System;
using System.Collections.Generic;
using System.Text;

namespace SkuAssignment.SkuRules
{
    /*
     *
     *
     * Test Setup
Unit price for SKU IDs 
A	50
B	30
C	20
D	15

Active Promotions
3 of A's for 130
2 of B's for 45 
C & D for 30

Scenario A
1 * A  50
1 * B  30
1 * C  20

Total 100

Scenario B
5 * A     130 + 2*50
5 * B     45 + 45 + 30
1 * C     28
Total	370

Scenario C
3 * A   130
5 * B   45 + 45 + 1 * 30
1 * C   -
1 * D   30
     *
     */
    class RuleItem
    {
        public List<string> ItemNames;
        public double OfferPrice;
    }

    class SkuRulesConfig
    {
        private List<RuleItem> ActiveOffers;

        public SkuRulesConfig()
        {
            ActiveOffers = new List<RuleItem>();
            ActiveOffers.Add(new RuleItem{ItemNames = new List<string>{"A", "A", "A"}, OfferPrice = 130.0});
            ActiveOffers.Add(new RuleItem { ItemNames = new List<string> { "B", "B" }, OfferPrice = 45.0 });
            ActiveOffers.Add(new RuleItem { ItemNames = new List<string> { "C", "D" }, OfferPrice = 30.0 });

        }
    }
}
