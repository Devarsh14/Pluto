using System;
using System.Collections.Generic;

namespace EntityLinqMasteringApp.DevERPModels
{
    public partial class MtlCategoryM
    {
        public short MaterialCategoryId { get; set; }
        public string MaterialTypeName { get; set; }
        public string MaterialTypeCode { get; set; }
        public int? GroupId { get; set; }
        public string Description { get; set; }
        public string IndustryType { get; set; }
        public string FamilyEditPage { get; set; }
        public string PartEditPage { get; set; }
        public string CategoryDisplayNamePart { get; set; }
        public short? ReportingUnitCategoryId { get; set; }
        public string CompulsoryFields { get; set; }
        public string DefaultValueFields { get; set; }
        public bool? IsAllowToAddDeleteFamily { get; set; }
        public string ParameterString { get; set; }
        public DateTime CreatedDt { get; set; }
        public short CreatedUserId { get; set; }
        public DateTime UpdatedDt { get; set; }
        public short UpdatedUserId { get; set; }
        public bool IsDeleted { get; set; }
        public byte? PcbtypeIdOld { get; set; }
        public int? MaterialClassIdOld { get; set; }
        public bool IsService { get; set; }
        public bool IsApplyPartGroups { get; set; }
    }
}
