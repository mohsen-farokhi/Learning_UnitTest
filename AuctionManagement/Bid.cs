namespace AuctionManagement
{
    public class Bid
    {
        public Bid(long amount, int bidderId)
        {
            Amount = amount;
            BidderId = bidderId;
        }

        public long Amount { get; private set; }
        public int BidderId { get; private set; }
    }
}
