using AuctionManagement;
using static AuctionManagement.Test.TestBuilders.TestConstants;

namespace AuctionManagement.Test.TestBuilders
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
