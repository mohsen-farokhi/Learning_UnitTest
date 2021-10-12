using AuctionManagement;
using System;
using static AuctionManagementTest.TestConstants;

namespace AuctionManagementTest.TestBuilders
{
    internal class AuctionTestBuilder
    {
        private int _sellerId = Sellers.Jack;
        private DateTime _endDateTime = DateTime.Now.AddDays(1);
        private string _product = "ASUS N56";
        private long _startingPrice = 1000;

        public Auction Build()
        {
            return
                 new Auction(_sellerId, _endDateTime, _product, _startingPrice);
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

        internal AuctionTestBuilder WithEndDateTime(DateTime endDateTime)
        {
            _endDateTime = endDateTime;
            return this;
        }
    }
}
