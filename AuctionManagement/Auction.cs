using AuctionManagement.Frameworks;
using System;

namespace AuctionManagement
{
    public class Auction
    {
        public Auction
            (int sellerId,
            DateTime endDateTime,
            string product,
            long startingPrice,
            IClock clock)
        {
            if (endDateTime < clock.Now())
            {
                throw new InvalidEndDateException();
            }

            SellerId = sellerId;
            EndDateTime = endDateTime;
            Product = product;
            StartingPrice = startingPrice;
        }

        public int SellerId { get; set; }
        public DateTime EndDateTime { get; set; }
        public string Product { get; set; }
        public long StartingPrice { get; set; }
        public Bid WinningBid { get; set; }

        public void PlaceBid(Bid bid, IClock clock)
        {
            if (bid.BidderId == SellerId)
            {
                throw new InvalidBidderException();
            }

            if (bid.Amount <= StartingPrice)
            {
                throw new InvalidBidAmountException();
            }

            if(clock.Now() >= EndDateTime)
            {
                throw new ExpiredAuctionException();
            }

            WinningBid = bid;
        }
    }
}
