using System;
using System.Collections.Generic;

namespace TestcaseSuperclass
{

    public abstract class Party
    {
        protected Party()
        {
            Addresses = new List<string>();
        }

        public List<string> Addresses { get; set; }

        public void AddAddress(string address)
        {
            Addresses.Add(address);
        }
    }

    public class IndividualParty : Party
    {
    }

    public class LegalParty : Party
    {
    }
}
