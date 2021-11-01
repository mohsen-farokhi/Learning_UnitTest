using FluentAssertions;
using Xunit;

namespace TestcaseSuperclass.Test
{
    //public class DummyParty : Party
    //{
    //}

    public abstract class PartyTest
    {
        [Fact]
        public void assign_address_to_party()
        {
            var party = CreateParty();

            party.AddAddress("Tehrab");

            party.Addresses.Should().HaveCount(1).And.Contain("Tehran");
        }

        protected abstract Party CreateParty();
    }

    public class LegalPartyTest : PartyTest
    {
        protected override Party CreateParty()
        {
            return new LegalParty();
        }
    }

    public class IndividualPartyTest : PartyTest
    {
        protected override Party CreateParty()
        {
            return new IndividualParty();
        }
    }
}
