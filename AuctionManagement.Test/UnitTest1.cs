using AuctionManagement.Test.TestBuilders;
using FluentAssertions;
using System;
using Xunit;
using static AuctionManagement.Test.TestBuilders.TestConstants;

namespace AuctionManagement.Test
{
    public class UnitTest1
    {
        [Fact]
        public void Auction_open_with_valid_data()
        {
            var sellerId = Sellers.Jack;
            var endDateTime = DateTime.Now.AddDays(1);
            var product = "ASUS N56";
            var startingPrice = 1000;

            var auction =
                new Auction(sellerId, endDateTime, product, startingPrice);

            auction.SellerId.Should().Be(sellerId);
            auction.EndDateTime.Should().Be(endDateTime);
            auction.Product.Should().Be(product);
            auction.StartingPrice.Should().Be(startingPrice);
        }

        [Fact]
        public void Auction_cant_be_open_when_ending_is_past()
        {
            Action auction = () =>
               new AuctionTestBuilder()
               .WithEndDateTime(DateTime.Now.AddDays(-1))
               .Build();

            auction.Should().Throw<InvalidEndDateException>();
        }

        [Fact]
        public void Auction_opens_with_no_winner_at_the_beginning()
        {
            var auction =
               new AuctionTestBuilder()
               .Build();

            auction.WinningBid.Should().BeNull();
        }

        [Fact]
        public void Bid_places_as_current_binner_when_bid_is_greater_than_starting_price_on_first_bid()
        {
            var auction =
               new AuctionTestBuilder()
               .WithStartingPrice(1000)
               .Build();

            var bid = BidTestFactory.CreateWithAmount(amount: 1100);

            auction.PlaceBid(bid);

            auction.WinningBid.Should().Be(bid);
        }

        [Theory]
        [InlineData(999, 1000)]
        [InlineData(1000, 1000)]
        public void Bid_not_placed_when_bid_is_greater_or_equal_to_starting_price_on_first_bid
            (long bidAmount, long startingPrice)
        {
            var auction =
               new AuctionTestBuilder()
               .WithStartingPrice(startingPrice)
               .Build();

            var bid = BidTestFactory.CreateWithAmount(amount: bidAmount);

            Action placingBid = () =>
                auction.PlaceBid(bid);

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
                auction.PlaceBid(bid);

            placeBid.Should().Throw<InvalidBidderException>();
        }

    }
}
