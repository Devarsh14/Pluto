using System;
using System.Collections.Generic;

namespace EntityLinqMasteringApp.NopCommerceModel
{
    public partial class PollVotingRecord
    {
        public int Id { get; set; }
        public int PollAnswerId { get; set; }
        public int CustomerId { get; set; }
        public DateTime CreatedOnUtc { get; set; }

        public Customer Customer { get; set; }
        public PollAnswer PollAnswer { get; set; }
    }
}
