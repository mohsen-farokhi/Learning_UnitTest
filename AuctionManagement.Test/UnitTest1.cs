using AuctionManagement.Test.TestBuilders;
using AuctionManagement.Test.TestDoubles;
using FluentAssertions;
using System;
using Xunit;
using static AuctionManagement.Test.TestBuilders.TestConstants;

namespace AuctionManagement.Test
{
    public class UnitTest1
    {
        [Fact]
        public void auction_open_with_valid_data()
        {
            var sellerId = Sellers.Jack;
            var endDateTime = DateTime.Now.AddDays(1);
            var product = "ASUS N56";
            var startingPrice = 1000;

            var auction = new Auction
                (sellerId, endDateTime, product, startingPrice, StubClock.Default());

            auction.SellerId.Should().Be(sellerId);
            auction.EndDateTime.Should().Be(endDateTime);
            auction.Product.Should().Be(product);
            auction.StartingPrice.Should().Be(startingPrice);
        }

        [Fact]
        public void auction_cant_be_open_when_ending_is_past()
        {
            Action auction = () =>
               new AuctionTestBuilder()
               .WithEndDateTime(DateTime.Now.AddDays(-1))
               .Build();

            auction.Should().Throw<InvalidEndDateException>();
        }

        [Fact]
        public void cant_palce_bid_on_expired_auction()
        {
            var clock = StubClock.WhichSetsNowAs(DateTime.Parse("2010-01-01 10:30"));
            var endDate = DateTime.Parse("2010-02-01 10:30");

            var auction = new AuctionTestBuilder()
                .WithStartingPrice(1000)
                .WithStartDateTime(clock)
                .WithEndDateTime(endDate)
                .Build();

            clock.TimeTravelToSomeDateAfter(endDate);

            var bid = BidTestFactory.CreateWithAmount(1100);

            Action placingBid = () => auction.PlaceBid(bid, clock);

            placingBid.Should().Throw<ExpiredAuctionException>();
        }

        [Fact]
        public void auction_opens_with_no_winner_at_the_beginning()
        {
            var auction =
               new AuctionTestBuilder()
               .Build();

            auction.WinningBid.Should().BeNull();
        }

        [Fact]
        public void bid_places_as_current_binner_when_bid_is_greater_than_starting_price_on_first_bid()
        {
            var auction =
               new AuctionTestBuilder()
               .WithStartingPrice(1000)
               .Build();

            var bid = BidTestFactory.CreateWithAmount(amount: 1100);

            auction.PlaceBid(bid, new StubClock());

            auction.WinningBid.Should().Be(bid);
        }

        [Theory]
        [InlineData(999, 1000)]
        [InlineData(1000, 1000)]
        public void bid_not_placed_when_bid_is_greater_or_equal_to_starting_price_on_first_bid
            (long bidAmount, long startingPrice)
        {
            var auction =
               new AuctionTestBuilder()
               .WithStartingPrice(startingPrice)
               .Build();

            var bid = BidTestFactory.CreateWithAmount(amount: bidAmount);

            Action placingBid = () =>
                auction.PlaceBid(bid, new StubClock());

            placingBid.Should().Throw<InvalidBidAmountException>();

        }

        [Fact]
        public void seller_cant_place_bid_on_himself_auction()
        {
            var auction =
               new AuctionTestBuilder()
               .WithSellerId(1)
               .Build();

            var bid = BidTestFactory.CreateWithBidder(bidderId: Sellers.Jack);

            Action placeBid = () =>
                auction.PlaceBid(bid, new StubClock());

            placeBid.Should().Throw<InvalidBidderException>();
        }

    }
}
