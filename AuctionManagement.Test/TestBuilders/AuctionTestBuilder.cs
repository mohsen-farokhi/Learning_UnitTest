using AuctionManagement.Frameworks;
using AuctionManagement.Test.TestDoubles;
using System;
using static AuctionManagement.Test.TestBuilders.TestConstants;

namespace AuctionManagement.Test.TestBuilders
{
    internal class AuctionTestBuilder
    {
        private int _sellerId = Sellers.Jack;
        private DateTime _endDateTime = DateTime.Now.AddDays(1);
        private string _product = "ASUS N56";
        private long _startingPrice = 1000;
        private IClock _clock = new StubClock();

        public Auction Build()
        {
            return
                 new Auction
                 (_sellerId, _endDateTime, _product, _startingPrice, _clock);
        }

        public AuctionTestBuilder WithSellerId(int sellerId)
        {
            _sellerId = sellerId;
            return this;
        }

        public AuctionTestBuilder WithStartingPrice(long startingPrice)
        {
            _startingPrice = startingPrice;
            return this;
        }

        public AuctionTestBuilder WithStartDateTime(IClock startClock)
        {
            _clock = startClock;
            return this;
        }

        public AuctionTestBuilder WithEndDateTime(DateTime endDateTime)
        {
            _endDateTime = endDateTime;
            return this;
        }
    }
}
