using System;
using System.Collections.Generic;

namespace EntityLinqMasteringApp.NopCommerceModel
{
    public partial class Poll
    {
        public Poll()
        {
            PollAnswer = new HashSet<PollAnswer>();
        }

        public int Id { get; set; }
        public int LanguageId { get; set; }
        public string Name { get; set; }
        public string SystemKeyword { get; set; }
        public bool Published { get; set; }
        public bool ShowOnHomePage { get; set; }
        public bool AllowGuestsToVote { get; set; }
        public int DisplayOrder { get; set; }
        public DateTime? StartDateUtc { get; set; }
        public DateTime? EndDateUtc { get; set; }

        public Language Language { get; set; }
        public ICollection<PollAnswer> PollAnswer { get; set; }
    }
}
