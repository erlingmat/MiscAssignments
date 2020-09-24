using System.Collections.Generic;
using Xunit;

namespace SkuAssignment.Test
{

    public class SkuRulesTests
    {
        public List<string> RuleMatch(List<string> largeList, List<string> subList, out bool RuleMatched)
        {
            List<string> tempList = new List<string>(largeList);
            RuleMatched = true;
            foreach (var elem in subList)
            {
                if (tempList.Contains(elem))
                {
                    tempList.Remove(elem);
                }
                else
                {
                    RuleMatched = false;
                }
            }

            if (RuleMatched)
            {
                return tempList;
            } 
            return largeList;
        }

        [Fact]
        public void ListItemTest()
        {
            List<string> purchase = new List<string> {"A", "A", "A", "B"};
            List<string> offer = new List<string> {"A", "A", "A"};
            var rest = RuleMatch(purchase, offer, out var matched);
            Assert.True(matched);
        }
    }
}
