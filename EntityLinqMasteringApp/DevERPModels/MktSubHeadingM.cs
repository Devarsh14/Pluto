using System;
using System.Collections.Generic;

namespace EntityLinqMasteringApp.DevERPModels
{
    public partial class MktSubHeadingM
    {
        public int SubHeadingId { get; set; }
        public int HeadingId { get; set; }
        public string Title { get; set; }
        public string MenuTitle { get; set; }
        public string Text { get; set; }
        public string BannerImg1 { get; set; }
        public string BannerImg2 { get; set; }
        public string BannerImg3 { get; set; }
        public string IconImg { get; set; }
        public DateTime CreatedDt { get; set; }
        public int CreatedUserId { get; set; }
        public DateTime? UpdatedDt { get; set; }
        public int? UpdatedUserId { get; set; }
        public bool IsDeleted { get; set; }
        public int DisplayOrder { get; set; }
        public string BannerImg4 { get; set; }
        public string BannerImg5 { get; set; }
    }
}
