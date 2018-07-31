using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace EntityLinqMasteringApp.DevERPModels
{
    public partial class DevERPContext : DbContext
    {
        public virtual DbSet<AccConfigM> AccConfigM { get; set; }
        public virtual DbSet<AccFavoriteGroupsLedgers> AccFavoriteGroupsLedgers { get; set; }
        public virtual DbSet<AccGroups> AccGroups { get; set; }
        public virtual DbSet<AccLedgers> AccLedgers { get; set; }
        public virtual DbSet<AccLedgersLimit> AccLedgersLimit { get; set; }
        public virtual DbSet<AccProjectD> AccProjectD { get; set; }
        public virtual DbSet<AccProjectEntryM> AccProjectEntryM { get; set; }
        public virtual DbSet<AccProjectM> AccProjectM { get; set; }
        public virtual DbSet<AccProjectStockD> AccProjectStockD { get; set; }
        public virtual DbSet<AccProjectTypeM> AccProjectTypeM { get; set; }
        public virtual DbSet<AccRatioD> AccRatioD { get; set; }
        public virtual DbSet<AccRatioM> AccRatioM { get; set; }
        public virtual DbSet<AccStockStatusD> AccStockStatusD { get; set; }
        public virtual DbSet<AccStockStatusM> AccStockStatusM { get; set; }
        public virtual DbSet<AccTransferMode> AccTransferMode { get; set; }
        public virtual DbSet<AccVoucherFormatM> AccVoucherFormatM { get; set; }
        public virtual DbSet<AccVoucherFormatTableD> AccVoucherFormatTableD { get; set; }
        public virtual DbSet<AccVoucherFormatTableM> AccVoucherFormatTableM { get; set; }
        public virtual DbSet<AccVoucherItemD> AccVoucherItemD { get; set; }
        public virtual DbSet<AccVoucherProject> AccVoucherProject { get; set; }
        public virtual DbSet<AccVouchersClassification> AccVouchersClassification { get; set; }
        public virtual DbSet<AccVouchersD> AccVouchersD { get; set; }
        public virtual DbSet<AccVouchersM> AccVouchersM { get; set; }
        public virtual DbSet<AccVoucherTypes> AccVoucherTypes { get; set; }
        public virtual DbSet<AccVoucherTypesOptionNames> AccVoucherTypesOptionNames { get; set; }
        public virtual DbSet<ActCashBankAccountM> ActCashBankAccountM { get; set; }
        public virtual DbSet<ActDeliveryChallanD> ActDeliveryChallanD { get; set; }
        public virtual DbSet<ActDeliveryChallanItemD> ActDeliveryChallanItemD { get; set; }
        public virtual DbSet<ActDeliveryChallanM> ActDeliveryChallanM { get; set; }
        public virtual DbSet<ActDeliveryChallanQtyD> ActDeliveryChallanQtyD { get; set; }
        public virtual DbSet<ActDeliveryTypeM> ActDeliveryTypeM { get; set; }
        public virtual DbSet<ActInvoiceD> ActInvoiceD { get; set; }
        public virtual DbSet<ActInvoiceItemD> ActInvoiceItemD { get; set; }
        public virtual DbSet<ActInvoiceM> ActInvoiceM { get; set; }
        public virtual DbSet<ActInvoiceQtyD> ActInvoiceQtyD { get; set; }
        public virtual DbSet<ActInvoiceTaxD> ActInvoiceTaxD { get; set; }
        public virtual DbSet<ActInvoiceTermD> ActInvoiceTermD { get; set; }
        public virtual DbSet<ActPackingBoxM> ActPackingBoxM { get; set; }
        public virtual DbSet<ActPackingListItemD> ActPackingListItemD { get; set; }
        public virtual DbSet<ActPackingListM> ActPackingListM { get; set; }
        public virtual DbSet<ActPaymentD> ActPaymentD { get; set; }
        public virtual DbSet<ActPaymentM> ActPaymentM { get; set; }
        public virtual DbSet<ActPaymentModeM> ActPaymentModeM { get; set; }
        public virtual DbSet<ActPaymentSendD> ActPaymentSendD { get; set; }
        public virtual DbSet<ActPaymentSendM> ActPaymentSendM { get; set; }
        public virtual DbSet<ActPaymentTypeM> ActPaymentTypeM { get; set; }
        public virtual DbSet<ActScrapInvoiceD> ActScrapInvoiceD { get; set; }
        public virtual DbSet<ActScrapInvoiceM> ActScrapInvoiceM { get; set; }
        public virtual DbSet<ActTaxClassificationM> ActTaxClassificationM { get; set; }
        public virtual DbSet<ActTaxHistory> ActTaxHistory { get; set; }
        public virtual DbSet<ActTaxNewM> ActTaxNewM { get; set; }
        public virtual DbSet<AlertDefinition> AlertDefinition { get; set; }
        public virtual DbSet<AlertEmails> AlertEmails { get; set; }
        public virtual DbSet<AlertRecipient> AlertRecipient { get; set; }
        public virtual DbSet<AstAreaM> AstAreaM { get; set; }
        public virtual DbSet<AstAssetAllocationM> AstAssetAllocationM { get; set; }
        public virtual DbSet<AstAssetCategoryM> AstAssetCategoryM { get; set; }
        public virtual DbSet<AstAssetInchargeD> AstAssetInchargeD { get; set; }
        public virtual DbSet<AstAssetM> AstAssetM { get; set; }
        public virtual DbSet<AstBudgetPlanM> AstBudgetPlanM { get; set; }
        public virtual DbSet<AstDepreciationD> AstDepreciationD { get; set; }
        public virtual DbSet<AstFieldTypeAssetM> AstFieldTypeAssetM { get; set; }
        public virtual DbSet<AstFieldTypeD> AstFieldTypeD { get; set; }
        public virtual DbSet<AstFieldTypeM> AstFieldTypeM { get; set; }
        public virtual DbSet<AstInsuranceAssetM> AstInsuranceAssetM { get; set; }
        public virtual DbSet<AstInsuranceD> AstInsuranceD { get; set; }
        public virtual DbSet<AstInsuranceM> AstInsuranceM { get; set; }
        public virtual DbSet<AstLocationM> AstLocationM { get; set; }
        public virtual DbSet<AstMachineWiseProcess> AstMachineWiseProcess { get; set; }
        public virtual DbSet<AstMaintenance> AstMaintenance { get; set; }
        public virtual DbSet<AstMaintenanceH> AstMaintenanceH { get; set; }
        public virtual DbSet<AstMaintenanceTypeM> AstMaintenanceTypeM { get; set; }
        public virtual DbSet<AstMarketValue> AstMarketValue { get; set; }
        public virtual DbSet<AstPlantM> AstPlantM { get; set; }
        public virtual DbSet<AstRepairM> AstRepairM { get; set; }
        public virtual DbSet<AstRepairRequestM> AstRepairRequestM { get; set; }
        public virtual DbSet<AstRepairTypeM> AstRepairTypeM { get; set; }
        public virtual DbSet<AstSupplierOfferingM> AstSupplierOfferingM { get; set; }
        public virtual DbSet<AstTypeM> AstTypeM { get; set; }
        public virtual DbSet<AstVersionM> AstVersionM { get; set; }
        public virtual DbSet<AstWarrantyD> AstWarrantyD { get; set; }
        public virtual DbSet<AstWarrantyM> AstWarrantyM { get; set; }
        public virtual DbSet<CityM> CityM { get; set; }
        public virtual DbSet<ColourM> ColourM { get; set; }
        public virtual DbSet<ComplexityLevelM> ComplexityLevelM { get; set; }
        public virtual DbSet<ConfigInvoiceTypeM> ConfigInvoiceTypeM { get; set; }
        public virtual DbSet<ConfigM> ConfigM { get; set; }
        public virtual DbSet<CountryM> CountryM { get; set; }
        public virtual DbSet<CurrencyM> CurrencyM { get; set; }
        public virtual DbSet<CustomReports> CustomReports { get; set; }
        public virtual DbSet<Emails> Emails { get; set; }
        public virtual DbSet<EmailTypeFormatM> EmailTypeFormatM { get; set; }
        public virtual DbSet<EmailTypeM> EmailTypeM { get; set; }
        public virtual DbSet<EmailTypeRecipientM> EmailTypeRecipientM { get; set; }
        public virtual DbSet<FilesM> FilesM { get; set; }
        public virtual DbSet<GenieVersionM> GenieVersionM { get; set; }
        public virtual DbSet<HrmAttendanceM> HrmAttendanceM { get; set; }
        public virtual DbSet<HrmAttendanceStatusM> HrmAttendanceStatusM { get; set; }
        public virtual DbSet<HrmBreakD> HrmBreakD { get; set; }
        public virtual DbSet<HrmBreakTypeM> HrmBreakTypeM { get; set; }
        public virtual DbSet<HrmConfInputEntryD> HrmConfInputEntryD { get; set; }
        public virtual DbSet<HrmConfInputEntryM> HrmConfInputEntryM { get; set; }
        public virtual DbSet<HrmConfInputTopics> HrmConfInputTopics { get; set; }
        public virtual DbSet<HrmDepartmentM> HrmDepartmentM { get; set; }
        public virtual DbSet<HrmDesignationM> HrmDesignationM { get; set; }
        public virtual DbSet<HrmDesignationRoleD> HrmDesignationRoleD { get; set; }
        public virtual DbSet<HrmDesignationSkillD> HrmDesignationSkillD { get; set; }
        public virtual DbSet<HrmEmployeeHolidayM> HrmEmployeeHolidayM { get; set; }
        public virtual DbSet<HrmEmployeeLeaveTypes> HrmEmployeeLeaveTypes { get; set; }
        public virtual DbSet<HrmEmployeeLogD> HrmEmployeeLogD { get; set; }
        public virtual DbSet<HrmEmployeeM> HrmEmployeeM { get; set; }
        public virtual DbSet<HrmEmployeePfD> HrmEmployeePfD { get; set; }
        public virtual DbSet<HrmEmployeePfM> HrmEmployeePfM { get; set; }
        public virtual DbSet<HrmEmployeeRecordD> HrmEmployeeRecordD { get; set; }
        public virtual DbSet<HrmEmployeeRecordM> HrmEmployeeRecordM { get; set; }
        public virtual DbSet<HrmEmployeeSalaryComponentM> HrmEmployeeSalaryComponentM { get; set; }
        public virtual DbSet<HrmEmployeeSalarySlipM> HrmEmployeeSalarySlipM { get; set; }
        public virtual DbSet<HrmEmployeeSkillD> HrmEmployeeSkillD { get; set; }
        public virtual DbSet<HrmEmployeeSkillM> HrmEmployeeSkillM { get; set; }
        public virtual DbSet<HrmEmpSkillCategoryM> HrmEmpSkillCategoryM { get; set; }
        public virtual DbSet<HrmHolidayD> HrmHolidayD { get; set; }
        public virtual DbSet<HrmHolidayM> HrmHolidayM { get; set; }
        public virtual DbSet<HrmLeaveAdditionM> HrmLeaveAdditionM { get; set; }
        public virtual DbSet<HrmLeaveRejectionReasonM> HrmLeaveRejectionReasonM { get; set; }
        public virtual DbSet<HrmLeaveRequestD> HrmLeaveRequestD { get; set; }
        public virtual DbSet<HrmLeaveRequestM> HrmLeaveRequestM { get; set; }
        public virtual DbSet<HrmLeaveRequestReasonM> HrmLeaveRequestReasonM { get; set; }
        public virtual DbSet<HrmLeaveTypeM> HrmLeaveTypeM { get; set; }
        public virtual DbSet<HrmProjectM> HrmProjectM { get; set; }
        public virtual DbSet<HrmProjectTeam> HrmProjectTeam { get; set; }
        public virtual DbSet<HrmQualificationD> HrmQualificationD { get; set; }
        public virtual DbSet<HrmQualificationM> HrmQualificationM { get; set; }
        public virtual DbSet<HrmReasonForTerminationM> HrmReasonForTerminationM { get; set; }
        public virtual DbSet<HrmRecordCategory> HrmRecordCategory { get; set; }
        public virtual DbSet<HrmRecordD> HrmRecordD { get; set; }
        public virtual DbSet<HrmRecordM> HrmRecordM { get; set; }
        public virtual DbSet<HrmRecSkillD> HrmRecSkillD { get; set; }
        public virtual DbSet<HrmReminderNote> HrmReminderNote { get; set; }
        public virtual DbSet<HrmRemindersM> HrmRemindersM { get; set; }
        public virtual DbSet<HrmRoleM> HrmRoleM { get; set; }
        public virtual DbSet<HrmRoleSkillsD> HrmRoleSkillsD { get; set; }
        public virtual DbSet<HrmSalaryComponentM> HrmSalaryComponentM { get; set; }
        public virtual DbSet<HrmSalaryExpenseHead> HrmSalaryExpenseHead { get; set; }
        public virtual DbSet<HrmSalaryExpenseHeadHistory> HrmSalaryExpenseHeadHistory { get; set; }
        public virtual DbSet<HrmSalarySlipD> HrmSalarySlipD { get; set; }
        public virtual DbSet<HrmSalarySlipM> HrmSalarySlipM { get; set; }
        public virtual DbSet<HrmShiftM> HrmShiftM { get; set; }
        public virtual DbSet<HrmSkillAdditionPlanM> HrmSkillAdditionPlanM { get; set; }
        public virtual DbSet<HrmSkillAdditionRecord> HrmSkillAdditionRecord { get; set; }
        public virtual DbSet<HrmTaskPreRequisite> HrmTaskPreRequisite { get; set; }
        public virtual DbSet<HrmTaskSchedule> HrmTaskSchedule { get; set; }
        public virtual DbSet<HrmTickTock> HrmTickTock { get; set; }
        public virtual DbSet<HrmTrainingAttendeesD> HrmTrainingAttendeesD { get; set; }
        public virtual DbSet<HrmTrainingM> HrmTrainingM { get; set; }
        public virtual DbSet<HrmTrainingObjectivesD> HrmTrainingObjectivesD { get; set; }
        public virtual DbSet<HrmTrainingSkillsD> HrmTrainingSkillsD { get; set; }
        public virtual DbSet<HrmTrainingTimeD> HrmTrainingTimeD { get; set; }
        public virtual DbSet<HrmUserActivityLogD> HrmUserActivityLogD { get; set; }
        public virtual DbSet<Inbox> Inbox { get; set; }
        public virtual DbSet<Message> Message { get; set; }
        public virtual DbSet<MktAutoQuoteD> MktAutoQuoteD { get; set; }
        public virtual DbSet<MktBusinessActivityM> MktBusinessActivityM { get; set; }
        public virtual DbSet<MktCommunication> MktCommunication { get; set; }
        public virtual DbSet<MktCommunicationTypes> MktCommunicationTypes { get; set; }
        public virtual DbSet<MktCompanyAddressD> MktCompanyAddressD { get; set; }
        public virtual DbSet<MktCompanyClassM> MktCompanyClassM { get; set; }
        public virtual DbSet<MktCompanyContactPersonD> MktCompanyContactPersonD { get; set; }
        public virtual DbSet<MktCompanyDeliveryD> MktCompanyDeliveryD { get; set; }
        public virtual DbSet<MktCompanyM> MktCompanyM { get; set; }
        public virtual DbSet<MktCompanyPagesD> MktCompanyPagesD { get; set; }
        public virtual DbSet<MktCompanyRecordD> MktCompanyRecordD { get; set; }
        public virtual DbSet<MktCompanyShipping> MktCompanyShipping { get; set; }
        public virtual DbSet<MktCompanyTaxClassification> MktCompanyTaxClassification { get; set; }
        public virtual DbSet<MktCompanyTermD> MktCompanyTermD { get; set; }
        public virtual DbSet<MktCustomerCategoryM> MktCustomerCategoryM { get; set; }
        public virtual DbSet<MktCustomerCategoryTaxD> MktCustomerCategoryTaxD { get; set; }
        public virtual DbSet<MktCustomerRegn> MktCustomerRegn { get; set; }
        public virtual DbSet<MktEventDateTimeD> MktEventDateTimeD { get; set; }
        public virtual DbSet<MktEventInviteesD> MktEventInviteesD { get; set; }
        public virtual DbSet<MktEventM> MktEventM { get; set; }
        public virtual DbSet<MktEventRegCharges> MktEventRegCharges { get; set; }
        public virtual DbSet<MktEventRegD> MktEventRegD { get; set; }
        public virtual DbSet<MktEventRegFields> MktEventRegFields { get; set; }
        public virtual DbSet<MktEventRegM> MktEventRegM { get; set; }
        public virtual DbSet<MktEventResultsD> MktEventResultsD { get; set; }
        public virtual DbSet<MktEventTaskD> MktEventTaskD { get; set; }
        public virtual DbSet<MktEventTypeM> MktEventTypeM { get; set; }
        public virtual DbSet<MktFacilitiesAssetsM> MktFacilitiesAssetsM { get; set; }
        public virtual DbSet<MktFeedbackBandM> MktFeedbackBandM { get; set; }
        public virtual DbSet<MktFeedbackCategoryM> MktFeedbackCategoryM { get; set; }
        public virtual DbSet<MktFeedbackD> MktFeedbackD { get; set; }
        public virtual DbSet<MktFeedbackFactorM> MktFeedbackFactorM { get; set; }
        public virtual DbSet<MktFeedbackM> MktFeedbackM { get; set; }
        public virtual DbSet<MktGenieMailM> MktGenieMailM { get; set; }
        public virtual DbSet<MktHeadingM> MktHeadingM { get; set; }
        public virtual DbSet<MktItemM> MktItemM { get; set; }
        public virtual DbSet<MktMarketValueM> MktMarketValueM { get; set; }
        public virtual DbSet<MktNewsM> MktNewsM { get; set; }
        public virtual DbSet<MktPiM> MktPiM { get; set; }
        public virtual DbSet<MktPoitems> MktPoitems { get; set; }
        public virtual DbSet<MktPoitemsHistory> MktPoitemsHistory { get; set; }
        public virtual DbSet<MktPoM> MktPoM { get; set; }
        public virtual DbSet<MktPotaxesNew> MktPotaxesNew { get; set; }
        public virtual DbSet<MktPotermsD> MktPotermsD { get; set; }
        public virtual DbSet<MktProductShoppingCartWishList> MktProductShoppingCartWishList { get; set; }
        public virtual DbSet<MktQuotationItems> MktQuotationItems { get; set; }
        public virtual DbSet<MktQuotationItemsD> MktQuotationItemsD { get; set; }
        public virtual DbSet<MktQuotationM> MktQuotationM { get; set; }
        public virtual DbSet<MktQuotationTaxes> MktQuotationTaxes { get; set; }
        public virtual DbSet<MktQuotationTermsD> MktQuotationTermsD { get; set; }
        public virtual DbSet<MktSubHeadingM> MktSubHeadingM { get; set; }
        public virtual DbSet<MktTermCustomerCategoy> MktTermCustomerCategoy { get; set; }
        public virtual DbSet<MktTermsM> MktTermsM { get; set; }
        public virtual DbSet<MktWebsiteBannersM> MktWebsiteBannersM { get; set; }
        public virtual DbSet<MktWebsiteConfigM> MktWebsiteConfigM { get; set; }
        public virtual DbSet<MktWebsiteCustomers> MktWebsiteCustomers { get; set; }
        public virtual DbSet<MktWebsitePagesM> MktWebsitePagesM { get; set; }
        public virtual DbSet<MtlBrandD> MtlBrandD { get; set; }
        public virtual DbSet<MtlBrandM> MtlBrandM { get; set; }
        public virtual DbSet<MtlCategoryFieldGroups> MtlCategoryFieldGroups { get; set; }
        public virtual DbSet<MtlCategoryM> MtlCategoryM { get; set; }
        public virtual DbSet<MtlCompanyParts> MtlCompanyParts { get; set; }
        public virtual DbSet<MtlCustomerReturnD> MtlCustomerReturnD { get; set; }
        public virtual DbSet<MtlCustomerReturnLogDetailD> MtlCustomerReturnLogDetailD { get; set; }
        public virtual DbSet<MtlCustomerReturnM> MtlCustomerReturnM { get; set; }
        public virtual DbSet<MtlDumpM> MtlDumpM { get; set; }
        public virtual DbSet<MtlFieldGroupM> MtlFieldGroupM { get; set; }
        public virtual DbSet<MtlFieldsD> MtlFieldsD { get; set; }
        public virtual DbSet<MtlFieldsM> MtlFieldsM { get; set; }
        public virtual DbSet<MtlFieldTypeM> MtlFieldTypeM { get; set; }
        public virtual DbSet<MtlIssueD> MtlIssueD { get; set; }
        public virtual DbSet<MtlIssueM> MtlIssueM { get; set; }
        public virtual DbSet<MtlIssueRequestD> MtlIssueRequestD { get; set; }
        public virtual DbSet<MtlIssueRequestM> MtlIssueRequestM { get; set; }
        public virtual DbSet<MtlMaterialConversionD> MtlMaterialConversionD { get; set; }
        public virtual DbSet<MtlMaterialConversionM> MtlMaterialConversionM { get; set; }
        public virtual DbSet<MtlMaterialM> MtlMaterialM { get; set; }
        public virtual DbSet<MtlMaterialPriceList> MtlMaterialPriceList { get; set; }
        public virtual DbSet<MtlMaterialSupplierOffersLogD> MtlMaterialSupplierOffersLogD { get; set; }
        public virtual DbSet<MtlMaterialSuppliers> MtlMaterialSuppliers { get; set; }
        public virtual DbSet<MtlMovementM> MtlMovementM { get; set; }
        public virtual DbSet<MtlOnlinePrice> MtlOnlinePrice { get; set; }
        public virtual DbSet<MtlPartCrmD> MtlPartCrmD { get; set; }
        public virtual DbSet<MtlPartTypes> MtlPartTypes { get; set; }
        public virtual DbSet<MtlPotermD> MtlPotermD { get; set; }
        public virtual DbSet<MtlPrdFieldOptions> MtlPrdFieldOptions { get; set; }
        public virtual DbSet<MtlPrdFileTypeM> MtlPrdFileTypeM { get; set; }
        public virtual DbSet<MtlPrdMaterialFileLog> MtlPrdMaterialFileLog { get; set; }
        public virtual DbSet<MtlPrdMaterialFiles> MtlPrdMaterialFiles { get; set; }
        public virtual DbSet<MtlPrdMaterialNotes> MtlPrdMaterialNotes { get; set; }
        public virtual DbSet<MtlPrdMaterialSubCategoryProcessStepUsageD> MtlPrdMaterialSubCategoryProcessStepUsageD { get; set; }
        public virtual DbSet<MtlPrdMultiValueFieldD> MtlPrdMultiValueFieldD { get; set; }
        public virtual DbSet<MtlPrdSubCategoryBrands> MtlPrdSubCategoryBrands { get; set; }
        public virtual DbSet<MtlPrdSubCategoryFileTypes> MtlPrdSubCategoryFileTypes { get; set; }
        public virtual DbSet<MtlPurchaseD> MtlPurchaseD { get; set; }
        public virtual DbSet<MtlPurchaseM> MtlPurchaseM { get; set; }
        public virtual DbSet<MtlPurchaseRequestD> MtlPurchaseRequestD { get; set; }
        public virtual DbSet<MtlPurchaseRequestM> MtlPurchaseRequestM { get; set; }
        public virtual DbSet<MtlPurchaseTaxD> MtlPurchaseTaxD { get; set; }
        public virtual DbSet<MtlPurchaseTrackingLogD> MtlPurchaseTrackingLogD { get; set; }
        public virtual DbSet<MtlReceiveD> MtlReceiveD { get; set; }
        public virtual DbSet<MtlReceiveM> MtlReceiveM { get; set; }
        public virtual DbSet<MtlReceiveTaxD> MtlReceiveTaxD { get; set; }
        public virtual DbSet<MtlReconcileM> MtlReconcileM { get; set; }
        public virtual DbSet<MtlReturnM> MtlReturnM { get; set; }
        public virtual DbSet<MtlScrapLogD> MtlScrapLogD { get; set; }
        public virtual DbSet<MtlSetD> MtlSetD { get; set; }
        public virtual DbSet<MtlSetM> MtlSetM { get; set; }
        public virtual DbSet<MtlSubCategoryFieldGroupsM> MtlSubCategoryFieldGroupsM { get; set; }
        public virtual DbSet<MtlSubCategoryFieldsM> MtlSubCategoryFieldsM { get; set; }
        public virtual DbSet<MtlSubcategoryM> MtlSubcategoryM { get; set; }
        public virtual DbSet<MtlSubCategoryStatusOption> MtlSubCategoryStatusOption { get; set; }
        public virtual DbSet<MtlSupplierShippingLogD> MtlSupplierShippingLogD { get; set; }
        public virtual DbSet<MtlTransactionInspectionD> MtlTransactionInspectionD { get; set; }
        public virtual DbSet<MtlTransactionInspectionIdealD> MtlTransactionInspectionIdealD { get; set; }
        public virtual DbSet<MtlTransactionInspectionIdealM> MtlTransactionInspectionIdealM { get; set; }
        public virtual DbSet<MtlTransactionInspectionM> MtlTransactionInspectionM { get; set; }
        public virtual DbSet<MtlTransactionL> MtlTransactionL { get; set; }
        public virtual DbSet<MtlTransactionLogD> MtlTransactionLogD { get; set; }
        public virtual DbSet<MtlTransactionLogL1> MtlTransactionLogL1 { get; set; }
        public virtual DbSet<MtlTransactionLogL2> MtlTransactionLogL2 { get; set; }
        public virtual DbSet<MtlTransactionLogM> MtlTransactionLogM { get; set; }
        public virtual DbSet<MtlTransactionM> MtlTransactionM { get; set; }
        public virtual DbSet<MtlTransactionRateChanges> MtlTransactionRateChanges { get; set; }
        public virtual DbSet<MtlValueLog> MtlValueLog { get; set; }
        public virtual DbSet<OldAstPurchaseD> OldAstPurchaseD { get; set; }
        public virtual DbSet<OldAstPurchaseM> OldAstPurchaseM { get; set; }
        public virtual DbSet<OldAstPurchaseTaxD> OldAstPurchaseTaxD { get; set; }
        public virtual DbSet<OldAstReceiveD> OldAstReceiveD { get; set; }
        public virtual DbSet<OldAstReceiveM> OldAstReceiveM { get; set; }
        public virtual DbSet<OldAstTaxHistory> OldAstTaxHistory { get; set; }
        public virtual DbSet<OldAttendanceM> OldAttendanceM { get; set; }
        public virtual DbSet<OldAutoQuoteM> OldAutoQuoteM { get; set; }
        public virtual DbSet<OldHrmAchievementAlertsSent> OldHrmAchievementAlertsSent { get; set; }
        public virtual DbSet<OldHrmAchievementEntryFieldsD> OldHrmAchievementEntryFieldsD { get; set; }
        public virtual DbSet<OldHrmAchievementEntryM> OldHrmAchievementEntryM { get; set; }
        public virtual DbSet<OldHrmAchievementTypeM> OldHrmAchievementTypeM { get; set; }
        public virtual DbSet<OldHrmAchievementTypesFieldsD> OldHrmAchievementTypesFieldsD { get; set; }
        public virtual DbSet<OldHrmAlertGroupAchievements> OldHrmAlertGroupAchievements { get; set; }
        public virtual DbSet<OldHrmAlertGroupIndisciplines> OldHrmAlertGroupIndisciplines { get; set; }
        public virtual DbSet<OldHrmAlertGroupM> OldHrmAlertGroupM { get; set; }
        public virtual DbSet<OldHrmAttendance> OldHrmAttendance { get; set; }
        public virtual DbSet<OldHrmAttendanceUserM> OldHrmAttendanceUserM { get; set; }
        public virtual DbSet<OldHrmContactDetailsForApplicants> OldHrmContactDetailsForApplicants { get; set; }
        public virtual DbSet<OldHrmDesignationModuleRights> OldHrmDesignationModuleRights { get; set; }
        public virtual DbSet<OldHrmEmployeeAccessRightM> OldHrmEmployeeAccessRightM { get; set; }
        public virtual DbSet<OldHrmEmployeeIndisciplineFieldsD> OldHrmEmployeeIndisciplineFieldsD { get; set; }
        public virtual DbSet<OldHrmEmployeeModuleRights> OldHrmEmployeeModuleRights { get; set; }
        public virtual DbSet<OldHrmEmployeeTargets> OldHrmEmployeeTargets { get; set; }
        public virtual DbSet<OldHrmIndisciplineAlertsSent> OldHrmIndisciplineAlertsSent { get; set; }
        public virtual DbSet<OldHrmIndisciplineEntryD> OldHrmIndisciplineEntryD { get; set; }
        public virtual DbSet<OldHrmIndisciplineEntryM> OldHrmIndisciplineEntryM { get; set; }
        public virtual DbSet<OldHrmIndisciplineStatusM> OldHrmIndisciplineStatusM { get; set; }
        public virtual DbSet<OldHrmIndisciplineTypeFieldsD> OldHrmIndisciplineTypeFieldsD { get; set; }
        public virtual DbSet<OldHrmIndisciplineTypeM> OldHrmIndisciplineTypeM { get; set; }
        public virtual DbSet<OldHrmIndisciplineTypePolicyD> OldHrmIndisciplineTypePolicyD { get; set; }
        public virtual DbSet<OldHrmIndisciplineTypeReviewActionD> OldHrmIndisciplineTypeReviewActionD { get; set; }
        public virtual DbSet<OldHrmLeaveTransactionD> OldHrmLeaveTransactionD { get; set; }
        public virtual DbSet<OldHrmLevelM> OldHrmLevelM { get; set; }
        public virtual DbSet<OldHrmPerformanceRecordD> OldHrmPerformanceRecordD { get; set; }
        public virtual DbSet<OldHrmPerformanceRecordM> OldHrmPerformanceRecordM { get; set; }
        public virtual DbSet<OldHrmPerformanceReviewers> OldHrmPerformanceReviewers { get; set; }
        public virtual DbSet<OldHrmPolicyAmendmentD> OldHrmPolicyAmendmentD { get; set; }
        public virtual DbSet<OldHrmPolicyCategoryM> OldHrmPolicyCategoryM { get; set; }
        public virtual DbSet<OldHrmPolicyM> OldHrmPolicyM { get; set; }
        public virtual DbSet<OldHrmPolicySectionD> OldHrmPolicySectionD { get; set; }
        public virtual DbSet<OldHrmReviewActionM> OldHrmReviewActionM { get; set; }
        public virtual DbSet<OldHrmReviewM> OldHrmReviewM { get; set; }
        public virtual DbSet<OldHrmRoadmapReviewLog> OldHrmRoadmapReviewLog { get; set; }
        public virtual DbSet<OldHrmRoadmapSkills> OldHrmRoadmapSkills { get; set; }
        public virtual DbSet<OldHrmRoadmapSteps> OldHrmRoadmapSteps { get; set; }
        public virtual DbSet<OldHrmRoadmapTargets> OldHrmRoadmapTargets { get; set; }
        public virtual DbSet<OldHrmSalaryFieldConfig> OldHrmSalaryFieldConfig { get; set; }
        public virtual DbSet<OldHrmSkillPreferenceM> OldHrmSkillPreferenceM { get; set; }
        public virtual DbSet<OldHrmStandardInstructionForJobApplication> OldHrmStandardInstructionForJobApplication { get; set; }
        public virtual DbSet<OldHrmTargetTypeM> OldHrmTargetTypeM { get; set; }
        public virtual DbSet<OldMktAutoQuoteBandM> OldMktAutoQuoteBandM { get; set; }
        public virtual DbSet<OldMktAutoQuoteSetupChargesM> OldMktAutoQuoteSetupChargesM { get; set; }
        public virtual DbSet<OldMktCustomerRegistrationM> OldMktCustomerRegistrationM { get; set; }
        public virtual DbSet<OldMktPotermsM> OldMktPotermsM { get; set; }
        public virtual DbSet<OldMktQuotationBaseRatesD> OldMktQuotationBaseRatesD { get; set; }
        public virtual DbSet<OldMktQuotationParametersD> OldMktQuotationParametersD { get; set; }
        public virtual DbSet<OldMktQuotationRatesD> OldMktQuotationRatesD { get; set; }
        public virtual DbSet<OldMktQuotationRatesM> OldMktQuotationRatesM { get; set; }
        public virtual DbSet<OldMktQuotationTermsM> OldMktQuotationTermsM { get; set; }
        public virtual DbSet<OldMktQuoteRateListTermsD> OldMktQuoteRateListTermsD { get; set; }
        public virtual DbSet<OldMtlDeliveryChallanReturnM> OldMtlDeliveryChallanReturnM { get; set; }
        public virtual DbSet<OldOldActPaymentSendD> OldOldActPaymentSendD { get; set; }
        public virtual DbSet<OldOldActPaymentSendM> OldOldActPaymentSendM { get; set; }
        public virtual DbSet<OldPrdProductParameterM> OldPrdProductParameterM { get; set; }
        public virtual DbSet<OldPrdStatusM> OldPrdStatusM { get; set; }
        public virtual DbSet<OldPrdSubsidiaryProductTypeD> OldPrdSubsidiaryProductTypeD { get; set; }
        public virtual DbSet<OldPrdTravelerCardComponentM> OldPrdTravelerCardComponentM { get; set; }
        public virtual DbSet<OldPrdWorkOrderEmployeeD> OldPrdWorkOrderEmployeeD { get; set; }
        public virtual DbSet<OldServiceM> OldServiceM { get; set; }
        public virtual DbSet<OldServiceTypeM> OldServiceTypeM { get; set; }
        public virtual DbSet<PrdAcceptableProcessFlowD> PrdAcceptableProcessFlowD { get; set; }
        public virtual DbSet<PrdAcceptableProcessFlowM> PrdAcceptableProcessFlowM { get; set; }
        public virtual DbSet<PrdFamilyConfigurationCustomerProduct> PrdFamilyConfigurationCustomerProduct { get; set; }
        public virtual DbSet<PrdFieldConfigurationCustomerProduct> PrdFieldConfigurationCustomerProduct { get; set; }
        public virtual DbSet<PrdFreeProcessSteps> PrdFreeProcessSteps { get; set; }
        public virtual DbSet<PrdHrmProcessGroups> PrdHrmProcessGroups { get; set; }
        public virtual DbSet<PrdHrmProcessSteps> PrdHrmProcessSteps { get; set; }
        public virtual DbSet<PrdMaintenanceParameterM> PrdMaintenanceParameterM { get; set; }
        public virtual DbSet<PrdMaintenanceParameterReadingD> PrdMaintenanceParameterReadingD { get; set; }
        public virtual DbSet<PrdMaintenanceParameterReadingM> PrdMaintenanceParameterReadingM { get; set; }
        public virtual DbSet<PrdMaintenanceParametersD> PrdMaintenanceParametersD { get; set; }
        public virtual DbSet<PrdOutputTypeM> PrdOutputTypeM { get; set; }
        public virtual DbSet<PrdParameterM> PrdParameterM { get; set; }
        public virtual DbSet<PrdPlantM> PrdPlantM { get; set; }
        public virtual DbSet<PrdProcessGroupM> PrdProcessGroupM { get; set; }
        public virtual DbSet<PrdProcessParameterReadingD> PrdProcessParameterReadingD { get; set; }
        public virtual DbSet<PrdProcessParameterReadingM> PrdProcessParameterReadingM { get; set; }
        public virtual DbSet<PrdProcessParametersD> PrdProcessParametersD { get; set; }
        public virtual DbSet<PrdProcessStepByproducts> PrdProcessStepByproducts { get; set; }
        public virtual DbSet<PrdProcessStepM> PrdProcessStepM { get; set; }
        public virtual DbSet<PrdProcessStepMaintenance> PrdProcessStepMaintenance { get; set; }
        public virtual DbSet<PrdProcessStepMaintenanceH> PrdProcessStepMaintenanceH { get; set; }
        public virtual DbSet<PrdProcessStepOutputTypes> PrdProcessStepOutputTypes { get; set; }
        public virtual DbSet<PrdProcessStepTimingM> PrdProcessStepTimingM { get; set; }
        public virtual DbSet<PrdProcessWiseFieldGroupsD> PrdProcessWiseFieldGroupsD { get; set; }
        public virtual DbSet<PrdProductByproduct> PrdProductByproduct { get; set; }
        public virtual DbSet<PrdProductFamilyProcessStepByproducts> PrdProductFamilyProcessStepByproducts { get; set; }
        public virtual DbSet<PrdProductFamilyProcessStepCapacityD> PrdProductFamilyProcessStepCapacityD { get; set; }
        public virtual DbSet<PrdProductFamilyProcessStepRawMaterials> PrdProductFamilyProcessStepRawMaterials { get; set; }
        public virtual DbSet<PrdProductFamilyProcessSteps> PrdProductFamilyProcessSteps { get; set; }
        public virtual DbSet<PrdProductFamilyProcessStepSubAssemblies> PrdProductFamilyProcessStepSubAssemblies { get; set; }
        public virtual DbSet<PrdProductMaterialUsageM> PrdProductMaterialUsageM { get; set; }
        public virtual DbSet<PrdProductProcessFlow> PrdProductProcessFlow { get; set; }
        public virtual DbSet<PrdProductSubAssemblies> PrdProductSubAssemblies { get; set; }
        public virtual DbSet<PrdRemediesM> PrdRemediesM { get; set; }
        public virtual DbSet<PrdResponsibleMaterialD> PrdResponsibleMaterialD { get; set; }
        public virtual DbSet<PrdWorkOrderD> PrdWorkOrderD { get; set; }
        public virtual DbSet<PrdWorkOrderEmpWorkHours> PrdWorkOrderEmpWorkHours { get; set; }
        public virtual DbSet<PrdWorkOrderFieldD> PrdWorkOrderFieldD { get; set; }
        public virtual DbSet<PrdWorkOrderFinishedGoodD> PrdWorkOrderFinishedGoodD { get; set; }
        public virtual DbSet<PrdWorkOrderGroupM> PrdWorkOrderGroupM { get; set; }
        public virtual DbSet<PrdWorkOrderM> PrdWorkOrderM { get; set; }
        public virtual DbSet<PrdWorkOrderMachineD> PrdWorkOrderMachineD { get; set; }
        public virtual DbSet<PrdWorkOrderMaterialD> PrdWorkOrderMaterialD { get; set; }
        public virtual DbSet<PrdWorkOrderMaterialDetailLogD> PrdWorkOrderMaterialDetailLogD { get; set; }
        public virtual DbSet<PrdWorkOrderMaterialRecoverD> PrdWorkOrderMaterialRecoverD { get; set; }
        public virtual DbSet<PrdWorkOrderMaterialTransferD> PrdWorkOrderMaterialTransferD { get; set; }
        public virtual DbSet<PrdWorkOrderMultiValueFieldD> PrdWorkOrderMultiValueFieldD { get; set; }
        public virtual DbSet<PrdWorkOrderNotes> PrdWorkOrderNotes { get; set; }
        public virtual DbSet<PrdWorkOrderPauses> PrdWorkOrderPauses { get; set; }
        public virtual DbSet<PrdWorkOrderPlan> PrdWorkOrderPlan { get; set; }
        public virtual DbSet<PrdWorkOrderPos> PrdWorkOrderPos { get; set; }
        public virtual DbSet<PrdWorkOrderProcesses> PrdWorkOrderProcesses { get; set; }
        public virtual DbSet<PrdWorkOrderProcessQaD> PrdWorkOrderProcessQaD { get; set; }
        public virtual DbSet<PrdWorkOrderProcessQaIdealD> PrdWorkOrderProcessQaIdealD { get; set; }
        public virtual DbSet<PrdWorkOrderProcessQaIdealM> PrdWorkOrderProcessQaIdealM { get; set; }
        public virtual DbSet<PrdWorkOrderProcessQaM> PrdWorkOrderProcessQaM { get; set; }
        public virtual DbSet<PrdWorkOrderSeries> PrdWorkOrderSeries { get; set; }
        public virtual DbSet<RightsAccount> RightsAccount { get; set; }
        public virtual DbSet<RightsAst> RightsAst { get; set; }
        public virtual DbSet<RightsAstOld> RightsAstOld { get; set; }
        public virtual DbSet<RightsDefaultPages> RightsDefaultPages { get; set; }
        public virtual DbSet<RightsFileTypes> RightsFileTypes { get; set; }
        public virtual DbSet<RightsHome> RightsHome { get; set; }
        public virtual DbSet<RightsHrm> RightsHrm { get; set; }
        public virtual DbSet<RightsHrmOld> RightsHrmOld { get; set; }
        public virtual DbSet<RightsMkt> RightsMkt { get; set; }
        public virtual DbSet<RightsMktOld> RightsMktOld { get; set; }
        public virtual DbSet<RightsMtl> RightsMtl { get; set; }
        public virtual DbSet<RightsMtlOld> RightsMtlOld { get; set; }
        public virtual DbSet<RightsMyStuff> RightsMyStuff { get; set; }
        public virtual DbSet<RightsPrd> RightsPrd { get; set; }
        public virtual DbSet<RightsPrdOld> RightsPrdOld { get; set; }
        public virtual DbSet<RoleM> RoleM { get; set; }
        public virtual DbSet<StateM> StateM { get; set; }
        public virtual DbSet<TermsCategoryM> TermsCategoryM { get; set; }
        public virtual DbSet<UnitCategoryM> UnitCategoryM { get; set; }
        public virtual DbSet<UnitM> UnitM { get; set; }
        public virtual DbSet<UserH> UserH { get; set; }
        public virtual DbSet<UserM> UserM { get; set; }
        public virtual DbSet<WebPageM> WebPageM { get; set; }
        public virtual DbSet<WipbalanceM> WipbalanceM { get; set; }

        // Unable to generate entity type for table 'dbo.MKT_GenieMailRecipient_D'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Old_HRM_EmployeeEvent_M'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Old_Old_userreg'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Old_tmp_Tally_AccountIntegration'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.HRM_ConfInputCfg'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Old_HRM_EmployeeEvent_D'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.MKT_Feedback_Praise'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.AST_PossibleRepair_D'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Old_SalaryComponent_M'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Old_SalaryDeduction_M'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.MKT_AutoQuote_CntRange'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.MKT_AutoQuote_Fields'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Old_MTL_DeliveryChallan_Return_D'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.MKT_AutoQuote_Measure'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.MKT_AutoQuote_BaseRate'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.ACC_PaymentSchedule'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Year_M'. Please see the warning messages.

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer(@"Data Source=Shivangini;Initial Catalog= DevERP;Integrated Security=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AccConfigM>(entity =>
            {
                entity.HasKey(e => e.FieldId);

                entity.ToTable("ACC_Config_M");

                entity.Property(e => e.FieldId).HasColumnName("FieldID");

                entity.Property(e => e.CreatedDt)
                    .HasColumnName("CreatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedUserId).HasColumnName("CreatedUserID");

                entity.Property(e => e.Field)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedDt)
                    .HasColumnName("UpdatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdatedUserId).HasColumnName("UpdatedUserID");

                entity.Property(e => e.Value)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AccFavoriteGroupsLedgers>(entity =>
            {
                entity.HasKey(e => e.FavoriteId);

                entity.ToTable("ACC_FavoriteGroupsLedgers");

                entity.Property(e => e.FavoriteId).HasColumnName("FavoriteID");

                entity.Property(e => e.CreatedDt)
                    .HasColumnName("CreatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FavoriteGroupId).HasColumnName("FavoriteGroupID");

                entity.Property(e => e.FavoriteLedgerId).HasColumnName("FavoriteLedgerID");

                entity.Property(e => e.OriginalLedgerId).HasColumnName("OriginalLedgerID");

                entity.Property(e => e.UserId).HasColumnName("UserID");
            });

            modelBuilder.Entity<AccGroups>(entity =>
            {
                entity.HasKey(e => e.GroupId);

                entity.ToTable("ACC_Groups");

                entity.Property(e => e.GroupId).HasColumnName("GroupID");

                entity.Property(e => e.AccType)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.AssetCategoryId).HasColumnName("AssetCategoryID");

                entity.Property(e => e.AssetTypeId).HasColumnName("AssetTypeID");

                entity.Property(e => e.BudgetAmount)
                    .HasColumnName("Budget_Amount")
                    .HasColumnType("money");

                entity.Property(e => e.CompanyCategoryId).HasColumnName("CompanyCategoryID");

                entity.Property(e => e.CreatedDt)
                    .HasColumnName("CreatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedUserId).HasColumnName("CreatedUserID");

                entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Enforcement)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ErpOnly).HasColumnName("ERP_Only");

                entity.Property(e => e.GroupAlias)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.GroupName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.MaterialCategoryId).HasColumnName("MaterialCategoryID");

                entity.Property(e => e.ParentGroupId).HasColumnName("ParentGroupID");

                entity.Property(e => e.Position)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.PrefixForLedger)
                    .HasColumnName("Prefix_For_Ledger")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.PrefixForSubGroup)
                    .HasColumnName("Prefix_For_SubGroup")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedDt)
                    .HasColumnName("UpdatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdatedUserId).HasColumnName("UpdatedUserID");
            });

            modelBuilder.Entity<AccLedgers>(entity =>
            {
                entity.HasKey(e => e.LedgerId);

                entity.ToTable("ACC_Ledgers");

                entity.Property(e => e.LedgerId).HasColumnName("LedgerID");

                entity.Property(e => e.ApprovedDt)
                    .HasColumnName("ApprovedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ApprovedUserId).HasColumnName("ApprovedUserID");

                entity.Property(e => e.AssetId).HasColumnName("AssetID");

                entity.Property(e => e.BudgetAmount)
                    .HasColumnName("Budget_Amount")
                    .HasColumnType("money");

                entity.Property(e => e.CashBankId).HasColumnName("CashBankID");

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.CreatedDt)
                    .HasColumnName("CreatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedUserId).HasColumnName("CreatedUserID");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");

                entity.Property(e => e.Enforcement)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ErpOnly).HasColumnName("ERP_Only");

                entity.Property(e => e.GroupId).HasColumnName("GroupID");

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.LedgerAlias)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.LedgerName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.MaterialSubCategoryId).HasColumnName("MaterialSubCategoryID");

                entity.Property(e => e.MergedIntoLedgerId).HasColumnName("MergedIntoLedgerID");

                entity.Property(e => e.OpeningBalance).HasColumnType("money");

                entity.Property(e => e.ProjectId)
                    .HasColumnName("ProjectID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ResponsibleEmployeeId).HasColumnName("ResponsibleEmployeeID");

                entity.Property(e => e.ServiceId).HasColumnName("ServiceID");

                entity.Property(e => e.TaxId).HasColumnName("TaxID");

                entity.Property(e => e.UpdatedDt)
                    .HasColumnName("UpdatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdatedUserId).HasColumnName("UpdatedUserID");
            });

            modelBuilder.Entity<AccLedgersLimit>(entity =>
            {
                entity.HasKey(e => e.LimitId);

                entity.ToTable("ACC_Ledgers_Limit");

                entity.Property(e => e.LimitId).HasColumnName("LimitID");

                entity.Property(e => e.CreatedDt)
                    .HasColumnName("CreatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedUserId).HasColumnName("CreatedUserID");

                entity.Property(e => e.FromDate).HasColumnType("smalldatetime");

                entity.Property(e => e.LedgerId).HasColumnName("LedgerID");

                entity.Property(e => e.MaxLimit).HasColumnType("money");

                entity.Property(e => e.MinLimit).HasColumnType("money");

                entity.Property(e => e.OriginalLedgerId).HasColumnName("OriginalLedgerID");

                entity.Property(e => e.ToDate).HasColumnType("smalldatetime");

                entity.Property(e => e.UpdatedDt)
                    .HasColumnName("UpdatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdatedUserId).HasColumnName("UpdatedUserID");
            });

            modelBuilder.Entity<AccProjectD>(entity =>
            {
                entity.HasKey(e => e.ProjectDetailId);

                entity.ToTable("ACC_Project_D");

                entity.Property(e => e.ProjectDetailId).HasColumnName("ProjectDetailID");

                entity.Property(e => e.CreatedDt)
                    .HasColumnName("CreatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedUserId).HasColumnName("CreatedUserID");

                entity.Property(e => e.IsLedgerId)
                    .HasColumnName("IsLedgerID")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.LedgerId).HasColumnName("LedgerID");

                entity.Property(e => e.OriginalLedgerId).HasColumnName("OriginalLedgerID");

                entity.Property(e => e.ProjectId).HasColumnName("ProjectID");

                entity.Property(e => e.RoleBasisType)
                    .IsRequired()
                    .HasColumnType("char(1)");

                entity.Property(e => e.RolePercent).HasColumnName("Role_Percent");

                entity.Property(e => e.UpdatedDt)
                    .HasColumnName("UpdatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdatedUserId).HasColumnName("UpdatedUserID");
            });

            modelBuilder.Entity<AccProjectEntryM>(entity =>
            {
                entity.HasKey(e => e.ProjectId);

                entity.ToTable("ACC_ProjectEntry_M");

                entity.Property(e => e.ProjectId).HasColumnName("ProjectID");

                entity.Property(e => e.CreatedDt)
                    .HasColumnName("CreatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedUserId).HasColumnName("CreatedUserID");

                entity.Property(e => e.ProjectName)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.ProjectTypeId).HasColumnName("ProjectTypeID");

                entity.Property(e => e.UpdatedDt)
                    .HasColumnName("UpdatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdatedUserId).HasColumnName("UpdatedUserID");
            });

            modelBuilder.Entity<AccProjectM>(entity =>
            {
                entity.HasKey(e => e.ProjectId);

                entity.ToTable("ACC_Project_M");

                entity.Property(e => e.ProjectId).HasColumnName("ProjectID");

                entity.Property(e => e.CreatedDt)
                    .HasColumnName("CreatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedUserId).HasColumnName("CreatedUserID");

                entity.Property(e => e.Isshare).HasColumnName("ISshare");

                entity.Property(e => e.ProjectName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedDt)
                    .HasColumnName("UpdatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdatedUserId).HasColumnName("UpdatedUserID");
            });

            modelBuilder.Entity<AccProjectStockD>(entity =>
            {
                entity.HasKey(e => e.ProjectStockId);

                entity.ToTable("ACC_Project_Stock_D");

                entity.Property(e => e.ProjectStockId).HasColumnName("ProjectStockID");

                entity.Property(e => e.CategoryId).HasColumnName("CategoryID");

                entity.Property(e => e.CreatedDt)
                    .HasColumnName("CreatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedUserId).HasColumnName("CreatedUserID");

                entity.Property(e => e.MaterialId)
                    .HasColumnName("MaterialID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ProjectId).HasColumnName("ProjectID");

                entity.Property(e => e.RolePercent)
                    .HasColumnName("Role_Percent")
                    .HasColumnType("decimal(11, 2)");

                entity.Property(e => e.StockId)
                    .HasColumnName("StockID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.SubCategoryId)
                    .HasColumnName("SubCategoryID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.UpdatedDt)
                    .HasColumnName("UpdatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdatedUserId).HasColumnName("UpdatedUserID");
            });

            modelBuilder.Entity<AccProjectTypeM>(entity =>
            {
                entity.HasKey(e => e.ProjectTypeId);

                entity.ToTable("ACC_ProjectType_M");

                entity.Property(e => e.ProjectTypeId).HasColumnName("ProjectTypeID");

                entity.Property(e => e.CreatedDt)
                    .HasColumnName("CreatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedUserId).HasColumnName("CreatedUserID");

                entity.Property(e => e.ProjectTypeName)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedDt)
                    .HasColumnName("UpdatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdatedUserId).HasColumnName("UpdatedUserID");
            });

            modelBuilder.Entity<AccRatioD>(entity =>
            {
                entity.HasKey(e => e.RatioDetId);

                entity.ToTable("ACC_Ratio_D");

                entity.Property(e => e.RatioDetId).HasColumnName("RatioDetID");

                entity.Property(e => e.CreatedDt)
                    .HasColumnName("CreatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedUserId)
                    .HasColumnName("CreatedUserID")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.DenominatorOperator)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.DenominatorOrder).HasDefaultValueSql("((1))");

                entity.Property(e => e.LedgerGroupId)
                    .HasColumnName("LedgerGroupID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.NumeratorOperator)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.NumeratorOrder).HasDefaultValueSql("((1))");

                entity.Property(e => e.OriginalLedgerId).HasColumnName("OriginalLedgerID");

                entity.Property(e => e.RatioId)
                    .HasColumnName("RatioID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.UpdatedDt)
                    .HasColumnName("UpdatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdatedUserId)
                    .HasColumnName("UpdatedUserID")
                    .HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<AccRatioM>(entity =>
            {
                entity.HasKey(e => e.RatioId);

                entity.ToTable("ACC_Ratio_M");

                entity.Property(e => e.RatioId).HasColumnName("RatioID");

                entity.Property(e => e.CreatedDt)
                    .HasColumnName("CreatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedUserId).HasColumnName("CreatedUserID");

                entity.Property(e => e.HealthyType)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.HealthyValue).HasDefaultValueSql("((0))");

                entity.Property(e => e.RatioName)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.RatioType)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.UnHealthyType)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.UnHealthyValue).HasDefaultValueSql("((0))");

                entity.Property(e => e.UpdatedDt)
                    .HasColumnName("UpdatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdatedUserId).HasColumnName("UpdatedUserID");
            });

            modelBuilder.Entity<AccStockStatusD>(entity =>
            {
                entity.HasKey(e => e.StockStatusDetId);

                entity.ToTable("ACC_StockStatus_D");

                entity.Property(e => e.StockStatusDetId).HasColumnName("StockStatusDetID");

                entity.Property(e => e.CreatedDt)
                    .HasColumnName("CreatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedUserId).HasColumnName("CreatedUserID");

                entity.Property(e => e.Item)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.StockStatusId).HasColumnName("StockStatusID");

                entity.Property(e => e.UpdatedDt)
                    .HasColumnName("UpdatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdatedUserId).HasColumnName("UpdatedUserID");
            });

            modelBuilder.Entity<AccStockStatusM>(entity =>
            {
                entity.HasKey(e => e.StockStatusId);

                entity.ToTable("ACC_StockStatus_M");

                entity.Property(e => e.StockStatusId).HasColumnName("StockStatusID");

                entity.Property(e => e.CreatedDt)
                    .HasColumnName("CreatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedUserId).HasColumnName("CreatedUserID");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Reference)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.StockStatusDt)
                    .HasColumnName("StockStatusDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdatedDt)
                    .HasColumnName("UpdatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdatedUserId).HasColumnName("UpdatedUserID");

                entity.Property(e => e.VoucherId)
                    .HasColumnName("VoucherID")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<AccTransferMode>(entity =>
            {
                entity.HasKey(e => e.TransferModeId);

                entity.ToTable("ACC_TransferMode");

                entity.Property(e => e.TransferModeId).HasColumnName("TransferModeID");

                entity.Property(e => e.CreatedDt)
                    .HasColumnName("CreatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedUserId).HasColumnName("CreatedUserID");

                entity.Property(e => e.TransferMode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedDt)
                    .HasColumnName("UpdatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdatedUserId).HasColumnName("UpdatedUserID");
            });

            modelBuilder.Entity<AccVoucherFormatM>(entity =>
            {
                entity.HasKey(e => e.FormatId);

                entity.ToTable("ACC_VoucherFormat_M");

                entity.Property(e => e.FormatId).HasColumnName("FormatID");

                entity.Property(e => e.AllowPaymentSchedule)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CreatedDt)
                    .HasColumnName("CreatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedUserId)
                    .HasColumnName("CreatedUserID")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.FormatName)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.FormatStyle)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.UpdatedDt)
                    .HasColumnName("UpdatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdatedUserId)
                    .HasColumnName("UpdatedUserID")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.VoucherTypeId)
                    .HasColumnName("VoucherTypeID")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<AccVoucherFormatTableD>(entity =>
            {
                entity.HasKey(e => e.FormatTableDetId);

                entity.ToTable("ACC_VoucherFormat_Table_D");

                entity.Property(e => e.FormatTableDetId).HasColumnName("FormatTableDetID");

                entity.Property(e => e.CreatedDt)
                    .HasColumnName("CreatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedUserId)
                    .HasColumnName("CreatedUserID")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.FormatId).HasColumnName("FormatID");

                entity.Property(e => e.FormatTableId).HasColumnName("FormatTableID");

                entity.Property(e => e.GroupId).HasColumnName("GroupID");

                entity.Property(e => e.UpdatedDt)
                    .HasColumnName("UpdatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdatedUserId)
                    .HasColumnName("UpdatedUserID")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.VoucherTypeId)
                    .HasColumnName("VoucherTypeID")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<AccVoucherFormatTableM>(entity =>
            {
                entity.HasKey(e => e.FormatTableId);

                entity.ToTable("ACC_VoucherFormat_Table_M");

                entity.Property(e => e.FormatTableId).HasColumnName("FormatTableID");

                entity.Property(e => e.CreatedDt)
                    .HasColumnName("CreatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedUserId)
                    .HasColumnName("CreatedUserID")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.FormatId).HasColumnName("FormatID");

                entity.Property(e => e.MinEntryValidation).HasDefaultValueSql("((0))");

                entity.Property(e => e.TableTitle)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TableType)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.UpdatedDt)
                    .HasColumnName("UpdatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdatedUserId)
                    .HasColumnName("UpdatedUserID")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.VoucherTypeId)
                    .HasColumnName("VoucherTypeID")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<AccVoucherItemD>(entity =>
            {
                entity.HasKey(e => e.VoucherItemDetId);

                entity.ToTable("ACC_VoucherItem_D");

                entity.Property(e => e.VoucherItemDetId).HasColumnName("VoucherItemDetID");

                entity.Property(e => e.CreatedDt)
                    .HasColumnName("CreatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedUserId).HasColumnName("CreatedUserID");

                entity.Property(e => e.InvoiceDetId).HasColumnName("InvoiceDetID");

                entity.Property(e => e.LedgerId).HasColumnName("LedgerID");

                entity.Property(e => e.MaterialReceiveDetailId).HasColumnName("MaterialReceiveDetailID");

                entity.Property(e => e.Notes)
                    .IsRequired()
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.OriginalLedgerId).HasColumnName("OriginalLedgerID");

                entity.Property(e => e.Rate).HasColumnType("money");

                entity.Property(e => e.UpdatedDt)
                    .HasColumnName("UpdatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdatedUserId).HasColumnName("UpdatedUserID");

                entity.Property(e => e.VoucherDetId).HasColumnName("VoucherDetID");

                entity.Property(e => e.VoucherId).HasColumnName("VoucherID");

                entity.Property(e => e.VoucherItem)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AccVoucherProject>(entity =>
            {
                entity.HasKey(e => e.VoucherProjectId);

                entity.ToTable("ACC_VoucherProject");

                entity.Property(e => e.VoucherProjectId).HasColumnName("VoucherProjectID");

                entity.Property(e => e.Amount).HasColumnType("money");

                entity.Property(e => e.CreatedDt)
                    .HasColumnName("CreatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedUserId)
                    .HasColumnName("CreatedUserID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ProjectId).HasColumnName("ProjectID");

                entity.Property(e => e.UpdatedDt)
                    .HasColumnName("UpdatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdatedUserId)
                    .HasColumnName("UpdatedUserID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.VoucherDetId).HasColumnName("VoucherDetID");
            });

            modelBuilder.Entity<AccVouchersClassification>(entity =>
            {
                entity.HasKey(e => e.VoucherClassificationId);

                entity.ToTable("ACC_Vouchers_Classification");

                entity.Property(e => e.VoucherClassificationId).HasColumnName("VoucherClassificationID");

                entity.Property(e => e.CreatedDt)
                    .HasColumnName("CreatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedUserId).HasColumnName("CreatedUserID");

                entity.Property(e => e.UpdatedDt)
                    .HasColumnName("UpdatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdatedUserId).HasColumnName("UpdatedUserID");

                entity.Property(e => e.VoucherClassificationName)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AccVouchersD>(entity =>
            {
                entity.HasKey(e => e.VoucherDetId);

                entity.ToTable("ACC_Vouchers_D");

                entity.Property(e => e.VoucherDetId).HasColumnName("VoucherDetID");

                entity.Property(e => e.CrAmount).HasColumnType("money");

                entity.Property(e => e.DbAmount).HasColumnType("money");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.InvoiceId)
                    .HasColumnName("InvoiceID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.InvoiceNum)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.LedgerId).HasColumnName("LedgerID");

                entity.Property(e => e.OriginalLedgerId).HasColumnName("OriginalLedgerID");

                entity.Property(e => e.PlanDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Reference)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TransferModeId).HasColumnName("TransferModeID");

                entity.Property(e => e.VoucherId).HasColumnName("VoucherID");
            });

            modelBuilder.Entity<AccVouchersM>(entity =>
            {
                entity.HasKey(e => e.VoucherId);

                entity.ToTable("ACC_Vouchers_M");

                entity.Property(e => e.VoucherId).HasColumnName("VoucherID");

                entity.Property(e => e.ApprovedDt)
                    .HasColumnName("ApprovedDT")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.ApprovedUserId).HasColumnName("ApprovedUserID");

                entity.Property(e => e.BillNum)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ChequeName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ChildVoucherId).HasColumnName("ChildVoucherID");

                entity.Property(e => e.CreatedDt)
                    .HasColumnName("CreatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedUserId).HasColumnName("CreatedUserID");

                entity.Property(e => e.CustomerReturnId)
                    .HasColumnName("CustomerReturnID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.EntrySourceErp).HasColumnName("EntrySourceERP");

                entity.Property(e => e.InvoiceDt)
                    .HasColumnName("InvoiceDT")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.InvoiceId)
                    .HasColumnName("InvoiceID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.InvoiceNum)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.MachineRepairId)
                    .HasColumnName("MachineRepairID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.MaintainanceId)
                    .HasColumnName("MaintainanceID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.MaterialReceiveId)
                    .HasColumnName("MaterialReceiveID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.PaymentDueDate).HasColumnType("smalldatetime");

                entity.Property(e => e.PaymentId)
                    .HasColumnName("PaymentID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.PaymentSendId)
                    .HasColumnName("PaymentSendID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.PlanDate).HasColumnType("smalldatetime");

                entity.Property(e => e.ReconciledDt)
                    .HasColumnName("ReconciledDT")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.ReconciledUserId).HasColumnName("ReconciledUserID");

                entity.Property(e => e.ReconciliationDate).HasColumnType("smalldatetime");

                entity.Property(e => e.ScrapInvoiceId)
                    .HasColumnName("ScrapInvoiceID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ServiceInvoiceId)
                    .HasColumnName("ServiceInvoiceID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TransactionId)
                    .HasColumnName("TransactionID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.UpdatedDt)
                    .HasColumnName("UpdatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdatedUserId).HasColumnName("UpdatedUserID");

                entity.Property(e => e.VoucherDate).HasColumnType("smalldatetime");

                entity.Property(e => e.VoucherFullNum)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.VoucherTypeId).HasColumnName("VoucherTypeID");
            });

            modelBuilder.Entity<AccVoucherTypes>(entity =>
            {
                entity.HasKey(e => e.VoucherTypeId);

                entity.ToTable("ACC_VoucherTypes");

                entity.Property(e => e.VoucherTypeId).HasColumnName("VoucherTypeID");

                entity.Property(e => e.CreatedDt)
                    .HasColumnName("CreatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedUserId).HasColumnName("CreatedUserID");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.FormatId)
                    .HasColumnName("FormatID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Prefix)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Suffix)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.UpdatedDt)
                    .HasColumnName("UpdatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdatedUserId).HasColumnName("UpdatedUserID");

                entity.Property(e => e.VoucherClassificationId)
                    .HasColumnName("VoucherClassificationID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.VoucherTypeName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AccVoucherTypesOptionNames>(entity =>
            {
                entity.HasKey(e => e.OptionId);

                entity.ToTable("ACC_VoucherTypes_OptionNames");

                entity.Property(e => e.OptionId).HasColumnName("OptionID");

                entity.Property(e => e.CreatedDt)
                    .HasColumnName("CreatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedUserId).HasColumnName("CreatedUserID");

                entity.Property(e => e.OptionNameToDisplay)
                    .IsRequired()
                    .HasColumnName("OptionNameTo_Display")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedDt)
                    .HasColumnName("UpdatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdatedUserId).HasColumnName("UpdatedUserID");

                entity.Property(e => e.VoucherTypeId).HasColumnName("VoucherTypeID");
            });

            modelBuilder.Entity<ActCashBankAccountM>(entity =>
            {
                entity.HasKey(e => e.CashBankAccountId);

                entity.ToTable("ACT_CashBankAccount_M");

                entity.Property(e => e.CashBankAccountId).HasColumnName("CashBankAccountID");

                entity.Property(e => e.AccountNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AccountType)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CashBankAccountName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDt)
                    .HasColumnName("CreatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.LedgerId).HasColumnName("LedgerID");

                entity.Property(e => e.UpdatedDt)
                    .HasColumnName("UpdatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<ActDeliveryChallanD>(entity =>
            {
                entity.HasKey(e => e.DeliveryChallanDetId);

                entity.ToTable("ACT_DeliveryChallan_D");

                entity.Property(e => e.DeliveryChallanDetId).HasColumnName("DeliveryChallanDetID");

                entity.Property(e => e.BatchNo)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.BrandId).HasColumnName("BrandID");

                entity.Property(e => e.Charge1Name)
                    .HasColumnName("Charge1_Name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Charge2Name)
                    .HasColumnName("Charge2_Name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Charge3Name)
                    .HasColumnName("Charge3_Name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Charge4Name)
                    .HasColumnName("Charge4_Name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDt)
                    .HasColumnName("CreatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedUserId).HasColumnName("CreatedUserID");

                entity.Property(e => e.DeliveryChallanId).HasColumnName("DeliveryChallanID");

                entity.Property(e => e.MaterialId).HasColumnName("MaterialID");

                entity.Property(e => e.MaterialTransactionId).HasColumnName("MaterialTransactionID");

                entity.Property(e => e.PackageDesc)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Pcbdesc)
                    .HasColumnName("PCBDesc")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PoitemId).HasColumnName("POItemID");

                entity.Property(e => e.SalesDeliveryUnitQty).HasColumnName("SalesDeliveryUnit_Qty");

                entity.Property(e => e.SalesDeliveryUnitUnitId).HasColumnName("SalesDeliveryUnit_UnitID");

                entity.Property(e => e.SkuUnitId).HasColumnName("SKU_UnitID");

                entity.Property(e => e.UpdatedDt)
                    .HasColumnName("UpdatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdatedUserId).HasColumnName("UpdatedUserID");
            });

            modelBuilder.Entity<ActDeliveryChallanItemD>(entity =>
            {
                entity.HasKey(e => e.DeliveryItemId);

                entity.ToTable("ACT_DeliveryChallanItem_D");

                entity.Property(e => e.DeliveryItemId).HasColumnName("DeliveryItemID");

                entity.Property(e => e.BoxSizeHeight).HasColumnName("BoxSize_Height");

                entity.Property(e => e.BoxSizeLength).HasColumnName("BoxSize_Length");

                entity.Property(e => e.BoxSizeUnit)
                    .IsRequired()
                    .HasColumnName("Box_Size_Unit")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.BoxSizeWidth).HasColumnName("BoxSize_Width");

                entity.Property(e => e.BoxWeightUnit)
                    .IsRequired()
                    .HasColumnName("BoxWeight_Unit")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDt)
                    .HasColumnName("CreatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedUserId).HasColumnName("CreatedUserID");

                entity.Property(e => e.DeliveryBoxName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DeliveryChallanId).HasColumnName("DeliveryChallanID");

                entity.Property(e => e.GrossWeightUnit)
                    .IsRequired()
                    .HasColumnName("GrossWeight_Unit")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PackedQtyInSkuunit).HasColumnName("PackedQtyInSKUUnit");

                entity.Property(e => e.Poid)
                    .HasColumnName("POID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.Property(e => e.UpdatedDt)
                    .HasColumnName("UpdatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdatedUserId).HasColumnName("UpdatedUserID");
            });

            modelBuilder.Entity<ActDeliveryChallanM>(entity =>
            {
                entity.HasKey(e => e.DeliveryChallanId);

                entity.ToTable("ACT_DeliveryChallan_M");

                entity.Property(e => e.DeliveryChallanId).HasColumnName("DeliveryChallanID");

                entity.Property(e => e.ActDeliverySerialNum).HasColumnName("ACT_Delivery_serialNum");

                entity.Property(e => e.AddressTypeId)
                    .HasColumnName("AddressTypeID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.BoxType)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ContactId)
                    .HasColumnName("ContactID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CreatedDt)
                    .HasColumnName("CreatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedUserId).HasColumnName("CreatedUserID");

                entity.Property(e => e.CurrencyId).HasColumnName("CurrencyID");

                entity.Property(e => e.CustomerId).HasColumnName("CustomerID");

                entity.Property(e => e.CustomerSBankName)
                    .IsRequired()
                    .HasColumnName("Customer'sBankName")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.DefaultCurrencyId).HasColumnName("DefaultCurrencyID");

                entity.Property(e => e.DeliveryAddress)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.DeliveryChallanDate).HasColumnType("smalldatetime");

                entity.Property(e => e.DeliveryChallanNum)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DeliveryDt)
                    .HasColumnName("DeliveryDT")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DeliveryReceiveDt)
                    .HasColumnName("DeliveryReceiveDT")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.GoodsDispatchedFrom)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.IsDirectDeliveryDispatch).HasColumnName("IsDirectDelivery_Dispatch");

                entity.Property(e => e.IsRoundoff).HasDefaultValueSql("((1))");

                entity.Property(e => e.PackingListNum)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PaymentMode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.PaymentTerms)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.PlantId).HasColumnName("PlantID");

                entity.Property(e => e.Poinfo)
                    .HasColumnName("POInfo")
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.PreCarriagePlace)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Remarks)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.RemovalofGoodsDt)
                    .HasColumnName("RemovalofGoodsDT")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.ShipperId).HasColumnName("ShipperID");

                entity.Property(e => e.TrackingNumDelivery)
                    .HasColumnName("TrackingNum_Delivery")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.TransportMode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TransportModeDetails)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.UpdatedDt)
                    .HasColumnName("UpdatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdatedUserId).HasColumnName("UpdatedUserID");
            });

            modelBuilder.Entity<ActDeliveryChallanQtyD>(entity =>
            {
                entity.HasKey(e => e.DeliveryChallanQtyId);

                entity.ToTable("ACT_DeliveryChallanQty_D");

                entity.Property(e => e.DeliveryChallanQtyId).HasColumnName("DeliveryChallanQtyID");

                entity.Property(e => e.BatchNo)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BrandId).HasColumnName("BrandID");

                entity.Property(e => e.DeliveryChallanDetId).HasColumnName("DeliveryChallanDetID");

                entity.Property(e => e.ExpireDt)
                    .HasColumnName("ExpireDT")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.MaterialId).HasColumnName("MaterialID");

                entity.Property(e => e.SalesDeliveryUnitQty).HasColumnName("SalesDeliveryUnit_Qty");
            });

            modelBuilder.Entity<ActDeliveryTypeM>(entity =>
            {
                entity.HasKey(e => e.DeliveryTypeId);

                entity.ToTable("ACT_DeliveryType_M");

                entity.Property(e => e.DeliveryTypeId).HasColumnName("DeliveryTypeID");

                entity.Property(e => e.CreatedDt)
                    .HasColumnName("CreatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedUserId).HasColumnName("CreatedUserID");

                entity.Property(e => e.DeliveryTypeName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IsDeleted).HasDefaultValueSql("(0)");

                entity.Property(e => e.UpdatedDt)
                    .HasColumnName("UpdatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdatedUserId).HasColumnName("UpdatedUserID");
            });

            modelBuilder.Entity<ActInvoiceD>(entity =>
            {
                entity.HasKey(e => e.InvoiceDetId);

                entity.ToTable("ACT_Invoice_D");

                entity.Property(e => e.InvoiceDetId).HasColumnName("InvoiceDetID");

                entity.Property(e => e.CartonNum)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Charge1Name)
                    .HasColumnName("Charge1_Name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Charge2Name)
                    .HasColumnName("Charge2_Name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Charge3Name)
                    .HasColumnName("Charge3_Name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Charge4Name)
                    .HasColumnName("Charge4_Name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DeliveryChallanDetId).HasColumnName("DeliveryChallanDetID");

                entity.Property(e => e.DeliveryChallanId).HasColumnName("DeliveryChallanID");

                entity.Property(e => e.Discount).HasDefaultValueSql("((0))");

                entity.Property(e => e.FixedCharge1).HasDefaultValueSql("((0))");

                entity.Property(e => e.FixedCharge2).HasDefaultValueSql("((0))");

                entity.Property(e => e.FixedCharge3).HasDefaultValueSql("((0))");

                entity.Property(e => e.InvoiceId).HasColumnName("InvoiceID");

                entity.Property(e => e.LastPackedDt)
                    .HasColumnName("LastPackedDT")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.MaterialId).HasColumnName("MaterialID");

                entity.Property(e => e.Mrp)
                    .HasColumnName("MRP")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Mrpamount)
                    .HasColumnName("MRPAmount")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.NoOfBoxes)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.PackageDesc)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.PackedQty).HasDefaultValueSql("((0))");

                entity.Property(e => e.Pcbdesc)
                    .IsRequired()
                    .HasColumnName("PCBDesc")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.PoitemId).HasColumnName("POItemID");

                entity.Property(e => e.SalesDeliveryUnitQty).HasColumnName("SalesDeliveryUnit_Qty");

                entity.Property(e => e.SalesDeliveryUnitUnitId).HasColumnName("SalesDeliveryUnit_UnitID");

                entity.Property(e => e.ServiceId).HasColumnName("ServiceID");

                entity.Property(e => e.SkuUnitId).HasColumnName("SKU_UnitID");
            });

            modelBuilder.Entity<ActInvoiceItemD>(entity =>
            {
                entity.HasKey(e => e.InvoiceItemId);

                entity.ToTable("ACT_InvoiceItem_D");

                entity.Property(e => e.InvoiceItemId).HasColumnName("InvoiceItemID");

                entity.Property(e => e.BoxSizeHeight).HasColumnName("BoxSize_Height");

                entity.Property(e => e.BoxSizeLength).HasColumnName("BoxSize_Length");

                entity.Property(e => e.BoxSizeUnit)
                    .IsRequired()
                    .HasColumnName("Box_Size_Unit")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.BoxSizeWidth).HasColumnName("BoxSize_Width");

                entity.Property(e => e.BoxWeightUnit)
                    .IsRequired()
                    .HasColumnName("BoxWeight_Unit")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDt)
                    .HasColumnName("CreatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedUserId).HasColumnName("CreatedUserID");

                entity.Property(e => e.DeliveryBoxName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.GrossWeightUnit)
                    .IsRequired()
                    .HasColumnName("GrossWeight_Unit")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.InvoiceId).HasColumnName("InvoiceID");

                entity.Property(e => e.PackedQtyInSkuunit).HasColumnName("PackedQtyInSKUUnit");

                entity.Property(e => e.Poid)
                    .HasColumnName("POID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.Property(e => e.UpdatedDt)
                    .HasColumnName("UpdatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdatedUserId).HasColumnName("UpdatedUserID");
            });

            modelBuilder.Entity<ActInvoiceM>(entity =>
            {
                entity.HasKey(e => e.InvoiceId);

                entity.ToTable("ACT_Invoice_M");

                entity.Property(e => e.InvoiceId).HasColumnName("InvoiceID");

                entity.Property(e => e.ActInvoiceSerialNum).HasColumnName("ACT_Invoice_SerialNum");

                entity.Property(e => e.AdditionalVatpercent)
                    .HasColumnName("AdditionalVATPercent")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.AddressTypeId)
                    .HasColumnName("AddressTypeID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.BoxType)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.BoxWeight).HasDefaultValueSql("((0))");

                entity.Property(e => e.CentralExciseAgainst)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Coddays).HasColumnName("CODDays");

                entity.Property(e => e.ConsigneeRefNum)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ContactId)
                    .HasColumnName("ContactID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CreaditTo).HasDefaultValueSql("((0))");

                entity.Property(e => e.CreatedDt)
                    .HasColumnName("CreatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedUserId).HasColumnName("CreatedUserID");

                entity.Property(e => e.CurrencyId).HasColumnName("CurrencyID");

                entity.Property(e => e.CurrentConversionRate).HasDefaultValueSql("((1))");

                entity.Property(e => e.CustomerCstdate)
                    .HasColumnName("CustomerCSTDate")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.CustomerId).HasColumnName("CustomerID");

                entity.Property(e => e.CustomerSBankName)
                    .IsRequired()
                    .HasColumnName("Customer'sBankName")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.DefaultCurrencyId).HasColumnName("DefaultCurrencyID");

                entity.Property(e => e.DeliveryAddress)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.DeliveryAddress1)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.DeliveryAddress2)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.DeliveryChallanDate).HasColumnType("smalldatetime");

                entity.Property(e => e.DeliveryChallanNum)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DeliveryCity)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.DeliveryCountry)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.DeliveryDt)
                    .HasColumnName("DeliveryDT")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DeliveryPinCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.DeliveryState)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.DeliveryTerms)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.DimensionOfPackage)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.DiscountAmt).HasDefaultValueSql("((0))");

                entity.Property(e => e.DispatchDocNo)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.DutyDate)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EduCessPercent).HasDefaultValueSql("((0))");

                entity.Property(e => e.EduCessShpercent)
                    .HasColumnName("EduCessSHPercent")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ExciseDutyPercent).HasDefaultValueSql("((0))");

                entity.Property(e => e.ExciseTaxId).HasColumnName("ExciseTaxID");

                entity.Property(e => e.ExporterRefNum)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.FinalDestination)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.FreightTerms)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.FrightBeforeTax).HasDefaultValueSql("((0))");

                entity.Property(e => e.GoodsDispatchedFrom)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Insurance).HasDefaultValueSql("((0))");

                entity.Property(e => e.InvoiceDt)
                    .HasColumnName("InvoiceDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.InvoiceNum)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InvoiceReceiveDt)
                    .HasColumnName("InvoiceReceiveDT")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.InvoiceType)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.IsDirectDeliveryInvoice).HasColumnName("IsDirectDelivery_Invoice");

                entity.Property(e => e.IsFob).HasColumnName("IsFOB");

                entity.Property(e => e.IsRoundoff).HasDefaultValueSql("((1))");

                entity.Property(e => e.IsSez).HasColumnName("IsSEZ");

                entity.Property(e => e.LastAmountReceivedDt)
                    .HasColumnName("LastAmountReceivedDT")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.LessAdvance).HasDefaultValueSql("((0))");

                entity.Property(e => e.Ofnno)
                    .HasColumnName("OFNNo")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.OtherChargesBeforeTaxAmt).HasDefaultValueSql("((0))");

                entity.Property(e => e.OtherChargesBeforeTaxDesc)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.OtherChargesName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OtherChargesValue).HasDefaultValueSql("((0))");

                entity.Property(e => e.PartIi)
                    .HasColumnName("PartII")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PaymentDueDt)
                    .HasColumnName("PaymentDueDT")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.PaymentMode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PaymentTerms)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.PlantId)
                    .HasColumnName("PlantID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.PlaregEntry)
                    .HasColumnName("PLARegEntry")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PlaregEntryDate)
                    .HasColumnName("PLARegEntryDate")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.Poinfo)
                    .HasColumnName("POInfo")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.PortOfDischarge)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.PortOfLoading)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.PreCarriagePlace)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.QuotationNum)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ReceiptSupplierId)
                    .HasColumnName("Receipt_SupplierID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Remarks)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.RemovalofGoodsDt)
                    .HasColumnName("RemovalofGoodsDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Rg23)
                    .HasColumnName("RG23")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Rg23entryDate)
                    .HasColumnName("RG23EntryDate")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.SalesTaxId).HasColumnName("SalesTaxID");

                entity.Property(e => e.SalesTaxPercent).HasDefaultValueSql("((0))");

                entity.Property(e => e.ShipperId).HasColumnName("ShipperID");

                entity.Property(e => e.ShippingMark)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ShippingTerm)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TaxType)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.TcstaxPercent)
                    .HasColumnName("TCSTaxPercent")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TotalReceivedAmount).HasDefaultValueSql("((0))");

                entity.Property(e => e.TotalReceivedAmountInRs).HasDefaultValueSql("((0))");

                entity.Property(e => e.TrackingNumInvoice)
                    .HasColumnName("TrackingNum_Invoice")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.TransportMode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TransportModeDetails)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Type)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.VideDebitEntryNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.VoucherId)
                    .HasColumnName("VoucherID")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<ActInvoiceQtyD>(entity =>
            {
                entity.HasKey(e => e.InvoiceQtyId);

                entity.ToTable("ACT_InvoiceQty_D");

                entity.Property(e => e.InvoiceQtyId).HasColumnName("InvoiceQtyID");

                entity.Property(e => e.BatchNo)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BrandId).HasColumnName("BrandID");

                entity.Property(e => e.ExpireDt)
                    .HasColumnName("ExpireDT")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.InvoiceDetId).HasColumnName("InvoiceDetID");

                entity.Property(e => e.MaterialId).HasColumnName("MaterialID");

                entity.Property(e => e.SalesDeliveryUnitQty).HasColumnName("SalesDeliveryUnit_Qty");
            });

            modelBuilder.Entity<ActInvoiceTaxD>(entity =>
            {
                entity.HasKey(e => e.InvoiceTaxId);

                entity.ToTable("ACT_Invoice_Tax_D");

                entity.Property(e => e.InvoiceTaxId).HasColumnName("InvoiceTaxID");

                entity.Property(e => e.AppliedOnAmount).HasDefaultValueSql("((0))");

                entity.Property(e => e.CreatedDt)
                    .HasColumnName("CreatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedId).HasColumnName("CreatedID");

                entity.Property(e => e.InvoiceId).HasColumnName("InvoiceID");

                entity.Property(e => e.TaxId).HasColumnName("TaxID");

                entity.Property(e => e.UpdatedDt)
                    .HasColumnName("UpdatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdatedId).HasColumnName("UpdatedID");
            });

            modelBuilder.Entity<ActInvoiceTermD>(entity =>
            {
                entity.HasKey(e => e.InvoiceTermDetId);

                entity.ToTable("ACT_InvoiceTerm_D");

                entity.Property(e => e.InvoiceTermDetId).HasColumnName("InvoiceTermDetID");

                entity.Property(e => e.InvoiceId)
                    .HasColumnName("InvoiceID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.InvoiceTermId)
                    .HasColumnName("InvoiceTermID")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<ActPackingBoxM>(entity =>
            {
                entity.HasKey(e => e.PackingBoxId);

                entity.ToTable("ACT_PackingBox_M");

                entity.Property(e => e.PackingBoxId).HasColumnName("PackingBoxID");

                entity.Property(e => e.BoxName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BoxSizeHeight).HasColumnName("BoxSize_Height");

                entity.Property(e => e.BoxSizeLength).HasColumnName("BoxSize_Length");

                entity.Property(e => e.BoxSizeUnit)
                    .IsRequired()
                    .HasColumnName("BoxSize_Unit")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.BoxSizeWidth).HasColumnName("BoxSize_Width");

                entity.Property(e => e.BoxWeightUnit)
                    .IsRequired()
                    .HasColumnName("BoxWeight_Unit")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDt)
                    .HasColumnName("CreatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedUserId).HasColumnName("CreatedUserID");

                entity.Property(e => e.NoofBoxes)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedDt)
                    .HasColumnName("UpdatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdatedUserId).HasColumnName("UpdatedUserID");
            });

            modelBuilder.Entity<ActPackingListItemD>(entity =>
            {
                entity.HasKey(e => e.PackingListItemId);

                entity.ToTable("ACT_PackingListItem_D");

                entity.Property(e => e.PackingListItemId).HasColumnName("PackingListItemID");

                entity.Property(e => e.BoxName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDt)
                    .HasColumnName("CreatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedUserId).HasColumnName("CreatedUserID");

                entity.Property(e => e.GrossWeightUnit)
                    .IsRequired()
                    .HasColumnName("GrossWeight_Unit")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.InvoiceDetId)
                    .HasColumnName("InvoiceDetID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.IsPcbunit).HasColumnName("IsPCBUnit");

                entity.Property(e => e.Notes)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.PackingBoxId).HasColumnName("PackingBoxID");

                entity.Property(e => e.PackingListId).HasColumnName("PackingListID");

                entity.Property(e => e.Pcbdesc)
                    .IsRequired()
                    .HasColumnName("PCBDesc")
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.Property(e => e.UpdatedDt)
                    .HasColumnName("UpdatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdatedUserId).HasColumnName("UpdatedUserID");
            });

            modelBuilder.Entity<ActPackingListM>(entity =>
            {
                entity.HasKey(e => e.PackingListId);

                entity.ToTable("ACT_PackingList_M");

                entity.Property(e => e.PackingListId).HasColumnName("PackingListID");

                entity.Property(e => e.CountryofOrigin)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDt)
                    .HasColumnName("CreatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedUserId).HasColumnName("CreatedUserID");

                entity.Property(e => e.DeliveryAddress)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.DeliveryAddress1)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.DeliveryAddress2)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.DeliveryCity)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.DeliveryCountry)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DeliveryCountry1)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.DeliveryPinCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.DeliveryState)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.DeliveryTerms)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.FinalDestination)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Notes)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.PackingListNum)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PaymentTerms)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.PortofDischarge)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PortofLoading)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PreCarriagePlace)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.TransportModeId).HasColumnName("TransportModeID");

                entity.Property(e => e.UpdatedDt)
                    .HasColumnName("UpdatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdatedUserId).HasColumnName("UpdatedUserID");
            });

            modelBuilder.Entity<ActPaymentD>(entity =>
            {
                entity.HasKey(e => e.PaymentDetId);

                entity.ToTable("ACT_Payment_D");

                entity.Property(e => e.PaymentDetId).HasColumnName("PaymentDetID");

                entity.Property(e => e.Amount).HasDefaultValueSql("((0))");

                entity.Property(e => e.AmountDefaultCurrencyId).HasColumnName("Amount_DefaultCurrencyID");

                entity.Property(e => e.InvoiceId).HasColumnName("InvoiceID");

                entity.Property(e => e.PaymentId).HasColumnName("PaymentID");

                entity.Property(e => e.TotalFinalAmountInRsOld).HasColumnName("TotalFinalAmountInRs_old");
            });

            modelBuilder.Entity<ActPaymentM>(entity =>
            {
                entity.HasKey(e => e.PaymentId);

                entity.ToTable("ACT_Payment_M");

                entity.Property(e => e.PaymentId).HasColumnName("PaymentID");

                entity.Property(e => e.AmountForAdvanceOld)
                    .HasColumnName("AmountForAdvance_old")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ClosingAdvance).HasDefaultValueSql("((0))");

                entity.Property(e => e.CreatedDt)
                    .HasColumnName("CreatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedUserId).HasColumnName("CreatedUserID");

                entity.Property(e => e.CurrencyId).HasColumnName("CurrencyID");

                entity.Property(e => e.CurrentConversionRate).HasDefaultValueSql("((1))");

                entity.Property(e => e.CustomerId).HasColumnName("CustomerID");

                entity.Property(e => e.DefaultCurrencyId).HasColumnName("DefaultCurrencyID");

                entity.Property(e => e.OpeningAdvance).HasDefaultValueSql("((0))");

                entity.Property(e => e.PaymentDetail)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.PaymentReceiptNum)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PaymentReceiveLedgerId)
                    .HasColumnName("PaymentReceive_LedgerID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.PaymentTypeId)
                    .HasColumnName("PaymentTypeID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TotalAmountDefaultCurrencyId).HasColumnName("TotalAmount_DefaultCurrencyID");

                entity.Property(e => e.TotalFinalAmountInRsOld).HasColumnName("TotalFinalAmountInRs_old");

                entity.Property(e => e.VoucherId)
                    .HasColumnName("VoucherID")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<ActPaymentModeM>(entity =>
            {
                entity.HasKey(e => e.PaymentModeId);

                entity.ToTable("ACT_PaymentMode_M");

                entity.Property(e => e.PaymentModeId)
                    .HasColumnName("PaymentModeID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.CreatedDt)
                    .HasColumnName("CreatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedUserId).HasColumnName("CreatedUserID");

                entity.Property(e => e.DisplayName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PaymentModeName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedDt)
                    .HasColumnName("UpdatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdatedUserId).HasColumnName("UpdatedUserID");
            });

            modelBuilder.Entity<ActPaymentSendD>(entity =>
            {
                entity.HasKey(e => e.PaymentSendDetId);

                entity.ToTable("ACT_PaymentSend_D");

                entity.Property(e => e.PaymentSendDetId).HasColumnName("PaymentSendDetID");

                entity.Property(e => e.CreatedDt)
                    .HasColumnName("CreatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedUserId).HasColumnName("CreatedUserID");

                entity.Property(e => e.MaterialReceiveId).HasColumnName("MaterialReceiveID");

                entity.Property(e => e.PaidAmountDefaultCurr).HasColumnName("PaidAmount_DefaultCurr");

                entity.Property(e => e.PaymentSendId).HasColumnName("PaymentSendID");
            });

            modelBuilder.Entity<ActPaymentSendM>(entity =>
            {
                entity.HasKey(e => e.PaymentSendId);

                entity.ToTable("ACT_PaymentSend_M");

                entity.Property(e => e.PaymentSendId).HasColumnName("PaymentSendID");

                entity.Property(e => e.ClosingAdvance).HasDefaultValueSql("((0))");

                entity.Property(e => e.CreatedDt)
                    .HasColumnName("CreatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedUserId).HasColumnName("CreatedUserID");

                entity.Property(e => e.CurrencyId).HasColumnName("CurrencyID");

                entity.Property(e => e.DefaultCurrencyId).HasColumnName("DefaultCurrencyID");

                entity.Property(e => e.ExchangeConversionRate).HasDefaultValueSql("((1))");

                entity.Property(e => e.OpeningAdvance).HasDefaultValueSql("((0))");

                entity.Property(e => e.PaymentDetail)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PaymentSendLedgerId)
                    .HasColumnName("PaymentSend_LedgerID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.PaymentSendNum)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PaymentTypeId).HasColumnName("PaymentTypeID");

                entity.Property(e => e.SupplierId).HasColumnName("SupplierID");

                entity.Property(e => e.TotalPaidAmtDefaultCurr).HasColumnName("TotalPaidAmt_DefaultCurr");

                entity.Property(e => e.VoucherId)
                    .HasColumnName("VoucherID")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<ActPaymentTypeM>(entity =>
            {
                entity.HasKey(e => e.PaymentTypeId);

                entity.ToTable("ACT_PaymentType_M");

                entity.Property(e => e.PaymentTypeId)
                    .HasColumnName("PaymentTypeID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.CreatedDt)
                    .HasColumnName("CreatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedUserId).HasColumnName("CreatedUserID");

                entity.Property(e => e.DetailDisplayName)
                    .HasColumnName("Detail_DisplayName")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PaymentTypeName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ActScrapInvoiceD>(entity =>
            {
                entity.HasKey(e => e.ScrapInvoiceDetId);

                entity.ToTable("ACT_ScrapInvoice_D");

                entity.Property(e => e.ScrapInvoiceDetId).HasColumnName("ScrapInvoiceDetID");

                entity.Property(e => e.MaterialId).HasColumnName("MaterialID");

                entity.Property(e => e.SalesDeliveryUnitId).HasColumnName("SalesDeliveryUnitID");

                entity.Property(e => e.ScrapInvoiceId).HasColumnName("ScrapInvoiceID");
            });

            modelBuilder.Entity<ActScrapInvoiceM>(entity =>
            {
                entity.HasKey(e => e.ScrapInvoiceId);

                entity.ToTable("ACT_ScrapInvoice_M");

                entity.Property(e => e.ScrapInvoiceId).HasColumnName("ScrapInvoiceID");

                entity.Property(e => e.CreatedUserId).HasColumnName("CreatedUserID");

                entity.Property(e => e.CurrencyId).HasColumnName("CurrencyID");

                entity.Property(e => e.Description)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ExciseId).HasColumnName("ExciseID");

                entity.Property(e => e.InvoiceNum)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OtherChargesBeforeTax).HasColumnName("OtherCharges_before_tax");

                entity.Property(e => e.OtherChargesBeforeTaxDesc)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.OtherChargesName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.SalesTaxId).HasColumnName("SalesTaxID");

                entity.Property(e => e.ScrapBuyerId).HasColumnName("ScrapBuyerID");

                entity.Property(e => e.ScrapInvoiceDt)
                    .HasColumnName("ScrapInvoiceDT")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.ShipperId).HasColumnName("ShipperID");

                entity.Property(e => e.ShippingModeId).HasColumnName("ShippingModeID");
            });

            modelBuilder.Entity<ActTaxClassificationM>(entity =>
            {
                entity.HasKey(e => e.ClassificationId);

                entity.ToTable("ACT_TaxClassification_M");

                entity.Property(e => e.ClassificationId).HasColumnName("ClassificationID");

                entity.Property(e => e.Classification)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDt)
                    .HasColumnName("CreatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedUserId)
                    .HasColumnName("CreatedUserID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TaxType)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedDt)
                    .HasColumnName("UpdatedDT")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.UpdatedUserId).HasColumnName("UpdatedUserID");
            });

            modelBuilder.Entity<ActTaxHistory>(entity =>
            {
                entity.HasKey(e => e.TaxHistoryId);

                entity.ToTable("ACT_TaxHistory");

                entity.Property(e => e.TaxHistoryId).HasColumnName("TaxHistoryID");

                entity.Property(e => e.Amount).HasDefaultValueSql("((0))");

                entity.Property(e => e.CreatedDt)
                    .HasColumnName("CreatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedUserId).HasColumnName("CreatedUserID");

                entity.Property(e => e.InvoiceId)
                    .HasColumnName("InvoiceID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.MaterialPurchaseReqId)
                    .HasColumnName("MaterialPurchaseReqID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ScrapInvoiceId)
                    .HasColumnName("ScrapInvoiceID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TaxStructureId)
                    .HasColumnName("TaxStructureID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.UpdatedDt)
                    .HasColumnName("UpdatedDT")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.UpdatedUserId).HasColumnName("UpdatedUserID");
            });

            modelBuilder.Entity<ActTaxNewM>(entity =>
            {
                entity.HasKey(e => e.TaxId);

                entity.ToTable("ACT_TaxNew_M");

                entity.Property(e => e.TaxId)
                    .HasColumnName("TaxID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Applicability).HasDefaultValueSql("((0))");

                entity.Property(e => e.ClassificationId)
                    .HasColumnName("ClassificationID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CreatedDt)
                    .HasColumnName("CreatedDT")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.CreatedUserId).HasColumnName("CreatedUserID");

                entity.Property(e => e.EffectiveTax).HasDefaultValueSql("((0))");

                entity.Property(e => e.LedgerId).HasColumnName("LedgerID");

                entity.Property(e => e.LedgerIdOut).HasColumnName("LedgerID_Out");

                entity.Property(e => e.SubTax1LedgerId).HasColumnName("SubTax1LedgerID");

                entity.Property(e => e.SubTax1LedgerIdOut).HasColumnName("SubTax1LedgerID_Out");

                entity.Property(e => e.SubTax1Name)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.SubTax2LedgerId).HasColumnName("SubTax2LedgerID");

                entity.Property(e => e.SubTax2LedgerIdOut).HasColumnName("SubTax2LedgerID_Out");

                entity.Property(e => e.SubTax2Name)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.TaxName)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.TaxStrName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.TaxType)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedDt)
                    .HasColumnName("UpdatedDT")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.UpdatedUserId).HasColumnName("UpdatedUserID");
            });

            modelBuilder.Entity<AlertDefinition>(entity =>
            {
                entity.HasKey(e => e.AlertDefinitionId);

                entity.ToTable("Alert_Definition");

                entity.Property(e => e.AlertDefinitionId).HasColumnName("AlertDefinitionID");

                entity.Property(e => e.AlertClassification)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.AlertDefinition1)
                    .IsRequired()
                    .HasColumnName("AlertDefinition")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.AlertTypeId)
                    .IsRequired()
                    .HasColumnName("AlertTypeID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreateDt)
                    .HasColumnName("CreateDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedUserId).HasColumnName("CreatedUserID");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.NextSendDt)
                    .HasColumnName("Next_SendDT")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.RepeatOnHours).HasDefaultValueSql("((1))");

                entity.Property(e => e.SendTime).HasColumnType("smalldatetime");

                entity.Property(e => e.UpdatedDt)
                    .HasColumnName("UpdatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdatedUserId).HasColumnName("UpdatedUserID");
            });

            modelBuilder.Entity<AlertEmails>(entity =>
            {
                entity.HasKey(e => e.EmailId);

                entity.ToTable("Alert_Emails");

                entity.Property(e => e.EmailId).HasColumnName("EMailID");

                entity.Property(e => e.AlertDefinitionId).HasColumnName("AlertDefinitionID");

                entity.Property(e => e.CreatedOn)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.EmailFrom)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.EmailTo)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.Error)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Message)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.SendDt)
                    .HasColumnName("SendDT")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.SentOn).HasColumnType("smalldatetime");

                entity.Property(e => e.Subject)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AlertRecipient>(entity =>
            {
                entity.HasKey(e => e.RecipientId);

                entity.ToTable("Alert_Recipient");

                entity.Property(e => e.RecipientId).HasColumnName("RecipientID");

                entity.Property(e => e.AlertDefinitionId).HasColumnName("AlertDefinitionID");

                entity.Property(e => e.CreateDt)
                    .HasColumnName("CreateDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedUserId)
                    .HasColumnName("CreatedUserID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Recipient)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.RecipientName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.UpdatedDt)
                    .HasColumnName("UpdatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdatedUserId)
                    .HasColumnName("UpdatedUserID")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<AstAreaM>(entity =>
            {
                entity.HasKey(e => e.AreaId);

                entity.ToTable("AST_Area_M");

                entity.Property(e => e.AreaId).HasColumnName("AreaID");

                entity.Property(e => e.AreaName)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDt)
                    .HasColumnName("CreatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedUserId).HasColumnName("CreatedUserID");

                entity.Property(e => e.Description)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.PlantId).HasColumnName("PlantID");

                entity.Property(e => e.UpdatedDt)
                    .HasColumnName("UpdatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdatedUserId).HasColumnName("UpdatedUserID");
            });

            modelBuilder.Entity<AstAssetAllocationM>(entity =>
            {
                entity.HasKey(e => e.AssetAllocationId);

                entity.ToTable("AST_AssetAllocation_M");

                entity.Property(e => e.AssetAllocationId).HasColumnName("AssetAllocationID");

                entity.Property(e => e.AssetId).HasColumnName("AssetID");

                entity.Property(e => e.CreatedDt)
                    .HasColumnName("CreatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedUserId)
                    .HasColumnName("CreatedUserID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CurrectInChargeId).HasColumnName("CurrectInChargeID");

                entity.Property(e => e.CurrentLocationId).HasColumnName("CurrentLocationID");

                entity.Property(e => e.NewInChargeId).HasColumnName("NewInChargeID");

                entity.Property(e => e.NewLocationId).HasColumnName("NewLocationID");

                entity.Property(e => e.UpdatedDt)
                    .HasColumnName("UpdatedDT")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.UpdatedUserId).HasColumnName("UpdatedUserID");
            });

            modelBuilder.Entity<AstAssetCategoryM>(entity =>
            {
                entity.HasKey(e => e.AssetCategoryId);

                entity.ToTable("AST_AssetCategory_M");

                entity.Property(e => e.AssetCategoryId).HasColumnName("AssetCategoryID");

                entity.Property(e => e.AskLocationMovement).HasColumnName("Ask_Location_Movement");

                entity.Property(e => e.AskWarrantyInsurance).HasColumnName("Ask_Warranty_Insurance");

                entity.Property(e => e.AssetCategoryCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AssetCategoryName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDt)
                    .HasColumnName("CreatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedUserId)
                    .HasColumnName("CreatedUserID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Description)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.GroupId).HasColumnName("GroupID");

                entity.Property(e => e.UpdatedDt)
                    .HasColumnName("UpdatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdatedUserId)
                    .HasColumnName("UpdatedUserID")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<AstAssetInchargeD>(entity =>
            {
                entity.HasKey(e => e.AssetInchargeId);

                entity.ToTable("AST_AssetIncharge_D");

                entity.Property(e => e.AssetInchargeId).HasColumnName("AssetInchargeID");

                entity.Property(e => e.AssetId).HasColumnName("AssetID");

                entity.Property(e => e.CreatedDt)
                    .HasColumnName("CreatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedUserId).HasColumnName("CreatedUserID");

                entity.Property(e => e.InchargeEmployeeId).HasColumnName("Incharge_EmployeeID");

                entity.Property(e => e.IsMainIncharge).HasColumnName("IsMain_Incharge");

                entity.Property(e => e.UpdatedDt)
                    .HasColumnName("UpdatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdatedUserId).HasColumnName("UpdatedUserID");
            });

            modelBuilder.Entity<AstAssetM>(entity =>
            {
                entity.HasKey(e => e.MachineId);

                entity.ToTable("AST_Asset_M");

                entity.Property(e => e.MachineId).HasColumnName("MachineID");

                entity.Property(e => e.AreaId).HasColumnName("AreaID");

                entity.Property(e => e.AssetCategoryId).HasColumnName("AssetCategoryID");

                entity.Property(e => e.AvailabilityPerDay)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.BudgetType)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ContactPersonName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ContactPersonPhoneNum)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDt)
                    .HasColumnName("CreatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedUserId).HasColumnName("CreatedUserID");

                entity.Property(e => e.CurrWorkOrderProcessId).HasColumnName("CurrWorkOrderProcessID");

                entity.Property(e => e.CurrencyId).HasColumnName("CurrencyID");

                entity.Property(e => e.DateofStartofUse).HasColumnType("smalldatetime");

                entity.Property(e => e.ElectricalDetails)
                    .IsRequired()
                    .HasColumnName("Electrical Details")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.EmailId)
                    .IsRequired()
                    .HasColumnName("EmailID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");

                entity.Property(e => e.IdealUtilizationPerHh)
                    .HasColumnName("IdealUtilizationPerHH")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.IdealUtilizationPerMm)
                    .HasColumnName("IdealUtilizationPerMM")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.IdofAsset)
                    .IsRequired()
                    .HasColumnName("IDofAsset")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.InitialSpentAmt).HasDefaultValueSql("((0))");

                entity.Property(e => e.InstallationDate).HasColumnType("smalldatetime");

                entity.Property(e => e.JobCount)
                    .HasColumnName("Job_Count")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.LedgerId)
                    .HasColumnName("LedgerID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.LocationId).HasColumnName("LocationID");

                entity.Property(e => e.MachineCode)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.MachineName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MachineSetupTime)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.MachineTypeId).HasColumnName("MachineTypeID");

                entity.Property(e => e.ModelNo)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MtncContectPersonName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.MtncEmailId)
                    .HasColumnName("MtncEmailID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MtncMobileNo)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.MtncPhoneNo)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.NextMaintenanceDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Notes)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.OfficePhoneNum)
                    .IsRequired()
                    .HasColumnName("Office PhoneNum")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.OutputCount)
                    .HasColumnName("Output_Count")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.OverdueAlertInDays).HasDefaultValueSql("((0))");

                entity.Property(e => e.OverdueAlertMobileNo)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.OverdueAlertforSupervisorInDays).HasDefaultValueSql("((0))");

                entity.Property(e => e.OverdueAlertforSupervisorMobileNo)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.PlantId).HasColumnName("PlantID");

                entity.Property(e => e.ProcessStepId)
                    .HasColumnName("ProcessStepID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.PurchaseDate).HasColumnType("smalldatetime");

                entity.Property(e => e.SerialNo)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.SqMdoneAfterMaintenance).HasColumnName("SqMDoneAfterMaintenance");

                entity.Property(e => e.SqMdonetotal).HasColumnName("SqMDonetotal");

                entity.Property(e => e.SqMforMaintenance).HasColumnName("SqMForMaintenance");

                entity.Property(e => e.Status)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SupplierId)
                    .HasColumnName("SupplierID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TotalWorkDoneInMeasurement).HasColumnName("TotalWorkDone_In_Measurement");

                entity.Property(e => e.TotalWorkDoneInMeasurementUnit).HasColumnName("TotalWorkDone_In_Measurement_Unit");

                entity.Property(e => e.TotalWorkDoneInProduction).HasColumnName("TotalWorkDone_In_Production");

                entity.Property(e => e.TotalWorkDoneInProductionUnit).HasColumnName("TotalWorkDone_In_Production_Unit");

                entity.Property(e => e.UpdatedDt)
                    .HasColumnName("UpdatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdatedUserId).HasColumnName("UpdatedUserID");

                entity.Property(e => e.WarrantyTillDate).HasColumnType("smalldatetime");

                entity.Property(e => e.YearofManufacture).HasColumnType("smalldatetime");
            });

            modelBuilder.Entity<AstBudgetPlanM>(entity =>
            {
                entity.HasKey(e => e.BudgetPlanId);

                entity.ToTable("AST_BudgetPlan_M");

                entity.Property(e => e.BudgetPlanId).HasColumnName("BudgetPlanID");

                entity.Property(e => e.AssetCategoryId).HasColumnName("AssetCategoryID");

                entity.Property(e => e.CancelQty).HasDefaultValueSql("((0))");

                entity.Property(e => e.CreatedDt)
                    .HasColumnName("CreatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedUserId).HasColumnName("CreatedUserID");

                entity.Property(e => e.DefaultCurrencyId).HasColumnName("Default_CurrencyID");

                entity.Property(e => e.MachineTypeId).HasColumnName("MachineTypeID");

                entity.Property(e => e.NeededBy).HasColumnType("smalldatetime");

                entity.Property(e => e.RefId).HasColumnName("RefID");

                entity.Property(e => e.UpdatedDt)
                    .HasColumnName("UpdatedDT")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.UpdatedUserId).HasColumnName("UpdatedUserID");
            });

            modelBuilder.Entity<AstDepreciationD>(entity =>
            {
                entity.HasKey(e => e.DepreciationId);

                entity.ToTable("AST_Depreciation_D");

                entity.Property(e => e.DepreciationId).HasColumnName("DepreciationID");

                entity.Property(e => e.CreatedDt)
                    .HasColumnName("CreatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedUserId).HasColumnName("CreatedUserID");

                entity.Property(e => e.DepreciationDate).HasColumnType("smalldatetime");

                entity.Property(e => e.MachineId).HasColumnName("MachineID");

                entity.Property(e => e.UpdatedDt)
                    .HasColumnName("UpdatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdatedUserId).HasColumnName("UpdatedUserID");
            });

            modelBuilder.Entity<AstFieldTypeAssetM>(entity =>
            {
                entity.HasKey(e => e.FieldTypeAssetId);

                entity.ToTable("AST_FieldTypeAsset_M");

                entity.Property(e => e.FieldTypeAssetId).HasColumnName("FieldTypeAssetID");

                entity.Property(e => e.CreatedDt)
                    .HasColumnName("CreatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedUserId).HasColumnName("CreatedUserID");

                entity.Property(e => e.Description)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FieldTypeDetailId).HasColumnName("FieldTypeDetailID");

                entity.Property(e => e.FieldTypeId).HasColumnName("FieldTypeID");

                entity.Property(e => e.MachineId).HasColumnName("MachineID");

                entity.Property(e => e.UpdatedDt)
                    .HasColumnName("UpdatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdatedUserId).HasColumnName("UpdatedUserID");
            });

            modelBuilder.Entity<AstFieldTypeD>(entity =>
            {
                entity.HasKey(e => e.FieldTypeDetailId);

                entity.ToTable("AST_FieldType_D");

                entity.Property(e => e.FieldTypeDetailId).HasColumnName("FieldTypeDetailID");

                entity.Property(e => e.CreatedDt)
                    .HasColumnName("CreatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedUserId).HasColumnName("CreatedUserID");

                entity.Property(e => e.FieldTypeId).HasColumnName("FieldTypeID");

                entity.Property(e => e.MachineTypeId).HasColumnName("MachineTypeID");

                entity.Property(e => e.UpdatedDt)
                    .HasColumnName("UpdatedDT")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.UpdatedUserId).HasColumnName("UpdatedUserID");
            });

            modelBuilder.Entity<AstFieldTypeM>(entity =>
            {
                entity.HasKey(e => e.FieldTypeId);

                entity.ToTable("AST_FieldType_M");

                entity.Property(e => e.FieldTypeId).HasColumnName("FieldTypeID");

                entity.Property(e => e.CreatedDt)
                    .HasColumnName("CreatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedUserId)
                    .HasColumnName("CreatedUserID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.FieldType)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedDt)
                    .HasColumnName("UpdatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdatedUserId)
                    .HasColumnName("UpdatedUserID")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<AstInsuranceAssetM>(entity =>
            {
                entity.HasKey(e => e.InsuranceAssetId);

                entity.ToTable("AST_InsuranceAsset_M");

                entity.Property(e => e.InsuranceAssetId).HasColumnName("InsuranceAssetID");

                entity.Property(e => e.CreatedDt)
                    .HasColumnName("CreatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedUserId).HasColumnName("CreatedUserID");

                entity.Property(e => e.ExpiryDate).HasColumnType("smalldatetime");

                entity.Property(e => e.InsuranceDetailId).HasColumnName("InsuranceDetailID");

                entity.Property(e => e.InsuranceId).HasColumnName("InsuranceID");

                entity.Property(e => e.MachineId).HasColumnName("MachineID");

                entity.Property(e => e.UpdatedDt)
                    .HasColumnName("UpdatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdatedUserId).HasColumnName("UpdatedUserID");
            });

            modelBuilder.Entity<AstInsuranceD>(entity =>
            {
                entity.HasKey(e => e.InsuranceDetailId);

                entity.ToTable("AST_Insurance_D");

                entity.Property(e => e.InsuranceDetailId).HasColumnName("InsuranceDetailID");

                entity.Property(e => e.CreatedDt)
                    .HasColumnName("CreatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedUserId).HasColumnName("CreatedUserID");

                entity.Property(e => e.InsuranceId).HasColumnName("InsuranceID");

                entity.Property(e => e.MachineTypeId).HasColumnName("MachineTypeID");

                entity.Property(e => e.UpdatedDt)
                    .HasColumnName("UpdatedDT")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.UpdatedUserId).HasColumnName("UpdatedUserID");
            });

            modelBuilder.Entity<AstInsuranceM>(entity =>
            {
                entity.HasKey(e => e.InsuranceId);

                entity.ToTable("AST_Insurance_M");

                entity.Property(e => e.InsuranceId).HasColumnName("InsuranceID");

                entity.Property(e => e.CreatedDt)
                    .HasColumnName("CreatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedUserId)
                    .HasColumnName("CreatedUserID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Description)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.InsuranceType)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedDt)
                    .HasColumnName("UpdatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdatedUserId)
                    .HasColumnName("UpdatedUserID")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<AstLocationM>(entity =>
            {
                entity.HasKey(e => e.LocationId);

                entity.ToTable("AST_Location_M");

                entity.Property(e => e.LocationId).HasColumnName("LocationID");

                entity.Property(e => e.AreaId).HasColumnName("AreaID");

                entity.Property(e => e.CreatedDt)
                    .HasColumnName("CreatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedUserId)
                    .HasColumnName("CreatedUserID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Description)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.LocationName)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.PlantId).HasColumnName("PlantID");

                entity.Property(e => e.UpdatedDt)
                    .HasColumnName("UpdatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdatedUserId)
                    .HasColumnName("UpdatedUserID")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<AstMachineWiseProcess>(entity =>
            {
                entity.HasKey(e => e.MachineWiseProcessStepId);

                entity.ToTable("AST_MachineWiseProcess");

                entity.Property(e => e.MachineWiseProcessStepId).HasColumnName("MachineWiseProcessStepID");

                entity.Property(e => e.AssetCategoryId).HasColumnName("AssetCategoryID");

                entity.Property(e => e.CreatedDt)
                    .HasColumnName("CreatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedUserId).HasColumnName("CreatedUserID");

                entity.Property(e => e.MachineId).HasColumnName("MachineID");

                entity.Property(e => e.MachineTypeId).HasColumnName("MachineTypeID");

                entity.Property(e => e.ProcessStepId).HasColumnName("ProcessStepID");

                entity.Property(e => e.UpdatedDt)
                    .HasColumnName("UpdatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdatedUserId).HasColumnName("UpdatedUserID");
            });

            modelBuilder.Entity<AstMaintenance>(entity =>
            {
                entity.HasKey(e => e.MachineMaintenanceId);

                entity.ToTable("AST_Maintenance");

                entity.Property(e => e.MachineMaintenanceId).HasColumnName("MachineMaintenanceID");

                entity.Property(e => e.AlertSmsnumbersMachineMaintenance)
                    .HasColumnName("AlertSMSNumbers_MachineMaintenance")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDt)
                    .HasColumnName("CreatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedUserId).HasColumnName("CreatedUserID");

                entity.Property(e => e.DayCount).HasColumnName("Day_Count");

                entity.Property(e => e.JobCount).HasColumnName("Job_Count");

                entity.Property(e => e.MachineId).HasColumnName("MachineID");

                entity.Property(e => e.MaintenanceBase).HasDefaultValueSql("((1))");

                entity.Property(e => e.MaintenanceCompletUserId).HasColumnName("MaintenanceCompletUserID");

                entity.Property(e => e.MaintenanceComplete).HasColumnType("smalldatetime");

                entity.Property(e => e.MaintenancePeriodInNoOfHours).HasColumnName("MaintenancePeriod_InNoOfHours");

                entity.Property(e => e.MaintenancePeriodInReportingUnitId).HasColumnName("MaintenancePeriodInReportingUnitID");

                entity.Property(e => e.MaintenancePeriodNoOfPcbs).HasColumnName("MaintenancePeriodNoOfPCBs");

                entity.Property(e => e.MaintenanceTypeId).HasColumnName("MaintenanceTypeID");

                entity.Property(e => e.MaintenanceTypeName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.NextMaintenanceDt)
                    .HasColumnName("NextMaintenanceDT")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.NextMaintenanceDtWithHours)
                    .HasColumnName("NextMaintenanceDT_WithHours")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.NextMaintenancePeriodAfterNoOfHours).HasColumnName("NextMaintenancePeriod_AfterNoOfHours");

                entity.Property(e => e.OutputCount).HasColumnName("Output_Count");

                entity.Property(e => e.ReportingCount).HasColumnName("Reporting_Count");

                entity.Property(e => e.UpdatedDt)
                    .HasColumnName("UpdatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdatedUserId).HasColumnName("UpdatedUserID");
            });

            modelBuilder.Entity<AstMaintenanceH>(entity =>
            {
                entity.HasKey(e => e.MachienmaintenanceHistoryId);

                entity.ToTable("AST_Maintenance_H");

                entity.Property(e => e.MachienmaintenanceHistoryId).HasColumnName("MachienmaintenanceHistoryID");

                entity.Property(e => e.ActualMaintenanceInNoOfHours).HasColumnName("ActualMaintenance_InNoOfHours");

                entity.Property(e => e.ActualMaintenanceOutputUnitId).HasColumnName("ActualMaintenanceOutputUnitID");

                entity.Property(e => e.ActualMaintenanceReportingUnitId).HasColumnName("ActualMaintenanceReportingUnitID");

                entity.Property(e => e.AttendedEmployeeId).HasColumnName("Attended_EmployeeID");

                entity.Property(e => e.CreatedDt)
                    .HasColumnName("CreatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedUserId).HasColumnName("CreatedUserID");

                entity.Property(e => e.CurrencyExchangeRate)
                    .HasColumnName("Currency_ExchangeRate")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.CurrencyId)
                    .HasColumnName("CurrencyID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.DefaultCurrencyId)
                    .HasColumnName("DefaultCurrencyID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ExpMaintenanceDtWithHours)
                    .HasColumnName("ExpMaintenanceDT_WithHours")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.ExpMaintenanceInNoOfHours).HasColumnName("ExpMaintenance_InNoOfHours");

                entity.Property(e => e.ExpectedMaintenanceOutputUnitId).HasColumnName("ExpectedMaintenanceOutputUnitID");

                entity.Property(e => e.ExpectedMaintenanceReportingUnitId).HasColumnName("ExpectedMaintenanceReportingUnitID");

                entity.Property(e => e.MachineId).HasColumnName("MachineID");

                entity.Property(e => e.MachineMaintenanceId).HasColumnName("MachineMaintenanceID");

                entity.Property(e => e.NextMaintenanceDt)
                    .HasColumnName("NextMaintenanceDT")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.NoofHoursForMaintenance)
                    .HasColumnName("NoofHours_ForMaintenance")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.PaidUsingLedgerId)
                    .HasColumnName("PaidUsingLedgerID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.SupplierId).HasColumnName("SupplierID");

                entity.Property(e => e.UpdatedDt)
                    .HasColumnName("UpdatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdatedUserId).HasColumnName("UpdatedUserID");

                entity.Property(e => e.VoucherId).HasColumnName("VoucherID");
            });

            modelBuilder.Entity<AstMaintenanceTypeM>(entity =>
            {
                entity.HasKey(e => e.MaintenanceTypeId);

                entity.ToTable("AST_MaintenanceType_M");

                entity.Property(e => e.MaintenanceTypeId).HasColumnName("MaintenanceTypeID");

                entity.Property(e => e.CreatedDt)
                    .HasColumnName("CreatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedUserId).HasColumnName("CreatedUserID");

                entity.Property(e => e.LedgerId)
                    .HasColumnName("LedgerID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.MaintenanceTypeName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.UpdatedDt)
                    .HasColumnName("UpdatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdatedUserId).HasColumnName("UpdatedUserID");
            });

            modelBuilder.Entity<AstMarketValue>(entity =>
            {
                entity.HasKey(e => e.MarketValueId);

                entity.ToTable("AST_MarketValue");

                entity.Property(e => e.MarketValueId).HasColumnName("MarketValueID");

                entity.Property(e => e.CreatedUserId).HasColumnName("CreatedUserID");

                entity.Property(e => e.MachineId).HasColumnName("MachineID");

                entity.Property(e => e.ObservedDate).HasColumnType("smalldatetime");
            });

            modelBuilder.Entity<AstPlantM>(entity =>
            {
                entity.HasKey(e => e.PlantId);

                entity.ToTable("AST_Plant_M");

                entity.Property(e => e.PlantId).HasColumnName("PlantID");

                entity.Property(e => e.CreatedDt)
                    .HasColumnName("CreatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedUserId)
                    .HasColumnName("CreatedUserID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Description)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.PlantName)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedDt)
                    .HasColumnName("UpdatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdatedUserId)
                    .HasColumnName("UpdatedUserID")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<AstRepairM>(entity =>
            {
                entity.HasKey(e => e.MachineRepairId);

                entity.ToTable("AST_Repair_M");

                entity.Property(e => e.MachineRepairId).HasColumnName("MachineRepairID");

                entity.Property(e => e.AssetCategoryId).HasColumnName("AssetCategoryID");

                entity.Property(e => e.AttendedEmployeeId).HasColumnName("Attended_EmployeeID");

                entity.Property(e => e.CompletionDt)
                    .HasColumnName("CompletionDT")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.CreatedDt)
                    .HasColumnName("CreatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedUserId).HasColumnName("CreatedUserID");

                entity.Property(e => e.ExchangeRate).HasDefaultValueSql("((0))");

                entity.Property(e => e.MachineId).HasColumnName("MachineID");

                entity.Property(e => e.NoofHoursForRepair)
                    .IsRequired()
                    .HasColumnName("NoofHours_ForRepair")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Notes)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.PaidUsingLedgerId)
                    .HasColumnName("PaidUsingLedgerID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.RepairRequestId)
                    .HasColumnName("RepairRequestID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.RepairTypeId).HasColumnName("RepairTypeID");

                entity.Property(e => e.SupplierId).HasColumnName("SupplierID");

                entity.Property(e => e.VoucherId)
                    .HasColumnName("VoucherID")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<AstRepairRequestM>(entity =>
            {
                entity.HasKey(e => e.RepairRequestId);

                entity.ToTable("AST_RepairRequest_M");

                entity.Property(e => e.RepairRequestId).HasColumnName("RepairRequestID");

                entity.Property(e => e.ApprovedDt)
                    .HasColumnName("ApprovedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ApprovedEmployeeId)
                    .HasColumnName("Approved_EmployeeID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.AssetCategoryId).HasColumnName("AssetCategoryID");

                entity.Property(e => e.CreatedDt)
                    .HasColumnName("CreatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedUserId)
                    .HasColumnName("CreatedUserID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ExpectedCost).HasDefaultValueSql("((0))");

                entity.Property(e => e.ExpectedHoursForRepair)
                    .HasColumnName("ExpectedHours_ForRepair")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MachineId).HasColumnName("MachineID");

                entity.Property(e => e.MachineTypeId).HasColumnName("MachineTypeID");

                entity.Property(e => e.Repair)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.RepairTypeId).HasColumnName("RepairTypeID");

                entity.Property(e => e.UpdatedDt)
                    .HasColumnName("UpdatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdatedUserId)
                    .HasColumnName("UpdatedUserID")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<AstRepairTypeM>(entity =>
            {
                entity.HasKey(e => e.RepairTypeId);

                entity.ToTable("AST_RepairType_M");

                entity.Property(e => e.RepairTypeId).HasColumnName("RepairTypeID");

                entity.Property(e => e.CreatedDt)
                    .HasColumnName("CreatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedUserId).HasColumnName("CreatedUserID");

                entity.Property(e => e.Description)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.InchargeEmailId)
                    .IsRequired()
                    .HasColumnName("Incharge_EmailID")
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.InchargeEmployeeId)
                    .HasColumnName("Incharge_EmployeeID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.LedgerId)
                    .HasColumnName("LedgerID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.RepairTypeName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedDt)
                    .HasColumnName("UpdatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdatedUserId).HasColumnName("UpdatedUserID");
            });

            modelBuilder.Entity<AstSupplierOfferingM>(entity =>
            {
                entity.HasKey(e => e.OfferingId);

                entity.ToTable("AST_SupplierOffering_M");

                entity.Property(e => e.OfferingId).HasColumnName("OfferingID");

                entity.Property(e => e.AssetCategoryId).HasColumnName("AssetCategoryID");

                entity.Property(e => e.CreatedDt)
                    .HasColumnName("CreatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedUserId).HasColumnName("CreatedUserID");

                entity.Property(e => e.MachineTypeId).HasColumnName("MachineTypeID");

                entity.Property(e => e.SupplierId).HasColumnName("SupplierID");

                entity.Property(e => e.UpdatedDt)
                    .HasColumnName("UpdatedDT")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.UpdatedUserId).HasColumnName("UpdatedUserID");
            });

            modelBuilder.Entity<AstTypeM>(entity =>
            {
                entity.HasKey(e => e.MachineTypeId);

                entity.ToTable("AST_Type_M");

                entity.Property(e => e.MachineTypeId).HasColumnName("MachineTypeID");

                entity.Property(e => e.AssetCategoryId).HasColumnName("AssetCategoryID");

                entity.Property(e => e.CreatedDt)
                    .HasColumnName("CreatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedUserId).HasColumnName("CreatedUserID");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.GroupId).HasColumnName("GroupID");

                entity.Property(e => e.MachineTypeCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MachineTypeName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MaintenanceBasisId)
                    .HasColumnName("MaintenanceBasisID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.MaintenanceBasisOnReportingUnitId)
                    .HasColumnName("MaintenanceBasisOnReportingUnitID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.OutputUnitId)
                    .HasColumnName("OutputUnitID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.OverdueAlertMobileNo)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.OverdueAlertforSupervisorMobileNo)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.ReportingUnitCategoryId)
                    .HasColumnName("ReportingUnitCategoryID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.UpdatedDt)
                    .HasColumnName("UpdatedDT")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.UpdatedUserId).HasColumnName("UpdatedUserID");
            });

            modelBuilder.Entity<AstVersionM>(entity =>
            {
                entity.HasKey(e => e.VersionId);

                entity.ToTable("AST_Version_M");

                entity.Property(e => e.VersionId).HasColumnName("VersionID");

                entity.Property(e => e.Comments)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDt)
                    .HasColumnName("CreatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedUserId).HasColumnName("CreatedUserID");

                entity.Property(e => e.EmpolyeeId).HasColumnName("EmpolyeeID");

                entity.Property(e => e.MachineId).HasColumnName("MachineID");

                entity.Property(e => e.SupplierId).HasColumnName("SupplierID");

                entity.Property(e => e.UpdatedDt)
                    .HasColumnName("UpdatedDT")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.UpdatedUserId).HasColumnName("UpdatedUserID");

                entity.Property(e => e.VersionName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AstWarrantyD>(entity =>
            {
                entity.HasKey(e => e.WarrantyDetailId);

                entity.ToTable("AST_Warranty_D");

                entity.Property(e => e.WarrantyDetailId).HasColumnName("WarrantyDetailID");

                entity.Property(e => e.CreatedDt)
                    .HasColumnName("CreatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedUserId).HasColumnName("CreatedUserID");

                entity.Property(e => e.MachineId).HasColumnName("MachineID");

                entity.Property(e => e.UpdatedDt)
                    .HasColumnName("UpdatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdatedUserId).HasColumnName("UpdatedUserID");

                entity.Property(e => e.WarrantyId).HasColumnName("WarrantyID");
            });

            modelBuilder.Entity<AstWarrantyM>(entity =>
            {
                entity.HasKey(e => e.WarrantyId);

                entity.ToTable("AST_Warranty_M");

                entity.Property(e => e.WarrantyId).HasColumnName("WarrantyID");

                entity.Property(e => e.CreatedDt)
                    .HasColumnName("CreatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedUserId)
                    .HasColumnName("CreatedUserID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Description)
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedDt)
                    .HasColumnName("UpdatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdatedUserId)
                    .HasColumnName("UpdatedUserID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Warranty)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CityM>(entity =>
            {
                entity.HasKey(e => e.CityId);

                entity.ToTable("City_M");

                entity.Property(e => e.CityId).HasColumnName("CityID");

                entity.Property(e => e.CityName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CountryId).HasColumnName("CountryID");

                entity.Property(e => e.CreatedDt)
                    .HasColumnName("CreatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedUserId).HasColumnName("CreatedUserID");

                entity.Property(e => e.StateId).HasColumnName("StateID");

                entity.Property(e => e.UpdatedDt)
                    .HasColumnName("UpdatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdatedUserId).HasColumnName("UpdatedUserID");
            });

            modelBuilder.Entity<ColourM>(entity =>
            {
                entity.HasKey(e => e.ColourId);

                entity.ToTable("Colour_M");

                entity.Property(e => e.ColourId)
                    .HasColumnName("ColourID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.ColourName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ComplexityLevelM>(entity =>
            {
                entity.HasKey(e => e.ComplexityLevelId);

                entity.ToTable("ComplexityLevel_M");

                entity.Property(e => e.ComplexityLevelId)
                    .HasColumnName("ComplexityLevelID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.ComplexityLevel)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ConfigInvoiceTypeM>(entity =>
            {
                entity.HasKey(e => e.InvoiceTypeId);

                entity.ToTable("Config_InvoiceType_M");

                entity.Property(e => e.InvoiceTypeId).HasColumnName("InvoiceTypeID");

                entity.Property(e => e.CurrentInvoiceNo)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.InvoiceTitle)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.InvoiceType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Prefix)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Suffix)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedDt)
                    .HasColumnName("UpdatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdatedUserId).HasColumnName("UpdatedUserID");
            });

            modelBuilder.Entity<ConfigM>(entity =>
            {
                entity.HasKey(e => e.FieldId);

                entity.ToTable("Config_M");

                entity.Property(e => e.FieldId).HasColumnName("FieldID");

                entity.Property(e => e.CreatedDt)
                    .HasColumnName("CreatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedUserId).HasColumnName("CreatedUserID");

                entity.Property(e => e.DisplayForm)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('Text')");

                entity.Property(e => e.DisplayText)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DisplayToUsers).HasDefaultValueSql("((1))");

                entity.Property(e => e.Field)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.NumRangeFrom).HasDefaultValueSql("((-1))");

                entity.Property(e => e.NumRangeTo).HasDefaultValueSql("((-1))");

                entity.Property(e => e.ShowInAccount).HasColumnName("Show in Account");

                entity.Property(e => e.ShowInAsset).HasColumnName("Show in Asset");

                entity.Property(e => e.ShowInHr).HasColumnName("Show in HR");

                entity.Property(e => e.ShowInMarketing).HasColumnName("Show in Marketing");

                entity.Property(e => e.ShowInMarketingSales).HasColumnName("Show in Marketing & Sales");

                entity.Property(e => e.ShowInMaterial).HasColumnName("Show in Material");

                entity.Property(e => e.ShowInPcbConfiguration).HasColumnName("Show in PCB Configuration");

                entity.Property(e => e.ShowInProduction).HasColumnName("Show in Production");

                entity.Property(e => e.TextLength).HasDefaultValueSql("((500))");

                entity.Property(e => e.UpdatedDt)
                    .HasColumnName("UpdatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdatedUserId).HasColumnName("UpdatedUserID");

                entity.Property(e => e.Validation)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('Text')");

                entity.Property(e => e.Value)
                    .IsRequired()
                    .HasMaxLength(1000)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CountryM>(entity =>
            {
                entity.HasKey(e => e.CountryId);

                entity.ToTable("Country_M");

                entity.Property(e => e.CountryId).HasColumnName("CountryID");

                entity.Property(e => e.CountryName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDt)
                    .HasColumnName("CreatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedUserId).HasColumnName("CreatedUserID");

                entity.Property(e => e.CurrencyId)
                    .HasColumnName("CurrencyID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.DialingCode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("((91))");

                entity.Property(e => e.UpdatedDt)
                    .HasColumnName("UpdatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdatedUserId).HasColumnName("UpdatedUserID");
            });

            modelBuilder.Entity<CurrencyM>(entity =>
            {
                entity.HasKey(e => e.CurrencyId);

                entity.ToTable("Currency_M");

                entity.Property(e => e.CurrencyId)
                    .HasColumnName("CurrencyID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.CreatedDt)
                    .HasColumnName("CreatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedUserId)
                    .HasColumnName("CreatedUserID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CurrencyFullName)
                    .HasColumnName("Currency_FullName")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CurrencyName)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.CurrencyPrecisionDigits)
                    .HasColumnName("Currency_PrecisionDigits")
                    .HasDefaultValueSql("((2))");

                entity.Property(e => e.LatestCurrencyPrice).HasDefaultValueSql("((0))");

                entity.Property(e => e.SecondCurrencyName)
                    .IsRequired()
                    .HasColumnName("Second_CurrencyName")
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.UpdatedDt)
                    .HasColumnName("UpdatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdatedUserId)
                    .HasColumnName("UpdatedUserID")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<CustomReports>(entity =>
            {
                entity.HasKey(e => e.CustomReportId);

                entity.Property(e => e.CustomReportId).HasColumnName("CustomReportID");

                entity.Property(e => e.FileName)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.PageTitle)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ReportType)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Emails>(entity =>
            {
                entity.HasKey(e => e.EmailId);

                entity.Property(e => e.EmailId).HasColumnName("EMailID");

                entity.Property(e => e.CreatedOn)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.EmailFrom)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.EmailTo)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.EmailType)
                    .HasColumnName("EMailType")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Error)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Message)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.SentOn).HasColumnType("smalldatetime");

                entity.Property(e => e.Subject)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EmailTypeFormatM>(entity =>
            {
                entity.HasKey(e => e.EmailTypeFormatId);

                entity.ToTable("EmailTypeFormat_M");

                entity.Property(e => e.EmailTypeFormatId).HasColumnName("EmailTypeFormatID");

                entity.Property(e => e.CreatedDt)
                    .HasColumnName("CreatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedUserId)
                    .HasColumnName("CreatedUserID")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.EmailBody1)
                    .IsRequired()
                    .HasColumnName("Email_Body1")
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.EmailBody2)
                    .HasColumnName("Email_Body2")
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.EmailBody3)
                    .HasColumnName("Email_Body3")
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.EmailBody4)
                    .HasColumnName("Email_Body4")
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.EmailFooter)
                    .IsRequired()
                    .HasColumnName("Email_Footer")
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.EmailHeader)
                    .IsRequired()
                    .HasColumnName("Email_Header")
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.EmailSubject)
                    .IsRequired()
                    .HasColumnName("Email_Subject")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.EmailTypeFormatNo)
                    .IsRequired()
                    .HasColumnName("EmailType_FormatNo")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.EmailTypeId).HasColumnName("EmailTypeID");

                entity.Property(e => e.UpdatedDt)
                    .HasColumnName("UpdatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdatedUserId)
                    .HasColumnName("UpdatedUserID")
                    .HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<EmailTypeM>(entity =>
            {
                entity.HasKey(e => e.EmailTypeId);

                entity.ToTable("EmailType_M");

                entity.Property(e => e.EmailTypeId).HasColumnName("EmailTypeID");

                entity.Property(e => e.AutoEmailFromName)
                    .HasColumnName("AutoEmail_FromName")
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.BcctoEmailId)
                    .IsRequired()
                    .HasColumnName("BCCTo_EmailID")
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.BcctoEmailIdname)
                    .IsRequired()
                    .HasColumnName("BCCTo_EmailIDName")
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.BcctoName)
                    .IsRequired()
                    .HasColumnName("BCCTo_Name")
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CctoEmailId)
                    .IsRequired()
                    .HasColumnName("CCTo_EmailID")
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CctoEmailIdname)
                    .IsRequired()
                    .HasColumnName("CCTo_EmailIDName")
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CctoName)
                    .IsRequired()
                    .HasColumnName("CCTo_Name")
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CreatedDt)
                    .HasColumnName("CreatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedUserId).HasColumnName("CreatedUserID");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.EmailType)
                    .IsRequired()
                    .HasMaxLength(120)
                    .IsUnicode(false);

                entity.Property(e => e.IsAllowBcc).HasColumnName("IsAllow_BCC");

                entity.Property(e => e.IsAllowCc).HasColumnName("IsAllow_CC");

                entity.Property(e => e.IsAllowReply).HasColumnName("IsAllow_Reply");

                entity.Property(e => e.ReplyToEmailId)
                    .IsRequired()
                    .HasColumnName("ReplyTo_EmailID")
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ReplyToEmailIdname)
                    .IsRequired()
                    .HasColumnName("ReplyTo_EmailIDName")
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ReplyToName)
                    .IsRequired()
                    .HasColumnName("ReplyTo_Name")
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.UpdatedDt)
                    .HasColumnName("UpdatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdatedUserId).HasColumnName("UpdatedUserID");
            });

            modelBuilder.Entity<EmailTypeRecipientM>(entity =>
            {
                entity.HasKey(e => e.EmailTypeRecipientId);

                entity.ToTable("EmailTypeRecipient_M");

                entity.Property(e => e.EmailTypeRecipientId).HasColumnName("EmailTypeRecipientID");

                entity.Property(e => e.CreatedDt)
                    .HasColumnName("CreatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedUserId)
                    .HasColumnName("CreatedUserID")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.DesignationId).HasColumnName("DesignationID");

                entity.Property(e => e.EmailTypeId).HasColumnName("EmailTypeID");

                entity.Property(e => e.RecipientEmailId)
                    .IsRequired()
                    .HasColumnName("Recipient_EmailID")
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.RecipientEmailIdname)
                    .IsRequired()
                    .HasColumnName("Recipient_EmailIDName")
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.RecipientName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.UpdatedDt)
                    .HasColumnName("UpdatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdatedUserId)
                    .HasColumnName("UpdatedUserID")
                    .HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<FilesM>(entity =>
            {
                entity.HasKey(e => e.FileId);

                entity.ToTable("Files_M");

                entity.Property(e => e.FileId).HasColumnName("FileID");

                entity.Property(e => e.CreatedDt)
                    .HasColumnName("CreatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedUserId).HasColumnName("CreatedUserID");

                entity.Property(e => e.FileName)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.Reference)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ReferenceId).HasColumnName("ReferenceID");

                entity.Property(e => e.UpdatedDt)
                    .HasColumnName("UpdatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdatedUserId).HasColumnName("UpdatedUserID");
            });

            modelBuilder.Entity<GenieVersionM>(entity =>
            {
                entity.HasKey(e => e.GenieVersionId);

                entity.ToTable("GenieVersion_M");

                entity.Property(e => e.GenieVersionId).HasColumnName("GenieVersionID");

                entity.Property(e => e.CreatedDt)
                    .HasColumnName("CreatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<HrmAttendanceM>(entity =>
            {
                entity.HasKey(e => e.AttendanceId);

                entity.ToTable("HRM_Attendance_M");

                entity.Property(e => e.AttendanceId).HasColumnName("AttendanceID");

                entity.Property(e => e.AttendanceStatusId).HasColumnName("AttendanceStatusID");

                entity.Property(e => e.AutoIsOverTime).HasColumnName("Auto_IsOverTime");

                entity.Property(e => e.AutoLeaveDurationDays).HasColumnName("Auto_LeaveDuration_Days");

                entity.Property(e => e.AutoOverTimeHours).HasColumnName("Auto_OverTime_Hours");

                entity.Property(e => e.AutoOverTimeMinutes).HasColumnName("Auto_OverTime_Minutes");

                entity.Property(e => e.AutoWorkDurationDays).HasColumnName("Auto_WorkDuration_Days");

                entity.Property(e => e.CreatedDt)
                    .HasColumnName("CreatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedUserId).HasColumnName("CreatedUserID");

                entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");

                entity.Property(e => e.IdealInTime)
                    .HasColumnName("Ideal_InTime")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.InDt)
                    .HasColumnName("InDT")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.IsManualEntry).HasDefaultValueSql("((1))");

                entity.Property(e => e.LateArrivalReason)
                    .HasColumnName("LateArrival_Reason")
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.LeaveDurationDays).HasColumnName("LeaveDuration_Days");

                entity.Property(e => e.LeaveDurationHours).HasColumnName("LeaveDuration_Hours");

                entity.Property(e => e.LeaveDurationMinutes).HasColumnName("LeaveDuration_Minutes");

                entity.Property(e => e.LeaveRequestDetailId).HasColumnName("LeaveRequestDetailID");

                entity.Property(e => e.LeaveTypeId).HasColumnName("LeaveTypeID");

                entity.Property(e => e.NoOfBreaksOfficial).HasColumnName("NoOfBreaks_Official");

                entity.Property(e => e.NoOfBreaksPersonal).HasColumnName("NoOfBreaks_Personal");

                entity.Property(e => e.OfficialBreakHours).HasColumnName("OfficialBreak_Hours");

                entity.Property(e => e.OfficialBreakMinutes).HasColumnName("OfficialBreak_Minutes");

                entity.Property(e => e.OutDt)
                    .HasColumnName("OutDT")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.OverTimeHours).HasColumnName("OverTime_Hours");

                entity.Property(e => e.OverTimeMinutes).HasColumnName("OverTime_Minutes");

                entity.Property(e => e.OverTimeReason)
                    .HasColumnName("OverTime_Reason")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.PersonalBreakHours).HasColumnName("PersonalBreak_Hours");

                entity.Property(e => e.PersonalBreakMinutes).HasColumnName("PersonalBreak_Minutes");

                entity.Property(e => e.UpdatedDt)
                    .HasColumnName("UpdatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdatedUserId).HasColumnName("UpdatedUserID");

                entity.Property(e => e.WorkDurationDays).HasColumnName("WorkDuration_Days");

                entity.Property(e => e.WorkDurationHours).HasColumnName("WorkDuration_Hours");

                entity.Property(e => e.WorkDurationMinutes).HasColumnName("WorkDuration_Minutes");
            });

            modelBuilder.Entity<HrmAttendanceStatusM>(entity =>
            {
                entity.HasKey(e => e.AttendanceStatusId);

                entity.ToTable("HRM_AttendanceStatus_M");

                entity.Property(e => e.AttendanceStatusId)
                    .HasColumnName("AttendanceStatusID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.AttendanceStatus)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CreatedDt)
                    .HasColumnName("CreatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedUserId).HasColumnName("CreatedUserID");

                entity.Property(e => e.DisplayAttendanceStatus)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.UpdatedDt)
                    .HasColumnName("UpdatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdatedUserId).HasColumnName("UpdatedUserID");
            });

            modelBuilder.Entity<HrmBreakD>(entity =>
            {
                entity.HasKey(e => e.BreakId);

                entity.ToTable("HRM_Break_D");

                entity.Property(e => e.BreakId).HasColumnName("BreakID");

                entity.Property(e => e.AttendanceId).HasColumnName("AttendanceID");

                entity.Property(e => e.BreakInDt)
                    .HasColumnName("Break_InDT")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.BreakOutDt)
                    .HasColumnName("Break_OutDT")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.BreakReason)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.BreakTypeId).HasColumnName("BreakTypeID");

                entity.Property(e => e.CreatedDt)
                    .HasColumnName("CreatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedUserId).HasColumnName("CreatedUserID");

                entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");

                entity.Property(e => e.IsManualEntry).HasDefaultValueSql("((1))");

                entity.Property(e => e.UpdatedDt)
                    .HasColumnName("UpdatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdatedUserId).HasColumnName("UpdatedUserID");
            });

            modelBuilder.Entity<HrmBreakTypeM>(entity =>
            {
                entity.HasKey(e => e.BreakTypeId);

                entity.ToTable("HRM_BreakType_M");

                entity.Property(e => e.BreakTypeId)
                    .HasColumnName("BreakTypeID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.BreakType)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDt)
                    .HasColumnName("CreatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedUserId).HasColumnName("CreatedUserID");

                entity.Property(e => e.UpdatedDt)
                    .HasColumnName("UpdatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdatedUserId).HasColumnName("UpdatedUserID");
            });

            modelBuilder.Entity<HrmConfInputEntryD>(entity =>
            {
                entity.HasKey(e => e.EntryRefId);

                entity.ToTable("HRM_ConfInputEntry_D");

                entity.Property(e => e.EntryRefId).HasColumnName("EntryRefID");

                entity.Property(e => e.ConfId).HasColumnName("ConfID");

                entity.Property(e => e.EmpAboutId).HasColumnName("EmpAboutID");
            });

            modelBuilder.Entity<HrmConfInputEntryM>(entity =>
            {
                entity.HasKey(e => e.ConfId);

                entity.ToTable("HRM_ConfInputEntry_M");

                entity.Property(e => e.ConfId).HasColumnName("ConfID");

                entity.Property(e => e.CreatedDt)
                    .HasColumnName("CreatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedUserId).HasColumnName("CreatedUserID");

                entity.Property(e => e.Details)
                    .IsRequired()
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.InputAbout)
                    .IsRequired()
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.ReportToId).HasColumnName("ReportToID");

                entity.Property(e => e.ReporterId)
                    .HasColumnName("ReporterID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TopicId).HasColumnName("TopicID");

                entity.Property(e => e.UpdatedDt)
                    .HasColumnName("UpdatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdatedUserId).HasColumnName("UpdatedUserID");
            });

            modelBuilder.Entity<HrmConfInputTopics>(entity =>
            {
                entity.HasKey(e => e.TopicId);

                entity.ToTable("HRM_ConfInputTopics");

                entity.Property(e => e.TopicId).HasColumnName("TopicID");

                entity.Property(e => e.CreatedDt)
                    .HasColumnName("CreatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedUserId).HasColumnName("CreatedUserID");

                entity.Property(e => e.NatureTypeId).HasColumnName("NatureTypeID");

                entity.Property(e => e.TopicName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedDt)
                    .HasColumnName("UpdatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdatedUserId).HasColumnName("UpdatedUserID");
            });

            modelBuilder.Entity<HrmDepartmentM>(entity =>
            {
                entity.HasKey(e => e.DepartmentId);

                entity.ToTable("HRM_Department_M");

                entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");

                entity.Property(e => e.CreatedDt)
                    .HasColumnName("CreatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedUserId).HasColumnName("CreatedUserID");

                entity.Property(e => e.DepartmentName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedDt)
                    .HasColumnName("UpdatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdatedUserId).HasColumnName("UpdatedUserID");

                entity.Property(e => e.WorkAreaId)
                    .HasColumnName("WorkAreaID")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<HrmDesignationM>(entity =>
            {
                entity.HasKey(e => e.EmployeeTypeId);

                entity.ToTable("HRM_Designation_M");

                entity.Property(e => e.EmployeeTypeId).HasColumnName("EmployeeTypeID");

                entity.Property(e => e.AllowedMaxHoursLateArrival)
                    .HasColumnName("Allowed_MaxHours_LateArrival")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.AuthorityToRecmaterial).HasColumnName("AuthorityToRECMaterial");

                entity.Property(e => e.CreatedDt)
                    .HasColumnName("CreatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedUserId).HasColumnName("CreatedUserID");

                entity.Property(e => e.DefaultModulePage)
                    .IsRequired()
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.DesignationRank).HasDefaultValueSql("((0))");

                entity.Property(e => e.DesignationToDisplay)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EmployeeTypeName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FileTitle)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FileType)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.IdealInTime)
                    .HasColumnName("Ideal_InTime")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.IncrementedSalary).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsApplicablePayDeductPolicyOnLateArrival).HasColumnName("IsApplicable_PayDeduct_Policy_OnLateArrival");

                entity.Property(e => e.IsConsiderAsHalfDayForLate).HasColumnName("IsConsider_As_HalfDay_For_Late");

                entity.Property(e => e.IsConsiderDirectLabour).HasColumnName("IsConsider_DirectLabour");

                entity.Property(e => e.IsLatePolicyApplicable).HasDefaultValueSql("((1))");

                entity.Property(e => e.MaxAllowedLateArrivalsPerMonth).HasColumnName("MaxAllowed_LateArrivals_PerMonth");

                entity.Property(e => e.MaxDayIncomeDeductOnLateArrival)
                    .HasColumnName("MaxDayIncome_Deduct_OnLateArrival")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MaximumSalary).HasDefaultValueSql("((0))");

                entity.Property(e => e.MinTimeLateArrival)
                    .HasColumnName("MinTime_LateArrival")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.MinimumSalary).HasDefaultValueSql("((0))");

                entity.Property(e => e.ReportingToEmployeeTypeId).HasColumnName("ReportingToEmployeeTypeID");

                entity.Property(e => e.RequireLeaveApprovalFromAdmin).HasColumnName("Require_Leave_Approval_From_Admin");

                entity.Property(e => e.RequireLeaveApprovalFromSupervisor).HasColumnName("Require_Leave_Approval_From_Supervisor");

                entity.Property(e => e.SalaryRange)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StandardInstruction).IsUnicode(false);

                entity.Property(e => e.UpdatedDt)
                    .HasColumnName("UpdatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdatedUserId).HasColumnName("UpdatedUserID");

                entity.Property(e => e.WorkHoursFullDay)
                    .HasColumnName("WorkHours_FullDay")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.WorkHoursHalfDay)
                    .HasColumnName("WorkHours_HalfDay")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.WorkHoursOverTime)
                    .HasColumnName("WorkHours_OverTime")
                    .HasColumnType("smalldatetime");
            });

            modelBuilder.Entity<HrmDesignationRoleD>(entity =>
            {
                entity.HasKey(e => e.DesignationRoleId);

                entity.ToTable("HRM_DesignationRole_D");

                entity.Property(e => e.DesignationRoleId).HasColumnName("DesignationRoleID");

                entity.Property(e => e.CreatedDt)
                    .HasColumnName("CreatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedUserId).HasColumnName("CreatedUserID");

                entity.Property(e => e.EmployeeTypeId).HasColumnName("EmployeeTypeID");

                entity.Property(e => e.RoleId).HasColumnName("RoleID");

                entity.Property(e => e.UpdatedDt)
                    .HasColumnName("UpdatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdatedUserId).HasColumnName("UpdatedUserID");
            });

            modelBuilder.Entity<HrmDesignationSkillD>(entity =>
            {
                entity.HasKey(e => e.EmpDesigDetId);

                entity.ToTable("HRM_DesignationSkill_D");

                entity.Property(e => e.EmpDesigDetId).HasColumnName("EmpDesigDetID");

                entity.Property(e => e.CreatedDt)
                    .HasColumnName("CreatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedUserId).HasColumnName("CreatedUserID");

                entity.Property(e => e.EmployeeTypeId).HasColumnName("EmployeeTypeID");

                entity.Property(e => e.LevelId).HasColumnName("LevelID");

                entity.Property(e => e.Persantage).HasColumnType("numeric(5, 2)");

                entity.Property(e => e.PersantageUtilised)
                    .HasColumnType("numeric(5, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.PreferenceId).HasColumnName("PreferenceID");

                entity.Property(e => e.SkillId).HasColumnName("SkillID");

                entity.Property(e => e.SkillWorth).HasDefaultValueSql("((0))");

                entity.Property(e => e.UpdatedDt)
                    .HasColumnName("UpdatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdatedUserId).HasColumnName("UpdatedUserID");
            });

            modelBuilder.Entity<HrmEmployeeHolidayM>(entity =>
            {
                entity.HasKey(e => e.EmployeeHolidayId);

                entity.ToTable("HRM_EmployeeHoliday_M");

                entity.Property(e => e.EmployeeHolidayId).HasColumnName("EmployeeHolidayID");

                entity.Property(e => e.CreatedDt)
                    .HasColumnName("CreatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedUserId)
                    .HasColumnName("CreatedUserID")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");

                entity.Property(e => e.HolidayId).HasColumnName("HolidayID");

                entity.Property(e => e.UpdatedDt)
                    .HasColumnName("UpdatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdatedUserId)
                    .HasColumnName("UpdatedUserID")
                    .HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<HrmEmployeeLeaveTypes>(entity =>
            {
                entity.HasKey(e => e.EmployeeLeaveTypeId);

                entity.ToTable("HRM_EmployeeLeaveTypes");

                entity.Property(e => e.EmployeeLeaveTypeId).HasColumnName("EmployeeLeaveTypeID");

                entity.Property(e => e.CreatedDt)
                    .HasColumnName("CreatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedUserId).HasColumnName("CreatedUserID");

                entity.Property(e => e.CurrentBookedLeaves)
                    .HasColumnName("Current_Booked_Leaves")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CurrentUnusedLeaves)
                    .HasColumnName("Current_Unused_Leaves")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");

                entity.Property(e => e.LeaveTypeId).HasColumnName("LeaveTypeID");

                entity.Property(e => e.MaxBackDaysForLeaveRequest)
                    .HasColumnName("Max_BackDays_For_LeaveRequest")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TotalAddedLeaves).HasColumnName("Total_Added_Leaves");

                entity.Property(e => e.TotalUsedLeaves)
                    .HasColumnName("Total_Used_Leaves")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.UpdatedDt)
                    .HasColumnName("UpdatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdatedUserId).HasColumnName("UpdatedUserID");
            });

            modelBuilder.Entity<HrmEmployeeLogD>(entity =>
            {
                entity.HasKey(e => e.EmployeeLogDetId);

                entity.ToTable("HRM_EmployeeLog_D");

                entity.Property(e => e.EmployeeLogDetId).HasColumnName("EmployeeLogDetID");

                entity.Property(e => e.AllowedMaxHoursLateArrival)
                    .HasColumnName("Allowed_MaxHours_LateArrival")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.CreatedDt)
                    .HasColumnName("CreatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedUserId).HasColumnName("CreatedUserID");

                entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");

                entity.Property(e => e.EmployeeTypeId).HasColumnName("EmployeeTypeID");

                entity.Property(e => e.IdealInTime)
                    .HasColumnName("Ideal_InTime")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.IsApplicablePayDeductPolicyOnLateArrival).HasColumnName("IsApplicable_PayDeduct_Policy_OnLateArrival");

                entity.Property(e => e.IsConsiderAsHalfDayForLate).HasColumnName("IsConsider_As_HalfDay_For_Late");

                entity.Property(e => e.IsLatePolicyApplicable).HasDefaultValueSql("((1))");

                entity.Property(e => e.MaxAllowedLateArrivalsPerMonth).HasColumnName("MaxAllowed_LateArrivals_PerMonth");

                entity.Property(e => e.MaxDayIncomeDeductOnLateArrival)
                    .HasColumnName("MaxDayIncome_Deduct_OnLateArrival")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MinTimeLateArrival)
                    .HasColumnName("MinTime_LateArrival")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.WorkHoursFullDay)
                    .HasColumnName("WorkHours_FullDay")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.WorkHoursHalfDay)
                    .HasColumnName("WorkHours_HalfDay")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.WorkHoursOverTime)
                    .HasColumnName("WorkHours_OverTime")
                    .HasColumnType("smalldatetime");
            });

            modelBuilder.Entity<HrmEmployeeM>(entity =>
            {
                entity.HasKey(e => e.EmployeeId);

                entity.ToTable("HRM_Employee_M");

                entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");

                entity.Property(e => e.Address1)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Address2)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.AllowAccessDuringAbsence).HasDefaultValueSql("((1))");

                entity.Property(e => e.AllowedMaxHoursLateArrival)
                    .HasColumnName("Allowed_MaxHours_LateArrival")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.BankAccountName)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.BankAccountNo)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.BirthDate).HasColumnType("smalldatetime");

                entity.Property(e => e.BloodGroup)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.City)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CityId).HasColumnName("CityID");

                entity.Property(e => e.ContractCompletionDt)
                    .HasColumnName("ContractCompletionDT")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.Country)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CountryId).HasColumnName("CountryID");

                entity.Property(e => e.CreatedDt)
                    .HasColumnName("CreatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedUserId).HasColumnName("CreatedUserID");

                entity.Property(e => e.CurrentSalary).HasDefaultValueSql("('')");

                entity.Property(e => e.DepartmentId)
                    .HasColumnName("DepartmentID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.DesignationSinceDt)
                    .HasColumnName("DesignationSinceDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.EmailId)
                    .IsRequired()
                    .HasColumnName("EmailID")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.EmployeeNum)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.EmployeeTypeId).HasColumnName("EmployeeTypeID");

                entity.Property(e => e.Employment)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('Permanent')");

                entity.Property(e => e.Fname)
                    .IsRequired()
                    .HasColumnName("FName")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Gender)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.HasProcessByPassInClose).HasColumnName("Has_ProcessByPass_InClose");

                entity.Property(e => e.IdealInTime)
                    .HasColumnName("Ideal_InTime")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.IsApplicableEpf).HasColumnName("IsApplicable_EPF");

                entity.Property(e => e.IsApplicablePayDeductPolicyOnLateArrival).HasColumnName("IsApplicable_PayDeduct_Policy_OnLateArrival");

                entity.Property(e => e.IsConsiderAsHalfDayForLate).HasColumnName("IsConsider_As_HalfDay_For_Late");

                entity.Property(e => e.IsLatePolicyApplicable).HasDefaultValueSql("((1))");

                entity.Property(e => e.JoinDate)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.JoinSalary).HasDefaultValueSql("('')");

                entity.Property(e => e.LastDateofEmployment).HasColumnType("smalldatetime");

                entity.Property(e => e.LedgerId).HasColumnName("LedgerID");

                entity.Property(e => e.Lname)
                    .IsRequired()
                    .HasColumnName("LName")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.MaritalStatus)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.MaxAllowedLateArrivalsPerMonth).HasColumnName("MaxAllowed_LateArrivals_PerMonth");

                entity.Property(e => e.MaxDayIncomeDeductOnLateArrival)
                    .HasColumnName("MaxDayIncome_Deduct_OnLateArrival")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MinTimeLateArrival)
                    .HasColumnName("MinTime_LateArrival")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.Mname)
                    .IsRequired()
                    .HasColumnName("MName")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.MobileNum)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Notes)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.OfficialmailId)
                    .HasColumnName("OfficialmailID")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.PhoneExtNo)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.PhoneNum)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.PhotoIdnum)
                    .IsRequired()
                    .HasColumnName("PhotoIDNum")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.PhotoIdtype)
                    .IsRequired()
                    .HasColumnName("PhotoIDType")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.PinCode)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.PresAddress1)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.PresAddress2)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.PresCity)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.PresCityId)
                    .HasColumnName("PresCityID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.PresCountry)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.PresCountryId)
                    .HasColumnName("PresCountryID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.PresPhoneNum)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.PresPinCode)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.PresState)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.PresStateId)
                    .HasColumnName("PresStateID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ReportingToId)
                    .HasColumnName("ReportingToID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.RoleId).HasColumnName("RoleID");

                entity.Property(e => e.SalaryBase).HasDefaultValueSql("((2))");

                entity.Property(e => e.SeniorityLevel)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SigningupAmount).HasDefaultValueSql("((0))");

                entity.Property(e => e.State)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.StateId).HasColumnName("StateID");

                entity.Property(e => e.Status).HasDefaultValueSql("((0))");

                entity.Property(e => e.UpdatedDt)
                    .HasColumnName("UpdatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdatedUserId).HasColumnName("UpdatedUserID");

                entity.Property(e => e.ValidIddt)
                    .HasColumnName("ValidIDDT")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.WorkHoursFullDay)
                    .HasColumnName("WorkHours_FullDay")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.WorkHoursHalfDay)
                    .HasColumnName("WorkHours_HalfDay")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.WorkHoursOverTime)
                    .HasColumnName("WorkHours_OverTime")
                    .HasColumnType("smalldatetime");
            });

            modelBuilder.Entity<HrmEmployeePfD>(entity =>
            {
                entity.HasKey(e => e.EmployeePfdetId);

                entity.ToTable("HRM_Employee_PF_D");

                entity.Property(e => e.EmployeePfdetId).HasColumnName("EmployeePFDetID");

                entity.Property(e => e.ArrearEpfEe).HasColumnName("ArrearEPF_EE");

                entity.Property(e => e.ArrearEpfEr).HasColumnName("ArrearEPF_ER");

                entity.Property(e => e.ArrearEpfwages).HasColumnName("ArrearEPFWages");

                entity.Property(e => e.ArrearEps).HasColumnName("ArrearEPS");

                entity.Property(e => e.CreatedDt)
                    .HasColumnName("CreatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedUserId).HasColumnName("CreatedUserID");

                entity.Property(e => e.DiffEpfEpsContributionDueEr).HasColumnName("Diff_EPF_EPS_ContributionDue_ER");

                entity.Property(e => e.DiffEpfEpsContributionRemittedEr).HasColumnName("Diff_EPF_EPS_ContributionRemitted_ER");

                entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");

                entity.Property(e => e.EmployeePfid).HasColumnName("EmployeePFID");

                entity.Property(e => e.EpfcontributionDueEe).HasColumnName("EPFContributionDue_EE");

                entity.Property(e => e.EpfcontributionRemittedEe).HasColumnName("EPFContributionRemitted_EE");

                entity.Property(e => e.Epfwages).HasColumnName("EPFWages");

                entity.Property(e => e.EpscontributionDue).HasColumnName("EPSContributionDue");

                entity.Property(e => e.EpscontributionRemitted).HasColumnName("EPSContributionRemitted");

                entity.Property(e => e.Epswages).HasColumnName("EPSWages");

                entity.Property(e => e.IsPfgenerated).HasColumnName("IsPFGenerated");

                entity.Property(e => e.Ncpdays).HasColumnName("NCPDays");

                entity.Property(e => e.PfMonth).HasColumnName("PF_Month");

                entity.Property(e => e.PfYear).HasColumnName("PF_Year");

                entity.Property(e => e.RefundAdvances).HasColumnName("Refund_Advances");

                entity.Property(e => e.UpdatedDt)
                    .HasColumnName("UpdatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdatedUserId).HasColumnName("UpdatedUserID");
            });

            modelBuilder.Entity<HrmEmployeePfM>(entity =>
            {
                entity.HasKey(e => e.EmployeePfid);

                entity.ToTable("HRM_Employee_PF_M");

                entity.Property(e => e.EmployeePfid).HasColumnName("EmployeePFID");

                entity.Property(e => e.CreatedDt)
                    .HasColumnName("CreatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedUserId).HasColumnName("CreatedUserID");

                entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");

                entity.Property(e => e.EpfExitDt)
                    .HasColumnName("EPF_ExitDT")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.EpfJoinDt)
                    .HasColumnName("EPF_JoinDT")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.EpfmemberId)
                    .IsRequired()
                    .HasColumnName("EPFMemberID")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.EpsExitDt)
                    .HasColumnName("EPS_ExitDT")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.EpsJoinDt)
                    .HasColumnName("EPS_JoinDT")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.LeaveReason).HasColumnType("char(1)");

                entity.Property(e => e.MemberFname)
                    .IsRequired()
                    .HasColumnName("MemberFName")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.MemberLname)
                    .IsRequired()
                    .HasColumnName("MemberLName")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.MemberMname)
                    .HasColumnName("MemberMName")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PfBirthDate)
                    .HasColumnName("PF_BirthDate")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.ReasonId).HasColumnName("ReasonID");

                entity.Property(e => e.RelationshipWithMember)
                    .IsRequired()
                    .HasColumnName("Relationship_WithMember")
                    .HasColumnType("char(1)");

                entity.Property(e => e.RelativeFname)
                    .IsRequired()
                    .HasColumnName("RelativeFName")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.RelativeLname)
                    .IsRequired()
                    .HasColumnName("RelativeLName")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.RelativeMname)
                    .HasColumnName("RelativeMName")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedDt)
                    .HasColumnName("UpdatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdatedUserId).HasColumnName("UpdatedUserID");
            });

            modelBuilder.Entity<HrmEmployeeRecordD>(entity =>
            {
                entity.HasKey(e => e.EmployeeRecordDetailId);

                entity.ToTable("HRM_EmployeeRecord_D");

                entity.Property(e => e.EmployeeRecordDetailId).HasColumnName("EmployeeRecordDetailID");

                entity.Property(e => e.CreatedDt)
                    .HasColumnName("CreatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedUserId)
                    .HasColumnName("CreatedUserID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.EmployeeRecordId).HasColumnName("EmployeeRecordID");

                entity.Property(e => e.RecordFieldId).HasColumnName("RecordFieldID");

                entity.Property(e => e.RecordFieldValue)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedDt)
                    .HasColumnName("UpdatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdatedUserId)
                    .HasColumnName("UpdatedUserID")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<HrmEmployeeRecordM>(entity =>
            {
                entity.HasKey(e => e.EmployeeRecordId);

                entity.ToTable("HRM_EmployeeRecord_M");

                entity.Property(e => e.EmployeeRecordId).HasColumnName("EmployeeRecordID");

                entity.Property(e => e.CreatedDt)
                    .HasColumnName("CreatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedUserId)
                    .HasColumnName("CreatedUserID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");

                entity.Property(e => e.RecordDt)
                    .HasColumnName("RecordDT")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.RecordId).HasColumnName("RecordID");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.UpdatedDt)
                    .HasColumnName("UpdatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdatedUserId)
                    .HasColumnName("UpdatedUserID")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<HrmEmployeeSalaryComponentM>(entity =>
            {
                entity.HasKey(e => e.EmployeeSalaryComponentId);

                entity.ToTable("HRM_EmployeeSalaryComponent_M");

                entity.Property(e => e.EmployeeSalaryComponentId).HasColumnName("EmployeeSalaryComponentID");

                entity.Property(e => e.Amount).HasDefaultValueSql("((0.0))");

                entity.Property(e => e.CreatedDt)
                    .HasColumnName("CreatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedUserId)
                    .HasColumnName("CreatedUserID")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.EmployeeId)
                    .HasColumnName("EmployeeID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.SalaryComponentId)
                    .HasColumnName("SalaryComponentID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.UpdatedDt)
                    .HasColumnName("UpdatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdatedUserId)
                    .HasColumnName("UpdatedUserID")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<HrmEmployeeSalarySlipM>(entity =>
            {
                entity.HasKey(e => e.EmployeeSalarySlipId);

                entity.ToTable("HRM_EmployeeSalarySlip_M");

                entity.Property(e => e.EmployeeSalarySlipId).HasColumnName("EmployeeSalarySlipID");

                entity.Property(e => e.CreatedDt)
                    .HasColumnName("CreatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedUserId)
                    .HasColumnName("CreatedUserID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Ctc)
                    .HasColumnName("CTC")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");

                entity.Property(e => e.IssueDt)
                    .HasColumnName("IssueDT")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.Notes)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Othours).HasColumnName("OTHours");

                entity.Property(e => e.SalarySlipNo).HasDefaultValueSql("((0))");

                entity.Property(e => e.UpdatedDt)
                    .HasColumnName("UpdatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdatedUserId)
                    .HasColumnName("UpdatedUserID")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<HrmEmployeeSkillD>(entity =>
            {
                entity.HasKey(e => e.EmployeeSkillDetlId);

                entity.ToTable("HRM_EmployeeSkill_D");

                entity.Property(e => e.EmployeeSkillDetlId).HasColumnName("EmployeeSkillDetlID");

                entity.Property(e => e.CreatedDt)
                    .HasColumnName("CreatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedUserId)
                    .HasColumnName("CreatedUserID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");

                entity.Property(e => e.Interest).HasDefaultValueSql("((0))");

                entity.Property(e => e.LevelId).HasColumnName("LevelID");

                entity.Property(e => e.SkillId).HasColumnName("SkillID");

                entity.Property(e => e.UpdatedDt)
                    .HasColumnName("UpdatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdatedUserId)
                    .HasColumnName("UpdatedUserID")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<HrmEmployeeSkillM>(entity =>
            {
                entity.HasKey(e => e.SkillId);

                entity.ToTable("HRM_EmployeeSkill_M");

                entity.Property(e => e.SkillId).HasColumnName("SkillID");

                entity.Property(e => e.CreatedDt)
                    .HasColumnName("CreatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedUserId)
                    .HasColumnName("CreatedUserID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.FinancialValue)
                    .HasColumnType("numeric(10, 0)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.MinNoOfEmpShouldKnow).HasDefaultValueSql("((0))");

                entity.Property(e => e.SkillCategoryId).HasColumnName("SkillCategoryID");

                entity.Property(e => e.SkillName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedDt)
                    .HasColumnName("UpdatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdatedUserId)
                    .HasColumnName("UpdatedUserID")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<HrmEmpSkillCategoryM>(entity =>
            {
                entity.HasKey(e => e.SkillCategoryId);

                entity.ToTable("HRM_EmpSkillCategory_M");

                entity.Property(e => e.SkillCategoryId).HasColumnName("SkillCategoryID");

                entity.Property(e => e.CreatedDt)
                    .HasColumnName("CreatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedUserId)
                    .HasColumnName("CreatedUserID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Description)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.SkillCategoryName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedDt)
                    .HasColumnName("UpdatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdatedUserId)
                    .HasColumnName("UpdatedUserID")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<HrmHolidayD>(entity =>
            {
                entity.HasKey(e => e.HolidayDetailId);

                entity.ToTable("HRM_Holiday_D");

                entity.Property(e => e.HolidayDetailId).HasColumnName("HolidayDetailID");

                entity.Property(e => e.CreatedDt)
                    .HasColumnName("CreatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedUserId)
                    .HasColumnName("CreatedUserID")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.HolidayId).HasColumnName("HolidayID");

                entity.Property(e => e.ProcessGroupId).HasColumnName("ProcessGroupID");

                entity.Property(e => e.UpdatedDt)
                    .HasColumnName("UpdatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdatedUserId)
                    .HasColumnName("UpdatedUserID")
                    .HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<HrmHolidayM>(entity =>
            {
                entity.HasKey(e => e.HolidayId);

                entity.ToTable("HRM_Holiday_M");

                entity.Property(e => e.HolidayId).HasColumnName("HolidayID");

                entity.Property(e => e.CreatedDt)
                    .HasColumnName("CreatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedUserId)
                    .HasColumnName("CreatedUserID")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Date)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Reason)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.UpdatedDt)
                    .HasColumnName("UpdatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdatedUserId)
                    .HasColumnName("UpdatedUserID")
                    .HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<HrmLeaveAdditionM>(entity =>
            {
                entity.HasKey(e => e.EmployeeLeaveAdditionId);

                entity.ToTable("HRM_LeaveAddition_M");

                entity.Property(e => e.EmployeeLeaveAdditionId).HasColumnName("EmployeeLeaveAdditionID");

                entity.Property(e => e.AddedLeaves).HasColumnName("Added_Leaves");

                entity.Property(e => e.BalanceOld).HasColumnName("Balance_OLD");

                entity.Property(e => e.CreatedDt)
                    .HasColumnName("CreatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedUserId).HasColumnName("CreatedUserID");

                entity.Property(e => e.DesignationIdOld).HasColumnName("DesignationID_OLD");

                entity.Property(e => e.EffectiveDt)
                    .HasColumnName("EffectiveDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");

                entity.Property(e => e.LeaveTypeId).HasColumnName("LeaveTypeID");

                entity.Property(e => e.OpeningBalanceOld).HasColumnName("OpeningBalance_OLD");

                entity.Property(e => e.UpdatedDtOld)
                    .HasColumnName("UpdatedDT_OLD")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.UpdatedUserIdOld).HasColumnName("UpdatedUserID_OLD");
            });

            modelBuilder.Entity<HrmLeaveRejectionReasonM>(entity =>
            {
                entity.HasKey(e => e.LeaveRejectionReasonId);

                entity.ToTable("HRM_LeaveRejectionReason_M");

                entity.Property(e => e.LeaveRejectionReasonId).HasColumnName("LeaveRejectionReasonID");

                entity.Property(e => e.CreatedDt)
                    .HasColumnName("CreatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedUserId).HasColumnName("CreatedUserID");

                entity.Property(e => e.Description)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Reason)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedDt)
                    .HasColumnName("UpdatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdatedUserId).HasColumnName("UpdatedUserID");
            });

            modelBuilder.Entity<HrmLeaveRequestD>(entity =>
            {
                entity.HasKey(e => e.LeaveRequestDetailId);

                entity.ToTable("HRM_LeaveRequest_D");

                entity.Property(e => e.LeaveRequestDetailId).HasColumnName("LeaveRequestDetailID");

                entity.Property(e => e.CreatedDt)
                    .HasColumnName("CreatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedUserId).HasColumnName("CreatedUserID");

                entity.Property(e => e.Date).HasColumnType("smalldatetime");

                entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");

                entity.Property(e => e.LeaveRequestId).HasColumnName("LeaveRequestID");
            });

            modelBuilder.Entity<HrmLeaveRequestM>(entity =>
            {
                entity.HasKey(e => e.LeaveRequestId);

                entity.ToTable("HRM_LeaveRequest_M");

                entity.Property(e => e.LeaveRequestId).HasColumnName("LeaveRequestID");

                entity.Property(e => e.ApproveLeaveTypeId).HasColumnName("ApproveLeaveTypeID");

                entity.Property(e => e.ApprovedAdminOn).HasColumnType("smalldatetime");

                entity.Property(e => e.ApprovedDt)
                    .HasColumnName("ApprovedDT")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.ApprovedOn)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedDt)
                    .HasColumnName("CreatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedUserId).HasColumnName("CreatedUserID");

                entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");

                entity.Property(e => e.IsApproved)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('Pending')");

                entity.Property(e => e.IsApprovedByAdmin)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IsApprovedBySupervisor)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LeavePeriodFrom).HasColumnType("smalldatetime");

                entity.Property(e => e.LeavePeriodTo).HasColumnType("smalldatetime");

                entity.Property(e => e.LeaveRejectionReasonId).HasColumnName("LeaveRejectionReasonID");

                entity.Property(e => e.LeaveRejectionReasonIdSupervisor)
                    .HasColumnName("LeaveRejectionReasonID_Supervisor")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.LeaveRequestReasonId).HasColumnName("LeaveRequestReasonID");

                entity.Property(e => e.LeaveTypeId).HasColumnName("LeaveTypeID");

                entity.Property(e => e.Reason)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ReasonTypeId)
                    .HasColumnName("ReasonTypeID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Remarks)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ReportingTo).HasDefaultValueSql("((0))");

                entity.Property(e => e.RequestDt)
                    .HasColumnName("RequestDT")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.UpdatedDt)
                    .HasColumnName("UpdatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdatedUserId)
                    .HasColumnName("UpdatedUserID")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<HrmLeaveRequestReasonM>(entity =>
            {
                entity.HasKey(e => e.LeaveRequestReasonId);

                entity.ToTable("HRM_LeaveRequestReason_M");

                entity.Property(e => e.LeaveRequestReasonId).HasColumnName("LeaveRequestReasonID");

                entity.Property(e => e.CreatedDt)
                    .HasColumnName("CreatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedUserId).HasColumnName("CreatedUserID");

                entity.Property(e => e.Description)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Reason)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedDt)
                    .HasColumnName("UpdatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdatedUserId).HasColumnName("UpdatedUserID");
            });

            modelBuilder.Entity<HrmLeaveTypeM>(entity =>
            {
                entity.HasKey(e => e.LeaveTypeId);

                entity.ToTable("HRM_LeaveType_M");

                entity.Property(e => e.LeaveTypeId).HasColumnName("LeaveTypeID");

                entity.Property(e => e.CalenderDaysForAdditionFormula).HasColumnName("CalenderDays_For_AdditionFormula");

                entity.Property(e => e.CalenderDaysForEligibility).HasColumnName("CalenderDays_For_Eligibility");

                entity.Property(e => e.CreatedDt)
                    .HasColumnName("CreatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedUserId).HasColumnName("CreatedUserID");

                entity.Property(e => e.Description)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.FixedDateForLeaveAdditionPeriod)
                    .HasColumnName("FixedDate_For_LeaveAdditionPeriod")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FixedDateForLeaveExpiry)
                    .HasColumnName("FixedDate_For_LeaveExpiry")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.LeaveAddedCellX)
                    .HasColumnName("LeaveAdded_Cell_X")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.LeaveAddedCellY)
                    .IsRequired()
                    .HasColumnName("LeaveAdded_Cell_Y")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.LeaveAvailableCellX)
                    .HasColumnName("LeaveAvailable_Cell_X")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.LeaveAvailableCellY)
                    .IsRequired()
                    .HasColumnName("LeaveAvailable_Cell_Y")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.LeaveCategory)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.LeaveShortName)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.LeaveType)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LeaveUsedCellX)
                    .HasColumnName("LeaveUsed_Cell_X")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.LeaveUsedCellY)
                    .IsRequired()
                    .HasColumnName("LeaveUsed_Cell_Y")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.MaximumLeaves).HasDefaultValueSql("((0))");

                entity.Property(e => e.MaximumLeavesForEncashment).HasColumnName("MaximumLeaves_For_Encashment");

                entity.Property(e => e.MinimumLeavesForEncashment).HasColumnName("MinimumLeaves_For_Encashment");

                entity.Property(e => e.MonthsForLeaveAdditionPeriod).HasColumnName("Months_For_LeaveAdditionPeriod");

                entity.Property(e => e.MonthsForLeaveExpiry).HasColumnName("Months_For_LeaveExpiry");

                entity.Property(e => e.Payability).HasDefaultValueSql("((0))");

                entity.Property(e => e.UpdatedDt)
                    .HasColumnName("UpdatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdatedUserId).HasColumnName("UpdatedUserID");

                entity.Property(e => e.WorkingDaysForAdditionFormula).HasColumnName("WorkingDays_For_AdditionFormula");

                entity.Property(e => e.WorkingDaysForEligibility).HasColumnName("WorkingDays_For_Eligibility");
            });

            modelBuilder.Entity<HrmProjectM>(entity =>
            {
                entity.HasKey(e => e.ProjectId);

                entity.ToTable("HRM_Project_M");

                entity.Property(e => e.ProjectId).HasColumnName("ProjectID");

                entity.Property(e => e.AccessType).HasDefaultValueSql("((0))");

                entity.Property(e => e.CreatedDt)
                    .HasColumnName("CreatedDT")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.CreatedUserId).HasColumnName("CreatedUserID");

                entity.Property(e => e.IsPersonal).HasDefaultValueSql("((0))");

                entity.Property(e => e.ProjectManagerEmpId)
                    .HasColumnName("ProjectManagerEmpID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ProjectName)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedDt)
                    .HasColumnName("UpdatedDT")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.UpdatedUserId).HasColumnName("UpdatedUserID");
            });

            modelBuilder.Entity<HrmProjectTeam>(entity =>
            {
                entity.HasKey(e => e.ProjectTeamId);

                entity.ToTable("HRM_ProjectTeam");

                entity.Property(e => e.ProjectTeamId).HasColumnName("ProjectTeamID");

                entity.Property(e => e.Access).HasDefaultValueSql("((0))");

                entity.Property(e => e.CreatedDt)
                    .HasColumnName("CreatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedUserId)
                    .HasColumnName("CreatedUserID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");

                entity.Property(e => e.ProjectId).HasColumnName("ProjectID");

                entity.Property(e => e.UpdatedDt)
                    .HasColumnName("UpdatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdatedUserId)
                    .HasColumnName("UpdatedUserID")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<HrmQualificationD>(entity =>
            {
                entity.HasKey(e => e.QualificationDetId);

                entity.ToTable("HRM_Qualification_D");

                entity.Property(e => e.QualificationDetId).HasColumnName("QualificationDetID");

                entity.Property(e => e.CreatedDt)
                    .HasColumnName("CreatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedUserId).HasColumnName("CreatedUserID");

                entity.Property(e => e.EmployeeTypeId).HasColumnName("EmployeeTypeID");

                entity.Property(e => e.QualificationId).HasColumnName("QualificationID");

                entity.Property(e => e.UpdatedDt)
                    .HasColumnName("UpdatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdatedUserId).HasColumnName("UpdatedUserID");
            });

            modelBuilder.Entity<HrmQualificationM>(entity =>
            {
                entity.HasKey(e => e.QualificationId);

                entity.ToTable("HRM_Qualification_M");

                entity.Property(e => e.QualificationId).HasColumnName("QualificationID");

                entity.Property(e => e.CreatedDt)
                    .HasColumnName("CreatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedUserId).HasColumnName("CreatedUserID");

                entity.Property(e => e.QualificationName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ShortName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Specialization)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedDt)
                    .HasColumnName("UpdatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdatedUserId).HasColumnName("UpdatedUserID");
            });

            modelBuilder.Entity<HrmReasonForTerminationM>(entity =>
            {
                entity.HasKey(e => e.ReasonId);

                entity.ToTable("HRM_ReasonForTermination_M");

                entity.Property(e => e.Reason)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<HrmRecordCategory>(entity =>
            {
                entity.HasKey(e => e.RecordCategoryId);

                entity.ToTable("HRM_RecordCategory");

                entity.Property(e => e.RecordCategoryId).HasColumnName("RecordCategoryID");

                entity.Property(e => e.CreatedDt)
                    .HasColumnName("CreatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedUserId)
                    .HasColumnName("CreatedUserID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.RecordCategoryName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedDt)
                    .HasColumnName("UpdatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdatedUserId)
                    .HasColumnName("UpdatedUserID")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<HrmRecordD>(entity =>
            {
                entity.HasKey(e => e.RecordFieldId);

                entity.ToTable("HRM_Record_D");

                entity.Property(e => e.RecordFieldId).HasColumnName("RecordFieldID");

                entity.Property(e => e.CreatedDt)
                    .HasColumnName("CreatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedUserId)
                    .HasColumnName("CreatedUserID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Field)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RecordId).HasColumnName("RecordID");

                entity.Property(e => e.UpdatedDt)
                    .HasColumnName("UpdatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdatedUserId)
                    .HasColumnName("UpdatedUserID")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<HrmRecordM>(entity =>
            {
                entity.HasKey(e => e.RecordId);

                entity.ToTable("HRM_Record_M");

                entity.Property(e => e.RecordId).HasColumnName("RecordID");

                entity.Property(e => e.CreatedDt)
                    .HasColumnName("CreatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedUserId)
                    .HasColumnName("CreatedUserID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.RecordCategoryId).HasColumnName("RecordCategoryID");

                entity.Property(e => e.RecordName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedDt)
                    .HasColumnName("UpdatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdatedUserId)
                    .HasColumnName("UpdatedUserID")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<HrmRecSkillD>(entity =>
            {
                entity.HasKey(e => e.SkillDetId);

                entity.ToTable("HRM_Rec_Skill_D");

                entity.Property(e => e.SkillDetId).HasColumnName("SkillDetID");

                entity.Property(e => e.CreatedDt)
                    .HasColumnName("CreatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedUserId).HasColumnName("CreatedUserID");

                entity.Property(e => e.EmployeeTypeId).HasColumnName("EmployeeTypeID");

                entity.Property(e => e.SkillId).HasColumnName("SkillID");

                entity.Property(e => e.UpdatedDt)
                    .HasColumnName("UpdatedDT")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.UpdatedUserId).HasColumnName("UpdatedUserID");
            });

            modelBuilder.Entity<HrmReminderNote>(entity =>
            {
                entity.HasKey(e => e.NoteId);

                entity.ToTable("HRM_ReminderNote");

                entity.Property(e => e.NoteId).HasColumnName("NoteID");

                entity.Property(e => e.CreatedDt)
                    .HasColumnName("CreatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedUserId)
                    .HasColumnName("CreatedUserID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Note)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.NoteDt)
                    .HasColumnName("NoteDT")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.NoteEntryEmployeeId).HasColumnName("NoteEntryEmployeeID");

                entity.Property(e => e.ReminderId).HasColumnName("ReminderID");
            });

            modelBuilder.Entity<HrmRemindersM>(entity =>
            {
                entity.HasKey(e => e.ReminderId);

                entity.ToTable("HRM_Reminders_M");

                entity.Property(e => e.ReminderId).HasColumnName("ReminderID");

                entity.Property(e => e.CompletedOn).HasColumnType("smalldatetime");

                entity.Property(e => e.CompletionDuration).HasDefaultValueSql("((0))");

                entity.Property(e => e.CompletionPercentage).HasDefaultValueSql("((0))");

                entity.Property(e => e.CreatedDt)
                    .HasColumnName("CreatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedUserId)
                    .HasColumnName("CreatedUserID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CustomerId).HasColumnName("CustomerID");

                entity.Property(e => e.Details).IsUnicode(false);

                entity.Property(e => e.GenieMailId).HasColumnName("GenieMailID");

                entity.Property(e => e.Note)
                    .IsRequired()
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ReferenceId)
                    .HasColumnName("ReferenceID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ReferenceName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ReferenceTypeId)
                    .HasColumnName("ReferenceTypeID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ReminderDt)
                    .HasColumnName("ReminderDT")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.ReminderForEmployeeId).HasColumnName("ReminderForEmployeeID");

                entity.Property(e => e.RoleId).HasColumnName("RoleID");

                entity.Property(e => e.ShowTaskTimeToReceiver).HasColumnName("Show_TaskTime_ToReceiver");

                entity.Property(e => e.Status).HasDefaultValueSql("((0))");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedDt)
                    .HasColumnName("UpdatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdatedUserId)
                    .HasColumnName("UpdatedUserID")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<HrmRoleM>(entity =>
            {
                entity.HasKey(e => e.RoleId);

                entity.ToTable("HRM_Role_M");

                entity.Property(e => e.RoleId).HasColumnName("RoleID");

                entity.Property(e => e.CreatedDt)
                    .HasColumnName("CreatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedUserId).HasColumnName("CreatedUserID");

                entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");

                entity.Property(e => e.RoleName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedDt)
                    .HasColumnName("UpdatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdatedUserId).HasColumnName("UpdatedUserID");
            });

            modelBuilder.Entity<HrmRoleSkillsD>(entity =>
            {
                entity.HasKey(e => e.RoleSkillDetId);

                entity.ToTable("HRM_Role_Skills_D");

                entity.Property(e => e.RoleSkillDetId).HasColumnName("RoleSkillDetID");

                entity.Property(e => e.CreatedDt)
                    .HasColumnName("CreatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedUserId).HasColumnName("CreatedUserID");

                entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");

                entity.Property(e => e.RoleId).HasColumnName("RoleID");

                entity.Property(e => e.SkillId).HasColumnName("SkillID");

                entity.Property(e => e.UpdatedDt)
                    .HasColumnName("UpdatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdatedUserId).HasColumnName("UpdatedUserID");
            });

            modelBuilder.Entity<HrmSalaryComponentM>(entity =>
            {
                entity.HasKey(e => e.SalaryComponentId);

                entity.ToTable("HRM_SalaryComponent_M");

                entity.Property(e => e.SalaryComponentId).HasColumnName("SalaryComponentID");

                entity.Property(e => e.Applicability)
                    .IsRequired()
                    .HasColumnType("char(1)");

                entity.Property(e => e.CellAddressX)
                    .HasColumnName("CellAddress_X")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CellAddressY)
                    .HasColumnName("CellAddress_Y")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDt)
                    .HasColumnName("CreatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedUserId)
                    .HasColumnName("CreatedUserID")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.LedgerId).HasColumnName("LedgerID");

                entity.Property(e => e.SalaryComponentName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.UpdatedDt)
                    .HasColumnName("UpdatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdatedUserId)
                    .HasColumnName("UpdatedUserID")
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<HrmSalaryExpenseHead>(entity =>
            {
                entity.HasKey(e => e.SalaryExpHeadId);

                entity.ToTable("HRM_SalaryExpenseHead");

                entity.Property(e => e.SalaryExpHeadId).HasColumnName("SalaryExpHeadID");

                entity.Property(e => e.CreatedDt)
                    .HasColumnName("CreatedDT")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.CreatedUserId).HasColumnName("CreatedUserID");

                entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");

                entity.Property(e => e.IsDeleted)
                    .IsRequired()
                    .HasColumnType("char(10)");

                entity.Property(e => e.LedgerId).HasColumnName("LedgerID");

                entity.Property(e => e.UpdatedDt)
                    .HasColumnName("UpdatedDT")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.UpdatedUserId).HasColumnName("UpdatedUserID");
            });

            modelBuilder.Entity<HrmSalaryExpenseHeadHistory>(entity =>
            {
                entity.HasKey(e => e.SalaryExpHeadHistoryId);

                entity.ToTable("HRM_SalaryExpenseHead_History");

                entity.Property(e => e.SalaryExpHeadHistoryId).HasColumnName("SalaryExpHeadHistoryID");

                entity.Property(e => e.CreatedDt)
                    .HasColumnName("CreatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedUserId).HasColumnName("CreatedUserID");

                entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");

                entity.Property(e => e.LedgerId)
                    .HasColumnName("LedgerID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Role).HasDefaultValueSql("((0))");

                entity.Property(e => e.SalaryFromDt)
                    .HasColumnName("SalaryFromDT")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.SalaryToDt)
                    .HasColumnName("SalaryToDT")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.UpdatedDt)
                    .HasColumnName("UpdatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdatedUserId).HasColumnName("UpdatedUserID");
            });

            modelBuilder.Entity<HrmSalarySlipD>(entity =>
            {
                entity.HasKey(e => e.SalarySlipDetailId);

                entity.ToTable("HRM_SalarySlip_D");

                entity.Property(e => e.SalarySlipDetailId)
                    .HasColumnName("SalarySlipDetailID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Amount).HasDefaultValueSql("((0))");

                entity.Property(e => e.ApplicableAmountDeleteItLater)
                    .HasColumnName("ApplicableAmount_Delete_It_Later")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CreatedDt)
                    .HasColumnName("CreatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedUserId)
                    .HasColumnName("CreatedUserID")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.SalaryComponentId)
                    .HasColumnName("SalaryComponentID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.SalarySlipId)
                    .HasColumnName("SalarySlipID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.UpdatedDt)
                    .HasColumnName("UpdatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdatedUserId)
                    .HasColumnName("UpdatedUserID")
                    .HasDefaultValueSql("((1))");

                entity.HasOne(d => d.SalarySlipDetail)
                    .WithOne(p => p.InverseSalarySlipDetail)
                    .HasForeignKey<HrmSalarySlipD>(d => d.SalarySlipDetailId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_HRM_SalarySlip_D_HRM_SalarySlip_D");
            });

            modelBuilder.Entity<HrmSalarySlipM>(entity =>
            {
                entity.HasKey(e => e.SalarySlipId);

                entity.ToTable("HRM_SalarySlip_M");

                entity.Property(e => e.SalarySlipId).HasColumnName("SalarySlipID");

                entity.Property(e => e.ApplicableMonth).HasMaxLength(50);

                entity.Property(e => e.CreatedDt)
                    .HasColumnName("CreatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedUserId)
                    .HasColumnName("CreatedUserID")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Ctc)
                    .HasColumnName("CTC")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.EmployeeId)
                    .HasColumnName("EmployeeID")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Otamount).HasColumnName("OTAmount");

                entity.Property(e => e.Otdays).HasColumnName("OTDays");

                entity.Property(e => e.Othours)
                    .HasColumnName("OTHours")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.SalaryFromDt)
                    .HasColumnName("SalaryFromDT")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.SalarySlipNo).HasDefaultValueSql("((0))");

                entity.Property(e => e.SalaryToDt)
                    .HasColumnName("SalaryToDT")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.TotalAttendedDays).HasDefaultValueSql("((0))");

                entity.Property(e => e.TotalWorkingDays).HasDefaultValueSql("((0))");

                entity.Property(e => e.UpdatedDt)
                    .HasColumnName("UpdatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdatedUserId)
                    .HasColumnName("UpdatedUserID")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.VoucherId)
                    .HasColumnName("VoucherID")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<HrmShiftM>(entity =>
            {
                entity.HasKey(e => e.ShiftId);

                entity.ToTable("HRM_Shift_M");

                entity.Property(e => e.ShiftId).HasColumnName("ShiftID");

                entity.Property(e => e.CreatedDt)
                    .HasColumnName("CreatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedUserId).HasColumnName("CreatedUserID");

                entity.Property(e => e.Endtime).HasColumnType("smalldatetime");

                entity.Property(e => e.ShiftName)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Starttime).HasColumnType("smalldatetime");

                entity.Property(e => e.UpdatedDt)
                    .HasColumnName("UpdatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdatedUserId).HasColumnName("UpdatedUserID");
            });

            modelBuilder.Entity<HrmSkillAdditionPlanM>(entity =>
            {
                entity.HasKey(e => e.SkillAdditionId);

                entity.ToTable("HRM_SkillAdditionPlan_M");

                entity.Property(e => e.SkillAdditionId).HasColumnName("SkillAdditionID");

                entity.Property(e => e.CreatedDt)
                    .HasColumnName("CreatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedUserId)
                    .HasColumnName("CreatedUserID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");

                entity.Property(e => e.LevelId).HasColumnName("LevelID");

                entity.Property(e => e.SkillId).HasColumnName("SkillID");

                entity.Property(e => e.UpdatedDt)
                    .HasColumnName("UpdatedDT")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.UpdatedUserId)
                    .HasColumnName("UpdatedUserID")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<HrmSkillAdditionRecord>(entity =>
            {
                entity.ToTable("HRM_SkillAdditionRecord");

                entity.Property(e => e.AdditionType)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CategoryId).HasColumnName("CategoryID");

                entity.Property(e => e.Description)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");

                entity.Property(e => e.LevelId).HasColumnName("LevelID");

                entity.Property(e => e.SkillId).HasColumnName("SkillID");

                entity.Property(e => e.UpdatedDt)
                    .HasColumnName("UpdatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdatedUserId).HasColumnName("UpdatedUserID");
            });

            modelBuilder.Entity<HrmTaskPreRequisite>(entity =>
            {
                entity.HasKey(e => e.TaskPreRequisiteId);

                entity.ToTable("HRM_TaskPreRequisite");

                entity.Property(e => e.TaskPreRequisiteId).HasColumnName("TaskPreRequisiteID");

                entity.Property(e => e.CreatedDt)
                    .HasColumnName("CreatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedUserId)
                    .HasColumnName("CreatedUserID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.PreRequisiteId).HasColumnName("PreRequisiteID");

                entity.Property(e => e.TaskId).HasColumnName("TaskID");

                entity.Property(e => e.UpdatedDt)
                    .HasColumnName("UpdatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdatedUserId)
                    .HasColumnName("UpdatedUserID")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<HrmTaskSchedule>(entity =>
            {
                entity.HasKey(e => e.TaskScheduleId);

                entity.ToTable("HRM_TaskSchedule");

                entity.Property(e => e.TaskScheduleId).HasColumnName("TaskScheduleID");

                entity.Property(e => e.CreatedDt)
                    .HasColumnName("CreatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedUserId)
                    .HasColumnName("CreatedUserID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.EndTime).HasColumnType("smalldatetime");

                entity.Property(e => e.StartTime).HasColumnType("smalldatetime");

                entity.Property(e => e.TaskId).HasColumnName("TaskID");

                entity.Property(e => e.UpdatedDt)
                    .HasColumnName("UpdatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdatedUserId)
                    .HasColumnName("UpdatedUserID")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<HrmTickTock>(entity =>
            {
                entity.HasKey(e => e.TickTockId);

                entity.ToTable("HRM_TickTock");

                entity.Property(e => e.TickTockId).HasColumnName("TickTockID");

                entity.Property(e => e.CreatedDt)
                    .HasColumnName("CreatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedUserId)
                    .HasColumnName("CreatedUserID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");

                entity.Property(e => e.EndTime).HasColumnType("smalldatetime");

                entity.Property(e => e.Note).IsUnicode(false);

                entity.Property(e => e.StartTime)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.TaskId)
                    .HasColumnName("TaskID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedDt)
                    .HasColumnName("UpdatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdatedUserId)
                    .HasColumnName("UpdatedUserID")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<HrmTrainingAttendeesD>(entity =>
            {
                entity.HasKey(e => e.AttendeeId);

                entity.ToTable("HRM_TrainingAttendees_D");

                entity.Property(e => e.AttendeeId).HasColumnName("AttendeeID");

                entity.Property(e => e.CreatedDt)
                    .HasColumnName("CreatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedUserId).HasColumnName("CreatedUserID");

                entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");

                entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");

                entity.Property(e => e.TrainingId).HasColumnName("TrainingID");

                entity.Property(e => e.UpdatedDt)
                    .HasColumnName("UpdatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdatedUserId).HasColumnName("UpdatedUserID");
            });

            modelBuilder.Entity<HrmTrainingM>(entity =>
            {
                entity.HasKey(e => e.TrainingId);

                entity.ToTable("HRM_Training_M");

                entity.Property(e => e.TrainingId).HasColumnName("TrainingID");

                entity.Property(e => e.CreatedDt)
                    .HasColumnName("CreatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedUserId)
                    .HasColumnName("CreatedUserID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.EndDate).HasColumnType("smalldatetime");

                entity.Property(e => e.EndTime).HasColumnType("smalldatetime");

                entity.Property(e => e.InChargeId).HasColumnName("InChargeID");

                entity.Property(e => e.StartDate).HasColumnType("smalldatetime");

                entity.Property(e => e.StartTime).HasColumnType("smalldatetime");

                entity.Property(e => e.Title)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.TrainerName)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedDt)
                    .HasColumnName("UpdatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdatedUserId)
                    .HasColumnName("UpdatedUserID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Venue)
                    .HasMaxLength(500)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<HrmTrainingObjectivesD>(entity =>
            {
                entity.HasKey(e => e.ObjectiveId);

                entity.ToTable("HRM_TrainingObjectives_D");

                entity.Property(e => e.ObjectiveId).HasColumnName("ObjectiveID");

                entity.Property(e => e.CreatedDt)
                    .HasColumnName("CreatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedUserId).HasColumnName("CreatedUserID");

                entity.Property(e => e.LevelId).HasColumnName("LevelID");

                entity.Property(e => e.SkillId).HasColumnName("SkillID");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.TrainingId).HasColumnName("TrainingID");

                entity.Property(e => e.UpdatedDt)
                    .HasColumnName("UpdatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdatedUserId).HasColumnName("UpdatedUserID");
            });

            modelBuilder.Entity<HrmTrainingSkillsD>(entity =>
            {
                entity.HasKey(e => e.TrainingSkillId);

                entity.ToTable("HRM_TrainingSkills_D");

                entity.Property(e => e.TrainingSkillId).HasColumnName("TrainingSkillID");

                entity.Property(e => e.CreatedDt)
                    .HasColumnName("CreatedDT")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.CreatedUserId).HasColumnName("CreatedUserID");

                entity.Property(e => e.LevelId).HasColumnName("LevelID");

                entity.Property(e => e.SkillId).HasColumnName("SkillID");

                entity.Property(e => e.TrainingId).HasColumnName("TrainingID");

                entity.Property(e => e.UpdatedDt)
                    .HasColumnName("UpdatedDT")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.UpdatedUserId).HasColumnName("UpdatedUserID");
            });

            modelBuilder.Entity<HrmTrainingTimeD>(entity =>
            {
                entity.HasKey(e => e.TrainingDtid);

                entity.ToTable("HRM_TrainingTime_D");

                entity.Property(e => e.TrainingDtid).HasColumnName("TrainingDTID");

                entity.Property(e => e.CreatedDt)
                    .HasColumnName("CreatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedUserId).HasColumnName("CreatedUserID");

                entity.Property(e => e.EndTime).HasColumnType("smalldatetime");

                entity.Property(e => e.EventDate).HasColumnType("smalldatetime");

                entity.Property(e => e.EventId).HasColumnName("EventID");

                entity.Property(e => e.StartTime).HasColumnType("smalldatetime");

                entity.Property(e => e.UpdatedDt)
                    .HasColumnName("UpdatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdatedUserId).HasColumnName("UpdatedUserID");
            });

            modelBuilder.Entity<HrmUserActivityLogD>(entity =>
            {
                entity.HasKey(e => e.UserActivityLogId);

                entity.ToTable("HRM_UserActivityLog_D");

                entity.Property(e => e.UserActivityLogId).HasColumnName("UserActivityLogID");

                entity.Property(e => e.ActionDescription)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ActionTypeId).HasColumnName("ActionTypeID");

                entity.Property(e => e.Date)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UserId).HasColumnName("UserID");
            });

            modelBuilder.Entity<Inbox>(entity =>
            {
                entity.HasKey(e => e.MessageId);

                entity.Property(e => e.MessageId).HasColumnName("MessageID");

                entity.Property(e => e.CreatedDt)
                    .HasColumnName("CreatedDT")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Message)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.PhoneNo)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.ReadDt)
                    .HasColumnName("ReadDT")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<Message>(entity =>
            {
                entity.Property(e => e.CitizenId)
                    .HasColumnName("CitizenID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDateTime)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");

                entity.Property(e => e.Error)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.InvoiceId).HasColumnName("InvoiceID");

                entity.Property(e => e.MachineId).HasColumnName("MachineID");

                entity.Property(e => e.MachineMaintenanceId).HasColumnName("MachineMaintenanceID");

                entity.Property(e => e.Message1)
                    .HasColumnName("Message")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.MessageType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MessageTypeId).HasColumnName("MessageTypeID");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SendToNo)
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.SentDateTime).HasColumnType("smalldatetime");

                entity.Property(e => e.WorkOrderId).HasColumnName("WorkOrderID");
            });

            modelBuilder.Entity<MktAutoQuoteD>(entity =>
            {
                entity.HasKey(e => e.AutoQuoteDetId);

                entity.ToTable("MKT_AutoQuote_D");

                entity.Property(e => e.AutoQuoteDetId).HasColumnName("AutoQuoteDetID");

                entity.Property(e => e.CreatedDt)
                    .HasColumnName("CreatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedUserId).HasColumnName("CreatedUserID");

                entity.Property(e => e.FieldValue).HasMaxLength(50);

                entity.Property(e => e.FieldValueId).HasColumnName("FieldValueID");

                entity.Property(e => e.MaterialFieldId).HasColumnName("MaterialFieldID");

                entity.Property(e => e.Rfqid).HasColumnName("RFQID");

                entity.Property(e => e.UpdatedDt)
                    .HasColumnName("UpdatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdatedUserId).HasColumnName("UpdatedUserID");
            });

            modelBuilder.Entity<MktBusinessActivityM>(entity =>
            {
                entity.HasKey(e => e.BusinessActivityId);

                entity.ToTable("MKT_BusinessActivity_M");

                entity.Property(e => e.BusinessActivityId)
                    .HasColumnName("BusinessActivityID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.BusinessActivity)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDt)
                    .HasColumnName("CreatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedUserId).HasColumnName("CreatedUserID");

                entity.Property(e => e.UpdatedDt)
                    .HasColumnName("UpdatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdatedUserId).HasColumnName("UpdatedUserID");
            });

            modelBuilder.Entity<MktCommunication>(entity =>
            {
                entity.HasKey(e => e.CommunicationId);

                entity.ToTable("MKT_Communication");

                entity.Property(e => e.CommunicationId).HasColumnName("CommunicationID");

                entity.Property(e => e.CommunicationTypeId)
                    .HasColumnName("CommunicationTypeID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.CreatedDt)
                    .HasColumnName("CreatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedUserId).HasColumnName("CreatedUserID");

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.Designation)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Details)
                    .HasMaxLength(800)
                    .IsUnicode(false);

                entity.Property(e => e.InitiatedBy)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.InteractedWith)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Mode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Topic)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedDt)
                    .HasColumnName("UpdatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdatedUserId).HasColumnName("UpdatedUserID");
            });

            modelBuilder.Entity<MktCommunicationTypes>(entity =>
            {
                entity.HasKey(e => e.CommunicationTypeId);

                entity.ToTable("MKT_CommunicationTypes");

                entity.Property(e => e.CommunicationTypeId).HasColumnName("CommunicationTypeID");

                entity.Property(e => e.CommunicationType)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDt)
                    .HasColumnName("CreatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedUserId)
                    .HasColumnName("CreatedUserID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Description)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedDt)
                    .HasColumnName("UpdatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdatedUserId)
                    .HasColumnName("UpdatedUserID")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<MktCompanyAddressD>(entity =>
            {
                entity.HasKey(e => e.CompanyAddressDetailId);

                entity.ToTable("MKT_CompanyAddress_D");

                entity.Property(e => e.CompanyAddressDetailId).HasColumnName("CompanyAddressDetailID");

                entity.Property(e => e.CompanyAddress1)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyAddress2)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyAddressType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyCity)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyCityId).HasColumnName("CompanyCityID");

                entity.Property(e => e.CompanyCountry)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyCountryId).HasColumnName("CompanyCountryID");

                entity.Property(e => e.CompanyEmail)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyFaxDialingCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyFaxNo)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.CompanyPhoneNo)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyPhoneNoDialingCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyPincode)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyState)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyStateId).HasColumnName("CompanyStateID");

                entity.Property(e => e.CompanyWebsite)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDt)
                    .HasColumnName("CreatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedUserId)
                    .HasColumnName("CreatedUserID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.UpdatedDt)
                    .HasColumnName("UpdatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdatedUserId)
                    .HasColumnName("UpdatedUserID")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<MktCompanyClassM>(entity =>
            {
                entity.HasKey(e => e.CompanyClassId);

                entity.ToTable("MKT_CompanyClass_M");

                entity.Property(e => e.CompanyClassId)
                    .HasColumnName("CompanyClassID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.CompanyClassName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.GroupId)
                    .HasColumnName("GroupID")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<MktCompanyContactPersonD>(entity =>
            {
                entity.HasKey(e => e.CompanyContactPersonId);

                entity.ToTable("MKT_CompanyContactPerson_D");

                entity.Property(e => e.CompanyContactPersonId).HasColumnName("CompanyContactPersonID");

                entity.Property(e => e.CompanyAddressDetailId)
                    .HasColumnName("CompanyAddressDetailID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.CreatedDt)
                    .HasColumnName("CreatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedUserId).HasColumnName("CreatedUserID");

                entity.Property(e => e.Designation)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EmailId)
                    .IsRequired()
                    .HasColumnName("EmailID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MobileNo)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.MobileNoDialingCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PersonName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PersonTitle)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PersonTitleId).HasColumnName("PersonTitleID");

                entity.Property(e => e.UpdatedDt)
                    .HasColumnName("UpdatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdatedUserId).HasColumnName("UpdatedUserID");
            });

            modelBuilder.Entity<MktCompanyDeliveryD>(entity =>
            {
                entity.HasKey(e => e.DeliveryId);

                entity.ToTable("MKT_CompanyDelivery_D");

                entity.Property(e => e.DeliveryId).HasColumnName("DeliveryID");

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.CreatedDt)
                    .HasColumnName("CreatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedUserId).HasColumnName("CreatedUserID");

                entity.Property(e => e.ShipperId).HasColumnName("ShipperID");

                entity.Property(e => e.ShippingCost).HasDefaultValueSql("((0))");

                entity.Property(e => e.ShippingModeId)
                    .HasColumnName("ShippingModeID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ShippingPeriodInDays)
                    .HasColumnName("ShippingPeriod_In_Days")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.UpdatedDt)
                    .HasColumnName("UpdatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdatedUserId).HasColumnName("UpdatedUserID");
            });

            modelBuilder.Entity<MktCompanyM>(entity =>
            {
                entity.HasKey(e => e.CompanyId);

                entity.ToTable("MKT_Company_M");

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.AccountNum)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.AdvanceInPercent).HasDefaultValueSql("((0))");

                entity.Property(e => e.AdvanceInRs).HasDefaultValueSql("((0))");

                entity.Property(e => e.AlertAccountsTeamNums)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.AnnualTargetBusinessVolume).HasDefaultValueSql("((0))");

                entity.Property(e => e.BankName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BillingAddress1)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.BillingAddress2)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.BillingCity)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BillingCityId).HasColumnName("BillingCityID");

                entity.Property(e => e.BillingCountry)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BillingCountryId).HasColumnName("BillingCountryID");

                entity.Property(e => e.BillingPincode)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.BillingState)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BillingStateId).HasColumnName("BillingStateID");

                entity.Property(e => e.BusinessActivityId).HasColumnName("BusinessActivityID");

                entity.Property(e => e.CompanyAddress1)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyAddress2)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyCity)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyCityId).HasColumnName("CompanyCityID");

                entity.Property(e => e.CompanyCode)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyCountry)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyCountryId).HasColumnName("CompanyCountryID");

                entity.Property(e => e.CompanyCstdate)
                    .HasColumnName("CompanyCSTDate")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.CompanyCstno)
                    .IsRequired()
                    .HasColumnName("CompanyCSTNo")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyEccno)
                    .IsRequired()
                    .HasColumnName("CompanyECCNo")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyEmail)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyFaxDialingCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyFaxNo)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyPhoneNo)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyPhoneNoDialingCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyPincode)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyShortName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyState)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyStateId).HasColumnName("CompanyStateID");

                entity.Property(e => e.CompanyTindate)
                    .HasColumnName("CompanyTINDate")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.CompanyTinno)
                    .IsRequired()
                    .HasColumnName("CompanyTINNo")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyWebsite)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ContactPerson)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ContactPersonDesignation)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ContactPersonEmail)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ContactPersonPhoneNo)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.ContactPersonPhoneNoDialingCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDt)
                    .HasColumnName("CreatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedUserId).HasColumnName("CreatedUserID");

                entity.Property(e => e.CreditLimit).HasDefaultValueSql("((0))");

                entity.Property(e => e.CreditPeriodForFullPayment).HasDefaultValueSql("((0))");

                entity.Property(e => e.CurrencyId).HasColumnName("CurrencyID");

                entity.Property(e => e.CustomerCategoryId)
                    .HasColumnName("CustomerCategoryID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.DeliveryAddress1)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DeliveryAddress2)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DeliveryCity)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DeliveryCityId).HasColumnName("DeliveryCityID");

                entity.Property(e => e.DeliveryCountry)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DeliveryCountryId).HasColumnName("DeliveryCountryID");

                entity.Property(e => e.DeliveryPincode)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.DeliveryState)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DeliveryStateId).HasColumnName("DeliveryStateID");

                entity.Property(e => e.DeliveryTypeId).HasColumnName("DeliveryTypeID");

                entity.Property(e => e.ExcessQuantityPercent).HasDefaultValueSql("((0))");

                entity.Property(e => e.ExciseTaxId)
                    .HasColumnName("ExciseTaxID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.InvoiceTypeId)
                    .HasColumnName("InvoiceTypeID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.IsBillingModeExport).HasColumnName("IsBillingMode_Export");

                entity.Property(e => e.IsShowJobStatusToCustomer).HasColumnName("IsShow_JobStatus_ToCustomer");

                entity.Property(e => e.LedgerId).HasColumnName("LedgerID");

                entity.Property(e => e.ModeOfTransportId)
                    .HasColumnName("ModeOfTransportID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Notes)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.NxtEmployee).HasDefaultValueSql("((0))");

                entity.Property(e => e.NxtIntDt)
                    .HasColumnName("NxtIntDT")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.NxtIntType).HasDefaultValueSql("((0))");

                entity.Property(e => e.NxtReminderId)
                    .HasColumnName("NxtReminderID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.NxtWithWhom)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.OrganizationHead)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.OrganizationHeadDesignation)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OrganizationHeadEmail)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OrganizationHeadPhoneNo)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.OrganizationHeadPhoneNoDialingCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PaymentTypeId)
                    .HasColumnName("PaymentTypeID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.PortOfDischarge)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.QuantityLimit).HasDefaultValueSql("((0))");

                entity.Property(e => e.RoleId)
                    .HasColumnName("RoleID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.RoutingDetails)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SalesTaxId)
                    .HasColumnName("SalesTaxID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ServiceTaxId).HasColumnName("ServiceTaxID");

                entity.Property(e => e.ShipperDelivery).HasDefaultValueSql("((0))");

                entity.Property(e => e.ShipperId).HasColumnName("ShipperID");

                entity.Property(e => e.ShippingMode)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ShippingPeriod).HasDefaultValueSql("((0))");

                entity.Property(e => e.ShippingPeriodInDays).HasColumnName("ShippingPeriod_InDays");

                entity.Property(e => e.TitleContactPerson)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.TitleOrganizationHead)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.TypeOfProductId).HasColumnName("TypeOfProductID");

                entity.Property(e => e.UpdatedDt)
                    .HasColumnName("UpdatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdatedUserId).HasColumnName("UpdatedUserID");
            });

            modelBuilder.Entity<MktCompanyPagesD>(entity =>
            {
                entity.HasKey(e => e.CompanyPageId);

                entity.ToTable("MKT_CompanyPages_D");

                entity.Property(e => e.CompanyPageId).HasColumnName("CompanyPageID");

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.CreatedDt)
                    .HasColumnName("CreatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedUserId).HasColumnName("CreatedUserID");

                entity.Property(e => e.UpdatedDt)
                    .HasColumnName("UpdatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdatedUserId).HasColumnName("UpdatedUserID");

                entity.Property(e => e.WebPageId).HasColumnName("WebPageID");
            });

            modelBuilder.Entity<MktCompanyRecordD>(entity =>
            {
                entity.HasKey(e => e.CompanyRecordId);

                entity.ToTable("MKT_CompanyRecord_D");

                entity.Property(e => e.CompanyRecordId).HasColumnName("CompanyRecordID");

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.CreatedDt)
                    .HasColumnName("CreatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedUserId)
                    .HasColumnName("CreatedUserID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Details)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Title)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MktCompanyShipping>(entity =>
            {
                entity.HasKey(e => e.CompanyShippingId);

                entity.ToTable("MKT_CompanyShipping");

                entity.Property(e => e.CompanyShippingId).HasColumnName("CompanyShippingID");

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.CreatedDt)
                    .HasColumnName("CreatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedUserId).HasColumnName("CreatedUserID");

                entity.Property(e => e.ModeOfTransportId).HasColumnName("ModeOfTransportID");

                entity.Property(e => e.ShippingMode)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedDt)
                    .HasColumnName("UpdatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdatedUserId).HasColumnName("UpdatedUserID");
            });

            modelBuilder.Entity<MktCompanyTaxClassification>(entity =>
            {
                entity.HasKey(e => e.CompanyTaxClassificationId);

                entity.ToTable("MKT_CompanyTaxClassification");

                entity.Property(e => e.CompanyTaxClassificationId).HasColumnName("CompanyTaxClassificationID");

                entity.Property(e => e.ClassificationId).HasColumnName("ClassificationID");

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.CreatedDt)
                    .HasColumnName("CreatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedUserId)
                    .HasColumnName("CreatedUserID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TaxId).HasColumnName("TaxID");

                entity.Property(e => e.UpdatedDt)
                    .HasColumnName("UpdatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdatedUserId)
                    .HasColumnName("UpdatedUserID")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<MktCompanyTermD>(entity =>
            {
                entity.HasKey(e => e.CompanyTermDetId);

                entity.ToTable("MKT_CompanyTerm_D");

                entity.Property(e => e.CompanyTermDetId).HasColumnName("CompanyTermDetID");

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.CreatedDt)
                    .HasColumnName("CreatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedUserId)
                    .HasColumnName("CreatedUserID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TermCategoryId).HasColumnName("TermCategoryID");

                entity.Property(e => e.TermId).HasColumnName("TermID");

                entity.Property(e => e.UpdatedDt)
                    .HasColumnName("UpdatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdatedUserId)
                    .HasColumnName("UpdatedUserID")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<MktCustomerCategoryM>(entity =>
            {
                entity.HasKey(e => e.CustomerCategoryId);

                entity.ToTable("MKT_CustomerCategory_M");

                entity.Property(e => e.CustomerCategoryId).HasColumnName("CustomerCategoryID");

                entity.Property(e => e.CreatedDt)
                    .HasColumnName("CreatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedUserId).HasColumnName("CreatedUserID");

                entity.Property(e => e.CurrencyId).HasColumnName("CurrencyID");

                entity.Property(e => e.CustomerCategory)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.GroupId).HasColumnName("GroupID");

                entity.Property(e => e.UpdatedDt)
                    .HasColumnName("UpdatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdatedUserId)
                    .HasColumnName("UpdatedUserID")
                    .HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<MktCustomerCategoryTaxD>(entity =>
            {
                entity.HasKey(e => e.CustomerCategoryTaxId);

                entity.ToTable("MKT_CustomerCategory_Tax_D");

                entity.Property(e => e.CustomerCategoryTaxId).HasColumnName("CustomerCategoryTaxID");

                entity.Property(e => e.ClassificationId)
                    .HasColumnName("ClassificationID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CreatedDt)
                    .HasColumnName("CreatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedUserId)
                    .HasColumnName("CreatedUserID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CustomerCategoryId)
                    .HasColumnName("CustomerCategoryID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TaxId)
                    .HasColumnName("TaxID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.UpdatedDt)
                    .HasColumnName("UpdatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdatedUserId)
                    .HasColumnName("UpdatedUserID")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<MktCustomerRegn>(entity =>
            {
                entity.HasKey(e => e.CustomerRegistrationId);

                entity.ToTable("MKT_Customer_Regn");

                entity.Property(e => e.CustomerRegistrationId).HasColumnName("CustomerRegistrationID");

                entity.Property(e => e.BillingAddress1)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.BillingAddress2)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.BillingCityId).HasColumnName("BillingCityID");

                entity.Property(e => e.BillingCountryId).HasColumnName("BillingCountryID");

                entity.Property(e => e.BillingPincode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.BillingStateId).HasColumnName("BillingStateID");

                entity.Property(e => e.BusinessActivityId).HasColumnName("BusinessActivityID");

                entity.Property(e => e.CompanyAddress1)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyAddress2)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyCityId).HasColumnName("CompanyCityID");

                entity.Property(e => e.CompanyCountryId).HasColumnName("CompanyCountryID");

                entity.Property(e => e.CompanyEmail)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyFaxDialingCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyFaxNo)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyPhoneNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyPhoneNoDialingCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyPincode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyStateId).HasColumnName("CompanyStateID");

                entity.Property(e => e.CompanyWebsite)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ContactPerson)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ContactPersonDesignation)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ContactPersonEmail)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ContactPersonPhoneNo)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.ContactPersonPhoneNoDialingCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDt)
                    .HasColumnName("CreatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedUserId)
                    .HasColumnName("CreatedUserID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CustomerCategoryId).HasColumnName("CustomerCategoryID");

                entity.Property(e => e.DeliveryAddress1)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DeliveryAddress2)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DeliveryCityId).HasColumnName("DeliveryCityID");

                entity.Property(e => e.DeliveryCountryId).HasColumnName("DeliveryCountryID");

                entity.Property(e => e.DeliveryPincode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.DeliveryStateId).HasColumnName("DeliveryStateID");

                entity.Property(e => e.MarketValueId).HasColumnName("MarketValueID");

                entity.Property(e => e.OrganizationHead)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.OrganizationHeadDesignation)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OrganizationHeadEmail)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OrganizationHeadPhoneNo)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.OrganizationHeadPhoneNoDialingCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Password)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TitleContactPerson)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.TitleOrganizationHead)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedDt)
                    .HasColumnName("UpdatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdatedUserId)
                    .HasColumnName("UpdatedUserID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MktEventDateTimeD>(entity =>
            {
                entity.HasKey(e => e.EventDtid);

                entity.ToTable("MKT_EventDateTime_D");

                entity.Property(e => e.EventDtid).HasColumnName("EventDTID");

                entity.Property(e => e.CreatedDt)
                    .HasColumnName("CreatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedUserId)
                    .HasColumnName("CreatedUserID")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.EndTime).HasColumnType("smalldatetime");

                entity.Property(e => e.EventDate).HasColumnType("smalldatetime");

                entity.Property(e => e.EventId).HasColumnName("EventID");

                entity.Property(e => e.StartTime).HasColumnType("smalldatetime");

                entity.Property(e => e.UpdatedDt)
                    .HasColumnName("UpdatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdatedUserId)
                    .HasColumnName("UpdatedUserID")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<MktEventInviteesD>(entity =>
            {
                entity.HasKey(e => e.InviteeId);

                entity.ToTable("MKT_EventInvitees_D");

                entity.Property(e => e.InviteeId).HasColumnName("InviteeID");

                entity.Property(e => e.ContactId).HasColumnName("ContactID");

                entity.Property(e => e.CreatedDt)
                    .HasColumnName("CreatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedUserId)
                    .HasColumnName("CreatedUserID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.EmailId)
                    .IsRequired()
                    .HasColumnName("EmailID")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.EventId).HasColumnName("EventID");

                entity.Property(e => e.InviteeName)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.InviteeType)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InviteeTypeId).HasColumnName("InviteeTypeID");

                entity.Property(e => e.ReferenceId)
                    .HasColumnName("ReferenceID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.UpdatedDt)
                    .HasColumnName("UpdatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdatedUserId)
                    .HasColumnName("UpdatedUserID")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<MktEventM>(entity =>
            {
                entity.HasKey(e => e.EventId);

                entity.ToTable("MKT_Event_M");

                entity.Property(e => e.EventId).HasColumnName("EventID");

                entity.Property(e => e.CreatedDt)
                    .HasColumnName("CreatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedUserId)
                    .HasColumnName("CreatedUserID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.EndDate)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.EventImage).IsUnicode(false);

                entity.Property(e => e.EventTitle)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.EventTypeId)
                    .IsRequired()
                    .HasColumnName("EventTypeID")
                    .HasColumnType("nchar(10)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.InchargeEmpId).HasColumnName("InchargeEmpID");

                entity.Property(e => e.IsAutoApprove).HasDefaultValueSql("((1))");

                entity.Property(e => e.NewsId)
                    .HasColumnName("NewsID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ResultTypeId)
                    .IsRequired()
                    .HasColumnName("ResultTypeID")
                    .HasColumnType("nchar(10)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.StartDate)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdatedDt)
                    .HasColumnName("UpdatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdatedUserId)
                    .HasColumnName("UpdatedUserID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Venue)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Visibility)
                    .IsRequired()
                    .HasColumnType("char(1)")
                    .HasDefaultValueSql("((2))");
            });

            modelBuilder.Entity<MktEventRegCharges>(entity =>
            {
                entity.HasKey(e => e.RegistrationChargesId);

                entity.ToTable("MKT_Event_Reg_Charges");

                entity.Property(e => e.RegistrationChargesId).HasColumnName("RegistrationChargesID");

                entity.Property(e => e.CreatedDt)
                    .HasColumnName("CreatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedUserId).HasColumnName("CreatedUserID");

                entity.Property(e => e.EventId).HasColumnName("EventID");

                entity.Property(e => e.FromDt)
                    .HasColumnName("FromDT")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.ToDt)
                    .HasColumnName("ToDT")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.UpdatedDt)
                    .HasColumnName("UpdatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdatedUserId).HasColumnName("UpdatedUserID");
            });

            modelBuilder.Entity<MktEventRegD>(entity =>
            {
                entity.HasKey(e => e.RegistrationDetId);

                entity.ToTable("MKT_Event_Reg_D");

                entity.Property(e => e.RegistrationDetId).HasColumnName("RegistrationDetID");

                entity.Property(e => e.CreatedDt)
                    .HasColumnName("CreatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedUserId).HasColumnName("CreatedUserID");

                entity.Property(e => e.FieldId).HasColumnName("FieldID");

                entity.Property(e => e.RegistrationId).HasColumnName("RegistrationID");

                entity.Property(e => e.UpdatedDt)
                    .HasColumnName("UpdatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdatedUserId).HasColumnName("UpdatedUserID");

                entity.Property(e => e.Value)
                    .IsRequired()
                    .HasMaxLength(400)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MktEventRegFields>(entity =>
            {
                entity.HasKey(e => e.FieldId);

                entity.ToTable("MKT_Event_Reg_Fields");

                entity.Property(e => e.FieldId).HasColumnName("FieldID");

                entity.Property(e => e.CreatedDt)
                    .HasColumnName("CreatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedUserId).HasColumnName("CreatedUserID");

                entity.Property(e => e.EventId).HasColumnName("EventID");

                entity.Property(e => e.FieldName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedDt)
                    .HasColumnName("UpdatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdatedUserId).HasColumnName("UpdatedUserID");
            });

            modelBuilder.Entity<MktEventRegM>(entity =>
            {
                entity.HasKey(e => e.RegistrationId);

                entity.ToTable("MKT_Event_Reg_M");

                entity.Property(e => e.RegistrationId).HasColumnName("RegistrationID");

                entity.Property(e => e.CreatedDt)
                    .HasColumnName("CreatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedUserId).HasColumnName("CreatedUserID");

                entity.Property(e => e.EmailId)
                    .IsRequired()
                    .HasColumnName("EmailID")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.EventId).HasColumnName("EventID");

                entity.Property(e => e.MobileNum)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PersonName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.RegistrationCharges).HasDefaultValueSql("((0))");

                entity.Property(e => e.UpdatedDt)
                    .HasColumnName("UpdatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdatedUserId).HasColumnName("UpdatedUserID");
            });

            modelBuilder.Entity<MktEventResultsD>(entity =>
            {
                entity.HasKey(e => e.ResultId);

                entity.ToTable("MKT_EventResults_D");

                entity.Property(e => e.ResultId).HasColumnName("ResultID");

                entity.Property(e => e.CreatedDt)
                    .HasColumnName("CreatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedUserId)
                    .HasColumnName("CreatedUserID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Details)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.EventId).HasColumnName("EventID");

                entity.Property(e => e.Result)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ResultName)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.TypeId).HasColumnName("TypeID");

                entity.Property(e => e.UpdatedDt)
                    .HasColumnName("UpdatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdatedUserId)
                    .HasColumnName("UpdatedUserID")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<MktEventTaskD>(entity =>
            {
                entity.HasKey(e => e.TaskId);

                entity.ToTable("MKT_EventTask_D");

                entity.Property(e => e.TaskId).HasColumnName("TaskID");

                entity.Property(e => e.CreatedDt)
                    .HasColumnName("CreatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedUserId)
                    .HasColumnName("CreatedUserID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.EmployeeId)
                    .HasColumnName("EmployeeID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.EventId).HasColumnName("EventID");

                entity.Property(e => e.ReminderId)
                    .HasColumnName("ReminderID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TaskDate)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.TaskName)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedDt)
                    .HasColumnName("UpdatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdatedUserId)
                    .HasColumnName("UpdatedUserID")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<MktEventTypeM>(entity =>
            {
                entity.HasKey(e => e.EventTypeId);

                entity.ToTable("MKT_EventType_M");

                entity.Property(e => e.EventTypeId).HasColumnName("EventTypeID");

                entity.Property(e => e.CreatedDt)
                    .HasColumnName("CreatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedUserId)
                    .HasColumnName("CreatedUserID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ResultTypeId).HasColumnName("ResultTypeID");

                entity.Property(e => e.TypeName)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedDt)
                    .HasColumnName("UpdatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdatedUserId)
                    .HasColumnName("UpdatedUserID")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<MktFacilitiesAssetsM>(entity =>
            {
                entity.HasKey(e => e.FacilityAssetId);

                entity.ToTable("MKT_FacilitiesAssets_M");

                entity.Property(e => e.FacilityAssetId).HasColumnName("FacilityAssetID");

                entity.Property(e => e.AssetCategoryId).HasColumnName("AssetCategoryID");

                entity.Property(e => e.AssetId).HasColumnName("AssetID");

                entity.Property(e => e.AssetTypeId).HasColumnName("AssetTypeID");

                entity.Property(e => e.CreatedDt)
                    .HasColumnName("CreatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedUserId).HasColumnName("CreatedUserID");

                entity.Property(e => e.Description)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.DisplayName)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ImageName)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedDt)
                    .HasColumnName("UpdatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdatedUserId).HasColumnName("UpdatedUserID");
            });

            modelBuilder.Entity<MktFeedbackBandM>(entity =>
            {
                entity.HasKey(e => e.FeedbackBandId);

                entity.ToTable("MKT_FeedbackBand_M");

                entity.Property(e => e.FeedbackBandId).HasColumnName("FeedbackBandID");

                entity.Property(e => e.BandType)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDt)
                    .HasColumnName("CreatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<MktFeedbackCategoryM>(entity =>
            {
                entity.HasKey(e => e.CategoryId);

                entity.ToTable("MKT_FeedbackCategory_M");

                entity.Property(e => e.CategoryId)
                    .HasColumnName("CategoryID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.AlertEmail)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CategoryName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDt)
                    .HasColumnName("CreatedDT")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.CreatedUserId).HasColumnName("CreatedUserID");

                entity.Property(e => e.UpdatedDt)
                    .HasColumnName("UpdatedDT")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.UpdatedUserId).HasColumnName("UpdatedUserID");
            });

            modelBuilder.Entity<MktFeedbackD>(entity =>
            {
                entity.HasKey(e => e.FeedbackDetId);

                entity.ToTable("MKT_Feedback_D");

                entity.Property(e => e.FeedbackDetId).HasColumnName("FeedbackDetID");

                entity.Property(e => e.CreatedDt)
                    .HasColumnName("CreatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedUserId).HasColumnName("CreatedUserID");

                entity.Property(e => e.FeedbackFactorId).HasColumnName("FeedbackFactorID");

                entity.Property(e => e.FeedbackId).HasColumnName("FeedbackID");

                entity.Property(e => e.UpdatedDt)
                    .HasColumnName("UpdatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdatedUserId).HasColumnName("UpdatedUserID");
            });

            modelBuilder.Entity<MktFeedbackFactorM>(entity =>
            {
                entity.HasKey(e => e.FeedbackFactorId);

                entity.ToTable("MKT_FeedbackFactor_M");

                entity.Property(e => e.FeedbackFactorId)
                    .HasColumnName("FeedbackFactorID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.CategoryId).HasColumnName("CategoryID");

                entity.Property(e => e.CreatedDt)
                    .HasColumnName("CreatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedUserId).HasColumnName("CreatedUserID");

                entity.Property(e => e.FeedbackFactorName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FeedbackWeightage).HasColumnType("decimal(4, 2)");

                entity.Property(e => e.UpdatedDt)
                    .HasColumnName("UpdatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdatedUserId).HasColumnName("UpdatedUserID");
            });

            modelBuilder.Entity<MktFeedbackM>(entity =>
            {
                entity.HasKey(e => e.FeedbackId);

                entity.ToTable("MKT_Feedback_M");

                entity.Property(e => e.FeedbackId).HasColumnName("FeedbackID");

                entity.Property(e => e.CreatedDt)
                    .HasColumnName("CreatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedUserId).HasColumnName("CreatedUserID");

                entity.Property(e => e.CustomerId).HasColumnName("CustomerID");

                entity.Property(e => e.InvoiceId).HasColumnName("InvoiceID");

                entity.Property(e => e.Notes)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.UpdatedDt)
                    .HasColumnName("UpdatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdatedUserId).HasColumnName("UpdatedUserID");
            });

            modelBuilder.Entity<MktGenieMailM>(entity =>
            {
                entity.HasKey(e => e.GenieMailId);

                entity.ToTable("MKT_GenieMail_M");

                entity.Property(e => e.GenieMailId).HasColumnName("GenieMailID");

                entity.Property(e => e.CreatedDt)
                    .HasColumnName("CreatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SenderUserId).HasColumnName("SenderUserID");

                entity.Property(e => e.SentUsing).HasColumnType("nchar(1)");

                entity.Property(e => e.ShowToSender).HasDefaultValueSql("((1))");

                entity.Property(e => e.Subject).HasMaxLength(100);
            });

            modelBuilder.Entity<MktHeadingM>(entity =>
            {
                entity.HasKey(e => e.HeadingId);

                entity.ToTable("MKT_Heading_M");

                entity.Property(e => e.HeadingId).HasColumnName("HeadingID");

                entity.Property(e => e.BannerImg1).IsUnicode(false);

                entity.Property(e => e.BannerImg2).IsUnicode(false);

                entity.Property(e => e.BannerImg3).IsUnicode(false);

                entity.Property(e => e.BannerImg4).IsUnicode(false);

                entity.Property(e => e.BannerImg5).IsUnicode(false);

                entity.Property(e => e.CreatedDt)
                    .HasColumnName("CreatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedUserId)
                    .HasColumnName("CreatedUserID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.DisplayOrder).HasDefaultValueSql("((0))");

                entity.Property(e => e.IconImg).IsUnicode(false);

                entity.Property(e => e.MenuTitle).HasMaxLength(100);

                entity.Property(e => e.Title).HasMaxLength(100);

                entity.Property(e => e.UpdatedDt)
                    .HasColumnName("UpdatedDT")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.UpdatedUserId).HasColumnName("UpdatedUserID");
            });

            modelBuilder.Entity<MktItemM>(entity =>
            {
                entity.HasKey(e => e.ItemId);

                entity.ToTable("MKT_Item_M");

                entity.Property(e => e.ItemId).HasColumnName("ItemID");

                entity.Property(e => e.CreatedDt)
                    .HasColumnName("CreatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedUserId)
                    .HasColumnName("CreatedUserID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ItemName)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.MaterialId)
                    .HasColumnName("MaterialID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.PartCrmid)
                    .HasColumnName("PartCRMID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.SetId)
                    .HasColumnName("SetID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.SubHeadingId)
                    .HasColumnName("SubHeadingID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.UpdatedDt)
                    .HasColumnName("UpdatedDT")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.UpdatedUserId).HasColumnName("UpdatedUserID");
            });

            modelBuilder.Entity<MktMarketValueM>(entity =>
            {
                entity.HasKey(e => e.MarketValueId);

                entity.ToTable("MKT_MarketValue_M");

                entity.Property(e => e.MarketValueId)
                    .HasColumnName("MarketValueID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.CreatedDt)
                    .HasColumnName("CreatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedUserId).HasColumnName("CreatedUserID");

                entity.Property(e => e.MarketValue)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedDt)
                    .HasColumnName("UpdatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdatedUserId).HasColumnName("UpdatedUserID");
            });

            modelBuilder.Entity<MktNewsM>(entity =>
            {
                entity.HasKey(e => e.NewsId);

                entity.ToTable("MKT_News_M");

                entity.Property(e => e.NewsId).HasColumnName("NewsID");

                entity.Property(e => e.CreatedDt)
                    .HasColumnName("CreatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedUserId)
                    .HasColumnName("CreatedUserID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Description).IsRequired();

                entity.Property(e => e.DisplayFromDt)
                    .HasColumnName("DisplayFromDT")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DisplayToDt)
                    .HasColumnName("DisplayToDT")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.FileName)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Heading).IsRequired();

                entity.Property(e => e.ImageName)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.LinkUrl)
                    .HasColumnName("LinkURL")
                    .IsUnicode(false);

                entity.Property(e => e.NewsDt)
                    .HasColumnName("NewsDT")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.ShowNewsDt).HasColumnName("ShowNewsDT");

                entity.Property(e => e.UpdatedDt)
                    .HasColumnName("UpdatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdatedUserId)
                    .HasColumnName("UpdatedUserID")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<MktPiM>(entity =>
            {
                entity.HasKey(e => e.Piid);

                entity.ToTable("MKT_PI_M");

                entity.Property(e => e.Piid).HasColumnName("PIID");

                entity.Property(e => e.BarcodeNo)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDt)
                    .HasColumnName("CreatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedUserId).HasColumnName("CreatedUserID");

                entity.Property(e => e.Pino)
                    .IsRequired()
                    .HasColumnName("PINo")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Poid).HasColumnName("POID");

                entity.Property(e => e.UpdatedDt)
                    .HasColumnName("UpdatedDT")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.UpdatedUserId).HasColumnName("UpdatedUserID");
            });

            modelBuilder.Entity<MktPoitems>(entity =>
            {
                entity.HasKey(e => e.PoitemId);

                entity.ToTable("MKT_POItems");

                entity.Property(e => e.PoitemId).HasColumnName("POItemID");

                entity.Property(e => e.CfSkunitIdToPoaunitIdDenominator).HasColumnName("CF_SKUnitID_To_POAUnitID_Denominator");

                entity.Property(e => e.CfSkunitIdToPoaunitIdNumerator).HasColumnName("CF_SKUnitID_To_POAUnitID_Numerator");

                entity.Property(e => e.Charge1Name)
                    .HasColumnName("Charge1_Name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Charge1Value).HasColumnName("Charge1_Value");

                entity.Property(e => e.Charge2Name)
                    .HasColumnName("Charge2_Name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Charge2Value).HasColumnName("Charge2_Value");

                entity.Property(e => e.Charge3Name)
                    .HasColumnName("Charge3_Name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Charge3Value).HasColumnName("Charge3_Value");

                entity.Property(e => e.Charge4Name)
                    .HasColumnName("Charge4_Name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Charge4Value).HasColumnName("Charge4_Value");

                entity.Property(e => e.CompletedQtyInPoaunit).HasColumnName("CompletedQty_In_POAUnit");

                entity.Property(e => e.CompletedQtyInSkunit).HasColumnName("CompletedQty_In_SKUnit");

                entity.Property(e => e.CrmItemId)
                    .HasColumnName("CRM_ItemID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.DeliveredDt)
                    .HasColumnName("DeliveredDT")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DeliveredQtyInPoaunit).HasColumnName("DeliveredQty_In_POAUnit");

                entity.Property(e => e.DeliveredQtyInSkunit).HasColumnName("DeliveredQty_In_SKUnit");

                entity.Property(e => e.DeliveredUserId).HasColumnName("DeliveredUserID");

                entity.Property(e => e.DeliveryDt)
                    .HasColumnName("DeliveryDT")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DeliveryTypeId).HasColumnName("DeliveryTypeID");

                entity.Property(e => e.ExpShippingDt)
                    .HasColumnName("ExpShippingDT")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.IsPending).HasDefaultValueSql("((1))");

                entity.Property(e => e.IsPocomplete).HasColumnName("IsPOComplete");

                entity.Property(e => e.Mrp)
                    .HasColumnName("MRP")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Mrpamount)
                    .HasColumnName("MRPAmount")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.PaymentDueDt)
                    .HasColumnName("PaymentDueDT")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.PoaunitId).HasColumnName("POAUnitID");

                entity.Property(e => e.Poid).HasColumnName("POID");

                entity.Property(e => e.PotypeId)
                    .HasColumnName("POTypeID")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.PrecisionDigitsRate).HasColumnName("PrecisionDigits_Rate");

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.Property(e => e.QtyInPoaunitId).HasColumnName("Qty_In_POAUnitID");

                entity.Property(e => e.QtyInSkUnitId).HasColumnName("Qty_In_SkUnitID");

                entity.Property(e => e.QuotationId)
                    .HasColumnName("QuotationID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ReasonForChange)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ShipperId)
                    .HasColumnName("ShipperID")
                    .HasDefaultValueSql("((13))");

                entity.Property(e => e.SkunitId).HasColumnName("SKUnitID");

                entity.Property(e => e.VersionNum).HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<MktPoitemsHistory>(entity =>
            {
                entity.HasKey(e => e.PoitemHistoryId);

                entity.ToTable("MKT_POItems_History");

                entity.Property(e => e.PoitemHistoryId).HasColumnName("POItemHistoryID");

                entity.Property(e => e.CfSkunitIdToPoaunitIdDenominator).HasColumnName("CF_SKUnitID_To_POAUnitID_Denominator");

                entity.Property(e => e.CfSkunitIdToPoaunitIdNumerator).HasColumnName("CF_SKUnitID_To_POAUnitID_Numerator");

                entity.Property(e => e.Charge1Name)
                    .HasColumnName("Charge1_Name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Charge1Value).HasColumnName("Charge1_Value");

                entity.Property(e => e.Charge2Name)
                    .HasColumnName("Charge2_Name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Charge2Value).HasColumnName("Charge2_Value");

                entity.Property(e => e.Charge3Name)
                    .HasColumnName("Charge3_Name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Charge3Value).HasColumnName("Charge3_Value");

                entity.Property(e => e.Charge4Name)
                    .HasColumnName("Charge4_Name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Charge4Value).HasColumnName("Charge4_Value");

                entity.Property(e => e.CreatedDt)
                    .HasColumnName("CreatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedUserId)
                    .HasColumnName("CreatedUserID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.DeliveryDt)
                    .HasColumnName("DeliveryDT")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DeliveryTypeId).HasColumnName("DeliveryTypeID");

                entity.Property(e => e.ExpShippingDt)
                    .HasColumnName("ExpShippingDT")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.IsPending).HasDefaultValueSql("((1))");

                entity.Property(e => e.Mrp)
                    .HasColumnName("MRP")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Mrpamount)
                    .HasColumnName("MRPAmount")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.PaymentDueDt)
                    .HasColumnName("PaymentDueDT")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.PoaunitId).HasColumnName("POAUnitID");

                entity.Property(e => e.Poid).HasColumnName("POID");

                entity.Property(e => e.PoitemId).HasColumnName("POItemID");

                entity.Property(e => e.PotypeId)
                    .HasColumnName("POTypeID")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.PrecisionDigitsRate).HasColumnName("PrecisionDigits_Rate");

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.Property(e => e.QtyInPoaunitId).HasColumnName("Qty_In_POAUnitID");

                entity.Property(e => e.QtyInSkUnitId).HasColumnName("Qty_In_SkUnitID");

                entity.Property(e => e.QuotationId)
                    .HasColumnName("QuotationID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ReasonForChange)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ShipperId)
                    .HasColumnName("ShipperID")
                    .HasDefaultValueSql("((13))");

                entity.Property(e => e.SkunitId).HasColumnName("SKUnitID");

                entity.Property(e => e.VersionNum).HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<MktPoM>(entity =>
            {
                entity.HasKey(e => e.Poid);

                entity.ToTable("MKT_PO_M");

                entity.Property(e => e.Poid).HasColumnName("POID");

                entity.Property(e => e.AcceptedDt)
                    .HasColumnName("AcceptedDT")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.AcceptedUserId).HasColumnName("AcceptedUserID");

                entity.Property(e => e.AddressTypeId)
                    .HasColumnName("AddressTypeID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ContactId)
                    .HasColumnName("ContactID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CreatedDt)
                    .HasColumnName("CreatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedUserId).HasColumnName("CreatedUserID");

                entity.Property(e => e.CreditTo).HasDefaultValueSql("((0))");

                entity.Property(e => e.CurrencyId).HasColumnName("CurrencyID");

                entity.Property(e => e.CustPonum)
                    .IsRequired()
                    .HasColumnName("CustPONum")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerId).HasColumnName("CustomerID");

                entity.Property(e => e.DefaultCurrencyId)
                    .HasColumnName("Default_CurrencyID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ExciseTaxId)
                    .HasColumnName("ExciseTaxID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.FinalCharge1Name)
                    .HasColumnName("FinalCharge1_Name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FinalCharge1Value)
                    .HasColumnName("FinalCharge1_Value")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.FinalCharge2Name)
                    .HasColumnName("FinalCharge2_Name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FinalCharge2Value)
                    .HasColumnName("FinalCharge2_Value")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.FinalCharge3Name)
                    .HasColumnName("FinalCharge3_Name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FinalCharge3Value)
                    .HasColumnName("FinalCharge3_Value")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.FinalCharge4Name)
                    .HasColumnName("FinalCharge4_Name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FinalCharge4Value)
                    .HasColumnName("FinalCharge4_Value")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.FreightAfterTax).HasDefaultValueSql("((0))");

                entity.Property(e => e.InvoiceId)
                    .HasColumnName("InvoiceID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.LatestCurrencyExchangeRate).HasDefaultValueSql("((1))");

                entity.Property(e => e.Notes)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.OtherChargesName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OtherChargesValue).HasDefaultValueSql("((0))");

                entity.Property(e => e.PaymentDueInDays)
                    .HasColumnName("PaymentDue_In_Days")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.PoaSerialNum)
                    .HasColumnName("POA_SerialNum")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.PoadvanceAmt)
                    .HasColumnName("POAdvanceAmt")
                    .HasColumnType("decimal(16, 2)")
                    .HasDefaultValueSql("((0.00))");

                entity.Property(e => e.Podate)
                    .HasColumnName("PODate")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.PofileName)
                    .HasColumnName("POFileName")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Ponum)
                    .HasColumnName("PONum")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.QuotationId).HasColumnName("QuotationID");

                entity.Property(e => e.ReasonToReject)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.SaleTaxId)
                    .HasColumnName("SaleTaxID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TaxType)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('T')");

                entity.Property(e => e.UpdatedDt)
                    .HasColumnName("UpdatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdatedUserId).HasColumnName("UpdatedUserID");
            });

            modelBuilder.Entity<MktPotaxesNew>(entity =>
            {
                entity.HasKey(e => e.PoTaxId);

                entity.ToTable("MKT_POTaxes_New");

                entity.Property(e => e.PoTaxId).HasColumnName("PoTaxID");

                entity.Property(e => e.AppliedOnAmount).HasDefaultValueSql("((0))");

                entity.Property(e => e.CreatedDt)
                    .HasColumnName("CreatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedId).HasColumnName("CreatedID");

                entity.Property(e => e.Poid).HasColumnName("POID");

                entity.Property(e => e.TaxId).HasColumnName("TaxID");

                entity.Property(e => e.UpdatedDt)
                    .HasColumnName("UpdatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdatedId).HasColumnName("UpdatedID");
            });

            modelBuilder.Entity<MktPotermsD>(entity =>
            {
                entity.HasKey(e => e.PotermDetId);

                entity.ToTable("MKT_POTerms_D");

                entity.Property(e => e.PotermDetId).HasColumnName("POTermDetID");

                entity.Property(e => e.Poid).HasColumnName("POID");

                entity.Property(e => e.PotermId).HasColumnName("POTermID");
            });

            modelBuilder.Entity<MktProductShoppingCartWishList>(entity =>
            {
                entity.HasKey(e => e.ProductCrmid);

                entity.ToTable("MKT_Product_ShoppingCart_WishList");

                entity.Property(e => e.ProductCrmid).HasColumnName("ProductCRMID");

                entity.Property(e => e.AlertMode).HasDefaultValueSql("((0))");

                entity.Property(e => e.CreatedDt)
                    .HasColumnName("CreatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedUserId).HasColumnName("CreatedUserID");

                entity.Property(e => e.CrmItemId)
                    .HasColumnName("CRM_ItemID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.IsShoppingCartItem).HasColumnName("IsShoppingCart_Item");

                entity.Property(e => e.IsWishListItem).HasColumnName("IsWishList_Item");

                entity.Property(e => e.MaterialId)
                    .HasColumnName("MaterialID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Quantity).HasDefaultValueSql("((0))");

                entity.Property(e => e.Rate).HasDefaultValueSql("((0))");

                entity.Property(e => e.SetId)
                    .HasColumnName("SetID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.UpdatedDt)
                    .HasColumnName("UpdatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdatedUserId).HasColumnName("UpdatedUserID");
            });

            modelBuilder.Entity<MktQuotationItems>(entity =>
            {
                entity.HasKey(e => e.Rfqid);

                entity.ToTable("MKT_QuotationItems");

                entity.Property(e => e.Rfqid).HasColumnName("RFQID");

                entity.Property(e => e.ApplyFixCharges).HasDefaultValueSql("((0))");

                entity.Property(e => e.CfPoaunitIdToSkunitIdDenominator).HasColumnName("CF_POAUnitID_To_SKUnitID_Denominator");

                entity.Property(e => e.CfPoaunitIdToSkunitIdNumerator).HasColumnName("CF_POAUnitID_To_SKUnitID_Numerator");

                entity.Property(e => e.Charge1Name)
                    .HasColumnName("Charge1_Name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Charge1Value).HasColumnName("Charge1_Value");

                entity.Property(e => e.Charge2Name)
                    .HasColumnName("Charge2_Name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Charge2Value).HasColumnName("Charge2_Value");

                entity.Property(e => e.Charge3Name)
                    .HasColumnName("Charge3_Name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Charge3Value).HasColumnName("Charge3_Value");

                entity.Property(e => e.Charge4Name)
                    .HasColumnName("Charge4_Name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Charge4Value).HasColumnName("Charge4_Value");

                entity.Property(e => e.CustRfqnum)
                    .HasColumnName("CustRFQNum")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerId)
                    .HasColumnName("CustomerID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CustomerPartName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerPartNum)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DeliveryDt).HasColumnType("smalldatetime");

                entity.Property(e => e.DeliveryLot).HasColumnType("char(2)");

                entity.Property(e => e.DetailString)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.DevelopmentCharges).HasDefaultValueSql("((0))");

                entity.Property(e => e.FirstDeliveryAfterDays)
                    .HasColumnName("FirstDeliveryAfter_Days")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.GerberFileName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.GrossPcblength)
                    .HasColumnName("GrossPCBLength")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.GrossPcbunitId)
                    .HasColumnName("GrossPCBUnitID")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.GrossPcbwidth)
                    .HasColumnName("GrossPCBWidth")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.IsVisible).HasDefaultValueSql("((1))");

                entity.Property(e => e.Mrp)
                    .HasColumnName("MRP")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Mrpamount)
                    .HasColumnName("MRPAmount")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.OtherCharges).HasDefaultValueSql("((0))");

                entity.Property(e => e.Pcblength)
                    .HasColumnName("PCBLength")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.PcbrateUnitId)
                    .HasColumnName("PCBRateUnitID")
                    .HasDefaultValueSql("((2))");

                entity.Property(e => e.PcbsPerArray)
                    .HasColumnName("PCBsPerArray")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Pcbsize)
                    .HasColumnName("PCBSize")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Pcbwidth)
                    .HasColumnName("PCBWidth")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.PoaunitId).HasColumnName("POAUnitID");

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.Property(e => e.PrototypeCharges).HasDefaultValueSql("((0))");

                entity.Property(e => e.PrototypeDevelopmentCharges).HasDefaultValueSql("((0))");

                entity.Property(e => e.QtyInPoaunitId).HasColumnName("Qty_In_POAUnitID");

                entity.Property(e => e.QtyInRuunitId).HasColumnName("Qty_In_RUUnitID");

                entity.Property(e => e.QtyInSkUnitId).HasColumnName("Qty_In_SkUnitID");

                entity.Property(e => e.QuantityPerLot).HasDefaultValueSql("((0))");

                entity.Property(e => e.QuotationDt)
                    .HasColumnName("QuotationDT")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.QuotationId).HasColumnName("QuotationID");

                entity.Property(e => e.QuotationUserId).HasColumnName("QuotationUserID");

                entity.Property(e => e.ReferenceRfqid)
                    .HasColumnName("ReferenceRFQID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Rfqdt)
                    .HasColumnName("RFQDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Rfqnum)
                    .HasColumnName("RFQNum")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.RfquserId).HasColumnName("RFQUserID");

                entity.Property(e => e.RuunitId).HasColumnName("RUUnitID");

                entity.Property(e => e.SetupCharge).HasDefaultValueSql("((0))");

                entity.Property(e => e.SkunitId).HasColumnName("SKUnitID");

                entity.Property(e => e.TechDetails)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ValidTillDt)
                    .HasColumnName("ValidTillDT")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.VersionNum).HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<MktQuotationItemsD>(entity =>
            {
                entity.HasKey(e => e.RfqdetId);

                entity.ToTable("MKT_QuotationItems_D");

                entity.Property(e => e.RfqdetId).HasColumnName("RFQDetID");

                entity.Property(e => e.CreatedDt)
                    .HasColumnName("CreatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedUserId)
                    .HasColumnName("CreatedUserID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.GerberFileName)
                    .IsRequired()
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.GerberFileTypeId).HasColumnName("GerberFileTypeID");

                entity.Property(e => e.Rfqid).HasColumnName("RFQID");

                entity.Property(e => e.UpdatedDt)
                    .HasColumnName("UpdatedDT")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.UpdatedUserId).HasColumnName("UpdatedUserID");
            });

            modelBuilder.Entity<MktQuotationM>(entity =>
            {
                entity.HasKey(e => e.QuotationId);

                entity.ToTable("MKT_Quotation_M");

                entity.Property(e => e.QuotationId).HasColumnName("QuotationID");

                entity.Property(e => e.AddressTo)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.AddressTypeId)
                    .HasColumnName("AddressTypeID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ContactId)
                    .HasColumnName("ContactID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CreatedDt)
                    .HasColumnName("CreatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedUserId).HasColumnName("CreatedUserID");

                entity.Property(e => e.CurrencyId).HasColumnName("CurrencyID");

                entity.Property(e => e.CustomerId).HasColumnName("CustomerID");

                entity.Property(e => e.DefaultCurrencyId)
                    .HasColumnName("Default_CurrencyID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.DeliveryDt).HasColumnType("smalldatetime");

                entity.Property(e => e.DevelopmentCharge).HasDefaultValueSql("((0))");

                entity.Property(e => e.ExciseId).HasColumnName("ExciseID");

                entity.Property(e => e.FinalCharge1Name)
                    .HasColumnName("FinalCharge1_Name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FinalCharge1Value)
                    .HasColumnName("FinalCharge1_Value")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.FinalCharge2Name)
                    .HasColumnName("FinalCharge2_Name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FinalCharge2Value)
                    .HasColumnName("FinalCharge2_Value")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.FinalCharge3Name)
                    .HasColumnName("FinalCharge3_Name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FinalCharge3Value)
                    .HasColumnName("FinalCharge3_Value")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.FinalCharge4Name)
                    .HasColumnName("FinalCharge4_Name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FinalCharge4Value)
                    .HasColumnName("FinalCharge4_Value")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Notes)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.OtherCharge).HasDefaultValueSql("((0))");

                entity.Property(e => e.OtherTerms)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.Period).HasColumnType("char(2)");

                entity.Property(e => e.PrecisionDigitsRate)
                    .HasColumnName("PrecisionDigits_Rate")
                    .HasDefaultValueSql("((2))");

                entity.Property(e => e.Price)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ProductionQuantity).HasDefaultValueSql("((0))");

                entity.Property(e => e.ProductionQuantityPeriod).HasColumnType("char(2)");

                entity.Property(e => e.ProposedRate).HasDefaultValueSql("((0))");

                entity.Property(e => e.PrototypeQuantity).HasDefaultValueSql("((0))");

                entity.Property(e => e.PrototypeQuantityPeriod).HasColumnType("char(2)");

                entity.Property(e => e.QtSerialNum)
                    .HasColumnName("QT_serialNum")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.QuotationDt)
                    .HasColumnName("QuotationDT")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.QuotationNum)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.QuotationType).HasColumnType("char(1)");

                entity.Property(e => e.QuoteVersion).HasColumnType("char(2)");

                entity.Property(e => e.SaleTaxId).HasColumnName("SaleTaxID");

                entity.Property(e => e.Subject)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TaxType)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.ValidTillDt)
                    .HasColumnName("ValidTillDT")
                    .HasColumnType("smalldatetime");
            });

            modelBuilder.Entity<MktQuotationTaxes>(entity =>
            {
                entity.HasKey(e => e.QuotationTaxId);

                entity.ToTable("MKT_QuotationTaxes");

                entity.Property(e => e.QuotationTaxId).HasColumnName("QuotationTaxID");

                entity.Property(e => e.AppliedOnAmount).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsDeleted).HasDefaultValueSql("(0)");

                entity.Property(e => e.QuotationId).HasColumnName("QuotationID");

                entity.Property(e => e.SubTax1Amount).HasDefaultValueSql("((0))");

                entity.Property(e => e.SubTax1Rate).HasDefaultValueSql("((0))");

                entity.Property(e => e.SubTax2Amount).HasDefaultValueSql("((0))");

                entity.Property(e => e.SubTax2Rate).HasDefaultValueSql("((0))");

                entity.Property(e => e.TaxId).HasColumnName("TaxID");
            });

            modelBuilder.Entity<MktQuotationTermsD>(entity =>
            {
                entity.HasKey(e => e.QuotationTermDetId);

                entity.ToTable("MKT_QuotationTerms_D");

                entity.Property(e => e.QuotationTermDetId).HasColumnName("QuotationTermDetID");

                entity.Property(e => e.QuotationId).HasColumnName("QuotationID");

                entity.Property(e => e.QuotationTermId).HasColumnName("QuotationTermID");
            });

            modelBuilder.Entity<MktSubHeadingM>(entity =>
            {
                entity.HasKey(e => e.SubHeadingId);

                entity.ToTable("MKT_SubHeading_M");

                entity.Property(e => e.SubHeadingId).HasColumnName("SubHeadingID");

                entity.Property(e => e.BannerImg1).IsUnicode(false);

                entity.Property(e => e.BannerImg2).IsUnicode(false);

                entity.Property(e => e.BannerImg3).IsUnicode(false);

                entity.Property(e => e.BannerImg4).IsUnicode(false);

                entity.Property(e => e.BannerImg5).IsUnicode(false);

                entity.Property(e => e.CreatedDt)
                    .HasColumnName("CreatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedUserId)
                    .HasColumnName("CreatedUserID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.DisplayOrder).HasDefaultValueSql("((0))");

                entity.Property(e => e.HeadingId)
                    .HasColumnName("HeadingID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.IconImg).IsUnicode(false);

                entity.Property(e => e.MenuTitle).HasMaxLength(100);

                entity.Property(e => e.Title).HasMaxLength(100);

                entity.Property(e => e.UpdatedDt)
                    .HasColumnName("UpdatedDT")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.UpdatedUserId).HasColumnName("UpdatedUserID");
            });

            modelBuilder.Entity<MktTermCustomerCategoy>(entity =>
            {
                entity.HasKey(e => e.CustomerTermId);

                entity.ToTable("MKT_Term_CustomerCategoy");

                entity.Property(e => e.CustomerTermId).HasColumnName("CustomerTermID");

                entity.Property(e => e.AdvanceAmtPer)
                    .HasColumnType("decimal(6, 2)")
                    .HasDefaultValueSql("((0.00))");

                entity.Property(e => e.CreatedDt)
                    .HasColumnName("CreatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedUserId).HasColumnName("CreatedUserID");

                entity.Property(e => e.CustomerCategoryId).HasColumnName("CustomerCategoryID");

                entity.Property(e => e.TermId).HasColumnName("TermID");

                entity.Property(e => e.TermsCategoryId).HasColumnName("TermsCategoryID");

                entity.Property(e => e.UpdatedDt)
                    .HasColumnName("UpdatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdatedUserId)
                    .HasColumnName("UpdatedUserID")
                    .HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<MktTermsM>(entity =>
            {
                entity.HasKey(e => e.TermId);

                entity.ToTable("MKT_Terms_M");

                entity.Property(e => e.TermId).HasColumnName("TermID");

                entity.Property(e => e.AdvanceAmtPer)
                    .HasColumnType("decimal(6, 2)")
                    .HasDefaultValueSql("((0.00))");

                entity.Property(e => e.CreatedDt)
                    .HasColumnName("CreatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedUserId).HasColumnName("CreatedUserID");

                entity.Property(e => e.Term)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.TermsCategoryId).HasColumnName("TermsCategoryID");

                entity.Property(e => e.UpdatedDt)
                    .HasColumnName("UpdatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdatedUserId)
                    .HasColumnName("UpdatedUserID")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<MktWebsiteBannersM>(entity =>
            {
                entity.HasKey(e => e.ImgId);

                entity.ToTable("MKT_Website_Banners_M");

                entity.Property(e => e.ImgId).HasColumnName("ImgID");

                entity.Property(e => e.CreatedDt)
                    .HasColumnName("CreatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedUserId).HasColumnName("CreatedUserID");

                entity.Property(e => e.ImgName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedDt)
                    .HasColumnName("UpdatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdatedUserId).HasColumnName("UpdatedUserID");
            });

            modelBuilder.Entity<MktWebsiteConfigM>(entity =>
            {
                entity.HasKey(e => e.FieldId);

                entity.ToTable("MKT_WebsiteConfig_M");

                entity.Property(e => e.FieldId).HasColumnName("FieldID");

                entity.Property(e => e.FieldName)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MktWebsiteCustomers>(entity =>
            {
                entity.HasKey(e => e.WebsiteCustomerId);

                entity.ToTable("MKT_Website_Customers");

                entity.Property(e => e.WebsiteCustomerId).HasColumnName("WebsiteCustomerID");

                entity.Property(e => e.CompanyAddressDetailId)
                    .HasColumnName("CompanyAddressDetailID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.CompanyName)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDt)
                    .HasColumnName("CreatedDT")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.CreatedUserId).HasColumnName("CreatedUserID");

                entity.Property(e => e.UpdatedDt)
                    .HasColumnName("UpdatedDT")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.UpdatedUserId).HasColumnName("UpdatedUserID");
            });

            modelBuilder.Entity<MktWebsitePagesM>(entity =>
            {
                entity.HasKey(e => e.LinkId);

                entity.ToTable("MKT_WebsitePages_M");

                entity.Property(e => e.LinkId).HasColumnName("LinkID");

                entity.Property(e => e.CreatedDt)
                    .HasColumnName("CreatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedUserId)
                    .HasColumnName("CreatedUserID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.DisplayOrder).HasDefaultValueSql("((0))");

                entity.Property(e => e.LinkDisplayText)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.LinkLevelId)
                    .HasColumnName("LinkLevelID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.LinkName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PageName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ParentLinkId)
                    .HasColumnName("ParentLinkID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.UpdatedDt)
                    .HasColumnName("UpdatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdatedUserId)
                    .HasColumnName("UpdatedUserID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Visible).HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<MtlBrandD>(entity =>
            {
                entity.HasKey(e => e.MaterialBrandDetId);

                entity.ToTable("MTL_Brand_D");

                entity.Property(e => e.MaterialBrandDetId).HasColumnName("MaterialBrandDetID");

                entity.Property(e => e.CreatedDt)
                    .HasColumnName("CreatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedUserId).HasColumnName("CreatedUserID");

                entity.Property(e => e.MaterialBrandId).HasColumnName("MaterialBrandID");

                entity.Property(e => e.MaterialId).HasColumnName("MaterialID");

                entity.Property(e => e.UpdatedDt)
                    .HasColumnName("UpdatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdatedUserId).HasColumnName("UpdatedUserID");
            });

            modelBuilder.Entity<MtlBrandM>(entity =>
            {
                entity.HasKey(e => e.MaterialBrandId);

                entity.ToTable("MTL_Brand_M");

                entity.Property(e => e.MaterialBrandId).HasColumnName("MaterialBrandID");

                entity.Property(e => e.CreatedDt)
                    .HasColumnName("CreatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedUserId).HasColumnName("CreatedUserID");

                entity.Property(e => e.Description)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.MaterialBrand)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedDt)
                    .HasColumnName("UpdatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdatedUserId).HasColumnName("UpdatedUserID");
            });

            modelBuilder.Entity<MtlCategoryFieldGroups>(entity =>
            {
                entity.HasKey(e => e.MaterialTypeFieldGroupId);

                entity.ToTable("MTL_CategoryFieldGroups");

                entity.Property(e => e.MaterialTypeFieldGroupId).HasColumnName("MaterialTypeFieldGroupID");

                entity.Property(e => e.CreatedDt)
                    .HasColumnName("CreatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedUserId).HasColumnName("CreatedUserID");

                entity.Property(e => e.MaterialCategoryId).HasColumnName("MaterialCategoryID");

                entity.Property(e => e.MaterialFieldGroupId).HasColumnName("MaterialFieldGroupID");

                entity.Property(e => e.UpdatedDt)
                    .HasColumnName("UpdatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdatedUserId).HasColumnName("UpdatedUserID");
            });

            modelBuilder.Entity<MtlCategoryM>(entity =>
            {
                entity.HasKey(e => e.MaterialCategoryId);

                entity.ToTable("MTL_Category_M");

                entity.Property(e => e.MaterialCategoryId).HasColumnName("MaterialCategoryID");

                entity.Property(e => e.CategoryDisplayNamePart)
                    .IsRequired()
                    .HasColumnName("CategoryDisplayName_Part")
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CompulsoryFields)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CreatedDt)
                    .HasColumnName("CreatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedUserId).HasColumnName("CreatedUserID");

                entity.Property(e => e.DefaultValueFields)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.FamilyEditPage)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.GroupId).HasColumnName("GroupID");

                entity.Property(e => e.IndustryType)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.IsAllowToAddDeleteFamily)
                    .HasColumnName("IsAllow_To_AddDelete_Family")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.MaterialClassIdOld).HasColumnName("MaterialClassID_Old");

                entity.Property(e => e.MaterialTypeCode)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.MaterialTypeName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ParameterString)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.PartEditPage)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.PcbtypeIdOld)
                    .HasColumnName("PCBTypeID_Old")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.ReportingUnitCategoryId).HasColumnName("Reporting_UnitCategoryID");

                entity.Property(e => e.UpdatedDt)
                    .HasColumnName("UpdatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdatedUserId).HasColumnName("UpdatedUserID");
            });

            modelBuilder.Entity<MtlCompanyParts>(entity =>
            {
                entity.HasKey(e => e.CompanyPartId);

                entity.ToTable("MTL_CompanyParts");

                entity.Property(e => e.CompanyPartId).HasColumnName("CompanyPartID");

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.CreatedDt)
                    .HasColumnName("CreatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedUserId).HasColumnName("CreatedUserID");

                entity.Property(e => e.IsPrincipleCompanyId).HasColumnName("IsPrincipleCompanyID");

                entity.Property(e => e.MaterialId).HasColumnName("MaterialID");

                entity.Property(e => e.UpdatedDt)
                    .HasColumnName("UpdatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdatedUserId).HasColumnName("UpdatedUserID");
            });

            modelBuilder.Entity<MtlCustomerReturnD>(entity =>
            {
                entity.HasKey(e => e.CustomerReturnDetId);

                entity.ToTable("MTL_CustomerReturn_D");

                entity.Property(e => e.CustomerReturnDetId).HasColumnName("CustomerReturnDetID");

                entity.Property(e => e.CustomerReturnId).HasColumnName("CustomerReturnID");

                entity.Property(e => e.InvoiceId).HasColumnName("InvoiceID");

                entity.Property(e => e.MaterialId).HasColumnName("MaterialID");

                entity.Property(e => e.QtyInSalesDeliveryUnit).HasColumnName("Qty_In_SalesDeliveryUnit");

                entity.Property(e => e.QtyInSkunit).HasColumnName("Qty_In_SKUnit");

                entity.Property(e => e.SalesDeliveryUnitId).HasColumnName("SalesDeliveryUnitID");

                entity.Property(e => e.SkuunitId).HasColumnName("SKUUnitID");
            });

            modelBuilder.Entity<MtlCustomerReturnLogDetailD>(entity =>
            {
                entity.HasKey(e => e.CustomerReturnDetailLogId);

                entity.ToTable("MTL_CustomerReturnLogDetail_D");

                entity.Property(e => e.CustomerReturnDetailLogId).HasColumnName("CustomerReturnDetailLogID");

                entity.Property(e => e.BatchNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.BatchNoId).HasColumnName("BatchNoID");

                entity.Property(e => e.BrandId)
                    .HasColumnName("BrandID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CreatedDt)
                    .HasColumnName("CreatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedUserId).HasColumnName("CreatedUserID");

                entity.Property(e => e.CustomerReturnDetId).HasColumnName("CustomerReturnDetID");

                entity.Property(e => e.InvoiceId).HasColumnName("InvoiceID");

                entity.Property(e => e.MaterialId).HasColumnName("MaterialID");

                entity.Property(e => e.UpdatedDt)
                    .HasColumnName("UpdatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdatedUserId).HasColumnName("UpdatedUserID");
            });

            modelBuilder.Entity<MtlCustomerReturnM>(entity =>
            {
                entity.HasKey(e => e.CustomerReturnId);

                entity.ToTable("MTL_CustomerReturn_M");

                entity.Property(e => e.CustomerReturnId).HasColumnName("CustomerReturnID");

                entity.Property(e => e.CreatedUserId).HasColumnName("CreatedUserID");

                entity.Property(e => e.CurrencyId).HasColumnName("CurrencyID");

                entity.Property(e => e.CustomerId).HasColumnName("CustomerID");

                entity.Property(e => e.CustomerReturnDt)
                    .HasColumnName("CustomerReturnDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CustomerReturnNum)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ExciseId).HasColumnName("ExciseID");

                entity.Property(e => e.InvoiceId).HasColumnName("InvoiceID");

                entity.Property(e => e.InvoiceNum)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IsRoundOff).HasDefaultValueSql("((1))");

                entity.Property(e => e.OtherChargesName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OtherChargesValueAfter).HasColumnName("OtherChargesValue_After");

                entity.Property(e => e.PafchargesName)
                    .HasColumnName("PAFChargesName")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PafchargesValue).HasColumnName("PAFChargesValue");

                entity.Property(e => e.SalesTaxId).HasColumnName("SalesTaxID");
            });

            modelBuilder.Entity<MtlDumpM>(entity =>
            {
                entity.HasKey(e => e.MaterialDumpId);

                entity.ToTable("MTL_Dump_M");

                entity.Property(e => e.MaterialDumpId).HasColumnName("MaterialDumpID");

                entity.Property(e => e.BatchNo)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.BatchNoMaterialTransactionId).HasColumnName("BatchNo_MaterialTransactionID");

                entity.Property(e => e.BatchNoQty)
                    .HasColumnName("BatchNo_Qty")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.BrandId).HasColumnName("BrandID");

                entity.Property(e => e.CreatedDt)
                    .HasColumnName("CreatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedUserId).HasColumnName("CreatedUserID");

                entity.Property(e => e.MaterialId).HasColumnName("MaterialID");

                entity.Property(e => e.Notes)
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MtlFieldGroupM>(entity =>
            {
                entity.HasKey(e => e.MaterialFieldGroupId);

                entity.ToTable("MTL_FieldGroup_M");

                entity.Property(e => e.MaterialFieldGroupId).HasColumnName("MaterialFieldGroupID");

                entity.Property(e => e.CreatedDt)
                    .HasColumnName("CreatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedUserId).HasColumnName("CreatedUserID");

                entity.Property(e => e.MaterialFieldGroup)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.MaterialFieldGroupOrder).HasDefaultValueSql("((0))");

                entity.Property(e => e.TestCriteriaType).HasColumnName("TestCriteria_Type");

                entity.Property(e => e.UpdatedDt)
                    .HasColumnName("UpdatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdatedUserId).HasColumnName("UpdatedUserID");
            });

            modelBuilder.Entity<MtlFieldsD>(entity =>
            {
                entity.HasKey(e => e.MtlPrdFieldDetId);

                entity.ToTable("MTL_Fields_D");

                entity.Property(e => e.MtlPrdFieldDetId).HasColumnName("MTL_PRD_FieldDetID");

                entity.Property(e => e.CreatedDt)
                    .HasColumnName("CreatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedUserId).HasColumnName("CreatedUserID");

                entity.Property(e => e.DeviationScopeFromValue)
                    .HasColumnName("DeviationScope_FromValue")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.DeviationScopeToValue)
                    .HasColumnName("DeviationScope_ToValue")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.FieldGroupId).HasColumnName("FieldGroupID");

                entity.Property(e => e.FieldId).HasColumnName("FieldID");

                entity.Property(e => e.FieldValue)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.FieldValueId).HasColumnName("FieldValueID");

                entity.Property(e => e.IsEnterObservedValue).HasColumnName("IsEnter_ObservedValue");

                entity.Property(e => e.MaterialId).HasColumnName("MaterialID");

                entity.Property(e => e.MaterialSubCategoryFieldId).HasColumnName("MaterialSubCategoryFieldID");

                entity.Property(e => e.ShowInWebsite)
                    .HasColumnName("ShowIn_Website")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.UpdatedDt)
                    .HasColumnName("UpdatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdatedUserId).HasColumnName("UpdatedUserID");
            });

            modelBuilder.Entity<MtlFieldsM>(entity =>
            {
                entity.HasKey(e => e.MaterialFieldId);

                entity.ToTable("MTL_Fields_M");

                entity.Property(e => e.MaterialFieldId).HasColumnName("MaterialFieldID");

                entity.Property(e => e.AllowChangeOfType).HasDefaultValueSql("((1))");

                entity.Property(e => e.CreatedDt)
                    .HasColumnName("CreatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedUserId)
                    .HasColumnName("CreatedUserID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Criticality).HasDefaultValueSql("((0))");

                entity.Property(e => e.DefaultUnitId).HasColumnName("DefaultUnitID");

                entity.Property(e => e.FieldDescription)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FieldDisplayCellX).HasColumnName("FieldDisplay_Cell_X");

                entity.Property(e => e.FieldDisplayCellY)
                    .HasColumnName("FieldDisplay_Cell_Y")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.FieldDisplayName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.FieldShortName)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.FieldValueCellX).HasColumnName("FieldValue_Cell_X");

                entity.Property(e => e.FieldValueCellY)
                    .HasColumnName("FieldValue_Cell_Y")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.HasFixValueOld).HasColumnName("HasFixValue_Old");

                entity.Property(e => e.IsEnterObservedValue).HasColumnName("IsEnter_ObservedValue");

                entity.Property(e => e.IsUsedInAutoQuote).HasColumnName("IsUsed_InAutoQuote");

                entity.Property(e => e.MaterialField)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.MaterialFieldGroupId).HasColumnName("MaterialFieldGroupID");

                entity.Property(e => e.MaterialFieldTypeId)
                    .HasColumnName("MaterialFieldTypeID")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.ObservedValueType).HasColumnName("ObservedValue_Type");

                entity.Property(e => e.ShowInInfoSheet).HasColumnName("ShowIn_InfoSheet");

                entity.Property(e => e.ShowInMaster)
                    .HasColumnName("ShowIn_Master")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.ShowInQuotation).HasColumnName("ShowIn_Quotation");

                entity.Property(e => e.ShowInTraveler).HasColumnName("ShowIn_Traveler");

                entity.Property(e => e.ShowInWebsite)
                    .HasColumnName("ShowIn_Website")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.UpdatedDt)
                    .HasColumnName("UpdatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdatedUserId)
                    .HasColumnName("UpdatedUserID")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<MtlFieldTypeM>(entity =>
            {
                entity.HasKey(e => e.MaterialFieldTypeId);

                entity.ToTable("MTL_FieldType_M");

                entity.Property(e => e.MaterialFieldTypeId).HasColumnName("MaterialFieldTypeID");

                entity.Property(e => e.CreatedDt)
                    .HasColumnName("CreatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedUserId).HasColumnName("CreatedUserID");

                entity.Property(e => e.MaterialFieldType)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedDt)
                    .HasColumnName("UpdatedDT")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.UpdatedUserId).HasColumnName("UpdatedUserID");
            });

            modelBuilder.Entity<MtlIssueD>(entity =>
            {
                entity.HasKey(e => e.MaterialIssueDetailId);

                entity.ToTable("MTL_Issue_D");

                entity.Property(e => e.MaterialIssueDetailId).HasColumnName("MaterialIssueDetailID");

                entity.Property(e => e.BatchNo)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.BatchNoMaterialTransactionId).HasColumnName("BatchNo_MaterialTransactionID");

                entity.Property(e => e.BatchNoQty)
                    .HasColumnName("BatchNo_Qty")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.BrandId).HasColumnName("BrandID");

                entity.Property(e => e.CompletedTillProcessId)
                    .HasColumnName("CompletedTillProcessID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CreatedDt)
                    .HasColumnName("CreatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedUserId)
                    .HasColumnName("CreatedUserID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.EmployeeId)
                    .HasColumnName("EmployeeID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.JobNum)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.MaterialCategoryId)
                    .HasColumnName("MaterialCategoryID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.MaterialId)
                    .HasColumnName("MaterialID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.MaterialInUsedQty).HasColumnName("MaterialInUsed_Qty");

                entity.Property(e => e.MaterialIssueId)
                    .HasColumnName("MaterialIssueID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.MaterialIssueReqDetId).HasColumnName("MaterialIssueReqDetID");

                entity.Property(e => e.MaterialSubCategoryId)
                    .HasColumnName("MaterialSubCategoryID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.NeededOn)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ProcessGroupId)
                    .HasColumnName("ProcessGroupID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ProcessStepId)
                    .HasColumnName("ProcessStepID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.Property(e => e.RequestedQty).HasDefaultValueSql("((0))");

                entity.Property(e => e.UpdatedDt)
                    .HasColumnName("UpdatedDT")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.UpdatedUserId).HasColumnName("UpdatedUserID");

                entity.Property(e => e.WorkOrderId).HasColumnName("WorkOrderID");
            });

            modelBuilder.Entity<MtlIssueM>(entity =>
            {
                entity.HasKey(e => e.MaterialIssueId);

                entity.ToTable("MTL_Issue_M");

                entity.Property(e => e.MaterialIssueId).HasColumnName("MaterialIssueID");

                entity.Property(e => e.CreatedDt)
                    .HasColumnName("CreatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedUserId)
                    .HasColumnName("CreatedUserID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.MaterialIssueRequestId)
                    .HasColumnName("MaterialIssueRequestID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.MaterialIssueSlipConfigNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Notes)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Status).HasDefaultValueSql("((1))");

                entity.Property(e => e.UpdatedDt)
                    .HasColumnName("UpdatedDT")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.UpdatedUserId).HasColumnName("UpdatedUserID");
            });

            modelBuilder.Entity<MtlIssueRequestD>(entity =>
            {
                entity.HasKey(e => e.MaterialIssueRequestDetailId);

                entity.ToTable("MTL_IssueRequest_D");

                entity.Property(e => e.MaterialIssueRequestDetailId).HasColumnName("MaterialIssueRequestDetailID");

                entity.Property(e => e.BrandId).HasColumnName("BrandID");

                entity.Property(e => e.CompletedTillProcessId)
                    .HasColumnName("CompletedTillProcessID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CreatedDt)
                    .HasColumnName("CreatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedUserId)
                    .HasColumnName("CreatedUserID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.EmployeeId)
                    .HasColumnName("EmployeeID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.JobNum)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.MaterialId)
                    .HasColumnName("MaterialID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.MaterialIssueRequestId)
                    .HasColumnName("MaterialIssueRequestID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.MaterialSubCategoryId)
                    .HasColumnName("MaterialSubCategoryID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.MaterialTypeId)
                    .HasColumnName("MaterialTypeID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.NeededOn)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ProcessGroupId)
                    .HasColumnName("ProcessGroupID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ProcessStepId)
                    .HasColumnName("ProcessStepID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.RequestedQty).HasDefaultValueSql("((0))");

                entity.Property(e => e.UpdatedDt)
                    .HasColumnName("UpdatedDT")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.UpdatedUserId).HasColumnName("UpdatedUserID");

                entity.Property(e => e.WorkOrderId).HasColumnName("WorkOrderID");
            });

            modelBuilder.Entity<MtlIssueRequestM>(entity =>
            {
                entity.HasKey(e => e.MaterialIssueRequestId);

                entity.ToTable("MTL_IssueRequest_M");

                entity.Property(e => e.MaterialIssueRequestId).HasColumnName("MaterialIssueRequestID");

                entity.Property(e => e.CreatedDt)
                    .HasColumnName("CreatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedUserId)
                    .HasColumnName("CreatedUserID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.IssueRequestSlipNo).HasDefaultValueSql("((0))");

                entity.Property(e => e.IssuedDt)
                    .HasColumnName("IssuedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Notes)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Status).HasDefaultValueSql("((1))");

                entity.Property(e => e.UpdatedDt)
                    .HasColumnName("UpdatedDT")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.UpdatedUserId).HasColumnName("UpdatedUserID");
            });

            modelBuilder.Entity<MtlMaterialConversionD>(entity =>
            {
                entity.HasKey(e => e.MaterialConversionDetId);

                entity.ToTable("MTL_MaterialConversion_D");

                entity.Property(e => e.MaterialConversionDetId).HasColumnName("MaterialConversionDetID");

                entity.Property(e => e.BatchNo).HasMaxLength(50);

                entity.Property(e => e.BrandId)
                    .HasColumnName("BrandID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.FamilyId).HasColumnName("FamilyID");

                entity.Property(e => e.MaterialConversionId).HasColumnName("MaterialConversionID");

                entity.Property(e => e.MaterialId).HasColumnName("MaterialID");
            });

            modelBuilder.Entity<MtlMaterialConversionM>(entity =>
            {
                entity.HasKey(e => e.MaterialConversionId);

                entity.ToTable("MTL_MaterialConversion_M");

                entity.Property(e => e.MaterialConversionId).HasColumnName("MaterialConversionID");

                entity.Property(e => e.ConversionReason)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDt)
                    .HasColumnName("CreatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedUserId).HasColumnName("CreatedUserID");

                entity.Property(e => e.MaterialConversionNum)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Notes)
                    .HasMaxLength(1000)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MtlMaterialM>(entity =>
            {
                entity.HasKey(e => e.MaterialId);

                entity.ToTable("MTL_Material_M");

                entity.Property(e => e.MaterialId).HasColumnName("MaterialID");

                entity.Property(e => e.AcceptableProcessFlowId).HasColumnName("AcceptableProcessFlowID");

                entity.Property(e => e.AllowExciseCredit).HasColumnName("Allow_ExciseCredit");

                entity.Property(e => e.AllowMigrationToHigherUnitOld).HasColumnName("AllowMigrationToHigherUnit_Old");

                entity.Property(e => e.AllowMigrationToLowerUnitOld).HasColumnName("AllowMigrationToLowerUnit_Old");

                entity.Property(e => e.AllowReValuation)
                    .HasColumnName("Allow_ReValuation")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.AllowSalesTaxCredit).HasColumnName("Allow_SalesTaxCredit");

                entity.Property(e => e.AllowSupplierToQuote).HasColumnName("Allow_Supplier_To_Quote");

                entity.Property(e => e.AvgPriceOld)
                    .HasColumnName("AvgPrice_Old")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CfSkunitIdToPoaunitIdDenominator).HasColumnName("CF_SKUnitID_To_POAUnitID_Denominator");

                entity.Property(e => e.CfSkunitIdToPoaunitIdNumerator).HasColumnName("CF_SKUnitID_To_POAUnitID_Numerator");

                entity.Property(e => e.CfSkunitIdToProdQtyUnitIdDenominator).HasColumnName("CF_SKUnitID_To_ProdQtyUnitID_Denominator");

                entity.Property(e => e.CfSkunitIdToProdQtyUnitIdNumerator).HasColumnName("CF_SKUnitID_To_ProdQtyUnitID_Numerator");

                entity.Property(e => e.CfSkunitIdToPurchaseReceiptUnitIdDenominator).HasColumnName("CF_SKUnitID_To_PurchaseReceiptUnitID_Denominator");

                entity.Property(e => e.CfSkunitIdToPurchaseReceiptUnitIdNumerator).HasColumnName("CF_SKUnitID_To_PurchaseReceiptUnitID_Numerator");

                entity.Property(e => e.CfSkunitIdToReportingUnitIdDenominator).HasColumnName("CF_SKUnitID_To_ReportingUnitID_Denominator");

                entity.Property(e => e.CfSkunitIdToReportingUnitIdNumerator).HasColumnName("CF_SKUnitID_To_ReportingUnitID_Numerator");

                entity.Property(e => e.CfSkunitIdToSalesDeliveryUnitIdNumerator).HasColumnName("CF_SKUnitID_To_SalesDeliveryUnitID_Numerator");

                entity.Property(e => e.CfSkunitIdToSalesDeliveryUnitUnitIdDenominator).HasColumnName("CF_SKUnitID_To_SalesDeliveryUnitUnitID_Denominator");

                entity.Property(e => e.Charge1Name)
                    .HasColumnName("Charge1_Name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Charge2Name)
                    .HasColumnName("Charge2_Name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Charge3Name)
                    .HasColumnName("Charge3_Name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Charge4Name)
                    .HasColumnName("Charge4_Name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ConversionFactorUnitCategoryConversionOld).HasColumnName("ConversionFactor_UnitCategoryConversion_Old");

                entity.Property(e => e.ConversionfactorUnitOld).HasColumnName("Conversionfactor_Unit_Old");

                entity.Property(e => e.CreatedDt)
                    .HasColumnName("CreatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedUserId).HasColumnName("CreatedUserID");

                entity.Property(e => e.Criticality).HasDefaultValueSql("((0))");

                entity.Property(e => e.CurrencyId)
                    .HasColumnName("CurrencyID")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.CurrentRate)
                    .HasColumnName("Current_Rate")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.DefaultExpiryPeriodDays).HasColumnName("DefaultExpiryPeriod_Days");

                entity.Property(e => e.DefaultInventoryRate).HasDefaultValueSql("((0))");

                entity.Property(e => e.DeliveryDays).HasDefaultValueSql("((1))");

                entity.Property(e => e.DeliveryUnitIdOld).HasColumnName("DeliveryUnitID_Old");

                entity.Property(e => e.DisplayPartName)
                    .HasMaxLength(120)
                    .IsUnicode(false);

                entity.Property(e => e.ErrorMarginPercent).HasDefaultValueSql("((0))");

                entity.Property(e => e.ExcessAllowanceIssuePercentage).HasColumnName("Excess_AllowanceIssue_Percentage");

                entity.Property(e => e.ExciseCreditPercentage)
                    .HasColumnName("ExciseCredit_Percentage")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ExpiryDtOld)
                    .HasColumnName("ExpiryDT_Old")
                    .HasColumnType("datetime");

                entity.Property(e => e.InitialAvgPriceInDefaultCurrencyOld)
                    .HasColumnName("InitialAvgPrice_In_DefaultCurrency_Old")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.InitialAvgPriceInRsOld)
                    .HasColumnName("InitialAvgPriceInRs_Old")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.InitialAvgPriceOld)
                    .HasColumnName("InitialAvgPrice_Old")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.InitialStockQtyOld)
                    .HasColumnName("InitialStockQty_Old")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.InitialUsedQtyOld)
                    .HasColumnName("InitialUsedQty_Old")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.InspectionPolicy)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.IsAcceptPoonlyAgainstQuotations).HasColumnName("IsAcceptPOOnlyAgainstQuotations");

                entity.Property(e => e.IsAllowDirectPurchaseWithoutPo).HasColumnName("IsAllowDirectPurchaseWithoutPO");

                entity.Property(e => e.IsAllowExcessIssueMoreThanJobRequirement).HasColumnName("IsAllowExcessIssue_MoreThanJobRequirement");

                entity.Property(e => e.IsAllowIssueFromSingleBatchOnly).HasColumnName("IsAllowIssue_From_SingleBatchOnly");

                entity.Property(e => e.IsAllowReceiptWithoutInspectionOld).HasColumnName("IsAllowReceiptWithoutInspection_Old");

                entity.Property(e => e.IsAllowSupplierToTransferMaterialToSpecificJobOld).HasColumnName("IsAllowSupplierToTransferMaterialToSpecificJob_Old");

                entity.Property(e => e.IsAllowTransferToDifferentJobAtWiplevel).HasColumnName("IsAllowTransfer_ToDifferentJob_AtWIPLevel");

                entity.Property(e => e.IsCompletedBom).HasColumnName("IsCompleted_BOM");

                entity.Property(e => e.IsCompletedByproduct).HasColumnName("IsCompleted_Byproduct");

                entity.Property(e => e.IsCompletedCharacteristics).HasColumnName("IsCompleted_Characteristics");

                entity.Property(e => e.IsCompletedCharges).HasColumnName("IsCompleted_Charges");

                entity.Property(e => e.IsCompletedFiles).HasColumnName("IsCompleted_Files");

                entity.Property(e => e.IsCompletedNotes).HasColumnName("IsCompleted_Notes");

                entity.Property(e => e.IsCompletedProcessFlow).HasColumnName("IsCompleted_ProcessFlow");

                entity.Property(e => e.IsCompletedPurchase).HasColumnName("IsCompleted_Purchase");

                entity.Property(e => e.IsCompletedSales).HasColumnName("IsCompleted_Sales");

                entity.Property(e => e.IsCompletedStore).HasColumnName("IsCompleted_Store");

                entity.Property(e => e.IsCompletedSubAssembly).HasColumnName("IsCompleted_SubAssembly");

                entity.Property(e => e.IsCompletedUnit).HasColumnName("IsCompleted_Unit");

                entity.Property(e => e.IsCompletedWebsite).HasColumnName("IsCompleted_Website");

                entity.Property(e => e.IsConsumedInGeneral).HasColumnName("IsConsumed_In_General");

                entity.Property(e => e.IsConsumedInProduction).HasColumnName("IsConsumed_In_Production");

                entity.Property(e => e.IsExpiredOld).HasColumnName("IsExpired_Old");

                entity.Property(e => e.IsGeneratedAsScrap).HasColumnName("IsGenerated_As_Scrap");

                entity.Property(e => e.IsHaveSubAssembly).HasColumnName("IsHave_SubAssembly");

                entity.Property(e => e.IsManufacturedInHouse).HasColumnName("IsManufactured_InHouse");

                entity.Property(e => e.IsOrderAcceptanceUnitSameAsSku).HasColumnName("IsOrderAcceptanceUnit_SameAs_SKU");

                entity.Property(e => e.IsProductionQtyUnitSameAsSku).HasColumnName("IsProductionQtyUnit_SameAs_SKU");

                entity.Property(e => e.IsPurchaseFromAnySupplierOld).HasColumnName("IsPurchaseFromAnySupplier_Old");

                entity.Property(e => e.IsPurchaseFromOutsideSuppliers).HasColumnName("IsPurchase_From_OutsideSuppliers");

                entity.Property(e => e.IsPurchaseReceiptUnitSameAsSku).HasColumnName("IsPurchaseReceiptUnit_SameAs_SKU");

                entity.Property(e => e.IsReceivedFromProductionAsByproduct).HasColumnName("IsReceived_From_Production_As_Byproduct");

                entity.Property(e => e.IsSalesDeliveryUnitSameAsSku).HasColumnName("IsSalesDeliveryUnit_SameAs_SKU");

                entity.Property(e => e.IsSellOnlyAgainstPo).HasColumnName("IsSellOnlyAgainstPO");

                entity.Property(e => e.IsSellToAnyCustomerOld).HasColumnName("IsSellToAnyCustomer_Old");

                entity.Property(e => e.IsSetRelationBetweenSkuAndOrderAcceptanceUnit).HasColumnName("IsSetRelation_between_SKU_And_OrderAcceptanceUnit");

                entity.Property(e => e.IsSetRelationBetweenSkuAndProductionQtyUnit).HasColumnName("IsSetRelation_between_SKU_And_ProductionQtyUnit");

                entity.Property(e => e.IsSetRelationBetweenSkuAndPurchaseReceiptUnit).HasColumnName("IsSetRelation_between_SKU_And_PurchaseReceiptUnit");

                entity.Property(e => e.IsSetRelationBetweenSkuAndSalesDeliveryUnit).HasColumnName("IsSetRelation_between_SKU_And_SalesDeliveryUnit");

                entity.Property(e => e.IsSoldAsCustomProduct).HasColumnName("IsSold_As_CustomProduct");

                entity.Property(e => e.IsSoldAsSideScrapItem).HasColumnName("IsSold_As_Side_Scrap_Item");

                entity.Property(e => e.IsSoldAsSpareAccessoryItem).HasColumnName("IsSold_As_Spare_Accessory_Item");

                entity.Property(e => e.IsSoldAsStdProduct).HasColumnName("IsSold_As_StdProduct");

                entity.Property(e => e.IssueIncrement).HasDefaultValueSql("((0))");

                entity.Property(e => e.IssueUnitId).HasColumnName("IssueUnitID");

                entity.Property(e => e.ItemMovement).HasDefaultValueSql("((2))");

                entity.Property(e => e.ItemValue).HasDefaultValueSql("((2))");

                entity.Property(e => e.LatestCurrencyPriceOld)
                    .HasColumnName("LatestCurrencyPrice_Old")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.LaunchUnitIdOld).HasColumnName("LaunchUnitID_Old");

                entity.Property(e => e.LocationId).HasColumnName("LocationID");

                entity.Property(e => e.MainUnitCategoryIdOld).HasColumnName("MainUnitCategoryID_Old");

                entity.Property(e => e.MainUnitIdFromOld).HasColumnName("MainUnitID_From_Old");

                entity.Property(e => e.MainUnitIdToOld).HasColumnName("MainUnitID_To_Old");

                entity.Property(e => e.MainUnitIdUnitCategoryConversionOld).HasColumnName("MainUnitID_UnitCategoryConversion_Old");

                entity.Property(e => e.MaterialCategoryId).HasColumnName("MaterialCategoryID");

                entity.Property(e => e.MaterialCode)
                    .IsRequired()
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.MaterialName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.MaterialSubCategoryId)
                    .HasColumnName("MaterialSubCategoryID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.MaxRate).HasDefaultValueSql("((0))");

                entity.Property(e => e.MaximumRejectionAllowPercentage).HasColumnName("MaximumRejectionAllow_Percentage");

                entity.Property(e => e.MinLeadTime).HasDefaultValueSql("((0))");

                entity.Property(e => e.MinPurOrderQty).HasDefaultValueSql("((0))");

                entity.Property(e => e.MinRate).HasDefaultValueSql("((0))");

                entity.Property(e => e.MinStockQty).HasDefaultValueSql("((0))");

                entity.Property(e => e.NotesOld)
                    .HasColumnName("Notes_Old")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.OrderAcceptanceUnitUnitId).HasColumnName("OrderAcceptanceUnit_UnitID");

                entity.Property(e => e.OtherReferenceNo1)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.OtherReferenceNo2)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ParentPartId)
                    .HasColumnName("ParentPartID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ParentUnitCategoryIdOld).HasColumnName("Parent_UnitCategoryID_Old");

                entity.Property(e => e.ParentUnitIdBasisUnitCategoryConversionOld).HasColumnName("ParentUnitID_Basis_UnitCategoryConversion_Old");

                entity.Property(e => e.PartName)
                    .IsRequired()
                    .HasMaxLength(120)
                    .IsUnicode(false);

                entity.Property(e => e.PartTypeId)
                    .HasColumnName("PartTypeID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.PounitIdOld).HasColumnName("POUnitID_Old");

                entity.Property(e => e.Prefix)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PricePerUnitOld).HasColumnName("PricePerUnit_Old");

                entity.Property(e => e.ProductionQtyUnitId).HasColumnName("ProductionQty_UnitID");

                entity.Property(e => e.ProposedSaleRate).HasColumnName("Proposed_SaleRate");

                entity.Property(e => e.PurchaseReceiptUnitUnitId).HasColumnName("PurchaseReceiptUnit_UnitID");

                entity.Property(e => e.PurchaseUnitIdOld).HasColumnName("PurchaseUnitID_Old");

                entity.Property(e => e.SalesCreditPercentage)
                    .HasColumnName("SalesCredit_Percentage")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.SalesDeliveryUnitUnitId).HasColumnName("SalesDeliveryUnit_UnitID");

                entity.Property(e => e.SetId)
                    .HasColumnName("SetID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Suffix)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.SunitIdOld).HasColumnName("SUnitID_Old");

                entity.Property(e => e.TotalReceivedStockQtyOld).HasColumnName("TotalReceivedStockQty_Old");

                entity.Property(e => e.UnitIdOld).HasColumnName("UnitID_Old");

                entity.Property(e => e.UpdatedDt)
                    .HasColumnName("UpdatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdatedUserId).HasColumnName("UpdatedUserID");

                entity.Property(e => e.VersionNum)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MtlMaterialPriceList>(entity =>
            {
                entity.HasKey(e => e.MaterialPriceListId);

                entity.ToTable("MTL_MaterialPriceList");

                entity.Property(e => e.MaterialPriceListId).HasColumnName("MaterialPriceListID");

                entity.Property(e => e.CntRangeId)
                    .HasColumnName("CntRangeID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CounterFromRange)
                    .HasColumnName("Counter_FromRange")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CounterToRange)
                    .HasColumnName("Counter_ToRange")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CounterUnitId).HasColumnName("Counter_UnitID");

                entity.Property(e => e.CreatedDt)
                    .HasColumnName("CreatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedUserId).HasColumnName("CreatedUserID");

                entity.Property(e => e.MaterialId)
                    .HasColumnName("MaterialID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Price).HasDefaultValueSql("((0))");

                entity.Property(e => e.UpdatedDt)
                    .HasColumnName("UpdatedDT")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.UpdatedUserId).HasColumnName("UpdatedUserID");
            });

            modelBuilder.Entity<MtlMaterialSupplierOffersLogD>(entity =>
            {
                entity.HasKey(e => e.MaterialSupplierOffersLogDetId);

                entity.ToTable("MTL_MaterialSupplierOffersLog_D");

                entity.Property(e => e.MaterialSupplierOffersLogDetId).HasColumnName("MaterialSupplierOffersLogDetID");

                entity.Property(e => e.CreatedDt)
                    .HasColumnName("CreatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedUserId).HasColumnName("CreatedUserID");

                entity.Property(e => e.EmployeeId)
                    .HasColumnName("EmployeeID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.IsRfq).HasColumnName("IsRFQ");

                entity.Property(e => e.LeadTimeInDays).HasColumnName("Lead_Time_InDays");

                entity.Property(e => e.MaterialId).HasColumnName("MaterialID");

                entity.Property(e => e.Notes)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.OfferValidTillDt)
                    .HasColumnName("Offer_ValidTillDT")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.RefRfqMtlsupplierOfferLogDetId)
                    .HasColumnName("RefRFQ_MTLSupplierOfferLogDetID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.RefuseDt)
                    .HasColumnName("RefuseDT")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.RfqValidTillDt)
                    .HasColumnName("RFQ_ValidTillDT")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.SupplierId).HasColumnName("SupplierID");
            });

            modelBuilder.Entity<MtlMaterialSuppliers>(entity =>
            {
                entity.HasKey(e => e.MaterialSupplierId);

                entity.ToTable("MTL_MaterialSuppliers");

                entity.Property(e => e.MaterialSupplierId).HasColumnName("MaterialSupplierID");

                entity.Property(e => e.AllowDirectShipment).HasColumnName("Allow_DirectShipment");

                entity.Property(e => e.AllowSupplierToGenerateInvoice).HasColumnName("AllowSupplier_to_GenerateInvoice");

                entity.Property(e => e.CreatedDt)
                    .HasColumnName("CreatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedUserId).HasColumnName("CreatedUserID");

                entity.Property(e => e.DefaultSupplier).HasColumnName("Default_Supplier");

                entity.Property(e => e.IsNewRfq).HasColumnName("IsNew_RFQ");

                entity.Property(e => e.LeadTimeInDays).HasColumnName("Lead_Time_InDays");

                entity.Property(e => e.MaterialId).HasColumnName("MaterialID");

                entity.Property(e => e.MinQty).HasColumnName("Min_Qty");

                entity.Property(e => e.OfferValidTillDt)
                    .HasColumnName("Offer_ValidTillDT")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.RateOffered).HasColumnName("Rate_Offered");

                entity.Property(e => e.RateOfferedDt)
                    .HasColumnName("RateOfferedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.RefuseDt)
                    .HasColumnName("RefuseDT")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.RfqDt)
                    .HasColumnName("RFQ_DT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.RfqLeadTimeInDays)
                    .HasColumnName("RFQ_LeadTime_InDays")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.RfqMtlsupplierOfferLogDetId)
                    .HasColumnName("RFQ_MTLSupplierOfferLogDetID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.RfqQty)
                    .HasColumnName("RFQ_Qty")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.RfqRate)
                    .HasColumnName("RFQ_Rate")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.RfqValidTillDt)
                    .HasColumnName("RFQ_ValidTillDT")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.SupplierId).HasColumnName("SupplierID");

                entity.Property(e => e.UpdatedDt)
                    .HasColumnName("UpdatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdatedUserId).HasColumnName("UpdatedUserID");
            });

            modelBuilder.Entity<MtlMovementM>(entity =>
            {
                entity.HasKey(e => e.MtlmovementId);

                entity.ToTable("MTL_Movement_M");

                entity.Property(e => e.MtlmovementId).HasColumnName("MTLMovementID");

                entity.Property(e => e.CreatedDt)
                    .HasColumnName("CreatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedUserId).HasColumnName("CreatedUserID");

                entity.Property(e => e.Notes)
                    .HasMaxLength(300)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MtlOnlinePrice>(entity =>
            {
                entity.HasKey(e => e.OnlinePriceId);

                entity.ToTable("MTL_OnlinePrice");

                entity.Property(e => e.OnlinePriceId).HasColumnName("OnlinePriceID");

                entity.Property(e => e.CreatedDt)
                    .HasColumnName("CreatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedUserId)
                    .HasColumnName("CreatedUserID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CurrencyId)
                    .HasColumnName("CurrencyID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ItemId)
                    .HasColumnName("ItemID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Price).HasDefaultValueSql("((0))");

                entity.Property(e => e.SetId)
                    .HasColumnName("SetID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.UpdatedDt)
                    .HasColumnName("UpdatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdatedUserId)
                    .HasColumnName("UpdatedUserID")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<MtlPartCrmD>(entity =>
            {
                entity.HasKey(e => e.PartCrmid);

                entity.ToTable("MTL_PartCRM_D");

                entity.Property(e => e.PartCrmid).HasColumnName("PartCRMID");

                entity.Property(e => e.CreatedDt)
                    .HasColumnName("CreatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedUserId)
                    .HasColumnName("CreatedUserID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.DisplayFileName).IsUnicode(false);

                entity.Property(e => e.FileName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.IconImage).IsUnicode(false);

                entity.Property(e => e.IsOnlineAvailability).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsStockSensitivity).HasDefaultValueSql("((0))");

                entity.Property(e => e.MaterialId)
                    .HasColumnName("MaterialID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ProductImage1).IsUnicode(false);

                entity.Property(e => e.ProductImage2).IsUnicode(false);

                entity.Property(e => e.ProductImage3).IsUnicode(false);

                entity.Property(e => e.ProductImage4).IsUnicode(false);

                entity.Property(e => e.ProductImage5).IsUnicode(false);

                entity.Property(e => e.SetId)
                    .HasColumnName("SetID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.StandardPrice).HasDefaultValueSql("((0))");

                entity.Property(e => e.Title).HasMaxLength(100);

                entity.Property(e => e.UpdatedDt)
                    .HasColumnName("UpdatedDT")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.UpdatedUserId).HasColumnName("UpdatedUserID");
            });

            modelBuilder.Entity<MtlPartTypes>(entity =>
            {
                entity.HasKey(e => e.PartTypeId);

                entity.ToTable("MTL_PartTypes");

                entity.Property(e => e.PartTypeId).HasColumnName("PartTypeID");

                entity.Property(e => e.CreatedDt)
                    .HasColumnName("CreatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedUserId).HasColumnName("CreatedUserID");

                entity.Property(e => e.IsConsumedInGeneral).HasColumnName("IsConsumed_In_General");

                entity.Property(e => e.IsConsumedInProduction).HasColumnName("IsConsumed_In_Production");

                entity.Property(e => e.IsGeneratedAsScrap).HasColumnName("IsGenerated_As_Scrap");

                entity.Property(e => e.IsManufacturedInHouse).HasColumnName("IsManufactured_InHouse");

                entity.Property(e => e.IsPurchaseFromOutsideSuppliers).HasColumnName("IsPurchase_From_OutsideSuppliers");

                entity.Property(e => e.IsReceivedFromProductionAsByproduct).HasColumnName("IsReceived_From_Production_As_Byproduct");

                entity.Property(e => e.IsSoldAsCustomProduct).HasColumnName("IsSold_As_CustomProduct");

                entity.Property(e => e.IsSoldAsSideScrapItem).HasColumnName("IsSold_As_Side_Scrap_Item");

                entity.Property(e => e.IsSoldAsSpareAccessoryItem).HasColumnName("IsSold_As_Spare_Accessory_Item");

                entity.Property(e => e.IsSoldAsStdProduct).HasColumnName("IsSold_As_StdProduct");

                entity.Property(e => e.PartTypeName)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.PartTypeOrder)
                    .HasColumnName("PartType_Order")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.UpdatedDt)
                    .HasColumnName("UpdatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdatedUserId).HasColumnName("UpdatedUserID");
            });

            modelBuilder.Entity<MtlPotermD>(entity =>
            {
                entity.HasKey(e => e.PotermDetId);

                entity.ToTable("MTL_POTerm_D");

                entity.Property(e => e.PotermDetId).HasColumnName("POTermDetID");

                entity.Property(e => e.Poid)
                    .HasColumnName("POID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.PotermId)
                    .HasColumnName("POTermID")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<MtlPrdFieldOptions>(entity =>
            {
                entity.HasKey(e => e.MaterialFieldOptionId);

                entity.ToTable("MTL_PRD_FieldOptions");

                entity.Property(e => e.MaterialFieldOptionId).HasColumnName("MaterialFieldOptionID");

                entity.Property(e => e.CreatedDt)
                    .HasColumnName("CreatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedUserId)
                    .HasColumnName("CreatedUserID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.MaterialFieldId).HasColumnName("MaterialFieldID");

                entity.Property(e => e.OptionValue)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedDt)
                    .HasColumnName("UpdatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdatedUserId).HasColumnName("UpdatedUserID");
            });

            modelBuilder.Entity<MtlPrdFileTypeM>(entity =>
            {
                entity.HasKey(e => e.FileTypeId);

                entity.ToTable("MTL_PRD_FileType_M");

                entity.Property(e => e.FileTypeId).HasColumnName("FileTypeID");

                entity.Property(e => e.CareatedDt)
                    .HasColumnName("CareatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedUserId).HasColumnName("CreatedUserID");

                entity.Property(e => e.FileExtension)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.FileSizeInMb)
                    .HasColumnName("FileSize_In_MB")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.FileType)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedDt)
                    .HasColumnName("UpdatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdatedUserId).HasColumnName("UpdatedUserID");
            });

            modelBuilder.Entity<MtlPrdMaterialFileLog>(entity =>
            {
                entity.HasKey(e => e.MaterialFileLogId);

                entity.ToTable("MTL_PRD_MaterialFileLog");

                entity.Property(e => e.MaterialFileLogId).HasColumnName("MaterialFileLogID");

                entity.Property(e => e.CreatedDt)
                    .HasColumnName("CreatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedUserId).HasColumnName("CreatedUserID");

                entity.Property(e => e.FileName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FileTypeId).HasColumnName("FileTypeID");

                entity.Property(e => e.MaterialId).HasColumnName("MaterialID");

                entity.Property(e => e.UpdatedDt)
                    .HasColumnName("UpdatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdatedUserId).HasColumnName("UpdatedUserID");
            });

            modelBuilder.Entity<MtlPrdMaterialFiles>(entity =>
            {
                entity.HasKey(e => e.MaterialFileTypeId);

                entity.ToTable("MTL_PRD_MaterialFiles");

                entity.Property(e => e.MaterialFileTypeId).HasColumnName("MaterialFileTypeID");

                entity.Property(e => e.CreatedDt)
                    .HasColumnName("CreatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedUserId).HasColumnName("CreatedUserID");

                entity.Property(e => e.FileName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FileTypeId).HasColumnName("FileTypeID");

                entity.Property(e => e.MaterialId).HasColumnName("MaterialID");

                entity.Property(e => e.UpdatedDt)
                    .HasColumnName("UpdatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdatedUserId).HasColumnName("UpdatedUserID");
            });

            modelBuilder.Entity<MtlPrdMaterialNotes>(entity =>
            {
                entity.HasKey(e => e.MaterialNoteId);

                entity.ToTable("MTL_PRD_MaterialNotes");

                entity.Property(e => e.MaterialNoteId).HasColumnName("MaterialNoteID");

                entity.Property(e => e.CreatedDt)
                    .HasColumnName("CreatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedUserId).HasColumnName("CreatedUserID");

                entity.Property(e => e.MaterialId).HasColumnName("MaterialID");

                entity.Property(e => e.Note)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.NoteCategoryId)
                    .HasColumnName("Note_CategoryID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.NoteCategoryName)
                    .IsRequired()
                    .HasColumnName("Note_CategoryName")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TitleNote)
                    .IsRequired()
                    .HasColumnName("Title_Note")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedDt)
                    .HasColumnName("UpdatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdatedUserId).HasColumnName("UpdatedUserID");
            });

            modelBuilder.Entity<MtlPrdMaterialSubCategoryProcessStepUsageD>(entity =>
            {
                entity.HasKey(e => e.MaterialSubCategoryProcessStepUsageId);

                entity.ToTable("MTL_PRD_MaterialSubCategory_ProcessStep_Usage_D");

                entity.Property(e => e.MaterialSubCategoryProcessStepUsageId).HasColumnName("MaterialSubCategory_ProcessStep_UsageID");

                entity.Property(e => e.CreatedDt)
                    .HasColumnName("CreatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedUserId).HasColumnName("CreatedUserID");

                entity.Property(e => e.MaterialCategoryId).HasColumnName("MaterialCategoryID");

                entity.Property(e => e.MaterialId).HasColumnName("MaterialID");

                entity.Property(e => e.MaterialSubCategoryId).HasColumnName("MaterialSubCategoryID");

                entity.Property(e => e.ProcessStepId).HasColumnName("ProcessStepID");

                entity.Property(e => e.UpdatedDt)
                    .HasColumnName("UpdatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdatedUserId).HasColumnName("UpdatedUserID");

                entity.Property(e => e.UsageBasisId).HasColumnName("UsageBasisID");

                entity.Property(e => e.UsageQtyDenominator).HasColumnName("UsageQty_Denominator");

                entity.Property(e => e.UsageQtyDenominatorUnitId).HasColumnName("UsageQty_Denominator_UnitID");

                entity.Property(e => e.UsageQtyNumerator).HasColumnName("UsageQty_Numerator");

                entity.Property(e => e.UsageQtyNumeratorUnitId).HasColumnName("UsageQty_Numerator_UnitID");
            });

            modelBuilder.Entity<MtlPrdMultiValueFieldD>(entity =>
            {
                entity.HasKey(e => e.MaterialMultiValueFieldDetId);

                entity.ToTable("MTL_PRD_MultiValue_Field_D");

                entity.Property(e => e.MaterialMultiValueFieldDetId).HasColumnName("MaterialMultiValueFieldDetID");

                entity.Property(e => e.CreatedDt)
                    .HasColumnName("CreatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedUserId).HasColumnName("CreatedUserID");

                entity.Property(e => e.MaterialFieldGroupId).HasColumnName("MaterialFieldGroupID");

                entity.Property(e => e.MaterialFieldId).HasColumnName("MaterialFieldID");

                entity.Property(e => e.MaterialFieldValueId).HasColumnName("MaterialFieldValueID");

                entity.Property(e => e.MaterialId).HasColumnName("MaterialID");

                entity.Property(e => e.MaterialSubCategoryFieldId).HasColumnName("MaterialSubCategoryFieldID");

                entity.Property(e => e.SrNoRow).HasColumnName("SrNo_Row");

                entity.Property(e => e.UpdatedDt)
                    .HasColumnName("UpdatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdatedUserId).HasColumnName("UpdatedUserID");

                entity.Property(e => e.Value)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MtlPrdSubCategoryBrands>(entity =>
            {
                entity.HasKey(e => e.MaterialSubCategoryBrandId);

                entity.ToTable("MTL_PRD_SubCategoryBrands");

                entity.Property(e => e.MaterialSubCategoryBrandId).HasColumnName("MaterialSubCategoryBrandID");

                entity.Property(e => e.BrandId).HasColumnName("BrandID");

                entity.Property(e => e.CreatedDt)
                    .HasColumnName("CreatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedUserId).HasColumnName("CreatedUserID");

                entity.Property(e => e.MaterialSubCategoryId).HasColumnName("MaterialSubCategoryID");

                entity.Property(e => e.UpdatedDt)
                    .HasColumnName("UpdatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdatedUserId).HasColumnName("UpdatedUserID");
            });

            modelBuilder.Entity<MtlPrdSubCategoryFileTypes>(entity =>
            {
                entity.HasKey(e => e.MaterialSubCategoryFileTypeId);

                entity.ToTable("MTL_PRD_SubCategoryFileTypes");

                entity.Property(e => e.MaterialSubCategoryFileTypeId).HasColumnName("MaterialSubCategoryFileTypeID");

                entity.Property(e => e.CreatedDt)
                    .HasColumnName("CreatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedUserId).HasColumnName("CreatedUserID");

                entity.Property(e => e.FileTypeId).HasColumnName("FileTypeID");

                entity.Property(e => e.MaterialSubCategoryId).HasColumnName("MaterialSubCategoryID");

                entity.Property(e => e.UpdatedDt)
                    .HasColumnName("UpdatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdatedUserId).HasColumnName("UpdatedUserID");
            });

            modelBuilder.Entity<MtlPurchaseD>(entity =>
            {
                entity.HasKey(e => e.MaterialPodetailId);

                entity.ToTable("MTL_Purchase_D");

                entity.Property(e => e.MaterialPodetailId).HasColumnName("MaterialPODetailID");

                entity.Property(e => e.BatchNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDt)
                    .HasColumnName("CreatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedUserId)
                    .HasColumnName("CreatedUserID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CurrencyId).HasColumnName("CurrencyID");

                entity.Property(e => e.DeliveryDt).HasColumnType("smalldatetime");

                entity.Property(e => e.DeliveryRecordNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EstimateTargetDt)
                    .HasColumnName("EstimateTargetDT")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.MaterialBrandId).HasColumnName("MaterialBrandID");

                entity.Property(e => e.MaterialCategoryId).HasColumnName("MaterialCategoryID");

                entity.Property(e => e.MaterialId).HasColumnName("MaterialID");

                entity.Property(e => e.MaterialPoid).HasColumnName("MaterialPOID");

                entity.Property(e => e.MaterialPurchaseReqDetId).HasColumnName("MaterialPurchaseReqDetID");

                entity.Property(e => e.MaterialSubCategoryId).HasColumnName("MaterialSubCategoryID");

                entity.Property(e => e.MktPoitemId).HasColumnName("MKT_POItemID");

                entity.Property(e => e.ModeId)
                    .HasColumnName("ModeID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.NeededBy).HasColumnType("smalldatetime");

                entity.Property(e => e.OtherProcessGroupName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProcessGroupId).HasColumnName("ProcessGroupID");

                entity.Property(e => e.PurchaseReceiptUnitQty).HasColumnName("PurchaseReceiptUnit_Qty");

                entity.Property(e => e.ShipperId)
                    .HasColumnName("ShipperID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Status).HasDefaultValueSql("((0))");

                entity.Property(e => e.StatusOptionId).HasColumnName("StatusOptionID");

                entity.Property(e => e.SupplierId)
                    .HasColumnName("SupplierID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TotalAmt)
                    .HasColumnType("decimal(20, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TotalAmtDefaultCurrency).HasColumnName("TotalAmt_DefaultCurrency");

                entity.Property(e => e.TrackingNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedDt)
                    .HasColumnName("UpdatedDT")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.UpdatedUserId).HasColumnName("UpdatedUserID");
            });

            modelBuilder.Entity<MtlPurchaseM>(entity =>
            {
                entity.HasKey(e => e.MaterialPoid);

                entity.ToTable("MTL_Purchase_M");

                entity.HasIndex(e => e.MaterialPoid)
                    .HasName("IX_MaterialPurchase_M");

                entity.Property(e => e.MaterialPoid).HasColumnName("MaterialPOID");

                entity.Property(e => e.AmdDate).HasColumnType("smalldatetime");

                entity.Property(e => e.AmdNo)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDt)
                    .HasColumnName("CreatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedUserId)
                    .HasColumnName("CreatedUserID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.DefaultCurrencyId).HasColumnName("DefaultCurrencyID");

                entity.Property(e => e.DisappReason)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ExciseTaxId).HasColumnName("ExciseTaxID");

                entity.Property(e => e.GrandTotalDefaultCurrency).HasColumnName("GrandTotal_DefaultCurrency");

                entity.Property(e => e.MaterialPonum)
                    .HasColumnName("MaterialPONum")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModeId)
                    .HasColumnName("ModeID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.MtlPoSerialNum)
                    .HasColumnName("MTL_PO_serialNum")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.OtherChargesaName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PaymentTerms)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Podate)
                    .HasColumnName("PODate")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.PotypeId).HasColumnName("POTypeID");

                entity.Property(e => e.Remarks)
                    .IsRequired()
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.SaleTaxId).HasColumnName("SaleTaxID");

                entity.Property(e => e.ShipperId)
                    .HasColumnName("ShipperID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Status).HasDefaultValueSql("((1))");

                entity.Property(e => e.UpdatedDt)
                    .HasColumnName("UpdatedDT")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.UpdatedUserId).HasColumnName("UpdatedUserID");
            });

            modelBuilder.Entity<MtlPurchaseRequestD>(entity =>
            {
                entity.HasKey(e => e.MaterialPurchaseReqDetId);

                entity.ToTable("MTL_PurchaseRequest_D");

                entity.Property(e => e.MaterialPurchaseReqDetId).HasColumnName("MaterialPurchaseReqDetID");

                entity.Property(e => e.ApproveQtyOld)
                    .HasColumnName("ApproveQty_Old")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ApprovedQtyInPurchaseReceiptUnit)
                    .HasColumnName("ApprovedQty_In_PurchaseReceiptUnit")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ApprovedQtyInSkunit)
                    .HasColumnName("ApprovedQty_In_SKUnit")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CreatedDt)
                    .HasColumnName("CreatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedUserId).HasColumnName("CreatedUserID");

                entity.Property(e => e.CurrencyId).HasColumnName("CurrencyID");

                entity.Property(e => e.MaterialBrandId).HasColumnName("MaterialBrandID");

                entity.Property(e => e.MaterialCategoryId).HasColumnName("MaterialCategoryID");

                entity.Property(e => e.MaterialId).HasColumnName("MaterialID");

                entity.Property(e => e.MaterialPurchaseReqId).HasColumnName("MaterialPurchaseReqID");

                entity.Property(e => e.MaterialSubCategoryId).HasColumnName("MaterialSubCategoryID");

                entity.Property(e => e.NeededBy).HasColumnType("smalldatetime");

                entity.Property(e => e.Notes)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.OrderQtyOld)
                    .HasColumnName("OrderQty_Old")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.PricePerUnit).HasDefaultValueSql("((0))");

                entity.Property(e => e.PurchaseReceiptUnitQtyOld)
                    .HasColumnName("PurchaseReceiptUnit_Qty_Old")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.PurchaseReceiptUnitUnitId).HasColumnName("PurchaseReceiptUnit_UnitID");

                entity.Property(e => e.RequestedQtyInPurchaseReceiptUnit)
                    .HasColumnName("RequestedQty_In_PurchaseReceiptUnit")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.RequestedQtyInSkunit)
                    .HasColumnName("RequestedQty_In_SKUnit")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Status).HasColumnType("nchar(10)");

                entity.Property(e => e.SupplierId).HasColumnName("SupplierID");

                entity.Property(e => e.Total)
                    .HasColumnType("decimal(20, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TotalDefaultCurrency)
                    .HasColumnName("Total_DefaultCurrency")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.UpdatedDt)
                    .HasColumnName("UpdatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdatedUserId).HasColumnName("UpdatedUserID");
            });

            modelBuilder.Entity<MtlPurchaseRequestM>(entity =>
            {
                entity.HasKey(e => e.MaterialPurchaseReqId);

                entity.ToTable("MTL_PurchaseRequest_M");

                entity.Property(e => e.MaterialPurchaseReqId).HasColumnName("MaterialPurchaseReqID");

                entity.Property(e => e.CreatedDt)
                    .HasColumnName("CreatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedUserId).HasColumnName("CreatedUserID");

                entity.Property(e => e.Notes)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.PrslipNo).HasColumnName("PRSlipNo");

                entity.Property(e => e.Status).HasDefaultValueSql("((0))");

                entity.Property(e => e.TotalAmountDefaultCurrency)
                    .HasColumnName("TotalAmount_DefaultCurrency")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.UpdatedDt)
                    .HasColumnName("UpdatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdatedUserId).HasColumnName("UpdatedUserID");
            });

            modelBuilder.Entity<MtlPurchaseTaxD>(entity =>
            {
                entity.HasKey(e => e.PoTaxId);

                entity.ToTable("MTL_PurchaseTax_D");

                entity.Property(e => e.PoTaxId).HasColumnName("PoTaxID");

                entity.Property(e => e.CreatedDt)
                    .HasColumnName("CreatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedId).HasColumnName("CreatedID");

                entity.Property(e => e.MaterialPoid).HasColumnName("MaterialPOID");

                entity.Property(e => e.TaxId).HasColumnName("TaxID");

                entity.Property(e => e.UpdatedDt)
                    .HasColumnName("UpdatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdatedId).HasColumnName("UpdatedID");
            });

            modelBuilder.Entity<MtlPurchaseTrackingLogD>(entity =>
            {
                entity.HasKey(e => e.MaterialPurchaseTrackingLogId);

                entity.ToTable("MTL_PurchaseTrackingLog_D");

                entity.Property(e => e.MaterialPurchaseTrackingLogId).HasColumnName("MaterialPurchaseTrackingLogID");

                entity.Property(e => e.CreatedDt)
                    .HasColumnName("CreatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedUserId).HasColumnName("CreatedUserID");

                entity.Property(e => e.MaterialPodetailId).HasColumnName("MaterialPODetailID");

                entity.Property(e => e.StatusOptionId).HasColumnName("StatusOptionID");
            });

            modelBuilder.Entity<MtlReceiveD>(entity =>
            {
                entity.HasKey(e => e.MaterialReceiveDetailId);

                entity.ToTable("MTL_Receive_D");

                entity.Property(e => e.MaterialReceiveDetailId).HasColumnName("MaterialReceiveDetailID");

                entity.Property(e => e.AccepetedQty).HasDefaultValueSql("((0))");

                entity.Property(e => e.AccepetedQtySku).HasColumnName("AccepetedQty_SKU");

                entity.Property(e => e.BatchNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.BrandId).HasColumnName("BrandID");

                entity.Property(e => e.CompletedTillProcessId)
                    .HasColumnName("CompletedTillProcessID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CreatedDt)
                    .HasColumnName("CreatedDT")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.CreatedUserId).HasColumnName("CreatedUserID");

                entity.Property(e => e.CurrencyId).HasColumnName("CurrencyID");

                entity.Property(e => e.MaterialId).HasColumnName("MaterialID");

                entity.Property(e => e.MaterialPodetailId).HasColumnName("MaterialPODetailID");

                entity.Property(e => e.MaterialReceiveId).HasColumnName("MaterialReceiveID");

                entity.Property(e => e.MaterialSubCategoryId).HasColumnName("MaterialSubCategoryID");

                entity.Property(e => e.Notes).HasMaxLength(200);

                entity.Property(e => e.OtherProcessGroupName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PendingQtySku).HasColumnName("PendingQty_SKU");

                entity.Property(e => e.ProcessGroupId).HasColumnName("ProcessGroupID");

                entity.Property(e => e.ReceivedQtySku).HasColumnName("ReceivedQty_SKU");

                entity.Property(e => e.ReceivedTotalDefaultCurrency).HasColumnName("ReceivedTotal_DefaultCurrency");

                entity.Property(e => e.RejectedQtySku).HasColumnName("RejectedQty_SKU");

                entity.Property(e => e.RejectionNotes).HasMaxLength(200);

                entity.Property(e => e.SupplierId).HasColumnName("SupplierID");

                entity.Property(e => e.UpdatedDt)
                    .HasColumnName("UpdatedDT")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.UpdatedUserId).HasColumnName("UpdatedUserID");

                entity.Property(e => e.WorkOrderId)
                    .HasColumnName("WorkOrderID")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<MtlReceiveM>(entity =>
            {
                entity.HasKey(e => e.MaterialReceiveId);

                entity.ToTable("MTL_Receive_M");

                entity.Property(e => e.MaterialReceiveId).HasColumnName("MaterialReceiveID");

                entity.Property(e => e.CreatedDt)
                    .HasColumnName("CreatedDT")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.CreatedUserId).HasColumnName("CreatedUserID");

                entity.Property(e => e.DeliveryChallanNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DeliveryDt)
                    .HasColumnName("DeliveryDT")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.ExciseTaxId).HasColumnName("ExciseTaxID");

                entity.Property(e => e.GrandTotalDefaultCurrency).HasColumnName("GrandTotal_DefaultCurrency");

                entity.Property(e => e.InvoiceDt)
                    .HasColumnName("InvoiceDT")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.InvoiceNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastPaymentSendDt)
                    .HasColumnName("LastPaymentSendDT")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.MaterialPoid).HasColumnName("MaterialPOID");

                entity.Property(e => e.OtherChargesaName)
                    .IsRequired()
                    .HasColumnType("nchar(50)");

                entity.Property(e => e.ReceivedDt)
                    .HasColumnName("ReceivedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Remarks)
                    .IsRequired()
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.SaleTaxId).HasColumnName("SaleTaxID");

                entity.Property(e => e.TotalPaidAmtDefaultCurrency).HasColumnName("TotalPaidAmt_DefaultCurrency");

                entity.Property(e => e.UpdatedDt)
                    .HasColumnName("UpdatedDT")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.UpdatedUserId).HasColumnName("UpdatedUserID");

                entity.Property(e => e.VoucherId)
                    .HasColumnName("VoucherID")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<MtlReceiveTaxD>(entity =>
            {
                entity.HasKey(e => e.MaterialRecTaxId);

                entity.ToTable("MTL_Receive_Tax_D");

                entity.Property(e => e.MaterialRecTaxId).HasColumnName("MaterialRecTaxID");

                entity.Property(e => e.CreatedDt)
                    .HasColumnName("CreatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedId).HasColumnName("CreatedID");

                entity.Property(e => e.MaterialReceiveId).HasColumnName("MaterialReceiveID");

                entity.Property(e => e.TaxId).HasColumnName("TaxID");

                entity.Property(e => e.UpdatedDt)
                    .HasColumnName("UpdatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdatedId).HasColumnName("UpdatedID");
            });

            modelBuilder.Entity<MtlReconcileM>(entity =>
            {
                entity.HasKey(e => e.MaterialTransactionDetId);

                entity.ToTable("MTL_Reconcile_M");

                entity.Property(e => e.MaterialTransactionDetId).HasColumnName("MaterialTransactionDetID");

                entity.Property(e => e.AddedQty).HasDefaultValueSql("((0))");

                entity.Property(e => e.BalanceQty).HasDefaultValueSql("((0))");

                entity.Property(e => e.BatchNo)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.BatchNoMaterialTransactionId).HasColumnName("BatchNo_MaterialTransactionID");

                entity.Property(e => e.BatchNoQty)
                    .HasColumnName("BatchNo_Qty")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.BrandId).HasColumnName("BrandID");

                entity.Property(e => e.CompletedTillProcessId).HasColumnName("CompletedTillProcessID");

                entity.Property(e => e.CreatedDt)
                    .HasColumnName("CreatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedUserId)
                    .HasColumnName("CreatedUserID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.MaterialId).HasColumnName("MaterialID");

                entity.Property(e => e.Reason)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.SubtractQty).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<MtlReturnM>(entity =>
            {
                entity.HasKey(e => e.MaterialReturnId);

                entity.ToTable("MTL_Return_M");

                entity.Property(e => e.MaterialReturnId).HasColumnName("MaterialReturnID");

                entity.Property(e => e.BatchNo)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.BatchNoMaterialTransactionId).HasColumnName("BatchNo_MaterialTransactionID");

                entity.Property(e => e.BatchNoQty)
                    .HasColumnName("BatchNo_Qty")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.BrandId).HasColumnName("BrandID");

                entity.Property(e => e.CreatedDt)
                    .HasColumnName("CreatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedUserId).HasColumnName("CreatedUserID");

                entity.Property(e => e.MaterialId).HasColumnName("MaterialID");

                entity.Property(e => e.MaterialReturnMId)
                    .HasColumnName("MaterialReturn_M_ID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.MaterialSubCategoryId).HasColumnName("MaterialSubCategoryID");

                entity.Property(e => e.MaterialTypeId).HasColumnName("MaterialTypeID");

                entity.Property(e => e.Notes)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ProcessGroupId)
                    .HasColumnName("ProcessGroupID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ProcessStepId)
                    .HasColumnName("ProcessStepID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ReturneeId).HasColumnName("ReturneeID");

                entity.Property(e => e.UpdatedDt)
                    .HasColumnName("UpdatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdatedUserId)
                    .HasColumnName("UpdatedUserID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.WorkOrderId).HasColumnName("WorkOrderID");
            });

            modelBuilder.Entity<MtlScrapLogD>(entity =>
            {
                entity.HasKey(e => e.MaterialScrapId);

                entity.ToTable("MTL_ScrapLog_D");

                entity.Property(e => e.MaterialScrapId).HasColumnName("MaterialScrapID");

                entity.Property(e => e.BatchNo)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.BatchNoMaterialTransactionId).HasColumnName("BatchNo_MaterialTransactionID");

                entity.Property(e => e.BrandId).HasColumnName("BrandID");

                entity.Property(e => e.ClosingQty).HasDefaultValueSql("((0))");

                entity.Property(e => e.CompletedTillProcessId)
                    .HasColumnName("CompletedTillProcessID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CreatedDt)
                    .HasColumnName("CreatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedUserId).HasColumnName("CreatedUserID");

                entity.Property(e => e.MaterialId).HasColumnName("MaterialID");

                entity.Property(e => e.Notes)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.OpeningQty).HasDefaultValueSql("((0))");

                entity.Property(e => e.TransactionType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TransactionTypeId)
                    .HasColumnName("TransactionTypeID")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<MtlSetD>(entity =>
            {
                entity.HasKey(e => e.SetDetailId);

                entity.ToTable("MTL_Set_D");

                entity.Property(e => e.SetDetailId).HasColumnName("SetDetailID");

                entity.Property(e => e.CreatedDt)
                    .HasColumnName("CreatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedUserId)
                    .HasColumnName("CreatedUserID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.MaterialId)
                    .HasColumnName("MaterialID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.RecommandedQty).HasDefaultValueSql("((0))");

                entity.Property(e => e.SetId)
                    .HasColumnName("SetID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.UpdatedDt)
                    .HasColumnName("UpdatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdatedUserId)
                    .HasColumnName("UpdatedUserID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.VariantOrder)
                    .HasColumnName("Variant_Order")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<MtlSetM>(entity =>
            {
                entity.HasKey(e => e.SetId);

                entity.ToTable("MTL_Set_M");

                entity.Property(e => e.SetId).HasColumnName("SetID");

                entity.Property(e => e.CreatedDt)
                    .HasColumnName("CreatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedUserId)
                    .HasColumnName("CreatedUserID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.FamilyId)
                    .HasColumnName("FamilyID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.SetCode)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.SetName)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedDt)
                    .HasColumnName("UpdatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdatedUserId)
                    .HasColumnName("UpdatedUserID")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<MtlSubCategoryFieldGroupsM>(entity =>
            {
                entity.HasKey(e => e.MaterialSubCategoryFieldGroupId);

                entity.ToTable("MTL_SubCategoryFieldGroups_M");

                entity.Property(e => e.MaterialSubCategoryFieldGroupId).HasColumnName("MaterialSubCategoryFieldGroupID");

                entity.Property(e => e.CreatedDt)
                    .HasColumnName("CreatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedUserId).HasColumnName("CreatedUserID");

                entity.Property(e => e.MaterialFieldGroupId).HasColumnName("MaterialFieldGroupID");

                entity.Property(e => e.MaterialFieldGroupOrder).HasDefaultValueSql("((0))");

                entity.Property(e => e.MaterialSubCategoryId).HasColumnName("MaterialSubCategoryID");

                entity.Property(e => e.UpdatedDt)
                    .HasColumnName("UpdatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdatedUserId).HasColumnName("UpdatedUserID");
            });

            modelBuilder.Entity<MtlSubCategoryFieldsM>(entity =>
            {
                entity.HasKey(e => e.MaterialSubCategoryFieldId);

                entity.ToTable("MTL_SubCategoryFields_M");

                entity.Property(e => e.MaterialSubCategoryFieldId).HasColumnName("MaterialSubCategoryFieldID");

                entity.Property(e => e.CreatedDt)
                    .HasColumnName("CreatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedUserId).HasColumnName("CreatedUserID");

                entity.Property(e => e.DefaultValue)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.FieldDisplayCell)
                    .HasColumnName("FieldDisplay_Cell")
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.FieldOrder).HasDefaultValueSql("((0))");

                entity.Property(e => e.FieldValueCell)
                    .HasColumnName("FieldValue_Cell")
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.IsEnterObservedValue).HasColumnName("IsEnter_ObservedValue");

                entity.Property(e => e.MaterialFieldId).HasColumnName("MaterialFieldID");

                entity.Property(e => e.MaterialSubCategoryFieldGroupId).HasColumnName("MaterialSubCategoryFieldGroupID");

                entity.Property(e => e.ShowInTraveler).HasColumnName("ShowIn_Traveler");

                entity.Property(e => e.ShowToCustomer).HasColumnName("ShowTo_Customer");

                entity.Property(e => e.ShowToSupplier).HasColumnName("ShowTo_Supplier");

                entity.Property(e => e.UpdatedDt)
                    .HasColumnName("UpdatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdatedUserId).HasColumnName("UpdatedUserID");
            });

            modelBuilder.Entity<MtlSubcategoryM>(entity =>
            {
                entity.HasKey(e => e.MaterialSubCategoryId);

                entity.ToTable("MTL_Subcategory_M");

                entity.Property(e => e.MaterialSubCategoryId).HasColumnName("MaterialSubCategoryID");

                entity.Property(e => e.AllowExciseCredit).HasColumnName("Allow_ExciseCredit");

                entity.Property(e => e.AllowSalesTaxCredit).HasColumnName("Allow_SalesTaxCredit");

                entity.Property(e => e.AllowSupplierToQuote).HasColumnName("Allow_Supplier_To_Quote");

                entity.Property(e => e.ApplyFixedChg).HasColumnName("Apply_FixedChg");

                entity.Property(e => e.AskForProductionspeed).HasColumnName("Ask_for_Productionspeed");

                entity.Property(e => e.CfSkunitIdToReportingUnitIdDenominator).HasColumnName("CF_SKUnitID_To_ReportingUnitID_Denominator");

                entity.Property(e => e.CfSkunitIdToReportingUnitIdNumerator).HasColumnName("CF_SKUnitID_To_ReportingUnitID_Numerator");

                entity.Property(e => e.Charge1Name)
                    .HasColumnName("Charge1_Name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Charge2Name)
                    .HasColumnName("Charge2_Name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Charge3Name)
                    .HasColumnName("Charge3_Name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Charge4Name)
                    .HasColumnName("Charge4_Name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ConversionFactorFromMainUnitToParentUnitOld).HasColumnName("ConversionFactor_FromMainUnitToParentUnit_Old");

                entity.Property(e => e.ConversionFactorRuvalueOld).HasColumnName("ConversionFactor_RUValue_Old");

                entity.Property(e => e.ConversionFactorSmuvalueOld).HasColumnName("ConversionFactor_SMUValue_Old");

                entity.Property(e => e.CreatedDt)
                    .HasColumnName("CreatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedUserId).HasColumnName("CreatedUserID");

                entity.Property(e => e.Criticality).HasDefaultValueSql("((0))");

                entity.Property(e => e.CurrencyId).HasColumnName("CurrencyID");

                entity.Property(e => e.DefaultDeliveryPeriod).HasColumnName("Default_Delivery_Period");

                entity.Property(e => e.DeliveryCriteriya).HasDefaultValueSql("((0))");

                entity.Property(e => e.ExcessIssueAllowancePercentage).HasColumnName("Excess_IssueAllowance_Percentage");

                entity.Property(e => e.ExciseClassificationId)
                    .HasColumnName("ExciseClassificationID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ExciseCreditPercentage)
                    .HasColumnName("ExciseCredit_Percentage")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ExpectFixedChg).HasColumnName("Expect_FixedChg");

                entity.Property(e => e.HighPriorityProductionDays).HasColumnName("HighPriority_ProductionDays");

                entity.Property(e => e.HighestPriorityProductionDays).HasColumnName("HighestPriority_ProductionDays");

                entity.Property(e => e.InspectionPolicy)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.InspectionStylePurchase).HasColumnName("InspectionStyle_Purchase");

                entity.Property(e => e.InspectionStyleStore).HasColumnName("InspectionStyle_Store");

                entity.Property(e => e.IsAllowDirectPurchaseWithoutPo).HasColumnName("IsAllowDirectPurchaseWithoutPO");

                entity.Property(e => e.IsAllowExcessIssueMoreThanJobRequirement).HasColumnName("IsAllowExcessIssue_MoreThanJobRequirement");

                entity.Property(e => e.IsAllowIssueFromSingleBatchOnly).HasColumnName("IsAllowIssue_From_SingleBatchOnly");

                entity.Property(e => e.IsAllowQuoteRequest).HasColumnName("IsAllow_QuoteRequest");

                entity.Property(e => e.IsAllowReceiptWithoutInspectionOld).HasColumnName("IsAllowReceiptWithoutInspection_Old");

                entity.Property(e => e.IsAllowTransferToDifferentJobAtWiplevel).HasColumnName("IsAllowTransfer_ToDifferentJob_AtWIPLevel");

                entity.Property(e => e.IsAskPolicyLevelchangeStore).HasColumnName("IsAskPolicyLevelchange_Store");

                entity.Property(e => e.IsCompletedBrands).HasColumnName("IsCompleted_Brands");

                entity.Property(e => e.IsCompletedByProduct).HasColumnName("IsCompleted_ByProduct");

                entity.Property(e => e.IsCompletedCharacteristics).HasColumnName("IsCompleted_Characteristics");

                entity.Property(e => e.IsCompletedCharges).HasColumnName("IsCompleted_Charges");

                entity.Property(e => e.IsCompletedFiles).HasColumnName("IsCompleted_Files");

                entity.Property(e => e.IsCompletedFlow).HasColumnName("IsCompleted_Flow");

                entity.Property(e => e.IsCompletedProcesses).HasColumnName("IsCompleted_Processes");

                entity.Property(e => e.IsCompletedProdn).HasColumnName("IsCompleted_Prodn");

                entity.Property(e => e.IsCompletedRawMtl).HasColumnName("IsCompleted_RawMtl");

                entity.Property(e => e.IsCompletedSales).HasColumnName("IsCompleted_Sales");

                entity.Property(e => e.IsCompletedStore).HasColumnName("IsCompleted_Store");

                entity.Property(e => e.IsCompletedSubAssembly).HasColumnName("IsCompleted_SubAssembly");

                entity.Property(e => e.IsCompletedUnit).HasColumnName("IsCompleted_Unit");

                entity.Property(e => e.IsCompletedUsage).HasColumnName("IsCompleted_Usage");

                entity.Property(e => e.IsConsumedInGeneral).HasColumnName("IsConsumed_In_General");

                entity.Property(e => e.IsConsumedInProduction).HasColumnName("IsConsumed_In_Production");

                entity.Property(e => e.IsDetailsOrderTracking).HasColumnName("IsDetails_OrderTracking");

                entity.Property(e => e.IsFixedUnitConversionWithParentUnitOld).HasColumnName("IsFixed_UnitConversionWithParentUnit_Old");

                entity.Property(e => e.IsGeneratedAsScrap).HasColumnName("IsGenerated_As_Scrap");

                entity.Property(e => e.IsManufacturedInHouse).HasColumnName("IsManufactured_InHouse");

                entity.Property(e => e.IsOrderAcceptanceUnitSameAsSku).HasColumnName("IsOrderAcceptanceUnit_SameAs_SKU");

                entity.Property(e => e.IsPartSensitiveCriticality).HasColumnName("IsPartSensitive_Criticality");

                entity.Property(e => e.IsProductionQtyUnitSameAsSku).HasColumnName("IsProductionQtyUnit_SameAs_SKU");

                entity.Property(e => e.IsPurchaseFromOutsideSuppliers).HasColumnName("IsPurchase_From_OutsideSuppliers");

                entity.Property(e => e.IsPurchaseReceiptUnitSameAsSku).HasColumnName("IsPurchaseReceiptUnit_SameAs_SKU");

                entity.Property(e => e.IsReceivedFromProductionAsByproduct).HasColumnName("IsReceived_From_Production_As_Byproduct");

                entity.Property(e => e.IsReqProductionSeriesParts).HasColumnName("IsReqProductionSeries_Parts");

                entity.Property(e => e.IsRequireByproducts).HasColumnName("IsRequire_Byproducts");

                entity.Property(e => e.IsRequireFiles).HasColumnName("IsRequire_Files");

                entity.Property(e => e.IsRequireLockPart).HasColumnName("IsRequire_LockPart");

                entity.Property(e => e.IsRequireRawmaterials).HasColumnName("IsRequire_Rawmaterials");

                entity.Property(e => e.IsRequireSubassemblies).HasColumnName("IsRequire_Subassemblies");

                entity.Property(e => e.IsRusameAsSku).HasColumnName("IsRUSameAsSKU");

                entity.Property(e => e.IsSalesDeliveryUnitSameAsSku).HasColumnName("IsSalesDeliveryUnit_SameAs_SKU");

                entity.Property(e => e.IsSoldAsCustomProduct).HasColumnName("IsSold_As_CustomProduct");

                entity.Property(e => e.IsSoldAsSideScrapItem).HasColumnName("IsSold_As_Side_Scrap_Item");

                entity.Property(e => e.IsSoldAsSpareAccessoryItem).HasColumnName("IsSold_As_Spare_Accessory_Item");

                entity.Property(e => e.IsSoldAsStdProduct).HasColumnName("IsSold_As_StdProduct");

                entity.Property(e => e.IssueUnitId).HasColumnName("IssueUnitID");

                entity.Property(e => e.LedgerId).HasColumnName("LedgerID");

                entity.Property(e => e.LocationId).HasColumnName("LocationID");

                entity.Property(e => e.LowPriorityProductionDays).HasColumnName("LowPriority_ProductionDays");

                entity.Property(e => e.LowestPriorityProductionDays).HasColumnName("LowestPriority_ProductionDays");

                entity.Property(e => e.MainUnitCategoryId).HasColumnName("Main_UnitCategoryID");

                entity.Property(e => e.MainUnitIdUnitConversionOld).HasColumnName("MainUnitID_UnitConversion_Old");

                entity.Property(e => e.MaterialCategoryId)
                    .HasColumnName("MaterialCategoryID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.MaterialSubCategory)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MaterialSubCategoryCode)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.MaterialSubCategoryShortName)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.MaxRate).HasDefaultValueSql("((0))");

                entity.Property(e => e.MaximumRejectionAllowPercentage).HasColumnName("MaximumRejectionAllow_Percentage");

                entity.Property(e => e.MinRate).HasDefaultValueSql("((0))");

                entity.Property(e => e.NormalPriorityProductionDays).HasColumnName("NormalPriority_ProductionDays");

                entity.Property(e => e.ParentUnitIdUnitConversionOld).HasColumnName("ParentUnitID_UnitConversion_Old");

                entity.Property(e => e.PartTypeId)
                    .HasColumnName("PartTypeID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.PrecisionDigitsOld).HasColumnName("PrecisionDigits_Old");

                entity.Property(e => e.RejectionMarginProduction).HasColumnName("RejectionMargin_Production");

                entity.Property(e => e.RejectionOutPutMaterialId)
                    .HasColumnName("RejectionOutPutMaterialID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.RejectionOutPutMode).HasDefaultValueSql("((1))");

                entity.Property(e => e.RuUnitCategoryId).HasColumnName("RU_UnitCategoryID");

                entity.Property(e => e.RuUnitId).HasColumnName("RU_UnitID");

                entity.Property(e => e.SalesClassificationId)
                    .HasColumnName("SalesClassificationID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.SalesCreditPercentage)
                    .HasColumnName("SalesCredit_Percentage")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.SalesLedgerId).HasColumnName("SalesLedgerID");

                entity.Property(e => e.ServiceClassificationId)
                    .HasColumnName("ServiceClassificationID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ShowDisplayPartName).HasColumnName("Show_DisplayPartName");

                entity.Property(e => e.ShowMaterialCode).HasColumnName("Show_MaterialCode");

                entity.Property(e => e.ShowOtherReferenceNo1).HasColumnName("Show_OtherReferenceNo1");

                entity.Property(e => e.ShowOtherReferenceNo2).HasColumnName("Show_OtherReferenceNo2");

                entity.Property(e => e.ShowPartName).HasColumnName("Show_PartName");

                entity.Property(e => e.ShowProcesswiseDefaultInventoryRate)
                    .HasColumnName("Show_Processwise_DefaultInventoryRate")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.TargetLowProductionQtyPerDay)
                    .HasColumnName("Target_LowProductionQty_Per_Day")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TargetOutputQty).HasDefaultValueSql("((0))");

                entity.Property(e => e.TargetOutputQtyPerDay)
                    .HasColumnName("TargetOutputQty_Per_Day")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TargetOutputUnit)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TargetRejectionQtyPerDay)
                    .HasColumnName("Target_RejectionQty_Per_Day")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TravelerCardFileName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.UnitConversionEntryLevelOld).HasColumnName("UnitConversionEntryLevel_Old");

                entity.Property(e => e.UpdatedDt)
                    .HasColumnName("UpdatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdatedUserId).HasColumnName("UpdatedUserID");
            });

            modelBuilder.Entity<MtlSubCategoryStatusOption>(entity =>
            {
                entity.HasKey(e => e.StatusOptionId);

                entity.ToTable("MTL_SubCategory_Status_Option");

                entity.Property(e => e.StatusOptionId).HasColumnName("StatusOptionID");

                entity.Property(e => e.CreatedDt)
                    .HasColumnName("CreatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedUserId).HasColumnName("CreatedUserID");

                entity.Property(e => e.StatusName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StatusOrder).HasColumnName("Status_Order");

                entity.Property(e => e.SubCategoryId).HasColumnName("SubCategoryID");

                entity.Property(e => e.UpdatedDt)
                    .HasColumnName("UpdatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdatedUserId).HasColumnName("UpdatedUserID");
            });

            modelBuilder.Entity<MtlSupplierShippingLogD>(entity =>
            {
                entity.HasKey(e => e.SupplierShippingLogId);

                entity.ToTable("MTL_SupplierShippingLog_D");

                entity.Property(e => e.SupplierShippingLogId).HasColumnName("SupplierShippingLogID");

                entity.Property(e => e.AcceptedQtyInSaleUnit).HasColumnName("AcceptedQty_In_SaleUnit");

                entity.Property(e => e.AcceptedQtyInSkunit).HasColumnName("AcceptedQty_In_SKUnit");

                entity.Property(e => e.BatchNo)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDt)
                    .HasColumnName("CreatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedUserId).HasColumnName("CreatedUserID");

                entity.Property(e => e.CustomerCompanyId).HasColumnName("CustomerCompanyID");

                entity.Property(e => e.DeliveryRecordDt)
                    .HasColumnName("DeliveryRecordDT")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DeliveryRecordNo)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.MaterialId).HasColumnName("MaterialID");

                entity.Property(e => e.MaterialPodetailId).HasColumnName("MaterialPODetailID");

                entity.Property(e => e.RecievedQtyInSaleUnit).HasColumnName("RecievedQty_In_SaleUnit");

                entity.Property(e => e.RecievedQtyInSkunit).HasColumnName("RecievedQty_In_SKUnit");

                entity.Property(e => e.RejectedQtyInSaleUnit).HasColumnName("RejectedQty_In_SaleUnit");

                entity.Property(e => e.RejectedQtyInSkunit).HasColumnName("RejectedQty_In_SKUnit");

                entity.Property(e => e.ShippedQtyInSaleUnit).HasColumnName("ShippedQty_In_SaleUnit");

                entity.Property(e => e.ShippedQtyInSkunit).HasColumnName("ShippedQty_In_SKUnit");

                entity.Property(e => e.TrackingNo)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedDt)
                    .HasColumnName("UpdatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdatedUserId).HasColumnName("UpdatedUserID");
            });

            modelBuilder.Entity<MtlTransactionInspectionD>(entity =>
            {
                entity.HasKey(e => e.TransactionInspectionDetailId);

                entity.ToTable("MTL_Transaction_Inspection_D");

                entity.Property(e => e.TransactionInspectionDetailId).HasColumnName("TransactionInspectionDetailID");

                entity.Property(e => e.CreatedDt)
                    .HasColumnName("CreatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedUserId).HasColumnName("CreatedUserID");

                entity.Property(e => e.FieldId).HasColumnName("FieldID");

                entity.Property(e => e.FieldValue1)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FieldValue2)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IdealTransactionInspectionDetailId)
                    .HasColumnName("Ideal_TransactionInspectionDetailID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TransactionInspectionId).HasColumnName("TransactionInspectionID");

                entity.Property(e => e.UpdatedDt)
                    .HasColumnName("UpdatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdatedUserId).HasColumnName("UpdatedUserID");
            });

            modelBuilder.Entity<MtlTransactionInspectionIdealD>(entity =>
            {
                entity.HasKey(e => e.IdealTransactionInspectionDetailId);

                entity.ToTable("MTL_Transaction_Inspection_Ideal_D");

                entity.Property(e => e.IdealTransactionInspectionDetailId).HasColumnName("Ideal_TransactionInspectionDetailID");

                entity.Property(e => e.CreatedDt)
                    .HasColumnName("CreatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedUserId).HasColumnName("CreatedUserID");

                entity.Property(e => e.DeviationScopeFromValue).HasColumnName("DeviationScope_FromValue");

                entity.Property(e => e.DeviationScopeToValue).HasColumnName("DeviationScope_ToValue");

                entity.Property(e => e.FieldId).HasColumnName("FieldID");

                entity.Property(e => e.FieldValue1)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FieldValue2)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IdealTransactionInspectionId).HasColumnName("Ideal_TransactionInspectionID");

                entity.Property(e => e.ObservedValueType)
                    .HasColumnName("ObservedValue_Type")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.UpdatedDt)
                    .HasColumnName("UpdatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdatedUserId).HasColumnName("UpdatedUserID");
            });

            modelBuilder.Entity<MtlTransactionInspectionIdealM>(entity =>
            {
                entity.HasKey(e => e.IdealTransactionInspectionId);

                entity.ToTable("MTL_Transaction_Inspection_Ideal_M");

                entity.Property(e => e.IdealTransactionInspectionId).HasColumnName("Ideal_TransactionInspectionID");

                entity.Property(e => e.CreatedDt)
                    .HasColumnName("CreatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedUserId).HasColumnName("CreatedUserID");

                entity.Property(e => e.MaterialId).HasColumnName("MaterialID");

                entity.Property(e => e.MaterialTransactionId).HasColumnName("MaterialTransactionID");

                entity.Property(e => e.UpdatedDt)
                    .HasColumnName("UpdatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdatedUserId).HasColumnName("UpdatedUserID");
            });

            modelBuilder.Entity<MtlTransactionInspectionM>(entity =>
            {
                entity.HasKey(e => e.TransactionInspectionId);

                entity.ToTable("MTL_Transaction_Inspection_M");

                entity.Property(e => e.TransactionInspectionId).HasColumnName("TransactionInspectionID");

                entity.Property(e => e.CreatedDt)
                    .HasColumnName("CreatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedUserId).HasColumnName("CreatedUserID");

                entity.Property(e => e.IdealTransactionInspectionId)
                    .HasColumnName("Ideal_TransactionInspectionID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.InspectedByEmpId)
                    .HasColumnName("InspectedBy_EmpID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.MaterialId).HasColumnName("MaterialID");

                entity.Property(e => e.MaterialTransactionId).HasColumnName("MaterialTransactionID");

                entity.Property(e => e.Mode).HasDefaultValueSql("((1))");

                entity.Property(e => e.Notes)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.SampleQtyInSkunit).HasColumnName("SampleQty_In_SKUnit");

                entity.Property(e => e.SampleQtySkunitId).HasColumnName("SampleQty_SKUnitID");

                entity.Property(e => e.SerialNum)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedDt)
                    .HasColumnName("UpdatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdatedUserId).HasColumnName("UpdatedUserID");
            });

            modelBuilder.Entity<MtlTransactionL>(entity =>
            {
                entity.HasKey(e => e.TransactionLid);

                entity.ToTable("MTL_Transaction_L");

                entity.Property(e => e.TransactionLid).HasColumnName("TransactionLID");

                entity.Property(e => e.BatchNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.BrandId).HasColumnName("BrandID");

                entity.Property(e => e.CompanyId)
                    .HasColumnName("CompanyID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CompletedTillProcessId)
                    .HasColumnName("CompletedTillProcessID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CustomerId).HasColumnName("CustomerID");

                entity.Property(e => e.Date).HasColumnType("smalldatetime");

                entity.Property(e => e.ExpiryDate).HasColumnType("smalldatetime");

                entity.Property(e => e.IsStore).HasDefaultValueSql("((1))");

                entity.Property(e => e.LocationId)
                    .HasColumnName("LocationID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.MaterialId).HasColumnName("MaterialID");

                entity.Property(e => e.MaterialReceiveId).HasColumnName("MaterialReceiveID");

                entity.Property(e => e.MaterialTransactionId).HasColumnName("MaterialTransactionID");

                entity.Property(e => e.PoitemId)
                    .HasColumnName("POItemID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ScrapQtySold).HasColumnName("ScrapQty(Sold)");

                entity.Property(e => e.TransactionType)
                    .IsRequired()
                    .HasColumnType("char(1)");

                entity.Property(e => e.WorkOrderId)
                    .HasColumnName("WorkOrderID")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<MtlTransactionLogD>(entity =>
            {
                entity.HasKey(e => e.TransactionLogDid);

                entity.ToTable("MTL_TransactionLog_D");

                entity.Property(e => e.TransactionLogDid).HasColumnName("TransactionLogDID");

                entity.Property(e => e.BatchNo)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BatchNoId).HasColumnName("BatchNo_ID");

                entity.Property(e => e.BrandId).HasColumnName("BrandID");

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.Date)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");

                entity.Property(e => e.MaterialCategoryId).HasColumnName("MaterialCategoryID");

                entity.Property(e => e.MaterialId).HasColumnName("MaterialID");

                entity.Property(e => e.MaterialSubCategoryId).HasColumnName("MaterialSubCategoryID");

                entity.Property(e => e.ProductId)
                    .HasColumnName("ProductID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Rate).HasDefaultValueSql("((0))");

                entity.Property(e => e.TransactionLogId).HasColumnName("TransactionLogID");

                entity.Property(e => e.TransactionType)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.TransactionTypeDetailId).HasColumnName("TransactionTypeDetailID");

                entity.Property(e => e.TransactionTypeId).HasColumnName("TransactionTypeID");
            });

            modelBuilder.Entity<MtlTransactionLogL1>(entity =>
            {
                entity.HasKey(e => e.TransactionLogL1id);

                entity.ToTable("MTL_TransactionLog_L1");

                entity.Property(e => e.TransactionLogL1id).HasColumnName("TransactionLogL1ID");

                entity.Property(e => e.CompletedTillProcessId)
                    .HasColumnName("CompletedTillProcessID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Date)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");

                entity.Property(e => e.LocationId)
                    .HasColumnName("LocationID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.MaterialCategoryId).HasColumnName("MaterialCategoryID");

                entity.Property(e => e.MaterialId).HasColumnName("MaterialID");

                entity.Property(e => e.MaterialSubCategoryId).HasColumnName("MaterialSubCategoryID");

                entity.Property(e => e.ProductId)
                    .HasColumnName("ProductID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TransactionType)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TransactionTypeId).HasColumnName("TransactionTypeID");
            });

            modelBuilder.Entity<MtlTransactionLogL2>(entity =>
            {
                entity.HasKey(e => e.TransactionLogL2id);

                entity.ToTable("MTL_TransactionLog_L2");

                entity.Property(e => e.TransactionLogL2id).HasColumnName("TransactionLogL2ID");

                entity.Property(e => e.BatchNo)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.BatchNoId).HasColumnName("BatchNo_ID");

                entity.Property(e => e.BrandId).HasColumnName("BrandID");

                entity.Property(e => e.CompanyId)
                    .HasColumnName("CompanyID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Date)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.EmployeeId)
                    .HasColumnName("EmployeeID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.LocationId)
                    .HasColumnName("LocationID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.MaterialCategoryId).HasColumnName("MaterialCategoryID");

                entity.Property(e => e.MaterialId).HasColumnName("MaterialID");

                entity.Property(e => e.MaterialSubCategoryId).HasColumnName("MaterialSubCategoryID");

                entity.Property(e => e.ProductId)
                    .HasColumnName("ProductID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Rate).HasDefaultValueSql("((0))");

                entity.Property(e => e.TransactionLid).HasColumnName("TransactionLID");

                entity.Property(e => e.TransactionLogL1id).HasColumnName("TransactionLogL1ID");

                entity.Property(e => e.TransactionType)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TransactionTypeDetailId).HasColumnName("TransactionTypeDetailID");

                entity.Property(e => e.TransactionTypeId).HasColumnName("TransactionTypeID");
            });

            modelBuilder.Entity<MtlTransactionLogM>(entity =>
            {
                entity.HasKey(e => e.TransactionLogId);

                entity.ToTable("MTL_TransactionLog_M");

                entity.Property(e => e.TransactionLogId).HasColumnName("TransactionLogID");

                entity.Property(e => e.CompletedTillProcessId)
                    .HasColumnName("CompletedTillProcessID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Date)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");

                entity.Property(e => e.MaterialCategoryId).HasColumnName("MaterialCategoryID");

                entity.Property(e => e.MaterialId).HasColumnName("MaterialID");

                entity.Property(e => e.MaterialSubCategoryId).HasColumnName("MaterialSubCategoryID");

                entity.Property(e => e.ProductId)
                    .HasColumnName("ProductID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TransactionType)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TransactionTypeId).HasColumnName("TransactionTypeID");
            });

            modelBuilder.Entity<MtlTransactionM>(entity =>
            {
                entity.HasKey(e => e.MaterialTransactionId);

                entity.ToTable("MTL_Transaction_M");

                entity.Property(e => e.MaterialTransactionId).HasColumnName("MaterialTransactionID");

                entity.Property(e => e.BatchNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.BrandId).HasColumnName("BrandID");

                entity.Property(e => e.CompanyId)
                    .HasColumnName("CompanyID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CompletedTillProcessId)
                    .HasColumnName("CompletedTillProcessID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CustomerId).HasColumnName("CustomerID");

                entity.Property(e => e.Date).HasColumnType("smalldatetime");

                entity.Property(e => e.ExpiryDate).HasColumnType("smalldatetime");

                entity.Property(e => e.IsStore).HasDefaultValueSql("((1))");

                entity.Property(e => e.MaterialId).HasColumnName("MaterialID");

                entity.Property(e => e.MaterialReceiveId).HasColumnName("MaterialReceiveID");

                entity.Property(e => e.PoitemId)
                    .HasColumnName("POItemID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ScrapQtySold).HasColumnName("ScrapQty(Sold)");

                entity.Property(e => e.TransactionType)
                    .IsRequired()
                    .HasColumnType("char(1)");

                entity.Property(e => e.WorkOrderId)
                    .HasColumnName("WorkOrderID")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<MtlTransactionRateChanges>(entity =>
            {
                entity.HasKey(e => e.TransactionRateChangeId);

                entity.ToTable("MTL_TransactionRateChanges");

                entity.Property(e => e.TransactionRateChangeId).HasColumnName("TransactionRateChangeID");

                entity.Property(e => e.CreatedDt)
                    .HasColumnName("CreatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedUserId).HasColumnName("CreatedUserID");

                entity.Property(e => e.MaterialTransactionId).HasColumnName("MaterialTransactionID");

                entity.Property(e => e.Reason)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<MtlValueLog>(entity =>
            {
                entity.HasKey(e => e.MaterialValueLogId);

                entity.ToTable("MTL_ValueLog");

                entity.Property(e => e.MaterialValueLogId).HasColumnName("MaterialValueLogID");

                entity.Property(e => e.CurrentBalance).HasDefaultValueSql("((0))");

                entity.Property(e => e.EntryDateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Form)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.MaterialId).HasColumnName("MaterialID");

                entity.Property(e => e.TransactionType)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TransactionTypeId).HasColumnName("TransactionTypeID");
            });

            modelBuilder.Entity<OldAstPurchaseD>(entity =>
            {
                entity.HasKey(e => e.AssetPodetailId);

                entity.ToTable("Old_AST_Purchase_D");

                entity.Property(e => e.AssetPodetailId).HasColumnName("AssetPODetailID");

                entity.Property(e => e.AssetCategoryId).HasColumnName("AssetCategoryID");

                entity.Property(e => e.AssetPoid).HasColumnName("AssetPOID");

                entity.Property(e => e.BudgetPlanId).HasColumnName("BudgetPlanID");

                entity.Property(e => e.CreatedDt)
                    .HasColumnName("CreatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedUserId)
                    .HasColumnName("CreatedUserID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CurrencyId).HasColumnName("CurrencyID");

                entity.Property(e => e.MachineTypeId).HasColumnName("MachineTypeID");

                entity.Property(e => e.NeededBy).HasColumnType("smalldatetime");

                entity.Property(e => e.QuoteNum)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.SupplierId)
                    .HasColumnName("SupplierID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TotalAmt)
                    .HasColumnType("decimal(20, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TotalAmtDefaultCurrency).HasColumnName("TotalAmt_DefaultCurrency");

                entity.Property(e => e.UpdatedDt)
                    .HasColumnName("UpdatedDT")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.UpdatedUserId).HasColumnName("UpdatedUserID");
            });

            modelBuilder.Entity<OldAstPurchaseM>(entity =>
            {
                entity.HasKey(e => e.AssetPoid);

                entity.ToTable("Old_AST_Purchase_M");

                entity.Property(e => e.AssetPoid).HasColumnName("AssetPOID");

                entity.Property(e => e.AmdDate).HasColumnType("smalldatetime");

                entity.Property(e => e.AmdNo)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AssetPonum)
                    .HasColumnName("AssetPONum")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDt)
                    .HasColumnName("CreatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedUserId)
                    .HasColumnName("CreatedUserID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.DisappReason)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ExciseTaxId).HasColumnName("ExciseTaxID");

                entity.Property(e => e.GrandTotalDefaultCurrency).HasColumnName("GrandTotal_DefaultCurrency");

                entity.Property(e => e.ModeDispatchId).HasColumnName("ModeDispatchID");

                entity.Property(e => e.PaymentTerms)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.PoaSrNum).HasColumnName("POA_SrNum");

                entity.Property(e => e.Podate)
                    .HasColumnName("PODate")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.PotypeId).HasColumnName("POTypeID");

                entity.Property(e => e.Remarks)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.SaleTaxId).HasColumnName("SaleTaxID");

                entity.Property(e => e.UpdatedDt)
                    .HasColumnName("UpdatedDT")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.UpdatedUserId).HasColumnName("UpdatedUserID");
            });

            modelBuilder.Entity<OldAstPurchaseTaxD>(entity =>
            {
                entity.HasKey(e => e.PoTaxId);

                entity.ToTable("Old_AST_PurchaseTax_D");

                entity.Property(e => e.PoTaxId).HasColumnName("PoTaxID");

                entity.Property(e => e.AssetPoid).HasColumnName("AssetPOID");

                entity.Property(e => e.CreatedDt)
                    .HasColumnName("CreatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedId).HasColumnName("CreatedID");

                entity.Property(e => e.TaxId).HasColumnName("TaxID");

                entity.Property(e => e.UpdatedDt)
                    .HasColumnName("UpdatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdatedId).HasColumnName("UpdatedID");
            });

            modelBuilder.Entity<OldAstReceiveD>(entity =>
            {
                entity.HasKey(e => e.AssetReceiveDetailId);

                entity.ToTable("Old_AST_Receive_D");

                entity.Property(e => e.AssetReceiveDetailId).HasColumnName("AssetReceiveDetailID");

                entity.Property(e => e.AssetCategoryId).HasColumnName("AssetCategoryID");

                entity.Property(e => e.AssetPodetailId).HasColumnName("AssetPODetailID");

                entity.Property(e => e.AssetReceiveId).HasColumnName("AssetReceiveID");

                entity.Property(e => e.CreatedDt)
                    .HasColumnName("CreatedDT")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.CreatedUserId).HasColumnName("CreatedUserID");

                entity.Property(e => e.CurrencyId).HasColumnName("CurrencyID");

                entity.Property(e => e.MachineTypeId).HasColumnName("MachineTypeID");

                entity.Property(e => e.Notes).HasMaxLength(500);

                entity.Property(e => e.ReceivedTotalDefaultCurrency).HasColumnName("ReceivedTotal_DefaultCurrency");

                entity.Property(e => e.SupplierId).HasColumnName("SupplierID");

                entity.Property(e => e.UpdatedDt)
                    .HasColumnName("UpdatedDT")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.UpdatedUserId).HasColumnName("UpdatedUserID");
            });

            modelBuilder.Entity<OldAstReceiveM>(entity =>
            {
                entity.HasKey(e => e.AssetReceiveId);

                entity.ToTable("Old_AST_Receive_M");

                entity.Property(e => e.AssetReceiveId).HasColumnName("AssetReceiveID");

                entity.Property(e => e.AssetPoid).HasColumnName("AssetPOID");

                entity.Property(e => e.CreatedDt)
                    .HasColumnName("CreatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedUserId).HasColumnName("CreatedUserID");

                entity.Property(e => e.DeliveryChallanNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DeliveryDt)
                    .HasColumnName("DeliveryDT")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.ExciseTaxId).HasColumnName("ExciseTaxID");

                entity.Property(e => e.GrandTotalDefaultCurrency).HasColumnName("GrandTotal_DefaultCurrency");

                entity.Property(e => e.InvoiceDt)
                    .HasColumnName("InvoiceDT")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.InvoiceNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OtherChargesaName)
                    .IsRequired()
                    .HasColumnType("nchar(50)");

                entity.Property(e => e.ReceivedDt)
                    .HasColumnName("ReceivedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Remarks)
                    .IsRequired()
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.SaleTaxId).HasColumnName("SaleTaxID");

                entity.Property(e => e.UpdatedDt)
                    .HasColumnName("UpdatedDT")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.UpdatedUserId).HasColumnName("UpdatedUserID");
            });

            modelBuilder.Entity<OldAstTaxHistory>(entity =>
            {
                entity.HasKey(e => e.TaxHistoryId);

                entity.ToTable("Old_AST_TaxHistory");

                entity.Property(e => e.TaxHistoryId).HasColumnName("TaxHistoryID");

                entity.Property(e => e.Amount).HasDefaultValueSql("((0))");

                entity.Property(e => e.AssetPoid)
                    .HasColumnName("AssetPOID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CreatedDt)
                    .HasColumnName("CreatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedUserId).HasColumnName("CreatedUserID");

                entity.Property(e => e.TaxStructureId)
                    .HasColumnName("TaxStructureID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.UpdatedDt)
                    .HasColumnName("UpdatedDT")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.UpdatedUserId).HasColumnName("UpdatedUserID");
            });

            modelBuilder.Entity<OldAttendanceM>(entity =>
            {
                entity.HasKey(e => e.AttendanceId);

                entity.ToTable("Old_Attendance_M");

                entity.Property(e => e.AttendanceId).HasColumnName("AttendanceID");

                entity.Property(e => e.InDt)
                    .HasColumnName("InDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.OutDt)
                    .HasColumnName("OutDT")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.UserId).HasColumnName("UserID");
            });

            modelBuilder.Entity<OldAutoQuoteM>(entity =>
            {
                entity.HasKey(e => e.AutoQuoteId);

                entity.ToTable("Old_AutoQuote_M");

                entity.Property(e => e.AutoQuoteId).HasColumnName("AutoQuoteID");

                entity.Property(e => e.Comments)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDt)
                    .HasColumnName("CreatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedUserId).HasColumnName("CreatedUserID");

                entity.Property(e => e.CustomerId).HasColumnName("CustomerID");

                entity.Property(e => e.DeliveryDt)
                    .HasColumnName("DeliveryDT")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.PartName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PartNum)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Pcblength).HasColumnName("PCBLength");

                entity.Property(e => e.Pcbwidth).HasColumnName("PCBWidth");

                entity.Property(e => e.ProductTypeId).HasColumnName("ProductTypeID");

                entity.Property(e => e.UnitId).HasColumnName("UnitID");

                entity.Property(e => e.UpdatedDt)
                    .HasColumnName("UpdatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdatedUserId).HasColumnName("UpdatedUserID");

                entity.Property(e => e.ValidTillDt)
                    .HasColumnName("ValidTillDT")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.Version)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<OldHrmAchievementAlertsSent>(entity =>
            {
                entity.HasKey(e => e.AchievementAlertsSentId);

                entity.ToTable("Old_HRM_AchievementAlertsSent");

                entity.Property(e => e.AchievementAlertsSentId).HasColumnName("AchievementAlertsSentID");

                entity.Property(e => e.AchievementId).HasColumnName("AchievementID");

                entity.Property(e => e.CreatedDt)
                    .HasColumnName("CreatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedUserId).HasColumnName("CreatedUserID");

                entity.Property(e => e.EmailId).HasColumnName("EMailID");

                entity.Property(e => e.EmployeeId)
                    .HasColumnName("EmployeeID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.UpdatedDt)
                    .HasColumnName("UpdatedDT")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.UpdatedUserId).HasColumnName("UpdatedUserID");
            });

            modelBuilder.Entity<OldHrmAchievementEntryFieldsD>(entity =>
            {
                entity.HasKey(e => e.FieldDetlId);

                entity.ToTable("Old_HRM_AchievementEntryFields_D");

                entity.Property(e => e.FieldDetlId).HasColumnName("FieldDetlID");

                entity.Property(e => e.AchievementId).HasColumnName("AchievementID");

                entity.Property(e => e.CellAddressX).HasColumnName("CellAddress_X");

                entity.Property(e => e.CellAddressY)
                    .IsRequired()
                    .HasColumnName("CellAddress_Y")
                    .HasColumnType("char(2)");

                entity.Property(e => e.CreatedDt)
                    .HasColumnName("CreatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedUserId).HasColumnName("CreatedUserID");

                entity.Property(e => e.FieldId).HasColumnName("FieldID");

                entity.Property(e => e.FieldValue)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedDt)
                    .HasColumnName("UpdatedDT")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.UpdatedUserId).HasColumnName("UpdatedUserID");
            });

            modelBuilder.Entity<OldHrmAchievementEntryM>(entity =>
            {
                entity.HasKey(e => e.AchievementId);

                entity.ToTable("Old_HRM_AchievementEntry_M");

                entity.Property(e => e.AchievementId).HasColumnName("AchievementID");

                entity.Property(e => e.AchievementDate).HasColumnType("smalldatetime");

                entity.Property(e => e.AchievementTypeId).HasColumnName("AchievementTypeID");

                entity.Property(e => e.Barcode)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.CertificateDescription)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CertificateFileName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('AchievementCertificate')");

                entity.Property(e => e.CertificateTemplateFileName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CreatedDt)
                    .HasColumnName("CreatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedUserId).HasColumnName("CreatedUserID");

                entity.Property(e => e.DateTillShowOnWebsite).HasColumnType("smalldatetime");

                entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");

                entity.Property(e => e.EntryWebDescription)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.Field1)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Field2)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Field3)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Field4)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Field5)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.FinAwardAmt).HasDefaultValueSql("((0))");

                entity.Property(e => e.Rating).HasDefaultValueSql("((0))");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedDt)
                    .HasColumnName("UpdatedDT")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.UpdatedUserId).HasColumnName("UpdatedUserID");
            });

            modelBuilder.Entity<OldHrmAchievementTypeM>(entity =>
            {
                entity.HasKey(e => e.AchievementTypeId);

                entity.ToTable("Old_HRM_AchievementType_M");

                entity.Property(e => e.AchievementTypeId).HasColumnName("AchievementTypeID");

                entity.Property(e => e.AchievementType)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CertificateFileName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('AchievementCertificate')");

                entity.Property(e => e.CreatedDt)
                    .HasColumnName("CreatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedUserId).HasColumnName("CreatedUserID");

                entity.Property(e => e.Field1)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Field2)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Field3)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Field4)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Field5)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedDt)
                    .HasColumnName("UpdatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdatedUserId).HasColumnName("UpdatedUserID");
            });

            modelBuilder.Entity<OldHrmAchievementTypesFieldsD>(entity =>
            {
                entity.HasKey(e => e.FieldId);

                entity.ToTable("Old_HRM_AchievementTypesFields_D");

                entity.Property(e => e.FieldId).HasColumnName("FieldID");

                entity.Property(e => e.AchievementTypeId).HasColumnName("AchievementTypeID");

                entity.Property(e => e.CellAddressX).HasColumnName("CellAddress_X");

                entity.Property(e => e.CellAddressY)
                    .IsRequired()
                    .HasColumnName("CellAddress_Y")
                    .HasColumnType("char(2)");

                entity.Property(e => e.CreatedDt)
                    .HasColumnName("CreatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedUserId).HasColumnName("CreatedUserID");

                entity.Property(e => e.FieldName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedDt)
                    .HasColumnName("UpdatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdatedUserId).HasColumnName("UpdatedUserID");
            });

            modelBuilder.Entity<OldHrmAlertGroupAchievements>(entity =>
            {
                entity.HasKey(e => e.AlertGroupAchievementId);

                entity.ToTable("Old_HRM_AlertGroup_Achievements");

                entity.Property(e => e.AlertGroupAchievementId).HasColumnName("AlertGroupAchievementID");

                entity.Property(e => e.AchievementTypeId).HasColumnName("AchievementTypeID");

                entity.Property(e => e.AlertGroupId).HasColumnName("AlertGroupID");

                entity.Property(e => e.CreatedDt)
                    .HasColumnName("CreatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedUserId).HasColumnName("CreatedUserID");

                entity.Property(e => e.UpdatedDt)
                    .HasColumnName("UpdatedDT")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.UpdatedUserId).HasColumnName("UpdatedUserID");
            });

            modelBuilder.Entity<OldHrmAlertGroupIndisciplines>(entity =>
            {
                entity.HasKey(e => e.AlertGroupIndisciplineTypeId);

                entity.ToTable("Old_HRM_AlertGroup_Indisciplines");

                entity.Property(e => e.AlertGroupIndisciplineTypeId).HasColumnName("AlertGroupIndisciplineTypeID");

                entity.Property(e => e.AlertGroupId).HasColumnName("AlertGroupID");

                entity.Property(e => e.CreatedDt)
                    .HasColumnName("CreatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedUserId).HasColumnName("CreatedUserID");

                entity.Property(e => e.IndisciplineTypeId).HasColumnName("IndisciplineTypeID");

                entity.Property(e => e.IsSendSmsalertTo).HasColumnName("IsSendSMSAlertTo");

                entity.Property(e => e.UpdatedDt)
                    .HasColumnName("UpdatedDT")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.UpdatedUserId).HasColumnName("UpdatedUserID");
            });

            modelBuilder.Entity<OldHrmAlertGroupM>(entity =>
            {
                entity.HasKey(e => e.AlertGroupId);

                entity.ToTable("Old_HRM_AlertGroup_M");

                entity.Property(e => e.AlertGroupId)
                    .HasColumnName("AlertGroupID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.AlertGroupDisplayName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AlertGroupName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<OldHrmAttendance>(entity =>
            {
                entity.HasKey(e => e.EmployeeAttendanceId);

                entity.ToTable("Old_HRM_Attendance");

                entity.Property(e => e.EmployeeAttendanceId).HasColumnName("EmployeeAttendanceID");

                entity.Property(e => e.AttendanceEntryDate).HasColumnType("smalldatetime");

                entity.Property(e => e.AttendanceStatus).HasDefaultValueSql("((1))");

                entity.Property(e => e.CreatedDt)
                    .HasColumnName("CreatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedUserId).HasColumnName("CreatedUserID");

                entity.Property(e => e.DesignationId).HasColumnName("DesignationID");

                entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");

                entity.Property(e => e.InTime).HasColumnType("smalldatetime");

                entity.Property(e => e.Othours).HasColumnName("OTHours");

                entity.Property(e => e.Otminutes).HasColumnName("OTMinutes");

                entity.Property(e => e.Otreason)
                    .IsRequired()
                    .HasColumnName("OTReason")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.OutTime).HasColumnType("smalldatetime");

                entity.Property(e => e.UpdatedDt)
                    .HasColumnName("UpdatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdatedUserId).HasColumnName("UpdatedUserID");
            });

            modelBuilder.Entity<OldHrmAttendanceUserM>(entity =>
            {
                entity.HasKey(e => e.UserId);

                entity.ToTable("Old_HRM_AttendanceUser_M");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.CreatedDt)
                    .HasColumnName("CreatedDT")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.EmployeeId)
                    .HasColumnName("EmployeeID")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Fingerprint).HasMaxLength(5000);

                entity.Property(e => e.InTime)
                    .IsRequired()
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('09:30 AM')");

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<OldHrmContactDetailsForApplicants>(entity =>
            {
                entity.HasKey(e => e.ContactDetlId);

                entity.ToTable("Old_HRM_ContactDetailsForApplicants");

                entity.Property(e => e.ContactDetlId).HasColumnName("ContactDetlID");

                entity.Property(e => e.CreatedDt)
                    .HasColumnName("CreatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedUserId)
                    .HasColumnName("CreatedUserID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedDt)
                    .HasColumnName("UpdatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdatedUserId)
                    .HasColumnName("UpdatedUserID")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<OldHrmDesignationModuleRights>(entity =>
            {
                entity.HasKey(e => e.DesignationRightsId);

                entity.ToTable("Old_HRM_Designation_ModuleRights");

                entity.Property(e => e.DesignationRightsId).HasColumnName("DesignationRightsID");

                entity.Property(e => e.CreatedDt)
                    .HasColumnName("CreatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedUserId).HasColumnName("CreatedUserID");

                entity.Property(e => e.EmployeeTypeId).HasColumnName("EmployeeTypeID");

                entity.Property(e => e.ModuleName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedDt)
                    .HasColumnName("UpdatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdatedUserId).HasColumnName("UpdatedUserID");
            });

            modelBuilder.Entity<OldHrmEmployeeAccessRightM>(entity =>
            {
                entity.HasKey(e => e.EmployeeAccessRightId);

                entity.ToTable("Old_HRM_Employee_AccessRight_M");

                entity.Property(e => e.EmployeeAccessRightId).HasColumnName("EmployeeAccessRightID");

                entity.Property(e => e.CreatedDt)
                    .HasColumnName("CreatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedUserId).HasColumnName("CreatedUserID");

                entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");

                entity.Property(e => e.EmployeeTypeId).HasColumnName("EmployeeTypeID");

                entity.Property(e => e.ModuleName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedDt)
                    .HasColumnName("UpdatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdatedUserId).HasColumnName("UpdatedUserID");
            });

            modelBuilder.Entity<OldHrmEmployeeIndisciplineFieldsD>(entity =>
            {
                entity.HasKey(e => e.FieldDetlId);

                entity.ToTable("Old_HRM_EmployeeIndisciplineFields_D");

                entity.Property(e => e.FieldDetlId).HasColumnName("FieldDetlID");

                entity.Property(e => e.CellAddressX).HasColumnName("CellAddress_X");

                entity.Property(e => e.CellAddressY)
                    .IsRequired()
                    .HasColumnName("CellAddress_Y")
                    .HasColumnType("char(2)");

                entity.Property(e => e.CreatedDt)
                    .HasColumnName("CreatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedUserId).HasColumnName("CreatedUserID");

                entity.Property(e => e.EmpIndisciplineId).HasColumnName("EmpIndisciplineID");

                entity.Property(e => e.FieldId).HasColumnName("FieldID");

                entity.Property(e => e.FieldValue)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedDt)
                    .HasColumnName("UpdatedDT")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.UpdatedUserId).HasColumnName("UpdatedUserID");
            });

            modelBuilder.Entity<OldHrmEmployeeModuleRights>(entity =>
            {
                entity.HasKey(e => e.EmployeeRightsId);

                entity.ToTable("Old_HRM_Employee_ModuleRights");

                entity.Property(e => e.EmployeeRightsId).HasColumnName("EmployeeRightsID");

                entity.Property(e => e.CreatedDt)
                    .HasColumnName("CreatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedUserId).HasColumnName("CreatedUserID");

                entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");

                entity.Property(e => e.EmployeeTypeId).HasColumnName("EmployeeTypeID");

                entity.Property(e => e.ModuleName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedDt)
                    .HasColumnName("UpdatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdatedUserId).HasColumnName("UpdatedUserID");
            });

            modelBuilder.Entity<OldHrmEmployeeTargets>(entity =>
            {
                entity.HasKey(e => e.EmpTargetId);

                entity.ToTable("Old_HRM_EmployeeTargets");

                entity.Property(e => e.EmpTargetId).HasColumnName("EmpTargetID");

                entity.Property(e => e.CreatedDt)
                    .HasColumnName("CreatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedUserId).HasColumnName("CreatedUserID");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");

                entity.Property(e => e.Target)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TargetTypeId).HasColumnName("TargetTypeID");

                entity.Property(e => e.UpdatedDt)
                    .HasColumnName("UpdatedDT")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.UpdatedUserId).HasColumnName("UpdatedUserID");
            });

            modelBuilder.Entity<OldHrmIndisciplineAlertsSent>(entity =>
            {
                entity.HasKey(e => e.IndisciplineAlertsSentId);

                entity.ToTable("Old_HRM_IndisciplineAlertsSent");

                entity.Property(e => e.IndisciplineAlertsSentId).HasColumnName("IndisciplineAlertsSentID");

                entity.Property(e => e.CreatedDt)
                    .HasColumnName("CreatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedUserId).HasColumnName("CreatedUserID");

                entity.Property(e => e.EmailId).HasColumnName("EMailID");

                entity.Property(e => e.EmpIndisciplineId).HasColumnName("EmpIndisciplineID");

                entity.Property(e => e.EmployeeId)
                    .HasColumnName("EmployeeID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.IsSendSmsalertTo).HasColumnName("IsSendSMSAlertTo");

                entity.Property(e => e.MessageId).HasColumnName("messageID");

                entity.Property(e => e.UpdatedDt)
                    .HasColumnName("UpdatedDT")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.UpdatedUserId).HasColumnName("UpdatedUserID");
            });

            modelBuilder.Entity<OldHrmIndisciplineEntryD>(entity =>
            {
                entity.HasKey(e => e.IndisciplineEntryDetailId);

                entity.ToTable("Old_HRM_IndisciplineEntry_D");

                entity.Property(e => e.IndisciplineEntryDetailId).HasColumnName("IndisciplineEntryDetailID");

                entity.Property(e => e.CreatedDt)
                    .HasColumnName("CreatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedUserId).HasColumnName("CreatedUserID");

                entity.Property(e => e.Description)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.IndisciplineEntryId).HasColumnName("IndisciplineEntryID");

                entity.Property(e => e.PromotionBarredTill).HasColumnType("smalldatetime");

                entity.Property(e => e.RaiseRestrictionTill).HasColumnType("smalldatetime");

                entity.Property(e => e.ReveiwPeriodStarDt)
                    .HasColumnName("ReveiwPeriodStarDT")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.ReviewPeriodEndDt)
                    .HasColumnName("ReviewPeriodEndDT")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.StatusId).HasColumnName("StatusID");

                entity.Property(e => e.TerminationDate).HasColumnType("smalldatetime");

                entity.Property(e => e.UpdatedDt)
                    .HasColumnName("UpdatedDT")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.UpdatedUserId).HasColumnName("UpdatedUserID");
            });

            modelBuilder.Entity<OldHrmIndisciplineEntryM>(entity =>
            {
                entity.HasKey(e => e.IndisciplineEntryId);

                entity.ToTable("Old_HRM_IndisciplineEntry_M");

                entity.Property(e => e.IndisciplineEntryId).HasColumnName("IndisciplineEntryID");

                entity.Property(e => e.Barcode)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDt)
                    .HasColumnName("CreatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedUserId).HasColumnName("CreatedUserID");

                entity.Property(e => e.DecisionDescription)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");

                entity.Property(e => e.EmployeeRespondedDt)
                    .HasColumnName("EmployeeRespondedDT")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.EmployeeResponse)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Field1)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Field2)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Field3)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Field4)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Field5)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.FinPenaltyAmt).HasDefaultValueSql("((0))");

                entity.Property(e => e.FinPenaltyDueDt)
                    .HasColumnName("FinPenaltyDueDT")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.FinalDecisionDt)
                    .HasColumnName("FinalDecisionDT")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.Indiscipline)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IndisciplineDate).HasColumnType("smalldatetime");

                entity.Property(e => e.IndisciplineTypeId).HasColumnName("IndisciplineTypeID");

                entity.Property(e => e.NoticeFileName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.NoticeTemplateName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PromotionBarredTillDt)
                    .HasColumnName("PromotionBarredTillDT")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.RaiseRestrictionTillDt)
                    .HasColumnName("RaiseRestrictionTillDT")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.ResoponseDueDt)
                    .HasColumnName("ResoponseDueDT")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.ReviewFinPenaltyDueDt)
                    .HasColumnName("ReviewFinPenaltyDueDT")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.ReviewPromotionBarredTillDt)
                    .HasColumnName("ReviewPromotionBarredTillDT")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.ReviewRaiseRestrictionTillDt)
                    .HasColumnName("ReviewRaiseRestrictionTillDT")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.ReviewStatusId).HasColumnName("ReviewStatusID");

                entity.Property(e => e.Smssyntax)
                    .HasColumnName("SMSSyntax")
                    .HasMaxLength(160)
                    .IsUnicode(false);

                entity.Property(e => e.StatusId).HasColumnName("StatusID");

                entity.Property(e => e.UpdatedDt)
                    .HasColumnName("UpdatedDT")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.UpdatedUserId).HasColumnName("UpdatedUserID");
            });

            modelBuilder.Entity<OldHrmIndisciplineStatusM>(entity =>
            {
                entity.HasKey(e => e.IndisciplineStatusId);

                entity.ToTable("Old_HRM_IndisciplineStatus_M");

                entity.Property(e => e.IndisciplineStatusId).HasColumnName("IndisciplineStatusID");

                entity.Property(e => e.StatusName)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<OldHrmIndisciplineTypeFieldsD>(entity =>
            {
                entity.HasKey(e => e.FieldId);

                entity.ToTable("Old_HRM_IndisciplineTypeFields_D");

                entity.Property(e => e.FieldId).HasColumnName("FieldID");

                entity.Property(e => e.CellAddressX).HasColumnName("CellAddress_X");

                entity.Property(e => e.CellAddressY)
                    .IsRequired()
                    .HasColumnName("CellAddress_Y")
                    .HasColumnType("char(2)");

                entity.Property(e => e.CreatedDt)
                    .HasColumnName("CreatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedUserId).HasColumnName("CreatedUserID");

                entity.Property(e => e.FieldName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IndisciplineTypeId).HasColumnName("IndisciplineTypeID");

                entity.Property(e => e.UpdatedDt)
                    .HasColumnName("UpdatedDT")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.UpdatedUserId).HasColumnName("UpdatedUserID");
            });

            modelBuilder.Entity<OldHrmIndisciplineTypeM>(entity =>
            {
                entity.HasKey(e => e.IndisciplineTypeId);

                entity.ToTable("Old_HRM_IndisciplineType_M");

                entity.Property(e => e.IndisciplineTypeId).HasColumnName("IndisciplineTypeID");

                entity.Property(e => e.CreatedDt)
                    .HasColumnName("CreatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedUserId).HasColumnName("CreatedUserID");

                entity.Property(e => e.Field1)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Field2)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Field3)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Field4)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Field5)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.FinPenaltyDueDays).HasDefaultValueSql("((0))");

                entity.Property(e => e.IndisciplineType)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PromotionBarredMonths).HasDefaultValueSql("((0))");

                entity.Property(e => e.RaiseRestrictionMonths).HasDefaultValueSql("((0))");

                entity.Property(e => e.ReviewFinPenaltyDueDays).HasDefaultValueSql("((0))");

                entity.Property(e => e.ReviewPromotionBarredMonths).HasDefaultValueSql("((0))");

                entity.Property(e => e.ReviewRaiseRestrictionMonths).HasDefaultValueSql("((0))");

                entity.Property(e => e.Smssyntax)
                    .HasColumnName("SMSSyntax")
                    .HasMaxLength(160)
                    .IsUnicode(false);

                entity.Property(e => e.TemplateFileName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedDt)
                    .HasColumnName("UpdatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdatedUserId).HasColumnName("UpdatedUserID");
            });

            modelBuilder.Entity<OldHrmIndisciplineTypePolicyD>(entity =>
            {
                entity.HasKey(e => e.ReleventPolicyId);

                entity.ToTable("Old_HRM_IndisciplineTypePolicy_D");

                entity.Property(e => e.ReleventPolicyId).HasColumnName("ReleventPolicyID");

                entity.Property(e => e.CreatedDt)
                    .HasColumnName("CreatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedUserId).HasColumnName("CreatedUserID");

                entity.Property(e => e.IndisciplineTypeId).HasColumnName("IndisciplineTypeID");

                entity.Property(e => e.SectionId).HasColumnName("SectionID");

                entity.Property(e => e.UpdatedDt)
                    .HasColumnName("UpdatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdatedUserId).HasColumnName("UpdatedUserID");
            });

            modelBuilder.Entity<OldHrmIndisciplineTypeReviewActionD>(entity =>
            {
                entity.HasKey(e => e.ReviewId);

                entity.ToTable("Old_HRM_IndisciplineTypeReviewAction_D");

                entity.Property(e => e.ReviewId).HasColumnName("ReviewID");

                entity.Property(e => e.CreatedDt)
                    .HasColumnName("CreatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedUserId).HasColumnName("CreatedUserID");

                entity.Property(e => e.IndisciplineTypeId).HasColumnName("IndisciplineTypeID");

                entity.Property(e => e.ReviewActionId).HasColumnName("ReviewActionID");

                entity.Property(e => e.UpdatedDt)
                    .HasColumnName("UpdatedDT")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.UpdatedUserId).HasColumnName("UpdatedUserID");
            });

            modelBuilder.Entity<OldHrmLeaveTransactionD>(entity =>
            {
                entity.HasKey(e => e.LeaveTransactionDetId);

                entity.ToTable("Old_HRM_LeaveTransaction_D");

                entity.Property(e => e.LeaveTransactionDetId).HasColumnName("LeaveTransactionDetID");

                entity.Property(e => e.AdditionOld)
                    .HasColumnName("Addition_OLD")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.AttendanceId).HasColumnName("AttendanceID");

                entity.Property(e => e.BalanceOld)
                    .HasColumnName("Balance_OLD")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ClosingUnusedLeave).HasColumnName("Closing_Unused_Leave");

                entity.Property(e => e.CreatedDt)
                    .HasColumnName("CreatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedUserId).HasColumnName("CreatedUserID");

                entity.Property(e => e.Date).HasColumnType("smalldatetime");

                entity.Property(e => e.EmployeeId)
                    .HasColumnName("EmployeeID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.EmployeeLeaveAdditionId).HasColumnName("EmployeeLeaveAdditionID");

                entity.Property(e => e.LeaveDays)
                    .HasColumnName("Leave_Days")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.LeaveRequestId)
                    .HasColumnName("LeaveRequestID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.LeaveTransactionIdOld).HasColumnName("LeaveTransactionID_Old");

                entity.Property(e => e.LeaveTransactionType)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.LeaveTypeId)
                    .HasColumnName("LeaveTypeID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.OpeningUnusedLeaves).HasColumnName("Opening_Unused_Leaves");

                entity.Property(e => e.SubtractionOld)
                    .HasColumnName("Subtraction_OLD")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.UpdatedDt)
                    .HasColumnName("UpdatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdatedUserId)
                    .HasColumnName("UpdatedUserID")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<OldHrmLevelM>(entity =>
            {
                entity.HasKey(e => e.SeniorityLevelId);

                entity.ToTable("Old_HRM_Level_M");

                entity.Property(e => e.SeniorityLevelId).HasColumnName("SeniorityLevelID");

                entity.Property(e => e.SeniorityLevelName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<OldHrmPerformanceRecordD>(entity =>
            {
                entity.HasKey(e => e.EmpPerformanceId);

                entity.ToTable("Old_HRM_PerformanceRecord_D");

                entity.Property(e => e.EmpPerformanceId).HasColumnName("EmpPerformanceID");

                entity.Property(e => e.CreatedDt)
                    .HasColumnName("CreatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedUserId)
                    .HasColumnName("CreatedUserID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CreatedUserName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.EmployeeId)
                    .HasColumnName("EmployeeID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.RecordDate)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.RecordDescription)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.RecordId)
                    .HasColumnName("RecordID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.RecordTitle)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.UpdatedDt)
                    .HasColumnName("UpdatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdatedUserId)
                    .HasColumnName("UpdatedUserID")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<OldHrmPerformanceRecordM>(entity =>
            {
                entity.HasKey(e => e.RecordId);

                entity.ToTable("Old_HRM_PerformanceRecord_M");

                entity.Property(e => e.RecordId).HasColumnName("RecordID");

                entity.Property(e => e.CreatedDt)
                    .HasColumnName("CreatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedUserId)
                    .HasColumnName("CreatedUserID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.IncentivePeriod)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PromotionPeriod)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RaisePeriod)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.RecordName)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.RecordType)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.UpdatedDt)
                    .HasColumnName("UpdatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdatedUserId)
                    .HasColumnName("UpdatedUserID")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<OldHrmPerformanceReviewers>(entity =>
            {
                entity.HasKey(e => e.ReviewId);

                entity.ToTable("Old_HRM_PerformanceReviewers");

                entity.Property(e => e.ReviewId).HasColumnName("ReviewID");

                entity.Property(e => e.CreatedDt)
                    .HasColumnName("CreatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedUserId).HasColumnName("CreatedUserID");

                entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");

                entity.Property(e => e.ReviewLogId).HasColumnName("ReviewLogID");

                entity.Property(e => e.UpdatedDt)
                    .HasColumnName("UpdatedDT")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.UpdatedUserId).HasColumnName("UpdatedUserID");
            });

            modelBuilder.Entity<OldHrmPolicyAmendmentD>(entity =>
            {
                entity.HasKey(e => e.AmendmentId);

                entity.ToTable("Old_HRM_PolicyAmendment_D");

                entity.Property(e => e.AmendmentId).HasColumnName("AmendmentID");

                entity.Property(e => e.Amendment)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AmendmentDt)
                    .HasColumnName("AmendmentDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.AmendmentNum)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Attachment)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDt)
                    .HasColumnName("CreatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedUserId).HasColumnName("CreatedUserID");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.EffectiveFromDt)
                    .HasColumnName("EffectiveFromDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.PolicyCategoryId).HasColumnName("PolicyCategoryID");

                entity.Property(e => e.PolicyId).HasColumnName("PolicyID");

                entity.Property(e => e.PolicySectionId).HasColumnName("PolicySectionID");

                entity.Property(e => e.UpdatedDt)
                    .HasColumnName("UpdatedDT")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.UpdatedUserId).HasColumnName("UpdatedUserID");
            });

            modelBuilder.Entity<OldHrmPolicyCategoryM>(entity =>
            {
                entity.HasKey(e => e.PolicyCategoryId);

                entity.ToTable("Old_HRM_PolicyCategory_M");

                entity.Property(e => e.PolicyCategoryId).HasColumnName("PolicyCategoryID");

                entity.Property(e => e.CreatedDt)
                    .HasColumnName("CreatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedUserId).HasColumnName("CreatedUserID");

                entity.Property(e => e.PolicyCategory)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedDt)
                    .HasColumnName("UpdatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdatedUserId).HasColumnName("UpdatedUserID");
            });

            modelBuilder.Entity<OldHrmPolicyM>(entity =>
            {
                entity.HasKey(e => e.PolicyId);

                entity.ToTable("Old_HRM_Policy_M");

                entity.Property(e => e.PolicyId).HasColumnName("PolicyID");

                entity.Property(e => e.CreatedDt)
                    .HasColumnName("CreatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedUserId).HasColumnName("CreatedUserID");

                entity.Property(e => e.Description)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.PolicyCategoryId).HasColumnName("PolicyCategoryID");

                entity.Property(e => e.PolicyName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PolicyNum)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedDt)
                    .HasColumnName("UpdatedDT")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.UpdatedUserId).HasColumnName("UpdatedUserID");
            });

            modelBuilder.Entity<OldHrmPolicySectionD>(entity =>
            {
                entity.HasKey(e => e.SectionId);

                entity.ToTable("Old_HRM_PolicySection_D");

                entity.Property(e => e.SectionId).HasColumnName("SectionID");

                entity.Property(e => e.Attachment)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDt)
                    .HasColumnName("CreatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedUserId).HasColumnName("CreatedUserID");

                entity.Property(e => e.Description)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.PolicyId).HasColumnName("PolicyID");

                entity.Property(e => e.Section)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SectionNum)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedDt)
                    .HasColumnName("UpdatedDT")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.UpdatedUserId).HasColumnName("UpdatedUserID");
            });

            modelBuilder.Entity<OldHrmReviewActionM>(entity =>
            {
                entity.HasKey(e => e.ReviewActionId);

                entity.ToTable("Old_HRM_ReviewAction_M");

                entity.Property(e => e.ReviewActionId)
                    .HasColumnName("ReviewActionID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.CreatedDt)
                    .HasColumnName("CreatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedUserId)
                    .HasColumnName("CreatedUserID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ReviewActionName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedDt)
                    .HasColumnName("UpdatedDT")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.UpdatedUserId).HasColumnName("UpdatedUserID");
            });

            modelBuilder.Entity<OldHrmReviewM>(entity =>
            {
                entity.HasKey(e => e.ReviewId);

                entity.ToTable("Old_HRM_Review_M");

                entity.Property(e => e.ReviewId).HasColumnName("ReviewID");

                entity.Property(e => e.CreatedDt)
                    .HasColumnName("CreatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedUserId).HasColumnName("CreatedUserID");

                entity.Property(e => e.EndDt)
                    .HasColumnName("EndDT")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.Notes)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StartDt)
                    .HasColumnName("StartDT")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.UpdatedDt)
                    .HasColumnName("UpdatedDT")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.UpdatedUserId)
                    .HasColumnName("UpdatedUserID")
                    .HasColumnType("smalldatetime");
            });

            modelBuilder.Entity<OldHrmRoadmapReviewLog>(entity =>
            {
                entity.HasKey(e => e.ReviewLogId);

                entity.ToTable("Old_HRM_RoadmapReviewLog");

                entity.Property(e => e.ReviewLogId).HasColumnName("ReviewLogID");

                entity.Property(e => e.CreatedDt)
                    .HasColumnName("CreatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedUserId).HasColumnName("CreatedUserID");

                entity.Property(e => e.DecisionId).HasColumnName("DecisionID");

                entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");

                entity.Property(e => e.NewDepartmentId).HasColumnName("NewDepartmentID");

                entity.Property(e => e.NewDesignationId).HasColumnName("NewDesignationID");

                entity.Property(e => e.NewReportingToId).HasColumnName("NewReportingToID");

                entity.Property(e => e.OriginalDepartmentId).HasColumnName("OriginalDepartmentID");

                entity.Property(e => e.OriginalDesignationId).HasColumnName("OriginalDesignationID");

                entity.Property(e => e.ReviewCompletionDt)
                    .HasColumnName("ReviewCompletionDT")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.ReviewPlanDt)
                    .HasColumnName("ReviewPlanDT")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.UpdatedDt)
                    .HasColumnName("UpdatedDT")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.UpdatedUserId).HasColumnName("UpdatedUserID");
            });

            modelBuilder.Entity<OldHrmRoadmapSkills>(entity =>
            {
                entity.HasKey(e => e.RoadmapSkillId);

                entity.ToTable("Old_HRM_RoadmapSkills");

                entity.Property(e => e.RoadmapSkillId).HasColumnName("RoadmapSkillID");

                entity.Property(e => e.CreatedDt)
                    .HasColumnName("CreatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedUserId).HasColumnName("CreatedUserID");

                entity.Property(e => e.RoadmapStepId).HasColumnName("RoadmapStepID");

                entity.Property(e => e.SkillId).HasColumnName("SkillID");

                entity.Property(e => e.UpdatedDt)
                    .HasColumnName("UpdatedDT")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.UpdatedUserId).HasColumnName("UpdatedUserID");
            });

            modelBuilder.Entity<OldHrmRoadmapSteps>(entity =>
            {
                entity.HasKey(e => e.RoadmapStepId);

                entity.ToTable("Old_HRM_RoadmapSteps");

                entity.Property(e => e.RoadmapStepId).HasColumnName("RoadmapStepID");

                entity.Property(e => e.AchievedDt)
                    .HasColumnName("AchievedDT")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.CreatdUserId).HasColumnName("CreatdUserID");

                entity.Property(e => e.CreatedDt)
                    .HasColumnName("CreatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DesignationId).HasColumnName("DesignationID");

                entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");

                entity.Property(e => e.IncrementLevel).HasDefaultValueSql("((0))");

                entity.Property(e => e.TargetDt)
                    .HasColumnName("TargetDT")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.UpdatedDt)
                    .HasColumnName("UpdatedDT")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.UpdatedUserId).HasColumnName("UpdatedUserID");
            });

            modelBuilder.Entity<OldHrmRoadmapTargets>(entity =>
            {
                entity.HasKey(e => e.RoadmapTargetId);

                entity.ToTable("Old_HRM_RoadmapTargets");

                entity.Property(e => e.RoadmapTargetId).HasColumnName("RoadmapTargetID");

                entity.Property(e => e.CreatedDt)
                    .HasColumnName("CreatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedUserId).HasColumnName("CreatedUserID");

                entity.Property(e => e.EmpTargetId).HasColumnName("EmpTargetID");

                entity.Property(e => e.RoadmapStepId).HasColumnName("RoadmapStepID");

                entity.Property(e => e.UpdatedDt)
                    .HasColumnName("UpdatedDT")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.UpdatedUserId).HasColumnName("UpdatedUserID");
            });

            modelBuilder.Entity<OldHrmSalaryFieldConfig>(entity =>
            {
                entity.HasKey(e => e.SalaryFieldConfigId);

                entity.ToTable("Old_HRM_SalaryFieldConfig");

                entity.Property(e => e.SalaryFieldConfigId).HasColumnName("SalaryFieldConfigID");

                entity.Property(e => e.CellAddressX).HasColumnName("CellAddress_X");

                entity.Property(e => e.CellAddressY)
                    .IsRequired()
                    .HasColumnName("CellAddress_Y")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDt)
                    .HasColumnName("CreatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedUserId)
                    .HasColumnName("CreatedUserID")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Field)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.UpdatedDt)
                    .HasColumnName("UpdatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdatedUserId)
                    .HasColumnName("UpdatedUserID")
                    .HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<OldHrmSkillPreferenceM>(entity =>
            {
                entity.HasKey(e => e.PreferenceId);

                entity.ToTable("Old_HRM_SkillPreference_M");

                entity.Property(e => e.PreferenceId).HasColumnName("PreferenceID");

                entity.Property(e => e.PreferenceName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<OldHrmStandardInstructionForJobApplication>(entity =>
            {
                entity.HasKey(e => e.StandardInstructionId);

                entity.ToTable("Old_HRM_StandardInstructionForJobApplication");

                entity.Property(e => e.StandardInstructionId).HasColumnName("StandardInstructionID");

                entity.Property(e => e.CreatedDt)
                    .HasColumnName("CreatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedUserId)
                    .HasColumnName("CreatedUserID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedDt)
                    .HasColumnName("UpdatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdatedUserId)
                    .HasColumnName("UpdatedUserID")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<OldHrmTargetTypeM>(entity =>
            {
                entity.HasKey(e => e.TargetTypeId);

                entity.ToTable("Old_HRM_TargetType_M");

                entity.Property(e => e.TargetTypeId).HasColumnName("TargetTypeID");

                entity.Property(e => e.CareatedDt)
                    .HasColumnName("CareatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedUserId).HasColumnName("CreatedUserID");

                entity.Property(e => e.TargetType)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedDt)
                    .HasColumnName("UpdatedDT")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.UpdatedUserId).HasColumnName("UpdatedUserID");
            });

            modelBuilder.Entity<OldMktAutoQuoteBandM>(entity =>
            {
                entity.HasKey(e => e.AutoQuoteBandId);

                entity.ToTable("Old_MKT_AutoQuoteBand_M");

                entity.Property(e => e.AutoQuoteBandId).HasColumnName("AutoQuoteBandID");

                entity.Property(e => e.BandName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDt)
                    .HasColumnName("CreatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedUserId).HasColumnName("CreatedUserID");

                entity.Property(e => e.UpdatedDt)
                    .HasColumnName("UpdatedDT")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.UpdatedUserId).HasColumnName("UpdatedUserID");
            });

            modelBuilder.Entity<OldMktAutoQuoteSetupChargesM>(entity =>
            {
                entity.HasKey(e => e.AutoquoteSetupChargesId);

                entity.ToTable("Old_MKT_AutoQuoteSetupCharges_M");

                entity.Property(e => e.AutoquoteSetupChargesId).HasColumnName("AutoquoteSetupChargesID");

                entity.Property(e => e.BandId).HasColumnName("BandID");

                entity.Property(e => e.CreatedDt)
                    .HasColumnName("CreatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedUserId).HasColumnName("CreatedUserID");

                entity.Property(e => e.CurrencyId).HasColumnName("CurrencyID");

                entity.Property(e => e.CustomerCategoryId).HasColumnName("CustomerCategoryID");

                entity.Property(e => e.UpdatedDt)
                    .HasColumnName("UpdatedDT")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.UpdatedUserId).HasColumnName("UpdatedUserID");
            });

            modelBuilder.Entity<OldMktCustomerRegistrationM>(entity =>
            {
                entity.HasKey(e => e.CustomerRegistrationId);

                entity.ToTable("Old_MKT_CustomerRegistration_M");

                entity.Property(e => e.CustomerRegistrationId).HasColumnName("CustomerRegistrationID");

                entity.Property(e => e.Address1)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Address2)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.BankName)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.BillingAddress1)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.BillingAddress2)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.BillingCity)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.BillingCityId)
                    .HasColumnName("BillingCityID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.BillingCountry)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.BillingCountryId)
                    .HasColumnName("BillingCountryID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.BillingPinCode)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.BillingState)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.BillingStateId)
                    .HasColumnName("BillingStateID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.BusinessActivityId).HasColumnName("BusinessActivityID");

                entity.Property(e => e.City)
                    .IsRequired()
                    .HasColumnType("nchar(50)")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CityId).HasColumnName("CityID");

                entity.Property(e => e.CompanyEmail)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CompanyFax)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CompanyName)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyPhone)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CompanyProducts)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CompanyProducts2)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CompanyProducts3)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CompanyWebsite)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ContactPerson)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ContactPersonDesignation)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ContactPersonEmail)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ContactPersonPhone)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Country)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CountryId).HasColumnName("CountryID");

                entity.Property(e => e.CreatedDt)
                    .HasColumnName("CreatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedUserId).HasColumnName("CreatedUserID");

                entity.Property(e => e.Cstdate)
                    .HasColumnName("CSTDate")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CurrencyId)
                    .HasColumnName("CurrencyID")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.CurrentBalanceAmount).HasDefaultValueSql("((0))");

                entity.Property(e => e.CustomerCst)
                    .HasColumnName("CustomerCST")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CustomerEccnum)
                    .HasColumnName("CustomerECCNum")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CustomerTaxId)
                    .HasColumnName("CustomerTaxID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CustomerTin)
                    .HasColumnName("CustomerTIN")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.DeliveryAddress1)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.DeliveryAddress2)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.DeliveryCity)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.DeliveryCityId)
                    .HasColumnName("DeliveryCityID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.DeliveryCountry)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.DeliveryCountryId)
                    .HasColumnName("DeliveryCountryID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.DeliveryPinCode)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.DeliveryState)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.DeliveryStateId)
                    .HasColumnName("DeliveryStateID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ExcessQuantityPercent).HasDefaultValueSql("((0))");

                entity.Property(e => e.LastBalanceUpdatedDt)
                    .HasColumnName("LastBalanceUpdatedDT")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.Notes)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.OrganizationHead)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.OrganizationHeadDesignation)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.OrganizationHeadEmail)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.OrganizationHeadPhone)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.PcbusageYear).HasColumnName("PCBUsage_Year");

                entity.Property(e => e.PinCode)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.PortOfDischarge)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.RoleId).HasColumnName("RoleID");

                entity.Property(e => e.State)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.StateId).HasColumnName("StateID");

                entity.Property(e => e.Tindate)
                    .HasColumnName("TINDate")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.TitleContactPerson)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TitleOrganizationHead)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TypeOfProductId).HasColumnName("TypeOfProductID");

                entity.Property(e => e.UpdatedDt)
                    .HasColumnName("UpdatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdatedUserId).HasColumnName("UpdatedUserID");
            });

            modelBuilder.Entity<OldMktPotermsM>(entity =>
            {
                entity.HasKey(e => e.PotermId);

                entity.ToTable("Old_MKT_POTerms_M");

                entity.Property(e => e.PotermId).HasColumnName("POTermID");

                entity.Property(e => e.AdvanceAmtPer)
                    .HasColumnType("decimal(6, 2)")
                    .HasDefaultValueSql("((0.00))");

                entity.Property(e => e.CreatedDt)
                    .HasColumnName("CreatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedUserId).HasColumnName("CreatedUserID");

                entity.Property(e => e.Poterm)
                    .IsRequired()
                    .HasColumnName("POTerm")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.TermsCategoryId).HasColumnName("TermsCategoryID");

                entity.Property(e => e.UpdatedDt)
                    .HasColumnName("UpdatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdatedUserId).HasColumnName("UpdatedUserID");
            });

            modelBuilder.Entity<OldMktQuotationBaseRatesD>(entity =>
            {
                entity.HasKey(e => e.QuotationRateListBaseRateId);

                entity.ToTable("Old_MKT_QuotationBaseRates_D");

                entity.Property(e => e.QuotationRateListBaseRateId).HasColumnName("QuotationRateListBaseRateID");

                entity.Property(e => e.BaseRate)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDt)
                    .HasColumnName("CreatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedUserId).HasColumnName("CreatedUserID");

                entity.Property(e => e.ProudctTypeId).HasColumnName("ProudctTypeID");

                entity.Property(e => e.QuotationRateListDetailsId).HasColumnName("QuotationRateListDetailsID");
            });

            modelBuilder.Entity<OldMktQuotationParametersD>(entity =>
            {
                entity.HasKey(e => e.QuotationRateListParameterId);

                entity.ToTable("Old_MKT_QuotationParameters_D");

                entity.Property(e => e.QuotationRateListParameterId).HasColumnName("QuotationRateListParameterID");

                entity.Property(e => e.CreatedDt)
                    .HasColumnName("CreatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedUserId).HasColumnName("CreatedUserID");

                entity.Property(e => e.ParameterId).HasColumnName("ParameterID");

                entity.Property(e => e.ParameterOptionId).HasColumnName("ParameterOptionID");

                entity.Property(e => e.QuotationRateListId).HasColumnName("QuotationRateListID");
            });

            modelBuilder.Entity<OldMktQuotationRatesD>(entity =>
            {
                entity.HasKey(e => e.QuotationRateListDetailsId);

                entity.ToTable("Old_MKT_QuotationRates_D");

                entity.Property(e => e.QuotationRateListDetailsId).HasColumnName("QuotationRateListDetailsID");

                entity.Property(e => e.AutoQuoteBandId).HasColumnName("AutoQuoteBandID");

                entity.Property(e => e.CreatedDt)
                    .HasColumnName("CreatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedUserId).HasColumnName("CreatedUserID");

                entity.Property(e => e.QuotationRateListId).HasColumnName("QuotationRateListID");
            });

            modelBuilder.Entity<OldMktQuotationRatesM>(entity =>
            {
                entity.HasKey(e => e.QuotationRateListId);

                entity.ToTable("Old_MKT_QuotationRates_M");

                entity.Property(e => e.QuotationRateListId).HasColumnName("QuotationRateListID");

                entity.Property(e => e.CreatedDt)
                    .HasColumnName("CreatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedUserId).HasColumnName("CreatedUserID");

                entity.Property(e => e.CurrencyId).HasColumnName("CurrencyID");

                entity.Property(e => e.CustomerCategoryId).HasColumnName("CustomerCategoryID");

                entity.Property(e => e.CustomerId).HasColumnName("CustomerID");

                entity.Property(e => e.RateUnitId).HasColumnName("RateUnitID");

                entity.Property(e => e.ValidityDt)
                    .HasColumnName("ValidityDT")
                    .HasColumnType("smalldatetime");
            });

            modelBuilder.Entity<OldMktQuotationTermsM>(entity =>
            {
                entity.HasKey(e => e.QuotationTermId);

                entity.ToTable("Old_MKT_QuotationTerms_M");

                entity.Property(e => e.QuotationTermId).HasColumnName("QuotationTermID");

                entity.Property(e => e.AdvanceAmtPer)
                    .HasColumnType("decimal(6, 2)")
                    .HasDefaultValueSql("((0.00))");

                entity.Property(e => e.CreatedDt)
                    .HasColumnName("CreatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedUserId).HasColumnName("CreatedUserID");

                entity.Property(e => e.QuotationTerm)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.TermsCategoryId).HasColumnName("TermsCategoryID");

                entity.Property(e => e.UpdatedDt)
                    .HasColumnName("UpdatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdatedUserId).HasColumnName("UpdatedUserID");
            });

            modelBuilder.Entity<OldMktQuoteRateListTermsD>(entity =>
            {
                entity.HasKey(e => e.QuotationRateListTermId);

                entity.ToTable("Old_MKT_QuoteRateListTerms_D");

                entity.Property(e => e.QuotationRateListTermId).HasColumnName("QuotationRateListTermID");

                entity.Property(e => e.CreatedDt)
                    .HasColumnName("CreatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedUserId).HasColumnName("CreatedUserID");

                entity.Property(e => e.QuotationRateListId).HasColumnName("QuotationRateListID");

                entity.Property(e => e.QuotationTermId).HasColumnName("QuotationTermID");
            });

            modelBuilder.Entity<OldMtlDeliveryChallanReturnM>(entity =>
            {
                entity.HasKey(e => e.DeliveryChallanReturnId);

                entity.ToTable("Old_MTL_DeliveryChallan_Return_M");

                entity.Property(e => e.DeliveryChallanReturnId).HasColumnName("DeliveryChallanReturnID");

                entity.Property(e => e.CreatedDt)
                    .HasColumnName("CreatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedUserId)
                    .HasColumnName("CreatedUserID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ExciseAmount).HasDefaultValueSql("((0.0))");

                entity.Property(e => e.ExciseTaxId).HasColumnName("ExciseTaxID");

                entity.Property(e => e.SaleTaxId).HasColumnName("SaleTaxID");

                entity.Property(e => e.SalesTaxAmount).HasDefaultValueSql("((0.0))");

                entity.Property(e => e.SupplierId).HasColumnName("SupplierID");

                entity.Property(e => e.UpdatedDt)
                    .HasColumnName("UpdatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdatedUserId)
                    .HasColumnName("UpdatedUserID")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<OldOldActPaymentSendD>(entity =>
            {
                entity.HasKey(e => e.PaymentSendDetId);

                entity.ToTable("Old_old_ACT_PaymentSend_D");

                entity.Property(e => e.PaymentSendDetId).HasColumnName("PaymentSendDetID");

                entity.Property(e => e.Amount).HasDefaultValueSql("((0))");

                entity.Property(e => e.CreatedDt)
                    .HasColumnName("CreatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedUserId).HasColumnName("CreatedUserID");

                entity.Property(e => e.CurrencyId).HasColumnName("CurrencyID");

                entity.Property(e => e.PaymentDetail)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PaymentSendId).HasColumnName("PaymentSendID");

                entity.Property(e => e.PaymentTypeId).HasColumnName("PaymentTypeID");

                entity.Property(e => e.PurchaseRequestId).HasColumnName("PurchaseRequestID");

                entity.Property(e => e.UpdatedDt)
                    .HasColumnName("UpdatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdatedUserId).HasColumnName("UpdatedUserID");
            });

            modelBuilder.Entity<OldOldActPaymentSendM>(entity =>
            {
                entity.HasKey(e => e.PaymentSendId);

                entity.ToTable("Old_old_ACT_PaymentSend_M");

                entity.Property(e => e.PaymentSendId).HasColumnName("PaymentSendID");

                entity.Property(e => e.AdvanceAmount).HasDefaultValueSql("((0))");

                entity.Property(e => e.Amount).HasDefaultValueSql("((0))");

                entity.Property(e => e.CreatedDt)
                    .HasColumnName("CreatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedUserId).HasColumnName("CreatedUserID");

                entity.Property(e => e.CurrencyId)
                    .HasColumnName("CurrencyID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.DefaultCurrencyId).HasColumnName("DefaultCurrencyID");

                entity.Property(e => e.MaterialReceiveId)
                    .HasColumnName("MaterialReceiveID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.PaymentDetail)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PaymentTypeId).HasColumnName("PaymentTypeID");

                entity.Property(e => e.SupplierId).HasColumnName("SupplierID");

                entity.Property(e => e.UpdatedDt)
                    .HasColumnName("UpdatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdatedUserId).HasColumnName("UpdatedUserID");
            });

            modelBuilder.Entity<OldPrdProductParameterM>(entity =>
            {
                entity.HasKey(e => e.ProductParameterId);

                entity.ToTable("Old_PRD_ProductParameter_M");

                entity.Property(e => e.ProductParameterId).HasColumnName("ProductParameterID");

                entity.Property(e => e.CreatedDt)
                    .HasColumnName("CreatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedUserId).HasColumnName("CreatedUserID");

                entity.Property(e => e.ParameterId).HasColumnName("ParameterID");

                entity.Property(e => e.ParameterOptionId).HasColumnName("ParameterOptionID");

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.Property(e => e.ProductTypeId).HasColumnName("ProductTypeID");

                entity.Property(e => e.UpdatedDt)
                    .HasColumnName("UpdatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdatedUserId).HasColumnName("UpdatedUserID");

                entity.Property(e => e.VersionNum).HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<OldPrdStatusM>(entity =>
            {
                entity.HasKey(e => e.StatusId);

                entity.ToTable("Old_PRD_Status_M");

                entity.Property(e => e.StatusId).HasColumnName("StatusID");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StatusHead)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<OldPrdSubsidiaryProductTypeD>(entity =>
            {
                entity.HasKey(e => e.SubsidiaryProductTypeId);

                entity.ToTable("Old_PRD_SubsidiaryProductType_D");

                entity.Property(e => e.SubsidiaryProductTypeId).HasColumnName("SubsidiaryProductTypeID");

                entity.Property(e => e.DependencyProductTypeId).HasColumnName("DependencyProductTypeID");

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.Property(e => e.UpdatedDt)
                    .HasColumnName("UpdatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UsedQty).HasDefaultValueSql("(0)");

                entity.Property(e => e.UsedQtyArray)
                    .HasColumnName("UsedQty_Array")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.UsedQtyPanel)
                    .HasColumnName("UsedQty_Panel")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.VersionNum).HasDefaultValueSql("(1)");
            });

            modelBuilder.Entity<OldPrdTravelerCardComponentM>(entity =>
            {
                entity.HasKey(e => e.TravelerCardComponentId);

                entity.ToTable("Old_PRD_TravelerCardComponent_M");

                entity.Property(e => e.TravelerCardComponentId).HasColumnName("TravelerCardComponentID");

                entity.Property(e => e.CreatedDt)
                    .HasColumnName("CreatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedUserId).HasColumnName("CreatedUserID");

                entity.Property(e => e.IsVisibleTravelerCard).HasColumnName("IsVisible_TravelerCard");

                entity.Property(e => e.TravelerCardComponentCellX).HasColumnName("TravelerCardComponent_Cell_X");

                entity.Property(e => e.TravelerCardComponentCellY)
                    .HasColumnName("TravelerCardComponent_Cell_Y")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.TravelerCardComponentDisplayName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.TravelerCardComponentName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.TravelerCardComponentValueCellX).HasColumnName("TravelerCardComponent_Value_Cell_X");

                entity.Property(e => e.TravelerCardComponentValueCellY)
                    .IsRequired()
                    .HasColumnName("TravelerCardComponent_Value_Cell_Y")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedDt)
                    .HasColumnName("UpdatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdatedUserId).HasColumnName("UpdatedUserID");
            });

            modelBuilder.Entity<OldPrdWorkOrderEmployeeD>(entity =>
            {
                entity.HasKey(e => e.WorkOrderEmpDetId);

                entity.ToTable("Old_PRD_WorkOrderEmployee_D");

                entity.Property(e => e.WorkOrderEmpDetId).HasColumnName("WorkOrderEmpDetID");

                entity.Property(e => e.CreatedDt)
                    .HasColumnName("CreatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");

                entity.Property(e => e.IsDeleted).HasDefaultValueSql("(0)");

                entity.Property(e => e.WorkOrderDetId).HasColumnName("WorkOrderDetID");
            });

            modelBuilder.Entity<OldServiceM>(entity =>
            {
                entity.HasKey(e => e.ServiceId);

                entity.ToTable("Old_Service_M");

                entity.Property(e => e.ServiceId).HasColumnName("ServiceID");

                entity.Property(e => e.CreatedDt)
                    .HasColumnName("CreatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedUserId).HasColumnName("CreatedUserID");

                entity.Property(e => e.Description)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.GroupId)
                    .HasColumnName("GroupID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.LedgerId)
                    .HasColumnName("LedgerID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ServiceCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ServiceName)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedDt)
                    .HasColumnName("UpdatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdatedUserId).HasColumnName("UpdatedUserID");
            });

            modelBuilder.Entity<OldServiceTypeM>(entity =>
            {
                entity.HasKey(e => e.ServiceTypeId);

                entity.ToTable("Old_ServiceType_M");

                entity.Property(e => e.ServiceTypeId).HasColumnName("ServiceTypeID");

                entity.Property(e => e.CreatedDt)
                    .HasColumnName("CreatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedUserId).HasColumnName("CreatedUserID");

                entity.Property(e => e.GroupId).HasColumnName("GroupID");

                entity.Property(e => e.ServiceTypeName)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedDt)
                    .HasColumnName("UpdatedDT")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.UpdatedUserId).HasColumnName("UpdatedUserID");
            });

            modelBuilder.Entity<PrdAcceptableProcessFlowD>(entity =>
            {
                entity.HasKey(e => e.AcceptableProcessFlowDetId);

                entity.ToTable("PRD_AcceptableProcessFlow_D");

                entity.Property(e => e.AcceptableProcessFlowDetId).HasColumnName("AcceptableProcessFlowDetID");

                entity.Property(e => e.AcceptableProcessFlowId).HasColumnName("AcceptableProcessFlowID");

                entity.Property(e => e.CreatedDt)
                    .HasColumnName("CreatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedUserId).HasColumnName("CreatedUserID");

                entity.Property(e => e.ProcessStepId).HasColumnName("ProcessStepID");

                entity.Property(e => e.UpdatedDt)
                    .HasColumnName("UpdatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdatedUserId).HasColumnName("UpdatedUserID");
            });

            modelBuilder.Entity<PrdAcceptableProcessFlowM>(entity =>
            {
                entity.HasKey(e => e.AcceptableProcessFlowId);

                entity.ToTable("PRD_AcceptableProcessFlow_M");

                entity.Property(e => e.AcceptableProcessFlowId).HasColumnName("AcceptableProcessFlowID");

                entity.Property(e => e.AcceptableProcessFlowCode)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.AcceptableProcessFlowName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDt)
                    .HasColumnName("CreatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedUserId).HasColumnName("CreatedUserID");

                entity.Property(e => e.SubCategoryId).HasColumnName("SubCategoryID");

                entity.Property(e => e.UpdatedDt)
                    .HasColumnName("UpdatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdatedUserId).HasColumnName("UpdatedUserID");
            });

            modelBuilder.Entity<PrdFamilyConfigurationCustomerProduct>(entity =>
            {
                entity.HasKey(e => e.PcbconfigurationFamilyId);

                entity.ToTable("PRD_Family_Configuration_CustomerProduct");

                entity.Property(e => e.PcbconfigurationFamilyId).HasColumnName("PCBConfiguration_FamilyID");

                entity.Property(e => e.CreatedDt)
                    .HasColumnName("CreatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedUserId).HasColumnName("CreatedUserID");

                entity.Property(e => e.IsFieldPanel1).HasColumnName("Is_Field_Panel1");

                entity.Property(e => e.IsFieldPcb1).HasColumnName("Is_Field_PCB1");

                entity.Property(e => e.IsFieldSheet1).HasColumnName("Is_Field_Sheet1");

                entity.Property(e => e.IsFieldWaste1).HasColumnName("Is_Field_Waste1");

                entity.Property(e => e.IsUsedInPanel).HasColumnName("IsUsedIn_Panel");

                entity.Property(e => e.IsUsedInPcb).HasColumnName("IsUsedIn_PCB");

                entity.Property(e => e.IsUsedInSheet).HasColumnName("IsUsedIn_Sheet");

                entity.Property(e => e.IsUsedInWaste).HasColumnName("IsUsedIn_Waste");

                entity.Property(e => e.MaterialSubCategoryId).HasColumnName("MaterialSubCategoryID");

                entity.Property(e => e.UpdatedDt)
                    .HasColumnName("UpdatedDT")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.UpdatedUserId).HasColumnName("UpdatedUserID");
            });

            modelBuilder.Entity<PrdFieldConfigurationCustomerProduct>(entity =>
            {
                entity.HasKey(e => e.PcbconfigurationFieldId);

                entity.ToTable("PRD_Field_Configuration_CustomerProduct");

                entity.Property(e => e.PcbconfigurationFieldId).HasColumnName("PCBConfiguration_FieldID");

                entity.Property(e => e.DefaultValue)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.IsFieldPanel1).HasColumnName("Is_Field_Panel1");

                entity.Property(e => e.IsFieldPcb1).HasColumnName("Is_Field_PCB1");

                entity.Property(e => e.IsFieldSheet1).HasColumnName("Is_Field_Sheet1");

                entity.Property(e => e.IsFieldWaste1).HasColumnName("Is_Field_Waste1");

                entity.Property(e => e.IsUsedInPanel).HasColumnName("IsUsedIn_Panel");

                entity.Property(e => e.IsUsedInPcb).HasColumnName("IsUsedIn_PCB");

                entity.Property(e => e.IsUsedInSheet).HasColumnName("IsUsedIn_Sheet");

                entity.Property(e => e.IsUsedInWaste).HasColumnName("IsUsedIn_Waste");

                entity.Property(e => e.MaterialFieldId).HasColumnName("MaterialFieldID");

                entity.Property(e => e.PcbconfigurationFieldDisplayName)
                    .IsRequired()
                    .HasColumnName("PCBConfiguration_FieldDisplayName")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PcbconfigurationFieldName)
                    .IsRequired()
                    .HasColumnName("PCBConfiguration_FieldName")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PcbconfigurationFieldOrder).HasColumnName("PCBConfiguration_FieldOrder");

                entity.Property(e => e.PcbconfigurationFieldTypeId).HasColumnName("PCBConfiguration_FieldTypeID");

                entity.Property(e => e.UpdatedDt)
                    .HasColumnName("UpdatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdatedUserId).HasColumnName("UpdatedUserID");
            });

            modelBuilder.Entity<PrdFreeProcessSteps>(entity =>
            {
                entity.HasKey(e => e.FreeProcessStepId);

                entity.ToTable("PRD_FreeProcessSteps");

                entity.Property(e => e.FreeProcessStepId).HasColumnName("FreeProcessStepID");

                entity.Property(e => e.FirstAvailableDt)
                    .HasColumnName("FirstAvailableDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ProcessStepId).HasColumnName("ProcessStepID");
            });

            modelBuilder.Entity<PrdHrmProcessGroups>(entity =>
            {
                entity.HasKey(e => e.EmployeeProcessGroupId);

                entity.ToTable("PRD_HRM_ProcessGroups");

                entity.Property(e => e.EmployeeProcessGroupId).HasColumnName("EmployeeProcessGroupID");

                entity.Property(e => e.CreatedDt)
                    .HasColumnName("CreatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedUserId).HasColumnName("CreatedUserID");

                entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");

                entity.Property(e => e.ProcessGroupId).HasColumnName("ProcessGroupID");

                entity.Property(e => e.UpdatedDt)
                    .HasColumnName("UpdatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdatedUserId).HasColumnName("UpdatedUserID");
            });

            modelBuilder.Entity<PrdHrmProcessSteps>(entity =>
            {
                entity.HasKey(e => e.EmployeeProcessStepId);

                entity.ToTable("PRD_HRM_ProcessSteps");

                entity.Property(e => e.EmployeeProcessStepId).HasColumnName("EmployeeProcessStepID");

                entity.Property(e => e.CreatedDt)
                    .HasColumnName("CreatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedUserId).HasColumnName("CreatedUserID");

                entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");

                entity.Property(e => e.IsDeleted).HasDefaultValueSql("(0)");

                entity.Property(e => e.ProcessStepId).HasColumnName("ProcessStepID");

                entity.Property(e => e.UpdatedDt)
                    .HasColumnName("UpdatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdatedUserId).HasColumnName("UpdatedUserID");
            });

            modelBuilder.Entity<PrdMaintenanceParameterM>(entity =>
            {
                entity.HasKey(e => e.MaintenanceParameterId);

                entity.ToTable("PRD_MaintenanceParameter_M");

                entity.Property(e => e.MaintenanceParameterId).HasColumnName("MaintenanceParameterID");

                entity.Property(e => e.CreatedDt)
                    .HasColumnName("CreatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedUserId)
                    .HasColumnName("CreatedUserID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.MaintenanceParameterDescription)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.MaintenanceParameterDisplayName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.MaintenanceParameterName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ParameterTypeId).HasColumnName("ParameterTypeID");

                entity.Property(e => e.UpdatedDt)
                    .HasColumnName("UpdatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdatedUserId)
                    .HasColumnName("UpdatedUserID")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<PrdMaintenanceParameterReadingD>(entity =>
            {
                entity.HasKey(e => e.MaintenanceParameterLogDetailId);

                entity.ToTable("PRD_MaintenanceParameterReading_D");

                entity.Property(e => e.MaintenanceParameterLogDetailId).HasColumnName("MaintenanceParameterLogDetailID");

                entity.Property(e => e.ActualValue)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDt)
                    .HasColumnName("CreatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedUserId).HasColumnName("CreatedUserID");

                entity.Property(e => e.IdealMaxValue)
                    .HasColumnName("Ideal_MaxValue")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.IdealMinValue)
                    .HasColumnName("Ideal_MinValue")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.IdealValue)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.MaintenanceParameterDetailsId).HasColumnName("MaintenanceParameterDetailsID");

                entity.Property(e => e.MaintenanceParameterId).HasColumnName("MaintenanceParameterID");

                entity.Property(e => e.MaintenanceParameterLogId).HasColumnName("MaintenanceParameterLogID");

                entity.Property(e => e.Notes)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ParameterValueUnitName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProcessId).HasColumnName("ProcessID");
            });

            modelBuilder.Entity<PrdMaintenanceParameterReadingM>(entity =>
            {
                entity.HasKey(e => e.MaintenanceParameterLogId);

                entity.ToTable("PRD_MaintenanceParameterReading_M");

                entity.Property(e => e.MaintenanceParameterLogId).HasColumnName("MaintenanceParameterLogID");

                entity.Property(e => e.CreatedDt)
                    .HasColumnName("CreatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedUserId).HasColumnName("CreatedUserID");

                entity.Property(e => e.ObservationDt)
                    .HasColumnName("ObservationDT")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.ObservedByEmpId).HasColumnName("ObservedBy_EmpID");
            });

            modelBuilder.Entity<PrdMaintenanceParametersD>(entity =>
            {
                entity.HasKey(e => e.MaintenanceParameterDetailsId);

                entity.ToTable("PRD_MaintenanceParameters_D");

                entity.Property(e => e.MaintenanceParameterDetailsId).HasColumnName("MaintenanceParameterDetailsID");

                entity.Property(e => e.CreatedDt)
                    .HasColumnName("CreatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedUserId).HasColumnName("CreatedUserID");

                entity.Property(e => e.IdealMaxValue)
                    .HasColumnName("Ideal_MaxValue")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.IdealMinValue)
                    .HasColumnName("Ideal_MinValue")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.IdealValue)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.MaintenanceParameterId).HasColumnName("MaintenanceParameterID");

                entity.Property(e => e.MaintenanceTypeId).HasColumnName("MaintenanceTypeID");

                entity.Property(e => e.ParameterValueUnitName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProcessStepId).HasColumnName("ProcessStepID");

                entity.Property(e => e.UpdatedDt)
                    .HasColumnName("UpdatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdatedUserId).HasColumnName("UpdatedUserID");
            });

            modelBuilder.Entity<PrdOutputTypeM>(entity =>
            {
                entity.HasKey(e => e.OutputTypeId);

                entity.ToTable("PRD_OutputType_M");

                entity.Property(e => e.OutputTypeId).HasColumnName("OutputTypeID");

                entity.Property(e => e.CreatedDt)
                    .HasColumnName("CreatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedUserId).HasColumnName("CreatedUserID");

                entity.Property(e => e.OutputCategory)
                    .IsRequired()
                    .HasColumnType("char(1)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.OutputErrorType)
                    .IsRequired()
                    .HasColumnType("char(1)");

                entity.Property(e => e.OutputNum)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.OutputTypeCode)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.OutputTypeName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ProcessStepId)
                    .HasColumnName("ProcessStepID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ResponsibleProcessStepId)
                    .HasColumnName("ResponsibleProcessStepID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ResponsibleProcessType).HasDefaultValueSql("((1))");

                entity.Property(e => e.UnitOutputTypeName)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedDt)
                    .HasColumnName("UpdatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdatedUserId).HasColumnName("UpdatedUserID");
            });

            modelBuilder.Entity<PrdParameterM>(entity =>
            {
                entity.HasKey(e => e.ParameterId);

                entity.ToTable("PRD_Parameter_M");

                entity.Property(e => e.ParameterId).HasColumnName("ParameterID");

                entity.Property(e => e.CreatedDt)
                    .HasColumnName("CreatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedUserId)
                    .HasColumnName("CreatedUserID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ParameterDescription)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ParameterDisplayName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ParameterName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ParameterTypeId).HasColumnName("ParameterTypeID");

                entity.Property(e => e.UpdatedDt)
                    .HasColumnName("UpdatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdatedUserId)
                    .HasColumnName("UpdatedUserID")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<PrdPlantM>(entity =>
            {
                entity.HasKey(e => e.PlantId);

                entity.ToTable("PRD_Plant_M");

                entity.Property(e => e.PlantId).HasColumnName("PlantID");

                entity.Property(e => e.CreatedDt)
                    .HasColumnName("CreatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedUserId).HasColumnName("CreatedUserID");

                entity.Property(e => e.ExportInvoice2TemplateFileName)
                    .IsRequired()
                    .HasColumnName("ExportInvoice_2_TemplateFileName")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ExportInvoice3TemplateFileName)
                    .IsRequired()
                    .HasColumnName("ExportInvoice_3_TemplateFileName")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ExportInvoiceTemplateFileName)
                    .IsRequired()
                    .HasColumnName("ExportInvoice_TemplateFileName")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.LocalInvoiceTemplateFileName)
                    .IsRequired()
                    .HasColumnName("LocalInvoice_TemplateFileName")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.PlantAddress1)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.PlantAddress2)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.PlantCity)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.PlantContactInfo1)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.PlantContactInfo2)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.PlantContactInfo3)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.PlantCountry)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.PlantName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PlantPinCode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.PlantState)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ProjectPresenceRptTemplateFile)
                    .HasColumnName("ProjectPresenceRPT_TemplateFile")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SalarySlipTemplateFileName)
                    .IsRequired()
                    .HasColumnName("SalarySlip_TemplateFileName")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ScrapInvoiceTemplateFileName)
                    .IsRequired()
                    .HasColumnName("ScrapInvoice_TemplateFileName")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.SezinvoiceTemplateFileName)
                    .IsRequired()
                    .HasColumnName("SEZInvoice_TemplateFileName")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TravelerCard1)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedDt)
                    .HasColumnName("UpdatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdatedUserId).HasColumnName("UpdatedUserID");
            });

            modelBuilder.Entity<PrdProcessGroupM>(entity =>
            {
                entity.HasKey(e => e.ProcessGroupId);

                entity.ToTable("PRD_ProcessGroup_M");

                entity.Property(e => e.ProcessGroupId).HasColumnName("ProcessGroupID");

                entity.Property(e => e.AlertSmsnumbersJobDelay)
                    .HasColumnName("AlertSMSNumbers_JobDelay")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CreatedDt)
                    .HasColumnName("CreatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedUserId).HasColumnName("CreatedUserID");

                entity.Property(e => e.ProcessGroupName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ProcessGroupOrder).HasDefaultValueSql("((0))");

                entity.Property(e => e.ProcessGroupShortName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UnitId)
                    .HasColumnName("UnitID")
                    .HasDefaultValueSql("((3))");

                entity.Property(e => e.UpdatedDt)
                    .HasColumnName("UpdatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdatedUserId).HasColumnName("UpdatedUserID");
            });

            modelBuilder.Entity<PrdProcessParameterReadingD>(entity =>
            {
                entity.HasKey(e => e.ProcessParameterLogDetailId);

                entity.ToTable("PRD_ProcessParameterReading_D");

                entity.Property(e => e.ProcessParameterLogDetailId).HasColumnName("ProcessParameterLogDetailID");

                entity.Property(e => e.ActualValue)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDt)
                    .HasColumnName("CreatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedUserId).HasColumnName("CreatedUserID");

                entity.Property(e => e.IdealMaxValue)
                    .HasColumnName("Ideal_MaxValue")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.IdealMinValue)
                    .HasColumnName("Ideal_MinValue")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.IdealValue)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Notes)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ParameterId).HasColumnName("ParameterID");

                entity.Property(e => e.ParameterValueUnitName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProcessId).HasColumnName("ProcessID");

                entity.Property(e => e.ProcessParameterId).HasColumnName("ProcessParameterID");

                entity.Property(e => e.ProcessParameterLogId).HasColumnName("ProcessParameterLogID");
            });

            modelBuilder.Entity<PrdProcessParameterReadingM>(entity =>
            {
                entity.HasKey(e => e.ProcessParameterLogId);

                entity.ToTable("PRD_ProcessParameterReading_M");

                entity.Property(e => e.ProcessParameterLogId).HasColumnName("ProcessParameterLogID");

                entity.Property(e => e.CreatedDt)
                    .HasColumnName("CreatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedUserId).HasColumnName("CreatedUserID");

                entity.Property(e => e.ObservationDt)
                    .HasColumnName("ObservationDT")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.ObservedByEmpId).HasColumnName("ObservedBy_EmpID");
            });

            modelBuilder.Entity<PrdProcessParametersD>(entity =>
            {
                entity.HasKey(e => e.ProcessParameterId);

                entity.ToTable("PRD_ProcessParameters_D");

                entity.Property(e => e.ProcessParameterId).HasColumnName("ProcessParameterID");

                entity.Property(e => e.CreatedDt)
                    .HasColumnName("CreatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedUserId).HasColumnName("CreatedUserID");

                entity.Property(e => e.IdealMaxValue)
                    .HasColumnName("Ideal_MaxValue")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.IdealMinValue)
                    .HasColumnName("Ideal_MinValue")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.IdealValue)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ParameterId).HasColumnName("ParameterID");

                entity.Property(e => e.ParameterValueUnitName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProcessStepId).HasColumnName("ProcessStepID");

                entity.Property(e => e.UpdatedDt)
                    .HasColumnName("UpdatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdatedUserId).HasColumnName("UpdatedUserID");
            });

            modelBuilder.Entity<PrdProcessStepByproducts>(entity =>
            {
                entity.HasKey(e => e.ProcessStepByproductId);

                entity.ToTable("PRD_ProcessStep_Byproducts");

                entity.Property(e => e.ProcessStepByproductId).HasColumnName("ProcessStepByproductID");

                entity.Property(e => e.CreatedDt)
                    .HasColumnName("CreatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedUserId).HasColumnName("CreatedUserID");

                entity.Property(e => e.MaterialCategoryId).HasColumnName("MaterialCategoryID");

                entity.Property(e => e.MaterialId).HasColumnName("MaterialID");

                entity.Property(e => e.MaterialSubCategoryId).HasColumnName("MaterialSubCategoryID");

                entity.Property(e => e.ProcessStepId).HasColumnName("ProcessStepID");

                entity.Property(e => e.QtyDenominator).HasColumnName("Qty_Denominator");

                entity.Property(e => e.QtyDenominatorUnitId).HasColumnName("Qty_Denominator_UnitID");

                entity.Property(e => e.QtyNumerator).HasColumnName("Qty_Numerator");

                entity.Property(e => e.QtyNumeratorUnitId).HasColumnName("Qty_Numerator_UnitID");

                entity.Property(e => e.SendToId).HasColumnName("SendTo_ID");

                entity.Property(e => e.UpdatedDt)
                    .HasColumnName("UpdatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdatedUserId).HasColumnName("UpdatedUserID");
            });

            modelBuilder.Entity<PrdProcessStepM>(entity =>
            {
                entity.HasKey(e => e.ProcessStepId);

                entity.ToTable("PRD_ProcessStep_M");

                entity.Property(e => e.ProcessStepId)
                    .HasColumnName("ProcessStepID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.AllowedNumOfJobs).HasDefaultValueSql("((1))");

                entity.Property(e => e.BypassMachinesDeleted)
                    .HasColumnName("BypassMachines_Deleted")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CfOutPutUnitIdToReportingUnitIdDenominator).HasColumnName("CF_OutPutUnitID_To_ReportingUnitID_Denominator");

                entity.Property(e => e.CfOutPutUnitIdToReportingUnitIdNumerator).HasColumnName("CF_OutPutUnitID_To_ReportingUnitID_Numerator");

                entity.Property(e => e.CreatedDt)
                    .HasColumnName("CreatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedUserId).HasColumnName("CreatedUserID");

                entity.Property(e => e.DepartmentIdDeleted)
                    .HasColumnName("DepartmentID_Deleted")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.InspectionQty)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.IsApplicableSpeedFactor).HasColumnName("IsApplicable_SpeedFactor");

                entity.Property(e => e.IsBubbleAlertPossible).HasColumnName("IsBubbleAlert_Possible");

                entity.Property(e => e.IsCompletedAlert).HasColumnName("IsCompleted_Alert");

                entity.Property(e => e.IsCompletedByProduct).HasColumnName("IsCompleted_ByProduct");

                entity.Property(e => e.IsCompletedMachine).HasColumnName("IsCompleted_Machine");

                entity.Property(e => e.IsCompletedMaintenance).HasColumnName("IsCompleted_Maintenance");

                entity.Property(e => e.IsCompletedRawMaterial).HasColumnName("IsCompleted_RawMaterial");

                entity.Property(e => e.IsCompletedRejection).HasColumnName("IsCompleted_Rejection");

                entity.Property(e => e.IsCompletedTiming).HasColumnName("IsCompleted_Timing");

                entity.Property(e => e.IsCompletedUnit).HasColumnName("IsCompleted_Unit");

                entity.Property(e => e.IsIncludeInSummaryEmails).HasColumnName("IsIncludeIn_SummaryEmails");

                entity.Property(e => e.IsOutputUnitEqualsInputUnit).HasColumnName("Is_OutputUnit_Equals_InputUnit");

                entity.Property(e => e.IsRelationExist).HasColumnName("Is_RelationExist");

                entity.Property(e => e.IsReportingUnitEqualsOutputUnit).HasColumnName("Is_ReportingUnit_Equals_OutputUnit");

                entity.Property(e => e.IsSplitJobforMl).HasColumnName("IsSplitJobforML");

                entity.Property(e => e.MaintenanceOverDueAlertMobileNo)
                    .HasColumnName("Maintenance_OverDueAlert_MobileNo")
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.MaxRejectionAllowedPercentage).HasColumnName("MaxRejectionAllowed_Percentage");

                entity.Property(e => e.Notes)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ParentUnitCategoryId).HasColumnName("Parent_UnitCategoryID");

                entity.Property(e => e.ParentUnitIdFrom).HasColumnName("Parent_UnitID_From");

                entity.Property(e => e.ParentUnitIdTo).HasColumnName("Parent_UnitID_To");

                entity.Property(e => e.PcbtypeIdDeleted).HasColumnName("PCBTypeID_Deleted");

                entity.Property(e => e.PollingId).HasColumnName("PollingID");

                entity.Property(e => e.ProcessFileName)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ProcessGroupId)
                    .HasColumnName("ProcessGroupID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ProcessOrder).HasDefaultValueSql("((0))");

                entity.Property(e => e.ProcessStepCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ProcessStepName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ProcessStepShortName)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ProductionInputUnitCategoryId).HasColumnName("Production_Input_UnitCategoryID");

                entity.Property(e => e.ProductionInputUnitId).HasColumnName("Production_Input_UnitID");

                entity.Property(e => e.ProductionInputUnitIdFrom)
                    .HasColumnName("Production_Input_UnitID_From")
                    .HasDefaultValueSql("((3))");

                entity.Property(e => e.ProductionInputUnitIdTo).HasColumnName("Production_Input_UnitID_To");

                entity.Property(e => e.ProductionOutputUnitCategoryId).HasColumnName("Production_Output_UnitCategoryID");

                entity.Property(e => e.ProductionOutputUnitId).HasColumnName("Production_Output_UnitID");

                entity.Property(e => e.ProductionOutputUnitIdFrom).HasColumnName("Production_Output_UnitID_From");

                entity.Property(e => e.ProductionOutputUnitIdTo).HasColumnName("Production_Output_UnitID_To");

                entity.Property(e => e.Psn)
                    .HasColumnName("PSN")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.ReportingUnitCategoryId).HasColumnName("Reporting_UnitCategoryID");

                entity.Property(e => e.ReportingUnitId).HasColumnName("Reporting_UnitID");

                entity.Property(e => e.TargetLowProductionQtyPerDay).HasColumnName("Target_LowProductionQty_Per_Day");

                entity.Property(e => e.TargetOutputQty).HasDefaultValueSql("((0))");

                entity.Property(e => e.TargetOutputQtyPerDay)
                    .HasColumnName("TargetOutputQty_Per_Day")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TargetOutputUnit)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TargetRejectionQtyPerDay).HasColumnName("Target_RejectionQty_Per_Day");

                entity.Property(e => e.UpdatedDt)
                    .HasColumnName("UpdatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdatedUserId).HasColumnName("UpdatedUserID");

                entity.Property(e => e.WorkHoursPerDayHours)
                    .HasColumnName("WorkHoursPerDay_Hours")
                    .HasDefaultValueSql("((8))");

                entity.Property(e => e.WorkHoursPerDayMinutes)
                    .HasColumnName("WorkHoursPerDay_Minutes")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<PrdProcessStepMaintenance>(entity =>
            {
                entity.HasKey(e => e.ProcessStepMaintenanceId);

                entity.ToTable("PRD_ProcessStep_Maintenance");

                entity.Property(e => e.ProcessStepMaintenanceId).HasColumnName("ProcessStepMaintenanceID");

                entity.Property(e => e.CreatedDt)
                    .HasColumnName("CreatedDT")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.CreatedUserId).HasColumnName("CreatedUserID");

                entity.Property(e => e.MaintenanceDays).HasDefaultValueSql("((0))");

                entity.Property(e => e.MaintenanceJobs).HasDefaultValueSql("((0))");

                entity.Property(e => e.MaintenanceOnParentUnit).HasDefaultValueSql("((0))");

                entity.Property(e => e.MaintenanceOutputUnitId).HasColumnName("MaintenanceOutputUnitID");

                entity.Property(e => e.MaintenancePratentUnitId)
                    .HasColumnName("MaintenancePratentUnitID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.MaintenanceTypeId).HasColumnName("MaintenanceTypeID");

                entity.Property(e => e.NextMaintenanceDt)
                    .HasColumnName("NextMaintenanceDT")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.NextMaintenanceDtWithHours)
                    .HasColumnName("NextMaintenanceDT_WithHours")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.ProcessStepId).HasColumnName("ProcessStepID");

                entity.Property(e => e.UpdatedDt)
                    .HasColumnName("UpdatedDT")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.UpdatedUserId).HasColumnName("UpdatedUserID");
            });

            modelBuilder.Entity<PrdProcessStepMaintenanceH>(entity =>
            {
                entity.HasKey(e => e.ProcessMaintenanceHistoryId);

                entity.ToTable("PRD_ProcessStep_Maintenance_H");

                entity.Property(e => e.ProcessMaintenanceHistoryId).HasColumnName("ProcessMaintenanceHistoryID");

                entity.Property(e => e.ActualMaintenanceInNoOfHours).HasColumnName("ActualMaintenance_InNoOfHours");

                entity.Property(e => e.AttendedEmployeeId).HasColumnName("Attended_EmployeeID");

                entity.Property(e => e.CreatedDt)
                    .HasColumnName("CreatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedUserId).HasColumnName("CreatedUserID");

                entity.Property(e => e.CurrencyExchangeRate)
                    .HasColumnName("Currency_ExchangeRate")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.CurrencyId)
                    .HasColumnName("CurrencyID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.DefaultCurrencyId)
                    .HasColumnName("DefaultCurrencyID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ExpMaintenanceDtWithHours)
                    .HasColumnName("ExpMaintenanceDT_WithHours")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.ExpMaintenanceInNoOfHours).HasColumnName("ExpMaintenance_InNoOfHours");

                entity.Property(e => e.ExpectedMaintnanceInOutputUnitId).HasColumnName("ExpectedMaintnanceInOutputUnitID");

                entity.Property(e => e.ExpectedMaintnanceInReportingUnitId).HasColumnName("ExpectedMaintnanceInReportingUnitID");

                entity.Property(e => e.NextMaintenanceDt)
                    .HasColumnName("NextMaintenanceDT")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.NoofHoursForMaintenance)
                    .HasColumnName("NoofHours_ForMaintenance")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.PaidUsingLedgerId)
                    .HasColumnName("PaidUsingLedgerID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ProcessStepId).HasColumnName("ProcessStepID");

                entity.Property(e => e.ProcessStepMaintenanceId).HasColumnName("ProcessStepMaintenanceID");

                entity.Property(e => e.UpdatedDt)
                    .HasColumnName("UpdatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdatedUserId).HasColumnName("UpdatedUserID");
            });

            modelBuilder.Entity<PrdProcessStepOutputTypes>(entity =>
            {
                entity.HasKey(e => e.ProcessStepOutputTypeId);

                entity.ToTable("PRD_ProcessStep_OutputTypes");

                entity.Property(e => e.ProcessStepOutputTypeId).HasColumnName("ProcessStepOutputTypeID");

                entity.Property(e => e.CreatedDt)
                    .HasColumnName("CreatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedUserId).HasColumnName("CreatedUserID");

                entity.Property(e => e.OutputTypeId).HasColumnName("OutputTypeID");

                entity.Property(e => e.ProcessStepId).HasColumnName("ProcessStepID");

                entity.Property(e => e.UpdatedDt)
                    .HasColumnName("UpdatedDT")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.UpdatedUserId).HasColumnName("UpdatedUserID");
            });

            modelBuilder.Entity<PrdProcessStepTimingM>(entity =>
            {
                entity.HasKey(e => e.ProcessStepTimingId);

                entity.ToTable("PRD_ProcessStepTiming_M");

                entity.Property(e => e.ProcessStepTimingId).HasColumnName("ProcessStepTimingID");

                entity.Property(e => e.CreatedDt)
                    .HasColumnName("CreatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedUserId).HasColumnName("CreatedUserID");

                entity.Property(e => e.EndTime1)
                    .HasColumnName("EndTime_1")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.EndTime2)
                    .HasColumnName("EndTime_2")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.EndTime3)
                    .HasColumnName("EndTime_3")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.ProcessStepId).HasColumnName("ProcessStepID");

                entity.Property(e => e.StartTime1)
                    .HasColumnName("StartTime_1")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.StartTime2)
                    .HasColumnName("StartTime_2")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.StartTime3)
                    .HasColumnName("StartTime_3")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.TypeId).HasColumnName("TypeID");

                entity.Property(e => e.UpdatedDt)
                    .HasColumnName("UpdatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdatedUserId)
                    .HasColumnName("UpdatedUserID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.WeekdayId).HasColumnName("WeekdayID");
            });

            modelBuilder.Entity<PrdProcessWiseFieldGroupsD>(entity =>
            {
                entity.HasKey(e => e.ProcessWiseFieldGroupId);

                entity.ToTable("PRD_ProcessWiseFieldGroups_D");

                entity.Property(e => e.ProcessWiseFieldGroupId).HasColumnName("ProcessWiseFieldGroupID");

                entity.Property(e => e.CreatedDt)
                    .HasColumnName("CreatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedUserId).HasColumnName("CreatedUserID");

                entity.Property(e => e.FieldGroupId).HasColumnName("FieldGroupID");

                entity.Property(e => e.ProcessStepId).HasColumnName("ProcessStepID");

                entity.Property(e => e.UpdatedDt)
                    .HasColumnName("UpdatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdatedUserId).HasColumnName("UpdatedUserID");
            });

            modelBuilder.Entity<PrdProductByproduct>(entity =>
            {
                entity.HasKey(e => e.ProductByproductId);

                entity.ToTable("PRD_ProductByproduct");

                entity.Property(e => e.ProductByproductId).HasColumnName("ProductByproductID");

                entity.Property(e => e.ByproductCategoryId).HasColumnName("Byproduct_CategoryID");

                entity.Property(e => e.ByproductId).HasColumnName("ByproductID");

                entity.Property(e => e.ByproductSubcategoryId).HasColumnName("Byproduct_SubcategoryID");

                entity.Property(e => e.CreatedDt)
                    .HasColumnName("CreatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedUserId).HasColumnName("CreatedUserID");

                entity.Property(e => e.LocationId).HasColumnName("LocationID");

                entity.Property(e => e.MaterialId).HasColumnName("MaterialID");

                entity.Property(e => e.ProcessStepId).HasColumnName("ProcessStepID");

                entity.Property(e => e.RequiredByproductQtyDenominator).HasColumnName("RequiredByproduct_Qty_Denominator");

                entity.Property(e => e.RequiredByproductQtyDenominatorUnitId).HasColumnName("RequiredByproduct_Qty_Denominator_UnitID");

                entity.Property(e => e.RequiredByproductQtyNumerator).HasColumnName("RequiredByproduct_Qty_Numerator");

                entity.Property(e => e.RequiredByproductQtyNumeratorUnitId).HasColumnName("RequiredByproduct_Qty_Numerator_UnitID");

                entity.Property(e => e.UpdatedDt)
                    .HasColumnName("UpdatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdatedUserId).HasColumnName("UpdatedUserID");
            });

            modelBuilder.Entity<PrdProductFamilyProcessStepByproducts>(entity =>
            {
                entity.HasKey(e => e.ProductFamilyProcessStepByproductId);

                entity.ToTable("PRD_ProductFamily_ProcessStep_Byproducts");

                entity.Property(e => e.ProductFamilyProcessStepByproductId).HasColumnName("ProductFamily_ProcessStep_ByproductID");

                entity.Property(e => e.CreatedDt)
                    .HasColumnName("CreatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedUserId).HasColumnName("CreatedUserID");

                entity.Property(e => e.MaterialCategoryId).HasColumnName("MaterialCategoryID");

                entity.Property(e => e.MaterialId).HasColumnName("MaterialID");

                entity.Property(e => e.MaterialSubCategoryId).HasColumnName("MaterialSubCategoryID");

                entity.Property(e => e.ProcessStepId).HasColumnName("ProcessStepID");

                entity.Property(e => e.ProductFamilyProcessStepId).HasColumnName("ProductFamilyProcessStepID");

                entity.Property(e => e.QtyDenominator).HasColumnName("Qty_Denominator");

                entity.Property(e => e.QtyDenominatorUnitId).HasColumnName("Qty_Denominator_UnitID");

                entity.Property(e => e.QtyNumerator).HasColumnName("Qty_Numerator");

                entity.Property(e => e.QtyNumeratorUnitId).HasColumnName("Qty_Numerator_UnitID");

                entity.Property(e => e.SubCategoryId).HasColumnName("SubCategoryID");

                entity.Property(e => e.UpdatedDt)
                    .HasColumnName("UpdatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdatedUserId).HasColumnName("UpdatedUserID");
            });

            modelBuilder.Entity<PrdProductFamilyProcessStepCapacityD>(entity =>
            {
                entity.HasKey(e => e.ProductFamilyProcessStepCapacityId);

                entity.ToTable("PRD_ProductFamily_ProcessStep_Capacity_D");

                entity.Property(e => e.ProductFamilyProcessStepCapacityId).HasColumnName("ProductFamily_ProcessStep_CapacityID");

                entity.Property(e => e.ComplexityLevelId).HasColumnName("ComplexityLevelID");

                entity.Property(e => e.CreatedDt)
                    .HasColumnName("CreatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedUserId).HasColumnName("CreatedUserID");

                entity.Property(e => e.MinTimeHrs).HasColumnName("MinTime_Hrs");

                entity.Property(e => e.MinTimeMins).HasColumnName("MinTime_Mins");

                entity.Property(e => e.ProcessStepId).HasColumnName("ProcessStepID");

                entity.Property(e => e.ProductFamilyProcessStepId).HasColumnName("ProductFamilyProcessStepID");

                entity.Property(e => e.ProductionCapacityDenominator).HasColumnName("ProductionCapacity_Denominator");

                entity.Property(e => e.ProductionUnitId).HasColumnName("ProductionUnitID");

                entity.Property(e => e.ProductionUnitIdDenominator).HasColumnName("ProductionUnitID_Denominator");

                entity.Property(e => e.ReportingUnitCapacityDenominator).HasColumnName("ReportingUnitCapacity_Denominator");

                entity.Property(e => e.ReportingUnitId).HasColumnName("ReportingUnitID");

                entity.Property(e => e.ReportingUnitIdDenominator).HasColumnName("ReportingUnitID_Denominator");

                entity.Property(e => e.SetupTimeHrs).HasColumnName("SetupTime_Hrs");

                entity.Property(e => e.SetupTimeMins).HasColumnName("SetupTime_Mins");

                entity.Property(e => e.SubCategoryId).HasColumnName("SubCategoryID");

                entity.Property(e => e.UpdatedDt)
                    .HasColumnName("UpdatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdatedUserId).HasColumnName("UpdatedUserID");
            });

            modelBuilder.Entity<PrdProductFamilyProcessStepRawMaterials>(entity =>
            {
                entity.HasKey(e => e.ProductFamilyProcessStepRawMaterialId);

                entity.ToTable("PRD_ProductFamily_ProcessStep_RawMaterials");

                entity.Property(e => e.ProductFamilyProcessStepRawMaterialId).HasColumnName("ProductFamily_ProcessStep_RawMaterialID");

                entity.Property(e => e.CreatedDt)
                    .HasColumnName("CreatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedUserId).HasColumnName("CreatedUserID");

                entity.Property(e => e.IsRecoverableRawMaterial).HasColumnName("IsRecoverable_RawMaterial");

                entity.Property(e => e.MaterialCategoryId).HasColumnName("MaterialCategoryID");

                entity.Property(e => e.MaterialId).HasColumnName("MaterialID");

                entity.Property(e => e.MaterialSubCategoryId).HasColumnName("MaterialSubCategoryID");

                entity.Property(e => e.OutputSubCategroyId).HasColumnName("Output_SubCategroyID");

                entity.Property(e => e.ProcessStepId).HasColumnName("ProcessStepID");

                entity.Property(e => e.ProductFamilyProcessStepId).HasColumnName("ProductFamilyProcessStepID");

                entity.Property(e => e.QtyDenominator).HasColumnName("Qty_Denominator");

                entity.Property(e => e.QtyDenominatorUnitId).HasColumnName("Qty_Denominator_UnitID");

                entity.Property(e => e.QtyNumerator).HasColumnName("Qty_Numerator");

                entity.Property(e => e.QtyNumeratorUnitId).HasColumnName("Qty_Numerator_UnitID");

                entity.Property(e => e.SubCategoryId).HasColumnName("SubCategoryID");

                entity.Property(e => e.UpdatedDt)
                    .HasColumnName("UpdatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdatedUserId).HasColumnName("UpdatedUserID");
            });

            modelBuilder.Entity<PrdProductFamilyProcessSteps>(entity =>
            {
                entity.HasKey(e => e.ProductFamilyProcessStepId);

                entity.ToTable("PRD_ProductFamily_ProcessSteps");

                entity.Property(e => e.ProductFamilyProcessStepId).HasColumnName("ProductFamilyProcessStepID");

                entity.Property(e => e.CreatedDt)
                    .HasColumnName("CreatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedUserId).HasColumnName("CreatedUserID");

                entity.Property(e => e.DefaultInventoryRatePercentage)
                    .HasColumnName("DefaultInventoryRate_Percentage")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ExpFinalOutputQtyDenominator).HasColumnName("ExpFinalOutputQty_Denominator");

                entity.Property(e => e.ExpFinalOutputQtyUnitIdDenominator).HasColumnName("ExpFinalOutputQty_UnitID_Denominator");

                entity.Property(e => e.ExpMaterialCategoryId).HasColumnName("ExpMaterialCategoryID");

                entity.Property(e => e.ExpMaterialSubCategoryId).HasColumnName("ExpMaterialSubCategoryID");

                entity.Property(e => e.ExpProcessOutputQtyNumerator).HasColumnName("ExpProcessOutputQty_Numerator");

                entity.Property(e => e.ExpProcessOutputQtyUnitIdNumerator).HasColumnName("ExpProcessOutputQty_UnitID_Numerator");

                entity.Property(e => e.InspectionPolicy)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.IsFinishedProcessOutPut).HasColumnName("IsFinished_ProcessOutPut");

                entity.Property(e => e.IsGenerateByproduct).HasColumnName("IsGenerate_Byproduct");

                entity.Property(e => e.IsRequireRawMaterial).HasColumnName("IsRequire_RawMaterial");

                entity.Property(e => e.IsRequireSubAssembly).HasColumnName("IsRequire_SubAssembly");

                entity.Property(e => e.MaximumRejectionAllowPercentage).HasColumnName("MaximumRejectionAllow_Percentage");

                entity.Property(e => e.ProcessStepId).HasColumnName("ProcessStepID");

                entity.Property(e => e.SubCategoryId).HasColumnName("SubCategoryID");

                entity.Property(e => e.UpdatedDt)
                    .HasColumnName("UpdatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdatedUserId).HasColumnName("UpdatedUserID");
            });

            modelBuilder.Entity<PrdProductFamilyProcessStepSubAssemblies>(entity =>
            {
                entity.HasKey(e => e.ProductFamilyProcessStepSubAssemblyId);

                entity.ToTable("PRD_ProductFamily_ProcessStep_SubAssemblies");

                entity.Property(e => e.ProductFamilyProcessStepSubAssemblyId).HasColumnName("ProductFamily_ProcessStep_SubAssemblyID");

                entity.Property(e => e.CreatedDt)
                    .HasColumnName("CreatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedUserId).HasColumnName("CreatedUserID");

                entity.Property(e => e.MaterialCategoryId).HasColumnName("MaterialCategoryID");

                entity.Property(e => e.MaterialId).HasColumnName("MaterialID");

                entity.Property(e => e.MaterialSubCategoryId).HasColumnName("MaterialSubCategoryID");

                entity.Property(e => e.ProcessStepId).HasColumnName("ProcessStepID");

                entity.Property(e => e.ProductFamilyProcessStepId).HasColumnName("ProductFamilyProcessStepID");

                entity.Property(e => e.QtyDenominator).HasColumnName("Qty_Denominator");

                entity.Property(e => e.QtyDenominatorUnitId).HasColumnName("Qty_Denominator_UnitID");

                entity.Property(e => e.QtyNumerator).HasColumnName("Qty_Numerator");

                entity.Property(e => e.QtyNumeratorUnitId).HasColumnName("Qty_Numerator_UnitID");

                entity.Property(e => e.SubCategoryId).HasColumnName("SubCategoryID");

                entity.Property(e => e.UpdatedDt)
                    .HasColumnName("UpdatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdatedUserId).HasColumnName("UpdatedUserID");
            });

            modelBuilder.Entity<PrdProductMaterialUsageM>(entity =>
            {
                entity.HasKey(e => e.ProductMaterialUsageId);

                entity.ToTable("PRD_ProductMaterialUsage_M");

                entity.Property(e => e.ProductMaterialUsageId).HasColumnName("ProductMaterialUsageID");

                entity.Property(e => e.ActualExpQtyOld).HasColumnName("ActualExpQty_Old");

                entity.Property(e => e.BasisAreaUnitIdOld).HasColumnName("Basis_Area_UnitID_Old");

                entity.Property(e => e.BasisIdOld).HasColumnName("BasisID_Old");

                entity.Property(e => e.CreatedDt)
                    .HasColumnName("CreatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedUserId).HasColumnName("CreatedUserID");

                entity.Property(e => e.CustomerIdOld).HasColumnName("CustomerID_Old");

                entity.Property(e => e.DenominatorExpQty).HasColumnName("Denominator_ExpQty");

                entity.Property(e => e.DenominatorExpQtyUnitId).HasColumnName("Denominator_ExpQty_UnitID");

                entity.Property(e => e.DenominatorExpRecoverQty).HasColumnName("Denominator_Exp_RecoverQty");

                entity.Property(e => e.DenominatorExpRecoverQtyUnitId).HasColumnName("Denominator_Exp_RecoverQty_UnitID");

                entity.Property(e => e.Description)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.IsRecoverableRawMaterial).HasColumnName("IsRecoverable_RawMaterial");

                entity.Property(e => e.Location)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MaterialBrandId).HasColumnName("MaterialBrandID");

                entity.Property(e => e.MaterialId).HasColumnName("MaterialID");

                entity.Property(e => e.MaterialSubCategoryId).HasColumnName("MaterialSubCategoryID");

                entity.Property(e => e.MaterialSubCategoryProductTypeIdOld)
                    .HasColumnName("MaterialSubCategoryProductTypeID_Old")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.MaterialTypeId).HasColumnName("MaterialTypeID");

                entity.Property(e => e.NumeratorExpQty).HasColumnName("Numerator_ExpQty");

                entity.Property(e => e.NumeratorExpQtyUnitId).HasColumnName("Numerator_ExpQty_UnitID");

                entity.Property(e => e.NumeratorExpRecoverQty).HasColumnName("Numerator_Exp_RecoverQty");

                entity.Property(e => e.NumeratorExpRecoverQtyUnitId).HasColumnName("Numerator_Exp_RecoverQty_UnitID");

                entity.Property(e => e.ProcessStepId).HasColumnName("ProcessStepID");

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.Property(e => e.QtySunitIdOld)
                    .HasColumnName("Qty_SUnitID_Old")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.QtyUnitIdOld).HasColumnName("Qty_UnitID_Old");

                entity.Property(e => e.UpdatedDt)
                    .HasColumnName("UpdatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdatedUserId).HasColumnName("UpdatedUserID");

                entity.Property(e => e.VersionNum).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<PrdProductProcessFlow>(entity =>
            {
                entity.HasKey(e => e.ProductProcessFlowId);

                entity.ToTable("PRD_ProductProcessFlow");

                entity.Property(e => e.ProductProcessFlowId).HasColumnName("ProductProcessFlowID");

                entity.Property(e => e.CfOptmtlSkunitIdToProcessOptunitIdDenominator).HasColumnName("CF_OPTMtlSKUnitID_To_ProcessOPTUnitID_Denominator");

                entity.Property(e => e.CfOptmtlSkunitIdToProcessOptunitIdNumerator).HasColumnName("CF_OPTMtlSKUnitID_To_ProcessOPTUnitID_Numerator");

                entity.Property(e => e.CfOutPutUnitIdToReportingUnitIdDenominator).HasColumnName("CF_OutPutUnitID_To_ReportingUnitID_Denominator");

                entity.Property(e => e.CfOutPutUnitIdToReportingUnitIdNumerator).HasColumnName("CF_OutPutUnitID_To_ReportingUnitID_Numerator");

                entity.Property(e => e.ComplexityLevelId).HasColumnName("ComplexityLevelID");

                entity.Property(e => e.Costing).HasDefaultValueSql("((0))");

                entity.Property(e => e.CreatedDt)
                    .HasColumnName("CreatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedUserId).HasColumnName("CreatedUserID");

                entity.Property(e => e.DefaultInventoryRate).HasDefaultValueSql("((0))");

                entity.Property(e => e.ExpFinalOutputQtyDenominator).HasColumnName("ExpFinalOutputQty_Denominator");

                entity.Property(e => e.ExpFinalOutputQtyUnitIdDenominator).HasColumnName("ExpFinalOutputQty_UnitID_Denominator");

                entity.Property(e => e.ExpProcessOutputQtyNumerator).HasColumnName("ExpProcessOutputQty_Numerator");

                entity.Property(e => e.ExpProcessOutputQtyUnitIdNumerator).HasColumnName("ExpProcessOutputQty_UnitID_Numerator");

                entity.Property(e => e.InspectionPolicy)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.IsFinishedProcessOutPut).HasColumnName("IsFinished_ProcessOutPut");

                entity.Property(e => e.IsOutsourcePossible).HasColumnName("IsOutsource_Possible");

                entity.Property(e => e.LocationId).HasColumnName("LocationID");

                entity.Property(e => e.MaterialId).HasColumnName("MaterialID");

                entity.Property(e => e.MaximumRejectionAllowPercentage).HasColumnName("MaximumRejectionAllow_Percentage");

                entity.Property(e => e.MinimumTimeHours).HasColumnName("MinimumTime_Hours");

                entity.Property(e => e.MinimumTimeMinutes).HasColumnName("MinimumTime_Minutes");

                entity.Property(e => e.OutputMaterialId).HasColumnName("Output_MaterialID");

                entity.Property(e => e.OutputUnitId).HasColumnName("OutputUnitID");

                entity.Property(e => e.ProcessFlowOrder).HasColumnName("ProcessFlow_Order");

                entity.Property(e => e.ProcessOutputUnitId).HasColumnName("Process_OutputUnitID");

                entity.Property(e => e.ProcessReportingUnitId).HasColumnName("Process_ReportingUnitID");

                entity.Property(e => e.ProcessStepId).HasColumnName("ProcessStepID");

                entity.Property(e => e.ProcessingTimeValueVariableTime1).HasColumnName("ProcessingTimeValue_VariableTime1");

                entity.Property(e => e.ProcessingTimeValueVariableTime2).HasColumnName("ProcessingTimeValue_VariableTime2");

                entity.Property(e => e.ProductionUnitIdVariableTime1).HasColumnName("ProductionUnitID_VariableTime1");

                entity.Property(e => e.ProductionUnitIdVariableTime2).HasColumnName("ProductionUnitID_VariableTime2");

                entity.Property(e => e.QtyProductionUnitVariableTime1).HasColumnName("Qty_ProductionUnit_VariableTime1");

                entity.Property(e => e.QtyProductionUnitVariableTime2).HasColumnName("Qty_ProductionUnit_VariableTime2");

                entity.Property(e => e.RejectionUnitId).HasColumnName("RejectionUnitID");

                entity.Property(e => e.SetupTimeHours).HasColumnName("SetupTime_Hours");

                entity.Property(e => e.SetupTimeMinutes).HasColumnName("SetupTime_Minutes");

                entity.Property(e => e.TimeUnitIdVariableTime1).HasColumnName("TimeUnitID_VariableTime1");

                entity.Property(e => e.TimeUnitIdVariableTime2).HasColumnName("TimeUnitID_VariableTime2");

                entity.Property(e => e.UpdatedDt)
                    .HasColumnName("UpdatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdatedUserId).HasColumnName("UpdatedUserID");
            });

            modelBuilder.Entity<PrdProductSubAssemblies>(entity =>
            {
                entity.HasKey(e => e.ProductSubAssemblyId);

                entity.ToTable("PRD_ProductSubAssemblies");

                entity.Property(e => e.ProductSubAssemblyId).HasColumnName("ProductSubAssemblyID");

                entity.Property(e => e.CreatedDt)
                    .HasColumnName("CreatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedUserId).HasColumnName("CreatedUserID");

                entity.Property(e => e.IsLaunchOrderInParallel).HasColumnName("IsLaunchOrder_InParallel");

                entity.Property(e => e.MaterialId).HasColumnName("MaterialID");

                entity.Property(e => e.ProcessStepId).HasColumnName("ProcessStepID");

                entity.Property(e => e.RequiredSubAssemblyQtyDenominator).HasColumnName("RequiredSubAssembly_Qty_Denominator");

                entity.Property(e => e.RequiredSubAssemblyQtyDenominatorUnitId).HasColumnName("RequiredSubAssembly_Qty_Denominator_UnitID");

                entity.Property(e => e.RequiredSubAssemblyQtyNumerator).HasColumnName("RequiredSubAssembly_Qty_Numerator");

                entity.Property(e => e.RequiredSubAssemblyQtyNumeratorUnitId).HasColumnName("RequiredSubAssembly_Qty_Numerator_UnitID");

                entity.Property(e => e.SubAssemblyCategoryId).HasColumnName("SubAssembly_CategoryID");

                entity.Property(e => e.SubAssemblyId).HasColumnName("SubAssemblyID");

                entity.Property(e => e.SubAssemblySubcategoryId).HasColumnName("SubAssembly_SubcategoryID");

                entity.Property(e => e.UpdatedDt)
                    .HasColumnName("UpdatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdatedUserId).HasColumnName("UpdatedUserID");
            });

            modelBuilder.Entity<PrdRemediesM>(entity =>
            {
                entity.HasKey(e => e.RemediesId);

                entity.ToTable("PRD_Remedies_M");

                entity.Property(e => e.RemediesId).HasColumnName("RemediesID");

                entity.Property(e => e.CreatedDt)
                    .HasColumnName("CreatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedUserId).HasColumnName("CreatedUserID");

                entity.Property(e => e.IsCommon).HasDefaultValueSql("((1))");

                entity.Property(e => e.IsRemedyForRejection).HasDefaultValueSql("((1))");

                entity.Property(e => e.OutputTypeId)
                    .HasColumnName("OutputTypeID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.RemediesName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.RemedyTypeId)
                    .HasColumnName("RemedyTypeID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.UpdatedDt)
                    .HasColumnName("UpdatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdatedUserId).HasColumnName("UpdatedUserID");
            });

            modelBuilder.Entity<PrdResponsibleMaterialD>(entity =>
            {
                entity.HasKey(e => e.ResponsibleMaterialId);

                entity.ToTable("PRD_ResponsibleMaterial_D");

                entity.Property(e => e.ResponsibleMaterialId).HasColumnName("ResponsibleMaterialID");

                entity.Property(e => e.MaterialSubCategoryId).HasColumnName("MaterialSubCategoryID");

                entity.Property(e => e.OutputTypeId).HasColumnName("OutputTypeID");
            });

            modelBuilder.Entity<PrdWorkOrderD>(entity =>
            {
                entity.HasKey(e => e.WorkOrderDetId);

                entity.ToTable("PRD_WorkOrder_D");

                entity.Property(e => e.WorkOrderDetId).HasColumnName("WorkOrderDetID");

                entity.Property(e => e.CreatedDt)
                    .HasColumnName("CreatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedUserId).HasColumnName("CreatedUserID");

                entity.Property(e => e.JobCompleteDt)
                    .HasColumnName("JobCompleteDT")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.JobCompleteUserId).HasColumnName("JobCompleteUserID");

                entity.Property(e => e.JobStartDt)
                    .HasColumnName("JobStartDT")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.JobStartUserId).HasColumnName("JobStartUserID");

                entity.Property(e => e.OutputTypeCauseEmployeeId).HasColumnName("OutputTypeCause_EmployeeID");

                entity.Property(e => e.OutputTypeCauseMachineId).HasColumnName("OutputTypeCause_MachineID");

                entity.Property(e => e.OutputTypeCauseMaterialId).HasColumnName("OutputTypeCause_MaterialID");

                entity.Property(e => e.OutputTypeId).HasColumnName("OutputTypeID");

                entity.Property(e => e.ProcessStepId).HasColumnName("ProcessStepID");

                entity.Property(e => e.QtyInProcessOptunit)
                    .HasColumnName("Qty_In_ProcessOPTUnit")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.QtyInProductionQtyUnit)
                    .HasColumnName("Qty_In_ProductionQtyUnit")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.QtyInReportingUnit)
                    .HasColumnName("Qty_In_ReportingUnit")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.QtyInSkunit)
                    .HasColumnName("Qty_In_SKUnit")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.RemedyActionDt)
                    .HasColumnName("RemedyActionDT")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.RemedyId).HasColumnName("RemedyID");

                entity.Property(e => e.RespProcessStepId)
                    .HasColumnName("RespProcessStepID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.UpdatedDt)
                    .HasColumnName("UpdatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdatedUserId).HasColumnName("UpdatedUserID");

                entity.Property(e => e.WorkOrderId).HasColumnName("WorkOrderID");
            });

            modelBuilder.Entity<PrdWorkOrderEmpWorkHours>(entity =>
            {
                entity.HasKey(e => e.WorkOrderEmpWorkHoursId);

                entity.ToTable("PRD_WorkOrder_EmpWorkHours");

                entity.Property(e => e.WorkOrderEmpWorkHoursId).HasColumnName("WorkOrderEmpWorkHoursID");

                entity.Property(e => e.CreatedDt)
                    .HasColumnName("CreatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedUserId)
                    .HasColumnName("CreatedUserID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.EmployeeId)
                    .HasColumnName("EmployeeID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.EndTime).HasColumnType("smalldatetime");

                entity.Property(e => e.HourCost).HasDefaultValueSql("((0))");

                entity.Property(e => e.ProcessStepId)
                    .HasColumnName("ProcessStepID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.StartTime).HasColumnType("smalldatetime");

                entity.Property(e => e.Status).HasDefaultValueSql("((0))");

                entity.Property(e => e.TotalCost).HasDefaultValueSql("((0))");

                entity.Property(e => e.UpdatedDt)
                    .HasColumnName("UpdatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdatedUserId)
                    .HasColumnName("UpdatedUserID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.WorkHours).HasColumnType("smalldatetime");

                entity.Property(e => e.WorkOrderId)
                    .HasColumnName("WorkOrderID")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<PrdWorkOrderFieldD>(entity =>
            {
                entity.HasKey(e => e.WorkOrderFieldDetId);

                entity.ToTable("PRD_WorkOrderField_D");

                entity.Property(e => e.WorkOrderFieldDetId).HasColumnName("WorkOrderFieldDetID");

                entity.Property(e => e.CreatedDt)
                    .HasColumnName("CreatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedUserId).HasColumnName("CreatedUserID");

                entity.Property(e => e.FieldGroupId).HasColumnName("FieldGroupID");

                entity.Property(e => e.FieldId).HasColumnName("FieldID");

                entity.Property(e => e.FieldValue)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.FieldValueId)
                    .HasColumnName("FieldValueID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ObservedFieldValue1)
                    .HasColumnName("ObservedFieldValue_1")
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ObservedFieldValue2)
                    .HasColumnName("ObservedFieldValue_2")
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ObservedFieldValue3)
                    .HasColumnName("ObservedFieldValue_3")
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ObservedFieldValueId1)
                    .HasColumnName("ObservedFieldValueID_1")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ObservedFieldValueId2)
                    .HasColumnName("ObservedFieldValueID_2")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ObservedFieldValueId3)
                    .HasColumnName("ObservedFieldValueID_3")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.Property(e => e.UpdatedDt)
                    .HasColumnName("UpdatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdatedUserId).HasColumnName("UpdatedUserID");

                entity.Property(e => e.WorkOrderId).HasColumnName("WorkOrderID");
            });

            modelBuilder.Entity<PrdWorkOrderFinishedGoodD>(entity =>
            {
                entity.HasKey(e => e.WorkOrderFinishedGoodDetId);

                entity.ToTable("PRD_WorkOrder_FinishedGood_D");

                entity.Property(e => e.WorkOrderFinishedGoodDetId).HasColumnName("WorkOrderFinishedGoodDetID");

                entity.Property(e => e.CompletedTillProcessId)
                    .HasColumnName("CompletedTillProcessID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CreatedDt)
                    .HasColumnName("CreatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedUserId).HasColumnName("CreatedUserID");

                entity.Property(e => e.FinishedGoodsQtyInPoaunit).HasColumnName("FinishedGoodsQty_In_POAUnit");

                entity.Property(e => e.FinishedGoodsQtyInProcessOptunit).HasColumnName("FinishedGoodsQty_In_ProcessOPTUnit");

                entity.Property(e => e.FinishedGoodsQtyInProcessReportingUnit).HasColumnName("FinishedGoodsQty_In_ProcessReportingUnit");

                entity.Property(e => e.FinishedGoodsQtyInProductionQtyUnit).HasColumnName("FinishedGoodsQty_In_ProductionQtyUnit");

                entity.Property(e => e.FinishedGoodsQtyInReportingUnitIdOld).HasColumnName("FinishedGoodsQty_In_ReportingUnitID_Old");

                entity.Property(e => e.FinishedGoodsQtyInSkunit).HasColumnName("FinishedGoodsQty_In_SKUnit");

                entity.Property(e => e.FinishedGoodsQtyUnitId).HasColumnName("FinishedGoodsQty_UnitID");

                entity.Property(e => e.LocationId).HasColumnName("LocationID");

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.Property(e => e.StoreLocationId).HasColumnName("StoreLocationID");

                entity.Property(e => e.WorkOrderId).HasColumnName("WorkOrderID");
            });

            modelBuilder.Entity<PrdWorkOrderGroupM>(entity =>
            {
                entity.HasKey(e => e.WorkOrderGroupId);

                entity.ToTable("PRD_WorkOrderGroup_M");

                entity.Property(e => e.WorkOrderGroupId).HasColumnName("WorkOrderGroupID");

                entity.Property(e => e.CreatedDt)
                    .HasColumnName("CreatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedUserId).HasColumnName("CreatedUserID");

                entity.Property(e => e.CustomerId).HasColumnName("CustomerID");

                entity.Property(e => e.CustomersForSearch)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.CustomersToShow)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Notes)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ParentWorkOrderGroupId).HasColumnName("ParentWorkOrderGroupID");

                entity.Property(e => e.PoaunitId).HasColumnName("POAUnitID");

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.Property(e => e.ProductionQtyUnitId).HasColumnName("ProductionQtyUnitID");

                entity.Property(e => e.ReportingUnitId).HasColumnName("ReportingUnitID");

                entity.Property(e => e.SkunitId).HasColumnName("SKUnitID");

                entity.Property(e => e.UpdatedDt)
                    .HasColumnName("UpdatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdatedUserId).HasColumnName("UpdatedUserID");

                entity.Property(e => e.WorkOrderQtyInPoaunit)
                    .HasColumnName("WorkOrderQty_In_POAUnit")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.WorkOrderQtyInProductionQtyUnit)
                    .HasColumnName("WorkOrderQty_In_ProductionQtyUnit")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.WorkOrderQtyInReportingUnitOld)
                    .HasColumnName("WorkOrderQty_In_ReportingUnit_Old")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.WorkOrderQtyInSkunit)
                    .HasColumnName("WorkOrderQty_In_SKUnit")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<PrdWorkOrderM>(entity =>
            {
                entity.HasKey(e => e.WorkOrderId);

                entity.ToTable("PRD_WorkOrder_M");

                entity.Property(e => e.WorkOrderId).HasColumnName("WorkOrderID");

                entity.Property(e => e.AcceptableProcessFlowId)
                    .HasColumnName("AcceptableProcessFlowID")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.BatchNo)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CfSkunitIdToPoaunitIdDenominator)
                    .HasColumnName("CF_SKUnitID_To_POAUnitID_Denominator")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CfSkunitIdToPoaunitIdNumerator)
                    .HasColumnName("CF_SKUnitID_To_POAUnitID_Numerator")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CfSkunitIdToProdQtyUnitIdDenominator)
                    .HasColumnName("CF_SKUnitID_To_ProdQtyUnitID_Denominator")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CfSkunitIdToProdQtyUnitIdNumerator)
                    .HasColumnName("CF_SKUnitID_To_ProdQtyUnitID_Numerator")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CfSkunitIdToReportingUnitIdDenominator)
                    .HasColumnName("CF_SKUnitID_To_ReportingUnitID_Denominator")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CfSkunitIdToReportingUnitIdNumerator)
                    .HasColumnName("CF_SKUnitID_To_ReportingUnitID_Numerator")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CompletedQtyInPoaunit)
                    .HasColumnName("CompletedQty_In_POAUnit")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CompletedQtyInProductionQtyUnit)
                    .HasColumnName("CompletedQty_In_ProductionQtyUnit")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CompletedQtyInReportingUnitOld)
                    .HasColumnName("CompletedQty_In_ReportingUnit_Old")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CompletedQtyInSkunit)
                    .HasColumnName("CompletedQty_In_SKUnit")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CreatedDt)
                    .HasColumnName("CreatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedUserId).HasColumnName("CreatedUserID");

                entity.Property(e => e.CurrentProcessStepId)
                    .HasColumnName("CurrentProcessStepID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CurrentProcessStepName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CurrentProcessSteps)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ExpCloseDt)
                    .HasColumnName("ExpCloseDT")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.ExpStartDt)
                    .HasColumnName("ExpStartDT")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.IsCompletedWorkOrder).HasColumnName("IsCompleted_WorkOrder");

                entity.Property(e => e.IsIgnoredRelaunch).HasColumnName("IsIgnored_Relaunch");

                entity.Property(e => e.IsInActiveWorkOrder).HasColumnName("IsInActive_WorkOrder");

                entity.Property(e => e.IsProdQtyUnitSameAsSkunit).HasColumnName("IsProdQtyUnit_SameAs_SKUnit");

                entity.Property(e => e.IsRelationExistForSkunitToProdQtyUnit).HasColumnName("IsRelation_Exist_For_SKUnit_To_ProdQtyUnit");

                entity.Property(e => e.IsSentDelayAlert).HasColumnName("IsSent_DelayAlert");

                entity.Property(e => e.IsUnStartedWorkOrder).HasColumnName("IsUnStarted_WorkOrder");

                entity.Property(e => e.IssuedDt)
                    .HasColumnName("IssuedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IssuedUserId).HasColumnName("IssuedUserID");

                entity.Property(e => e.JobNum)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.JobType)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.LowProductionQtyInPoaunit)
                    .HasColumnName("LowProductionQty_In_POAUnit")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.LowProductionQtyInProductionQtyUnit)
                    .HasColumnName("LowProductionQty_In_ProductionQtyUnit")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.LowProductionQtyInReportingUnitOld)
                    .HasColumnName("LowProductionQty_In_ReportingUnit_Old")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.LowProductionQtyInSkunit)
                    .HasColumnName("LowProductionQty_In_SKUnit")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.MaterialSubCategoryId).HasColumnName("MaterialSubCategoryID");

                entity.Property(e => e.NewExpCloseDt)
                    .HasColumnName("NewExpCloseDT")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.ParentProcessStepId)
                    .HasColumnName("ParentProcessStepID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ParentWorkOrderGroupId)
                    .HasColumnName("ParentWorkOrderGroupID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.PlantId)
                    .HasColumnName("PlantID")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.PoaunitId).HasColumnName("POAUnitID");

                entity.Property(e => e.Priority).HasDefaultValueSql("((3))");

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.Property(e => e.ProductionQtyUnitId).HasColumnName("ProductionQtyUnitID");

                entity.Property(e => e.ProposedLaunchDt)
                    .HasColumnName("ProposedLaunchDT")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.ReceivedInStoreQtyInPoaunit)
                    .HasColumnName("ReceivedInStoreQty_In_POAUnit")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ReceivedInStoreQtyInProductionQtyUnit)
                    .HasColumnName("ReceivedInStoreQty_In_ProductionQtyUnit")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ReceivedInStoreQtyInReportingUnitOld)
                    .HasColumnName("ReceivedInStoreQty_In_ReportingUnit_Old")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ReceivedInStoreQtyInSkunit)
                    .HasColumnName("ReceivedInStoreQty_In_SKUnit")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.RejectedQtyInPoaunit)
                    .HasColumnName("RejectedQty_In_POAUnit")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.RejectedQtyInProductionQtyUnit)
                    .HasColumnName("RejectedQty_In_ProductionQtyUnit")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.RejectedQtyInReportingUnitOld)
                    .HasColumnName("RejectedQty_In_ReportingUnit_Old")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.RejectedQtyInSkunit)
                    .HasColumnName("RejectedQty_In_SKUnit")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.RelaunchReason)
                    .IsRequired()
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.RelaunchWorkOrderId)
                    .HasColumnName("RelaunchWorkOrderID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.RelevantPodates)
                    .HasColumnName("RelevantPODates")
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.RelevantPoqty)
                    .HasColumnName("RelevantPOQty")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.RelevantPos)
                    .HasColumnName("RelevantPOs")
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ReportingUnitId).HasColumnName("ReportingUnitID");

                entity.Property(e => e.SkunitId).HasColumnName("SKUnitID");

                entity.Property(e => e.TargetComplnDt)
                    .HasColumnName("TargetComplnDT")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.TargetStartDt)
                    .HasColumnName("TargetStartDT")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.UpdatedDt)
                    .HasColumnName("UpdatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdatedUserId).HasColumnName("UpdatedUserID");

                entity.Property(e => e.VersionNum).HasDefaultValueSql("((1))");

                entity.Property(e => e.WoFirstCompletedDt)
                    .HasColumnName("WO_First_CompletedDT")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.WoLastCompletedDt)
                    .HasColumnName("WO_Last_CompletedDT")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.WoStartedDt)
                    .HasColumnName("WO_StartedDT")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.WoWarningQtyInPoaunit)
                    .HasColumnName("WO_WarningQty_In_POAUnit")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.WoWarningQtyInProdQtyUnit)
                    .HasColumnName("WO_WarningQty_In_ProdQtyUnit")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.WoWarningQtyInSkunit)
                    .HasColumnName("WO_WarningQty_In_SKUnit")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.WorkOrderGroupId)
                    .HasColumnName("WorkOrderGroupID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.WorkOrderNum)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.WorkOrderQtyInPoaunit)
                    .HasColumnName("WorkOrderQty_In_POAUnit")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.WorkOrderQtyInProductionQtyUnit)
                    .HasColumnName("WorkOrderQty_In_ProductionQtyUnit")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.WorkOrderQtyInReportingUnitOld)
                    .HasColumnName("WorkOrderQty_In_ReportingUnit_Old")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.WorkOrderQtyInSkunit)
                    .HasColumnName("WorkOrderQty_In_SKUnit")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<PrdWorkOrderMachineD>(entity =>
            {
                entity.HasKey(e => e.WorkOrderMachineDetId);

                entity.ToTable("PRD_WorkOrderMachine_D");

                entity.Property(e => e.WorkOrderMachineDetId).HasColumnName("WorkOrderMachineDetID");

                entity.Property(e => e.CreatedDt)
                    .HasColumnName("CreatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedUserId).HasColumnName("CreatedUserID");

                entity.Property(e => e.MachineId).HasColumnName("MachineID");

                entity.Property(e => e.MachineUsageInProcessOutputUnit)
                    .HasColumnName("MachineUsage_In_ProcessOutputUnit")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ProcessStepId).HasColumnName("ProcessStepID");

                entity.Property(e => e.RoleInPercentage).HasColumnName("Role_In_Percentage");

                entity.Property(e => e.WorkDoneQtyInProductionQtyUnit).HasColumnName("WorkDoneQty_In_ProductionQtyUnit");

                entity.Property(e => e.WorkDoneQtyInReportingUnit).HasColumnName("WorkDoneQty_In_ReportingUnit");

                entity.Property(e => e.WorkDoneQtyInSkunit).HasColumnName("WorkDoneQty_In_SKUnit");

                entity.Property(e => e.WorkOrderDetId)
                    .HasColumnName("WorkOrderDetID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.WorkOrderId).HasColumnName("WorkOrderID");
            });

            modelBuilder.Entity<PrdWorkOrderMaterialD>(entity =>
            {
                entity.HasKey(e => e.WorkOrderMaterialDetId);

                entity.ToTable("PRD_WorkOrderMaterial_D");

                entity.Property(e => e.WorkOrderMaterialDetId).HasColumnName("WorkOrderMaterialDetID");

                entity.Property(e => e.ActualExpProductionQty).HasColumnName("Actual_Exp_ProductionQty");

                entity.Property(e => e.ActualExpQtyMaterialUsage).HasColumnName("Actual_ExpQty_MaterialUsage");

                entity.Property(e => e.ActualExpQtyMaterialUsageUnitId).HasColumnName("Actual_ExpQty_MaterialUsage_UnitID");

                entity.Property(e => e.ActualProductionQty).HasColumnName("Actual_ProductionQty");

                entity.Property(e => e.ActualUsedQtyMaterialUsage)
                    .HasColumnName("Actual_UsedQty_MaterialUsage")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CompletedTillProcessId)
                    .HasColumnName("CompletedTillProcessID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CreatedDt)
                    .HasColumnName("CreatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedUserId).HasColumnName("CreatedUserID");

                entity.Property(e => e.DefaultInventoryRate).HasDefaultValueSql("((0))");

                entity.Property(e => e.DenominatorExpProductionQty).HasColumnName("Denominator_Exp_ProductionQty");

                entity.Property(e => e.DenominatorExpProductionQtyUnitId).HasColumnName("Denominator_Exp_ProductionQty_UnitID");

                entity.Property(e => e.DenominatorExpQty).HasColumnName("Denominator_ExpQty");

                entity.Property(e => e.DenominatorExpQtyUnitId).HasColumnName("Denominator_ExpQty_UnitID");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ExpQtyMaterialUsagePerProcessOutputQty).HasColumnName("ExpQty_MaterialUsage_Per_ProcessOutputQty");

                entity.Property(e => e.IsRecoverableRawMaterial).HasColumnName("IsRecoverable_RawMaterial");

                entity.Property(e => e.IssuedQty).HasDefaultValueSql("((0))");

                entity.Property(e => e.Location)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.MaterialBrandId)
                    .HasColumnName("MaterialBrandID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.MaterialCategoryId).HasColumnName("MaterialCategoryID");

                entity.Property(e => e.MaterialId).HasColumnName("MaterialID");

                entity.Property(e => e.MaterialSubCategoryId).HasColumnName("MaterialSubCategoryID");

                entity.Property(e => e.NumeratorExpProductionQty).HasColumnName("Numerator_Exp_ProductionQty");

                entity.Property(e => e.NumeratorExpProductionQtyUnitId).HasColumnName("Numerator_Exp_ProductionQty_UnitID");

                entity.Property(e => e.NumeratorExpQty).HasColumnName("Numerator_ExpQty");

                entity.Property(e => e.NumeratorExpQtyUnitId).HasColumnName("Numerator_ExpQty_UnitID");

                entity.Property(e => e.OriginalExpProductionQty).HasColumnName("Original_Exp_ProductionQty");

                entity.Property(e => e.OriginalExpQtyMaterialUsage).HasColumnName("Original_ExpQty_MaterialUsage");

                entity.Property(e => e.ProcessStepId)
                    .HasColumnName("ProcessStepID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ProductByProductId)
                    .HasColumnName("ProductByProductID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ProductMaterialUsageId)
                    .HasColumnName("ProductMaterialUsageID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ProductSubAssemblyId)
                    .HasColumnName("ProductSubAssemblyID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.RemainingActualExpProductionQty).HasColumnName("Remaining_Actual_Exp_ProductionQty");

                entity.Property(e => e.RemainingActualExpQtyMaterialUsage).HasColumnName("Remaining_Actual_ExpQty_MaterialUsage");

                entity.Property(e => e.TransferredToOtherJobQty).HasDefaultValueSql("((0))");

                entity.Property(e => e.UpdatedDt)
                    .HasColumnName("UpdatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdatedUserId).HasColumnName("UpdatedUserID");

                entity.Property(e => e.WorkOrderId)
                    .HasColumnName("WorkOrderID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.WorkOrderQtyInPoaunit)
                    .HasColumnName("WorkOrderQty_In_POAUnit")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.WorkOrderQtyInProductionQtyUnit)
                    .HasColumnName("WorkOrderQty_In_ProductionQtyUnit")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.WorkOrderQtyInSkunit)
                    .HasColumnName("WorkOrderQty_In_SKUnit")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<PrdWorkOrderMaterialDetailLogD>(entity =>
            {
                entity.HasKey(e => e.WomaterialDetailLogId);

                entity.ToTable("PRD_WorkOrderMaterialDetailLog_D");

                entity.Property(e => e.WomaterialDetailLogId).HasColumnName("WOMaterialDetailLogID");

                entity.Property(e => e.BatchNoId)
                    .HasColumnName("BatchNo_ID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.BrandId)
                    .HasColumnName("BrandID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CreatedDt)
                    .HasColumnName("CreatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedUserId)
                    .HasColumnName("CreatedUserID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.IssuedQty).HasDefaultValueSql("((0))");

                entity.Property(e => e.MaterialId).HasColumnName("MaterialID");

                entity.Property(e => e.MaterialIssueDetailId)
                    .HasColumnName("MaterialIssueDetailID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ProductionQty).HasDefaultValueSql("((0))");

                entity.Property(e => e.Rate).HasDefaultValueSql("((0))");

                entity.Property(e => e.ReceivedInStoreQty).HasDefaultValueSql("((0))");

                entity.Property(e => e.TransferredToOtherJobQty).HasDefaultValueSql("((0))");

                entity.Property(e => e.UpdatedDt)
                    .HasColumnName("UpdatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdatedUserId)
                    .HasColumnName("UpdatedUserID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.UsedQty).HasDefaultValueSql("((0))");

                entity.Property(e => e.WorkOrderId).HasColumnName("WorkOrderID");

                entity.Property(e => e.WorkOrderMaterialDetId)
                    .HasColumnName("WorkOrderMaterialDetID")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<PrdWorkOrderMaterialRecoverD>(entity =>
            {
                entity.HasKey(e => e.WorkOrderMaterialRecoverDetId);

                entity.ToTable("PRD_WorkOrderMaterialRecover_D");

                entity.Property(e => e.WorkOrderMaterialRecoverDetId).HasColumnName("WorkOrderMaterialRecoverDetID");

                entity.Property(e => e.CreatedDt)
                    .HasColumnName("CreatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedUserId)
                    .HasColumnName("CreatedUserID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.IssueUnitId).HasColumnName("IssueUnitID");

                entity.Property(e => e.MaterialId).HasColumnName("MaterialID");

                entity.Property(e => e.ProcessStepId).HasColumnName("ProcessStepID");

                entity.Property(e => e.UpdatedDt)
                    .HasColumnName("UpdatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdatedUserId)
                    .HasColumnName("UpdatedUserID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.WorkOrderId).HasColumnName("WorkOrderID");
            });

            modelBuilder.Entity<PrdWorkOrderMaterialTransferD>(entity =>
            {
                entity.HasKey(e => e.WorkOrderMaterialTransferDetId);

                entity.ToTable("PRD_WorkOrderMaterial_Transfer_D");

                entity.Property(e => e.WorkOrderMaterialTransferDetId).HasColumnName("WorkOrderMaterialTransferDetID");

                entity.Property(e => e.CreatedDt)
                    .HasColumnName("CreatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedUserId).HasColumnName("CreatedUserID");

                entity.Property(e => e.MaterialTransferredQty).HasColumnName("Material_TransferredQty");

                entity.Property(e => e.MaterialTransferredQtyUnitId).HasColumnName("Material_TransferredQty_UnitID");

                entity.Property(e => e.TransferredToProcessStepId).HasColumnName("Transferred_To_ProcessStepID");

                entity.Property(e => e.TransferredToWorkOrderMaterialDetId).HasColumnName("Transferred_To_WorkOrderMaterialDetID");

                entity.Property(e => e.WorkOrderMaterialDetId).HasColumnName("WorkOrderMaterialDetID");
            });

            modelBuilder.Entity<PrdWorkOrderMultiValueFieldD>(entity =>
            {
                entity.HasKey(e => e.WorkOrderMultiValueFieldDetId);

                entity.ToTable("PRD_WorkOrder_MultiValue_Field_D");

                entity.Property(e => e.WorkOrderMultiValueFieldDetId).HasColumnName("WorkOrder_MultiValueFieldDetID");

                entity.Property(e => e.CreatedDt)
                    .HasColumnName("CreatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedUserId).HasColumnName("CreatedUserID");

                entity.Property(e => e.FieldGroupId).HasColumnName("FieldGroupID");

                entity.Property(e => e.FieldId).HasColumnName("FieldID");

                entity.Property(e => e.FieldValue)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.FieldValueId)
                    .HasColumnName("FieldValueID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ObservedFieldValue1)
                    .HasColumnName("ObservedFieldValue_1")
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ObservedFieldValue2)
                    .HasColumnName("ObservedFieldValue_2")
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ObservedFieldValue3)
                    .HasColumnName("ObservedFieldValue_3")
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ObservedFieldValueId1)
                    .HasColumnName("ObservedFieldValueID_1")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ObservedFieldValueId2)
                    .HasColumnName("ObservedFieldValueID_2")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ObservedFieldValueId3)
                    .HasColumnName("ObservedFieldValueID_3")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.Property(e => e.SrNoRow).HasColumnName("SrNo_Row");

                entity.Property(e => e.UpdatedDt)
                    .HasColumnName("UpdatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdatedUserId).HasColumnName("UpdatedUserID");

                entity.Property(e => e.WorkOrderId).HasColumnName("WorkOrderID");
            });

            modelBuilder.Entity<PrdWorkOrderNotes>(entity =>
            {
                entity.HasKey(e => e.WorkOrderNoteId);

                entity.ToTable("PRD_WorkOrderNotes");

                entity.Property(e => e.WorkOrderNoteId).HasColumnName("WorkOrderNoteID");

                entity.Property(e => e.CreatedDt)
                    .HasColumnName("CreatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedUserId).HasColumnName("CreatedUserID");

                entity.Property(e => e.Note)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ProcessStepId).HasColumnName("ProcessStepID");

                entity.Property(e => e.UpdatedDt)
                    .HasColumnName("UpdatedDT")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.UpdatedUserId).HasColumnName("UpdatedUserID");

                entity.Property(e => e.WorkOrderId).HasColumnName("WorkOrderID");

                entity.Property(e => e.WorkOrderProcessId).HasColumnName("WorkOrderProcessID");
            });

            modelBuilder.Entity<PrdWorkOrderPauses>(entity =>
            {
                entity.HasKey(e => e.WorkOrderPausesId);

                entity.ToTable("PRD_WorkOrderPauses");

                entity.Property(e => e.WorkOrderPausesId).HasColumnName("WorkOrderPausesID");

                entity.Property(e => e.CreatedDt)
                    .HasColumnName("CreatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedUserId).HasColumnName("CreatedUserID");

                entity.Property(e => e.PauseDt)
                    .HasColumnName("PauseDT")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.PauseUserId).HasColumnName("PauseUserID");

                entity.Property(e => e.ProcessStepId).HasColumnName("ProcessStepID");

                entity.Property(e => e.ResumeDt)
                    .HasColumnName("ResumeDT")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.ResumeUserId).HasColumnName("ResumeUserID");

                entity.Property(e => e.UpdatedDt)
                    .HasColumnName("UpdatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdatedUserId).HasColumnName("UpdatedUserID");

                entity.Property(e => e.WorkOrderId).HasColumnName("WorkOrderID");
            });

            modelBuilder.Entity<PrdWorkOrderPlan>(entity =>
            {
                entity.HasKey(e => e.WorkOrderPlanId);

                entity.ToTable("PRD_WorkOrderPlan");

                entity.Property(e => e.WorkOrderPlanId).HasColumnName("WorkOrderPlanID");

                entity.Property(e => e.CreatedDt)
                    .HasColumnName("CreatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedUserId)
                    .HasColumnName("CreatedUserID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ExpArrDt)
                    .HasColumnName("ExpArrDT")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.ExpCloseDt)
                    .HasColumnName("ExpCloseDT")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.ExpProcessTimeMinutes)
                    .HasColumnName("ExpProcessTime_Minutes")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ExpStartDt)
                    .HasColumnName("ExpStartDT")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.JobStartDt)
                    .HasColumnName("JobStartDT")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.MachineId)
                    .HasColumnName("MachineID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ProcessStepId).HasColumnName("ProcessStepID");

                entity.Property(e => e.Qty).HasDefaultValueSql("((0))");

                entity.Property(e => e.UpdatedDt)
                    .HasColumnName("UpdatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdatedUserId)
                    .HasColumnName("UpdatedUserID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.WoprocessOrder)
                    .HasColumnName("WOProcess_Order")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.WorkOrderId).HasColumnName("WorkOrderID");

                entity.Property(e => e.WorkOrderProcessId).HasColumnName("WorkOrderProcessID");
            });

            modelBuilder.Entity<PrdWorkOrderPos>(entity =>
            {
                entity.HasKey(e => e.WorkOrderPoid);

                entity.ToTable("PRD_WorkOrderPOs");

                entity.Property(e => e.WorkOrderPoid).HasColumnName("WorkOrderPOID");

                entity.Property(e => e.CompletedQtyInPoaunit)
                    .HasColumnName("CompletedQty_In_POAUnit")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CompletedQtyInProductionQtyUnit)
                    .HasColumnName("CompletedQty_In_ProductionQtyUnit")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CompletedQtyInSkunit)
                    .HasColumnName("CompletedQty_In_SKUnit")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CreatedDt)
                    .HasColumnName("CreatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.LowProductionQtyInPoaunit)
                    .HasColumnName("LowProductionQty_In_POAunit")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.LowProductionQtyInProductionQtyUnit)
                    .HasColumnName("LowProductionQty_In_ProductionQtyUnit")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.LowProductionQtyInSkunit)
                    .HasColumnName("LowProductionQty_In_SKUnit")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Poid).HasColumnName("POID");

                entity.Property(e => e.PoitemId).HasColumnName("POItemID");

                entity.Property(e => e.PoitemQtyInPoaunit)
                    .HasColumnName("POItemQty_In_POAUnit")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.PoitemQtyInSkunit)
                    .HasColumnName("POItemQty_In_SKUnit")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.PriorityForRejection).HasDefaultValueSql("((0))");

                entity.Property(e => e.QtyInProcessInPoaunit)
                    .HasColumnName("QtyInProcess_In_POAUnit")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.QtyInProcessInProductionQtyUnit)
                    .HasColumnName("QtyInProcess_In_ProductionQtyUnit")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.QtyInProcessInSkunit)
                    .HasColumnName("QtyInProcess_In_SKUnit")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ReceivedInStoreQtyInPoaunit)
                    .HasColumnName("ReceivedInStoreQty_In_POAUnit")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ReceivedInStoreQtyInProductionQtyUnit)
                    .HasColumnName("ReceivedInStoreQty_In_ProductionQtyUnit")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ReceivedInStoreQtyInSkunit)
                    .HasColumnName("ReceivedInStoreQty_In_SKUnit")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.RejectedQtyInPoaunit)
                    .HasColumnName("RejectedQty_In_POAUnit")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.RejectedQtyInProductionQtyUnit)
                    .HasColumnName("RejectedQty_In_ProductionQtyUnit")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.RejectedQtyInSkunit)
                    .HasColumnName("RejectedQty_In_SKUnit")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TargetQtyInPoaunit)
                    .HasColumnName("TargetQty_In_POAUnit")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TargetQtyInSkunit)
                    .HasColumnName("TargetQty_In_SKUnit")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.UpdatedDt)
                    .HasColumnName("UpdatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.WorkOrderGroupId)
                    .HasColumnName("WorkOrderGroupID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.WorkOrderQtyInPoaunit)
                    .HasColumnName("WorkOrderQty_In_POAUnit")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.WorkOrderQtyInProductionQtyUnit)
                    .HasColumnName("WorkOrderQty_In_ProductionQtyUnit")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.WorkOrderQtyInSkunit)
                    .HasColumnName("WorkOrderQty_In_SKUnit")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<PrdWorkOrderProcesses>(entity =>
            {
                entity.HasKey(e => e.WorkOrderProcessId);

                entity.ToTable("PRD_WorkOrderProcesses");

                entity.Property(e => e.WorkOrderProcessId).HasColumnName("WorkOrderProcessID");

                entity.Property(e => e.CfProcessOutPutUnitIdToReportingUnitIdDenominator)
                    .HasColumnName("CF_ProcessOutPutUnitID_To_ReportingUnitID_Denominator")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CfProcessOutputUnitIdToReportingUnitIdNumerator)
                    .HasColumnName("CF_ProcessOutputUnitID_To_ReportingUnitID_Numerator")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CfSkunitIdToProdQtyUnitIdDenominator)
                    .HasColumnName("CF_SKUnitID_To_ProdQtyUnitID_Denominator")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CfSkunitIdToProdQtyUnitIdNumerator)
                    .HasColumnName("CF_SKUnitID_To_ProdQtyUnitID_Numerator")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CfSkunitIdToReportingUnitIdDenominator)
                    .HasColumnName("CF_SKUnitID_To_ReportingUnitID_Denominator")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CfSkunitIdToReportingUnitIdNumerator)
                    .HasColumnName("CF_SKUnitID_To_ReportingUnitID_Numerator")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CfWopskunitIdToProcessOptunitIdDenominator).HasColumnName("CF_WOPSKUnitID_To_ProcessOPTUnitID_Denominator");

                entity.Property(e => e.CfWopskunitIdToProcessOptunitIdNumerator).HasColumnName("CF_WOPSKUnitID_To_ProcessOPTUnitID_Numerator");

                entity.Property(e => e.ComplexityLevelId).HasColumnName("ComplexityLevelID");

                entity.Property(e => e.CreatedDt)
                    .HasColumnName("CreatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedUserId).HasColumnName("CreatedUserID");

                entity.Property(e => e.DoneQtyInProcessOptunit)
                    .HasColumnName("DoneQty_In_ProcessOPTUnit")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.DoneQtyInProductionQtyUnit)
                    .HasColumnName("DoneQty_In_ProductionQtyUnit")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.DoneQtyInReportingUnit)
                    .HasColumnName("DoneQty_In_ReportingUnit")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.DoneQtyInSkunit)
                    .HasColumnName("DoneQty_In_SKUnit")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ExpArrivalDt)
                    .HasColumnName("ExpArrivalDT")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.ExpCloseDt)
                    .HasColumnName("ExpCloseDT")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.ExpProcessOutputQtyDenominator)
                    .HasColumnName("Exp_ProcessOutputQty_Denominator")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ExpProcessOutputQtyInProductionQtyUnit).HasColumnName("Exp_ProcessOutputQty_In_ProductionQtyUnit");

                entity.Property(e => e.ExpProcessOutputQtyInReportingUnit)
                    .HasColumnName("Exp_ProcessOutputQty_In_ReportingUnit")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ExpProcessOutputQtyInSkunit)
                    .HasColumnName("Exp_ProcessOutputQty_In_SKUnit")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ExpProcessOutputQtyNumerator)
                    .HasColumnName("Exp_ProcessOutputQty_Numerator")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ExpProcessOutputQtyUnitIdDenominator)
                    .HasColumnName("Exp_ProcessOutputQty_UnitID_Denominator")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ExpProcessOutputQtyUnitIdNumerator)
                    .HasColumnName("Exp_ProcessOutputQty_UnitID_Numerator")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ExpProcessTimeMinutes)
                    .HasColumnName("ExpProcessTime_Minutes")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.IsClosedWop).HasColumnName("IsClosed_WOP");

                entity.Property(e => e.IsFinishedProcessOutPut).HasColumnName("IsFinished_ProcessOutPut");

                entity.Property(e => e.IsFirstWop).HasColumnName("IsFirst_WOP");

                entity.Property(e => e.IsProdQtyUnitSameAsSkunit).HasColumnName("IsProdQtyUnit_SameAs_SKUnit");

                entity.Property(e => e.IsRelationExistForProcessOutputUnitToReportingUnit).HasColumnName("IsRelationExist_For_ProcessOutputUnit_To_ReportingUnit");

                entity.Property(e => e.IsRelationExistForSkunitToProdQtyUnit).HasColumnName("IsRelationExist_For_SKUnit_To_ProdQtyUnit");

                entity.Property(e => e.IsRelationExistForSkunitToReportingUnit).HasColumnName("IsRelationExist_For_SKUnit_To_ReportingUnit");

                entity.Property(e => e.IsRelationExistForWopskunitIdToProcessOptunit).HasColumnName("IsRelationExist_For_WOPSKUnitID_To_ProcessOPTUnit");

                entity.Property(e => e.IsRunningWop).HasColumnName("IsRunning_WOP");

                entity.Property(e => e.IsStartedWop).HasColumnName("IsStarted_WOP");

                entity.Property(e => e.JobArrivalDt)
                    .HasColumnName("JobArrivalDT")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.JobCompleteDt)
                    .HasColumnName("JobCompleteDT")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.JobCompleteUserId).HasColumnName("JobCompleteUserID");

                entity.Property(e => e.JobStartDt)
                    .HasColumnName("JobStartDT")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.JobStartUserId).HasColumnName("JobStartUserID");

                entity.Property(e => e.LatestJobArrivalDt)
                    .HasColumnName("Latest_JobArrivalDT")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.LatestJobStartDt)
                    .HasColumnName("Latest_JobStartDT")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.LatestJobStartUserId).HasColumnName("Latest_JobStartUserID");

                entity.Property(e => e.LowProductionQtyInProcessOptunit)
                    .HasColumnName("LowProductionQty_In_ProcessOPTUnit")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.LowProductionQtyInProductionQtyUnit)
                    .HasColumnName("LowProductionQty_In_ProductionQtyUnit")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.LowProductionQtyInReportingUnit)
                    .HasColumnName("LowProductionQty_In_ReportingUnit")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.LowProductionQtyInSkunit)
                    .HasColumnName("LowProductionQty_In_SKUnit")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ManualStartDt)
                    .HasColumnName("ManualStartDT")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.MinimumTimeHours).HasColumnName("MinimumTime_Hours");

                entity.Property(e => e.MinimumTimeMinutes).HasColumnName("MinimumTime_Minutes");

                entity.Property(e => e.OriginalExpProcessOutputQtyInProductionQtyUnit)
                    .HasColumnName("Original_Exp_ProcessOutputQty_In_ProductionQtyUnit")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.OriginalExpProcessOutputQtyInReportingUnit)
                    .HasColumnName("Original_Exp_ProcessOutputQty_In_ReportingUnit")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.OriginalExpProcessOutputQtyInSkunit)
                    .HasColumnName("Original_Exp_ProcessOutputQty_In_SKUnit")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.OutputMaterialId).HasColumnName("Output_MaterialID");

                entity.Property(e => e.PausedDt)
                    .HasColumnName("PausedDT")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.PlannedArrivalDt)
                    .HasColumnName("PlannedArrivalDT")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.PlannedCloseDt)
                    .HasColumnName("PlannedCloseDT")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.PlantId)
                    .HasColumnName("PlantID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ProcessCost).HasDefaultValueSql("((0))");

                entity.Property(e => e.ProcessInputUnitId).HasColumnName("Process_InputUnitID");

                entity.Property(e => e.ProcessOutputUnitId).HasColumnName("Process_OutputUnitID");

                entity.Property(e => e.ProcessRejectionUnitId).HasColumnName("Process_RejectionUnitID");

                entity.Property(e => e.ProcessStepId).HasColumnName("ProcessStepID");

                entity.Property(e => e.ProcessingTimeValueVariableTime1).HasColumnName("ProcessingTimeValue_VariableTime1");

                entity.Property(e => e.ProductionUnitIdVariableTime1).HasColumnName("ProductionUnitID_VariableTime1");

                entity.Property(e => e.QtyProductionUnitVariableTime1).HasColumnName("Qty_ProductionUnit_VariableTime1");

                entity.Property(e => e.RemainingExpProcessOutputQtyInProductionQtyUnit)
                    .HasColumnName("Remaining_Exp_ProcessOutputQty_In_ProductionQtyUnit")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.RemainingExpProcessOutputQtyInReportingUnit)
                    .HasColumnName("Remaining_Exp_ProcessOutputQty_In_ReportingUnit")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.RemainingExpProcessOutputQtyInSkunit)
                    .HasColumnName("Remaining_Exp_ProcessOutputQty_In_SKUnit")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ResumedDt)
                    .HasColumnName("ResumedDT")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.SetupTimeHours).HasColumnName("SetupTime_Hours");

                entity.Property(e => e.SetupTimeMinutes).HasColumnName("SetupTime_Minutes");

                entity.Property(e => e.SuccessQtyInProcessOptunit)
                    .HasColumnName("SuccessQty_In_ProcessOPTUnit")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.SuccessQtyInProductionQtyUnit)
                    .HasColumnName("SuccessQty_In_ProductionQtyUnit")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.SuccessQtyInReportingUnit)
                    .HasColumnName("SuccessQty_In_ReportingUnit")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.SuccessQtyInSkunit)
                    .HasColumnName("SuccessQty_In_SKUnit")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TimeUnitIdVariableTime1).HasColumnName("TimeUnitID_VariableTime1");

                entity.Property(e => e.TransferredQtyInProductionQtyUnit)
                    .HasColumnName("TransferredQty_In_ProductionQtyUnit")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TransferredQtyInReportingUnitOld)
                    .HasColumnName("TransferredQty_In_ReportingUnit_Old")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TransferredQtyInSkunit).HasColumnName("TransferredQty_In_SKUnit");

                entity.Property(e => e.TrashQtyInProcessOptunit)
                    .HasColumnName("TrashQty_In_ProcessOPTUnit")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TrashQtyInProductionQtyUnit)
                    .HasColumnName("TrashQty_In_ProductionQtyUnit")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TrashQtyInReportingUnit)
                    .HasColumnName("TrashQty_In_ReportingUnit")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TrashQtyInSkunit)
                    .HasColumnName("TrashQty_In_SKUnit")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.UnusedProcessOutputQtyInProductionQtyUnit)
                    .HasColumnName("Unused_ProcessOutputQty_In_ProductionQtyUnit")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.UnusedProcessOutputQtyInReportingUnitOld)
                    .HasColumnName("Unused_ProcessOutputQty_In_ReportingUnit_Old")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.UnusedProcessOutputQtyInSkunit)
                    .HasColumnName("Unused_ProcessOutputQty_In_SKUnit")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.UpdatedDt)
                    .HasColumnName("UpdatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdatedUserId).HasColumnName("UpdatedUserID");

                entity.Property(e => e.UsedProcessOutputQtyInProductionQtyUnit)
                    .HasColumnName("Used_ProcessOutputQty_In_ProductionQtyUnit")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.UsedProcessOutputQtyInReportingUnitOld)
                    .HasColumnName("Used_ProcessOutputQty_In_ReportingUnit_Old")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.UsedProcessOutputQtyInSkunit)
                    .HasColumnName("Used_ProcessOutputQty_In_SKUnit")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.WopProductionQtyUnitId).HasColumnName("WOP_ProductionQtyUnitID");

                entity.Property(e => e.WopReportingUnitId).HasColumnName("WOP_ReportingUnitID");

                entity.Property(e => e.WopSkunitId).HasColumnName("WOP_SKUnitID");

                entity.Property(e => e.WoprocessOrder).HasColumnName("WOProcess_Order");

                entity.Property(e => e.WorkOrderId).HasColumnName("WorkOrderID");
            });

            modelBuilder.Entity<PrdWorkOrderProcessQaD>(entity =>
            {
                entity.HasKey(e => e.WorkOrderProcessDetailQaid);

                entity.ToTable("PRD_WorkOrder_Process_QA_D");

                entity.Property(e => e.WorkOrderProcessDetailQaid).HasColumnName("WorkOrderProcessDetailQAID");

                entity.Property(e => e.CreatedDt)
                    .HasColumnName("CreatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedUserId).HasColumnName("CreatedUserID");

                entity.Property(e => e.FieldId).HasColumnName("FieldID");

                entity.Property(e => e.FieldValue1)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FieldValue2)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IdealWorkOrderProcessDetailQaid)
                    .HasColumnName("Ideal_WorkOrderProcessDetailQAID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.UpdatedDt)
                    .HasColumnName("UpdatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdatedUserId).HasColumnName("UpdatedUserID");

                entity.Property(e => e.WorkOrderProcessQaid).HasColumnName("WorkOrderProcessQAID");
            });

            modelBuilder.Entity<PrdWorkOrderProcessQaIdealD>(entity =>
            {
                entity.HasKey(e => e.IdealWorkOrderProcessDetailQaid);

                entity.ToTable("PRD_WorkOrder_Process_QA_Ideal_D");

                entity.Property(e => e.IdealWorkOrderProcessDetailQaid).HasColumnName("Ideal_WorkOrderProcessDetailQAID");

                entity.Property(e => e.CreatedDt)
                    .HasColumnName("CreatedDT")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.CreatedUserId).HasColumnName("CreatedUserID");

                entity.Property(e => e.DeviationScopeFromValue).HasColumnName("DeviationScope_FromValue");

                entity.Property(e => e.DeviationScopeToValue).HasColumnName("DeviationScope_ToValue");

                entity.Property(e => e.FieldId).HasColumnName("FieldID");

                entity.Property(e => e.FieldValue1)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FieldValue2)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IdealWorkOrderProcessQaid).HasColumnName("Ideal_WorkOrderProcessQAID");

                entity.Property(e => e.ObservedValueType).HasColumnName("ObservedValue_Type");

                entity.Property(e => e.UpdatedDt)
                    .HasColumnName("UpdatedDT")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.UpdatedUserId).HasColumnName("UpdatedUserID");
            });

            modelBuilder.Entity<PrdWorkOrderProcessQaIdealM>(entity =>
            {
                entity.HasKey(e => e.IdealWorkOrderProcessQaid);

                entity.ToTable("PRD_WorkOrder_Process_QA_Ideal_M");

                entity.Property(e => e.IdealWorkOrderProcessQaid).HasColumnName("Ideal_WorkOrderProcessQAID");

                entity.Property(e => e.CreatedDt)
                    .HasColumnName("CreatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedUserId).HasColumnName("CreatedUserID");

                entity.Property(e => e.UpdatedDt)
                    .HasColumnName("UpdatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdatedUserId).HasColumnName("UpdatedUserID");

                entity.Property(e => e.WorkOrderId).HasColumnName("WorkOrderID");

                entity.Property(e => e.WorkOrderProcessId).HasColumnName("WorkOrderProcessID");
            });

            modelBuilder.Entity<PrdWorkOrderProcessQaM>(entity =>
            {
                entity.HasKey(e => e.WorkOrderProcessQaid);

                entity.ToTable("PRD_WorkOrder_Process_QA_M");

                entity.Property(e => e.WorkOrderProcessQaid).HasColumnName("WorkOrderProcessQAID");

                entity.Property(e => e.CreatedDt)
                    .HasColumnName("CreatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedUserId).HasColumnName("CreatedUserID");

                entity.Property(e => e.IdealWorkOrderProcessQaid)
                    .HasColumnName("Ideal_WorkOrderProcessQAID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.InspectedByEmpId)
                    .HasColumnName("InspectedBy_EmpID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Notes)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.SampleQtyInProcessOptunit)
                    .HasColumnName("SampleQty_In_ProcessOPTUnit")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.SampleQtyInProdQtyUnit).HasColumnName("SampleQty_In_ProdQtyUnit");

                entity.Property(e => e.SampleQtyInReportingUnit).HasColumnName("SampleQty_In_ReportingUnit");

                entity.Property(e => e.SampleQtyInSkunit).HasColumnName("SampleQty_In_SKUnit");

                entity.Property(e => e.SampleQtyProcessOptunitId).HasColumnName("SampleQty_ProcessOPTUnitID");

                entity.Property(e => e.SampleQtyProdQtyUnitId).HasColumnName("SampleQty_ProdQtyUnitID");

                entity.Property(e => e.SampleQtyReportingUnitId).HasColumnName("SampleQty_ReportingUnitID");

                entity.Property(e => e.SampleQtySkunitId).HasColumnName("SampleQty_SKUnitID");

                entity.Property(e => e.SerialNum)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedDt)
                    .HasColumnName("UpdatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdatedUserId).HasColumnName("UpdatedUserID");

                entity.Property(e => e.WorkOrderId).HasColumnName("WorkOrderID");

                entity.Property(e => e.WorkOrderProcessId).HasColumnName("WorkOrderProcessID");
            });

            modelBuilder.Entity<PrdWorkOrderSeries>(entity =>
            {
                entity.HasKey(e => e.WorkOrderSeriesId);

                entity.ToTable("PRD_WorkOrder_Series");

                entity.Property(e => e.WorkOrderSeriesId).HasColumnName("WorkOrderSeriesID");

                entity.Property(e => e.CreatedDt)
                    .HasColumnName("CreatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedUserId).HasColumnName("CreatedUserID");

                entity.Property(e => e.Prefix)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.Property(e => e.Suffix)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.WorkOrderFinishedGoodDetId).HasColumnName("WorkOrderFinishedGoodDetID");

                entity.Property(e => e.WorkOrderId).HasColumnName("WorkOrderID");
            });

            modelBuilder.Entity<RightsAccount>(entity =>
            {
                entity.HasKey(e => e.AccrightsId);

                entity.ToTable("Rights_Account");

                entity.Property(e => e.AccrightsId).HasColumnName("ACCRightsID");

                entity.Property(e => e.AccConfig)
                    .HasColumnName("Acc_Config")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.CashFlowPlanning)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDt)
                    .HasColumnName("CreatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedUserId)
                    .HasColumnName("CreatedUserID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.DefaultPage)
                    .IsRequired()
                    .HasColumnName("Default_Page")
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.EmployeeTypeId).HasColumnName("EmployeeTypeID");

                entity.Property(e => e.Groups)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Indicators)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Ledgers)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Profitability)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Ratio)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Reconcilition)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Reports)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Stock)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedDt)
                    .HasColumnName("UpdatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdatedUserId)
                    .HasColumnName("UpdatedUserID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.UserEntry)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.VoucherEntry)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.VoucherFormat)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.VoucherTypes)
                    .HasMaxLength(2)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<RightsAst>(entity =>
            {
                entity.HasKey(e => e.AstrightId);

                entity.ToTable("Rights_AST");

                entity.Property(e => e.AstrightId).HasColumnName("ASTRightID");

                entity.Property(e => e.AstConfiguration).HasColumnName("AST_Configuration");

                entity.Property(e => e.AstMaintanance).HasColumnName("AST_Maintanance");

                entity.Property(e => e.AstMovement).HasColumnName("AST_Movement");

                entity.Property(e => e.AstOtherConfiguration).HasColumnName("AST_Other_Configuration");

                entity.Property(e => e.AstRepairEntry).HasColumnName("AST_RepairEntry");

                entity.Property(e => e.AstRepairRequestApproval).HasColumnName("AST_RepairRequest_Approval");

                entity.Property(e => e.AstRepairs).HasColumnName("AST_Repairs");

                entity.Property(e => e.AstReports).HasColumnName("AST_Reports");

                entity.Property(e => e.CreateAssets).HasColumnName("Create_Assets");

                entity.Property(e => e.CreatedDt)
                    .HasColumnName("CreatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedUserId).HasColumnName("CreatedUserID");

                entity.Property(e => e.DefaultPageTitle)
                    .IsRequired()
                    .HasColumnName("Default_PageTitle")
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.DeleteAssets).HasColumnName("Delete_Assets");

                entity.Property(e => e.EditAssetWorth).HasColumnName("Edit_AssetWorth");

                entity.Property(e => e.EmployeeTypeId).HasColumnName("EmployeeTypeID");

                entity.Property(e => e.EnterAstmovement).HasColumnName("Enter_ASTMovement");

                entity.Property(e => e.LocationConfiguration).HasColumnName("Location_Configuration");

                entity.Property(e => e.OverdueMaintananceEntry).HasColumnName("Overdue_MaintananceEntry");

                entity.Property(e => e.RegularMaintananceEntry).HasColumnName("Regular_MaintananceEntry");

                entity.Property(e => e.RepairMaintananceConfiguration).HasColumnName("Repair_Maintanance_Configuration");

                entity.Property(e => e.ShowAssetWorth).HasColumnName("Show_AssetWorth");

                entity.Property(e => e.UpdateAssets).HasColumnName("Update_Assets");

                entity.Property(e => e.UpdatedDt)
                    .HasColumnName("UpdatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdatedUserId).HasColumnName("UpdatedUserID");

                entity.Property(e => e.ViewAssets).HasColumnName("View_Assets");

                entity.Property(e => e.ViewAstmovement).HasColumnName("View_ASTMovement");

                entity.Property(e => e.ViewMaintananceSchedule).HasColumnName("View_MaintananceSchedule");
            });

            modelBuilder.Entity<RightsAstOld>(entity =>
            {
                entity.HasKey(e => e.AstrightId);

                entity.ToTable("Rights_AST_Old");

                entity.Property(e => e.AstrightId).HasColumnName("ASTRightID");

                entity.Property(e => e.ActivateOrDeactivateAssetSupplier).HasColumnName("ActivateOrDeactivate_AssetSupplier");

                entity.Property(e => e.AddMaintenanceTypeInAssetDetailEntryPage).HasColumnName("Add_MaintenanceType_InAssetDetailEntryPage");

                entity.Property(e => e.AddRepairTypeInAssetDetailEntryPage).HasColumnName("Add_RepairType_InAssetDetailEntryPage");

                entity.Property(e => e.ApproveOrDisapproveAssetPo).HasColumnName("ApproveOrDisapprove_AssetPO");

                entity.Property(e => e.ApproveOtherRepairRequest).HasColumnName("ApproveOther_RepairRequest");

                entity.Property(e => e.AssetOtherConfiguration).HasColumnName("Asset_OtherConfiguration");

                entity.Property(e => e.AssetPoAutoApprove).HasColumnName("AssetPO_AutoApprove");

                entity.Property(e => e.AssetPoapprovaeOtherRequest).HasColumnName("AssetPOApprovaeOtherRequest");

                entity.Property(e => e.AstConfigurationAccess).HasColumnName("AST_ConfigurationAccess");

                entity.Property(e => e.Astcategory).HasColumnName("ASTCategory");

                entity.Property(e => e.AutoApproveRepairRequest).HasColumnName("AutoApprove_RepairRequest");

                entity.Property(e => e.CreateAsset).HasColumnName("Create_Asset");

                entity.Property(e => e.CreateAssetArea).HasColumnName("Create_AssetArea");

                entity.Property(e => e.CreateAssetCharacteristics).HasColumnName("Create_AssetCharacteristics");

                entity.Property(e => e.CreateAssetInsuranceType).HasColumnName("Create_AssetInsuranceType");

                entity.Property(e => e.CreateAssetLocation).HasColumnName("Create_AssetLocation");

                entity.Property(e => e.CreateAssetPlant).HasColumnName("Create_AssetPlant");

                entity.Property(e => e.CreateAssetPo).HasColumnName("Create_AssetPO");

                entity.Property(e => e.CreateAssetSupplier).HasColumnName("Create_AssetSupplier");

                entity.Property(e => e.CreateAssetType).HasColumnName("Create_AssetType");

                entity.Property(e => e.CreateAssetWarranty).HasColumnName("Create_AssetWarranty");

                entity.Property(e => e.CreateAstcategory).HasColumnName("Create_ASTCategory");

                entity.Property(e => e.CreateMaintenanceType).HasColumnName("Create_MaintenanceType");

                entity.Property(e => e.CreateOrUpdateLoginForAssetSupplier).HasColumnName("CreateOrUpdateLoginFor_AssetSupplier");

                entity.Property(e => e.CreateRepairRequest).HasColumnName("Create_RepairRequest");

                entity.Property(e => e.CreateRepairType).HasColumnName("Create_RepairType");

                entity.Property(e => e.CreatedDt)
                    .HasColumnName("CreatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedUserId)
                    .HasColumnName("CreatedUserID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.DefaultPage)
                    .IsRequired()
                    .HasColumnName("Default_Page")
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.DeleteAsset).HasColumnName("Delete_Asset");

                entity.Property(e => e.DeleteAssetArea).HasColumnName("Delete_AssetArea");

                entity.Property(e => e.DeleteAssetCharacteristics).HasColumnName("Delete_AssetCharacteristics");

                entity.Property(e => e.DeleteAssetInsuranceType).HasColumnName("Delete_AssetInsuranceType");

                entity.Property(e => e.DeleteAssetLocation).HasColumnName("Delete_AssetLocation");

                entity.Property(e => e.DeleteAssetPlant).HasColumnName("Delete_AssetPlant");

                entity.Property(e => e.DeleteAssetType).HasColumnName("Delete_AssetType");

                entity.Property(e => e.DeleteAssetWarranty).HasColumnName("Delete_AssetWarranty");

                entity.Property(e => e.DeleteAstcategory).HasColumnName("Delete_ASTCategory");

                entity.Property(e => e.DeleteMaintenanceType).HasColumnName("Delete_MaintenanceType");

                entity.Property(e => e.DeleteMaintenanceTypeInAssetDetailEntryPage).HasColumnName("Delete_MaintenanceType_InAssetDetailEntryPage");

                entity.Property(e => e.DeleteRepairRequest).HasColumnName("Delete_RepairRequest");

                entity.Property(e => e.DeleteRepairType).HasColumnName("Delete_RepairType");

                entity.Property(e => e.DeleteRepairTypeInAssetDetailEntryPage).HasColumnName("Delete_RepairType_InAssetDetailEntryPage");

                entity.Property(e => e.EditAsset).HasColumnName("Edit_Asset");

                entity.Property(e => e.EditAssetType).HasColumnName("Edit_AssetType");

                entity.Property(e => e.EditAstcategory).HasColumnName("Edit_ASTCategory");

                entity.Property(e => e.EmployeeTypeId).HasColumnName("EmployeeTypeID");

                entity.Property(e => e.EnterAssetMovement).HasColumnName("Enter_AssetMovement");

                entity.Property(e => e.MaintenanceInAssetDetailEntryPage).HasColumnName("Maintenance_InAssetDetailEntryPage");

                entity.Property(e => e.MakeAssetMaintenanceEntry).HasColumnName("Make_Asset_MaintenanceEntry");

                entity.Property(e => e.MakeProcessMaintenanceEntry).HasColumnName("Make_Process_MaintenanceEntry");

                entity.Property(e => e.MakeRepairEntryForRequest).HasColumnName("Make_RepairEntry_ForRequest");

                entity.Property(e => e.MakeRepairEntryLog).HasColumnName("Make_RepairEntryLog");

                entity.Property(e => e.ReceiveAssetAgainstPo).HasColumnName("ReceiveAsset_AgainstPO");

                entity.Property(e => e.RepairsInAssetDetailEntryPage).HasColumnName("Repairs_InAssetDetailEntryPage");

                entity.Property(e => e.UpdateAssetArea).HasColumnName("Update_AssetArea");

                entity.Property(e => e.UpdateAssetCharacteristics).HasColumnName("Update_AssetCharacteristics");

                entity.Property(e => e.UpdateAssetInsuranceType).HasColumnName("Update_AssetInsuranceType");

                entity.Property(e => e.UpdateAssetLocation).HasColumnName("Update_AssetLocation");

                entity.Property(e => e.UpdateAssetPlant).HasColumnName("Update_AssetPlant");

                entity.Property(e => e.UpdateAssetSupplierEntry).HasColumnName("Update_AssetSupplierEntry");

                entity.Property(e => e.UpdateAssetWarranty).HasColumnName("Update_AssetWarranty");

                entity.Property(e => e.UpdateMaintenanceType).HasColumnName("Update_MaintenanceType");

                entity.Property(e => e.UpdateOrDeleteAssetBudget).HasColumnName("UpdateOrDelete_AssetBudget");

                entity.Property(e => e.UpdateRepairType).HasColumnName("Update_RepairType");

                entity.Property(e => e.UpdatedDt)
                    .HasColumnName("UpdatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdatedUserId)
                    .HasColumnName("UpdatedUserID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ViewAssetBudgetPlan).HasColumnName("View_AssetBudgetPlan");

                entity.Property(e => e.ViewAssetBudgetReport).HasColumnName("View_AssetBudgetReport");

                entity.Property(e => e.ViewAssetMaintenanceSchedule).HasColumnName("View_Asset_MaintenanceSchedule");

                entity.Property(e => e.ViewAssetMarketBookValue).HasColumnName("View_Asset_Market_BookValue");

                entity.Property(e => e.ViewAssetMovement).HasColumnName("View_AssetMovement");

                entity.Property(e => e.ViewExpiredAssetBudgetPlan).HasColumnName("View_Expired_AssetBudgetPlan");

                entity.Property(e => e.ViewListOfAssetPo).HasColumnName("ViewListOfAssetPO");

                entity.Property(e => e.ViewListOfAstcategory).HasColumnName("ViewListOfASTCategory");

                entity.Property(e => e.ViewMaintenanceStatistics).HasColumnName("View_MaintenanceStatistics");

                entity.Property(e => e.ViewOverAllMaintenanceHistory).HasColumnName("View_OverAllMaintenanceHistory");

                entity.Property(e => e.ViewProcessMaintenanceSchedule).HasColumnName("View_Process_MaintenanceSchedule");

                entity.Property(e => e.ViewRepairHistory).HasColumnName("View_RepairHistory");

                entity.Property(e => e.ViewRepairStatistics).HasColumnName("View_RepairStatistics");

                entity.Property(e => e.ViewStockInventory).HasColumnName("View_StockInventory");
            });

            modelBuilder.Entity<RightsDefaultPages>(entity =>
            {
                entity.HasKey(e => e.DefaultPageId);

                entity.ToTable("Rights_DefaultPages");

                entity.Property(e => e.DefaultPageId).HasColumnName("DefaultPageID");

                entity.Property(e => e.CreatedDt)
                    .HasColumnName("CreatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedUserId).HasColumnName("CreatedUserID");

                entity.Property(e => e.DefaultPage)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Module)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PageTitle)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.UpdatedDt)
                    .HasColumnName("UpdatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdatedUserId).HasColumnName("UpdatedUserID");
            });

            modelBuilder.Entity<RightsFileTypes>(entity =>
            {
                entity.HasKey(e => e.FileTypeRightId);

                entity.ToTable("Rights_FileTypes");

                entity.Property(e => e.FileTypeRightId).HasColumnName("FileTypeRightID");

                entity.Property(e => e.CreatedDt)
                    .HasColumnName("CreatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedUserId)
                    .HasColumnName("CreatedUserID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.EmployeeTypeId).HasColumnName("EmployeeTypeID");

                entity.Property(e => e.FileTypeId).HasColumnName("FileTypeID");

                entity.Property(e => e.UpdatedDt)
                    .HasColumnName("UpdatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdatedUserId)
                    .HasColumnName("UpdatedUserID")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<RightsHome>(entity =>
            {
                entity.HasKey(e => e.HomeRightId);

                entity.ToTable("Rights_Home");

                entity.Property(e => e.HomeRightId).HasColumnName("HomeRightID");

                entity.Property(e => e.CreatedDt)
                    .HasColumnName("CreatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedUserId)
                    .HasColumnName("CreatedUserID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.DefaultPage)
                    .IsRequired()
                    .HasColumnName("Default_Page")
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.EmployeeTypeId).HasColumnName("EmployeeTypeID");

                entity.Property(e => e.ShowAccReports).HasColumnName("Show_ACC_Reports");

                entity.Property(e => e.ShowAstReports).HasColumnName("Show_AST_Reports");

                entity.Property(e => e.ShowHrmReports).HasColumnName("Show_HRM_Reports");

                entity.Property(e => e.ShowMktReports).HasColumnName("Show_MKT_Reports");

                entity.Property(e => e.ShowMtlReports).HasColumnName("Show_MTL_Reports");

                entity.Property(e => e.ShowPrdReports).HasColumnName("Show_PRD_Reports");

                entity.Property(e => e.UpdatedDt)
                    .HasColumnName("UpdatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdatedUserId)
                    .HasColumnName("UpdatedUserID")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<RightsHrm>(entity =>
            {
                entity.HasKey(e => e.HrmrightId);

                entity.ToTable("Rights_HRM");

                entity.Property(e => e.HrmrightId).HasColumnName("HRMRightID");

                entity.Property(e => e.AllowExceptionsAttendance).HasColumnName("Allow_Exceptions_Attendance");

                entity.Property(e => e.CreateEmployeeRecords).HasColumnName("Create_EmployeeRecords");

                entity.Property(e => e.CreateEmployees).HasColumnName("Create_Employees");

                entity.Property(e => e.CreatedDt)
                    .HasColumnName("CreatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedUserId).HasColumnName("CreatedUserID");

                entity.Property(e => e.CurrentAttendanceEntry).HasColumnName("Current_AttendanceEntry");

                entity.Property(e => e.DefaultPageTitle)
                    .IsRequired()
                    .HasColumnName("Default_PageTitle")
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.DeleteEmployeeRecords).HasColumnName("Delete_EmployeeRecords");

                entity.Property(e => e.DeleteEmployees).HasColumnName("Delete_Employees");

                entity.Property(e => e.EmpHierarchyRightsConfiguration).HasColumnName("EmpHierarchy_Rights_Configuration");

                entity.Property(e => e.EmployeeRecordsConfiguration).HasColumnName("EmployeeRecords_Configuration");

                entity.Property(e => e.EmployeeTypeId).HasColumnName("EmployeeTypeID");

                entity.Property(e => e.HrmManageTraining).HasColumnName("HRM_ManageTraining");

                entity.Property(e => e.HrmOtherConfiguration).HasColumnName("HRM_Other_Configuration");

                entity.Property(e => e.HrmPrints).HasColumnName("HRM_Prints");

                entity.Property(e => e.HrmReports).HasColumnName("HRM_Reports");

                entity.Property(e => e.LeaveApprovalsAsAdmin).HasColumnName("LeaveApprovals_As_Admin");

                entity.Property(e => e.LeaveSalaryConfiguration).HasColumnName("Leave_Salary_Configuration");

                entity.Property(e => e.OldAttendanceEntry).HasColumnName("Old_AttendanceEntry");

                entity.Property(e => e.RecruitmentConfiguration).HasColumnName("Recruitment_Configuration");

                entity.Property(e => e.RequestOtherEmpLeaves).HasColumnName("Request_OtherEmpLeaves");

                entity.Property(e => e.ResetPasswordOtherEmployees).HasColumnName("ResetPassword_OtherEmployees");

                entity.Property(e => e.UpdateEmployeeRecords).HasColumnName("Update_EmployeeRecords");

                entity.Property(e => e.UpdateEmployees).HasColumnName("Update_Employees");

                entity.Property(e => e.UpdatedDt)
                    .HasColumnName("UpdatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdatedUserId).HasColumnName("UpdatedUserID");

                entity.Property(e => e.ViewEmployeeRecords).HasColumnName("View_EmployeeRecords");

                entity.Property(e => e.ViewEmployees).HasColumnName("View_Employees");
            });

            modelBuilder.Entity<RightsHrmOld>(entity =>
            {
                entity.HasKey(e => e.HrmrightId);

                entity.ToTable("Rights_HRM_Old");

                entity.Property(e => e.HrmrightId).HasColumnName("HRMRightID");

                entity.Property(e => e.AddAttendanceEntry).HasColumnName("Add_AttendanceEntry");

                entity.Property(e => e.AddHolidayEntry).HasColumnName("Add_HolidayEntry");

                entity.Property(e => e.AddLeaveBalance).HasColumnName("Add_LeaveBalance");

                entity.Property(e => e.AddLeaveRequestForOtherEmployee).HasColumnName("Add_LeaveRequest_ForOtherEmployee");

                entity.Property(e => e.AddLeaveRequestSelf).HasColumnName("Add_LeaveRequest_Self");

                entity.Property(e => e.CalculateSalary).HasColumnName("Calculate_Salary");

                entity.Property(e => e.ChangePasswordOtherEmployeesInList).HasColumnName("ChangePassword_OtherEmployees_InList");

                entity.Property(e => e.ConfigureSalaryComponents).HasColumnName("Configure_SalaryComponents");

                entity.Property(e => e.ContactEmployeeViaSms).HasColumnName("Contact_Employee_ViaSMS");

                entity.Property(e => e.CreateAmmendmentEntry).HasColumnName("Create_AmmendmentEntry");

                entity.Property(e => e.CreateDepartmentEntry).HasColumnName("Create_DepartmentEntry");

                entity.Property(e => e.CreateDesignationEntry).HasColumnName("Create_DesignationEntry");

                entity.Property(e => e.CreateEmployeeEntry).HasColumnName("Create_EmployeeEntry");

                entity.Property(e => e.CreateIndisciplineEntry).HasColumnName("Create_IndisciplineEntry");

                entity.Property(e => e.CreateLeaveRejectionReason).HasColumnName("Create_LeaveRejectionReason");

                entity.Property(e => e.CreateLeaveRequestReason).HasColumnName("Create_LeaveRequestReason");

                entity.Property(e => e.CreateLeaveType).HasColumnName("Create_LeaveType");

                entity.Property(e => e.CreatePolicyEntry).HasColumnName("Create_PolicyEntry");

                entity.Property(e => e.CreatedDt)
                    .HasColumnName("CreatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedUserId)
                    .HasColumnName("CreatedUserID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.DefaultPage)
                    .IsRequired()
                    .HasColumnName("Default_Page")
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.DeleteAchievement).HasColumnName("Delete_Achievement");

                entity.Property(e => e.DeleteDepartmentEntry).HasColumnName("Delete_DepartmentEntry");

                entity.Property(e => e.DeleteDesignationEntry).HasColumnName("Delete_DesignationEntry");

                entity.Property(e => e.DeleteEmployeeEntry).HasColumnName("Delete_EmployeeEntry");

                entity.Property(e => e.DeleteHolidayEntry).HasColumnName("Delete_HolidayEntry");

                entity.Property(e => e.DeleteIndisciplineEntry).HasColumnName("Delete_IndisciplineEntry");

                entity.Property(e => e.DeleteIndisciplineType).HasColumnName("Delete_IndisciplineType");

                entity.Property(e => e.DeleteLeaveRejectionReason).HasColumnName("Delete_LeaveRejectionReason");

                entity.Property(e => e.DeleteLeaveRequest).HasColumnName("Delete_LeaveRequest");

                entity.Property(e => e.DeleteLeaveRequestReason).HasColumnName("Delete_LeaveRequestReason");

                entity.Property(e => e.DeleteLeaveType).HasColumnName("Delete_LeaveType");

                entity.Property(e => e.EditAchievement).HasColumnName("Edit_Achievement");

                entity.Property(e => e.EditDepartmentEntry).HasColumnName("Edit_DepartmentEntry");

                entity.Property(e => e.EditDesignationEntry).HasColumnName("Edit_DesignationEntry");

                entity.Property(e => e.EditEmployeeEntry).HasColumnName("Edit_EmployeeEntry");

                entity.Property(e => e.EditHolidayEntry).HasColumnName("Edit_HolidayEntry");

                entity.Property(e => e.EditIndisciplineType).HasColumnName("Edit_IndisciplineType");

                entity.Property(e => e.EditLeaveRejectionReason).HasColumnName("Edit_LeaveRejectionReason");

                entity.Property(e => e.EditLeaveRequestReason).HasColumnName("Edit_LeaveRequestReason");

                entity.Property(e => e.EditLeaveType).HasColumnName("Edit_LeaveType");

                entity.Property(e => e.EditOfficialDetails).HasColumnName("Edit_OfficialDetails");

                entity.Property(e => e.EditPastAttendanceEntry).HasColumnName("Edit_Past_AttendanceEntry");

                entity.Property(e => e.EditSalaryDetails).HasColumnName("Edit_SalaryDetails");

                entity.Property(e => e.EmployeeTypeId).HasColumnName("EmployeeTypeID");

                entity.Property(e => e.EnterAttendanceManually).HasColumnName("Enter_Attendance_Manually");

                entity.Property(e => e.EnterIndisciplineTypes).HasColumnName("Enter_IndisciplineTypes");

                entity.Property(e => e.HrmConfiguration).HasColumnName("HRM_Configuration");

                entity.Property(e => e.HrmOtherConfiguration).HasColumnName("HRM_OtherConfiguration");

                entity.Property(e => e.HrmReports).HasColumnName("HRM_Reports");

                entity.Property(e => e.IssueSalary).HasColumnName("Issue_Salary");

                entity.Property(e => e.LeaveRequestApprovalAsAdmin).HasColumnName("LeaveRequestApproval_As_Admin");

                entity.Property(e => e.LeaveRequestApprovalAsSupervisor).HasColumnName("LeaveRequestApproval_As_Supervisor");

                entity.Property(e => e.LeaveRequestApproveOtherRequests).HasColumnName("LeaveRequest_Approve_OtherRequests");

                entity.Property(e => e.LeaveRequestAutoApprove).HasColumnName("LeaveRequest_AutoApprove");

                entity.Property(e => e.ReviewIndisciplineEntry).HasColumnName("Review_IndisciplineEntry");

                entity.Property(e => e.UpdatedDt)
                    .HasColumnName("UpdatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdatedUserId)
                    .HasColumnName("UpdatedUserID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ViewAmmendments).HasColumnName("View_Ammendments");

                entity.Property(e => e.ViewAttendanceReport).HasColumnName("View_AttendanceReport");

                entity.Property(e => e.ViewDesignationHierarchy).HasColumnName("View_DesignationHierarchy");

                entity.Property(e => e.ViewEmpUtilization).HasColumnName("View_EmpUtilization");

                entity.Property(e => e.ViewIndisciplineEntry).HasColumnName("View_IndisciplineEntry");

                entity.Property(e => e.ViewIndisciplineResponseList).HasColumnName("View_IndisciplineResponseList");

                entity.Property(e => e.ViewLeaveLog).HasColumnName("View_LeaveLog");

                entity.Property(e => e.ViewLeavesOtherEmployeesInList).HasColumnName("View_Leaves_OtherEmployees_InList");

                entity.Property(e => e.ViewListOfDepartments).HasColumnName("ViewListOf_Departments");

                entity.Property(e => e.ViewListOfDesignations).HasColumnName("ViewListOf_Designations");

                entity.Property(e => e.ViewListOfEmployees).HasColumnName("ViewListOf_Employees");

                entity.Property(e => e.ViewListOfHolidays).HasColumnName("ViewListOf_Holidays");

                entity.Property(e => e.ViewListOfLeaveRejectionReason).HasColumnName("ViewListOf_LeaveRejectionReason");

                entity.Property(e => e.ViewListOfLeaveRequestReasons).HasColumnName("ViewListOf_LeaveRequestReasons");

                entity.Property(e => e.ViewListOfLeaveRequests).HasColumnName("ViewListOf_LeaveRequests");

                entity.Property(e => e.ViewListOfLeaveTypes).HasColumnName("ViewListOf_LeaveTypes");

                entity.Property(e => e.ViewPolicyList).HasColumnName("View_PolicyList");

                entity.Property(e => e.ViewProjectedPresence).HasColumnName("View_ProjectedPresence");

                entity.Property(e => e.ViewRecordOtherEmployeesInList).HasColumnName("View_Record_OtherEmployees_InList");

                entity.Property(e => e.ViewSalarySlips).HasColumnName("View_SalarySlips");
            });

            modelBuilder.Entity<RightsMkt>(entity =>
            {
                entity.HasKey(e => e.MktrightId);

                entity.ToTable("Rights_MKT");

                entity.Property(e => e.MktrightId).HasColumnName("MKTRightID");

                entity.Property(e => e.ApprovePartDraft).HasColumnName("Approve_PartDraft");

                entity.Property(e => e.ConfirmMktPo).HasColumnName("Confirm_MKT_PO");

                entity.Property(e => e.CreateCustomer).HasColumnName("Create_Customer");

                entity.Property(e => e.CreatePartDraft).HasColumnName("Create_PartDraft");

                entity.Property(e => e.CreatedDt)
                    .HasColumnName("CreatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedUserId).HasColumnName("CreatedUserID");

                entity.Property(e => e.DefaultPageTitle)
                    .IsRequired()
                    .HasColumnName("Default_PageTitle")
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.DeleteCustomer).HasColumnName("Delete_Customer");

                entity.Property(e => e.DeletePart).HasColumnName("Delete_Part");

                entity.Property(e => e.EmployeeTypeId).HasColumnName("EmployeeTypeID");

                entity.Property(e => e.EnterInteractions).HasColumnName("Enter_Interactions");

                entity.Property(e => e.EnterMktPo).HasColumnName("Enter_MKT_PO");

                entity.Property(e => e.IssueQuotation).HasColumnName("Issue_Quotation");

                entity.Property(e => e.MktConfiguration).HasColumnName("MKT_Configuration");

                entity.Property(e => e.MktDispatchEntry).HasColumnName("MKT_DispatchEntry");

                entity.Property(e => e.MktEvents).HasColumnName("MKT_Events");

                entity.Property(e => e.MktFeedbackEntry).HasColumnName("MKT_FeedbackEntry");

                entity.Property(e => e.MktInquiryEntry).HasColumnName("MKT_InquiryEntry");

                entity.Property(e => e.MktInteractions).HasColumnName("MKT_Interactions");

                entity.Property(e => e.MktInvoiceGeneration).HasColumnName("MKT_InvoiceGeneration");

                entity.Property(e => e.MktPaymentEntry).HasColumnName("MKT_PaymentEntry");

                entity.Property(e => e.MktReports).HasColumnName("MKT_Reports");

                entity.Property(e => e.MktWebSiteSetup).HasColumnName("MKT_WebSiteSetup");

                entity.Property(e => e.PartSpecificationEntry).HasColumnName("PartSpecification_Entry");

                entity.Property(e => e.Poacceptance).HasColumnName("POAcceptance");

                entity.Property(e => e.PrepareQuotation).HasColumnName("Prepare_Quotation");

                entity.Property(e => e.ReIssueQuotation).HasColumnName("ReIssue_Quotation");

                entity.Property(e => e.RejectMktPo).HasColumnName("Reject_MKT_PO");

                entity.Property(e => e.UpdateCustomer).HasColumnName("Update_Customer");

                entity.Property(e => e.UpdatePart).HasColumnName("Update_Part");

                entity.Property(e => e.UpdatedDt)
                    .HasColumnName("UpdatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdatedUserId).HasColumnName("UpdatedUserID");

                entity.Property(e => e.ViewCustomerPrint).HasColumnName("View_CustomerPrint");

                entity.Property(e => e.ViewCustomers).HasColumnName("View_Customers");

                entity.Property(e => e.ViewInteractions).HasColumnName("View_Interactions");

                entity.Property(e => e.ViewPartPrintable).HasColumnName("View_PartPrintable");
            });

            modelBuilder.Entity<RightsMktOld>(entity =>
            {
                entity.HasKey(e => e.MktrightsId);

                entity.ToTable("Rights_MKT_Old");

                entity.Property(e => e.MktrightsId).HasColumnName("MKTRightsID");

                entity.Property(e => e.ActivateOrDeactivateShipper).HasColumnName("ActivateOrDeactivate_Shipper");

                entity.Property(e => e.AddReceivedDateForDeliveryRecord).HasColumnName("AddReceivedDate_For_DeliveryRecord");

                entity.Property(e => e.AddTrackingNoForDeliveryRecord).HasColumnName("AddTrackingNo_For_DeliveryRecord");

                entity.Property(e => e.AddTrackingNoForInvoiceList).HasColumnName("AddTrackingNo_For_InvoiceList");

                entity.Property(e => e.AdvancePaymentReceiveInInvoice).HasColumnName("Advance_PaymentReceive_In_Invoice");

                entity.Property(e => e.ApprovePo).HasColumnName("ApprovePO");

                entity.Property(e => e.CreateAcustomer).HasColumnName("CreateACustomer");

                entity.Property(e => e.CreateCommunicationEntry).HasColumnName("Create_CommunicationEntry");

                entity.Property(e => e.CreateCurrency).HasColumnName("Create_Currency");

                entity.Property(e => e.CreateCustomerCategory).HasColumnName("Create_CustomerCategory");

                entity.Property(e => e.CreateDeliveryRecordForRejectedMtls).HasColumnName("Create_DeliveryRecord_For_RejectedMtls");

                entity.Property(e => e.CreateExportDeliveryRecord).HasColumnName("Create_Export_DeliveryRecord");

                entity.Property(e => e.CreateExportInvoice).HasColumnName("Create_Export_Invoice");

                entity.Property(e => e.CreateLocalDeliveryRecord).HasColumnName("Create_Local_DeliveryRecord");

                entity.Property(e => e.CreateLocalInvoice).HasColumnName("Create_Local_Invoice");

                entity.Property(e => e.CreateOrUpdateLoginForShipper).HasColumnName("CreateOrUpdateLoginFor_Shipper");

                entity.Property(e => e.CreateScrapDeliveryRecord).HasColumnName("Create_Scrap_DeliveryRecord");

                entity.Property(e => e.CreateScrapInvoice).HasColumnName("Create_Scrap_Invoice");

                entity.Property(e => e.CreateShipper).HasColumnName("Create_Shipper");

                entity.Property(e => e.CreateTaxStructure).HasColumnName("Create_TaxStructure");

                entity.Property(e => e.CreateTerm).HasColumnName("Create_Term");

                entity.Property(e => e.CreateTermCategory).HasColumnName("Create_TermCategory");

                entity.Property(e => e.CreatedDt)
                    .HasColumnName("CreatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedUserId)
                    .HasColumnName("CreatedUserID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.DefaultPage)
                    .IsRequired()
                    .HasColumnName("Default_Page")
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.DeleteCurrency).HasColumnName("Delete_Currency");

                entity.Property(e => e.DeleteCustomerCategory).HasColumnName("Delete_CustomerCategory");

                entity.Property(e => e.DeleteTaxStructure).HasColumnName("Delete_TaxStructure");

                entity.Property(e => e.DeleteTerms).HasColumnName("Delete_Terms");

                entity.Property(e => e.DeliveryRecordWithOutPackingList).HasColumnName("DeliveryRecord_WithOut_PackingList");

                entity.Property(e => e.DeliveryRecordWithOutPoreference).HasColumnName("DeliveryRecord_WithOut_POReference");

                entity.Property(e => e.EditCurrency).HasColumnName("Edit_Currency");

                entity.Property(e => e.EditCustomerCategory).HasColumnName("Edit_CustomerCategory");

                entity.Property(e => e.EditTaxStructure).HasColumnName("Edit_TaxStructure");

                entity.Property(e => e.EmployeeTypeId).HasColumnName("EmployeeTypeID");

                entity.Property(e => e.FullPaymentReceiveInInvoice).HasColumnName("Full_PaymentReceive_In_Invoice");

                entity.Property(e => e.FullyPaidInvoices).HasColumnName("FullyPaid_Invoices");

                entity.Property(e => e.InvoiceAgainstDeliveryRecord).HasColumnName("Invoice_AgainstDeliveryRecord");

                entity.Property(e => e.InvoiceWithOutPackingList).HasColumnName("Invoice_WithOut_PackingList");

                entity.Property(e => e.InvoiceWithOutPoreference).HasColumnName("Invoice_WithOut_POReference");

                entity.Property(e => e.InvoiceWithPoreference).HasColumnName("Invoice_With_POReference");

                entity.Property(e => e.MakeChangeInOrderQtyInInvoice).HasColumnName("Make_ChangeIn_OrderQty_In_Invoice");

                entity.Property(e => e.MakeChangeInPoitemRateInInvoice).HasColumnName("Make_ChangeIn_POItemRate_In_Invoice");

                entity.Property(e => e.MakeDiscountInInvoice).HasColumnName("Make_Discount_In_Invoice");

                entity.Property(e => e.MakePaymentReceiveInInvoice).HasColumnName("Make_PaymentReceive_In_Invoice");

                entity.Property(e => e.MarkCompletePoitemLessThanDeficientQtyLimitInDeliveryRecord).HasColumnName("Mark_CompletePOItem_LessThan_DeficientQtyLimit_In_DeliveryRecord");

                entity.Property(e => e.MarkCompletePoitemLessThanDeficientQtyLimitInInvoice).HasColumnName("Mark_CompletePOItem_LessThan_DeficientQtyLimit_In_Invoice");

                entity.Property(e => e.MarkCompletePoitemMoreThanExcessQtyLimitInDeliveryRecord).HasColumnName("Mark_CompletePOItem_MoreThan_ExcessQtyLimit_In_DeliveryRecord");

                entity.Property(e => e.MarkCompletePoitemMoreThanExcessQtyLimitInInvoice).HasColumnName("Mark_CompletePOItem_MoreThan_ExcessQtyLimit_In_Invoice");

                entity.Property(e => e.MktConfigurationAccess).HasColumnName("MKT_ConfigurationAccess");

                entity.Property(e => e.MktOtherConfiguration).HasColumnName("MKT_OtherConfiguration");

                entity.Property(e => e.MktReports).HasColumnName("MKT_Reports");

                entity.Property(e => e.PartialPaymentReceiveInInvoice).HasColumnName("Partial_PaymentReceive_In_Invoice");

                entity.Property(e => e.PartiallyPaidInvoices).HasColumnName("PartiallyPaid_Invoices");

                entity.Property(e => e.ReceivePaymentFromAdvance).HasColumnName("ReceivePayment_From_Advance");

                entity.Property(e => e.ReceivePaymentFromNewFund).HasColumnName("ReceivePayment_From_NewFund");

                entity.Property(e => e.RejectPo).HasColumnName("RejectPO");

                entity.Property(e => e.SalesOtherConfiguration).HasColumnName("Sales_OtherConfiguration");

                entity.Property(e => e.SendPaymentAgainstMaterialFromAdvance).HasColumnName("SendPayment_AgainstMaterial_From_Advance");

                entity.Property(e => e.SendPaymentAgainstMaterialFromNewFund).HasColumnName("SendPayment_AgainstMaterial_From_NewFund");

                entity.Property(e => e.SendPaymentForAdvance).HasColumnName("SendPayment_For_Advance");

                entity.Property(e => e.UnPaidInvoices).HasColumnName("UnPaid_Invoices");

                entity.Property(e => e.UpdateShipperEntry).HasColumnName("Update_ShipperEntry");

                entity.Property(e => e.UpdatedDt)
                    .HasColumnName("UpdatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdatedUserId)
                    .HasColumnName("UpdatedUserID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ViewAndPrintPoandPi).HasColumnName("ViewAndPrintPOAndPI");

                entity.Property(e => e.ViewListOfDeliveredDeliveryRecords).HasColumnName("ViewListOf_Delivered_DeliveryRecords");

                entity.Property(e => e.ViewListOfOnWayDeliveryRecords).HasColumnName("ViewListOf_OnWay_DeliveryRecords");

                entity.Property(e => e.ViewMktCustomerLoyalty).HasColumnName("View_MKT_CustomerLoyalty");

                entity.Property(e => e.ViewMktCustomerwiseSalesSummary).HasColumnName("View_MKT_Customerwise_SalesSummary");

                entity.Property(e => e.ViewMktInquiryLog).HasColumnName("View_MKT_InquiryLog");

                entity.Property(e => e.ViewMktInquiryResponse).HasColumnName("View_MKT_InquiryResponse");

                entity.Property(e => e.ViewMktInvoiceHistory).HasColumnName("View_MKT_InvoiceHistory");

                entity.Property(e => e.ViewMktPaymentReceiptHistory).HasColumnName("View_MKT_PaymentReceiptHistory");

                entity.Property(e => e.ViewMktProductwiseSalesSummary).HasColumnName("View_MKT_Productwise_SalesSummary");

                entity.Property(e => e.ViewMktQuotationHistory).HasColumnName("View_MKT_QuotationHistory");

                entity.Property(e => e.ViewMktQuoteLog).HasColumnName("View_MKT_QuoteLog");

                entity.Property(e => e.ViewMktReceivables).HasColumnName("View_MKT_Receivables");

                entity.Property(e => e.ViewMktSalesLog).HasColumnName("View_MKT_SalesLog");
            });

            modelBuilder.Entity<RightsMtl>(entity =>
            {
                entity.HasKey(e => e.MtlrightId);

                entity.ToTable("Rights_MTL");

                entity.Property(e => e.MtlrightId).HasColumnName("MTLRightID");

                entity.Property(e => e.AcceptCustomerReturns).HasColumnName("Accept_Customer_Returns");

                entity.Property(e => e.AcceptFinishedGoodsFromProduction).HasColumnName("Accept_FinishedGoods_From_Production");

                entity.Property(e => e.AcceptPurchasedMaterials).HasColumnName("Accept_Purchased_Materials");

                entity.Property(e => e.AcceptReturnedMaterials).HasColumnName("Accept_Returned_Materials");

                entity.Property(e => e.ApproveMtlPo).HasColumnName("Approve_MTL_PO");

                entity.Property(e => e.ApprovePartDraft).HasColumnName("Approve_PartDraft");

                entity.Property(e => e.ApprovePurchaseRequests).HasColumnName("Approve_PurchaseRequests");

                entity.Property(e => e.AutoApproveOwnPurchaseRequests).HasColumnName("AutoApprove_Own_PurchaseRequests");

                entity.Property(e => e.CancelIssuedMtlPo).HasColumnName("Cancel_Issued_MTL_PO");

                entity.Property(e => e.ConvertMtl).HasColumnName("Convert_MTL");

                entity.Property(e => e.CreatePartDraft).HasColumnName("Create_PartDraft");

                entity.Property(e => e.CreateSupplier).HasColumnName("Create_Supplier");

                entity.Property(e => e.CreatedDt)
                    .HasColumnName("CreatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedUserId).HasColumnName("CreatedUserID");

                entity.Property(e => e.DefaultPageTitle)
                    .IsRequired()
                    .HasColumnName("Default_PageTitle")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DeletePart).HasColumnName("Delete_Part");

                entity.Property(e => e.DeleteSupplier).HasColumnName("Delete_Supplier");

                entity.Property(e => e.DisposeMtl).HasColumnName("Dispose_MTL");

                entity.Property(e => e.EmployeeTypeId).HasColumnName("EmployeeTypeID");

                entity.Property(e => e.MiscMtltransactions).HasColumnName("Misc_MTLTransactions");

                entity.Property(e => e.MtlConfiguration).HasColumnName("MTL_Configuration");

                entity.Property(e => e.MtlEmailAlerts).HasColumnName("MTL_EmailAlerts");

                entity.Property(e => e.MtlReports).HasColumnName("MTL_Reports");

                entity.Property(e => e.MtlStockStatusReport).HasColumnName("MTL_StockStatus_Report");

                entity.Property(e => e.MtlacceptMakeExceptionInOrder).HasColumnName("MTLAccept_MakeExceptionInOrder");

                entity.Property(e => e.MtlissueAgainstApprovedRequest).HasColumnName("MTLIssue_Against_ApprovedRequest");

                entity.Property(e => e.MtlissueRegardlessRequestOrApproval).HasColumnName("MTLIssue_Regardless_RequestOrApproval");

                entity.Property(e => e.MtlpurchaseOrders).HasColumnName("MTLPurchaseOrders");

                entity.Property(e => e.MtlpurchaseRequests).HasColumnName("MTLPurchaseRequests");

                entity.Property(e => e.PartSpecificationEntry).HasColumnName("PartSpecification_Entry");

                entity.Property(e => e.PrepareMtlPo).HasColumnName("Prepare_MTL_PO");

                entity.Property(e => e.ReconcileMtl).HasColumnName("Reconcile_MTL");

                entity.Property(e => e.RevalueMtl).HasColumnName("Revalue_MTL");

                entity.Property(e => e.SupplierLogInteractions).HasColumnName("Supplier_Log_Interactions");

                entity.Property(e => e.SupplierRequestQuote).HasColumnName("Supplier_Request_Quote");

                entity.Property(e => e.SupplierReturnMaterials).HasColumnName("Supplier_Return_Materials");

                entity.Property(e => e.SupplierSellScrap).HasColumnName("Supplier_Sell_Scrap");

                entity.Property(e => e.UpdateMtlPo).HasColumnName("Update_MTL_PO");

                entity.Property(e => e.UpdatePart).HasColumnName("Update_Part");

                entity.Property(e => e.UpdateSupplier).HasColumnName("Update_Supplier");

                entity.Property(e => e.UpdatedDt)
                    .HasColumnName("UpdatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdatedUserId).HasColumnName("UpdatedUserID");

                entity.Property(e => e.ViewCompareSuppliers).HasColumnName("View_Compare_Suppliers");

                entity.Property(e => e.ViewPartPrintable).HasColumnName("View_PartPrintable");
            });

            modelBuilder.Entity<RightsMtlOld>(entity =>
            {
                entity.HasKey(e => e.MtlrightsId);

                entity.ToTable("Rights_MTL_Old");

                entity.Property(e => e.MtlrightsId).HasColumnName("MTLRightsID");

                entity.Property(e => e.ActivateOrDeactivateMtlsupplier).HasColumnName("ActivateOrDeactivate_MTLSupplier");

                entity.Property(e => e.ActivateOrDeactivateScrapBuyer).HasColumnName("ActivateOrDeactivate_ScrapBuyer");

                entity.Property(e => e.CreateCharacteristicEntry).HasColumnName("Create_CharacteristicEntry");

                entity.Property(e => e.CreateCharacteristicGroupEntry).HasColumnName("Create_CharacteristicGroupEntry");

                entity.Property(e => e.CreateMaterial).HasColumnName("Create_Material");

                entity.Property(e => e.CreateMtlBrand).HasColumnName("Create_MTL_Brand");

                entity.Property(e => e.CreateMtlCategory).HasColumnName("Create_MtlCategory");

                entity.Property(e => e.CreateMtlSubCategory).HasColumnName("Create_MtlSubCategory");

                entity.Property(e => e.CreateMtlsupplier).HasColumnName("Create_MTLSupplier");

                entity.Property(e => e.CreateOrUpdateLoginForMtlsupplier).HasColumnName("CreateOrUpdateLoginFor_MTLSupplier");

                entity.Property(e => e.CreateOrUpdateLoginForScrapBuyer).HasColumnName("CreateOrUpdateLoginFor_ScrapBuyer");

                entity.Property(e => e.CreateScrapBuyer).HasColumnName("Create_ScrapBuyer");

                entity.Property(e => e.CreateUnit).HasColumnName("Create_Unit");

                entity.Property(e => e.CreateUnitCategory).HasColumnName("Create_UnitCategory");

                entity.Property(e => e.CreatedDt)
                    .HasColumnName("CreatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedUserId)
                    .HasColumnName("CreatedUserID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.DefaultPage)
                    .IsRequired()
                    .HasColumnName("Default_Page")
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.DeleteCharacteristicEntry).HasColumnName("Delete_CharacteristicEntry");

                entity.Property(e => e.DeleteCharacteristicGroupEntry).HasColumnName("Delete_CharacteristicGroupEntry");

                entity.Property(e => e.DeleteMaterial).HasColumnName("Delete_Material");

                entity.Property(e => e.DeleteMtlBrand).HasColumnName("Delete_MTL_Brand");

                entity.Property(e => e.DeleteMtlCategory).HasColumnName("Delete_MtlCategory");

                entity.Property(e => e.DeleteMtlSubCategory).HasColumnName("Delete_MtlSubCategory");

                entity.Property(e => e.DeleteUnit).HasColumnName("Delete_Unit");

                entity.Property(e => e.DeleteUnitCategory).HasColumnName("Delete_UnitCategory");

                entity.Property(e => e.DirectIssueMaterial).HasColumnName("Direct_IssueMaterial");

                entity.Property(e => e.EditMaterial).HasColumnName("Edit_Material");

                entity.Property(e => e.EditMtlCategory).HasColumnName("Edit_MtlCategory");

                entity.Property(e => e.EditMtlSubCategory).HasColumnName("Edit_MtlSubCategory");

                entity.Property(e => e.EditUnit).HasColumnName("Edit_Unit");

                entity.Property(e => e.EditUnitCategory).HasColumnName("Edit_UnitCategory");

                entity.Property(e => e.EmployeeTypeId).HasColumnName("EmployeeTypeID");

                entity.Property(e => e.IssueMtlApproveOtherRequest).HasColumnName("IssueMTL_ApproveOtherRequest");

                entity.Property(e => e.MtlBrands).HasColumnName("MTL_Brands");

                entity.Property(e => e.MtlConfigurationAccess).HasColumnName("MTL_ConfigurationAccess");

                entity.Property(e => e.MtlReports).HasColumnName("MTL_Reports");

                entity.Property(e => e.MtlRevaluationStock).HasColumnName("MTL_Revaluation_Stock");

                entity.Property(e => e.MtlsupplierEntry).HasColumnName("MTLSupplierEntry");

                entity.Property(e => e.PoapprovaeOtherRequest).HasColumnName("POApprovaeOtherRequest");

                entity.Property(e => e.PoautoApprove).HasColumnName("POAutoApprove");

                entity.Property(e => e.PrapproveOtherRequest).HasColumnName("PRApproveOtherRequest");

                entity.Property(e => e.PrautoApprove).HasColumnName("PRAutoApprove");

                entity.Property(e => e.ReceiveMaterialFromCustomer).HasColumnName("ReceiveMaterial_FromCustomer");

                entity.Property(e => e.ReceiveMtlAgainstPo).HasColumnName("ReceiveMtl_AgainstPO");

                entity.Property(e => e.ReceiveMtlDirectReceive).HasColumnName("ReceiveMtl_DirectReceive");

                entity.Property(e => e.ReceiveMtlOtherRequest).HasColumnName("ReceiveMtl_OtherRequest");

                entity.Property(e => e.ReqMtlApproveOtherRequest).HasColumnName("ReqMTL_ApproveOtherRequest");

                entity.Property(e => e.ReqMtlAutoApprove).HasColumnName("ReqMTL_AutoApprove");

                entity.Property(e => e.ReturnMaterialToCustomer).HasColumnName("ReturnMaterial_ToCustomer");

                entity.Property(e => e.ReturnMaterialToStore).HasColumnName("ReturnMaterial_ToStore");

                entity.Property(e => e.ShowMtlStockValueInReports).HasColumnName("ShowMtlStockValue_In_Reports");

                entity.Property(e => e.UpdateCharacteristicEntry).HasColumnName("Update_CharacteristicEntry");

                entity.Property(e => e.UpdateMtlBrand).HasColumnName("Update_MTL_Brand");

                entity.Property(e => e.UpdateMtlsupplierEntry).HasColumnName("Update_MTLSupplierEntry");

                entity.Property(e => e.UpdateScrapBuyerEntry).HasColumnName("Update_ScrapBuyerEntry");

                entity.Property(e => e.UpdatedDt)
                    .HasColumnName("UpdatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdatedUserId)
                    .HasColumnName("UpdatedUserID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ViewListOfCharacteristicGroups).HasColumnName("ViewListOf_CharacteristicGroups");

                entity.Property(e => e.ViewListOfCharacteristics).HasColumnName("ViewListOf_Characteristics");

                entity.Property(e => e.ViewListOfMtlBrands).HasColumnName("ViewListOf_MTL_Brands");

                entity.Property(e => e.ViewListOfMtlsuppliers).HasColumnName("ViewListOfMTLSuppliers");

                entity.Property(e => e.ViewMtlConsolidatedStatus).HasColumnName("View_MTL_ConsolidatedStatus");

                entity.Property(e => e.ViewMtlConsumptionStatistics).HasColumnName("View_MTL_ConsumptionStatistics");

                entity.Property(e => e.ViewMtlExpiredStock).HasColumnName("View_MTL_ExpiredStock");

                entity.Property(e => e.ViewMtlIssueHistory).HasColumnName("View_MTL_IssueHistory");

                entity.Property(e => e.ViewMtlIssueRequests).HasColumnName("View_MTL_IssueRequests");

                entity.Property(e => e.ViewMtlPurchaseLog).HasColumnName("View_MTL_PurchaseLog");

                entity.Property(e => e.ViewMtlPurchaseRequests).HasColumnName("View_MTL_PurchaseRequests");

                entity.Property(e => e.ViewMtlStockAvailability).HasColumnName("View_MTL_StockAvailability");

                entity.Property(e => e.ViewMtlStockStatus).HasColumnName("View_MTL_StockStatus");

                entity.Property(e => e.ViewMtlSupplierwisePaymentHistory).HasColumnName("View_MTL_Supplierwise_PaymentHistory");

                entity.Property(e => e.ViewMtlSupplierwisePurchaseSummary).HasColumnName("View_MTL_Supplierwise_PurchaseSummary");

                entity.Property(e => e.ViewMtlTransactionLog).HasColumnName("View_MTL_TransactionLog");

                entity.Property(e => e.ViewSupplierAnalysis).HasColumnName("View_SupplierAnalysis");

                entity.Property(e => e.ViewSupplierPayables).HasColumnName("View_Supplier_Payables");
            });

            modelBuilder.Entity<RightsMyStuff>(entity =>
            {
                entity.HasKey(e => e.MyStuffRightId);

                entity.ToTable("Rights_MyStuff");

                entity.Property(e => e.MyStuffRightId).HasColumnName("MyStuffRightID");

                entity.Property(e => e.CreatedDt)
                    .HasColumnName("CreatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedUserId)
                    .HasColumnName("CreatedUserID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.DefaultPage)
                    .IsRequired()
                    .HasColumnName("Default_Page")
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.EmployeeTypeId).HasColumnName("EmployeeTypeID");

                entity.Property(e => e.UpdatedDt)
                    .HasColumnName("UpdatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdatedUserId)
                    .HasColumnName("UpdatedUserID")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<RightsPrd>(entity =>
            {
                entity.HasKey(e => e.PrdrightId);

                entity.ToTable("Rights_PRD");

                entity.Property(e => e.PrdrightId).HasColumnName("PRDRightID");

                entity.Property(e => e.ApprovePartDraft).HasColumnName("Approve_PartDraft");

                entity.Property(e => e.ChangePriorityWo).HasColumnName("ChangePriority_WO");

                entity.Property(e => e.ChangeScheduledJob).HasColumnName("Change_ScheduledJob");

                entity.Property(e => e.ChangeTargetDtWo).HasColumnName("ChangeTargetDT_WO");

                entity.Property(e => e.CreatePartDraft).HasColumnName("Create_PartDraft");

                entity.Property(e => e.CreatedDt)
                    .HasColumnName("CreatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedUserId).HasColumnName("CreatedUserID");

                entity.Property(e => e.DefaultPageTitle)
                    .IsRequired()
                    .HasColumnName("Default_PageTitle")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DeletePart).HasColumnName("Delete_Part");

                entity.Property(e => e.DeleteUnStartedScheduledJob).HasColumnName("Delete_UnStarted_ScheduledJob");

                entity.Property(e => e.EmployeeTypeId).HasColumnName("EmployeeTypeID");

                entity.Property(e => e.FullProcessAccess).HasColumnName("Full_ProcessAccess");

                entity.Property(e => e.JobHistoryReports).HasColumnName("JobHistory_Reports");

                entity.Property(e => e.NoProcessAccess).HasColumnName("No_ProcessAccess");

                entity.Property(e => e.PartSpecificationEntry).HasColumnName("PartSpecification_Entry");

                entity.Property(e => e.PerformanceCapacityUtilizationReports).HasColumnName("Performance_Capacity_Utilization_Reports");

                entity.Property(e => e.PrdAlertDailyProductionPerformance).HasColumnName("PRD_Alert_Daily_ProductionPerformance");

                entity.Property(e => e.PrdAlertWorkQueue).HasColumnName("PRD_Alert_WorkQueue");

                entity.Property(e => e.PrdAutoApproveMtlrequest).HasColumnName("PRD_AutoApprove_MTLRequest");

                entity.Property(e => e.PrdEmailAlerts).HasColumnName("PRD_EmailAlerts");

                entity.Property(e => e.PrdJobEstimationSettings).HasColumnName("PRD_JobEstimationSettings");

                entity.Property(e => e.PrdJobMovement).HasColumnName("PRD_JobMovement");

                entity.Property(e => e.PrdJobScheduling).HasColumnName("PRD_JobScheduling");

                entity.Property(e => e.PrdMaterialRequest).HasColumnName("PRD_MaterialRequest");

                entity.Property(e => e.PrdMiscSettings).HasColumnName("PRD_MiscSettings");

                entity.Property(e => e.PrdOtherConfiguration).HasColumnName("PRD_Other_Configuration");

                entity.Property(e => e.PrdPanelManagement).HasColumnName("PRD_PanelManagement");

                entity.Property(e => e.PrdProcessAccessibility).HasColumnName("PRD_ProcessAccessibility");

                entity.Property(e => e.PrdProcessConfiguration).HasColumnName("PRD_ProcessConfiguration");

                entity.Property(e => e.PrdProcessGroups).HasColumnName("PRD_ProcessGroups");

                entity.Property(e => e.PrdProcessMaintenanceParameterReading).HasColumnName("PRD_ProcessMaintenance_ParameterReading");

                entity.Property(e => e.PrdProcesses).HasColumnName("PRD_Processes");

                entity.Property(e => e.PrdRejectionConfiguration).HasColumnName("PRD_RejectionConfiguration");

                entity.Property(e => e.PrdReports).HasColumnName("PRD_Reports");

                entity.Property(e => e.PrdSetProductionTargets).HasColumnName("PRD_Set_Production_Targets");

                entity.Property(e => e.PrdViewTraveler).HasColumnName("PRD_ViewTraveler");

                entity.Property(e => e.PrdWoCloseJob).HasColumnName("PRD_WO_CloseJob");

                entity.Property(e => e.PrdWoEnterQcInspectionData).HasColumnName("PRD_WO_Enter_QC_InspectionData");

                entity.Property(e => e.PrdWoPauseResumeJob).HasColumnName("PRD_WO_PauseResumeJob");

                entity.Property(e => e.PrdWoStartJob).HasColumnName("PRD_WO_StartJob");

                entity.Property(e => e.PrdWopPlanMovement).HasColumnName("PRD_WOP_PlanMovement");

                entity.Property(e => e.PrdWorkInProcess).HasColumnName("PRD_WorkInProcess");

                entity.Property(e => e.PrintJobCardPrd).HasColumnName("PrintJobCard_PRD");

                entity.Property(e => e.ReasonsRejectionRework).HasColumnName("Reasons_Rejection_Rework");

                entity.Property(e => e.RejectionQcAnalysisReports).HasColumnName("Rejection_QC_Analysis_Reports");

                entity.Property(e => e.RunAutoSchedulerPrdPpq).HasColumnName("RunAutoScheduler_PRD_PPQ");

                entity.Property(e => e.ScheduleNewJob).HasColumnName("Schedule_NewJob");

                entity.Property(e => e.SelectiveProcessAccess).HasColumnName("Selective_ProcessAccess");

                entity.Property(e => e.ShowCustomerPrdWip).HasColumnName("ShowCustomer_PRD_WIP");

                entity.Property(e => e.UpdatePart).HasColumnName("Update_Part");

                entity.Property(e => e.UpdatedDt)
                    .HasColumnName("UpdatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdatedUserId).HasColumnName("UpdatedUserID");

                entity.Property(e => e.ViewAllDeptPrdWip).HasColumnName("ViewAllDept_PRD_WIP");

                entity.Property(e => e.ViewCustomerOrderJobScheduling).HasColumnName("ViewCustomerOrder_JobScheduling");

                entity.Property(e => e.ViewPartPrintable).HasColumnName("View_PartPrintable");

                entity.Property(e => e.ViewScheduledJob).HasColumnName("View_ScheduledJob");
            });

            modelBuilder.Entity<RightsPrdOld>(entity =>
            {
                entity.HasKey(e => e.PrdrightsId);

                entity.ToTable("Rights_PRD_Old");

                entity.Property(e => e.PrdrightsId).HasColumnName("PRDRightsID");

                entity.Property(e => e.AddFiles).HasColumnName("Add_Files");

                entity.Property(e => e.AllowUpdatePartDefAfterLocking).HasColumnName("AllowUpdate_PartDef_AfterLocking");

                entity.Property(e => e.ChangeExistingFiles).HasColumnName("Change_Existing_Files");

                entity.Property(e => e.ConfigurationProductionPlanning).HasColumnName("Configuration_ProductionPlanning");

                entity.Property(e => e.CreateFailureType).HasColumnName("Create_FailureType");

                entity.Property(e => e.CreatePartEntry).HasColumnName("Create_PartEntry");

                entity.Property(e => e.CreateProcessEntry).HasColumnName("Create_ProcessEntry");

                entity.Property(e => e.CreateProcessGroupEntry).HasColumnName("Create_ProcessGroupEntry");

                entity.Property(e => e.CreateRemedies).HasColumnName("Create_Remedies");

                entity.Property(e => e.CreatedDt)
                    .HasColumnName("CreatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedUserId)
                    .HasColumnName("CreatedUserID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.DefaultPage)
                    .IsRequired()
                    .HasColumnName("Default_Page")
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.DeleteFailureType).HasColumnName("Delete_FailureType");

                entity.Property(e => e.DeleteInactiveJob).HasColumnName("Delete_Inactive_Job");

                entity.Property(e => e.DeletePartEntry).HasColumnName("Delete_PartEntry");

                entity.Property(e => e.DeleteProcessEntry).HasColumnName("Delete_ProcessEntry");

                entity.Property(e => e.DeleteProcessGroupEntry).HasColumnName("Delete_ProcessGroupEntry");

                entity.Property(e => e.DeleteRemedies).HasColumnName("Delete_Remedies");

                entity.Property(e => e.DeleteScheduledUnstartedJob).HasColumnName("Delete_Scheduled_Unstarted_Job");

                entity.Property(e => e.EditCharacteristicsInPartEntry).HasColumnName("Edit_Characteristics_In_PartEntry");

                entity.Property(e => e.EditFailureType).HasColumnName("Edit_FailureType");

                entity.Property(e => e.EditPanelInPartEntry).HasColumnName("Edit_Panel_In_PartEntry");

                entity.Property(e => e.EditPartEntry).HasColumnName("Edit_PartEntry");

                entity.Property(e => e.EditProcessFlowInPartEntry).HasColumnName("Edit_ProcessFlow_In_PartEntry");

                entity.Property(e => e.EditProductionTargets).HasColumnName("Edit_ProductionTargets");

                entity.Property(e => e.EditRemedies).HasColumnName("Edit_Remedies");

                entity.Property(e => e.EmployeeTypeId).HasColumnName("EmployeeTypeID");

                entity.Property(e => e.FileManagementForParts).HasColumnName("FileManagement_ForParts");

                entity.Property(e => e.FullProcessAccess).HasColumnName("Full_ProcessAccess");

                entity.Property(e => e.IsShowInfoOfOtherDept).HasColumnName("IsShowInfo_Of_OtherDept");

                entity.Property(e => e.NoProcessAccess).HasColumnName("No_ProcessAccess");

                entity.Property(e => e.PartEntryWithMultipleCustomers).HasColumnName("PartEntry_With_MultipleCustomers");

                entity.Property(e => e.PrdConfiguration).HasColumnName("PRD_Configuration");

                entity.Property(e => e.PrdOtherConfiguration).HasColumnName("PRD_OtherConfiguration");

                entity.Property(e => e.PrdReports).HasColumnName("PRD_Reports");

                entity.Property(e => e.ProcessGroupId)
                    .HasColumnName("ProcessGroupID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.SelectiveProcessAccess).HasColumnName("Selective_ProcessAccess");

                entity.Property(e => e.SetPlannedCompletionDate).HasColumnName("Set_Planned_CompletionDate");

                entity.Property(e => e.ShowPodetail).HasColumnName("ShowPODetail");

                entity.Property(e => e.UpdateProcessEntry).HasColumnName("Update_ProcessEntry");

                entity.Property(e => e.UpdatedDt)
                    .HasColumnName("UpdatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdatedUserId)
                    .HasColumnName("UpdatedUserID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ViewDailyProductionOutput).HasColumnName("View_Daily_Production_Output");

                entity.Property(e => e.ViewFiles).HasColumnName("View_Files");

                entity.Property(e => e.ViewListOfCompletedJobList).HasColumnName("ViewListOf_Completed_JobList");

                entity.Property(e => e.ViewListOfFutureJobList).HasColumnName("ViewListOf_Future_JobList");

                entity.Property(e => e.ViewListOfInactiveJobs).HasColumnName("ViewListOf_Inactive_Jobs");

                entity.Property(e => e.ViewListOfPausedJobList).HasColumnName("ViewListOf_Paused_JobList");

                entity.Property(e => e.ViewListOfPendingJobList).HasColumnName("ViewListOf_Pending_JobList");

                entity.Property(e => e.ViewListOfProcessGroups).HasColumnName("ViewListOf_ProcessGroups");

                entity.Property(e => e.ViewListOfProcesses).HasColumnName("ViewListOf_Processes");

                entity.Property(e => e.ViewListOfQueueJobList).HasColumnName("ViewListOf_Queue_JobList");

                entity.Property(e => e.ViewListOfUnStartedJobList).HasColumnName("ViewListOf_UnStarted_JobList");

                entity.Property(e => e.ViewPrdJobwiseOutputEfficiency).HasColumnName("View_PRD_Jobwise_OutputEfficiency");

                entity.Property(e => e.ViewPrdProcessCapacityUtilization).HasColumnName("View_PRD_ProcessCapacity_Utilization");

                entity.Property(e => e.ViewPrdProcessCapacityUtilizationSummary).HasColumnName("View_PRD_ProcessCapacity_Utilization_Summary");

                entity.Property(e => e.ViewPrdProcessEfficiency).HasColumnName("View_PRD_ProcessEfficiency");

                entity.Property(e => e.ViewPrdProcessEfficiencyInDetail).HasColumnName("View_PRD_ProcessEfficiency_In_Detail");

                entity.Property(e => e.ViewPrdProcessPerformance).HasColumnName("View_PRD_ProcessPerformance");

                entity.Property(e => e.ViewPrdProcesswiseOutputEfficiency).HasColumnName("View_PRD_Processwise_OutputEfficiency");

                entity.Property(e => e.ViewPrdProcesswiseRejectionAnalysis).HasColumnName("View_PRD_Processwise_RejectionAnalysis");

                entity.Property(e => e.ViewPrdProcesswiseRejectionList).HasColumnName("View_PRD_Processwise_RejectionList");

                entity.Property(e => e.ViewPrdProcesswiseRejectionTrend).HasColumnName("View_PRD_Processwise_RejectionTrend");

                entity.Property(e => e.ViewPrdProductTypewiseOutputEfficiency).HasColumnName("View_PRD_ProductTypewise_OutputEfficiency");

                entity.Property(e => e.ViewPrdRejectionDetailsForProcess).HasColumnName("View_PRD_RejectionDetails_For_Process");

                entity.Property(e => e.ViewPrdRejectionRecords).HasColumnName("View_PRD_RejectionRecords");

                entity.Property(e => e.ViewPrdRejectionTrendForProcess).HasColumnName("View_PRD_RejectionTrend_For_Process");

                entity.Property(e => e.ViewPrdRemedialActions).HasColumnName("View_PRD_RemedialActions");

                entity.Property(e => e.ViewPrdWorkSequence).HasColumnName("View_PRD_WorkSequence");

                entity.Property(e => e.ViewProcesswiseWorkLoad).HasColumnName("View_Processwise_WorkLoad");

                entity.Property(e => e.ViewProductionEfficiency).HasColumnName("View_ProductionEfficiency");

                entity.Property(e => e.ViewProductionPerformance).HasColumnName("View_ProductionPerformance");

                entity.Property(e => e.ViewProductionTargets).HasColumnName("View_ProductionTargets");

                entity.Property(e => e.ViewProductionVolume).HasColumnName("View_ProductionVolume");
            });

            modelBuilder.Entity<RoleM>(entity =>
            {
                entity.HasKey(e => e.RoleId);

                entity.ToTable("Role_M");

                entity.Property(e => e.RoleId).HasColumnName("RoleID");

                entity.Property(e => e.CreatedDt)
                    .HasColumnName("CreatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedUserId).HasColumnName("CreatedUserID");

                entity.Property(e => e.RoleName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedDt)
                    .HasColumnName("UpdatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdatedUserId).HasColumnName("UpdatedUserID");
            });

            modelBuilder.Entity<StateM>(entity =>
            {
                entity.HasKey(e => e.StateId);

                entity.ToTable("State_M");

                entity.Property(e => e.StateId).HasColumnName("StateID");

                entity.Property(e => e.CountryId).HasColumnName("CountryID");

                entity.Property(e => e.CreatedDt)
                    .HasColumnName("CreatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedUserId).HasColumnName("CreatedUserID");

                entity.Property(e => e.StateName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedDt)
                    .HasColumnName("UpdatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdatedUserId).HasColumnName("UpdatedUserID");
            });

            modelBuilder.Entity<TermsCategoryM>(entity =>
            {
                entity.HasKey(e => e.TermsCategoryId);

                entity.ToTable("TermsCategory_M");

                entity.Property(e => e.TermsCategoryId).HasColumnName("TermsCategoryID");

                entity.Property(e => e.CreatedDt)
                    .HasColumnName("CreatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedUserId).HasColumnName("CreatedUserID");

                entity.Property(e => e.TermsCategoryName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedDt)
                    .HasColumnName("UpdatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdatedUserId).HasColumnName("UpdatedUserID");
            });

            modelBuilder.Entity<UnitCategoryM>(entity =>
            {
                entity.HasKey(e => e.UnitCategoryId);

                entity.ToTable("UnitCategory_M");

                entity.Property(e => e.UnitCategoryId).HasColumnName("UnitCategoryID");

                entity.Property(e => e.CreatedDt)
                    .HasColumnName("CreatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedUserId).HasColumnName("CreatedUserID");

                entity.Property(e => e.UnitCategory)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedDt)
                    .HasColumnName("UpdatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdatedUserId).HasColumnName("UpdatedUserID");
            });

            modelBuilder.Entity<UnitM>(entity =>
            {
                entity.HasKey(e => e.UnitId);

                entity.ToTable("Unit_M");

                entity.Property(e => e.UnitId).HasColumnName("UnitID");

                entity.Property(e => e.BasisUnitId).HasColumnName("Basis_UnitID");

                entity.Property(e => e.ConversionFactor).HasDefaultValueSql("((0))");

                entity.Property(e => e.CreatedDt)
                    .HasColumnName("CreatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedUserId).HasColumnName("CreatedUserID");

                entity.Property(e => e.UnitCategoryId).HasColumnName("UnitCategoryID");

                entity.Property(e => e.UnitName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedDt)
                    .HasColumnName("UpdatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdatedUserId).HasColumnName("UpdatedUserID");
            });

            modelBuilder.Entity<UserH>(entity =>
            {
                entity.ToTable("User_H");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.LoginDate).HasColumnType("datetime");

                entity.Property(e => e.LogoutDate).HasColumnType("datetime");

                entity.Property(e => e.UserId).HasColumnName("UserID");
            });

            modelBuilder.Entity<UserM>(entity =>
            {
                entity.HasKey(e => e.UserId);

                entity.ToTable("User_M");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.ChangePwdDate).HasColumnType("smalldatetime");

                entity.Property(e => e.CreatedDt)
                    .HasColumnName("CreatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedUserId).HasColumnName("CreatedUserID");

                entity.Property(e => e.CustomerId)
                    .HasColumnName("CustomerID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.EmailId)
                    .IsRequired()
                    .HasColumnName("EmailID")
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.EmployeeId)
                    .HasColumnName("EmployeeID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Fingerprint).HasMaxLength(5000);

                entity.Property(e => e.IsCrmuser).HasColumnName("IsCRMUser");

                entity.Property(e => e.LastMailCheckDt)
                    .HasColumnName("LastMailCheckDT")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.LoginName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.PinNum).HasColumnName("PIN_Num");

                entity.Property(e => e.SecretAnswer)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SecretQuestion)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SupplierId)
                    .HasColumnName("SupplierID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.UpdatedDt)
                    .HasColumnName("UpdatedDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdatedUserId).HasColumnName("UpdatedUserID");
            });

            modelBuilder.Entity<WebPageM>(entity =>
            {
                entity.HasKey(e => e.WebPageId);

                entity.ToTable("WebPage_M");

                entity.Property(e => e.WebPageId).HasColumnName("WebPageID");

                entity.Property(e => e.WebPageDisplayName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.WebPageName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.WebPageOrder).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<WipbalanceM>(entity =>
            {
                entity.HasKey(e => e.WipbalanceId);

                entity.ToTable("WIPBalance_M");

                entity.Property(e => e.WipbalanceId).HasColumnName("WIPBalanceID");

                entity.Property(e => e.ProcessGroupId).HasColumnName("ProcessGroupID");

                entity.Property(e => e.RptAsOnDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Wip).HasColumnName("WIP");
            });
        }
    }
}
