using AuctionManagement.Frameworks;
using System;

namespace AuctionManagement.Test.TestDoubles
{
    public class StubClock : IClock
    {
        private DateTime _now;

        private StubClock(DateTime now)
        {
            _now = now;
        }

        public static StubClock WhichSetsNowAs(DateTime dateTime)
        {
            return new StubClock(dateTime);
        }

        public static StubClock Default()
        {
            return new StubClock(DateTime.Now);
        }

        public DateTime Now() => _now;

        public void TimeTravelToSomeDateAfter(DateTime date)
        {
            _now = date.AddDays(1);
        }

        public void TimeTravelToSomeDateBefore(DateTime date)
        {
            _now = date.AddDays(-1);
        }
    }
}
