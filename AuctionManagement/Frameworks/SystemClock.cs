using System;

namespace AuctionManagement.Frameworks
{
    public class SystemClock : IClock
    {
        public DateTime Now()
        {
            return DateTime.Now;
        }
    }
}
