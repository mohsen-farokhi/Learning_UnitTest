using AuctionManagement;
using static AuctionManagementTest.TestBuilders.TestConstants;

namespace AuctionManagementTest.TestBuilders
{
    internal class BidTestFactory
    {
        public static Bid CreateWithAmount(long amount)
        {
            return new Bid(amount, Bidders.Sara);
        }

        public static Bid CreateWithBidder(int bidderId)
        {
            return new Bid(1111111, bidderId);
        }
    }
}
