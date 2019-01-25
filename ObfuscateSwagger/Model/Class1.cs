using System;
using System.Collections.Generic;
using System.Text;

namespace ObfuscateSwagger
{

    public class Rootobject
    {
        public string openapi { get; set; }
        public Info info { get; set; }
        public Server[] servers { get; set; }
        public Paths paths { get; set; }
        public Components components { get; set; }
        public Security[] security { get; set; }
    }

    public class Info
    {
        public string title { get; set; }
        public string description { get; set; }
        public string version { get; set; }
    }

    public class Paths
    {
        public ApiTags apiTags { get; set; }
        public ApiTagsKey apiTagskey { get; set; }
        public ApiTagsKeyRelatedtagsRef apiTagskeyRelatedTagsref { get; set; }
        public ApiTagsKeyRelatedtagsRelatedkeyRef apiTagskeyRelatedTagsrelatedKeyref { get; set; }
        public ApiUser apiUser { get; set; }
        public ApiRegisterorgunitimpersonation apiRegisterOrgUnitImpersonation { get; set; }
        public ApiFiles apiFiles { get; set; }
        public ApiFilesKey apiFileskey { get; set; }
        public ApiPlans apiPlans { get; set; }
        public ApiPlansKey apiPlanskey { get; set; }
        public ApiRoles apiRoles { get; set; }
        public ApiRolesKey apiRoleskey { get; set; }
        public ApiUsers apiUsers { get; set; }
        public ApiUsersKey apiUserskey { get; set; }
        public ApiUsersKeyUnlock apiUserskeyUnlock { get; set; }
        public ApiUsersKeySetroles apiUserskeySetRoles { get; set; }
        public ApiSurveys apiSurveys { get; set; }
        public ApiSurveysKey apiSurveyskey { get; set; }
        public ApiCatalogs apiCatalogs { get; set; }
        public ApiCatalogsKey apiCatalogskey { get; set; }
        public ApiOrgunits apiOrgUnits { get; set; }
        public ApiOrgunitsKey apiOrgUnitskey { get; set; }
        public ApiOrgunitsIdSubscribers apiOrgUnitsidSubscribers { get; set; }
        public ApiOrgunitsIdEmployeeimports apiOrgUnitsidEmployeeImports { get; set; }
        public ApiOrgunitsIdCurrentperiodemployees apiOrgUnitsidCurrentPeriodEmployees { get; set; }
        public ApiOrgunitsKeyImportfile apiOrgUnitskeyImportFile { get; set; }
        public ApiOrgunitsKeyQueueunregisteredemployeemails apiOrgUnitskeyQueueUnregisteredEmployeeMails { get; set; }
        public ApiProducts apiProducts { get; set; }
        public ApiProductsKey apiProductskey { get; set; }
        public ApiProductsKeyGetproductruns apiProductskeyGetProductRuns { get; set; }
        public ApiProductsBulkassign apiProductsBulkAssign { get; set; }
        public ApiProfiles apiProfiles { get; set; }
        public ApiProfilesKey apiProfileskey { get; set; }
        public ApiProfilesIdTaggedcontentitems apiProfilesidTaggedContentItems { get; set; }
        public ApiProfilesKeyDeletetag apiProfileskeyDeleteTag { get; set; }
        public ApiProfilesKeyExcludetag apiProfileskeyExcludeTag { get; set; }
        public ApiProfilesKeyIncludetag apiProfileskeyIncludeTag { get; set; }
        public ApiProfilesKeyProfilebubble apiProfileskeyProfileBubble { get; set; }
        public ApiCosttypes apiCostTypes { get; set; }
        public ApiCosttypesKey apiCostTypeskey { get; set; }
        public ApiEmployees apiEmployees { get; set; }
        public ApiEmployeesKey apiEmployeeskey { get; set; }
        public ApiEmployeesKeyNotifications apiEmployeeskeyNotifications { get; set; }
        public ApiEmployeesKeyCurrentperiodemployee apiEmployeeskeyCurrentPeriodEmployee { get; set; }
        public ApiEmployeesBulkcreatenotifications apiEmployeesBulkCreateNotifications { get; set; }
        public ApiEmployeesKeyMarknotificationasread apiEmployeeskeyMarkNotificationAsRead { get; set; }
        public ApiActivations apiActivations { get; set; }
        public ApiActivationsKey apiActivationskey { get; set; }
        public ApiActivationsAddmanager apiActivationsAddManager { get; set; }
        public ApiActivationsKeyQueuemail apiActivationskeyQueueMail { get; set; }
        public ApiActivationsKeyGenerateletter apiActivationskeyGenerateLetter { get; set; }
        public ApiPlancomments apiPlanComments { get; set; }
        public ApiPlancommentsKey apiPlanCommentskey { get; set; }
        public ApiTransactions apiTransactions { get; set; }
        public ApiTransactionsKey apiTransactionskey { get; set; }
        public ApiTransactionsBulkrefund apiTransactionsBulkRefund { get; set; }
        public ApiTransactionsBulkreject apiTransactionsBulkReject { get; set; }
        public ApiTransactionsBulkapprove apiTransactionsBulkApprove { get; set; }
        public ApiTransactionsKeyCancel apiTransactionskeyCancel { get; set; }
        public ApiTransactionsKeyRefund apiTransactionskeyRefund { get; set; }
        public ApiTransactionsKeyReject apiTransactionskeyReject { get; set; }
        public ApiTransactionsKeyApprove apiTransactionskeyApprove { get; set; }
        public ApiTransactionsKeyConfirm apiTransactionskeyConfirm { get; set; }
        public ApiTransactionsKeyRateproduct apiTransactionskeyRateProduct { get; set; }
        public ApiTransactionsKeyConfirmafterapproval apiTransactionskeyConfirmAfterApproval { get; set; }
        public ApiDiscountrules apiDiscountRules { get; set; }
        public ApiDiscountrulesKey apiDiscountRuleskey { get; set; }
        public ApiDiscountrulesKeyExcludedcosttypesRef apiDiscountRuleskeyExcludedCostTypesref { get; set; }
        public ApiDiscountrulesBulkcopy apiDiscountRulesBulkCopy { get; set; }
        public ApiDiscountrulesBulkdelete apiDiscountRulesBulkDelete { get; set; }
        public ApiDiscountrulesKeyExcludedcosttypesRelatedkeyRef apiDiscountRuleskeyExcludedCostTypesrelatedKeyref { get; set; }
        public ApiNotifications apiNotifications { get; set; }
        public ApiNotificationsKey apiNotificationskey { get; set; }
        public ApiOrgunitreport apiOrgUnitReport { get; set; }
        public ApiInstanceinformation apiInstanceInformation { get; set; }
        public ApiProductgroups apiProductGroups { get; set; }
        public ApiProductgroupsKey apiProductGroupskey { get; set; }
        public ApiProductgroupsKeyNavigationpropertyRef apiProductGroupskeynavigationPropertyref { get; set; }
        public ApiProductgroupsKeyNavigationpropertyRelatedkeyRef apiProductGroupskeynavigationPropertyrelatedKeyref { get; set; }
        public ApiOrgunitbudgets apiOrgUnitBudgets { get; set; }
        public ApiOrgunitbudgetsKey apiOrgUnitBudgetskey { get; set; }
        public ApiOrgunitbudgetsKeyAdjustments apiOrgUnitBudgetskeyAdjustments { get; set; }
        public ApiOrgunitbudgetsKeyAdjustbudget apiOrgUnitBudgetskeyAdjustBudget { get; set; }
        public ApiOrgunitsKeyPrioritizeorgunitbudgets apiOrgUnitskeyPrioritizeOrgUnitBudgets { get; set; }
        public ApiEmployeebudgets apiEmployeeBudgets { get; set; }
        public ApiEmployeebudgetsKey apiEmployeeBudgetskey { get; set; }
        public ApiEmployeebudgetsIdAdjustments apiEmployeeBudgetsidAdjustments { get; set; }
        public ApiEmployeebudgetsKeyCurrentbalance apiEmployeeBudgetskeyCurrentBalance { get; set; }
        public ApiEmployeebudgetsAdjustbudgets apiEmployeeBudgetsAdjustBudgets { get; set; }
        public ApiEmployeebudgetsKeyAdjustbudget apiEmployeeBudgetskeyAdjustBudget { get; set; }
        public ApiEmployeeimports apiEmployeeImports { get; set; }
        public ApiEmployeeimportsKey apiEmployeeImportskey { get; set; }
        public ApiOrgunitchannels apiOrgUnitChannels { get; set; }
        public ApiOrgunitchannelsKey apiOrgUnitChannelskey { get; set; }
        public ApiOrgunitcryptors apiOrgUnitCryptors { get; set; }
        public ApiOrgunitcryptorsKey apiOrgUnitCryptorskey { get; set; }
        public ApiPeriodemployees apiPeriodEmployees { get; set; }
        public ApiPeriodemployeesKey apiPeriodEmployeeskey { get; set; }
        public ApiSurveyresponses apiSurveyResponses { get; set; }
        public ApiSurveyresponsesKey apiSurveyResponseskey { get; set; }
        public ApiProductsuppliers apiProductSuppliers { get; set; }
        public ApiProductsuppliersKey apiProductSupplierskey { get; set; }
        public ApiOrgunitconnectors apiOrgUnitConnectors { get; set; }
        public ApiOrgunitconnectorsKey apiOrgUnitConnectorskey { get; set; }
        public ApiOrgunitconnectorsKeyEnqueuejob apiOrgUnitConnectorskeyEnqueueJob { get; set; }
        public ApiTemplateresources apiTemplateResources { get; set; }
        public ApiTemplateresourcesKey apiTemplateResourceskey { get; set; }
        public ApiTaggedcontentitems apiTaggedContentItems { get; set; }
        public ApiTaggedcontentitemsKey apiTaggedContentItemskey { get; set; }
        public ApiTaggedcontentitemsKeyTagsRef apiTaggedContentItemskeyTagsref { get; set; }
        public ApiTaggedcontentitemsKeyTagsRelatedkeyRef apiTaggedContentItemskeyTagsrelatedKeyref { get; set; }
        public ApiTracktracemessages apiTrackTraceMessages { get; set; }
        public ApiTracktracemessagesKey apiTrackTraceMessageskey { get; set; }
        public ApiCatalogsubscriptions apiCatalogSubscriptions { get; set; }
        public ApiCatalogsubscriptionsKey apiCatalogSubscriptionskey { get; set; }
        public ApiProductchoicebatches apiProductChoiceBatches { get; set; }
        public ApiProductchoicebatchesKey apiProductChoiceBatcheskey { get; set; }
        public ApiProductchoicebatchesKeyReprocess apiProductChoiceBatcheskeyReprocess { get; set; }
        public ApiOrgunitauthenticators apiOrgUnitAuthenticators { get; set; }
        public ApiOrgunitauthenticatorsKey apiOrgUnitAuthenticatorskey { get; set; }
        public ApiApplicationconfigurations apiApplicationConfigurations { get; set; }
        public ApiApplicationconfigurationsKey apiApplicationConfigurationskey { get; set; }
        public ApiEmployeedatamodifications apiEmployeeDataModifications { get; set; }
        public ApiEmployeedatamodificationsKey apiEmployeeDataModificationskey { get; set; }
        public ApiEmployeedatamodificationsKeyModify apiEmployeeDataModificationskeyModify { get; set; }
        public ApiEmployeedatamodificationsKeyReject apiEmployeeDataModificationskeyReject { get; set; }
        public ApiEmployeedatamodificationsKeyApprove apiEmployeeDataModificationskeyApprove { get; set; }
        public ApiEmployeedatamodificationsKeyReprocess apiEmployeeDataModificationskeyReprocess { get; set; }
        public ApiProductimportspecifications apiProductImportSpecifications { get; set; }
        public ApiProductimportspecificationsKey apiProductImportSpecificationskey { get; set; }
        public ApiProductimportspecificationsKeyImportfile apiProductImportSpecificationskeyImportFile { get; set; }
        public ApiEmployeesIdTransactions apiEmployeesidTransactions { get; set; }
        public ApiEmployeesIdCurrenttotalbudgetbalance apiEmployeesidCurrentTotalBudgetBalance { get; set; }
        public ApiEmployeesIdProductspecifications apiEmployeesidProductSpecifications { get; set; }
        public ApiEmployeesIdCreatetransaction apiEmployeesidCreateTransaction { get; set; }
        public ApiEnumerationvaluesEnumtypeEnumtype apiEnumerationValuesEnumTypeenumType { get; set; }
        public ApiUnsubscribe apiUnsubscribe { get; set; }
        public ApiProductspecificationsRuntest apiProductSpecificationsRunTest { get; set; }
        public ApiProductspecificationsGenerate apiProductSpecificationsGenerate { get; set; }
        public ApiEmployeesKeyCreatemodification apiEmployeeskeyCreateModification { get; set; }
    }

    public class ApiTags
    {
        public Get get { get; set; }
        public Post post { get; set; }
    }

    public class Get
    {
        public string[] tags { get; set; }
        public string operationId { get; set; }
        public Parameter[] parameters { get; set; }
        public Responses responses { get; set; }
        public string[] xroles { get; set; }
    }

    public class Responses
    {
        public _200 _200 { get; set; }
    }

    public class _200
    {
        public string description { get; set; }
        public Content content { get; set; }
    }

    public class Content
    {
        public ApplicationJson applicationjson { get; set; }
    }

    public class ApplicationJson
    {
        public Schema schema { get; set; }
    }

    public class Schema
    {
        public string type { get; set; }
        public bool nullable { get; set; }
        public Items items { get; set; }
    }

    public class Items
    {
        public string _ref { get; set; }
    }

    public class Parameter
    {
        public string name { get; set; }
        public string _in { get; set; }
        public string description { get; set; }
        public Schema1 schema { get; set; }
    }

    public class Schema1
    {
        public string type { get; set; }
        public bool nullable { get; set; }
        public string format { get; set; }
    }

    public class Post
    {
        public string[] tags { get; set; }
        public string operationId { get; set; }
        public Requestbody requestBody { get; set; }
        public Responses1 responses { get; set; }
        public string[] xroles { get; set; }
    }

    public class Requestbody
    {
        public string xname { get; set; }
        public Content1 content { get; set; }
        public bool required { get; set; }
    }

    public class Content1
    {
        public ApplicationJson1 applicationjson { get; set; }
    }

    public class ApplicationJson1
    {
        public Schema2 schema { get; set; }
    }

    public class Schema2
    {
        public string _ref { get; set; }
    }

    public class Responses1
    {
        public _2001 _200 { get; set; }
    }

    public class _2001
    {
        public string description { get; set; }
        public Content2 content { get; set; }
    }

    public class Content2
    {
        public ApplicationJson2 applicationjson { get; set; }
    }

    public class ApplicationJson2
    {
        public Schema3 schema { get; set; }
    }

    public class Schema3
    {
        public string type { get; set; }
    }

    public class ApiTagsKey
    {
        public Get1 get { get; set; }
        public Patch patch { get; set; }
        public Delete delete { get; set; }
    }

    public class Get1
    {
        public string[] tags { get; set; }
        public string operationId { get; set; }
        public Parameter1[] parameters { get; set; }
        public Responses2 responses { get; set; }
        public string[] xroles { get; set; }
    }

    public class Responses2
    {
        public _2002 _200 { get; set; }
    }

    public class _2002
    {
        public string description { get; set; }
        public Content3 content { get; set; }
    }

    public class Content3
    {
        public ApplicationJson3 applicationjson { get; set; }
    }

    public class ApplicationJson3
    {
        public Schema4 schema { get; set; }
    }

    public class Schema4
    {
        public bool nullable { get; set; }
        public Oneof[] oneOf { get; set; }
    }

    public class Oneof
    {
        public string _ref { get; set; }
    }

    public class Parameter1
    {
        public string name { get; set; }
        public string _in { get; set; }
        public bool required { get; set; }
        public Schema5 schema { get; set; }
        public string description { get; set; }
    }

    public class Schema5
    {
        public string type { get; set; }
        public string format { get; set; }
        public bool nullable { get; set; }
    }

    public class Patch
    {
        public string[] tags { get; set; }
        public string operationId { get; set; }
        public Parameter2[] parameters { get; set; }
        public Requestbody1 requestBody { get; set; }
        public Responses3 responses { get; set; }
        public string[] xroles { get; set; }
    }

    public class Requestbody1
    {
        public string xname { get; set; }
        public Content4 content { get; set; }
        public bool required { get; set; }
    }

    public class Content4
    {
        public ApplicationJson4 applicationjson { get; set; }
    }

    public class ApplicationJson4
    {
        public Schema6 schema { get; set; }
    }

    public class Schema6
    {
        public string _ref { get; set; }
    }

    public class Responses3
    {
        public _2003 _200 { get; set; }
    }

    public class _2003
    {
        public string description { get; set; }
        public Content5 content { get; set; }
    }

    public class Content5
    {
        public ApplicationJson5 applicationjson { get; set; }
    }

    public class ApplicationJson5
    {
        public Schema7 schema { get; set; }
    }

    public class Schema7
    {
        public string type { get; set; }
    }

    public class Parameter2
    {
        public string name { get; set; }
        public string _in { get; set; }
        public bool required { get; set; }
        public Schema8 schema { get; set; }
    }

    public class Schema8
    {
        public string type { get; set; }
        public string format { get; set; }
    }

    public class Delete
    {
        public string[] tags { get; set; }
        public string operationId { get; set; }
        public Parameter3[] parameters { get; set; }
        public Responses4 responses { get; set; }
        public string[] xroles { get; set; }
    }

    public class Responses4
    {
        public _2004 _200 { get; set; }
    }

    public class _2004
    {
        public string description { get; set; }
        public Content6 content { get; set; }
    }

    public class Content6
    {
        public ApplicationJson6 applicationjson { get; set; }
    }

    public class ApplicationJson6
    {
        public Schema9 schema { get; set; }
    }

    public class Schema9
    {
        public string type { get; set; }
    }

    public class Parameter3
    {
        public string name { get; set; }
        public string _in { get; set; }
        public bool required { get; set; }
        public Schema10 schema { get; set; }
    }

    public class Schema10
    {
        public string type { get; set; }
        public string format { get; set; }
    }

    public class ApiTagsKeyRelatedtagsRef
    {
        public Put put { get; set; }
        public Post1 post { get; set; }
    }

    public class Put
    {
        public string[] tags { get; set; }
        public string operationId { get; set; }
        public Parameter4[] parameters { get; set; }
        public Requestbody2 requestBody { get; set; }
        public Responses5 responses { get; set; }
        public string[] xroles { get; set; }
    }

    public class Requestbody2
    {
        public string xname { get; set; }
        public Content7 content { get; set; }
        public bool required { get; set; }
    }

    public class Content7
    {
        public ApplicationJson7 applicationjson { get; set; }
    }

    public class ApplicationJson7
    {
        public Schema11 schema { get; set; }
    }

    public class Schema11
    {
        public string type { get; set; }
        public string format { get; set; }
    }

    public class Responses5
    {
        public _2005 _200 { get; set; }
    }

    public class _2005
    {
        public string description { get; set; }
        public Content8 content { get; set; }
    }

    public class Content8
    {
        public ApplicationJson8 applicationjson { get; set; }
    }

    public class ApplicationJson8
    {
        public Schema12 schema { get; set; }
    }

    public class Schema12
    {
        public string type { get; set; }
    }

    public class Parameter4
    {
        public string name { get; set; }
        public string _in { get; set; }
        public bool required { get; set; }
        public Schema13 schema { get; set; }
    }

    public class Schema13
    {
        public string type { get; set; }
        public string format { get; set; }
        public bool nullable { get; set; }
    }

    public class Post1
    {
        public string[] tags { get; set; }
        public string operationId { get; set; }
        public Parameter5[] parameters { get; set; }
        public Requestbody3 requestBody { get; set; }
        public Responses6 responses { get; set; }
        public string[] xroles { get; set; }
    }

    public class Requestbody3
    {
        public string xname { get; set; }
        public Content9 content { get; set; }
        public bool required { get; set; }
    }

    public class Content9
    {
        public ApplicationJson9 applicationjson { get; set; }
    }

    public class ApplicationJson9
    {
        public Schema14 schema { get; set; }
    }

    public class Schema14
    {
        public string type { get; set; }
        public string format { get; set; }
    }

    public class Responses6
    {
        public _2006 _200 { get; set; }
    }

    public class _2006
    {
        public string description { get; set; }
        public Content10 content { get; set; }
    }

    public class Content10
    {
        public ApplicationJson10 applicationjson { get; set; }
    }

    public class ApplicationJson10
    {
        public Schema15 schema { get; set; }
    }

    public class Schema15
    {
        public string type { get; set; }
    }

    public class Parameter5
    {
        public string name { get; set; }
        public string _in { get; set; }
        public bool required { get; set; }
        public Schema16 schema { get; set; }
    }

    public class Schema16
    {
        public string type { get; set; }
        public string format { get; set; }
        public bool nullable { get; set; }
    }

    public class ApiTagsKeyRelatedtagsRelatedkeyRef
    {
        public Delete1 delete { get; set; }
    }

    public class Delete1
    {
        public string[] tags { get; set; }
        public string operationId { get; set; }
        public Parameter6[] parameters { get; set; }
        public Responses7 responses { get; set; }
        public string[] xroles { get; set; }
    }

    public class Responses7
    {
        public _2007 _200 { get; set; }
    }

    public class _2007
    {
        public string description { get; set; }
        public Content11 content { get; set; }
    }

    public class Content11
    {
        public ApplicationJson11 applicationjson { get; set; }
    }

    public class ApplicationJson11
    {
        public Schema17 schema { get; set; }
    }

    public class Schema17
    {
        public string type { get; set; }
    }

    public class Parameter6
    {
        public string name { get; set; }
        public string _in { get; set; }
        public bool required { get; set; }
        public Schema18 schema { get; set; }
    }

    public class Schema18
    {
        public string type { get; set; }
        public string format { get; set; }
        public bool nullable { get; set; }
    }

    public class ApiUser
    {
        public Get2 get { get; set; }
        public Patch1 patch { get; set; }
    }

    public class Get2
    {
        public string[] tags { get; set; }
        public string operationId { get; set; }
        public Parameter7[] parameters { get; set; }
        public Responses8 responses { get; set; }
        public string[] xroles { get; set; }
    }

    public class Responses8
    {
        public _2008 _200 { get; set; }
    }

    public class _2008
    {
        public string description { get; set; }
        public Content12 content { get; set; }
    }

    public class Content12
    {
        public ApplicationJson12 applicationjson { get; set; }
    }

    public class ApplicationJson12
    {
        public Schema19 schema { get; set; }
    }

    public class Schema19
    {
        public bool nullable { get; set; }
        public Oneof1[] oneOf { get; set; }
    }

    public class Oneof1
    {
        public string _ref { get; set; }
    }

    public class Parameter7
    {
        public string name { get; set; }
        public string _in { get; set; }
        public string description { get; set; }
        public Schema20 schema { get; set; }
    }

    public class Schema20
    {
        public string type { get; set; }
        public bool nullable { get; set; }
    }

    public class Patch1
    {
        public string[] tags { get; set; }
        public string operationId { get; set; }
        public Requestbody4 requestBody { get; set; }
        public Responses9 responses { get; set; }
        public string[] xroles { get; set; }
    }

    public class Requestbody4
    {
        public string xname { get; set; }
        public Content13 content { get; set; }
        public bool required { get; set; }
    }

    public class Content13
    {
        public ApplicationJson13 applicationjson { get; set; }
    }

    public class ApplicationJson13
    {
        public Schema21 schema { get; set; }
    }

    public class Schema21
    {
        public string _ref { get; set; }
    }

    public class Responses9
    {
        public _2009 _200 { get; set; }
    }

    public class _2009
    {
        public string description { get; set; }
        public Content14 content { get; set; }
    }

    public class Content14
    {
        public ApplicationJson14 applicationjson { get; set; }
    }

    public class ApplicationJson14
    {
        public Schema22 schema { get; set; }
    }

    public class Schema22
    {
        public string type { get; set; }
    }

    public class ApiRegisterorgunitimpersonation
    {
        public Post2 post { get; set; }
    }

    public class Post2
    {
        public string[] tags { get; set; }
        public string operationId { get; set; }
        public Parameter8[] parameters { get; set; }
        public Requestbody5 requestBody { get; set; }
        public Responses10 responses { get; set; }
        public string[] xroles { get; set; }
    }

    public class Requestbody5
    {
        public string xname { get; set; }
        public Content15 content { get; set; }
        public bool required { get; set; }
    }

    public class Content15
    {
        public ApplicationJson15 applicationjson { get; set; }
    }

    public class ApplicationJson15
    {
        public Schema23 schema { get; set; }
    }

    public class Schema23
    {
        public string _ref { get; set; }
    }

    public class Responses10
    {
        public _20010 _200 { get; set; }
    }

    public class _20010
    {
        public string description { get; set; }
        public Content16 content { get; set; }
    }

    public class Content16
    {
        public ApplicationJson16 applicationjson { get; set; }
    }

    public class ApplicationJson16
    {
        public Schema24 schema { get; set; }
    }

    public class Schema24
    {
        public string type { get; set; }
    }

    public class Parameter8
    {
        public string name { get; set; }
        public string _in { get; set; }
        public string description { get; set; }
        public Schema25 schema { get; set; }
    }

    public class Schema25
    {
        public string type { get; set; }
        public bool nullable { get; set; }
    }

    public class ApiFiles
    {
        public Get3 get { get; set; }
    }

    public class Get3
    {
        public string[] tags { get; set; }
        public string operationId { get; set; }
        public Parameter9[] parameters { get; set; }
        public Responses11 responses { get; set; }
        public string[] xroles { get; set; }
    }

    public class Responses11
    {
        public _20011 _200 { get; set; }
    }

    public class _20011
    {
        public string description { get; set; }
        public Content17 content { get; set; }
    }

    public class Content17
    {
        public ApplicationJson17 applicationjson { get; set; }
    }

    public class ApplicationJson17
    {
        public Schema26 schema { get; set; }
    }

    public class Schema26
    {
        public string type { get; set; }
        public bool nullable { get; set; }
        public Items1 items { get; set; }
    }

    public class Items1
    {
        public string _ref { get; set; }
    }

    public class Parameter9
    {
        public string name { get; set; }
        public string _in { get; set; }
        public string description { get; set; }
        public Schema27 schema { get; set; }
    }

    public class Schema27
    {
        public string type { get; set; }
        public bool nullable { get; set; }
        public string format { get; set; }
    }

    public class ApiFilesKey
    {
        public Get4 get { get; set; }
    }

    public class Get4
    {
        public string[] tags { get; set; }
        public string operationId { get; set; }
        public Parameter10[] parameters { get; set; }
        public Responses12 responses { get; set; }
        public string[] xroles { get; set; }
    }

    public class Responses12
    {
        public _20012 _200 { get; set; }
    }

    public class _20012
    {
        public string description { get; set; }
        public Content18 content { get; set; }
    }

    public class Content18
    {
        public ApplicationJson18 applicationjson { get; set; }
    }

    public class ApplicationJson18
    {
        public Schema28 schema { get; set; }
    }

    public class Schema28
    {
        public bool nullable { get; set; }
        public Oneof2[] oneOf { get; set; }
    }

    public class Oneof2
    {
        public string _ref { get; set; }
    }

    public class Parameter10
    {
        public string name { get; set; }
        public string _in { get; set; }
        public bool required { get; set; }
        public Schema29 schema { get; set; }
        public string description { get; set; }
    }

    public class Schema29
    {
        public string type { get; set; }
        public string format { get; set; }
        public bool nullable { get; set; }
    }

    public class ApiPlans
    {
        public Get5 get { get; set; }
        public Post3 post { get; set; }
    }

    public class Get5
    {
        public string[] tags { get; set; }
        public string operationId { get; set; }
        public Parameter11[] parameters { get; set; }
        public Responses13 responses { get; set; }
        public string[] xroles { get; set; }
    }

    public class Responses13
    {
        public _20013 _200 { get; set; }
    }

    public class _20013
    {
        public string description { get; set; }
        public Content19 content { get; set; }
    }

    public class Content19
    {
        public ApplicationJson19 applicationjson { get; set; }
    }

    public class ApplicationJson19
    {
        public Schema30 schema { get; set; }
    }

    public class Schema30
    {
        public string type { get; set; }
        public bool nullable { get; set; }
        public Items2 items { get; set; }
    }

    public class Items2
    {
        public string _ref { get; set; }
    }

    public class Parameter11
    {
        public string name { get; set; }
        public string _in { get; set; }
        public string description { get; set; }
        public Schema31 schema { get; set; }
    }

    public class Schema31
    {
        public string type { get; set; }
        public bool nullable { get; set; }
        public string format { get; set; }
    }

    public class Post3
    {
        public string[] tags { get; set; }
        public string operationId { get; set; }
        public Requestbody6 requestBody { get; set; }
        public Responses14 responses { get; set; }
        public string[] xroles { get; set; }
    }

    public class Requestbody6
    {
        public string xname { get; set; }
        public Content20 content { get; set; }
        public bool required { get; set; }
    }

    public class Content20
    {
        public ApplicationJson20 applicationjson { get; set; }
    }

    public class ApplicationJson20
    {
        public Schema32 schema { get; set; }
    }

    public class Schema32
    {
        public string _ref { get; set; }
    }

    public class Responses14
    {
        public _20014 _200 { get; set; }
    }

    public class _20014
    {
        public string description { get; set; }
        public Content21 content { get; set; }
    }

    public class Content21
    {
        public ApplicationJson21 applicationjson { get; set; }
    }

    public class ApplicationJson21
    {
        public Schema33 schema { get; set; }
    }

    public class Schema33
    {
        public string type { get; set; }
    }

    public class ApiPlansKey
    {
        public Get6 get { get; set; }
        public Patch2 patch { get; set; }
        public Delete2 delete { get; set; }
    }

    public class Get6
    {
        public string[] tags { get; set; }
        public string operationId { get; set; }
        public Parameter12[] parameters { get; set; }
        public Responses15 responses { get; set; }
        public string[] xroles { get; set; }
    }

    public class Responses15
    {
        public _20015 _200 { get; set; }
    }

    public class _20015
    {
        public string description { get; set; }
        public Content22 content { get; set; }
    }

    public class Content22
    {
        public ApplicationJson22 applicationjson { get; set; }
    }

    public class ApplicationJson22
    {
        public Schema34 schema { get; set; }
    }

    public class Schema34
    {
        public bool nullable { get; set; }
        public Oneof3[] oneOf { get; set; }
    }

    public class Oneof3
    {
        public string _ref { get; set; }
    }

    public class Parameter12
    {
        public string name { get; set; }
        public string _in { get; set; }
        public bool required { get; set; }
        public Schema35 schema { get; set; }
        public string description { get; set; }
    }

    public class Schema35
    {
        public string type { get; set; }
        public string format { get; set; }
        public bool nullable { get; set; }
    }

    public class Patch2
    {
        public string[] tags { get; set; }
        public string operationId { get; set; }
        public Parameter13[] parameters { get; set; }
        public Requestbody7 requestBody { get; set; }
        public Responses16 responses { get; set; }
        public string[] xroles { get; set; }
    }

    public class Requestbody7
    {
        public string xname { get; set; }
        public Content23 content { get; set; }
        public bool required { get; set; }
    }

    public class Content23
    {
        public ApplicationJson23 applicationjson { get; set; }
    }

    public class ApplicationJson23
    {
        public Schema36 schema { get; set; }
    }

    public class Schema36
    {
        public string _ref { get; set; }
    }

    public class Responses16
    {
        public _20016 _200 { get; set; }
    }

    public class _20016
    {
        public string description { get; set; }
        public Content24 content { get; set; }
    }

    public class Content24
    {
        public ApplicationJson24 applicationjson { get; set; }
    }

    public class ApplicationJson24
    {
        public Schema37 schema { get; set; }
    }

    public class Schema37
    {
        public string type { get; set; }
    }

    public class Parameter13
    {
        public string name { get; set; }
        public string _in { get; set; }
        public bool required { get; set; }
        public Schema38 schema { get; set; }
    }

    public class Schema38
    {
        public string type { get; set; }
        public string format { get; set; }
    }

    public class Delete2
    {
        public string[] tags { get; set; }
        public string operationId { get; set; }
        public Parameter14[] parameters { get; set; }
        public Responses17 responses { get; set; }
        public string[] xroles { get; set; }
    }

    public class Responses17
    {
        public _20017 _200 { get; set; }
    }

    public class _20017
    {
        public string description { get; set; }
        public Content25 content { get; set; }
    }

    public class Content25
    {
        public ApplicationJson25 applicationjson { get; set; }
    }

    public class ApplicationJson25
    {
        public Schema39 schema { get; set; }
    }

    public class Schema39
    {
        public string type { get; set; }
    }

    public class Parameter14
    {
        public string name { get; set; }
        public string _in { get; set; }
        public bool required { get; set; }
        public Schema40 schema { get; set; }
    }

    public class Schema40
    {
        public string type { get; set; }
        public string format { get; set; }
    }

    public class ApiRoles
    {
        public Get7 get { get; set; }
    }

    public class Get7
    {
        public string[] tags { get; set; }
        public string operationId { get; set; }
        public Parameter15[] parameters { get; set; }
        public Responses18 responses { get; set; }
        public string[] xroles { get; set; }
    }

    public class Responses18
    {
        public _20018 _200 { get; set; }
    }

    public class _20018
    {
        public string description { get; set; }
        public Content26 content { get; set; }
    }

    public class Content26
    {
        public ApplicationJson26 applicationjson { get; set; }
    }

    public class ApplicationJson26
    {
        public Schema41 schema { get; set; }
    }

    public class Schema41
    {
        public string type { get; set; }
        public bool nullable { get; set; }
        public Items3 items { get; set; }
    }

    public class Items3
    {
        public string _ref { get; set; }
    }

    public class Parameter15
    {
        public string name { get; set; }
        public string _in { get; set; }
        public string description { get; set; }
        public Schema42 schema { get; set; }
    }

    public class Schema42
    {
        public string type { get; set; }
        public bool nullable { get; set; }
        public string format { get; set; }
    }

    public class ApiRolesKey
    {
        public Get8 get { get; set; }
    }

    public class Get8
    {
        public string[] tags { get; set; }
        public string operationId { get; set; }
        public Parameter16[] parameters { get; set; }
        public Responses19 responses { get; set; }
        public string[] xroles { get; set; }
    }

    public class Responses19
    {
        public _20019 _200 { get; set; }
    }

    public class _20019
    {
        public string description { get; set; }
        public Content27 content { get; set; }
    }

    public class Content27
    {
        public ApplicationJson27 applicationjson { get; set; }
    }

    public class ApplicationJson27
    {
        public Schema43 schema { get; set; }
    }

    public class Schema43
    {
        public bool nullable { get; set; }
        public Oneof4[] oneOf { get; set; }
    }

    public class Oneof4
    {
        public string _ref { get; set; }
    }

    public class Parameter16
    {
        public string name { get; set; }
        public string _in { get; set; }
        public bool required { get; set; }
        public Schema44 schema { get; set; }
        public string description { get; set; }
    }

    public class Schema44
    {
        public string type { get; set; }
        public string format { get; set; }
        public bool nullable { get; set; }
    }

    public class ApiUsers
    {
        public Get9 get { get; set; }
        public Post4 post { get; set; }
    }

    public class Get9
    {
        public string[] tags { get; set; }
        public string operationId { get; set; }
        public Parameter17[] parameters { get; set; }
        public Responses20 responses { get; set; }
        public string[] xroles { get; set; }
    }

    public class Responses20
    {
        public _20020 _200 { get; set; }
    }

    public class _20020
    {
        public string description { get; set; }
        public Content28 content { get; set; }
    }

    public class Content28
    {
        public ApplicationJson28 applicationjson { get; set; }
    }

    public class ApplicationJson28
    {
        public Schema45 schema { get; set; }
    }

    public class Schema45
    {
        public string type { get; set; }
        public bool nullable { get; set; }
        public Items4 items { get; set; }
    }

    public class Items4
    {
        public string _ref { get; set; }
    }

    public class Parameter17
    {
        public string name { get; set; }
        public string _in { get; set; }
        public string description { get; set; }
        public Schema46 schema { get; set; }
    }

    public class Schema46
    {
        public string type { get; set; }
        public bool nullable { get; set; }
        public string format { get; set; }
    }

    public class Post4
    {
        public string[] tags { get; set; }
        public string operationId { get; set; }
        public Requestbody8 requestBody { get; set; }
        public Responses21 responses { get; set; }
        public string[] xroles { get; set; }
    }

    public class Requestbody8
    {
        public string xname { get; set; }
        public Content29 content { get; set; }
        public bool required { get; set; }
    }

    public class Content29
    {
        public ApplicationJson29 applicationjson { get; set; }
    }

    public class ApplicationJson29
    {
        public Schema47 schema { get; set; }
    }

    public class Schema47
    {
        public string _ref { get; set; }
    }

    public class Responses21
    {
        public _20021 _200 { get; set; }
    }

    public class _20021
    {
        public string description { get; set; }
        public Content30 content { get; set; }
    }

    public class Content30
    {
        public ApplicationJson30 applicationjson { get; set; }
    }

    public class ApplicationJson30
    {
        public Schema48 schema { get; set; }
    }

    public class Schema48
    {
        public bool nullable { get; set; }
        public Oneof5[] oneOf { get; set; }
    }

    public class Oneof5
    {
        public string _ref { get; set; }
    }

    public class ApiUsersKey
    {
        public Get10 get { get; set; }
        public Patch3 patch { get; set; }
    }

    public class Get10
    {
        public string[] tags { get; set; }
        public string operationId { get; set; }
        public Parameter18[] parameters { get; set; }
        public Responses22 responses { get; set; }
        public string[] xroles { get; set; }
    }

    public class Responses22
    {
        public _20022 _200 { get; set; }
    }

    public class _20022
    {
        public string description { get; set; }
        public Content31 content { get; set; }
    }

    public class Content31
    {
        public ApplicationJson31 applicationjson { get; set; }
    }

    public class ApplicationJson31
    {
        public Schema49 schema { get; set; }
    }

    public class Schema49
    {
        public bool nullable { get; set; }
        public Oneof6[] oneOf { get; set; }
    }

    public class Oneof6
    {
        public string _ref { get; set; }
    }

    public class Parameter18
    {
        public string name { get; set; }
        public string _in { get; set; }
        public bool required { get; set; }
        public Schema50 schema { get; set; }
        public string description { get; set; }
    }

    public class Schema50
    {
        public string type { get; set; }
        public string format { get; set; }
        public bool nullable { get; set; }
    }

    public class Patch3
    {
        public string[] tags { get; set; }
        public string operationId { get; set; }
        public Parameter19[] parameters { get; set; }
        public Requestbody9 requestBody { get; set; }
        public Responses23 responses { get; set; }
        public string[] xroles { get; set; }
    }

    public class Requestbody9
    {
        public string xname { get; set; }
        public Content32 content { get; set; }
        public bool required { get; set; }
    }

    public class Content32
    {
        public ApplicationJson32 applicationjson { get; set; }
    }

    public class ApplicationJson32
    {
        public Schema51 schema { get; set; }
    }

    public class Schema51
    {
        public string _ref { get; set; }
    }

    public class Responses23
    {
        public _20023 _200 { get; set; }
    }

    public class _20023
    {
        public string description { get; set; }
        public Content33 content { get; set; }
    }

    public class Content33
    {
        public ApplicationJson33 applicationjson { get; set; }
    }

    public class ApplicationJson33
    {
        public Schema52 schema { get; set; }
    }

    public class Schema52
    {
        public bool nullable { get; set; }
        public Oneof7[] oneOf { get; set; }
    }

    public class Oneof7
    {
        public string _ref { get; set; }
    }

    public class Parameter19
    {
        public string name { get; set; }
        public string _in { get; set; }
        public bool required { get; set; }
        public Schema53 schema { get; set; }
    }

    public class Schema53
    {
        public string type { get; set; }
        public string format { get; set; }
    }

    public class ApiUsersKeyUnlock
    {
        public Post5 post { get; set; }
    }

    public class Post5
    {
        public string[] tags { get; set; }
        public string operationId { get; set; }
        public Parameter20[] parameters { get; set; }
        public Responses24 responses { get; set; }
        public string[] xroles { get; set; }
    }

    public class Responses24
    {
        public _20024 _200 { get; set; }
    }

    public class _20024
    {
        public string description { get; set; }
        public Content34 content { get; set; }
    }

    public class Content34
    {
        public ApplicationJson34 applicationjson { get; set; }
    }

    public class ApplicationJson34
    {
        public Schema54 schema { get; set; }
    }

    public class Schema54
    {
        public bool nullable { get; set; }
        public Oneof8[] oneOf { get; set; }
    }

    public class Oneof8
    {
        public string _ref { get; set; }
    }

    public class Parameter20
    {
        public string name { get; set; }
        public string _in { get; set; }
        public bool required { get; set; }
        public Schema55 schema { get; set; }
        public string description { get; set; }
    }

    public class Schema55
    {
        public string type { get; set; }
        public string format { get; set; }
        public bool nullable { get; set; }
    }

    public class ApiUsersKeySetroles
    {
        public Post6 post { get; set; }
    }

    public class Post6
    {
        public string[] tags { get; set; }
        public string operationId { get; set; }
        public Parameter21[] parameters { get; set; }
        public Requestbody10 requestBody { get; set; }
        public Responses25 responses { get; set; }
        public string[] xroles { get; set; }
    }

    public class Requestbody10
    {
        public string xname { get; set; }
        public Content35 content { get; set; }
        public bool required { get; set; }
    }

    public class Content35
    {
        public ApplicationJson35 applicationjson { get; set; }
    }

    public class ApplicationJson35
    {
        public Schema56 schema { get; set; }
    }

    public class Schema56
    {
        public string _ref { get; set; }
    }

    public class Responses25
    {
        public _20025 _200 { get; set; }
    }

    public class _20025
    {
        public string description { get; set; }
        public Content36 content { get; set; }
    }

    public class Content36
    {
        public ApplicationJson36 applicationjson { get; set; }
    }

    public class ApplicationJson36
    {
        public Schema57 schema { get; set; }
    }

    public class Schema57
    {
        public bool nullable { get; set; }
        public Oneof9[] oneOf { get; set; }
    }

    public class Oneof9
    {
        public string _ref { get; set; }
    }

    public class Parameter21
    {
        public string name { get; set; }
        public string _in { get; set; }
        public bool required { get; set; }
        public Schema58 schema { get; set; }
        public string description { get; set; }
    }

    public class Schema58
    {
        public string type { get; set; }
        public string format { get; set; }
        public bool nullable { get; set; }
    }

    public class ApiSurveys
    {
        public Get11 get { get; set; }
    }

    public class Get11
    {
        public string[] tags { get; set; }
        public string operationId { get; set; }
        public Parameter22[] parameters { get; set; }
        public Responses26 responses { get; set; }
        public string[] xroles { get; set; }
    }

    public class Responses26
    {
        public _20026 _200 { get; set; }
    }

    public class _20026
    {
        public string description { get; set; }
        public Content37 content { get; set; }
    }

    public class Content37
    {
        public ApplicationJson37 applicationjson { get; set; }
    }

    public class ApplicationJson37
    {
        public Schema59 schema { get; set; }
    }

    public class Schema59
    {
        public string type { get; set; }
        public bool nullable { get; set; }
        public Items5 items { get; set; }
    }

    public class Items5
    {
        public string _ref { get; set; }
    }

    public class Parameter22
    {
        public string name { get; set; }
        public string _in { get; set; }
        public string description { get; set; }
        public Schema60 schema { get; set; }
    }

    public class Schema60
    {
        public string type { get; set; }
        public bool nullable { get; set; }
        public string format { get; set; }
    }

    public class ApiSurveysKey
    {
        public Get12 get { get; set; }
    }

    public class Get12
    {
        public string[] tags { get; set; }
        public string operationId { get; set; }
        public Parameter23[] parameters { get; set; }
        public Responses27 responses { get; set; }
        public string[] xroles { get; set; }
    }

    public class Responses27
    {
        public _20027 _200 { get; set; }
    }

    public class _20027
    {
        public string description { get; set; }
        public Content38 content { get; set; }
    }

    public class Content38
    {
        public ApplicationJson38 applicationjson { get; set; }
    }

    public class ApplicationJson38
    {
        public Schema61 schema { get; set; }
    }

    public class Schema61
    {
        public bool nullable { get; set; }
        public Oneof10[] oneOf { get; set; }
    }

    public class Oneof10
    {
        public string _ref { get; set; }
    }

    public class Parameter23
    {
        public string name { get; set; }
        public string _in { get; set; }
        public bool required { get; set; }
        public Schema62 schema { get; set; }
        public string description { get; set; }
    }

    public class Schema62
    {
        public string type { get; set; }
        public string format { get; set; }
        public bool nullable { get; set; }
    }

    public class ApiCatalogs
    {
        public Get13 get { get; set; }
        public Post7 post { get; set; }
    }

    public class Get13
    {
        public string[] tags { get; set; }
        public string operationId { get; set; }
        public Parameter24[] parameters { get; set; }
        public Responses28 responses { get; set; }
        public string[] xroles { get; set; }
    }

    public class Responses28
    {
        public _20028 _200 { get; set; }
    }

    public class _20028
    {
        public string description { get; set; }
        public Content39 content { get; set; }
    }

    public class Content39
    {
        public ApplicationJson39 applicationjson { get; set; }
    }

    public class ApplicationJson39
    {
        public Schema63 schema { get; set; }
    }

    public class Schema63
    {
        public string type { get; set; }
        public bool nullable { get; set; }
        public Items6 items { get; set; }
    }

    public class Items6
    {
        public string _ref { get; set; }
    }

    public class Parameter24
    {
        public string name { get; set; }
        public string _in { get; set; }
        public string description { get; set; }
        public Schema64 schema { get; set; }
    }

    public class Schema64
    {
        public string type { get; set; }
        public bool nullable { get; set; }
        public string format { get; set; }
    }

    public class Post7
    {
        public string[] tags { get; set; }
        public string operationId { get; set; }
        public Requestbody11 requestBody { get; set; }
        public Responses29 responses { get; set; }
        public string[] xroles { get; set; }
    }

    public class Requestbody11
    {
        public string xname { get; set; }
        public Content40 content { get; set; }
        public bool required { get; set; }
    }

    public class Content40
    {
        public ApplicationJson40 applicationjson { get; set; }
    }

    public class ApplicationJson40
    {
        public Schema65 schema { get; set; }
    }

    public class Schema65
    {
        public string _ref { get; set; }
    }

    public class Responses29
    {
        public _20029 _200 { get; set; }
    }

    public class _20029
    {
        public string description { get; set; }
        public Content41 content { get; set; }
    }

    public class Content41
    {
        public ApplicationJson41 applicationjson { get; set; }
    }

    public class ApplicationJson41
    {
        public Schema66 schema { get; set; }
    }

    public class Schema66
    {
        public string type { get; set; }
    }

    public class ApiCatalogsKey
    {
        public Get14 get { get; set; }
        public Patch4 patch { get; set; }
        public Delete3 delete { get; set; }
    }

    public class Get14
    {
        public string[] tags { get; set; }
        public string operationId { get; set; }
        public Parameter25[] parameters { get; set; }
        public Responses30 responses { get; set; }
        public string[] xroles { get; set; }
    }

    public class Responses30
    {
        public _20030 _200 { get; set; }
    }

    public class _20030
    {
        public string description { get; set; }
        public Content42 content { get; set; }
    }

    public class Content42
    {
        public ApplicationJson42 applicationjson { get; set; }
    }

    public class ApplicationJson42
    {
        public Schema67 schema { get; set; }
    }

    public class Schema67
    {
        public bool nullable { get; set; }
        public Oneof11[] oneOf { get; set; }
    }

    public class Oneof11
    {
        public string _ref { get; set; }
    }

    public class Parameter25
    {
        public string name { get; set; }
        public string _in { get; set; }
        public bool required { get; set; }
        public Schema68 schema { get; set; }
        public string description { get; set; }
    }

    public class Schema68
    {
        public string type { get; set; }
        public string format { get; set; }
        public bool nullable { get; set; }
    }

    public class Patch4
    {
        public string[] tags { get; set; }
        public string operationId { get; set; }
        public Parameter26[] parameters { get; set; }
        public Requestbody12 requestBody { get; set; }
        public Responses31 responses { get; set; }
        public string[] xroles { get; set; }
    }

    public class Requestbody12
    {
        public string xname { get; set; }
        public Content43 content { get; set; }
        public bool required { get; set; }
    }

    public class Content43
    {
        public ApplicationJson43 applicationjson { get; set; }
    }

    public class ApplicationJson43
    {
        public Schema69 schema { get; set; }
    }

    public class Schema69
    {
        public string _ref { get; set; }
    }

    public class Responses31
    {
        public _20031 _200 { get; set; }
    }

    public class _20031
    {
        public string description { get; set; }
        public Content44 content { get; set; }
    }

    public class Content44
    {
        public ApplicationJson44 applicationjson { get; set; }
    }

    public class ApplicationJson44
    {
        public Schema70 schema { get; set; }
    }

    public class Schema70
    {
        public string type { get; set; }
    }

    public class Parameter26
    {
        public string name { get; set; }
        public string _in { get; set; }
        public bool required { get; set; }
        public Schema71 schema { get; set; }
    }

    public class Schema71
    {
        public string type { get; set; }
        public string format { get; set; }
    }

    public class Delete3
    {
        public string[] tags { get; set; }
        public string operationId { get; set; }
        public Parameter27[] parameters { get; set; }
        public Responses32 responses { get; set; }
        public string[] xroles { get; set; }
    }

    public class Responses32
    {
        public _20032 _200 { get; set; }
    }

    public class _20032
    {
        public string description { get; set; }
        public Content45 content { get; set; }
    }

    public class Content45
    {
        public ApplicationJson45 applicationjson { get; set; }
    }

    public class ApplicationJson45
    {
        public Schema72 schema { get; set; }
    }

    public class Schema72
    {
        public string type { get; set; }
    }

    public class Parameter27
    {
        public string name { get; set; }
        public string _in { get; set; }
        public bool required { get; set; }
        public Schema73 schema { get; set; }
    }

    public class Schema73
    {
        public string type { get; set; }
        public string format { get; set; }
    }

    public class ApiOrgunits
    {
        public Get15 get { get; set; }
        public Post8 post { get; set; }
    }

    public class Get15
    {
        public string[] tags { get; set; }
        public string operationId { get; set; }
        public Parameter28[] parameters { get; set; }
        public Responses33 responses { get; set; }
        public string[] xroles { get; set; }
    }

    public class Responses33
    {
        public _20033 _200 { get; set; }
    }

    public class _20033
    {
        public string description { get; set; }
        public Content46 content { get; set; }
    }

    public class Content46
    {
        public ApplicationJson46 applicationjson { get; set; }
    }

    public class ApplicationJson46
    {
        public Schema74 schema { get; set; }
    }

    public class Schema74
    {
        public string type { get; set; }
        public bool nullable { get; set; }
        public Items7 items { get; set; }
    }

    public class Items7
    {
        public string _ref { get; set; }
    }

    public class Parameter28
    {
        public string name { get; set; }
        public string _in { get; set; }
        public string description { get; set; }
        public Schema75 schema { get; set; }
    }

    public class Schema75
    {
        public string type { get; set; }
        public bool nullable { get; set; }
        public string format { get; set; }
    }

    public class Post8
    {
        public string[] tags { get; set; }
        public string operationId { get; set; }
        public Requestbody13 requestBody { get; set; }
        public Responses34 responses { get; set; }
        public string[] xroles { get; set; }
    }

    public class Requestbody13
    {
        public string xname { get; set; }
        public Content47 content { get; set; }
        public bool required { get; set; }
    }

    public class Content47
    {
        public ApplicationJson47 applicationjson { get; set; }
    }

    public class ApplicationJson47
    {
        public Schema76 schema { get; set; }
    }

    public class Schema76
    {
        public string _ref { get; set; }
    }

    public class Responses34
    {
        public _20034 _200 { get; set; }
    }

    public class _20034
    {
        public string description { get; set; }
        public Content48 content { get; set; }
    }

    public class Content48
    {
        public ApplicationJson48 applicationjson { get; set; }
    }

    public class ApplicationJson48
    {
        public Schema77 schema { get; set; }
    }

    public class Schema77
    {
        public string type { get; set; }
    }

    public class ApiOrgunitsKey
    {
        public Get16 get { get; set; }
        public Patch5 patch { get; set; }
        public Delete4 delete { get; set; }
    }

    public class Get16
    {
        public string[] tags { get; set; }
        public string operationId { get; set; }
        public Parameter29[] parameters { get; set; }
        public Responses35 responses { get; set; }
        public string[] xroles { get; set; }
    }

    public class Responses35
    {
        public _20035 _200 { get; set; }
    }

    public class _20035
    {
        public string description { get; set; }
        public Content49 content { get; set; }
    }

    public class Content49
    {
        public ApplicationJson49 applicationjson { get; set; }
    }

    public class ApplicationJson49
    {
        public Schema78 schema { get; set; }
    }

    public class Schema78
    {
        public bool nullable { get; set; }
        public Oneof12[] oneOf { get; set; }
    }

    public class Oneof12
    {
        public string _ref { get; set; }
    }

    public class Parameter29
    {
        public string name { get; set; }
        public string _in { get; set; }
        public bool required { get; set; }
        public Schema79 schema { get; set; }
        public string description { get; set; }
    }

    public class Schema79
    {
        public string type { get; set; }
        public string format { get; set; }
        public bool nullable { get; set; }
    }

    public class Patch5
    {
        public string[] tags { get; set; }
        public string operationId { get; set; }
        public Parameter30[] parameters { get; set; }
        public Requestbody14 requestBody { get; set; }
        public Responses36 responses { get; set; }
        public string[] xroles { get; set; }
    }

    public class Requestbody14
    {
        public string xname { get; set; }
        public Content50 content { get; set; }
        public bool required { get; set; }
    }

    public class Content50
    {
        public ApplicationJson50 applicationjson { get; set; }
    }

    public class ApplicationJson50
    {
        public Schema80 schema { get; set; }
    }

    public class Schema80
    {
        public string _ref { get; set; }
    }

    public class Responses36
    {
        public _20036 _200 { get; set; }
    }

    public class _20036
    {
        public string description { get; set; }
        public Content51 content { get; set; }
    }

    public class Content51
    {
        public ApplicationJson51 applicationjson { get; set; }
    }

    public class ApplicationJson51
    {
        public Schema81 schema { get; set; }
    }

    public class Schema81
    {
        public string type { get; set; }
    }

    public class Parameter30
    {
        public string name { get; set; }
        public string _in { get; set; }
        public bool required { get; set; }
        public Schema82 schema { get; set; }
    }

    public class Schema82
    {
        public string type { get; set; }
        public string format { get; set; }
    }

    public class Delete4
    {
        public string[] tags { get; set; }
        public string operationId { get; set; }
        public Parameter31[] parameters { get; set; }
        public Responses37 responses { get; set; }
        public string[] xroles { get; set; }
    }

    public class Responses37
    {
        public _20037 _200 { get; set; }
    }

    public class _20037
    {
        public string description { get; set; }
        public Content52 content { get; set; }
    }

    public class Content52
    {
        public ApplicationJson52 applicationjson { get; set; }
    }

    public class ApplicationJson52
    {
        public Schema83 schema { get; set; }
    }

    public class Schema83
    {
        public string type { get; set; }
    }

    public class Parameter31
    {
        public string name { get; set; }
        public string _in { get; set; }
        public bool required { get; set; }
        public Schema84 schema { get; set; }
    }

    public class Schema84
    {
        public string type { get; set; }
        public string format { get; set; }
    }

    public class ApiOrgunitsIdSubscribers
    {
        public Get17 get { get; set; }
    }

    public class Get17
    {
        public string[] tags { get; set; }
        public string operationId { get; set; }
        public Parameter32[] parameters { get; set; }
        public Responses38 responses { get; set; }
        public string[] xroles { get; set; }
    }

    public class Responses38
    {
        public _20038 _200 { get; set; }
    }

    public class _20038
    {
        public string description { get; set; }
        public Content53 content { get; set; }
    }

    public class Content53
    {
        public ApplicationJson53 applicationjson { get; set; }
    }

    public class ApplicationJson53
    {
        public Schema85 schema { get; set; }
    }

    public class Schema85
    {
        public string type { get; set; }
        public bool nullable { get; set; }
        public Items8 items { get; set; }
    }

    public class Items8
    {
        public string _ref { get; set; }
    }

    public class Parameter32
    {
        public string name { get; set; }
        public string _in { get; set; }
        public bool required { get; set; }
        public Schema86 schema { get; set; }
        public string description { get; set; }
    }

    public class Schema86
    {
        public string type { get; set; }
        public string format { get; set; }
        public bool nullable { get; set; }
    }

    public class ApiOrgunitsIdEmployeeimports
    {
        public Get18 get { get; set; }
    }

    public class Get18
    {
        public string[] tags { get; set; }
        public string operationId { get; set; }
        public Parameter33[] parameters { get; set; }
        public Responses39 responses { get; set; }
        public string[] xroles { get; set; }
    }

    public class Responses39
    {
        public _20039 _200 { get; set; }
    }

    public class _20039
    {
        public string description { get; set; }
        public Content54 content { get; set; }
    }

    public class Content54
    {
        public ApplicationJson54 applicationjson { get; set; }
    }

    public class ApplicationJson54
    {
        public Schema87 schema { get; set; }
    }

    public class Schema87
    {
        public string type { get; set; }
        public bool nullable { get; set; }
        public Items9 items { get; set; }
    }

    public class Items9
    {
        public string _ref { get; set; }
    }

    public class Parameter33
    {
        public string name { get; set; }
        public string _in { get; set; }
        public bool required { get; set; }
        public Schema88 schema { get; set; }
        public string description { get; set; }
    }

    public class Schema88
    {
        public string type { get; set; }
        public string format { get; set; }
        public bool nullable { get; set; }
    }

    public class ApiOrgunitsIdCurrentperiodemployees
    {
        public Get19 get { get; set; }
    }

    public class Get19
    {
        public string[] tags { get; set; }
        public string operationId { get; set; }
        public Parameter34[] parameters { get; set; }
        public Responses40 responses { get; set; }
        public string[] xroles { get; set; }
    }

    public class Responses40
    {
        public _20040 _200 { get; set; }
    }

    public class _20040
    {
        public string description { get; set; }
        public Content55 content { get; set; }
    }

    public class Content55
    {
        public ApplicationJson55 applicationjson { get; set; }
    }

    public class ApplicationJson55
    {
        public Schema89 schema { get; set; }
    }

    public class Schema89
    {
        public string type { get; set; }
        public bool nullable { get; set; }
        public Items10 items { get; set; }
    }

    public class Items10
    {
        public string _ref { get; set; }
    }

    public class Parameter34
    {
        public string name { get; set; }
        public string _in { get; set; }
        public bool required { get; set; }
        public Schema90 schema { get; set; }
        public string description { get; set; }
    }

    public class Schema90
    {
        public string type { get; set; }
        public string format { get; set; }
        public bool nullable { get; set; }
    }

    public class ApiOrgunitsKeyImportfile
    {
        public Post9 post { get; set; }
    }

    public class Post9
    {
        public string[] tags { get; set; }
        public string operationId { get; set; }
        public Parameter35[] parameters { get; set; }
        public Requestbody15 requestBody { get; set; }
        public Responses41 responses { get; set; }
        public string[] xroles { get; set; }
    }

    public class Requestbody15
    {
        public Content56 content { get; set; }
    }

    public class Content56
    {
        public MultipartFormData multipartformdata { get; set; }
    }

    public class MultipartFormData
    {
        public Schema91 schema { get; set; }
    }

    public class Schema91
    {
        public string type { get; set; }
        public string description { get; set; }
        public Properties properties { get; set; }
    }

    public class Properties
    {
        public File file { get; set; }
    }

    public class File
    {
        public string type { get; set; }
        public string format { get; set; }
    }

    public class Responses41
    {
        public _20041 _200 { get; set; }
    }

    public class _20041
    {
        public string description { get; set; }
        public Content57 content { get; set; }
    }

    public class Content57
    {
        public ApplicationJson56 applicationjson { get; set; }
    }

    public class ApplicationJson56
    {
        public Schema92 schema { get; set; }
    }

    public class Schema92
    {
        public string type { get; set; }
        public bool nullable { get; set; }
        public Items11 items { get; set; }
    }

    public class Items11
    {
        public string _ref { get; set; }
    }

    public class Parameter35
    {
        public string name { get; set; }
        public string _in { get; set; }
        public bool required { get; set; }
        public Schema93 schema { get; set; }
        public string description { get; set; }
    }

    public class Schema93
    {
        public string type { get; set; }
        public string format { get; set; }
        public bool nullable { get; set; }
    }

    public class ApiOrgunitsKeyQueueunregisteredemployeemails
    {
        public Post10 post { get; set; }
    }

    public class Post10
    {
        public string[] tags { get; set; }
        public string operationId { get; set; }
        public Parameter36[] parameters { get; set; }
        public Responses42 responses { get; set; }
        public string[] xroles { get; set; }
    }

    public class Responses42
    {
        public _20042 _200 { get; set; }
    }

    public class _20042
    {
        public string description { get; set; }
        public Content58 content { get; set; }
    }

    public class Content58
    {
        public ApplicationJson57 applicationjson { get; set; }
    }

    public class ApplicationJson57
    {
        public Schema94 schema { get; set; }
    }

    public class Schema94
    {
        public string type { get; set; }
        public string format { get; set; }
    }

    public class Parameter36
    {
        public string name { get; set; }
        public string _in { get; set; }
        public bool required { get; set; }
        public Schema95 schema { get; set; }
        public string description { get; set; }
    }

    public class Schema95
    {
        public string type { get; set; }
        public string format { get; set; }
        public bool nullable { get; set; }
    }

    public class ApiProducts
    {
        public Get20 get { get; set; }
    }

    public class Get20
    {
        public string[] tags { get; set; }
        public string operationId { get; set; }
        public Parameter37[] parameters { get; set; }
        public Responses43 responses { get; set; }
        public string[] xroles { get; set; }
    }

    public class Responses43
    {
        public _20043 _200 { get; set; }
    }

    public class _20043
    {
        public string description { get; set; }
        public Content59 content { get; set; }
    }

    public class Content59
    {
        public ApplicationJson58 applicationjson { get; set; }
    }

    public class ApplicationJson58
    {
        public Schema96 schema { get; set; }
    }

    public class Schema96
    {
        public string type { get; set; }
        public bool nullable { get; set; }
        public Items12 items { get; set; }
    }

    public class Items12
    {
        public string _ref { get; set; }
    }

    public class Parameter37
    {
        public string name { get; set; }
        public string _in { get; set; }
        public string description { get; set; }
        public Schema97 schema { get; set; }
    }

    public class Schema97
    {
        public string type { get; set; }
        public bool nullable { get; set; }
        public string format { get; set; }
    }

    public class ApiProductsKey
    {
        public Get21 get { get; set; }
        public Put1 put { get; set; }
        public Post11 post { get; set; }
        public Patch6 patch { get; set; }
        public Delete5 delete { get; set; }
    }

    public class Get21
    {
        public string[] tags { get; set; }
        public string operationId { get; set; }
        public Parameter38[] parameters { get; set; }
        public Responses44 responses { get; set; }
        public string[] xroles { get; set; }
    }

    public class Responses44
    {
        public _20044 _200 { get; set; }
    }

    public class _20044
    {
        public string description { get; set; }
        public Content60 content { get; set; }
    }

    public class Content60
    {
        public ApplicationJson59 applicationjson { get; set; }
    }

    public class ApplicationJson59
    {
        public Schema98 schema { get; set; }
    }

    public class Schema98
    {
        public bool nullable { get; set; }
        public Oneof13[] oneOf { get; set; }
    }

    public class Oneof13
    {
        public string _ref { get; set; }
    }

    public class Parameter38
    {
        public string name { get; set; }
        public string _in { get; set; }
        public bool required { get; set; }
        public Schema99 schema { get; set; }
        public string description { get; set; }
    }

    public class Schema99
    {
        public string type { get; set; }
        public string format { get; set; }
        public bool nullable { get; set; }
    }

    public class Put1
    {
        public string[] tags { get; set; }
        public string operationId { get; set; }
        public Parameter39[] parameters { get; set; }
        public Requestbody16 requestBody { get; set; }
        public Responses45 responses { get; set; }
        public string[] xroles { get; set; }
    }

    public class Requestbody16
    {
        public string xname { get; set; }
        public Content61 content { get; set; }
        public bool required { get; set; }
    }

    public class Content61
    {
        public ApplicationJson60 applicationjson { get; set; }
    }

    public class ApplicationJson60
    {
        public Schema100 schema { get; set; }
    }

    public class Schema100
    {
        public string type { get; set; }
        public string format { get; set; }
    }

    public class Responses45
    {
        public _20045 _200 { get; set; }
    }

    public class _20045
    {
        public string description { get; set; }
        public Content62 content { get; set; }
    }

    public class Content62
    {
        public ApplicationJson61 applicationjson { get; set; }
    }

    public class ApplicationJson61
    {
        public Schema101 schema { get; set; }
    }

    public class Schema101
    {
        public string type { get; set; }
    }

    public class Parameter39
    {
        public string name { get; set; }
        public string _in { get; set; }
        public bool required { get; set; }
        public Schema102 schema { get; set; }
    }

    public class Schema102
    {
        public string type { get; set; }
        public string format { get; set; }
        public bool nullable { get; set; }
    }

    public class Post11
    {
        public string[] tags { get; set; }
        public string operationId { get; set; }
        public Parameter40[] parameters { get; set; }
        public Requestbody17 requestBody { get; set; }
        public Responses46 responses { get; set; }
        public string[] xroles { get; set; }
    }

    public class Requestbody17
    {
        public string xname { get; set; }
        public Content63 content { get; set; }
        public bool required { get; set; }
    }

    public class Content63
    {
        public ApplicationJson62 applicationjson { get; set; }
    }

    public class ApplicationJson62
    {
        public Schema103 schema { get; set; }
    }

    public class Schema103
    {
        public string type { get; set; }
        public string format { get; set; }
    }

    public class Responses46
    {
        public _20046 _200 { get; set; }
    }

    public class _20046
    {
        public string description { get; set; }
        public Content64 content { get; set; }
    }

    public class Content64
    {
        public ApplicationJson63 applicationjson { get; set; }
    }

    public class ApplicationJson63
    {
        public Schema104 schema { get; set; }
    }

    public class Schema104
    {
        public string type { get; set; }
    }

    public class Parameter40
    {
        public string name { get; set; }
        public string _in { get; set; }
        public bool required { get; set; }
        public Schema105 schema { get; set; }
    }

    public class Schema105
    {
        public string type { get; set; }
        public string format { get; set; }
        public bool nullable { get; set; }
    }

    public class Patch6
    {
        public string[] tags { get; set; }
        public string operationId { get; set; }
        public Parameter41[] parameters { get; set; }
        public Requestbody18 requestBody { get; set; }
        public Responses47 responses { get; set; }
        public string[] xroles { get; set; }
    }

    public class Requestbody18
    {
        public string xname { get; set; }
        public Content65 content { get; set; }
        public bool required { get; set; }
    }

    public class Content65
    {
        public ApplicationJson64 applicationjson { get; set; }
    }

    public class ApplicationJson64
    {
        public Schema106 schema { get; set; }
    }

    public class Schema106
    {
        public string _ref { get; set; }
    }

    public class Responses47
    {
        public _20047 _200 { get; set; }
    }

    public class _20047
    {
        public string description { get; set; }
        public Content66 content { get; set; }
    }

    public class Content66
    {
        public ApplicationJson65 applicationjson { get; set; }
    }

    public class ApplicationJson65
    {
        public Schema107 schema { get; set; }
    }

    public class Schema107
    {
        public string type { get; set; }
    }

    public class Parameter41
    {
        public string name { get; set; }
        public string _in { get; set; }
        public bool required { get; set; }
        public Schema108 schema { get; set; }
    }

    public class Schema108
    {
        public string type { get; set; }
        public string format { get; set; }
    }

    public class Delete5
    {
        public string[] tags { get; set; }
        public string operationId { get; set; }
        public Parameter42[] parameters { get; set; }
        public Responses48 responses { get; set; }
        public string[] xroles { get; set; }
    }

    public class Responses48
    {
        public _20048 _200 { get; set; }
    }

    public class _20048
    {
        public string description { get; set; }
        public Content67 content { get; set; }
    }

    public class Content67
    {
        public ApplicationJson66 applicationjson { get; set; }
    }

    public class ApplicationJson66
    {
        public Schema109 schema { get; set; }
    }

    public class Schema109
    {
        public string type { get; set; }
    }

    public class Parameter42
    {
        public string name { get; set; }
        public string _in { get; set; }
        public bool required { get; set; }
        public Schema110 schema { get; set; }
    }

    public class Schema110
    {
        public string type { get; set; }
        public string format { get; set; }
        public bool nullable { get; set; }
    }

    public class ApiProductsKeyGetproductruns
    {
        public Get22 get { get; set; }
    }

    public class Get22
    {
        public string[] tags { get; set; }
        public string operationId { get; set; }
        public Parameter43[] parameters { get; set; }
        public Responses49 responses { get; set; }
        public string[] xroles { get; set; }
    }

    public class Responses49
    {
        public _20049 _200 { get; set; }
    }

    public class _20049
    {
        public string description { get; set; }
        public Content68 content { get; set; }
    }

    public class Content68
    {
        public ApplicationJson67 applicationjson { get; set; }
    }

    public class ApplicationJson67
    {
        public Schema111 schema { get; set; }
    }

    public class Schema111
    {
        public string type { get; set; }
        public bool nullable { get; set; }
        public Items13 items { get; set; }
    }

    public class Items13
    {
        public string _ref { get; set; }
    }

    public class Parameter43
    {
        public string name { get; set; }
        public string _in { get; set; }
        public bool required { get; set; }
        public Schema112 schema { get; set; }
        public string description { get; set; }
    }

    public class Schema112
    {
        public string type { get; set; }
        public string format { get; set; }
        public bool nullable { get; set; }
    }

    public class ApiProductsBulkassign
    {
        public Post12 post { get; set; }
    }

    public class Post12
    {
        public string[] tags { get; set; }
        public string operationId { get; set; }
        public Parameter44[] parameters { get; set; }
        public Requestbody19 requestBody { get; set; }
        public Responses50 responses { get; set; }
        public string[] xroles { get; set; }
    }

    public class Requestbody19
    {
        public string xname { get; set; }
        public Content69 content { get; set; }
        public bool required { get; set; }
    }

    public class Content69
    {
        public ApplicationJson68 applicationjson { get; set; }
    }

    public class ApplicationJson68
    {
        public Schema113 schema { get; set; }
    }

    public class Schema113
    {
        public string _ref { get; set; }
    }

    public class Responses50
    {
        public _20050 _200 { get; set; }
    }

    public class _20050
    {
        public string description { get; set; }
        public Content70 content { get; set; }
    }

    public class Content70
    {
        public ApplicationJson69 applicationjson { get; set; }
    }

    public class ApplicationJson69
    {
        public Schema114 schema { get; set; }
    }

    public class Schema114
    {
        public string type { get; set; }
        public string format { get; set; }
    }

    public class Parameter44
    {
        public string name { get; set; }
        public string _in { get; set; }
        public string description { get; set; }
        public Schema115 schema { get; set; }
    }

    public class Schema115
    {
        public string type { get; set; }
        public bool nullable { get; set; }
    }

    public class ApiProfiles
    {
        public Get23 get { get; set; }
    }

    public class Get23
    {
        public string[] tags { get; set; }
        public string operationId { get; set; }
        public Parameter45[] parameters { get; set; }
        public Responses51 responses { get; set; }
        public string[] xroles { get; set; }
    }

    public class Responses51
    {
        public _20051 _200 { get; set; }
    }

    public class _20051
    {
        public string description { get; set; }
        public Content71 content { get; set; }
    }

    public class Content71
    {
        public ApplicationJson70 applicationjson { get; set; }
    }

    public class ApplicationJson70
    {
        public Schema116 schema { get; set; }
    }

    public class Schema116
    {
        public string type { get; set; }
        public bool nullable { get; set; }
        public Items14 items { get; set; }
    }

    public class Items14
    {
        public string _ref { get; set; }
    }

    public class Parameter45
    {
        public string name { get; set; }
        public string _in { get; set; }
        public string description { get; set; }
        public Schema117 schema { get; set; }
    }

    public class Schema117
    {
        public string type { get; set; }
        public bool nullable { get; set; }
        public string format { get; set; }
    }

    public class ApiProfilesKey
    {
        public Get24 get { get; set; }
        public Put2 put { get; set; }
        public Post13 post { get; set; }
        public Delete6 delete { get; set; }
    }

    public class Get24
    {
        public string[] tags { get; set; }
        public string operationId { get; set; }
        public Parameter46[] parameters { get; set; }
        public Responses52 responses { get; set; }
        public string[] xroles { get; set; }
    }

    public class Responses52
    {
        public _20052 _200 { get; set; }
    }

    public class _20052
    {
        public string description { get; set; }
        public Content72 content { get; set; }
    }

    public class Content72
    {
        public ApplicationJson71 applicationjson { get; set; }
    }

    public class ApplicationJson71
    {
        public Schema118 schema { get; set; }
    }

    public class Schema118
    {
        public bool nullable { get; set; }
        public Oneof14[] oneOf { get; set; }
    }

    public class Oneof14
    {
        public string _ref { get; set; }
    }

    public class Parameter46
    {
        public string name { get; set; }
        public string _in { get; set; }
        public bool required { get; set; }
        public Schema119 schema { get; set; }
        public string description { get; set; }
    }

    public class Schema119
    {
        public string type { get; set; }
        public string format { get; set; }
        public bool nullable { get; set; }
    }

    public class Put2
    {
        public string[] tags { get; set; }
        public string operationId { get; set; }
        public Parameter47[] parameters { get; set; }
        public Requestbody20 requestBody { get; set; }
        public Responses53 responses { get; set; }
        public string[] xroles { get; set; }
    }

    public class Requestbody20
    {
        public string xname { get; set; }
        public Content73 content { get; set; }
        public bool required { get; set; }
    }

    public class Content73
    {
        public ApplicationJson72 applicationjson { get; set; }
    }

    public class ApplicationJson72
    {
        public Schema120 schema { get; set; }
    }

    public class Schema120
    {
        public string type { get; set; }
        public string format { get; set; }
    }

    public class Responses53
    {
        public _20053 _200 { get; set; }
    }

    public class _20053
    {
        public string description { get; set; }
        public Content74 content { get; set; }
    }

    public class Content74
    {
        public ApplicationJson73 applicationjson { get; set; }
    }

    public class ApplicationJson73
    {
        public Schema121 schema { get; set; }
    }

    public class Schema121
    {
        public string type { get; set; }
    }

    public class Parameter47
    {
        public string name { get; set; }
        public string _in { get; set; }
        public bool required { get; set; }
        public Schema122 schema { get; set; }
    }

    public class Schema122
    {
        public string type { get; set; }
        public string format { get; set; }
        public bool nullable { get; set; }
    }

    public class Post13
    {
        public string[] tags { get; set; }
        public string operationId { get; set; }
        public Parameter48[] parameters { get; set; }
        public Requestbody21 requestBody { get; set; }
        public Responses54 responses { get; set; }
        public string[] xroles { get; set; }
    }

    public class Requestbody21
    {
        public string xname { get; set; }
        public Content75 content { get; set; }
        public bool required { get; set; }
    }

    public class Content75
    {
        public ApplicationJson74 applicationjson { get; set; }
    }

    public class ApplicationJson74
    {
        public Schema123 schema { get; set; }
    }

    public class Schema123
    {
        public string type { get; set; }
        public string format { get; set; }
    }

    public class Responses54
    {
        public _20054 _200 { get; set; }
    }

    public class _20054
    {
        public string description { get; set; }
        public Content76 content { get; set; }
    }

    public class Content76
    {
        public ApplicationJson75 applicationjson { get; set; }
    }

    public class ApplicationJson75
    {
        public Schema124 schema { get; set; }
    }

    public class Schema124
    {
        public string type { get; set; }
    }

    public class Parameter48
    {
        public string name { get; set; }
        public string _in { get; set; }
        public bool required { get; set; }
        public Schema125 schema { get; set; }
    }

    public class Schema125
    {
        public string type { get; set; }
        public string format { get; set; }
        public bool nullable { get; set; }
    }

    public class Delete6
    {
        public string[] tags { get; set; }
        public string operationId { get; set; }
        public Parameter49[] parameters { get; set; }
        public Responses55 responses { get; set; }
        public string[] xroles { get; set; }
    }

    public class Responses55
    {
        public _20055 _200 { get; set; }
    }

    public class _20055
    {
        public string description { get; set; }
        public Content77 content { get; set; }
    }

    public class Content77
    {
        public ApplicationJson76 applicationjson { get; set; }
    }

    public class ApplicationJson76
    {
        public Schema126 schema { get; set; }
    }

    public class Schema126
    {
        public string type { get; set; }
    }

    public class Parameter49
    {
        public string name { get; set; }
        public string _in { get; set; }
        public bool required { get; set; }
        public Schema127 schema { get; set; }
    }

    public class Schema127
    {
        public string type { get; set; }
        public string format { get; set; }
        public bool nullable { get; set; }
    }

    public class ApiProfilesIdTaggedcontentitems
    {
        public Get25 get { get; set; }
    }

    public class Get25
    {
        public string[] tags { get; set; }
        public string operationId { get; set; }
        public Parameter50[] parameters { get; set; }
        public Responses56 responses { get; set; }
        public string[] xroles { get; set; }
    }

    public class Responses56
    {
        public _20056 _200 { get; set; }
    }

    public class _20056
    {
        public string description { get; set; }
        public Content78 content { get; set; }
    }

    public class Content78
    {
        public ApplicationJson77 applicationjson { get; set; }
    }

    public class ApplicationJson77
    {
        public Schema128 schema { get; set; }
    }

    public class Schema128
    {
        public string type { get; set; }
        public bool nullable { get; set; }
        public Items15 items { get; set; }
    }

    public class Items15
    {
        public string _ref { get; set; }
    }

    public class Parameter50
    {
        public string name { get; set; }
        public string _in { get; set; }
        public bool required { get; set; }
        public Schema129 schema { get; set; }
        public string description { get; set; }
    }

    public class Schema129
    {
        public string type { get; set; }
        public string format { get; set; }
        public bool nullable { get; set; }
    }

    public class ApiProfilesKeyDeletetag
    {
        public Post14 post { get; set; }
    }

    public class Post14
    {
        public string[] tags { get; set; }
        public string operationId { get; set; }
        public Parameter51[] parameters { get; set; }
        public Requestbody22 requestBody { get; set; }
        public Responses57 responses { get; set; }
        public string[] xroles { get; set; }
    }

    public class Requestbody22
    {
        public string xname { get; set; }
        public Content79 content { get; set; }
        public bool required { get; set; }
    }

    public class Content79
    {
        public ApplicationJson78 applicationjson { get; set; }
    }

    public class ApplicationJson78
    {
        public Schema130 schema { get; set; }
    }

    public class Schema130
    {
        public string _ref { get; set; }
    }

    public class Responses57
    {
        public _20057 _200 { get; set; }
    }

    public class _20057
    {
        public string description { get; set; }
        public Content80 content { get; set; }
    }

    public class Content80
    {
        public ApplicationJson79 applicationjson { get; set; }
    }

    public class ApplicationJson79
    {
        public Schema131 schema { get; set; }
    }

    public class Schema131
    {
        public string type { get; set; }
        public bool nullable { get; set; }
        public Items16 items { get; set; }
    }

    public class Items16
    {
        public string _ref { get; set; }
    }

    public class Parameter51
    {
        public string name { get; set; }
        public string _in { get; set; }
        public bool required { get; set; }
        public Schema132 schema { get; set; }
        public string description { get; set; }
    }

    public class Schema132
    {
        public string type { get; set; }
        public string format { get; set; }
        public bool nullable { get; set; }
    }

    public class ApiProfilesKeyExcludetag
    {
        public Post15 post { get; set; }
    }

    public class Post15
    {
        public string[] tags { get; set; }
        public string operationId { get; set; }
        public Parameter52[] parameters { get; set; }
        public Requestbody23 requestBody { get; set; }
        public Responses58 responses { get; set; }
        public string[] xroles { get; set; }
    }

    public class Requestbody23
    {
        public string xname { get; set; }
        public Content81 content { get; set; }
        public bool required { get; set; }
    }

    public class Content81
    {
        public ApplicationJson80 applicationjson { get; set; }
    }

    public class ApplicationJson80
    {
        public Schema133 schema { get; set; }
    }

    public class Schema133
    {
        public string _ref { get; set; }
    }

    public class Responses58
    {
        public _20058 _200 { get; set; }
    }

    public class _20058
    {
        public string description { get; set; }
        public Content82 content { get; set; }
    }

    public class Content82
    {
        public ApplicationJson81 applicationjson { get; set; }
    }

    public class ApplicationJson81
    {
        public Schema134 schema { get; set; }
    }

    public class Schema134
    {
        public string type { get; set; }
        public bool nullable { get; set; }
        public Items17 items { get; set; }
    }

    public class Items17
    {
        public string _ref { get; set; }
    }

    public class Parameter52
    {
        public string name { get; set; }
        public string _in { get; set; }
        public bool required { get; set; }
        public Schema135 schema { get; set; }
        public string description { get; set; }
    }

    public class Schema135
    {
        public string type { get; set; }
        public string format { get; set; }
        public bool nullable { get; set; }
    }

    public class ApiProfilesKeyIncludetag
    {
        public Post16 post { get; set; }
    }

    public class Post16
    {
        public string[] tags { get; set; }
        public string operationId { get; set; }
        public Parameter53[] parameters { get; set; }
        public Requestbody24 requestBody { get; set; }
        public Responses59 responses { get; set; }
        public string[] xroles { get; set; }
    }

    public class Requestbody24
    {
        public string xname { get; set; }
        public Content83 content { get; set; }
        public bool required { get; set; }
    }

    public class Content83
    {
        public ApplicationJson82 applicationjson { get; set; }
    }

    public class ApplicationJson82
    {
        public Schema136 schema { get; set; }
    }

    public class Schema136
    {
        public string _ref { get; set; }
    }

    public class Responses59
    {
        public _20059 _200 { get; set; }
    }

    public class _20059
    {
        public string description { get; set; }
        public Content84 content { get; set; }
    }

    public class Content84
    {
        public ApplicationJson83 applicationjson { get; set; }
    }

    public class ApplicationJson83
    {
        public Schema137 schema { get; set; }
    }

    public class Schema137
    {
        public string type { get; set; }
        public bool nullable { get; set; }
        public Items18 items { get; set; }
    }

    public class Items18
    {
        public string _ref { get; set; }
    }

    public class Parameter53
    {
        public string name { get; set; }
        public string _in { get; set; }
        public bool required { get; set; }
        public Schema138 schema { get; set; }
        public string description { get; set; }
    }

    public class Schema138
    {
        public string type { get; set; }
        public string format { get; set; }
        public bool nullable { get; set; }
    }

    public class ApiProfilesKeyProfilebubble
    {
        public Post17 post { get; set; }
    }

    public class Post17
    {
        public string[] tags { get; set; }
        public string operationId { get; set; }
        public Parameter54[] parameters { get; set; }
        public Responses60 responses { get; set; }
        public string[] xroles { get; set; }
    }

    public class Responses60
    {
        public _20060 _200 { get; set; }
    }

    public class _20060
    {
        public string description { get; set; }
        public Content85 content { get; set; }
    }

    public class Content85
    {
        public ApplicationJson84 applicationjson { get; set; }
    }

    public class ApplicationJson84
    {
        public Schema139 schema { get; set; }
    }

    public class Schema139
    {
        public bool nullable { get; set; }
        public Oneof15[] oneOf { get; set; }
    }

    public class Oneof15
    {
        public string _ref { get; set; }
    }

    public class Parameter54
    {
        public string name { get; set; }
        public string _in { get; set; }
        public bool required { get; set; }
        public Schema140 schema { get; set; }
        public string description { get; set; }
    }

    public class Schema140
    {
        public string type { get; set; }
        public string format { get; set; }
        public bool nullable { get; set; }
    }

    public class ApiCosttypes
    {
        public Get26 get { get; set; }
    }

    public class Get26
    {
        public string[] tags { get; set; }
        public string operationId { get; set; }
        public Parameter55[] parameters { get; set; }
        public Responses61 responses { get; set; }
        public string[] xroles { get; set; }
    }

    public class Responses61
    {
        public _20061 _200 { get; set; }
    }

    public class _20061
    {
        public string description { get; set; }
        public Content86 content { get; set; }
    }

    public class Content86
    {
        public ApplicationJson85 applicationjson { get; set; }
    }

    public class ApplicationJson85
    {
        public Schema141 schema { get; set; }
    }

    public class Schema141
    {
        public string type { get; set; }
        public bool nullable { get; set; }
        public Items19 items { get; set; }
    }

    public class Items19
    {
        public string _ref { get; set; }
    }

    public class Parameter55
    {
        public string name { get; set; }
        public string _in { get; set; }
        public string description { get; set; }
        public Schema142 schema { get; set; }
    }

    public class Schema142
    {
        public string type { get; set; }
        public bool nullable { get; set; }
        public string format { get; set; }
    }

    public class ApiCosttypesKey
    {
        public Get27 get { get; set; }
    }

    public class Get27
    {
        public string[] tags { get; set; }
        public string operationId { get; set; }
        public Parameter56[] parameters { get; set; }
        public Responses62 responses { get; set; }
        public string[] xroles { get; set; }
    }

    public class Responses62
    {
        public _20062 _200 { get; set; }
    }

    public class _20062
    {
        public string description { get; set; }
        public Content87 content { get; set; }
    }

    public class Content87
    {
        public ApplicationJson86 applicationjson { get; set; }
    }

    public class ApplicationJson86
    {
        public Schema143 schema { get; set; }
    }

    public class Schema143
    {
        public bool nullable { get; set; }
        public Oneof16[] oneOf { get; set; }
    }

    public class Oneof16
    {
        public string _ref { get; set; }
    }

    public class Parameter56
    {
        public string name { get; set; }
        public string _in { get; set; }
        public bool required { get; set; }
        public Schema144 schema { get; set; }
        public string description { get; set; }
    }

    public class Schema144
    {
        public string type { get; set; }
        public string format { get; set; }
        public bool nullable { get; set; }
    }

    public class ApiEmployees
    {
        public Get28 get { get; set; }
    }

    public class Get28
    {
        public string[] tags { get; set; }
        public string operationId { get; set; }
        public Parameter57[] parameters { get; set; }
        public Responses63 responses { get; set; }
        public string[] xroles { get; set; }
    }

    public class Responses63
    {
        public _20063 _200 { get; set; }
    }

    public class _20063
    {
        public string description { get; set; }
        public Content88 content { get; set; }
    }

    public class Content88
    {
        public ApplicationJson87 applicationjson { get; set; }
    }

    public class ApplicationJson87
    {
        public Schema145 schema { get; set; }
    }

    public class Schema145
    {
        public string type { get; set; }
        public bool nullable { get; set; }
        public Items20 items { get; set; }
    }

    public class Items20
    {
        public string _ref { get; set; }
    }

    public class Parameter57
    {
        public string name { get; set; }
        public string _in { get; set; }
        public string description { get; set; }
        public Schema146 schema { get; set; }
    }

    public class Schema146
    {
        public string type { get; set; }
        public bool nullable { get; set; }
        public string format { get; set; }
    }

    public class ApiEmployeesKey
    {
        public Get29 get { get; set; }
    }

    public class Get29
    {
        public string[] tags { get; set; }
        public string operationId { get; set; }
        public Parameter58[] parameters { get; set; }
        public Responses64 responses { get; set; }
        public string[] xroles { get; set; }
    }

    public class Responses64
    {
        public _20064 _200 { get; set; }
    }

    public class _20064
    {
        public string description { get; set; }
        public Content89 content { get; set; }
    }

    public class Content89
    {
        public ApplicationJson88 applicationjson { get; set; }
    }

    public class ApplicationJson88
    {
        public Schema147 schema { get; set; }
    }

    public class Schema147
    {
        public bool nullable { get; set; }
        public Oneof17[] oneOf { get; set; }
    }

    public class Oneof17
    {
        public string _ref { get; set; }
    }

    public class Parameter58
    {
        public string name { get; set; }
        public string _in { get; set; }
        public bool required { get; set; }
        public Schema148 schema { get; set; }
        public string description { get; set; }
    }

    public class Schema148
    {
        public string type { get; set; }
        public string format { get; set; }
        public bool nullable { get; set; }
    }

    public class ApiEmployeesKeyNotifications
    {
        public Get30 get { get; set; }
    }

    public class Get30
    {
        public string[] tags { get; set; }
        public string operationId { get; set; }
        public Parameter59[] parameters { get; set; }
        public Responses65 responses { get; set; }
        public string[] xroles { get; set; }
    }

    public class Responses65
    {
        public _20065 _200 { get; set; }
    }

    public class _20065
    {
        public string description { get; set; }
        public Content90 content { get; set; }
    }

    public class Content90
    {
        public ApplicationJson89 applicationjson { get; set; }
    }

    public class ApplicationJson89
    {
        public Schema149 schema { get; set; }
    }

    public class Schema149
    {
        public string type { get; set; }
        public bool nullable { get; set; }
        public Items21 items { get; set; }
    }

    public class Items21
    {
        public string _ref { get; set; }
    }

    public class Parameter59
    {
        public string name { get; set; }
        public string _in { get; set; }
        public bool required { get; set; }
        public Schema150 schema { get; set; }
        public string description { get; set; }
    }

    public class Schema150
    {
        public string type { get; set; }
        public string format { get; set; }
        public bool nullable { get; set; }
    }

    public class ApiEmployeesKeyCurrentperiodemployee
    {
        public Get31 get { get; set; }
    }

    public class Get31
    {
        public string[] tags { get; set; }
        public string operationId { get; set; }
        public Parameter60[] parameters { get; set; }
        public Responses66 responses { get; set; }
        public string[] xroles { get; set; }
    }

    public class Responses66
    {
        public _20066 _200 { get; set; }
    }

    public class _20066
    {
        public string description { get; set; }
        public Content91 content { get; set; }
    }

    public class Content91
    {
        public ApplicationJson90 applicationjson { get; set; }
    }

    public class ApplicationJson90
    {
        public Schema151 schema { get; set; }
    }

    public class Schema151
    {
        public bool nullable { get; set; }
        public Oneof18[] oneOf { get; set; }
    }

    public class Oneof18
    {
        public string _ref { get; set; }
    }

    public class Parameter60
    {
        public string name { get; set; }
        public string _in { get; set; }
        public bool required { get; set; }
        public Schema152 schema { get; set; }
        public string description { get; set; }
    }

    public class Schema152
    {
        public string type { get; set; }
        public string format { get; set; }
        public bool nullable { get; set; }
    }

    public class ApiEmployeesBulkcreatenotifications
    {
        public Post18 post { get; set; }
    }

    public class Post18
    {
        public string[] tags { get; set; }
        public string operationId { get; set; }
        public Parameter61[] parameters { get; set; }
        public Requestbody25 requestBody { get; set; }
        public Responses67 responses { get; set; }
        public string[] xroles { get; set; }
    }

    public class Requestbody25
    {
        public string xname { get; set; }
        public Content92 content { get; set; }
        public bool required { get; set; }
    }

    public class Content92
    {
        public ApplicationJson91 applicationjson { get; set; }
    }

    public class ApplicationJson91
    {
        public Schema153 schema { get; set; }
    }

    public class Schema153
    {
        public string _ref { get; set; }
    }

    public class Responses67
    {
        public _20067 _200 { get; set; }
    }

    public class _20067
    {
        public string description { get; set; }
        public Content93 content { get; set; }
    }

    public class Content93
    {
        public ApplicationJson92 applicationjson { get; set; }
    }

    public class ApplicationJson92
    {
        public Schema154 schema { get; set; }
    }

    public class Schema154
    {
        public string type { get; set; }
        public string format { get; set; }
    }

    public class Parameter61
    {
        public string name { get; set; }
        public string _in { get; set; }
        public string description { get; set; }
        public Schema155 schema { get; set; }
    }

    public class Schema155
    {
        public string type { get; set; }
        public bool nullable { get; set; }
    }

    public class ApiEmployeesKeyMarknotificationasread
    {
        public Post19 post { get; set; }
    }

    public class Post19
    {
        public string[] tags { get; set; }
        public string operationId { get; set; }
        public Parameter62[] parameters { get; set; }
        public Requestbody26 requestBody { get; set; }
        public Responses68 responses { get; set; }
        public string[] xroles { get; set; }
    }

    public class Requestbody26
    {
        public string xname { get; set; }
        public Content94 content { get; set; }
        public bool required { get; set; }
    }

    public class Content94
    {
        public ApplicationJson93 applicationjson { get; set; }
    }

    public class ApplicationJson93
    {
        public Schema156 schema { get; set; }
    }

    public class Schema156
    {
        public string _ref { get; set; }
    }

    public class Responses68
    {
        public _20068 _200 { get; set; }
    }

    public class _20068
    {
        public string description { get; set; }
        public Content95 content { get; set; }
    }

    public class Content95
    {
        public ApplicationJson94 applicationjson { get; set; }
    }

    public class ApplicationJson94
    {
        public Schema157 schema { get; set; }
    }

    public class Schema157
    {
        public bool nullable { get; set; }
        public Oneof19[] oneOf { get; set; }
    }

    public class Oneof19
    {
        public string _ref { get; set; }
    }

    public class Parameter62
    {
        public string name { get; set; }
        public string _in { get; set; }
        public bool required { get; set; }
        public Schema158 schema { get; set; }
        public string description { get; set; }
    }

    public class Schema158
    {
        public string type { get; set; }
        public string format { get; set; }
        public bool nullable { get; set; }
    }

    public class ApiActivations
    {
        public Get32 get { get; set; }
    }

    public class Get32
    {
        public string[] tags { get; set; }
        public string operationId { get; set; }
        public Parameter63[] parameters { get; set; }
        public Responses69 responses { get; set; }
        public string[] xroles { get; set; }
    }

    public class Responses69
    {
        public _20069 _200 { get; set; }
    }

    public class _20069
    {
        public string description { get; set; }
        public Content96 content { get; set; }
    }

    public class Content96
    {
        public ApplicationJson95 applicationjson { get; set; }
    }

    public class ApplicationJson95
    {
        public Schema159 schema { get; set; }
    }

    public class Schema159
    {
        public string type { get; set; }
        public bool nullable { get; set; }
        public Items22 items { get; set; }
    }

    public class Items22
    {
        public string _ref { get; set; }
    }

    public class Parameter63
    {
        public string name { get; set; }
        public string _in { get; set; }
        public string description { get; set; }
        public Schema160 schema { get; set; }
    }

    public class Schema160
    {
        public string type { get; set; }
        public bool nullable { get; set; }
        public string format { get; set; }
    }

    public class ApiActivationsKey
    {
        public Get33 get { get; set; }
    }

    public class Get33
    {
        public string[] tags { get; set; }
        public string operationId { get; set; }
        public Parameter64[] parameters { get; set; }
        public Responses70 responses { get; set; }
        public string[] xroles { get; set; }
    }

    public class Responses70
    {
        public _20070 _200 { get; set; }
    }

    public class _20070
    {
        public string description { get; set; }
        public Content97 content { get; set; }
    }

    public class Content97
    {
        public ApplicationJson96 applicationjson { get; set; }
    }

    public class ApplicationJson96
    {
        public Schema161 schema { get; set; }
    }

    public class Schema161
    {
        public bool nullable { get; set; }
        public Oneof20[] oneOf { get; set; }
    }

    public class Oneof20
    {
        public string _ref { get; set; }
    }

    public class Parameter64
    {
        public string name { get; set; }
        public string _in { get; set; }
        public bool required { get; set; }
        public Schema162 schema { get; set; }
        public string description { get; set; }
    }

    public class Schema162
    {
        public string type { get; set; }
        public string format { get; set; }
        public bool nullable { get; set; }
    }

    public class ApiActivationsAddmanager
    {
        public Post20 post { get; set; }
    }

    public class Post20
    {
        public string[] tags { get; set; }
        public string operationId { get; set; }
        public Parameter65[] parameters { get; set; }
        public Requestbody27 requestBody { get; set; }
        public Responses71 responses { get; set; }
        public string[] xroles { get; set; }
    }

    public class Requestbody27
    {
        public string xname { get; set; }
        public Content98 content { get; set; }
        public bool required { get; set; }
    }

    public class Content98
    {
        public ApplicationJson97 applicationjson { get; set; }
    }

    public class ApplicationJson97
    {
        public Schema163 schema { get; set; }
    }

    public class Schema163
    {
        public string _ref { get; set; }
    }

    public class Responses71
    {
        public _20071 _200 { get; set; }
    }

    public class _20071
    {
        public string description { get; set; }
        public Content99 content { get; set; }
    }

    public class Content99
    {
        public ApplicationJson98 applicationjson { get; set; }
    }

    public class ApplicationJson98
    {
        public Schema164 schema { get; set; }
    }

    public class Schema164
    {
        public bool nullable { get; set; }
        public Oneof21[] oneOf { get; set; }
    }

    public class Oneof21
    {
        public string _ref { get; set; }
    }

    public class Parameter65
    {
        public string name { get; set; }
        public string _in { get; set; }
        public string description { get; set; }
        public Schema165 schema { get; set; }
    }

    public class Schema165
    {
        public string type { get; set; }
        public bool nullable { get; set; }
    }

    public class ApiActivationsKeyQueuemail
    {
        public Post21 post { get; set; }
    }

    public class Post21
    {
        public string[] tags { get; set; }
        public string operationId { get; set; }
        public Parameter66[] parameters { get; set; }
        public Responses72 responses { get; set; }
        public string[] xroles { get; set; }
    }

    public class Responses72
    {
        public _20072 _200 { get; set; }
    }

    public class _20072
    {
        public string description { get; set; }
        public Content100 content { get; set; }
    }

    public class Content100
    {
        public ApplicationJson99 applicationjson { get; set; }
    }

    public class ApplicationJson99
    {
        public Schema166 schema { get; set; }
    }

    public class Schema166
    {
        public bool nullable { get; set; }
        public Oneof22[] oneOf { get; set; }
    }

    public class Oneof22
    {
        public string _ref { get; set; }
    }

    public class Parameter66
    {
        public string name { get; set; }
        public string _in { get; set; }
        public bool required { get; set; }
        public Schema167 schema { get; set; }
        public string description { get; set; }
    }

    public class Schema167
    {
        public string type { get; set; }
        public string format { get; set; }
        public bool nullable { get; set; }
    }

    public class ApiActivationsKeyGenerateletter
    {
        public Post22 post { get; set; }
    }

    public class Post22
    {
        public string[] tags { get; set; }
        public string operationId { get; set; }
        public Parameter67[] parameters { get; set; }
        public Responses73 responses { get; set; }
        public string[] xroles { get; set; }
    }

    public class Responses73
    {
        public _20073 _200 { get; set; }
    }

    public class _20073
    {
        public string description { get; set; }
        public Content101 content { get; set; }
    }

    public class Content101
    {
        public ApplicationJson100 applicationjson { get; set; }
    }

    public class ApplicationJson100
    {
        public Schema168 schema { get; set; }
    }

    public class Schema168
    {
        public bool nullable { get; set; }
        public Oneof23[] oneOf { get; set; }
    }

    public class Oneof23
    {
        public string _ref { get; set; }
    }

    public class Parameter67
    {
        public string name { get; set; }
        public string _in { get; set; }
        public bool required { get; set; }
        public Schema169 schema { get; set; }
        public string description { get; set; }
    }

    public class Schema169
    {
        public string type { get; set; }
        public string format { get; set; }
        public bool nullable { get; set; }
    }

    public class ApiPlancomments
    {
        public Get34 get { get; set; }
        public Post23 post { get; set; }
    }

    public class Get34
    {
        public string[] tags { get; set; }
        public string operationId { get; set; }
        public Parameter68[] parameters { get; set; }
        public Responses74 responses { get; set; }
        public string[] xroles { get; set; }
    }

    public class Responses74
    {
        public _20074 _200 { get; set; }
    }

    public class _20074
    {
        public string description { get; set; }
        public Content102 content { get; set; }
    }

    public class Content102
    {
        public ApplicationJson101 applicationjson { get; set; }
    }

    public class ApplicationJson101
    {
        public Schema170 schema { get; set; }
    }

    public class Schema170
    {
        public string type { get; set; }
        public bool nullable { get; set; }
        public Items23 items { get; set; }
    }

    public class Items23
    {
        public string _ref { get; set; }
    }

    public class Parameter68
    {
        public string name { get; set; }
        public string _in { get; set; }
        public string description { get; set; }
        public Schema171 schema { get; set; }
    }

    public class Schema171
    {
        public string type { get; set; }
        public bool nullable { get; set; }
        public string format { get; set; }
    }

    public class Post23
    {
        public string[] tags { get; set; }
        public string operationId { get; set; }
        public Requestbody28 requestBody { get; set; }
        public Responses75 responses { get; set; }
        public string[] xroles { get; set; }
    }

    public class Requestbody28
    {
        public string xname { get; set; }
        public Content103 content { get; set; }
        public bool required { get; set; }
    }

    public class Content103
    {
        public ApplicationJson102 applicationjson { get; set; }
    }

    public class ApplicationJson102
    {
        public Schema172 schema { get; set; }
    }

    public class Schema172
    {
        public string _ref { get; set; }
    }

    public class Responses75
    {
        public _20075 _200 { get; set; }
    }

    public class _20075
    {
        public string description { get; set; }
        public Content104 content { get; set; }
    }

    public class Content104
    {
        public ApplicationJson103 applicationjson { get; set; }
    }

    public class ApplicationJson103
    {
        public Schema173 schema { get; set; }
    }

    public class Schema173
    {
        public string type { get; set; }
    }

    public class ApiPlancommentsKey
    {
        public Get35 get { get; set; }
        public Patch7 patch { get; set; }
        public Delete7 delete { get; set; }
    }

    public class Get35
    {
        public string[] tags { get; set; }
        public string operationId { get; set; }
        public Parameter69[] parameters { get; set; }
        public Responses76 responses { get; set; }
        public string[] xroles { get; set; }
    }

    public class Responses76
    {
        public _20076 _200 { get; set; }
    }

    public class _20076
    {
        public string description { get; set; }
        public Content105 content { get; set; }
    }

    public class Content105
    {
        public ApplicationJson104 applicationjson { get; set; }
    }

    public class ApplicationJson104
    {
        public Schema174 schema { get; set; }
    }

    public class Schema174
    {
        public bool nullable { get; set; }
        public Oneof24[] oneOf { get; set; }
    }

    public class Oneof24
    {
        public string _ref { get; set; }
    }

    public class Parameter69
    {
        public string name { get; set; }
        public string _in { get; set; }
        public bool required { get; set; }
        public Schema175 schema { get; set; }
        public string description { get; set; }
    }

    public class Schema175
    {
        public string type { get; set; }
        public string format { get; set; }
        public bool nullable { get; set; }
    }

    public class Patch7
    {
        public string[] tags { get; set; }
        public string operationId { get; set; }
        public Parameter70[] parameters { get; set; }
        public Requestbody29 requestBody { get; set; }
        public Responses77 responses { get; set; }
        public string[] xroles { get; set; }
    }

    public class Requestbody29
    {
        public string xname { get; set; }
        public Content106 content { get; set; }
        public bool required { get; set; }
    }

    public class Content106
    {
        public ApplicationJson105 applicationjson { get; set; }
    }

    public class ApplicationJson105
    {
        public Schema176 schema { get; set; }
    }

    public class Schema176
    {
        public string _ref { get; set; }
    }

    public class Responses77
    {
        public _20077 _200 { get; set; }
    }

    public class _20077
    {
        public string description { get; set; }
        public Content107 content { get; set; }
    }

    public class Content107
    {
        public ApplicationJson106 applicationjson { get; set; }
    }

    public class ApplicationJson106
    {
        public Schema177 schema { get; set; }
    }

    public class Schema177
    {
        public string type { get; set; }
    }

    public class Parameter70
    {
        public string name { get; set; }
        public string _in { get; set; }
        public bool required { get; set; }
        public Schema178 schema { get; set; }
    }

    public class Schema178
    {
        public string type { get; set; }
        public string format { get; set; }
    }

    public class Delete7
    {
        public string[] tags { get; set; }
        public string operationId { get; set; }
        public Parameter71[] parameters { get; set; }
        public Responses78 responses { get; set; }
        public string[] xroles { get; set; }
    }

    public class Responses78
    {
        public _20078 _200 { get; set; }
    }

    public class _20078
    {
        public string description { get; set; }
        public Content108 content { get; set; }
    }

    public class Content108
    {
        public ApplicationJson107 applicationjson { get; set; }
    }

    public class ApplicationJson107
    {
        public Schema179 schema { get; set; }
    }

    public class Schema179
    {
        public string type { get; set; }
    }

    public class Parameter71
    {
        public string name { get; set; }
        public string _in { get; set; }
        public bool required { get; set; }
        public Schema180 schema { get; set; }
    }

    public class Schema180
    {
        public string type { get; set; }
        public string format { get; set; }
    }

    public class ApiTransactions
    {
        public Get36 get { get; set; }
    }

    public class Get36
    {
        public string[] tags { get; set; }
        public string operationId { get; set; }
        public Parameter72[] parameters { get; set; }
        public Responses79 responses { get; set; }
        public string[] xroles { get; set; }
    }

    public class Responses79
    {
        public _20079 _200 { get; set; }
    }

    public class _20079
    {
        public string description { get; set; }
        public Content109 content { get; set; }
    }

    public class Content109
    {
        public ApplicationJson108 applicationjson { get; set; }
    }

    public class ApplicationJson108
    {
        public Schema181 schema { get; set; }
    }

    public class Schema181
    {
        public string type { get; set; }
        public bool nullable { get; set; }
        public Items24 items { get; set; }
    }

    public class Items24
    {
        public string _ref { get; set; }
    }

    public class Parameter72
    {
        public string name { get; set; }
        public string _in { get; set; }
        public string description { get; set; }
        public Schema182 schema { get; set; }
    }

    public class Schema182
    {
        public string type { get; set; }
        public bool nullable { get; set; }
        public string format { get; set; }
    }

    public class ApiTransactionsKey
    {
        public Get37 get { get; set; }
        public Post24 post { get; set; }
    }

    public class Get37
    {
        public string[] tags { get; set; }
        public string operationId { get; set; }
        public Parameter73[] parameters { get; set; }
        public Responses80 responses { get; set; }
        public string[] xroles { get; set; }
    }

    public class Responses80
    {
        public _20080 _200 { get; set; }
    }

    public class _20080
    {
        public string description { get; set; }
        public Content110 content { get; set; }
    }

    public class Content110
    {
        public ApplicationJson109 applicationjson { get; set; }
    }

    public class ApplicationJson109
    {
        public Schema183 schema { get; set; }
    }

    public class Schema183
    {
        public bool nullable { get; set; }
        public Oneof25[] oneOf { get; set; }
    }

    public class Oneof25
    {
        public string _ref { get; set; }
    }

    public class Parameter73
    {
        public string name { get; set; }
        public string _in { get; set; }
        public bool required { get; set; }
        public Schema184 schema { get; set; }
        public string description { get; set; }
    }

    public class Schema184
    {
        public string type { get; set; }
        public string format { get; set; }
        public bool nullable { get; set; }
    }

    public class Post24
    {
        public string[] tags { get; set; }
        public string operationId { get; set; }
        public Parameter74[] parameters { get; set; }
        public Requestbody30 requestBody { get; set; }
        public Responses81 responses { get; set; }
        public string[] xroles { get; set; }
    }

    public class Requestbody30
    {
        public string xname { get; set; }
        public Content111 content { get; set; }
        public bool required { get; set; }
    }

    public class Content111
    {
        public ApplicationJson110 applicationjson { get; set; }
    }

    public class ApplicationJson110
    {
        public Schema185 schema { get; set; }
    }

    public class Schema185
    {
        public string _ref { get; set; }
    }

    public class Responses81
    {
        public _20081 _200 { get; set; }
    }

    public class _20081
    {
        public string description { get; set; }
        public Content112 content { get; set; }
    }

    public class Content112
    {
        public ApplicationJson111 applicationjson { get; set; }
    }

    public class ApplicationJson111
    {
        public Schema186 schema { get; set; }
    }

    public class Schema186
    {
        public bool nullable { get; set; }
        public Oneof26[] oneOf { get; set; }
    }

    public class Oneof26
    {
        public string _ref { get; set; }
    }

    public class Parameter74
    {
        public string name { get; set; }
        public string _in { get; set; }
        public bool required { get; set; }
        public Schema187 schema { get; set; }
    }

    public class Schema187
    {
        public string type { get; set; }
        public string format { get; set; }
    }

    public class ApiTransactionsBulkrefund
    {
        public Post25 post { get; set; }
    }

    public class Post25
    {
        public string[] tags { get; set; }
        public string operationId { get; set; }
        public Parameter75[] parameters { get; set; }
        public Requestbody31 requestBody { get; set; }
        public Responses82 responses { get; set; }
        public string[] xroles { get; set; }
    }

    public class Requestbody31
    {
        public string xname { get; set; }
        public Content113 content { get; set; }
        public bool required { get; set; }
    }

    public class Content113
    {
        public ApplicationJson112 applicationjson { get; set; }
    }

    public class ApplicationJson112
    {
        public Schema188 schema { get; set; }
    }

    public class Schema188
    {
        public string _ref { get; set; }
    }

    public class Responses82
    {
        public _20082 _200 { get; set; }
    }

    public class _20082
    {
        public string description { get; set; }
        public Content114 content { get; set; }
    }

    public class Content114
    {
        public ApplicationJson113 applicationjson { get; set; }
    }

    public class ApplicationJson113
    {
        public Schema189 schema { get; set; }
    }

    public class Schema189
    {
        public string type { get; set; }
        public string format { get; set; }
    }

    public class Parameter75
    {
        public string name { get; set; }
        public string _in { get; set; }
        public string description { get; set; }
        public Schema190 schema { get; set; }
    }

    public class Schema190
    {
        public string type { get; set; }
        public bool nullable { get; set; }
    }

    public class ApiTransactionsBulkreject
    {
        public Post26 post { get; set; }
    }

    public class Post26
    {
        public string[] tags { get; set; }
        public string operationId { get; set; }
        public Parameter76[] parameters { get; set; }
        public Requestbody32 requestBody { get; set; }
        public Responses83 responses { get; set; }
        public string[] xroles { get; set; }
    }

    public class Requestbody32
    {
        public string xname { get; set; }
        public Content115 content { get; set; }
        public bool required { get; set; }
    }

    public class Content115
    {
        public ApplicationJson114 applicationjson { get; set; }
    }

    public class ApplicationJson114
    {
        public Schema191 schema { get; set; }
    }

    public class Schema191
    {
        public string _ref { get; set; }
    }

    public class Responses83
    {
        public _20083 _200 { get; set; }
    }

    public class _20083
    {
        public string description { get; set; }
        public Content116 content { get; set; }
    }

    public class Content116
    {
        public ApplicationJson115 applicationjson { get; set; }
    }

    public class ApplicationJson115
    {
        public Schema192 schema { get; set; }
    }

    public class Schema192
    {
        public string type { get; set; }
        public string format { get; set; }
    }

    public class Parameter76
    {
        public string name { get; set; }
        public string _in { get; set; }
        public string description { get; set; }
        public Schema193 schema { get; set; }
    }

    public class Schema193
    {
        public string type { get; set; }
        public bool nullable { get; set; }
    }

    public class ApiTransactionsBulkapprove
    {
        public Post27 post { get; set; }
    }

    public class Post27
    {
        public string[] tags { get; set; }
        public string operationId { get; set; }
        public Parameter77[] parameters { get; set; }
        public Requestbody33 requestBody { get; set; }
        public Responses84 responses { get; set; }
        public string[] xroles { get; set; }
    }

    public class Requestbody33
    {
        public string xname { get; set; }
        public Content117 content { get; set; }
        public bool required { get; set; }
    }

    public class Content117
    {
        public ApplicationJson116 applicationjson { get; set; }
    }

    public class ApplicationJson116
    {
        public Schema194 schema { get; set; }
    }

    public class Schema194
    {
        public string _ref { get; set; }
    }

    public class Responses84
    {
        public _20084 _200 { get; set; }
    }

    public class _20084
    {
        public string description { get; set; }
        public Content118 content { get; set; }
    }

    public class Content118
    {
        public ApplicationJson117 applicationjson { get; set; }
    }

    public class ApplicationJson117
    {
        public Schema195 schema { get; set; }
    }

    public class Schema195
    {
        public string type { get; set; }
        public string format { get; set; }
    }

    public class Parameter77
    {
        public string name { get; set; }
        public string _in { get; set; }
        public string description { get; set; }
        public Schema196 schema { get; set; }
    }

    public class Schema196
    {
        public string type { get; set; }
        public bool nullable { get; set; }
    }

    public class ApiTransactionsKeyCancel
    {
        public Post28 post { get; set; }
    }

    public class Post28
    {
        public string[] tags { get; set; }
        public string operationId { get; set; }
        public Parameter78[] parameters { get; set; }
        public Responses85 responses { get; set; }
        public string[] xroles { get; set; }
    }

    public class Responses85
    {
        public _20085 _200 { get; set; }
    }

    public class _20085
    {
        public string description { get; set; }
        public Content119 content { get; set; }
    }

    public class Content119
    {
        public ApplicationJson118 applicationjson { get; set; }
    }

    public class ApplicationJson118
    {
        public Schema197 schema { get; set; }
    }

    public class Schema197
    {
        public bool nullable { get; set; }
        public Oneof27[] oneOf { get; set; }
    }

    public class Oneof27
    {
        public string _ref { get; set; }
    }

    public class Parameter78
    {
        public string name { get; set; }
        public string _in { get; set; }
        public bool required { get; set; }
        public Schema198 schema { get; set; }
        public string description { get; set; }
    }

    public class Schema198
    {
        public string type { get; set; }
        public string format { get; set; }
        public bool nullable { get; set; }
    }

    public class ApiTransactionsKeyRefund
    {
        public Post29 post { get; set; }
    }

    public class Post29
    {
        public string[] tags { get; set; }
        public string operationId { get; set; }
        public Parameter79[] parameters { get; set; }
        public Requestbody34 requestBody { get; set; }
        public Responses86 responses { get; set; }
        public string[] xroles { get; set; }
    }

    public class Requestbody34
    {
        public string xname { get; set; }
        public Content120 content { get; set; }
        public bool required { get; set; }
    }

    public class Content120
    {
        public ApplicationJson119 applicationjson { get; set; }
    }

    public class ApplicationJson119
    {
        public Schema199 schema { get; set; }
    }

    public class Schema199
    {
        public string _ref { get; set; }
    }

    public class Responses86
    {
        public _20086 _200 { get; set; }
    }

    public class _20086
    {
        public string description { get; set; }
        public Content121 content { get; set; }
    }

    public class Content121
    {
        public ApplicationJson120 applicationjson { get; set; }
    }

    public class ApplicationJson120
    {
        public Schema200 schema { get; set; }
    }

    public class Schema200
    {
        public bool nullable { get; set; }
        public Oneof28[] oneOf { get; set; }
    }

    public class Oneof28
    {
        public string _ref { get; set; }
    }

    public class Parameter79
    {
        public string name { get; set; }
        public string _in { get; set; }
        public bool required { get; set; }
        public Schema201 schema { get; set; }
        public string description { get; set; }
    }

    public class Schema201
    {
        public string type { get; set; }
        public string format { get; set; }
        public bool nullable { get; set; }
    }

    public class ApiTransactionsKeyReject
    {
        public Post30 post { get; set; }
    }

    public class Post30
    {
        public string[] tags { get; set; }
        public string operationId { get; set; }
        public Parameter80[] parameters { get; set; }
        public Requestbody35 requestBody { get; set; }
        public Responses87 responses { get; set; }
        public string[] xroles { get; set; }
    }

    public class Requestbody35
    {
        public string xname { get; set; }
        public Content122 content { get; set; }
        public bool required { get; set; }
    }

    public class Content122
    {
        public ApplicationJson121 applicationjson { get; set; }
    }

    public class ApplicationJson121
    {
        public Schema202 schema { get; set; }
    }

    public class Schema202
    {
        public string _ref { get; set; }
    }

    public class Responses87
    {
        public _20087 _200 { get; set; }
    }

    public class _20087
    {
        public string description { get; set; }
        public Content123 content { get; set; }
    }

    public class Content123
    {
        public ApplicationJson122 applicationjson { get; set; }
    }

    public class ApplicationJson122
    {
        public Schema203 schema { get; set; }
    }

    public class Schema203
    {
        public bool nullable { get; set; }
        public Oneof29[] oneOf { get; set; }
    }

    public class Oneof29
    {
        public string _ref { get; set; }
    }

    public class Parameter80
    {
        public string name { get; set; }
        public string _in { get; set; }
        public bool required { get; set; }
        public Schema204 schema { get; set; }
        public string description { get; set; }
    }

    public class Schema204
    {
        public string type { get; set; }
        public string format { get; set; }
        public bool nullable { get; set; }
    }

    public class ApiTransactionsKeyApprove
    {
        public Post31 post { get; set; }
    }

    public class Post31
    {
        public string[] tags { get; set; }
        public string operationId { get; set; }
        public Parameter81[] parameters { get; set; }
        public Requestbody36 requestBody { get; set; }
        public Responses88 responses { get; set; }
        public string[] xroles { get; set; }
    }

    public class Requestbody36
    {
        public string xname { get; set; }
        public Content124 content { get; set; }
        public bool required { get; set; }
    }

    public class Content124
    {
        public ApplicationJson123 applicationjson { get; set; }
    }

    public class ApplicationJson123
    {
        public Schema205 schema { get; set; }
    }

    public class Schema205
    {
        public string _ref { get; set; }
    }

    public class Responses88
    {
        public _20088 _200 { get; set; }
    }

    public class _20088
    {
        public string description { get; set; }
        public Content125 content { get; set; }
    }

    public class Content125
    {
        public ApplicationJson124 applicationjson { get; set; }
    }

    public class ApplicationJson124
    {
        public Schema206 schema { get; set; }
    }

    public class Schema206
    {
        public bool nullable { get; set; }
        public Oneof30[] oneOf { get; set; }
    }

    public class Oneof30
    {
        public string _ref { get; set; }
    }

    public class Parameter81
    {
        public string name { get; set; }
        public string _in { get; set; }
        public bool required { get; set; }
        public Schema207 schema { get; set; }
        public string description { get; set; }
    }

    public class Schema207
    {
        public string type { get; set; }
        public string format { get; set; }
        public bool nullable { get; set; }
    }

    public class ApiTransactionsKeyConfirm
    {
        public Post32 post { get; set; }
    }

    public class Post32
    {
        public string[] tags { get; set; }
        public string operationId { get; set; }
        public Parameter82[] parameters { get; set; }
        public Requestbody37 requestBody { get; set; }
        public Responses89 responses { get; set; }
        public string[] xroles { get; set; }
    }

    public class Requestbody37
    {
        public string xname { get; set; }
        public Content126 content { get; set; }
        public bool required { get; set; }
    }

    public class Content126
    {
        public ApplicationJson125 applicationjson { get; set; }
    }

    public class ApplicationJson125
    {
        public Schema208 schema { get; set; }
    }

    public class Schema208
    {
        public string _ref { get; set; }
    }

    public class Responses89
    {
        public _20089 _200 { get; set; }
    }

    public class _20089
    {
        public string description { get; set; }
        public Content127 content { get; set; }
    }

    public class Content127
    {
        public ApplicationJson126 applicationjson { get; set; }
    }

    public class ApplicationJson126
    {
        public Schema209 schema { get; set; }
    }

    public class Schema209
    {
        public bool nullable { get; set; }
        public Oneof31[] oneOf { get; set; }
    }

    public class Oneof31
    {
        public string _ref { get; set; }
    }

    public class Parameter82
    {
        public string name { get; set; }
        public string _in { get; set; }
        public bool required { get; set; }
        public Schema210 schema { get; set; }
        public string description { get; set; }
    }

    public class Schema210
    {
        public string type { get; set; }
        public string format { get; set; }
        public bool nullable { get; set; }
    }

    public class ApiTransactionsKeyRateproduct
    {
        public Post33 post { get; set; }
    }

    public class Post33
    {
        public string[] tags { get; set; }
        public string operationId { get; set; }
        public Parameter83[] parameters { get; set; }
        public Requestbody38 requestBody { get; set; }
        public Responses90 responses { get; set; }
        public string[] xroles { get; set; }
    }

    public class Requestbody38
    {
        public string xname { get; set; }
        public Content128 content { get; set; }
        public bool required { get; set; }
    }

    public class Content128
    {
        public ApplicationJson127 applicationjson { get; set; }
    }

    public class ApplicationJson127
    {
        public Schema211 schema { get; set; }
    }

    public class Schema211
    {
        public string _ref { get; set; }
    }

    public class Responses90
    {
        public _20090 _200 { get; set; }
    }

    public class _20090
    {
        public string description { get; set; }
        public Content129 content { get; set; }
    }

    public class Content129
    {
        public ApplicationJson128 applicationjson { get; set; }
    }

    public class ApplicationJson128
    {
        public Schema212 schema { get; set; }
    }

    public class Schema212
    {
        public bool nullable { get; set; }
        public Oneof32[] oneOf { get; set; }
    }

    public class Oneof32
    {
        public string _ref { get; set; }
    }

    public class Parameter83
    {
        public string name { get; set; }
        public string _in { get; set; }
        public bool required { get; set; }
        public Schema213 schema { get; set; }
        public string description { get; set; }
    }

    public class Schema213
    {
        public string type { get; set; }
        public string format { get; set; }
        public bool nullable { get; set; }
    }

    public class ApiTransactionsKeyConfirmafterapproval
    {
        public Post34 post { get; set; }
    }

    public class Post34
    {
        public string[] tags { get; set; }
        public string operationId { get; set; }
        public Parameter84[] parameters { get; set; }
        public Responses91 responses { get; set; }
        public string[] xroles { get; set; }
    }

    public class Responses91
    {
        public _20091 _200 { get; set; }
    }

    public class _20091
    {
        public string description { get; set; }
        public Content130 content { get; set; }
    }

    public class Content130
    {
        public ApplicationJson129 applicationjson { get; set; }
    }

    public class ApplicationJson129
    {
        public Schema214 schema { get; set; }
    }

    public class Schema214
    {
        public bool nullable { get; set; }
        public Oneof33[] oneOf { get; set; }
    }

    public class Oneof33
    {
        public string _ref { get; set; }
    }

    public class Parameter84
    {
        public string name { get; set; }
        public string _in { get; set; }
        public bool required { get; set; }
        public Schema215 schema { get; set; }
        public string description { get; set; }
    }

    public class Schema215
    {
        public string type { get; set; }
        public string format { get; set; }
        public bool nullable { get; set; }
    }

    public class ApiDiscountrules
    {
        public Get38 get { get; set; }
        public Post35 post { get; set; }
    }

    public class Get38
    {
        public string[] tags { get; set; }
        public string operationId { get; set; }
        public Parameter85[] parameters { get; set; }
        public Responses92 responses { get; set; }
        public string[] xroles { get; set; }
    }

    public class Responses92
    {
        public _20092 _200 { get; set; }
    }

    public class _20092
    {
        public string description { get; set; }
        public Content131 content { get; set; }
    }

    public class Content131
    {
        public ApplicationJson130 applicationjson { get; set; }
    }

    public class ApplicationJson130
    {
        public Schema216 schema { get; set; }
    }

    public class Schema216
    {
        public string type { get; set; }
        public bool nullable { get; set; }
        public Items25 items { get; set; }
    }

    public class Items25
    {
        public string _ref { get; set; }
    }

    public class Parameter85
    {
        public string name { get; set; }
        public string _in { get; set; }
        public string description { get; set; }
        public Schema217 schema { get; set; }
    }

    public class Schema217
    {
        public string type { get; set; }
        public bool nullable { get; set; }
        public string format { get; set; }
    }

    public class Post35
    {
        public string[] tags { get; set; }
        public string operationId { get; set; }
        public Requestbody39 requestBody { get; set; }
        public Responses93 responses { get; set; }
        public string[] xroles { get; set; }
    }

    public class Requestbody39
    {
        public string xname { get; set; }
        public Content132 content { get; set; }
        public bool required { get; set; }
    }

    public class Content132
    {
        public ApplicationJson131 applicationjson { get; set; }
    }

    public class ApplicationJson131
    {
        public Schema218 schema { get; set; }
    }

    public class Schema218
    {
        public string _ref { get; set; }
    }

    public class Responses93
    {
        public _20093 _200 { get; set; }
    }

    public class _20093
    {
        public string description { get; set; }
        public Content133 content { get; set; }
    }

    public class Content133
    {
        public ApplicationJson132 applicationjson { get; set; }
    }

    public class ApplicationJson132
    {
        public Schema219 schema { get; set; }
    }

    public class Schema219
    {
        public string type { get; set; }
    }

    public class ApiDiscountrulesKey
    {
        public Get39 get { get; set; }
        public Patch8 patch { get; set; }
        public Delete8 delete { get; set; }
    }

    public class Get39
    {
        public string[] tags { get; set; }
        public string operationId { get; set; }
        public Parameter86[] parameters { get; set; }
        public Responses94 responses { get; set; }
        public string[] xroles { get; set; }
    }

    public class Responses94
    {
        public _20094 _200 { get; set; }
    }

    public class _20094
    {
        public string description { get; set; }
        public Content134 content { get; set; }
    }

    public class Content134
    {
        public ApplicationJson133 applicationjson { get; set; }
    }

    public class ApplicationJson133
    {
        public Schema220 schema { get; set; }
    }

    public class Schema220
    {
        public bool nullable { get; set; }
        public Oneof34[] oneOf { get; set; }
    }

    public class Oneof34
    {
        public string _ref { get; set; }
    }

    public class Parameter86
    {
        public string name { get; set; }
        public string _in { get; set; }
        public bool required { get; set; }
        public Schema221 schema { get; set; }
        public string description { get; set; }
    }

    public class Schema221
    {
        public string type { get; set; }
        public string format { get; set; }
        public bool nullable { get; set; }
    }

    public class Patch8
    {
        public string[] tags { get; set; }
        public string operationId { get; set; }
        public Parameter87[] parameters { get; set; }
        public Requestbody40 requestBody { get; set; }
        public Responses95 responses { get; set; }
        public string[] xroles { get; set; }
    }

    public class Requestbody40
    {
        public string xname { get; set; }
        public Content135 content { get; set; }
        public bool required { get; set; }
    }

    public class Content135
    {
        public ApplicationJson134 applicationjson { get; set; }
    }

    public class ApplicationJson134
    {
        public Schema222 schema { get; set; }
    }

    public class Schema222
    {
        public string _ref { get; set; }
    }

    public class Responses95
    {
        public _20095 _200 { get; set; }
    }

    public class _20095
    {
        public string description { get; set; }
        public Content136 content { get; set; }
    }

    public class Content136
    {
        public ApplicationJson135 applicationjson { get; set; }
    }

    public class ApplicationJson135
    {
        public Schema223 schema { get; set; }
    }

    public class Schema223
    {
        public string type { get; set; }
    }

    public class Parameter87
    {
        public string name { get; set; }
        public string _in { get; set; }
        public bool required { get; set; }
        public Schema224 schema { get; set; }
    }

    public class Schema224
    {
        public string type { get; set; }
        public string format { get; set; }
    }

    public class Delete8
    {
        public string[] tags { get; set; }
        public string operationId { get; set; }
        public Parameter88[] parameters { get; set; }
        public Responses96 responses { get; set; }
        public string[] xroles { get; set; }
    }

    public class Responses96
    {
        public _20096 _200 { get; set; }
    }

    public class _20096
    {
        public string description { get; set; }
        public Content137 content { get; set; }
    }

    public class Content137
    {
        public ApplicationJson136 applicationjson { get; set; }
    }

    public class ApplicationJson136
    {
        public Schema225 schema { get; set; }
    }

    public class Schema225
    {
        public string type { get; set; }
    }

    public class Parameter88
    {
        public string name { get; set; }
        public string _in { get; set; }
        public bool required { get; set; }
        public Schema226 schema { get; set; }
    }

    public class Schema226
    {
        public string type { get; set; }
        public string format { get; set; }
    }

    public class ApiDiscountrulesKeyExcludedcosttypesRef
    {
        public Put3 put { get; set; }
        public Post36 post { get; set; }
    }

    public class Put3
    {
        public string[] tags { get; set; }
        public string operationId { get; set; }
        public Parameter89[] parameters { get; set; }
        public Requestbody41 requestBody { get; set; }
        public Responses97 responses { get; set; }
        public string[] xroles { get; set; }
    }

    public class Requestbody41
    {
        public string xname { get; set; }
        public Content138 content { get; set; }
        public bool required { get; set; }
    }

    public class Content138
    {
        public ApplicationJson137 applicationjson { get; set; }
    }

    public class ApplicationJson137
    {
        public Schema227 schema { get; set; }
    }

    public class Schema227
    {
        public string type { get; set; }
        public string format { get; set; }
    }

    public class Responses97
    {
        public _20097 _200 { get; set; }
    }

    public class _20097
    {
        public string description { get; set; }
        public Content139 content { get; set; }
    }

    public class Content139
    {
        public ApplicationJson138 applicationjson { get; set; }
    }

    public class ApplicationJson138
    {
        public Schema228 schema { get; set; }
    }

    public class Schema228
    {
        public string type { get; set; }
    }

    public class Parameter89
    {
        public string name { get; set; }
        public string _in { get; set; }
        public bool required { get; set; }
        public Schema229 schema { get; set; }
    }

    public class Schema229
    {
        public string type { get; set; }
        public string format { get; set; }
        public bool nullable { get; set; }
    }

    public class Post36
    {
        public string[] tags { get; set; }
        public string operationId { get; set; }
        public Parameter90[] parameters { get; set; }
        public Requestbody42 requestBody { get; set; }
        public Responses98 responses { get; set; }
        public string[] xroles { get; set; }
    }

    public class Requestbody42
    {
        public string xname { get; set; }
        public Content140 content { get; set; }
        public bool required { get; set; }
    }

    public class Content140
    {
        public ApplicationJson139 applicationjson { get; set; }
    }

    public class ApplicationJson139
    {
        public Schema230 schema { get; set; }
    }

    public class Schema230
    {
        public string type { get; set; }
        public string format { get; set; }
    }

    public class Responses98
    {
        public _20098 _200 { get; set; }
    }

    public class _20098
    {
        public string description { get; set; }
        public Content141 content { get; set; }
    }

    public class Content141
    {
        public ApplicationJson140 applicationjson { get; set; }
    }

    public class ApplicationJson140
    {
        public Schema231 schema { get; set; }
    }

    public class Schema231
    {
        public string type { get; set; }
    }

    public class Parameter90
    {
        public string name { get; set; }
        public string _in { get; set; }
        public bool required { get; set; }
        public Schema232 schema { get; set; }
    }

    public class Schema232
    {
        public string type { get; set; }
        public string format { get; set; }
        public bool nullable { get; set; }
    }

    public class ApiDiscountrulesBulkcopy
    {
        public Post37 post { get; set; }
    }

    public class Post37
    {
        public string[] tags { get; set; }
        public string operationId { get; set; }
        public Parameter91[] parameters { get; set; }
        public Requestbody43 requestBody { get; set; }
        public Responses99 responses { get; set; }
        public string[] xroles { get; set; }
    }

    public class Requestbody43
    {
        public string xname { get; set; }
        public Content142 content { get; set; }
        public bool required { get; set; }
    }

    public class Content142
    {
        public ApplicationJson141 applicationjson { get; set; }
    }

    public class ApplicationJson141
    {
        public Schema233 schema { get; set; }
    }

    public class Schema233
    {
        public string _ref { get; set; }
    }

    public class Responses99
    {
        public _20099 _200 { get; set; }
    }

    public class _20099
    {
        public string description { get; set; }
        public Content143 content { get; set; }
    }

    public class Content143
    {
        public ApplicationJson142 applicationjson { get; set; }
    }

    public class ApplicationJson142
    {
        public Schema234 schema { get; set; }
    }

    public class Schema234
    {
        public string type { get; set; }
        public string format { get; set; }
    }

    public class Parameter91
    {
        public string name { get; set; }
        public string _in { get; set; }
        public string description { get; set; }
        public Schema235 schema { get; set; }
    }

    public class Schema235
    {
        public string type { get; set; }
        public bool nullable { get; set; }
    }

    public class ApiDiscountrulesBulkdelete
    {
        public Post38 post { get; set; }
    }

    public class Post38
    {
        public string[] tags { get; set; }
        public string operationId { get; set; }
        public Parameter92[] parameters { get; set; }
        public Requestbody44 requestBody { get; set; }
        public Responses100 responses { get; set; }
        public string[] xroles { get; set; }
    }

    public class Requestbody44
    {
        public string xname { get; set; }
        public Content144 content { get; set; }
        public bool required { get; set; }
    }

    public class Content144
    {
        public ApplicationJson143 applicationjson { get; set; }
    }

    public class ApplicationJson143
    {
        public Schema236 schema { get; set; }
    }

    public class Schema236
    {
        public string _ref { get; set; }
    }

    public class Responses100
    {
        public _200100 _200 { get; set; }
    }

    public class _200100
    {
        public string description { get; set; }
        public Content145 content { get; set; }
    }

    public class Content145
    {
        public ApplicationJson144 applicationjson { get; set; }
    }

    public class ApplicationJson144
    {
        public Schema237 schema { get; set; }
    }

    public class Schema237
    {
        public string type { get; set; }
        public string format { get; set; }
    }

    public class Parameter92
    {
        public string name { get; set; }
        public string _in { get; set; }
        public string description { get; set; }
        public Schema238 schema { get; set; }
    }

    public class Schema238
    {
        public string type { get; set; }
        public bool nullable { get; set; }
    }

    public class ApiDiscountrulesKeyExcludedcosttypesRelatedkeyRef
    {
        public Delete9 delete { get; set; }
    }

    public class Delete9
    {
        public string[] tags { get; set; }
        public string operationId { get; set; }
        public Parameter93[] parameters { get; set; }
        public Responses101 responses { get; set; }
        public string[] xroles { get; set; }
    }

    public class Responses101
    {
        public _200101 _200 { get; set; }
    }

    public class _200101
    {
        public string description { get; set; }
        public Content146 content { get; set; }
    }

    public class Content146
    {
        public ApplicationJson145 applicationjson { get; set; }
    }

    public class ApplicationJson145
    {
        public Schema239 schema { get; set; }
    }

    public class Schema239
    {
        public string type { get; set; }
    }

    public class Parameter93
    {
        public string name { get; set; }
        public string _in { get; set; }
        public bool required { get; set; }
        public Schema240 schema { get; set; }
    }

    public class Schema240
    {
        public string type { get; set; }
        public string format { get; set; }
        public bool nullable { get; set; }
    }

    public class ApiNotifications
    {
        public Get40 get { get; set; }
    }

    public class Get40
    {
        public string[] tags { get; set; }
        public string operationId { get; set; }
        public Parameter94[] parameters { get; set; }
        public Responses102 responses { get; set; }
        public string[] xroles { get; set; }
    }

    public class Responses102
    {
        public _200102 _200 { get; set; }
    }

    public class _200102
    {
        public string description { get; set; }
        public Content147 content { get; set; }
    }

    public class Content147
    {
        public ApplicationJson146 applicationjson { get; set; }
    }

    public class ApplicationJson146
    {
        public Schema241 schema { get; set; }
    }

    public class Schema241
    {
        public string type { get; set; }
        public bool nullable { get; set; }
        public Items26 items { get; set; }
    }

    public class Items26
    {
        public string _ref { get; set; }
    }

    public class Parameter94
    {
        public string name { get; set; }
        public string _in { get; set; }
        public string description { get; set; }
        public Schema242 schema { get; set; }
    }

    public class Schema242
    {
        public string type { get; set; }
        public bool nullable { get; set; }
        public string format { get; set; }
    }

    public class ApiNotificationsKey
    {
        public Get41 get { get; set; }
    }

    public class Get41
    {
        public string[] tags { get; set; }
        public string operationId { get; set; }
        public Parameter95[] parameters { get; set; }
        public Responses103 responses { get; set; }
        public string[] xroles { get; set; }
    }

    public class Responses103
    {
        public _200103 _200 { get; set; }
    }

    public class _200103
    {
        public string description { get; set; }
        public Content148 content { get; set; }
    }

    public class Content148
    {
        public ApplicationJson147 applicationjson { get; set; }
    }

    public class ApplicationJson147
    {
        public Schema243 schema { get; set; }
    }

    public class Schema243
    {
        public bool nullable { get; set; }
        public Oneof35[] oneOf { get; set; }
    }

    public class Oneof35
    {
        public string _ref { get; set; }
    }

    public class Parameter95
    {
        public string name { get; set; }
        public string _in { get; set; }
        public bool required { get; set; }
        public Schema244 schema { get; set; }
        public string description { get; set; }
    }

    public class Schema244
    {
        public string type { get; set; }
        public string format { get; set; }
        public bool nullable { get; set; }
    }

    public class ApiOrgunitreport
    {
        public Get42 get { get; set; }
    }

    public class Get42
    {
        public string[] tags { get; set; }
        public string operationId { get; set; }
        public Parameter96[] parameters { get; set; }
        public Responses104 responses { get; set; }
        public string[] xroles { get; set; }
    }

    public class Responses104
    {
        public _200104 _200 { get; set; }
    }

    public class _200104
    {
        public string description { get; set; }
        public Content149 content { get; set; }
    }

    public class Content149
    {
        public ApplicationJson148 applicationjson { get; set; }
    }

    public class ApplicationJson148
    {
        public Schema245 schema { get; set; }
    }

    public class Schema245
    {
        public string type { get; set; }
        public bool nullable { get; set; }
        public Items27 items { get; set; }
    }

    public class Items27
    {
        public string _ref { get; set; }
    }

    public class Parameter96
    {
        public string name { get; set; }
        public string _in { get; set; }
        public string description { get; set; }
        public Schema246 schema { get; set; }
    }

    public class Schema246
    {
        public string type { get; set; }
        public bool nullable { get; set; }
        public string format { get; set; }
    }

    public class ApiInstanceinformation
    {
        public Get43 get { get; set; }
    }

    public class Get43
    {
        public string[] tags { get; set; }
        public string operationId { get; set; }
        public Parameter97[] parameters { get; set; }
        public Responses105 responses { get; set; }
        public string[] xroles { get; set; }
    }

    public class Responses105
    {
        public _200105 _200 { get; set; }
    }

    public class _200105
    {
        public string description { get; set; }
        public Content150 content { get; set; }
    }

    public class Content150
    {
        public ApplicationJson149 applicationjson { get; set; }
    }

    public class ApplicationJson149
    {
        public Schema247 schema { get; set; }
    }

    public class Schema247
    {
        public bool nullable { get; set; }
        public Oneof36[] oneOf { get; set; }
    }

    public class Oneof36
    {
        public string _ref { get; set; }
    }

    public class Parameter97
    {
        public string name { get; set; }
        public string _in { get; set; }
        public string description { get; set; }
        public Schema248 schema { get; set; }
    }

    public class Schema248
    {
        public string type { get; set; }
        public bool nullable { get; set; }
    }

    public class ApiProductgroups
    {
        public Get44 get { get; set; }
        public Post39 post { get; set; }
    }

    public class Get44
    {
        public string[] tags { get; set; }
        public string operationId { get; set; }
        public Parameter98[] parameters { get; set; }
        public Responses106 responses { get; set; }
        public string[] xroles { get; set; }
    }

    public class Responses106
    {
        public _200106 _200 { get; set; }
    }

    public class _200106
    {
        public string description { get; set; }
        public Content151 content { get; set; }
    }

    public class Content151
    {
        public ApplicationJson150 applicationjson { get; set; }
    }

    public class ApplicationJson150
    {
        public Schema249 schema { get; set; }
    }

    public class Schema249
    {
        public string type { get; set; }
        public bool nullable { get; set; }
        public Items28 items { get; set; }
    }

    public class Items28
    {
        public string _ref { get; set; }
    }

    public class Parameter98
    {
        public string name { get; set; }
        public string _in { get; set; }
        public string description { get; set; }
        public Schema250 schema { get; set; }
    }

    public class Schema250
    {
        public string type { get; set; }
        public bool nullable { get; set; }
        public string format { get; set; }
    }

    public class Post39
    {
        public string[] tags { get; set; }
        public string operationId { get; set; }
        public Requestbody45 requestBody { get; set; }
        public Responses107 responses { get; set; }
        public string[] xroles { get; set; }
    }

    public class Requestbody45
    {
        public string xname { get; set; }
        public Content152 content { get; set; }
        public bool required { get; set; }
    }

    public class Content152
    {
        public ApplicationJson151 applicationjson { get; set; }
    }

    public class ApplicationJson151
    {
        public Schema251 schema { get; set; }
    }

    public class Schema251
    {
        public string _ref { get; set; }
    }

    public class Responses107
    {
        public _200107 _200 { get; set; }
    }

    public class _200107
    {
        public string description { get; set; }
        public Content153 content { get; set; }
    }

    public class Content153
    {
        public ApplicationJson152 applicationjson { get; set; }
    }

    public class ApplicationJson152
    {
        public Schema252 schema { get; set; }
    }

    public class Schema252
    {
        public string type { get; set; }
    }

    public class ApiProductgroupsKey
    {
        public Get45 get { get; set; }
        public Patch9 patch { get; set; }
        public Delete10 delete { get; set; }
    }

    public class Get45
    {
        public string[] tags { get; set; }
        public string operationId { get; set; }
        public Parameter99[] parameters { get; set; }
        public Responses108 responses { get; set; }
        public string[] xroles { get; set; }
    }

    public class Responses108
    {
        public _200108 _200 { get; set; }
    }

    public class _200108
    {
        public string description { get; set; }
        public Content154 content { get; set; }
    }

    public class Content154
    {
        public ApplicationJson153 applicationjson { get; set; }
    }

    public class ApplicationJson153
    {
        public Schema253 schema { get; set; }
    }

    public class Schema253
    {
        public bool nullable { get; set; }
        public Oneof37[] oneOf { get; set; }
    }

    public class Oneof37
    {
        public string _ref { get; set; }
    }

    public class Parameter99
    {
        public string name { get; set; }
        public string _in { get; set; }
        public bool required { get; set; }
        public Schema254 schema { get; set; }
        public string description { get; set; }
    }

    public class Schema254
    {
        public string type { get; set; }
        public string format { get; set; }
        public bool nullable { get; set; }
    }

    public class Patch9
    {
        public string[] tags { get; set; }
        public string operationId { get; set; }
        public Parameter100[] parameters { get; set; }
        public Requestbody46 requestBody { get; set; }
        public Responses109 responses { get; set; }
        public string[] xroles { get; set; }
    }

    public class Requestbody46
    {
        public string xname { get; set; }
        public Content155 content { get; set; }
        public bool required { get; set; }
    }

    public class Content155
    {
        public ApplicationJson154 applicationjson { get; set; }
    }

    public class ApplicationJson154
    {
        public Schema255 schema { get; set; }
    }

    public class Schema255
    {
        public string _ref { get; set; }
    }

    public class Responses109
    {
        public _200109 _200 { get; set; }
    }

    public class _200109
    {
        public string description { get; set; }
        public Content156 content { get; set; }
    }

    public class Content156
    {
        public ApplicationJson155 applicationjson { get; set; }
    }

    public class ApplicationJson155
    {
        public Schema256 schema { get; set; }
    }

    public class Schema256
    {
        public string type { get; set; }
    }

    public class Parameter100
    {
        public string name { get; set; }
        public string _in { get; set; }
        public bool required { get; set; }
        public Schema257 schema { get; set; }
    }

    public class Schema257
    {
        public string type { get; set; }
        public string format { get; set; }
    }

    public class Delete10
    {
        public string[] tags { get; set; }
        public string operationId { get; set; }
        public Parameter101[] parameters { get; set; }
        public Responses110 responses { get; set; }
        public string[] xroles { get; set; }
    }

    public class Responses110
    {
        public _200110 _200 { get; set; }
    }

    public class _200110
    {
        public string description { get; set; }
        public Content157 content { get; set; }
    }

    public class Content157
    {
        public ApplicationJson156 applicationjson { get; set; }
    }

    public class ApplicationJson156
    {
        public Schema258 schema { get; set; }
    }

    public class Schema258
    {
        public string type { get; set; }
    }

    public class Parameter101
    {
        public string name { get; set; }
        public string _in { get; set; }
        public bool required { get; set; }
        public Schema259 schema { get; set; }
    }

    public class Schema259
    {
        public string type { get; set; }
        public string format { get; set; }
    }

    public class ApiProductgroupsKeyNavigationpropertyRef
    {
        public Put4 put { get; set; }
        public Post40 post { get; set; }
    }

    public class Put4
    {
        public string[] tags { get; set; }
        public string operationId { get; set; }
        public Parameter102[] parameters { get; set; }
        public Requestbody47 requestBody { get; set; }
        public Responses111 responses { get; set; }
        public string[] xroles { get; set; }
    }

    public class Requestbody47
    {
        public string xname { get; set; }
        public Content158 content { get; set; }
        public bool required { get; set; }
    }

    public class Content158
    {
        public ApplicationJson157 applicationjson { get; set; }
    }

    public class ApplicationJson157
    {
        public Schema260 schema { get; set; }
    }

    public class Schema260
    {
        public string type { get; set; }
        public string format { get; set; }
    }

    public class Responses111
    {
        public _200111 _200 { get; set; }
    }

    public class _200111
    {
        public string description { get; set; }
        public Content159 content { get; set; }
    }

    public class Content159
    {
        public ApplicationJson158 applicationjson { get; set; }
    }

    public class ApplicationJson158
    {
        public Schema261 schema { get; set; }
    }

    public class Schema261
    {
        public string type { get; set; }
    }

    public class Parameter102
    {
        public string name { get; set; }
        public string _in { get; set; }
        public bool required { get; set; }
        public Schema262 schema { get; set; }
    }

    public class Schema262
    {
        public string type { get; set; }
        public string format { get; set; }
        public bool nullable { get; set; }
    }

    public class Post40
    {
        public string[] tags { get; set; }
        public string operationId { get; set; }
        public Parameter103[] parameters { get; set; }
        public Requestbody48 requestBody { get; set; }
        public Responses112 responses { get; set; }
        public string[] xroles { get; set; }
    }

    public class Requestbody48
    {
        public string xname { get; set; }
        public Content160 content { get; set; }
        public bool required { get; set; }
    }

    public class Content160
    {
        public ApplicationJson159 applicationjson { get; set; }
    }

    public class ApplicationJson159
    {
        public Schema263 schema { get; set; }
    }

    public class Schema263
    {
        public string type { get; set; }
        public string format { get; set; }
    }

    public class Responses112
    {
        public _200112 _200 { get; set; }
    }

    public class _200112
    {
        public string description { get; set; }
        public Content161 content { get; set; }
    }

    public class Content161
    {
        public ApplicationJson160 applicationjson { get; set; }
    }

    public class ApplicationJson160
    {
        public Schema264 schema { get; set; }
    }

    public class Schema264
    {
        public string type { get; set; }
    }

    public class Parameter103
    {
        public string name { get; set; }
        public string _in { get; set; }
        public bool required { get; set; }
        public Schema265 schema { get; set; }
    }

    public class Schema265
    {
        public string type { get; set; }
        public string format { get; set; }
        public bool nullable { get; set; }
    }

    public class ApiProductgroupsKeyNavigationpropertyRelatedkeyRef
    {
        public Delete11 delete { get; set; }
    }

    public class Delete11
    {
        public string[] tags { get; set; }
        public string operationId { get; set; }
        public Parameter104[] parameters { get; set; }
        public Responses113 responses { get; set; }
        public string[] xroles { get; set; }
    }

    public class Responses113
    {
        public _200113 _200 { get; set; }
    }

    public class _200113
    {
        public string description { get; set; }
        public Content162 content { get; set; }
    }

    public class Content162
    {
        public ApplicationJson161 applicationjson { get; set; }
    }

    public class ApplicationJson161
    {
        public Schema266 schema { get; set; }
    }

    public class Schema266
    {
        public string type { get; set; }
    }

    public class Parameter104
    {
        public string name { get; set; }
        public string _in { get; set; }
        public bool required { get; set; }
        public Schema267 schema { get; set; }
    }

    public class Schema267
    {
        public string type { get; set; }
        public string format { get; set; }
        public bool nullable { get; set; }
    }

    public class ApiOrgunitbudgets
    {
        public Get46 get { get; set; }
        public Post41 post { get; set; }
    }

    public class Get46
    {
        public string[] tags { get; set; }
        public string operationId { get; set; }
        public Parameter105[] parameters { get; set; }
        public Responses114 responses { get; set; }
        public string[] xroles { get; set; }
    }

    public class Responses114
    {
        public _200114 _200 { get; set; }
    }

    public class _200114
    {
        public string description { get; set; }
        public Content163 content { get; set; }
    }

    public class Content163
    {
        public ApplicationJson162 applicationjson { get; set; }
    }

    public class ApplicationJson162
    {
        public Schema268 schema { get; set; }
    }

    public class Schema268
    {
        public string type { get; set; }
        public bool nullable { get; set; }
        public Items29 items { get; set; }
    }

    public class Items29
    {
        public string _ref { get; set; }
    }

    public class Parameter105
    {
        public string name { get; set; }
        public string _in { get; set; }
        public string description { get; set; }
        public Schema269 schema { get; set; }
    }

    public class Schema269
    {
        public string type { get; set; }
        public bool nullable { get; set; }
        public string format { get; set; }
    }

    public class Post41
    {
        public string[] tags { get; set; }
        public string operationId { get; set; }
        public Requestbody49 requestBody { get; set; }
        public Responses115 responses { get; set; }
        public string[] xroles { get; set; }
    }

    public class Requestbody49
    {
        public string xname { get; set; }
        public Content164 content { get; set; }
        public bool required { get; set; }
    }

    public class Content164
    {
        public ApplicationJson163 applicationjson { get; set; }
    }

    public class ApplicationJson163
    {
        public Schema270 schema { get; set; }
    }

    public class Schema270
    {
        public string _ref { get; set; }
    }

    public class Responses115
    {
        public _200115 _200 { get; set; }
    }

    public class _200115
    {
        public string description { get; set; }
        public Content165 content { get; set; }
    }

    public class Content165
    {
        public ApplicationJson164 applicationjson { get; set; }
    }

    public class ApplicationJson164
    {
        public Schema271 schema { get; set; }
    }

    public class Schema271
    {
        public string type { get; set; }
    }

    public class ApiOrgunitbudgetsKey
    {
        public Get47 get { get; set; }
        public Patch10 patch { get; set; }
        public Delete12 delete { get; set; }
    }

    public class Get47
    {
        public string[] tags { get; set; }
        public string operationId { get; set; }
        public Parameter106[] parameters { get; set; }
        public Responses116 responses { get; set; }
        public string[] xroles { get; set; }
    }

    public class Responses116
    {
        public _200116 _200 { get; set; }
    }

    public class _200116
    {
        public string description { get; set; }
        public Content166 content { get; set; }
    }

    public class Content166
    {
        public ApplicationJson165 applicationjson { get; set; }
    }

    public class ApplicationJson165
    {
        public Schema272 schema { get; set; }
    }

    public class Schema272
    {
        public bool nullable { get; set; }
        public Oneof38[] oneOf { get; set; }
    }

    public class Oneof38
    {
        public string _ref { get; set; }
    }

    public class Parameter106
    {
        public string name { get; set; }
        public string _in { get; set; }
        public bool required { get; set; }
        public Schema273 schema { get; set; }
        public string description { get; set; }
    }

    public class Schema273
    {
        public string type { get; set; }
        public string format { get; set; }
        public bool nullable { get; set; }
    }

    public class Patch10
    {
        public string[] tags { get; set; }
        public string operationId { get; set; }
        public Parameter107[] parameters { get; set; }
        public Requestbody50 requestBody { get; set; }
        public Responses117 responses { get; set; }
        public string[] xroles { get; set; }
    }

    public class Requestbody50
    {
        public string xname { get; set; }
        public Content167 content { get; set; }
        public bool required { get; set; }
    }

    public class Content167
    {
        public ApplicationJson166 applicationjson { get; set; }
    }

    public class ApplicationJson166
    {
        public Schema274 schema { get; set; }
    }

    public class Schema274
    {
        public string _ref { get; set; }
    }

    public class Responses117
    {
        public _200117 _200 { get; set; }
    }

    public class _200117
    {
        public string description { get; set; }
        public Content168 content { get; set; }
    }

    public class Content168
    {
        public ApplicationJson167 applicationjson { get; set; }
    }

    public class ApplicationJson167
    {
        public Schema275 schema { get; set; }
    }

    public class Schema275
    {
        public string type { get; set; }
    }

    public class Parameter107
    {
        public string name { get; set; }
        public string _in { get; set; }
        public bool required { get; set; }
        public Schema276 schema { get; set; }
    }

    public class Schema276
    {
        public string type { get; set; }
        public string format { get; set; }
    }

    public class Delete12
    {
        public string[] tags { get; set; }
        public string operationId { get; set; }
        public Parameter108[] parameters { get; set; }
        public Responses118 responses { get; set; }
        public string[] xroles { get; set; }
    }

    public class Responses118
    {
        public _200118 _200 { get; set; }
    }

    public class _200118
    {
        public string description { get; set; }
        public Content169 content { get; set; }
    }

    public class Content169
    {
        public ApplicationJson168 applicationjson { get; set; }
    }

    public class ApplicationJson168
    {
        public Schema277 schema { get; set; }
    }

    public class Schema277
    {
        public string type { get; set; }
    }

    public class Parameter108
    {
        public string name { get; set; }
        public string _in { get; set; }
        public bool required { get; set; }
        public Schema278 schema { get; set; }
    }

    public class Schema278
    {
        public string type { get; set; }
        public string format { get; set; }
    }

    public class ApiOrgunitbudgetsKeyAdjustments
    {
        public Get48 get { get; set; }
    }

    public class Get48
    {
        public string[] tags { get; set; }
        public string operationId { get; set; }
        public Parameter109[] parameters { get; set; }
        public Responses119 responses { get; set; }
        public string[] xroles { get; set; }
    }

    public class Responses119
    {
        public _200119 _200 { get; set; }
    }

    public class _200119
    {
        public string description { get; set; }
        public Content170 content { get; set; }
    }

    public class Content170
    {
        public ApplicationJson169 applicationjson { get; set; }
    }

    public class ApplicationJson169
    {
        public Schema279 schema { get; set; }
    }

    public class Schema279
    {
        public string type { get; set; }
        public bool nullable { get; set; }
        public Items30 items { get; set; }
    }

    public class Items30
    {
        public string _ref { get; set; }
    }

    public class Parameter109
    {
        public string name { get; set; }
        public string _in { get; set; }
        public bool required { get; set; }
        public Schema280 schema { get; set; }
        public string description { get; set; }
    }

    public class Schema280
    {
        public string type { get; set; }
        public string format { get; set; }
        public bool nullable { get; set; }
    }

    public class ApiOrgunitbudgetsKeyAdjustbudget
    {
        public Post42 post { get; set; }
    }

    public class Post42
    {
        public string[] tags { get; set; }
        public string operationId { get; set; }
        public Parameter110[] parameters { get; set; }
        public Requestbody51 requestBody { get; set; }
        public Responses120 responses { get; set; }
        public string[] xroles { get; set; }
    }

    public class Requestbody51
    {
        public string xname { get; set; }
        public Content171 content { get; set; }
        public bool required { get; set; }
    }

    public class Content171
    {
        public ApplicationJson170 applicationjson { get; set; }
    }

    public class ApplicationJson170
    {
        public Schema281 schema { get; set; }
    }

    public class Schema281
    {
        public string _ref { get; set; }
    }

    public class Responses120
    {
        public _200120 _200 { get; set; }
    }

    public class _200120
    {
        public string description { get; set; }
        public Content172 content { get; set; }
    }

    public class Content172
    {
        public ApplicationJson171 applicationjson { get; set; }
    }

    public class ApplicationJson171
    {
        public Schema282 schema { get; set; }
    }

    public class Schema282
    {
        public bool nullable { get; set; }
        public Oneof39[] oneOf { get; set; }
    }

    public class Oneof39
    {
        public string _ref { get; set; }
    }

    public class Parameter110
    {
        public string name { get; set; }
        public string _in { get; set; }
        public bool required { get; set; }
        public Schema283 schema { get; set; }
        public string description { get; set; }
    }

    public class Schema283
    {
        public string type { get; set; }
        public string format { get; set; }
        public bool nullable { get; set; }
    }

    public class ApiOrgunitsKeyPrioritizeorgunitbudgets
    {
        public Post43 post { get; set; }
    }

    public class Post43
    {
        public string[] tags { get; set; }
        public string operationId { get; set; }
        public Parameter111[] parameters { get; set; }
        public Requestbody52 requestBody { get; set; }
        public Responses121 responses { get; set; }
        public string[] xroles { get; set; }
    }

    public class Requestbody52
    {
        public string xname { get; set; }
        public Content173 content { get; set; }
        public bool required { get; set; }
    }

    public class Content173
    {
        public ApplicationJson172 applicationjson { get; set; }
    }

    public class ApplicationJson172
    {
        public Schema284 schema { get; set; }
    }

    public class Schema284
    {
        public string _ref { get; set; }
    }

    public class Responses121
    {
        public _200121 _200 { get; set; }
    }

    public class _200121
    {
        public string description { get; set; }
        public Content174 content { get; set; }
    }

    public class Content174
    {
        public ApplicationJson173 applicationjson { get; set; }
    }

    public class ApplicationJson173
    {
        public Schema285 schema { get; set; }
    }

    public class Schema285
    {
        public string type { get; set; }
        public bool nullable { get; set; }
        public Items31 items { get; set; }
    }

    public class Items31
    {
        public string _ref { get; set; }
    }

    public class Parameter111
    {
        public string name { get; set; }
        public string _in { get; set; }
        public bool required { get; set; }
        public Schema286 schema { get; set; }
        public string description { get; set; }
    }

    public class Schema286
    {
        public string type { get; set; }
        public string format { get; set; }
        public bool nullable { get; set; }
    }

    public class ApiEmployeebudgets
    {
        public Get49 get { get; set; }
        public Post44 post { get; set; }
    }

    public class Get49
    {
        public string[] tags { get; set; }
        public string operationId { get; set; }
        public Parameter112[] parameters { get; set; }
        public Responses122 responses { get; set; }
        public string[] xroles { get; set; }
    }

    public class Responses122
    {
        public _200122 _200 { get; set; }
    }

    public class _200122
    {
        public string description { get; set; }
        public Content175 content { get; set; }
    }

    public class Content175
    {
        public ApplicationJson174 applicationjson { get; set; }
    }

    public class ApplicationJson174
    {
        public Schema287 schema { get; set; }
    }

    public class Schema287
    {
        public string type { get; set; }
        public bool nullable { get; set; }
        public Items32 items { get; set; }
    }

    public class Items32
    {
        public string _ref { get; set; }
    }

    public class Parameter112
    {
        public string name { get; set; }
        public string _in { get; set; }
        public string description { get; set; }
        public Schema288 schema { get; set; }
    }

    public class Schema288
    {
        public string type { get; set; }
        public bool nullable { get; set; }
        public string format { get; set; }
    }

    public class Post44
    {
        public string[] tags { get; set; }
        public string operationId { get; set; }
        public Requestbody53 requestBody { get; set; }
        public Responses123 responses { get; set; }
        public string[] xroles { get; set; }
    }

    public class Requestbody53
    {
        public string xname { get; set; }
        public Content176 content { get; set; }
        public bool required { get; set; }
    }

    public class Content176
    {
        public ApplicationJson175 applicationjson { get; set; }
    }

    public class ApplicationJson175
    {
        public Schema289 schema { get; set; }
    }

    public class Schema289
    {
        public string _ref { get; set; }
    }

    public class Responses123
    {
        public _200123 _200 { get; set; }
    }

    public class _200123
    {
        public string description { get; set; }
        public Content177 content { get; set; }
    }

    public class Content177
    {
        public ApplicationJson176 applicationjson { get; set; }
    }

    public class ApplicationJson176
    {
        public Schema290 schema { get; set; }
    }

    public class Schema290
    {
        public string type { get; set; }
    }

    public class ApiEmployeebudgetsKey
    {
        public Get50 get { get; set; }
        public Patch11 patch { get; set; }
        public Delete13 delete { get; set; }
    }

    public class Get50
    {
        public string[] tags { get; set; }
        public string operationId { get; set; }
        public Parameter113[] parameters { get; set; }
        public Responses124 responses { get; set; }
        public string[] xroles { get; set; }
    }

    public class Responses124
    {
        public _200124 _200 { get; set; }
    }

    public class _200124
    {
        public string description { get; set; }
        public Content178 content { get; set; }
    }

    public class Content178
    {
        public ApplicationJson177 applicationjson { get; set; }
    }

    public class ApplicationJson177
    {
        public Schema291 schema { get; set; }
    }

    public class Schema291
    {
        public bool nullable { get; set; }
        public Oneof40[] oneOf { get; set; }
    }

    public class Oneof40
    {
        public string _ref { get; set; }
    }

    public class Parameter113
    {
        public string name { get; set; }
        public string _in { get; set; }
        public bool required { get; set; }
        public Schema292 schema { get; set; }
        public string description { get; set; }
    }

    public class Schema292
    {
        public string type { get; set; }
        public string format { get; set; }
        public bool nullable { get; set; }
    }

    public class Patch11
    {
        public string[] tags { get; set; }
        public string operationId { get; set; }
        public Parameter114[] parameters { get; set; }
        public Requestbody54 requestBody { get; set; }
        public Responses125 responses { get; set; }
        public string[] xroles { get; set; }
    }

    public class Requestbody54
    {
        public string xname { get; set; }
        public Content179 content { get; set; }
        public bool required { get; set; }
    }

    public class Content179
    {
        public ApplicationJson178 applicationjson { get; set; }
    }

    public class ApplicationJson178
    {
        public Schema293 schema { get; set; }
    }

    public class Schema293
    {
        public string _ref { get; set; }
    }

    public class Responses125
    {
        public _200125 _200 { get; set; }
    }

    public class _200125
    {
        public string description { get; set; }
        public Content180 content { get; set; }
    }

    public class Content180
    {
        public ApplicationJson179 applicationjson { get; set; }
    }

    public class ApplicationJson179
    {
        public Schema294 schema { get; set; }
    }

    public class Schema294
    {
        public string type { get; set; }
    }

    public class Parameter114
    {
        public string name { get; set; }
        public string _in { get; set; }
        public bool required { get; set; }
        public Schema295 schema { get; set; }
    }

    public class Schema295
    {
        public string type { get; set; }
        public string format { get; set; }
    }

    public class Delete13
    {
        public string[] tags { get; set; }
        public string operationId { get; set; }
        public Parameter115[] parameters { get; set; }
        public Responses126 responses { get; set; }
        public string[] xroles { get; set; }
    }

    public class Responses126
    {
        public _200126 _200 { get; set; }
    }

    public class _200126
    {
        public string description { get; set; }
        public Content181 content { get; set; }
    }

    public class Content181
    {
        public ApplicationJson180 applicationjson { get; set; }
    }

    public class ApplicationJson180
    {
        public Schema296 schema { get; set; }
    }

    public class Schema296
    {
        public string type { get; set; }
    }

    public class Parameter115
    {
        public string name { get; set; }
        public string _in { get; set; }
        public bool required { get; set; }
        public Schema297 schema { get; set; }
    }

    public class Schema297
    {
        public string type { get; set; }
        public string format { get; set; }
    }

    public class ApiEmployeebudgetsIdAdjustments
    {
        public Get51 get { get; set; }
    }

    public class Get51
    {
        public string[] tags { get; set; }
        public string operationId { get; set; }
        public Parameter116[] parameters { get; set; }
        public Responses127 responses { get; set; }
        public string[] xroles { get; set; }
    }

    public class Responses127
    {
        public _200127 _200 { get; set; }
    }

    public class _200127
    {
        public string description { get; set; }
        public Content182 content { get; set; }
    }

    public class Content182
    {
        public ApplicationJson181 applicationjson { get; set; }
    }

    public class ApplicationJson181
    {
        public Schema298 schema { get; set; }
    }

    public class Schema298
    {
        public string type { get; set; }
        public bool nullable { get; set; }
        public Items33 items { get; set; }
    }

    public class Items33
    {
        public string _ref { get; set; }
    }

    public class Parameter116
    {
        public string name { get; set; }
        public string _in { get; set; }
        public bool required { get; set; }
        public Schema299 schema { get; set; }
        public string description { get; set; }
    }

    public class Schema299
    {
        public string type { get; set; }
        public string format { get; set; }
        public bool nullable { get; set; }
    }

    public class ApiEmployeebudgetsKeyCurrentbalance
    {
        public Get52 get { get; set; }
    }

    public class Get52
    {
        public string[] tags { get; set; }
        public string operationId { get; set; }
        public Parameter117[] parameters { get; set; }
        public Responses128 responses { get; set; }
        public string[] xroles { get; set; }
    }

    public class Responses128
    {
        public _200128 _200 { get; set; }
    }

    public class _200128
    {
        public string description { get; set; }
        public Content183 content { get; set; }
    }

    public class Content183
    {
        public ApplicationJson182 applicationjson { get; set; }
    }

    public class ApplicationJson182
    {
        public Schema300 schema { get; set; }
    }

    public class Schema300
    {
        public bool nullable { get; set; }
        public Oneof41[] oneOf { get; set; }
    }

    public class Oneof41
    {
        public string _ref { get; set; }
    }

    public class Parameter117
    {
        public string name { get; set; }
        public string _in { get; set; }
        public bool required { get; set; }
        public Schema301 schema { get; set; }
        public string description { get; set; }
    }

    public class Schema301
    {
        public string type { get; set; }
        public string format { get; set; }
        public bool nullable { get; set; }
    }

    public class ApiEmployeebudgetsAdjustbudgets
    {
        public Post45 post { get; set; }
    }

    public class Post45
    {
        public string[] tags { get; set; }
        public string operationId { get; set; }
        public Parameter118[] parameters { get; set; }
        public Requestbody55 requestBody { get; set; }
        public Responses129 responses { get; set; }
        public string[] xroles { get; set; }
    }

    public class Requestbody55
    {
        public string xname { get; set; }
        public Content184 content { get; set; }
        public bool required { get; set; }
    }

    public class Content184
    {
        public ApplicationJson183 applicationjson { get; set; }
    }

    public class ApplicationJson183
    {
        public Schema302 schema { get; set; }
    }

    public class Schema302
    {
        public string _ref { get; set; }
    }

    public class Responses129
    {
        public _200129 _200 { get; set; }
    }

    public class _200129
    {
        public string description { get; set; }
        public Content185 content { get; set; }
    }

    public class Content185
    {
        public ApplicationJson184 applicationjson { get; set; }
    }

    public class ApplicationJson184
    {
        public Schema303 schema { get; set; }
    }

    public class Schema303
    {
        public string type { get; set; }
        public string format { get; set; }
    }

    public class Parameter118
    {
        public string name { get; set; }
        public string _in { get; set; }
        public string description { get; set; }
        public Schema304 schema { get; set; }
    }

    public class Schema304
    {
        public string type { get; set; }
        public bool nullable { get; set; }
    }

    public class ApiEmployeebudgetsKeyAdjustbudget
    {
        public Post46 post { get; set; }
    }

    public class Post46
    {
        public string[] tags { get; set; }
        public string operationId { get; set; }
        public Parameter119[] parameters { get; set; }
        public Requestbody56 requestBody { get; set; }
        public Responses130 responses { get; set; }
        public string[] xroles { get; set; }
    }

    public class Requestbody56
    {
        public string xname { get; set; }
        public Content186 content { get; set; }
        public bool required { get; set; }
    }

    public class Content186
    {
        public ApplicationJson185 applicationjson { get; set; }
    }

    public class ApplicationJson185
    {
        public Schema305 schema { get; set; }
    }

    public class Schema305
    {
        public string _ref { get; set; }
    }

    public class Responses130
    {
        public _200130 _200 { get; set; }
    }

    public class _200130
    {
        public string description { get; set; }
        public Content187 content { get; set; }
    }

    public class Content187
    {
        public ApplicationJson186 applicationjson { get; set; }
    }

    public class ApplicationJson186
    {
        public Schema306 schema { get; set; }
    }

    public class Schema306
    {
        public bool nullable { get; set; }
        public Oneof42[] oneOf { get; set; }
    }

    public class Oneof42
    {
        public string _ref { get; set; }
    }

    public class Parameter119
    {
        public string name { get; set; }
        public string _in { get; set; }
        public bool required { get; set; }
        public Schema307 schema { get; set; }
        public string description { get; set; }
    }

    public class Schema307
    {
        public string type { get; set; }
        public string format { get; set; }
        public bool nullable { get; set; }
    }

    public class ApiEmployeeimports
    {
        public Get53 get { get; set; }
    }

    public class Get53
    {
        public string[] tags { get; set; }
        public string operationId { get; set; }
        public Parameter120[] parameters { get; set; }
        public Responses131 responses { get; set; }
        public string[] xroles { get; set; }
    }

    public class Responses131
    {
        public _200131 _200 { get; set; }
    }

    public class _200131
    {
        public string description { get; set; }
        public Content188 content { get; set; }
    }

    public class Content188
    {
        public ApplicationJson187 applicationjson { get; set; }
    }

    public class ApplicationJson187
    {
        public Schema308 schema { get; set; }
    }

    public class Schema308
    {
        public string type { get; set; }
        public bool nullable { get; set; }
        public Items34 items { get; set; }
    }

    public class Items34
    {
        public string _ref { get; set; }
    }

    public class Parameter120
    {
        public string name { get; set; }
        public string _in { get; set; }
        public string description { get; set; }
        public Schema309 schema { get; set; }
    }

    public class Schema309
    {
        public string type { get; set; }
        public bool nullable { get; set; }
        public string format { get; set; }
    }

    public class ApiEmployeeimportsKey
    {
        public Get54 get { get; set; }
    }

    public class Get54
    {
        public string[] tags { get; set; }
        public string operationId { get; set; }
        public Parameter121[] parameters { get; set; }
        public Responses132 responses { get; set; }
        public string[] xroles { get; set; }
    }

    public class Responses132
    {
        public _200132 _200 { get; set; }
    }

    public class _200132
    {
        public string description { get; set; }
        public Content189 content { get; set; }
    }

    public class Content189
    {
        public ApplicationJson188 applicationjson { get; set; }
    }

    public class ApplicationJson188
    {
        public Schema310 schema { get; set; }
    }

    public class Schema310
    {
        public bool nullable { get; set; }
        public Oneof43[] oneOf { get; set; }
    }

    public class Oneof43
    {
        public string _ref { get; set; }
    }

    public class Parameter121
    {
        public string name { get; set; }
        public string _in { get; set; }
        public bool required { get; set; }
        public Schema311 schema { get; set; }
        public string description { get; set; }
    }

    public class Schema311
    {
        public string type { get; set; }
        public string format { get; set; }
        public bool nullable { get; set; }
    }

    public class ApiOrgunitchannels
    {
        public Get55 get { get; set; }
        public Post47 post { get; set; }
    }

    public class Get55
    {
        public string[] tags { get; set; }
        public string operationId { get; set; }
        public Parameter122[] parameters { get; set; }
        public Responses133 responses { get; set; }
        public string[] xroles { get; set; }
    }

    public class Responses133
    {
        public _200133 _200 { get; set; }
    }

    public class _200133
    {
        public string description { get; set; }
        public Content190 content { get; set; }
    }

    public class Content190
    {
        public ApplicationJson189 applicationjson { get; set; }
    }

    public class ApplicationJson189
    {
        public Schema312 schema { get; set; }
    }

    public class Schema312
    {
        public string type { get; set; }
        public bool nullable { get; set; }
        public Items35 items { get; set; }
    }

    public class Items35
    {
        public string _ref { get; set; }
    }

    public class Parameter122
    {
        public string name { get; set; }
        public string _in { get; set; }
        public string description { get; set; }
        public Schema313 schema { get; set; }
    }

    public class Schema313
    {
        public string type { get; set; }
        public bool nullable { get; set; }
        public string format { get; set; }
    }

    public class Post47
    {
        public string[] tags { get; set; }
        public string operationId { get; set; }
        public Requestbody57 requestBody { get; set; }
        public Responses134 responses { get; set; }
        public string[] xroles { get; set; }
    }

    public class Requestbody57
    {
        public string xname { get; set; }
        public Content191 content { get; set; }
        public bool required { get; set; }
    }

    public class Content191
    {
        public ApplicationJson190 applicationjson { get; set; }
    }

    public class ApplicationJson190
    {
        public Schema314 schema { get; set; }
    }

    public class Schema314
    {
        public string _ref { get; set; }
    }

    public class Responses134
    {
        public _200134 _200 { get; set; }
    }

    public class _200134
    {
        public string description { get; set; }
        public Content192 content { get; set; }
    }

    public class Content192
    {
        public ApplicationJson191 applicationjson { get; set; }
    }

    public class ApplicationJson191
    {
        public Schema315 schema { get; set; }
    }

    public class Schema315
    {
        public string type { get; set; }
    }

    public class ApiOrgunitchannelsKey
    {
        public Get56 get { get; set; }
        public Patch12 patch { get; set; }
        public Delete14 delete { get; set; }
    }

    public class Get56
    {
        public string[] tags { get; set; }
        public string operationId { get; set; }
        public Parameter123[] parameters { get; set; }
        public Responses135 responses { get; set; }
        public string[] xroles { get; set; }
    }

    public class Responses135
    {
        public _200135 _200 { get; set; }
    }

    public class _200135
    {
        public string description { get; set; }
        public Content193 content { get; set; }
    }

    public class Content193
    {
        public ApplicationJson192 applicationjson { get; set; }
    }

    public class ApplicationJson192
    {
        public Schema316 schema { get; set; }
    }

    public class Schema316
    {
        public bool nullable { get; set; }
        public Oneof44[] oneOf { get; set; }
    }

    public class Oneof44
    {
        public string _ref { get; set; }
    }

    public class Parameter123
    {
        public string name { get; set; }
        public string _in { get; set; }
        public bool required { get; set; }
        public Schema317 schema { get; set; }
        public string description { get; set; }
    }

    public class Schema317
    {
        public string type { get; set; }
        public string format { get; set; }
        public bool nullable { get; set; }
    }

    public class Patch12
    {
        public string[] tags { get; set; }
        public string operationId { get; set; }
        public Parameter124[] parameters { get; set; }
        public Requestbody58 requestBody { get; set; }
        public Responses136 responses { get; set; }
        public string[] xroles { get; set; }
    }

    public class Requestbody58
    {
        public string xname { get; set; }
        public Content194 content { get; set; }
        public bool required { get; set; }
    }

    public class Content194
    {
        public ApplicationJson193 applicationjson { get; set; }
    }

    public class ApplicationJson193
    {
        public Schema318 schema { get; set; }
    }

    public class Schema318
    {
        public string _ref { get; set; }
    }

    public class Responses136
    {
        public _200136 _200 { get; set; }
    }

    public class _200136
    {
        public string description { get; set; }
        public Content195 content { get; set; }
    }

    public class Content195
    {
        public ApplicationJson194 applicationjson { get; set; }
    }

    public class ApplicationJson194
    {
        public Schema319 schema { get; set; }
    }

    public class Schema319
    {
        public string type { get; set; }
    }

    public class Parameter124
    {
        public string name { get; set; }
        public string _in { get; set; }
        public bool required { get; set; }
        public Schema320 schema { get; set; }
    }

    public class Schema320
    {
        public string type { get; set; }
        public string format { get; set; }
    }

    public class Delete14
    {
        public string[] tags { get; set; }
        public string operationId { get; set; }
        public Parameter125[] parameters { get; set; }
        public Responses137 responses { get; set; }
        public string[] xroles { get; set; }
    }

    public class Responses137
    {
        public _200137 _200 { get; set; }
    }

    public class _200137
    {
        public string description { get; set; }
        public Content196 content { get; set; }
    }

    public class Content196
    {
        public ApplicationJson195 applicationjson { get; set; }
    }

    public class ApplicationJson195
    {
        public Schema321 schema { get; set; }
    }

    public class Schema321
    {
        public string type { get; set; }
    }

    public class Parameter125
    {
        public string name { get; set; }
        public string _in { get; set; }
        public bool required { get; set; }
        public Schema322 schema { get; set; }
    }

    public class Schema322
    {
        public string type { get; set; }
        public string format { get; set; }
    }

    public class ApiOrgunitcryptors
    {
        public Get57 get { get; set; }
        public Post48 post { get; set; }
    }

    public class Get57
    {
        public string[] tags { get; set; }
        public string operationId { get; set; }
        public Parameter126[] parameters { get; set; }
        public Responses138 responses { get; set; }
        public string[] xroles { get; set; }
    }

    public class Responses138
    {
        public _200138 _200 { get; set; }
    }

    public class _200138
    {
        public string description { get; set; }
        public Content197 content { get; set; }
    }

    public class Content197
    {
        public ApplicationJson196 applicationjson { get; set; }
    }

    public class ApplicationJson196
    {
        public Schema323 schema { get; set; }
    }

    public class Schema323
    {
        public string type { get; set; }
        public bool nullable { get; set; }
        public Items36 items { get; set; }
    }

    public class Items36
    {
        public string _ref { get; set; }
    }

    public class Parameter126
    {
        public string name { get; set; }
        public string _in { get; set; }
        public string description { get; set; }
        public Schema324 schema { get; set; }
    }

    public class Schema324
    {
        public string type { get; set; }
        public bool nullable { get; set; }
        public string format { get; set; }
    }

    public class Post48
    {
        public string[] tags { get; set; }
        public string operationId { get; set; }
        public Requestbody59 requestBody { get; set; }
        public Responses139 responses { get; set; }
        public string[] xroles { get; set; }
    }

    public class Requestbody59
    {
        public string xname { get; set; }
        public Content198 content { get; set; }
        public bool required { get; set; }
    }

    public class Content198
    {
        public ApplicationJson197 applicationjson { get; set; }
    }

    public class ApplicationJson197
    {
        public Schema325 schema { get; set; }
    }

    public class Schema325
    {
        public string _ref { get; set; }
    }

    public class Responses139
    {
        public _200139 _200 { get; set; }
    }

    public class _200139
    {
        public string description { get; set; }
        public Content199 content { get; set; }
    }

    public class Content199
    {
        public ApplicationJson198 applicationjson { get; set; }
    }

    public class ApplicationJson198
    {
        public Schema326 schema { get; set; }
    }

    public class Schema326
    {
        public string type { get; set; }
    }

    public class ApiOrgunitcryptorsKey
    {
        public Get58 get { get; set; }
        public Patch13 patch { get; set; }
        public Delete15 delete { get; set; }
    }

    public class Get58
    {
        public string[] tags { get; set; }
        public string operationId { get; set; }
        public Parameter127[] parameters { get; set; }
        public Responses140 responses { get; set; }
        public string[] xroles { get; set; }
    }

    public class Responses140
    {
        public _200140 _200 { get; set; }
    }

    public class _200140
    {
        public string description { get; set; }
        public Content200 content { get; set; }
    }

    public class Content200
    {
        public ApplicationJson199 applicationjson { get; set; }
    }

    public class ApplicationJson199
    {
        public Schema327 schema { get; set; }
    }

    public class Schema327
    {
        public bool nullable { get; set; }
        public Oneof45[] oneOf { get; set; }
    }

    public class Oneof45
    {
        public string _ref { get; set; }
    }

    public class Parameter127
    {
        public string name { get; set; }
        public string _in { get; set; }
        public bool required { get; set; }
        public Schema328 schema { get; set; }
        public string description { get; set; }
    }

    public class Schema328
    {
        public string type { get; set; }
        public string format { get; set; }
        public bool nullable { get; set; }
    }

    public class Patch13
    {
        public string[] tags { get; set; }
        public string operationId { get; set; }
        public Parameter128[] parameters { get; set; }
        public Requestbody60 requestBody { get; set; }
        public Responses141 responses { get; set; }
        public string[] xroles { get; set; }
    }

    public class Requestbody60
    {
        public string xname { get; set; }
        public Content201 content { get; set; }
        public bool required { get; set; }
    }

    public class Content201
    {
        public ApplicationJson200 applicationjson { get; set; }
    }

    public class ApplicationJson200
    {
        public Schema329 schema { get; set; }
    }

    public class Schema329
    {
        public string _ref { get; set; }
    }

    public class Responses141
    {
        public _200141 _200 { get; set; }
    }

    public class _200141
    {
        public string description { get; set; }
        public Content202 content { get; set; }
    }

    public class Content202
    {
        public ApplicationJson201 applicationjson { get; set; }
    }

    public class ApplicationJson201
    {
        public Schema330 schema { get; set; }
    }

    public class Schema330
    {
        public string type { get; set; }
    }

    public class Parameter128
    {
        public string name { get; set; }
        public string _in { get; set; }
        public bool required { get; set; }
        public Schema331 schema { get; set; }
    }

    public class Schema331
    {
        public string type { get; set; }
        public string format { get; set; }
    }

    public class Delete15
    {
        public string[] tags { get; set; }
        public string operationId { get; set; }
        public Parameter129[] parameters { get; set; }
        public Responses142 responses { get; set; }
        public string[] xroles { get; set; }
    }

    public class Responses142
    {
        public _200142 _200 { get; set; }
    }

    public class _200142
    {
        public string description { get; set; }
        public Content203 content { get; set; }
    }

    public class Content203
    {
        public ApplicationJson202 applicationjson { get; set; }
    }

    public class ApplicationJson202
    {
        public Schema332 schema { get; set; }
    }

    public class Schema332
    {
        public string type { get; set; }
    }

    public class Parameter129
    {
        public string name { get; set; }
        public string _in { get; set; }
        public bool required { get; set; }
        public Schema333 schema { get; set; }
    }

    public class Schema333
    {
        public string type { get; set; }
        public string format { get; set; }
    }

    public class ApiPeriodemployees
    {
        public Get59 get { get; set; }
    }

    public class Get59
    {
        public string[] tags { get; set; }
        public string operationId { get; set; }
        public Parameter130[] parameters { get; set; }
        public Responses143 responses { get; set; }
        public string[] xroles { get; set; }
    }

    public class Responses143
    {
        public _200143 _200 { get; set; }
    }

    public class _200143
    {
        public string description { get; set; }
        public Content204 content { get; set; }
    }

    public class Content204
    {
        public ApplicationJson203 applicationjson { get; set; }
    }

    public class ApplicationJson203
    {
        public Schema334 schema { get; set; }
    }

    public class Schema334
    {
        public string type { get; set; }
        public bool nullable { get; set; }
        public Items37 items { get; set; }
    }

    public class Items37
    {
        public string _ref { get; set; }
    }

    public class Parameter130
    {
        public string name { get; set; }
        public string _in { get; set; }
        public string description { get; set; }
        public Schema335 schema { get; set; }
    }

    public class Schema335
    {
        public string type { get; set; }
        public bool nullable { get; set; }
        public string format { get; set; }
    }

    public class ApiPeriodemployeesKey
    {
        public Get60 get { get; set; }
    }

    public class Get60
    {
        public string[] tags { get; set; }
        public string operationId { get; set; }
        public Parameter131[] parameters { get; set; }
        public Responses144 responses { get; set; }
        public string[] xroles { get; set; }
    }

    public class Responses144
    {
        public _200144 _200 { get; set; }
    }

    public class _200144
    {
        public string description { get; set; }
        public Content205 content { get; set; }
    }

    public class Content205
    {
        public ApplicationJson204 applicationjson { get; set; }
    }

    public class ApplicationJson204
    {
        public Schema336 schema { get; set; }
    }

    public class Schema336
    {
        public bool nullable { get; set; }
        public Oneof46[] oneOf { get; set; }
    }

    public class Oneof46
    {
        public string _ref { get; set; }
    }

    public class Parameter131
    {
        public string name { get; set; }
        public string _in { get; set; }
        public bool required { get; set; }
        public Schema337 schema { get; set; }
        public string description { get; set; }
    }

    public class Schema337
    {
        public string type { get; set; }
        public string format { get; set; }
        public bool nullable { get; set; }
    }

    public class ApiSurveyresponses
    {
        public Get61 get { get; set; }
        public Post49 post { get; set; }
    }

    public class Get61
    {
        public string[] tags { get; set; }
        public string operationId { get; set; }
        public Parameter132[] parameters { get; set; }
        public Responses145 responses { get; set; }
        public string[] xroles { get; set; }
    }

    public class Responses145
    {
        public _200145 _200 { get; set; }
    }

    public class _200145
    {
        public string description { get; set; }
        public Content206 content { get; set; }
    }

    public class Content206
    {
        public ApplicationJson205 applicationjson { get; set; }
    }

    public class ApplicationJson205
    {
        public Schema338 schema { get; set; }
    }

    public class Schema338
    {
        public string type { get; set; }
        public bool nullable { get; set; }
        public Items38 items { get; set; }
    }

    public class Items38
    {
        public string _ref { get; set; }
    }

    public class Parameter132
    {
        public string name { get; set; }
        public string _in { get; set; }
        public string description { get; set; }
        public Schema339 schema { get; set; }
    }

    public class Schema339
    {
        public string type { get; set; }
        public bool nullable { get; set; }
        public string format { get; set; }
    }

    public class Post49
    {
        public string[] tags { get; set; }
        public string operationId { get; set; }
        public Requestbody61 requestBody { get; set; }
        public Responses146 responses { get; set; }
        public string[] xroles { get; set; }
    }

    public class Requestbody61
    {
        public string xname { get; set; }
        public Content207 content { get; set; }
        public bool required { get; set; }
    }

    public class Content207
    {
        public ApplicationJson206 applicationjson { get; set; }
    }

    public class ApplicationJson206
    {
        public Schema340 schema { get; set; }
    }

    public class Schema340
    {
        public string _ref { get; set; }
    }

    public class Responses146
    {
        public _200146 _200 { get; set; }
    }

    public class _200146
    {
        public string description { get; set; }
        public Content208 content { get; set; }
    }

    public class Content208
    {
        public ApplicationJson207 applicationjson { get; set; }
    }

    public class ApplicationJson207
    {
        public Schema341 schema { get; set; }
    }

    public class Schema341
    {
        public string type { get; set; }
    }

    public class ApiSurveyresponsesKey
    {
        public Get62 get { get; set; }
        public Patch14 patch { get; set; }
    }

    public class Get62
    {
        public string[] tags { get; set; }
        public string operationId { get; set; }
        public Parameter133[] parameters { get; set; }
        public Responses147 responses { get; set; }
        public string[] xroles { get; set; }
    }

    public class Responses147
    {
        public _200147 _200 { get; set; }
    }

    public class _200147
    {
        public string description { get; set; }
        public Content209 content { get; set; }
    }

    public class Content209
    {
        public ApplicationJson208 applicationjson { get; set; }
    }

    public class ApplicationJson208
    {
        public Schema342 schema { get; set; }
    }

    public class Schema342
    {
        public bool nullable { get; set; }
        public Oneof47[] oneOf { get; set; }
    }

    public class Oneof47
    {
        public string _ref { get; set; }
    }

    public class Parameter133
    {
        public string name { get; set; }
        public string _in { get; set; }
        public bool required { get; set; }
        public Schema343 schema { get; set; }
        public string description { get; set; }
    }

    public class Schema343
    {
        public string type { get; set; }
        public string format { get; set; }
        public bool nullable { get; set; }
    }

    public class Patch14
    {
        public string[] tags { get; set; }
        public string operationId { get; set; }
        public Parameter134[] parameters { get; set; }
        public Requestbody62 requestBody { get; set; }
        public Responses148 responses { get; set; }
        public string[] xroles { get; set; }
    }

    public class Requestbody62
    {
        public string xname { get; set; }
        public Content210 content { get; set; }
        public bool required { get; set; }
    }

    public class Content210
    {
        public ApplicationJson209 applicationjson { get; set; }
    }

    public class ApplicationJson209
    {
        public Schema344 schema { get; set; }
    }

    public class Schema344
    {
        public string _ref { get; set; }
    }

    public class Responses148
    {
        public _200148 _200 { get; set; }
    }

    public class _200148
    {
        public string description { get; set; }
        public Content211 content { get; set; }
    }

    public class Content211
    {
        public ApplicationJson210 applicationjson { get; set; }
    }

    public class ApplicationJson210
    {
        public Schema345 schema { get; set; }
    }

    public class Schema345
    {
        public string type { get; set; }
    }

    public class Parameter134
    {
        public string name { get; set; }
        public string _in { get; set; }
        public bool required { get; set; }
        public Schema346 schema { get; set; }
    }

    public class Schema346
    {
        public string type { get; set; }
        public string format { get; set; }
    }

    public class ApiProductsuppliers
    {
        public Get63 get { get; set; }
        public Post50 post { get; set; }
    }

    public class Get63
    {
        public string[] tags { get; set; }
        public string operationId { get; set; }
        public Parameter135[] parameters { get; set; }
        public Responses149 responses { get; set; }
        public string[] xroles { get; set; }
    }

    public class Responses149
    {
        public _200149 _200 { get; set; }
    }

    public class _200149
    {
        public string description { get; set; }
        public Content212 content { get; set; }
    }

    public class Content212
    {
        public ApplicationJson211 applicationjson { get; set; }
    }

    public class ApplicationJson211
    {
        public Schema347 schema { get; set; }
    }

    public class Schema347
    {
        public string type { get; set; }
        public bool nullable { get; set; }
        public Items39 items { get; set; }
    }

    public class Items39
    {
        public string _ref { get; set; }
    }

    public class Parameter135
    {
        public string name { get; set; }
        public string _in { get; set; }
        public string description { get; set; }
        public Schema348 schema { get; set; }
    }

    public class Schema348
    {
        public string type { get; set; }
        public bool nullable { get; set; }
        public string format { get; set; }
    }

    public class Post50
    {
        public string[] tags { get; set; }
        public string operationId { get; set; }
        public Requestbody63 requestBody { get; set; }
        public Responses150 responses { get; set; }
        public string[] xroles { get; set; }
    }

    public class Requestbody63
    {
        public string xname { get; set; }
        public Content213 content { get; set; }
        public bool required { get; set; }
    }

    public class Content213
    {
        public ApplicationJson212 applicationjson { get; set; }
    }

    public class ApplicationJson212
    {
        public Schema349 schema { get; set; }
    }

    public class Schema349
    {
        public string _ref { get; set; }
    }

    public class Responses150
    {
        public _200150 _200 { get; set; }
    }

    public class _200150
    {
        public string description { get; set; }
        public Content214 content { get; set; }
    }

    public class Content214
    {
        public ApplicationJson213 applicationjson { get; set; }
    }

    public class ApplicationJson213
    {
        public Schema350 schema { get; set; }
    }

    public class Schema350
    {
        public string type { get; set; }
    }

    public class ApiProductsuppliersKey
    {
        public Get64 get { get; set; }
        public Patch15 patch { get; set; }
        public Delete16 delete { get; set; }
    }

    public class Get64
    {
        public string[] tags { get; set; }
        public string operationId { get; set; }
        public Parameter136[] parameters { get; set; }
        public Responses151 responses { get; set; }
        public string[] xroles { get; set; }
    }

    public class Responses151
    {
        public _200151 _200 { get; set; }
    }

    public class _200151
    {
        public string description { get; set; }
        public Content215 content { get; set; }
    }

    public class Content215
    {
        public ApplicationJson214 applicationjson { get; set; }
    }

    public class ApplicationJson214
    {
        public Schema351 schema { get; set; }
    }

    public class Schema351
    {
        public bool nullable { get; set; }
        public Oneof48[] oneOf { get; set; }
    }

    public class Oneof48
    {
        public string _ref { get; set; }
    }

    public class Parameter136
    {
        public string name { get; set; }
        public string _in { get; set; }
        public bool required { get; set; }
        public Schema352 schema { get; set; }
        public string description { get; set; }
    }

    public class Schema352
    {
        public string type { get; set; }
        public string format { get; set; }
        public bool nullable { get; set; }
    }

    public class Patch15
    {
        public string[] tags { get; set; }
        public string operationId { get; set; }
        public Parameter137[] parameters { get; set; }
        public Requestbody64 requestBody { get; set; }
        public Responses152 responses { get; set; }
        public string[] xroles { get; set; }
    }

    public class Requestbody64
    {
        public string xname { get; set; }
        public Content216 content { get; set; }
        public bool required { get; set; }
    }

    public class Content216
    {
        public ApplicationJson215 applicationjson { get; set; }
    }

    public class ApplicationJson215
    {
        public Schema353 schema { get; set; }
    }

    public class Schema353
    {
        public string _ref { get; set; }
    }

    public class Responses152
    {
        public _200152 _200 { get; set; }
    }

    public class _200152
    {
        public string description { get; set; }
        public Content217 content { get; set; }
    }

    public class Content217
    {
        public ApplicationJson216 applicationjson { get; set; }
    }

    public class ApplicationJson216
    {
        public Schema354 schema { get; set; }
    }

    public class Schema354
    {
        public string type { get; set; }
    }

    public class Parameter137
    {
        public string name { get; set; }
        public string _in { get; set; }
        public bool required { get; set; }
        public Schema355 schema { get; set; }
    }

    public class Schema355
    {
        public string type { get; set; }
        public string format { get; set; }
    }

    public class Delete16
    {
        public string[] tags { get; set; }
        public string operationId { get; set; }
        public Parameter138[] parameters { get; set; }
        public Responses153 responses { get; set; }
        public string[] xroles { get; set; }
    }

    public class Responses153
    {
        public _200153 _200 { get; set; }
    }

    public class _200153
    {
        public string description { get; set; }
        public Content218 content { get; set; }
    }

    public class Content218
    {
        public ApplicationJson217 applicationjson { get; set; }
    }

    public class ApplicationJson217
    {
        public Schema356 schema { get; set; }
    }

    public class Schema356
    {
        public string type { get; set; }
    }

    public class Parameter138
    {
        public string name { get; set; }
        public string _in { get; set; }
        public bool required { get; set; }
        public Schema357 schema { get; set; }
    }

    public class Schema357
    {
        public string type { get; set; }
        public string format { get; set; }
    }

    public class ApiOrgunitconnectors
    {
        public Get65 get { get; set; }
        public Post51 post { get; set; }
    }

    public class Get65
    {
        public string[] tags { get; set; }
        public string operationId { get; set; }
        public Parameter139[] parameters { get; set; }
        public Responses154 responses { get; set; }
        public string[] xroles { get; set; }
    }

    public class Responses154
    {
        public _200154 _200 { get; set; }
    }

    public class _200154
    {
        public string description { get; set; }
        public Content219 content { get; set; }
    }

    public class Content219
    {
        public ApplicationJson218 applicationjson { get; set; }
    }

    public class ApplicationJson218
    {
        public Schema358 schema { get; set; }
    }

    public class Schema358
    {
        public string type { get; set; }
        public bool nullable { get; set; }
        public Items40 items { get; set; }
    }

    public class Items40
    {
        public string _ref { get; set; }
    }

    public class Parameter139
    {
        public string name { get; set; }
        public string _in { get; set; }
        public string description { get; set; }
        public Schema359 schema { get; set; }
    }

    public class Schema359
    {
        public string type { get; set; }
        public bool nullable { get; set; }
        public string format { get; set; }
    }

    public class Post51
    {
        public string[] tags { get; set; }
        public string operationId { get; set; }
        public Requestbody65 requestBody { get; set; }
        public Responses155 responses { get; set; }
        public string[] xroles { get; set; }
    }

    public class Requestbody65
    {
        public string xname { get; set; }
        public Content220 content { get; set; }
        public bool required { get; set; }
    }

    public class Content220
    {
        public ApplicationJson219 applicationjson { get; set; }
    }

    public class ApplicationJson219
    {
        public Schema360 schema { get; set; }
    }

    public class Schema360
    {
        public string _ref { get; set; }
    }

    public class Responses155
    {
        public _200155 _200 { get; set; }
    }

    public class _200155
    {
        public string description { get; set; }
        public Content221 content { get; set; }
    }

    public class Content221
    {
        public ApplicationJson220 applicationjson { get; set; }
    }

    public class ApplicationJson220
    {
        public Schema361 schema { get; set; }
    }

    public class Schema361
    {
        public string type { get; set; }
    }

    public class ApiOrgunitconnectorsKey
    {
        public Get66 get { get; set; }
        public Patch16 patch { get; set; }
        public Delete17 delete { get; set; }
    }

    public class Get66
    {
        public string[] tags { get; set; }
        public string operationId { get; set; }
        public Parameter140[] parameters { get; set; }
        public Responses156 responses { get; set; }
        public string[] xroles { get; set; }
    }

    public class Responses156
    {
        public _200156 _200 { get; set; }
    }

    public class _200156
    {
        public string description { get; set; }
        public Content222 content { get; set; }
    }

    public class Content222
    {
        public ApplicationJson221 applicationjson { get; set; }
    }

    public class ApplicationJson221
    {
        public Schema362 schema { get; set; }
    }

    public class Schema362
    {
        public bool nullable { get; set; }
        public Oneof49[] oneOf { get; set; }
    }

    public class Oneof49
    {
        public string _ref { get; set; }
    }

    public class Parameter140
    {
        public string name { get; set; }
        public string _in { get; set; }
        public bool required { get; set; }
        public Schema363 schema { get; set; }
        public string description { get; set; }
    }

    public class Schema363
    {
        public string type { get; set; }
        public string format { get; set; }
        public bool nullable { get; set; }
    }

    public class Patch16
    {
        public string[] tags { get; set; }
        public string operationId { get; set; }
        public Parameter141[] parameters { get; set; }
        public Requestbody66 requestBody { get; set; }
        public Responses157 responses { get; set; }
        public string[] xroles { get; set; }
    }

    public class Requestbody66
    {
        public string xname { get; set; }
        public Content223 content { get; set; }
        public bool required { get; set; }
    }

    public class Content223
    {
        public ApplicationJson222 applicationjson { get; set; }
    }

    public class ApplicationJson222
    {
        public Schema364 schema { get; set; }
    }

    public class Schema364
    {
        public string _ref { get; set; }
    }

    public class Responses157
    {
        public _200157 _200 { get; set; }
    }

    public class _200157
    {
        public string description { get; set; }
        public Content224 content { get; set; }
    }

    public class Content224
    {
        public ApplicationJson223 applicationjson { get; set; }
    }

    public class ApplicationJson223
    {
        public Schema365 schema { get; set; }
    }

    public class Schema365
    {
        public string type { get; set; }
    }

    public class Parameter141
    {
        public string name { get; set; }
        public string _in { get; set; }
        public bool required { get; set; }
        public Schema366 schema { get; set; }
    }

    public class Schema366
    {
        public string type { get; set; }
        public string format { get; set; }
    }

    public class Delete17
    {
        public string[] tags { get; set; }
        public string operationId { get; set; }
        public Parameter142[] parameters { get; set; }
        public Responses158 responses { get; set; }
        public string[] xroles { get; set; }
    }

    public class Responses158
    {
        public _200158 _200 { get; set; }
    }

    public class _200158
    {
        public string description { get; set; }
        public Content225 content { get; set; }
    }

    public class Content225
    {
        public ApplicationJson224 applicationjson { get; set; }
    }

    public class ApplicationJson224
    {
        public Schema367 schema { get; set; }
    }

    public class Schema367
    {
        public string type { get; set; }
    }

    public class Parameter142
    {
        public string name { get; set; }
        public string _in { get; set; }
        public bool required { get; set; }
        public Schema368 schema { get; set; }
    }

    public class Schema368
    {
        public string type { get; set; }
        public string format { get; set; }
    }

    public class ApiOrgunitconnectorsKeyEnqueuejob
    {
        public Post52 post { get; set; }
    }

    public class Post52
    {
        public string[] tags { get; set; }
        public string summary { get; set; }
        public string operationId { get; set; }
        public Parameter143[] parameters { get; set; }
        public Responses159 responses { get; set; }
        public string[] xroles { get; set; }
    }

    public class Responses159
    {
        public _200159 _200 { get; set; }
    }

    public class _200159
    {
        public string description { get; set; }
        public Content226 content { get; set; }
    }

    public class Content226
    {
        public ApplicationJson225 applicationjson { get; set; }
    }

    public class ApplicationJson225
    {
        public Schema369 schema { get; set; }
    }

    public class Schema369
    {
        public string type { get; set; }
    }

    public class Parameter143
    {
        public string name { get; set; }
        public string _in { get; set; }
        public bool required { get; set; }
        public Schema370 schema { get; set; }
        public string description { get; set; }
    }

    public class Schema370
    {
        public string type { get; set; }
        public string format { get; set; }
        public bool nullable { get; set; }
    }

    public class ApiTemplateresources
    {
        public Get67 get { get; set; }
        public Post53 post { get; set; }
    }

    public class Get67
    {
        public string[] tags { get; set; }
        public string operationId { get; set; }
        public Parameter144[] parameters { get; set; }
        public Responses160 responses { get; set; }
        public string[] xroles { get; set; }
    }

    public class Responses160
    {
        public _200160 _200 { get; set; }
    }

    public class _200160
    {
        public string description { get; set; }
        public Content227 content { get; set; }
    }

    public class Content227
    {
        public ApplicationJson226 applicationjson { get; set; }
    }

    public class ApplicationJson226
    {
        public Schema371 schema { get; set; }
    }

    public class Schema371
    {
        public string type { get; set; }
        public bool nullable { get; set; }
        public Items41 items { get; set; }
    }

    public class Items41
    {
        public string _ref { get; set; }
    }

    public class Parameter144
    {
        public string name { get; set; }
        public string _in { get; set; }
        public string description { get; set; }
        public Schema372 schema { get; set; }
    }

    public class Schema372
    {
        public string type { get; set; }
        public bool nullable { get; set; }
        public string format { get; set; }
    }

    public class Post53
    {
        public string[] tags { get; set; }
        public string operationId { get; set; }
        public Requestbody67 requestBody { get; set; }
        public Responses161 responses { get; set; }
        public string[] xroles { get; set; }
    }

    public class Requestbody67
    {
        public string xname { get; set; }
        public Content228 content { get; set; }
        public bool required { get; set; }
    }

    public class Content228
    {
        public ApplicationJson227 applicationjson { get; set; }
    }

    public class ApplicationJson227
    {
        public Schema373 schema { get; set; }
    }

    public class Schema373
    {
        public string _ref { get; set; }
    }

    public class Responses161
    {
        public _200161 _200 { get; set; }
    }

    public class _200161
    {
        public string description { get; set; }
        public Content229 content { get; set; }
    }

    public class Content229
    {
        public ApplicationJson228 applicationjson { get; set; }
    }

    public class ApplicationJson228
    {
        public Schema374 schema { get; set; }
    }

    public class Schema374
    {
        public string type { get; set; }
    }

    public class ApiTemplateresourcesKey
    {
        public Get68 get { get; set; }
        public Patch17 patch { get; set; }
        public Delete18 delete { get; set; }
    }

    public class Get68
    {
        public string[] tags { get; set; }
        public string operationId { get; set; }
        public Parameter145[] parameters { get; set; }
        public Responses162 responses { get; set; }
        public string[] xroles { get; set; }
    }

    public class Responses162
    {
        public _200162 _200 { get; set; }
    }

    public class _200162
    {
        public string description { get; set; }
        public Content230 content { get; set; }
    }

    public class Content230
    {
        public ApplicationJson229 applicationjson { get; set; }
    }

    public class ApplicationJson229
    {
        public Schema375 schema { get; set; }
    }

    public class Schema375
    {
        public bool nullable { get; set; }
        public Oneof50[] oneOf { get; set; }
    }

    public class Oneof50
    {
        public string _ref { get; set; }
    }

    public class Parameter145
    {
        public string name { get; set; }
        public string _in { get; set; }
        public bool required { get; set; }
        public Schema376 schema { get; set; }
        public string description { get; set; }
    }

    public class Schema376
    {
        public string type { get; set; }
        public string format { get; set; }
        public bool nullable { get; set; }
    }

    public class Patch17
    {
        public string[] tags { get; set; }
        public string operationId { get; set; }
        public Parameter146[] parameters { get; set; }
        public Requestbody68 requestBody { get; set; }
        public Responses163 responses { get; set; }
        public string[] xroles { get; set; }
    }

    public class Requestbody68
    {
        public string xname { get; set; }
        public Content231 content { get; set; }
        public bool required { get; set; }
    }

    public class Content231
    {
        public ApplicationJson230 applicationjson { get; set; }
    }

    public class ApplicationJson230
    {
        public Schema377 schema { get; set; }
    }

    public class Schema377
    {
        public string _ref { get; set; }
    }

    public class Responses163
    {
        public _200163 _200 { get; set; }
    }

    public class _200163
    {
        public string description { get; set; }
        public Content232 content { get; set; }
    }

    public class Content232
    {
        public ApplicationJson231 applicationjson { get; set; }
    }

    public class ApplicationJson231
    {
        public Schema378 schema { get; set; }
    }

    public class Schema378
    {
        public string type { get; set; }
    }

    public class Parameter146
    {
        public string name { get; set; }
        public string _in { get; set; }
        public bool required { get; set; }
        public Schema379 schema { get; set; }
    }

    public class Schema379
    {
        public string type { get; set; }
        public string format { get; set; }
    }

    public class Delete18
    {
        public string[] tags { get; set; }
        public string operationId { get; set; }
        public Parameter147[] parameters { get; set; }
        public Responses164 responses { get; set; }
        public string[] xroles { get; set; }
    }

    public class Responses164
    {
        public _200164 _200 { get; set; }
    }

    public class _200164
    {
        public string description { get; set; }
        public Content233 content { get; set; }
    }

    public class Content233
    {
        public ApplicationJson232 applicationjson { get; set; }
    }

    public class ApplicationJson232
    {
        public Schema380 schema { get; set; }
    }

    public class Schema380
    {
        public string type { get; set; }
    }

    public class Parameter147
    {
        public string name { get; set; }
        public string _in { get; set; }
        public bool required { get; set; }
        public Schema381 schema { get; set; }
    }

    public class Schema381
    {
        public string type { get; set; }
        public string format { get; set; }
    }

    public class ApiTaggedcontentitems
    {
        public Get69 get { get; set; }
        public Post54 post { get; set; }
    }

    public class Get69
    {
        public string[] tags { get; set; }
        public string operationId { get; set; }
        public Parameter148[] parameters { get; set; }
        public Responses165 responses { get; set; }
        public string[] xroles { get; set; }
    }

    public class Responses165
    {
        public _200165 _200 { get; set; }
    }

    public class _200165
    {
        public string description { get; set; }
        public Content234 content { get; set; }
    }

    public class Content234
    {
        public ApplicationJson233 applicationjson { get; set; }
    }

    public class ApplicationJson233
    {
        public Schema382 schema { get; set; }
    }

    public class Schema382
    {
        public string type { get; set; }
        public bool nullable { get; set; }
        public Items42 items { get; set; }
    }

    public class Items42
    {
        public string _ref { get; set; }
    }

    public class Parameter148
    {
        public string name { get; set; }
        public string _in { get; set; }
        public string description { get; set; }
        public Schema383 schema { get; set; }
    }

    public class Schema383
    {
        public string type { get; set; }
        public bool nullable { get; set; }
        public string format { get; set; }
    }

    public class Post54
    {
        public string[] tags { get; set; }
        public string operationId { get; set; }
        public Requestbody69 requestBody { get; set; }
        public Responses166 responses { get; set; }
        public string[] xroles { get; set; }
    }

    public class Requestbody69
    {
        public string xname { get; set; }
        public Content235 content { get; set; }
        public bool required { get; set; }
    }

    public class Content235
    {
        public ApplicationJson234 applicationjson { get; set; }
    }

    public class ApplicationJson234
    {
        public Schema384 schema { get; set; }
    }

    public class Schema384
    {
        public string _ref { get; set; }
    }

    public class Responses166
    {
        public _200166 _200 { get; set; }
    }

    public class _200166
    {
        public string description { get; set; }
        public Content236 content { get; set; }
    }

    public class Content236
    {
        public ApplicationJson235 applicationjson { get; set; }
    }

    public class ApplicationJson235
    {
        public Schema385 schema { get; set; }
    }

    public class Schema385
    {
        public string type { get; set; }
    }

    public class ApiTaggedcontentitemsKey
    {
        public Get70 get { get; set; }
        public Patch18 patch { get; set; }
        public Delete19 delete { get; set; }
    }

    public class Get70
    {
        public string[] tags { get; set; }
        public string operationId { get; set; }
        public Parameter149[] parameters { get; set; }
        public Responses167 responses { get; set; }
        public string[] xroles { get; set; }
    }

    public class Responses167
    {
        public _200167 _200 { get; set; }
    }

    public class _200167
    {
        public string description { get; set; }
        public Content237 content { get; set; }
    }

    public class Content237
    {
        public ApplicationJson236 applicationjson { get; set; }
    }

    public class ApplicationJson236
    {
        public Schema386 schema { get; set; }
    }

    public class Schema386
    {
        public bool nullable { get; set; }
        public Oneof51[] oneOf { get; set; }
    }

    public class Oneof51
    {
        public string _ref { get; set; }
    }

    public class Parameter149
    {
        public string name { get; set; }
        public string _in { get; set; }
        public bool required { get; set; }
        public Schema387 schema { get; set; }
        public string description { get; set; }
    }

    public class Schema387
    {
        public string type { get; set; }
        public string format { get; set; }
        public bool nullable { get; set; }
    }

    public class Patch18
    {
        public string[] tags { get; set; }
        public string operationId { get; set; }
        public Parameter150[] parameters { get; set; }
        public Requestbody70 requestBody { get; set; }
        public Responses168 responses { get; set; }
        public string[] xroles { get; set; }
    }

    public class Requestbody70
    {
        public string xname { get; set; }
        public Content238 content { get; set; }
        public bool required { get; set; }
    }

    public class Content238
    {
        public ApplicationJson237 applicationjson { get; set; }
    }

    public class ApplicationJson237
    {
        public Schema388 schema { get; set; }
    }

    public class Schema388
    {
        public string _ref { get; set; }
    }

    public class Responses168
    {
        public _200168 _200 { get; set; }
    }

    public class _200168
    {
        public string description { get; set; }
        public Content239 content { get; set; }
    }

    public class Content239
    {
        public ApplicationJson238 applicationjson { get; set; }
    }

    public class ApplicationJson238
    {
        public Schema389 schema { get; set; }
    }

    public class Schema389
    {
        public string type { get; set; }
    }

    public class Parameter150
    {
        public string name { get; set; }
        public string _in { get; set; }
        public bool required { get; set; }
        public Schema390 schema { get; set; }
    }

    public class Schema390
    {
        public string type { get; set; }
        public string format { get; set; }
    }

    public class Delete19
    {
        public string[] tags { get; set; }
        public string operationId { get; set; }
        public Parameter151[] parameters { get; set; }
        public Responses169 responses { get; set; }
        public string[] xroles { get; set; }
    }

    public class Responses169
    {
        public _200169 _200 { get; set; }
    }

    public class _200169
    {
        public string description { get; set; }
        public Content240 content { get; set; }
    }

    public class Content240
    {
        public ApplicationJson239 applicationjson { get; set; }
    }

    public class ApplicationJson239
    {
        public Schema391 schema { get; set; }
    }

    public class Schema391
    {
        public string type { get; set; }
    }

    public class Parameter151
    {
        public string name { get; set; }
        public string _in { get; set; }
        public bool required { get; set; }
        public Schema392 schema { get; set; }
    }

    public class Schema392
    {
        public string type { get; set; }
        public string format { get; set; }
    }

    public class ApiTaggedcontentitemsKeyTagsRef
    {
        public Put5 put { get; set; }
        public Post55 post { get; set; }
    }

    public class Put5
    {
        public string[] tags { get; set; }
        public string operationId { get; set; }
        public Parameter152[] parameters { get; set; }
        public Requestbody71 requestBody { get; set; }
        public Responses170 responses { get; set; }
        public string[] xroles { get; set; }
    }

    public class Requestbody71
    {
        public string xname { get; set; }
        public Content241 content { get; set; }
        public bool required { get; set; }
    }

    public class Content241
    {
        public ApplicationJson240 applicationjson { get; set; }
    }

    public class ApplicationJson240
    {
        public Schema393 schema { get; set; }
    }

    public class Schema393
    {
        public string type { get; set; }
        public string format { get; set; }
    }

    public class Responses170
    {
        public _200170 _200 { get; set; }
    }

    public class _200170
    {
        public string description { get; set; }
        public Content242 content { get; set; }
    }

    public class Content242
    {
        public ApplicationJson241 applicationjson { get; set; }
    }

    public class ApplicationJson241
    {
        public Schema394 schema { get; set; }
    }

    public class Schema394
    {
        public string type { get; set; }
    }

    public class Parameter152
    {
        public string name { get; set; }
        public string _in { get; set; }
        public bool required { get; set; }
        public Schema395 schema { get; set; }
    }

    public class Schema395
    {
        public string type { get; set; }
        public string format { get; set; }
        public bool nullable { get; set; }
    }

    public class Post55
    {
        public string[] tags { get; set; }
        public string operationId { get; set; }
        public Parameter153[] parameters { get; set; }
        public Requestbody72 requestBody { get; set; }
        public Responses171 responses { get; set; }
        public string[] xroles { get; set; }
    }

    public class Requestbody72
    {
        public string xname { get; set; }
        public Content243 content { get; set; }
        public bool required { get; set; }
    }

    public class Content243
    {
        public ApplicationJson242 applicationjson { get; set; }
    }

    public class ApplicationJson242
    {
        public Schema396 schema { get; set; }
    }

    public class Schema396
    {
        public string type { get; set; }
        public string format { get; set; }
    }

    public class Responses171
    {
        public _200171 _200 { get; set; }
    }

    public class _200171
    {
        public string description { get; set; }
        public Content244 content { get; set; }
    }

    public class Content244
    {
        public ApplicationJson243 applicationjson { get; set; }
    }

    public class ApplicationJson243
    {
        public Schema397 schema { get; set; }
    }

    public class Schema397
    {
        public string type { get; set; }
    }

    public class Parameter153
    {
        public string name { get; set; }
        public string _in { get; set; }
        public bool required { get; set; }
        public Schema398 schema { get; set; }
    }

    public class Schema398
    {
        public string type { get; set; }
        public string format { get; set; }
        public bool nullable { get; set; }
    }

    public class ApiTaggedcontentitemsKeyTagsRelatedkeyRef
    {
        public Delete20 delete { get; set; }
    }

    public class Delete20
    {
        public string[] tags { get; set; }
        public string operationId { get; set; }
        public Parameter154[] parameters { get; set; }
        public Responses172 responses { get; set; }
        public string[] xroles { get; set; }
    }

    public class Responses172
    {
        public _200172 _200 { get; set; }
    }

    public class _200172
    {
        public string description { get; set; }
        public Content245 content { get; set; }
    }

    public class Content245
    {
        public ApplicationJson244 applicationjson { get; set; }
    }

    public class ApplicationJson244
    {
        public Schema399 schema { get; set; }
    }

    public class Schema399
    {
        public string type { get; set; }
    }

    public class Parameter154
    {
        public string name { get; set; }
        public string _in { get; set; }
        public bool required { get; set; }
        public Schema400 schema { get; set; }
    }

    public class Schema400
    {
        public string type { get; set; }
        public string format { get; set; }
        public bool nullable { get; set; }
    }

    public class ApiTracktracemessages
    {
        public Get71 get { get; set; }
    }

    public class Get71
    {
        public string[] tags { get; set; }
        public string operationId { get; set; }
        public Parameter155[] parameters { get; set; }
        public Responses173 responses { get; set; }
        public string[] xroles { get; set; }
    }

    public class Responses173
    {
        public _200173 _200 { get; set; }
    }

    public class _200173
    {
        public string description { get; set; }
        public Content246 content { get; set; }
    }

    public class Content246
    {
        public ApplicationJson245 applicationjson { get; set; }
    }

    public class ApplicationJson245
    {
        public Schema401 schema { get; set; }
    }

    public class Schema401
    {
        public string type { get; set; }
        public bool nullable { get; set; }
        public Items43 items { get; set; }
    }

    public class Items43
    {
        public string _ref { get; set; }
    }

    public class Parameter155
    {
        public string name { get; set; }
        public string _in { get; set; }
        public string description { get; set; }
        public Schema402 schema { get; set; }
    }

    public class Schema402
    {
        public string type { get; set; }
        public bool nullable { get; set; }
        public string format { get; set; }
    }

    public class ApiTracktracemessagesKey
    {
        public Get72 get { get; set; }
    }

    public class Get72
    {
        public string[] tags { get; set; }
        public string operationId { get; set; }
        public Parameter156[] parameters { get; set; }
        public Responses174 responses { get; set; }
        public string[] xroles { get; set; }
    }

    public class Responses174
    {
        public _200174 _200 { get; set; }
    }

    public class _200174
    {
        public string description { get; set; }
        public Content247 content { get; set; }
    }

    public class Content247
    {
        public ApplicationJson246 applicationjson { get; set; }
    }

    public class ApplicationJson246
    {
        public Schema403 schema { get; set; }
    }

    public class Schema403
    {
        public bool nullable { get; set; }
        public Oneof52[] oneOf { get; set; }
    }

    public class Oneof52
    {
        public string _ref { get; set; }
    }

    public class Parameter156
    {
        public string name { get; set; }
        public string _in { get; set; }
        public bool required { get; set; }
        public Schema404 schema { get; set; }
        public string description { get; set; }
    }

    public class Schema404
    {
        public string type { get; set; }
        public string format { get; set; }
        public bool nullable { get; set; }
    }

    public class ApiCatalogsubscriptions
    {
        public Get73 get { get; set; }
        public Post56 post { get; set; }
    }

    public class Get73
    {
        public string[] tags { get; set; }
        public string operationId { get; set; }
        public Parameter157[] parameters { get; set; }
        public Responses175 responses { get; set; }
        public string[] xroles { get; set; }
    }

    public class Responses175
    {
        public _200175 _200 { get; set; }
    }

    public class _200175
    {
        public string description { get; set; }
        public Content248 content { get; set; }
    }

    public class Content248
    {
        public ApplicationJson247 applicationjson { get; set; }
    }

    public class ApplicationJson247
    {
        public Schema405 schema { get; set; }
    }

    public class Schema405
    {
        public string type { get; set; }
        public bool nullable { get; set; }
        public Items44 items { get; set; }
    }

    public class Items44
    {
        public string _ref { get; set; }
    }

    public class Parameter157
    {
        public string name { get; set; }
        public string _in { get; set; }
        public string description { get; set; }
        public Schema406 schema { get; set; }
    }

    public class Schema406
    {
        public string type { get; set; }
        public bool nullable { get; set; }
        public string format { get; set; }
    }

    public class Post56
    {
        public string[] tags { get; set; }
        public string operationId { get; set; }
        public Requestbody73 requestBody { get; set; }
        public Responses176 responses { get; set; }
        public string[] xroles { get; set; }
    }

    public class Requestbody73
    {
        public string xname { get; set; }
        public Content249 content { get; set; }
        public bool required { get; set; }
    }

    public class Content249
    {
        public ApplicationJson248 applicationjson { get; set; }
    }

    public class ApplicationJson248
    {
        public Schema407 schema { get; set; }
    }

    public class Schema407
    {
        public string _ref { get; set; }
    }

    public class Responses176
    {
        public _200176 _200 { get; set; }
    }

    public class _200176
    {
        public string description { get; set; }
        public Content250 content { get; set; }
    }

    public class Content250
    {
        public ApplicationJson249 applicationjson { get; set; }
    }

    public class ApplicationJson249
    {
        public Schema408 schema { get; set; }
    }

    public class Schema408
    {
        public string type { get; set; }
    }

    public class ApiCatalogsubscriptionsKey
    {
        public Get74 get { get; set; }
        public Patch19 patch { get; set; }
        public Delete21 delete { get; set; }
    }

    public class Get74
    {
        public string[] tags { get; set; }
        public string operationId { get; set; }
        public Parameter158[] parameters { get; set; }
        public Responses177 responses { get; set; }
        public string[] xroles { get; set; }
    }

    public class Responses177
    {
        public _200177 _200 { get; set; }
    }

    public class _200177
    {
        public string description { get; set; }
        public Content251 content { get; set; }
    }

    public class Content251
    {
        public ApplicationJson250 applicationjson { get; set; }
    }

    public class ApplicationJson250
    {
        public Schema409 schema { get; set; }
    }

    public class Schema409
    {
        public bool nullable { get; set; }
        public Oneof53[] oneOf { get; set; }
    }

    public class Oneof53
    {
        public string _ref { get; set; }
    }

    public class Parameter158
    {
        public string name { get; set; }
        public string _in { get; set; }
        public bool required { get; set; }
        public Schema410 schema { get; set; }
        public string description { get; set; }
    }

    public class Schema410
    {
        public string type { get; set; }
        public string format { get; set; }
        public bool nullable { get; set; }
    }

    public class Patch19
    {
        public string[] tags { get; set; }
        public string operationId { get; set; }
        public Parameter159[] parameters { get; set; }
        public Requestbody74 requestBody { get; set; }
        public Responses178 responses { get; set; }
        public string[] xroles { get; set; }
    }

    public class Requestbody74
    {
        public string xname { get; set; }
        public Content252 content { get; set; }
        public bool required { get; set; }
    }

    public class Content252
    {
        public ApplicationJson251 applicationjson { get; set; }
    }

    public class ApplicationJson251
    {
        public Schema411 schema { get; set; }
    }

    public class Schema411
    {
        public string _ref { get; set; }
    }

    public class Responses178
    {
        public _200178 _200 { get; set; }
    }

    public class _200178
    {
        public string description { get; set; }
        public Content253 content { get; set; }
    }

    public class Content253
    {
        public ApplicationJson252 applicationjson { get; set; }
    }

    public class ApplicationJson252
    {
        public Schema412 schema { get; set; }
    }

    public class Schema412
    {
        public string type { get; set; }
    }

    public class Parameter159
    {
        public string name { get; set; }
        public string _in { get; set; }
        public bool required { get; set; }
        public Schema413 schema { get; set; }
    }

    public class Schema413
    {
        public string type { get; set; }
        public string format { get; set; }
    }

    public class Delete21
    {
        public string[] tags { get; set; }
        public string operationId { get; set; }
        public Parameter160[] parameters { get; set; }
        public Responses179 responses { get; set; }
        public string[] xroles { get; set; }
    }

    public class Responses179
    {
        public _200179 _200 { get; set; }
    }

    public class _200179
    {
        public string description { get; set; }
        public Content254 content { get; set; }
    }

    public class Content254
    {
        public ApplicationJson253 applicationjson { get; set; }
    }

    public class ApplicationJson253
    {
        public Schema414 schema { get; set; }
    }

    public class Schema414
    {
        public string type { get; set; }
    }

    public class Parameter160
    {
        public string name { get; set; }
        public string _in { get; set; }
        public bool required { get; set; }
        public Schema415 schema { get; set; }
    }

    public class Schema415
    {
        public string type { get; set; }
        public string format { get; set; }
    }

    public class ApiProductchoicebatches
    {
        public Get75 get { get; set; }
    }

    public class Get75
    {
        public string[] tags { get; set; }
        public string operationId { get; set; }
        public Parameter161[] parameters { get; set; }
        public Responses180 responses { get; set; }
        public string[] xroles { get; set; }
    }

    public class Responses180
    {
        public _200180 _200 { get; set; }
    }

    public class _200180
    {
        public string description { get; set; }
        public Content255 content { get; set; }
    }

    public class Content255
    {
        public ApplicationJson254 applicationjson { get; set; }
    }

    public class ApplicationJson254
    {
        public Schema416 schema { get; set; }
    }

    public class Schema416
    {
        public string type { get; set; }
        public bool nullable { get; set; }
        public Items45 items { get; set; }
    }

    public class Items45
    {
        public string _ref { get; set; }
    }

    public class Parameter161
    {
        public string name { get; set; }
        public string _in { get; set; }
        public string description { get; set; }
        public Schema417 schema { get; set; }
    }

    public class Schema417
    {
        public string type { get; set; }
        public bool nullable { get; set; }
        public string format { get; set; }
    }

    public class ApiProductchoicebatchesKey
    {
        public Get76 get { get; set; }
    }

    public class Get76
    {
        public string[] tags { get; set; }
        public string operationId { get; set; }
        public Parameter162[] parameters { get; set; }
        public Responses181 responses { get; set; }
        public string[] xroles { get; set; }
    }

    public class Responses181
    {
        public _200181 _200 { get; set; }
    }

    public class _200181
    {
        public string description { get; set; }
        public Content256 content { get; set; }
    }

    public class Content256
    {
        public ApplicationJson255 applicationjson { get; set; }
    }

    public class ApplicationJson255
    {
        public Schema418 schema { get; set; }
    }

    public class Schema418
    {
        public bool nullable { get; set; }
        public Oneof54[] oneOf { get; set; }
    }

    public class Oneof54
    {
        public string _ref { get; set; }
    }

    public class Parameter162
    {
        public string name { get; set; }
        public string _in { get; set; }
        public bool required { get; set; }
        public Schema419 schema { get; set; }
        public string description { get; set; }
    }

    public class Schema419
    {
        public string type { get; set; }
        public string format { get; set; }
        public bool nullable { get; set; }
    }

    public class ApiProductchoicebatchesKeyReprocess
    {
        public Post57 post { get; set; }
    }

    public class Post57
    {
        public string[] tags { get; set; }
        public string summary { get; set; }
        public string operationId { get; set; }
        public Parameter163[] parameters { get; set; }
        public Responses182 responses { get; set; }
        public string[] xroles { get; set; }
    }

    public class Responses182
    {
        public _200182 _200 { get; set; }
    }

    public class _200182
    {
        public string description { get; set; }
        public Content257 content { get; set; }
    }

    public class Content257
    {
        public ApplicationJson256 applicationjson { get; set; }
    }

    public class ApplicationJson256
    {
        public Schema420 schema { get; set; }
    }

    public class Schema420
    {
        public string type { get; set; }
    }

    public class Parameter163
    {
        public string name { get; set; }
        public string _in { get; set; }
        public bool required { get; set; }
        public Schema421 schema { get; set; }
        public string description { get; set; }
    }

    public class Schema421
    {
        public string type { get; set; }
        public string format { get; set; }
        public bool nullable { get; set; }
    }

    public class ApiOrgunitauthenticators
    {
        public Get77 get { get; set; }
        public Post58 post { get; set; }
    }

    public class Get77
    {
        public string[] tags { get; set; }
        public string operationId { get; set; }
        public Parameter164[] parameters { get; set; }
        public Responses183 responses { get; set; }
        public string[] xroles { get; set; }
    }

    public class Responses183
    {
        public _200183 _200 { get; set; }
    }

    public class _200183
    {
        public string description { get; set; }
        public Content258 content { get; set; }
    }

    public class Content258
    {
        public ApplicationJson257 applicationjson { get; set; }
    }

    public class ApplicationJson257
    {
        public Schema422 schema { get; set; }
    }

    public class Schema422
    {
        public string type { get; set; }
        public bool nullable { get; set; }
        public Items46 items { get; set; }
    }

    public class Items46
    {
        public string _ref { get; set; }
    }

    public class Parameter164
    {
        public string name { get; set; }
        public string _in { get; set; }
        public string description { get; set; }
        public Schema423 schema { get; set; }
    }

    public class Schema423
    {
        public string type { get; set; }
        public bool nullable { get; set; }
        public string format { get; set; }
    }

    public class Post58
    {
        public string[] tags { get; set; }
        public string operationId { get; set; }
        public Requestbody75 requestBody { get; set; }
        public Responses184 responses { get; set; }
        public string[] xroles { get; set; }
    }

    public class Requestbody75
    {
        public string xname { get; set; }
        public Content259 content { get; set; }
        public bool required { get; set; }
    }

    public class Content259
    {
        public ApplicationJson258 applicationjson { get; set; }
    }

    public class ApplicationJson258
    {
        public Schema424 schema { get; set; }
    }

    public class Schema424
    {
        public string _ref { get; set; }
    }

    public class Responses184
    {
        public _200184 _200 { get; set; }
    }

    public class _200184
    {
        public string description { get; set; }
        public Content260 content { get; set; }
    }

    public class Content260
    {
        public ApplicationJson259 applicationjson { get; set; }
    }

    public class ApplicationJson259
    {
        public Schema425 schema { get; set; }
    }

    public class Schema425
    {
        public string type { get; set; }
    }

    public class ApiOrgunitauthenticatorsKey
    {
        public Get78 get { get; set; }
        public Patch20 patch { get; set; }
        public Delete22 delete { get; set; }
    }

    public class Get78
    {
        public string[] tags { get; set; }
        public string operationId { get; set; }
        public Parameter165[] parameters { get; set; }
        public Responses185 responses { get; set; }
        public string[] xroles { get; set; }
    }

    public class Responses185
    {
        public _200185 _200 { get; set; }
    }

    public class _200185
    {
        public string description { get; set; }
        public Content261 content { get; set; }
    }

    public class Content261
    {
        public ApplicationJson260 applicationjson { get; set; }
    }

    public class ApplicationJson260
    {
        public Schema426 schema { get; set; }
    }

    public class Schema426
    {
        public bool nullable { get; set; }
        public Oneof55[] oneOf { get; set; }
    }

    public class Oneof55
    {
        public string _ref { get; set; }
    }

    public class Parameter165
    {
        public string name { get; set; }
        public string _in { get; set; }
        public bool required { get; set; }
        public Schema427 schema { get; set; }
        public string description { get; set; }
    }

    public class Schema427
    {
        public string type { get; set; }
        public string format { get; set; }
        public bool nullable { get; set; }
    }

    public class Patch20
    {
        public string[] tags { get; set; }
        public string operationId { get; set; }
        public Parameter166[] parameters { get; set; }
        public Requestbody76 requestBody { get; set; }
        public Responses186 responses { get; set; }
        public string[] xroles { get; set; }
    }

    public class Requestbody76
    {
        public string xname { get; set; }
        public Content262 content { get; set; }
        public bool required { get; set; }
    }

    public class Content262
    {
        public ApplicationJson261 applicationjson { get; set; }
    }

    public class ApplicationJson261
    {
        public Schema428 schema { get; set; }
    }

    public class Schema428
    {
        public string _ref { get; set; }
    }

    public class Responses186
    {
        public _200186 _200 { get; set; }
    }

    public class _200186
    {
        public string description { get; set; }
        public Content263 content { get; set; }
    }

    public class Content263
    {
        public ApplicationJson262 applicationjson { get; set; }
    }

    public class ApplicationJson262
    {
        public Schema429 schema { get; set; }
    }

    public class Schema429
    {
        public string type { get; set; }
    }

    public class Parameter166
    {
        public string name { get; set; }
        public string _in { get; set; }
        public bool required { get; set; }
        public Schema430 schema { get; set; }
    }

    public class Schema430
    {
        public string type { get; set; }
        public string format { get; set; }
    }

    public class Delete22
    {
        public string[] tags { get; set; }
        public string operationId { get; set; }
        public Parameter167[] parameters { get; set; }
        public Responses187 responses { get; set; }
        public string[] xroles { get; set; }
    }

    public class Responses187
    {
        public _200187 _200 { get; set; }
    }

    public class _200187
    {
        public string description { get; set; }
        public Content264 content { get; set; }
    }

    public class Content264
    {
        public ApplicationJson263 applicationjson { get; set; }
    }

    public class ApplicationJson263
    {
        public Schema431 schema { get; set; }
    }

    public class Schema431
    {
        public string type { get; set; }
    }

    public class Parameter167
    {
        public string name { get; set; }
        public string _in { get; set; }
        public bool required { get; set; }
        public Schema432 schema { get; set; }
    }

    public class Schema432
    {
        public string type { get; set; }
        public string format { get; set; }
    }

    public class ApiApplicationconfigurations
    {
        public Get79 get { get; set; }
    }

    public class Get79
    {
        public string[] tags { get; set; }
        public string operationId { get; set; }
        public Parameter168[] parameters { get; set; }
        public Responses188 responses { get; set; }
        public string[] xroles { get; set; }
    }

    public class Responses188
    {
        public _200188 _200 { get; set; }
    }

    public class _200188
    {
        public string description { get; set; }
        public Content265 content { get; set; }
    }

    public class Content265
    {
        public ApplicationJson264 applicationjson { get; set; }
    }

    public class ApplicationJson264
    {
        public Schema433 schema { get; set; }
    }

    public class Schema433
    {
        public string type { get; set; }
        public bool nullable { get; set; }
        public Items47 items { get; set; }
    }

    public class Items47
    {
        public string _ref { get; set; }
    }

    public class Parameter168
    {
        public string name { get; set; }
        public string _in { get; set; }
        public string description { get; set; }
        public Schema434 schema { get; set; }
    }

    public class Schema434
    {
        public string type { get; set; }
        public bool nullable { get; set; }
        public string format { get; set; }
    }

    public class ApiApplicationconfigurationsKey
    {
        public Get80 get { get; set; }
        public Patch21 patch { get; set; }
    }

    public class Get80
    {
        public string[] tags { get; set; }
        public string operationId { get; set; }
        public Parameter169[] parameters { get; set; }
        public Responses189 responses { get; set; }
        public string[] xroles { get; set; }
    }

    public class Responses189
    {
        public _200189 _200 { get; set; }
    }

    public class _200189
    {
        public string description { get; set; }
        public Content266 content { get; set; }
    }

    public class Content266
    {
        public ApplicationJson265 applicationjson { get; set; }
    }

    public class ApplicationJson265
    {
        public Schema435 schema { get; set; }
    }

    public class Schema435
    {
        public bool nullable { get; set; }
        public Oneof56[] oneOf { get; set; }
    }

    public class Oneof56
    {
        public string _ref { get; set; }
    }

    public class Parameter169
    {
        public string name { get; set; }
        public string _in { get; set; }
        public bool required { get; set; }
        public Schema436 schema { get; set; }
        public string description { get; set; }
    }

    public class Schema436
    {
        public string type { get; set; }
        public string format { get; set; }
        public bool nullable { get; set; }
    }

    public class Patch21
    {
        public string[] tags { get; set; }
        public string operationId { get; set; }
        public Parameter170[] parameters { get; set; }
        public Requestbody77 requestBody { get; set; }
        public Responses190 responses { get; set; }
        public string[] xroles { get; set; }
    }

    public class Requestbody77
    {
        public string xname { get; set; }
        public Content267 content { get; set; }
        public bool required { get; set; }
    }

    public class Content267
    {
        public ApplicationJson266 applicationjson { get; set; }
    }

    public class ApplicationJson266
    {
        public Schema437 schema { get; set; }
    }

    public class Schema437
    {
        public string _ref { get; set; }
    }

    public class Responses190
    {
        public _200190 _200 { get; set; }
    }

    public class _200190
    {
        public string description { get; set; }
        public Content268 content { get; set; }
    }

    public class Content268
    {
        public ApplicationJson267 applicationjson { get; set; }
    }

    public class ApplicationJson267
    {
        public Schema438 schema { get; set; }
    }

    public class Schema438
    {
        public string type { get; set; }
    }

    public class Parameter170
    {
        public string name { get; set; }
        public string _in { get; set; }
        public bool required { get; set; }
        public Schema439 schema { get; set; }
    }

    public class Schema439
    {
        public string type { get; set; }
        public string format { get; set; }
    }

    public class ApiEmployeedatamodifications
    {
        public Get81 get { get; set; }
    }

    public class Get81
    {
        public string[] tags { get; set; }
        public string operationId { get; set; }
        public Parameter171[] parameters { get; set; }
        public Responses191 responses { get; set; }
        public string[] xroles { get; set; }
    }

    public class Responses191
    {
        public _200191 _200 { get; set; }
    }

    public class _200191
    {
        public string description { get; set; }
        public Content269 content { get; set; }
    }

    public class Content269
    {
        public ApplicationJson268 applicationjson { get; set; }
    }

    public class ApplicationJson268
    {
        public Schema440 schema { get; set; }
    }

    public class Schema440
    {
        public string type { get; set; }
        public bool nullable { get; set; }
        public Items48 items { get; set; }
    }

    public class Items48
    {
        public string _ref { get; set; }
    }

    public class Parameter171
    {
        public string name { get; set; }
        public string _in { get; set; }
        public string description { get; set; }
        public Schema441 schema { get; set; }
    }

    public class Schema441
    {
        public string type { get; set; }
        public bool nullable { get; set; }
        public string format { get; set; }
    }

    public class ApiEmployeedatamodificationsKey
    {
        public Get82 get { get; set; }
    }

    public class Get82
    {
        public string[] tags { get; set; }
        public string operationId { get; set; }
        public Parameter172[] parameters { get; set; }
        public Responses192 responses { get; set; }
        public string[] xroles { get; set; }
    }

    public class Responses192
    {
        public _200192 _200 { get; set; }
    }

    public class _200192
    {
        public string description { get; set; }
        public Content270 content { get; set; }
    }

    public class Content270
    {
        public ApplicationJson269 applicationjson { get; set; }
    }

    public class ApplicationJson269
    {
        public Schema442 schema { get; set; }
    }

    public class Schema442
    {
        public bool nullable { get; set; }
        public Oneof57[] oneOf { get; set; }
    }

    public class Oneof57
    {
        public string _ref { get; set; }
    }

    public class Parameter172
    {
        public string name { get; set; }
        public string _in { get; set; }
        public bool required { get; set; }
        public Schema443 schema { get; set; }
        public string description { get; set; }
    }

    public class Schema443
    {
        public string type { get; set; }
        public string format { get; set; }
        public bool nullable { get; set; }
    }

    public class ApiEmployeedatamodificationsKeyModify
    {
        public Post59 post { get; set; }
    }

    public class Post59
    {
        public string[] tags { get; set; }
        public string operationId { get; set; }
        public Parameter173[] parameters { get; set; }
        public Requestbody78 requestBody { get; set; }
        public Responses193 responses { get; set; }
        public string[] xroles { get; set; }
    }

    public class Requestbody78
    {
        public string xname { get; set; }
        public Content271 content { get; set; }
        public bool required { get; set; }
    }

    public class Content271
    {
        public ApplicationJson270 applicationjson { get; set; }
    }

    public class ApplicationJson270
    {
        public Schema444 schema { get; set; }
    }

    public class Schema444
    {
        public string _ref { get; set; }
    }

    public class Responses193
    {
        public _200193 _200 { get; set; }
    }

    public class _200193
    {
        public string description { get; set; }
        public Content272 content { get; set; }
    }

    public class Content272
    {
        public ApplicationJson271 applicationjson { get; set; }
    }

    public class ApplicationJson271
    {
        public Schema445 schema { get; set; }
    }

    public class Schema445
    {
        public bool nullable { get; set; }
        public Oneof58[] oneOf { get; set; }
    }

    public class Oneof58
    {
        public string _ref { get; set; }
    }

    public class Parameter173
    {
        public string name { get; set; }
        public string _in { get; set; }
        public bool required { get; set; }
        public Schema446 schema { get; set; }
        public string description { get; set; }
    }

    public class Schema446
    {
        public string type { get; set; }
        public string format { get; set; }
        public bool nullable { get; set; }
    }

    public class ApiEmployeedatamodificationsKeyReject
    {
        public Post60 post { get; set; }
    }

    public class Post60
    {
        public string[] tags { get; set; }
        public string operationId { get; set; }
        public Parameter174[] parameters { get; set; }
        public Requestbody79 requestBody { get; set; }
        public Responses194 responses { get; set; }
        public string[] xroles { get; set; }
    }

    public class Requestbody79
    {
        public string xname { get; set; }
        public Content273 content { get; set; }
        public bool required { get; set; }
    }

    public class Content273
    {
        public ApplicationJson272 applicationjson { get; set; }
    }

    public class ApplicationJson272
    {
        public Schema447 schema { get; set; }
    }

    public class Schema447
    {
        public string _ref { get; set; }
    }

    public class Responses194
    {
        public _200194 _200 { get; set; }
    }

    public class _200194
    {
        public string description { get; set; }
        public Content274 content { get; set; }
    }

    public class Content274
    {
        public ApplicationJson273 applicationjson { get; set; }
    }

    public class ApplicationJson273
    {
        public Schema448 schema { get; set; }
    }

    public class Schema448
    {
        public bool nullable { get; set; }
        public Oneof59[] oneOf { get; set; }
    }

    public class Oneof59
    {
        public string _ref { get; set; }
    }

    public class Parameter174
    {
        public string name { get; set; }
        public string _in { get; set; }
        public bool required { get; set; }
        public Schema449 schema { get; set; }
        public string description { get; set; }
    }

    public class Schema449
    {
        public string type { get; set; }
        public string format { get; set; }
        public bool nullable { get; set; }
    }

    public class ApiEmployeedatamodificationsKeyApprove
    {
        public Post61 post { get; set; }
    }

    public class Post61
    {
        public string[] tags { get; set; }
        public string operationId { get; set; }
        public Parameter175[] parameters { get; set; }
        public Requestbody80 requestBody { get; set; }
        public Responses195 responses { get; set; }
        public string[] xroles { get; set; }
    }

    public class Requestbody80
    {
        public string xname { get; set; }
        public Content275 content { get; set; }
        public bool required { get; set; }
    }

    public class Content275
    {
        public ApplicationJson274 applicationjson { get; set; }
    }

    public class ApplicationJson274
    {
        public Schema450 schema { get; set; }
    }

    public class Schema450
    {
        public string _ref { get; set; }
    }

    public class Responses195
    {
        public _200195 _200 { get; set; }
    }

    public class _200195
    {
        public string description { get; set; }
        public Content276 content { get; set; }
    }

    public class Content276
    {
        public ApplicationJson275 applicationjson { get; set; }
    }

    public class ApplicationJson275
    {
        public Schema451 schema { get; set; }
    }

    public class Schema451
    {
        public bool nullable { get; set; }
        public Oneof60[] oneOf { get; set; }
    }

    public class Oneof60
    {
        public string _ref { get; set; }
    }

    public class Parameter175
    {
        public string name { get; set; }
        public string _in { get; set; }
        public bool required { get; set; }
        public Schema452 schema { get; set; }
        public string description { get; set; }
    }

    public class Schema452
    {
        public string type { get; set; }
        public string format { get; set; }
        public bool nullable { get; set; }
    }

    public class ApiEmployeedatamodificationsKeyReprocess
    {
        public Post62 post { get; set; }
    }

    public class Post62
    {
        public string[] tags { get; set; }
        public string summary { get; set; }
        public string operationId { get; set; }
        public Parameter176[] parameters { get; set; }
        public Responses196 responses { get; set; }
        public string[] xroles { get; set; }
    }

    public class Responses196
    {
        public _200196 _200 { get; set; }
    }

    public class _200196
    {
        public string description { get; set; }
        public Content277 content { get; set; }
    }

    public class Content277
    {
        public ApplicationJson276 applicationjson { get; set; }
    }

    public class ApplicationJson276
    {
        public Schema453 schema { get; set; }
    }

    public class Schema453
    {
        public string type { get; set; }
    }

    public class Parameter176
    {
        public string name { get; set; }
        public string _in { get; set; }
        public bool required { get; set; }
        public Schema454 schema { get; set; }
        public string description { get; set; }
    }

    public class Schema454
    {
        public string type { get; set; }
        public string format { get; set; }
        public bool nullable { get; set; }
    }

    public class ApiProductimportspecifications
    {
        public Get83 get { get; set; }
        public Post63 post { get; set; }
    }

    public class Get83
    {
        public string[] tags { get; set; }
        public string operationId { get; set; }
        public Parameter177[] parameters { get; set; }
        public Responses197 responses { get; set; }
        public string[] xroles { get; set; }
    }

    public class Responses197
    {
        public _200197 _200 { get; set; }
    }

    public class _200197
    {
        public string description { get; set; }
        public Content278 content { get; set; }
    }

    public class Content278
    {
        public ApplicationJson277 applicationjson { get; set; }
    }

    public class ApplicationJson277
    {
        public Schema455 schema { get; set; }
    }

    public class Schema455
    {
        public string type { get; set; }
        public bool nullable { get; set; }
        public Items49 items { get; set; }
    }

    public class Items49
    {
        public string _ref { get; set; }
    }

    public class Parameter177
    {
        public string name { get; set; }
        public string _in { get; set; }
        public string description { get; set; }
        public Schema456 schema { get; set; }
    }

    public class Schema456
    {
        public string type { get; set; }
        public bool nullable { get; set; }
        public string format { get; set; }
    }

    public class Post63
    {
        public string[] tags { get; set; }
        public string operationId { get; set; }
        public Requestbody81 requestBody { get; set; }
        public Responses198 responses { get; set; }
        public string[] xroles { get; set; }
    }

    public class Requestbody81
    {
        public string xname { get; set; }
        public Content279 content { get; set; }
        public bool required { get; set; }
    }

    public class Content279
    {
        public ApplicationJson278 applicationjson { get; set; }
    }

    public class ApplicationJson278
    {
        public Schema457 schema { get; set; }
    }

    public class Schema457
    {
        public string _ref { get; set; }
    }

    public class Responses198
    {
        public _200198 _200 { get; set; }
    }

    public class _200198
    {
        public string description { get; set; }
        public Content280 content { get; set; }
    }

    public class Content280
    {
        public ApplicationJson279 applicationjson { get; set; }
    }

    public class ApplicationJson279
    {
        public Schema458 schema { get; set; }
    }

    public class Schema458
    {
        public string type { get; set; }
    }

    public class ApiProductimportspecificationsKey
    {
        public Get84 get { get; set; }
        public Patch22 patch { get; set; }
        public Delete23 delete { get; set; }
    }

    public class Get84
    {
        public string[] tags { get; set; }
        public string operationId { get; set; }
        public Parameter178[] parameters { get; set; }
        public Responses199 responses { get; set; }
        public string[] xroles { get; set; }
    }

    public class Responses199
    {
        public _200199 _200 { get; set; }
    }

    public class _200199
    {
        public string description { get; set; }
        public Content281 content { get; set; }
    }

    public class Content281
    {
        public ApplicationJson280 applicationjson { get; set; }
    }

    public class ApplicationJson280
    {
        public Schema459 schema { get; set; }
    }

    public class Schema459
    {
        public bool nullable { get; set; }
        public Oneof61[] oneOf { get; set; }
    }

    public class Oneof61
    {
        public string _ref { get; set; }
    }

    public class Parameter178
    {
        public string name { get; set; }
        public string _in { get; set; }
        public bool required { get; set; }
        public Schema460 schema { get; set; }
        public string description { get; set; }
    }

    public class Schema460
    {
        public string type { get; set; }
        public string format { get; set; }
        public bool nullable { get; set; }
    }

    public class Patch22
    {
        public string[] tags { get; set; }
        public string operationId { get; set; }
        public Parameter179[] parameters { get; set; }
        public Requestbody82 requestBody { get; set; }
        public Responses200 responses { get; set; }
        public string[] xroles { get; set; }
    }

    public class Requestbody82
    {
        public string xname { get; set; }
        public Content282 content { get; set; }
        public bool required { get; set; }
    }

    public class Content282
    {
        public ApplicationJson281 applicationjson { get; set; }
    }

    public class ApplicationJson281
    {
        public Schema461 schema { get; set; }
    }

    public class Schema461
    {
        public string _ref { get; set; }
    }

    public class Responses200
    {
        public _200200 _200 { get; set; }
    }

    public class _200200
    {
        public string description { get; set; }
        public Content283 content { get; set; }
    }

    public class Content283
    {
        public ApplicationJson282 applicationjson { get; set; }
    }

    public class ApplicationJson282
    {
        public Schema462 schema { get; set; }
    }

    public class Schema462
    {
        public string type { get; set; }
    }

    public class Parameter179
    {
        public string name { get; set; }
        public string _in { get; set; }
        public bool required { get; set; }
        public Schema463 schema { get; set; }
    }

    public class Schema463
    {
        public string type { get; set; }
        public string format { get; set; }
    }

    public class Delete23
    {
        public string[] tags { get; set; }
        public string operationId { get; set; }
        public Parameter180[] parameters { get; set; }
        public Responses201 responses { get; set; }
        public string[] xroles { get; set; }
    }

    public class Responses201
    {
        public _200201 _200 { get; set; }
    }

    public class _200201
    {
        public string description { get; set; }
        public Content284 content { get; set; }
    }

    public class Content284
    {
        public ApplicationJson283 applicationjson { get; set; }
    }

    public class ApplicationJson283
    {
        public Schema464 schema { get; set; }
    }

    public class Schema464
    {
        public string type { get; set; }
    }

    public class Parameter180
    {
        public string name { get; set; }
        public string _in { get; set; }
        public bool required { get; set; }
        public Schema465 schema { get; set; }
    }

    public class Schema465
    {
        public string type { get; set; }
        public string format { get; set; }
    }

    public class ApiProductimportspecificationsKeyImportfile
    {
        public Post64 post { get; set; }
    }

    public class Post64
    {
        public string[] tags { get; set; }
        public string summary { get; set; }
        public string operationId { get; set; }
        public Parameter181[] parameters { get; set; }
        public Requestbody83 requestBody { get; set; }
        public Responses202 responses { get; set; }
        public string[] xroles { get; set; }
    }

    public class Requestbody83
    {
        public Content285 content { get; set; }
    }

    public class Content285
    {
        public MultipartFormData1 multipartformdata { get; set; }
    }

    public class MultipartFormData1
    {
        public Schema466 schema { get; set; }
    }

    public class Schema466
    {
        public string type { get; set; }
        public string description { get; set; }
        public Properties1 properties { get; set; }
    }

    public class Properties1
    {
        public File1 file { get; set; }
    }

    public class File1
    {
        public string type { get; set; }
        public string format { get; set; }
    }

    public class Responses202
    {
        public _200202 _200 { get; set; }
    }

    public class _200202
    {
        public string description { get; set; }
        public Content286 content { get; set; }
    }

    public class Content286
    {
        public ApplicationJson284 applicationjson { get; set; }
    }

    public class ApplicationJson284
    {
        public Schema467 schema { get; set; }
    }

    public class Schema467
    {
        public bool nullable { get; set; }
        public Oneof62[] oneOf { get; set; }
    }

    public class Oneof62
    {
        public string _ref { get; set; }
    }

    public class Parameter181
    {
        public string name { get; set; }
        public string _in { get; set; }
        public bool required { get; set; }
        public Schema468 schema { get; set; }
        public string description { get; set; }
    }

    public class Schema468
    {
        public string type { get; set; }
        public string format { get; set; }
        public bool nullable { get; set; }
    }

    public class ApiEmployeesIdTransactions
    {
        public Get85 get { get; set; }
    }

    public class Get85
    {
        public string[] tags { get; set; }
        public string operationId { get; set; }
        public Parameter182[] parameters { get; set; }
        public Responses203 responses { get; set; }
        public string[] xroles { get; set; }
    }

    public class Responses203
    {
        public _200203 _200 { get; set; }
    }

    public class _200203
    {
        public string description { get; set; }
        public Content287 content { get; set; }
    }

    public class Content287
    {
        public ApplicationJson285 applicationjson { get; set; }
    }

    public class ApplicationJson285
    {
        public Schema469 schema { get; set; }
    }

    public class Schema469
    {
        public string type { get; set; }
        public bool nullable { get; set; }
        public Items50 items { get; set; }
    }

    public class Items50
    {
        public string _ref { get; set; }
    }

    public class Parameter182
    {
        public string name { get; set; }
        public string _in { get; set; }
        public bool required { get; set; }
        public Schema470 schema { get; set; }
        public string description { get; set; }
    }

    public class Schema470
    {
        public string type { get; set; }
        public string format { get; set; }
        public bool nullable { get; set; }
    }

    public class ApiEmployeesIdCurrenttotalbudgetbalance
    {
        public Get86 get { get; set; }
    }

    public class Get86
    {
        public string[] tags { get; set; }
        public string summary { get; set; }
        public string operationId { get; set; }
        public Parameter183[] parameters { get; set; }
        public Responses204 responses { get; set; }
        public string[] xroles { get; set; }
    }

    public class Responses204
    {
        public _200204 _200 { get; set; }
    }

    public class _200204
    {
        public string description { get; set; }
        public Content288 content { get; set; }
    }

    public class Content288
    {
        public ApplicationJson286 applicationjson { get; set; }
    }

    public class ApplicationJson286
    {
        public Schema471 schema { get; set; }
    }

    public class Schema471
    {
        public bool nullable { get; set; }
        public Oneof63[] oneOf { get; set; }
    }

    public class Oneof63
    {
        public string _ref { get; set; }
    }

    public class Parameter183
    {
        public string name { get; set; }
        public string _in { get; set; }
        public bool required { get; set; }
        public Schema472 schema { get; set; }
        public string description { get; set; }
    }

    public class Schema472
    {
        public string type { get; set; }
        public string format { get; set; }
        public bool nullable { get; set; }
    }

    public class ApiEmployeesIdProductspecifications
    {
        public Get87 get { get; set; }
    }

    public class Get87
    {
        public string[] tags { get; set; }
        public string operationId { get; set; }
        public Parameter184[] parameters { get; set; }
        public Responses205 responses { get; set; }
        public string[] xroles { get; set; }
    }

    public class Responses205
    {
        public _200205 _200 { get; set; }
    }

    public class _200205
    {
        public string description { get; set; }
        public Content289 content { get; set; }
    }

    public class Content289
    {
        public ApplicationJson287 applicationjson { get; set; }
    }

    public class ApplicationJson287
    {
        public Schema473 schema { get; set; }
    }

    public class Schema473
    {
        public string type { get; set; }
        public bool nullable { get; set; }
        public Items51 items { get; set; }
    }

    public class Items51
    {
        public string _ref { get; set; }
    }

    public class Parameter184
    {
        public string name { get; set; }
        public string _in { get; set; }
        public bool required { get; set; }
        public Schema474 schema { get; set; }
        public string description { get; set; }
    }

    public class Schema474
    {
        public string type { get; set; }
        public string format { get; set; }
        public bool nullable { get; set; }
    }

    public class ApiEmployeesIdCreatetransaction
    {
        public Post65 post { get; set; }
    }

    public class Post65
    {
        public string[] tags { get; set; }
        public string summary { get; set; }
        public string operationId { get; set; }
        public Parameter185[] parameters { get; set; }
        public Requestbody84 requestBody { get; set; }
        public Responses206 responses { get; set; }
        public string[] xroles { get; set; }
    }

    public class Requestbody84
    {
        public string xname { get; set; }
        public Content290 content { get; set; }
        public bool required { get; set; }
    }

    public class Content290
    {
        public ApplicationJson288 applicationjson { get; set; }
    }

    public class ApplicationJson288
    {
        public Schema475 schema { get; set; }
    }

    public class Schema475
    {
        public string _ref { get; set; }
    }

    public class Responses206
    {
        public _200206 _200 { get; set; }
    }

    public class _200206
    {
        public string description { get; set; }
        public Content291 content { get; set; }
    }

    public class Content291
    {
        public ApplicationJson289 applicationjson { get; set; }
    }

    public class ApplicationJson289
    {
        public Schema476 schema { get; set; }
    }

    public class Schema476
    {
        public bool nullable { get; set; }
        public Oneof64[] oneOf { get; set; }
    }

    public class Oneof64
    {
        public string _ref { get; set; }
    }

    public class Parameter185
    {
        public string name { get; set; }
        public string _in { get; set; }
        public bool required { get; set; }
        public Schema477 schema { get; set; }
        public string description { get; set; }
    }

    public class Schema477
    {
        public string type { get; set; }
        public string format { get; set; }
        public bool nullable { get; set; }
    }

    public class ApiEnumerationvaluesEnumtypeEnumtype
    {
        public Get88 get { get; set; }
    }

    public class Get88
    {
        public string[] tags { get; set; }
        public string operationId { get; set; }
        public Parameter186[] parameters { get; set; }
        public Responses207 responses { get; set; }
        public string[] xroles { get; set; }
    }

    public class Responses207
    {
        public _200207 _200 { get; set; }
    }

    public class _200207
    {
        public string description { get; set; }
        public Content292 content { get; set; }
    }

    public class Content292
    {
        public ApplicationJson290 applicationjson { get; set; }
    }

    public class ApplicationJson290
    {
        public Schema478 schema { get; set; }
    }

    public class Schema478
    {
        public string type { get; set; }
        public bool nullable { get; set; }
        public Items52 items { get; set; }
    }

    public class Items52
    {
        public string _ref { get; set; }
    }

    public class Parameter186
    {
        public string name { get; set; }
        public string _in { get; set; }
        public bool required { get; set; }
        public Schema479 schema { get; set; }
        public string description { get; set; }
    }

    public class Schema479
    {
        public string type { get; set; }
        public bool nullable { get; set; }
        public string format { get; set; }
    }

    public class ApiUnsubscribe
    {
        public Post66 post { get; set; }
    }

    public class Post66
    {
        public string[] tags { get; set; }
        public string operationId { get; set; }
        public Parameter187[] parameters { get; set; }
        public Requestbody85 requestBody { get; set; }
        public Responses208 responses { get; set; }
        public object[] xroles { get; set; }
    }

    public class Requestbody85
    {
        public string xname { get; set; }
        public Content293 content { get; set; }
        public bool required { get; set; }
    }

    public class Content293
    {
        public ApplicationJson291 applicationjson { get; set; }
    }

    public class ApplicationJson291
    {
        public Schema480 schema { get; set; }
    }

    public class Schema480
    {
        public string _ref { get; set; }
    }

    public class Responses208
    {
        public _200208 _200 { get; set; }
    }

    public class _200208
    {
        public string description { get; set; }
        public Content294 content { get; set; }
    }

    public class Content294
    {
        public ApplicationJson292 applicationjson { get; set; }
    }

    public class ApplicationJson292
    {
        public Schema481 schema { get; set; }
    }

    public class Schema481
    {
        public string type { get; set; }
    }

    public class Parameter187
    {
        public string name { get; set; }
        public string _in { get; set; }
        public string description { get; set; }
        public Schema482 schema { get; set; }
    }

    public class Schema482
    {
        public string type { get; set; }
        public bool nullable { get; set; }
    }

    public class ApiProductspecificationsRuntest
    {
        public Post67 post { get; set; }
    }

    public class Post67
    {
        public string[] tags { get; set; }
        public string operationId { get; set; }
        public Parameter188[] parameters { get; set; }
        public Requestbody86 requestBody { get; set; }
        public Responses209 responses { get; set; }
        public string[] xroles { get; set; }
    }

    public class Requestbody86
    {
        public string xname { get; set; }
        public Content295 content { get; set; }
        public bool required { get; set; }
    }

    public class Content295
    {
        public ApplicationJson293 applicationjson { get; set; }
    }

    public class ApplicationJson293
    {
        public Schema483 schema { get; set; }
    }

    public class Schema483
    {
        public string _ref { get; set; }
    }

    public class Responses209
    {
        public _200209 _200 { get; set; }
    }

    public class _200209
    {
        public string description { get; set; }
        public Content296 content { get; set; }
    }

    public class Content296
    {
        public ApplicationJson294 applicationjson { get; set; }
    }

    public class ApplicationJson294
    {
        public Schema484 schema { get; set; }
    }

    public class Schema484
    {
        public bool nullable { get; set; }
        public Oneof65[] oneOf { get; set; }
    }

    public class Oneof65
    {
        public string _ref { get; set; }
    }

    public class Parameter188
    {
        public string name { get; set; }
        public string _in { get; set; }
        public string description { get; set; }
        public Schema485 schema { get; set; }
    }

    public class Schema485
    {
        public string type { get; set; }
        public bool nullable { get; set; }
    }

    public class ApiProductspecificationsGenerate
    {
        public Post68 post { get; set; }
    }

    public class Post68
    {
        public string[] tags { get; set; }
        public string operationId { get; set; }
        public Parameter189[] parameters { get; set; }
        public Requestbody87 requestBody { get; set; }
        public Responses210 responses { get; set; }
        public string[] xroles { get; set; }
    }

    public class Requestbody87
    {
        public string xname { get; set; }
        public Content297 content { get; set; }
        public bool required { get; set; }
    }

    public class Content297
    {
        public ApplicationJson295 applicationjson { get; set; }
    }

    public class ApplicationJson295
    {
        public Schema486 schema { get; set; }
    }

    public class Schema486
    {
        public string _ref { get; set; }
    }

    public class Responses210
    {
        public _200210 _200 { get; set; }
    }

    public class _200210
    {
        public string description { get; set; }
        public Content298 content { get; set; }
    }

    public class Content298
    {
        public ApplicationJson296 applicationjson { get; set; }
    }

    public class ApplicationJson296
    {
        public Schema487 schema { get; set; }
    }

    public class Schema487
    {
        public string type { get; set; }
    }

    public class Parameter189
    {
        public string name { get; set; }
        public string _in { get; set; }
        public string description { get; set; }
        public Schema488 schema { get; set; }
    }

    public class Schema488
    {
        public string type { get; set; }
        public bool nullable { get; set; }
    }

    public class ApiEmployeesKeyCreatemodification
    {
        public Post69 post { get; set; }
    }

    public class Post69
    {
        public string[] tags { get; set; }
        public string summary { get; set; }
        public string operationId { get; set; }
        public Parameter190[] parameters { get; set; }
        public Responses211 responses { get; set; }
        public string[] xroles { get; set; }
    }

    public class Responses211
    {
        public _200211 _200 { get; set; }
    }

    public class _200211
    {
        public string description { get; set; }
        public Content299 content { get; set; }
    }

    public class Content299
    {
        public ApplicationJson297 applicationjson { get; set; }
    }

    public class ApplicationJson297
    {
        public Schema489 schema { get; set; }
    }

    public class Schema489
    {
        public bool nullable { get; set; }
        public Oneof66[] oneOf { get; set; }
    }

    public class Oneof66
    {
        public string _ref { get; set; }
    }

    public class Parameter190
    {
        public string name { get; set; }
        public string _in { get; set; }
        public bool required { get; set; }
        public Schema490 schema { get; set; }
        public string description { get; set; }
    }

    public class Schema490
    {
        public string type { get; set; }
        public string format { get; set; }
        public bool nullable { get; set; }
    }

    public class Components
    {
        public Schemas schemas { get; set; }
        public Securityschemes securitySchemes { get; set; }
    }

    public class Schemas
    {
        public Tag Tag { get; set; }
        public Taggedcontentitem TaggedContentItem { get; set; }
        public Surveyresponse SurveyResponse { get; set; }
        public Profile1 Profile { get; set; }
        public Employee1 Employee { get; set; }
        public User1 User { get; set; }
        public Orgunit2 OrgUnit { get; set; }
        public Status1 Status { get; set; }
        public Operationmode1 OperationMode { get; set; }
        public Useractivationflow1 UserActivationFlow { get; set; }
        public Importtype ImportType { get; set; }
        public Employerperiodtype1 EmployerPeriodType { get; set; }
        public Ikbsubscriptiontype1 IkbSubscriptionType { get; set; }
        public Termsofservicerequirements1 TermsOfServiceRequirements { get; set; }
        public Shoppricedisplaypolicy1 ShopPriceDisplayPolicy { get; set; }
        public Shoptaxationpolicy1 ShopTaxationPolicy { get; set; }
        public Cao1 Cao { get; set; }
        public Orgunitconfiguration OrgUnitConfiguration { get; set; }
        public Employeeimport EmployeeImport { get; set; }
        public Activationletterfile1 ActivationLetterFile { get; set; }
        public File2 File { get; set; }
        public Employeeimportfile1 EmployeeImportFile { get; set; }
        public Employeeimportmiddlewarefile1 EmployeeImportMiddlewareFile { get; set; }
        public Tracktracecode1 TrackTraceCode { get; set; }
        public Tracktracemessage TrackTraceMessage { get; set; }
        public Tracktraceloglevel TrackTraceLogLevel { get; set; }
        public Importstatus ImportStatus { get; set; }
        public Orgunitfunctiongroupmapping OrgUnitFunctionGroupMapping { get; set; }
        public Functiongroup2 FunctionGroup { get; set; }
        public Productgroup ProductGroup { get; set; }
        public Catalog Catalog { get; set; }
        public Catalogsubscription CatalogSubscription { get; set; }
        public Product Product { get; set; }
        public Productcategory1 ProductCategory { get; set; }
        public Productsupplier1 ProductSupplier { get; set; }
        public Productimportdocument1 ProductImportDocument { get; set; }
        public Importsource1 ImportSource { get; set; }
        public Importformat1 ImportFormat { get; set; }
        public Programcost ProgramCost { get; set; }
        public Costtype1 CostType { get; set; }
        public Costtypevalue1 CostTypeValue { get; set; }
        public Discountrule DiscountRule { get; set; }
        public Discountcalculationmethod DiscountCalculationMethod { get; set; }
        public Monetaryquantity MonetaryQuantity { get; set; }
        public Productimportspecification ProductImportSpecification { get; set; }
        public Productgrouptype1 ProductGroupType { get; set; }
        public Taxationindication1 TaxationIndication { get; set; }
        public Orgunitbudget OrgUnitBudget { get; set; }
        public Employeebudget EmployeeBudget { get; set; }
        public Transaction Transaction { get; set; }
        public Transactionstate TransactionState { get; set; }
        public Transactionstatus TransactionStatus { get; set; }
        public Productcostcomponent1 ProductCostComponent { get; set; }
        public Productcost ProductCost { get; set; }
        public Costtypecomponent CostTypeComponent { get; set; }
        public Pricespecification2 PriceSpecification { get; set; }
        public Pricingspecification1 PricingSpecification { get; set; }
        public Transactionrating TransactionRating { get; set; }
        public Budget Budget { get; set; }
        public Budgetadjustment BudgetAdjustment { get; set; }
        public Userrole UserRole { get; set; }
        public Identityuserroleofint64 IdentityUserRoleOfInt64 { get; set; }
        public Userclaim UserClaim { get; set; }
        public Identityuserclaimofint64 IdentityUserClaimOfInt64 { get; set; }
        public Userlogin UserLogin { get; set; }
        public Identityuserloginofint64 IdentityUserLoginOfInt64 { get; set; }
        public Identityuserofint64anduserloginanduserroleanduserclaim IdentityUserOfInt64AndUserLoginAndUserRoleAndUserClaim { get; set; }
        public Periodemployee PeriodEmployee { get; set; }
        public Gender1 Gender { get; set; }
        public Civilstatus1 CivilStatus { get; set; }
        public Iperiodemployee IPeriodEmployee { get; set; }
        public Employeefile EmployeeFile { get; set; }
        public Employeefiletype EmployeeFileType { get; set; }
        public Employeedatamodification EmployeeDataModification { get; set; }
        public Workflowstatus1 WorkflowStatus { get; set; }
        public Profile_Tag Profile_Tag { get; set; }
        public Taginclusion1 TagInclusion { get; set; }
        public Plan Plan { get; set; }
        public Plancomment PlanComment { get; set; }
        public Survey1 Survey { get; set; }
        public Singleresultoftag SingleResultOfTag { get; set; }
        public Singleresult SingleResult { get; set; }
        public Registerorgunitimpersonationparameters RegisterOrgUnitImpersonationParameters { get; set; }
        public Singleresultoffile SingleResultOfFile { get; set; }
        public Singleresultofplan SingleResultOfPlan { get; set; }
        public Role Role { get; set; }
        public Identityroleofint64anduserrole IdentityRoleOfInt64AndUserRole { get; set; }
        public Singleresultofrole SingleResultOfRole { get; set; }
        public Singleresultofuser SingleResultOfUser { get; set; }
        public Userpasswordreset UserPasswordReset { get; set; }
        public Setrolesparameters SetRolesParameters { get; set; }
        public Singleresultofsurvey SingleResultOfSurvey { get; set; }
        public Singleresultofcatalog SingleResultOfCatalog { get; set; }
        public Singleresultoforgunit SingleResultOfOrgUnit { get; set; }
        public Singleresultofproduct SingleResultOfProduct { get; set; }
        public Productrunspecification ProductRunSpecification { get; set; }
        public Bulkassignparameters BulkAssignParameters { get; set; }
        public Assignmentmethod1 AssignmentMethod { get; set; }
        public Singleresultofprofile SingleResultOfProfile { get; set; }
        public Deletetagparameters DeleteTagParameters { get; set; }
        public Excludetagparameters ExcludeTagParameters { get; set; }
        public Includetagparameters IncludeTagParameters { get; set; }
        public Profilebubblefilterviewmodel ProfileBubbleFilterViewModel { get; set; }
        public Singleresultofcosttype SingleResultOfCostType { get; set; }
        public Singleresultofemployee SingleResultOfEmployee { get; set; }
        public Notification Notification { get; set; }
        public Queuestatus1 QueueStatus { get; set; }
        public Notificationtype1 NotificationType { get; set; }
        public Singleresultofperiodemployee SingleResultOfPeriodEmployee { get; set; }
        public Bulkcreatenotificationsparameters BulkCreateNotificationsParameters { get; set; }
        public Marknotificationasreadparameters MarkNotificationAsReadParameters { get; set; }
        public Activation Activation { get; set; }
        public Activationflow1 ActivationFlow { get; set; }
        public Singleresultofactivation SingleResultOfActivation { get; set; }
        public Addmanagerparameters AddManagerParameters { get; set; }
        public Singleresultofplancomment SingleResultOfPlanComment { get; set; }
        public Singleresultoftransaction SingleResultOfTransaction { get; set; }
        public Odataactionparameters ODataActionParameters { get; set; }
        public Bulkrefundparameters BulkRefundParameters { get; set; }
        public Bulkrejectparameters BulkRejectParameters { get; set; }
        public Bulkapproveparameters BulkApproveParameters { get; set; }
        public Refundparameters RefundParameters { get; set; }
        public Rejectparameters RejectParameters { get; set; }
        public Approveparameters ApproveParameters { get; set; }
        public Confirmparameters ConfirmParameters { get; set; }
        public Rateproductparameters RateProductParameters { get; set; }
        public Singleresultofdiscountrule SingleResultOfDiscountRule { get; set; }
        public Bulkcopyparameters BulkCopyParameters { get; set; }
        public Bulkdeleteparameters BulkDeleteParameters { get; set; }
        public Singleresultofnotification SingleResultOfNotification { get; set; }
        public Orgunitreportmodel OrgUnitReportModel { get; set; }
        public Instanceinformation InstanceInformation { get; set; }
        public Instancetype1 InstanceType { get; set; }
        public Instanceinformationnotificationoptions InstanceInformationNotificationOptions { get; set; }
        public Instanceinformationmodeloptions InstanceInformationModelOptions { get; set; }
        public Csvspecification CsvSpecification { get; set; }
        public Appoptions AppOptions { get; set; }
        public Deployenvironment1 DeployEnvironment { get; set; }
        public Connectivityapioptions ConnectivityApiOptions { get; set; }
        public Swaggeroptions SwaggerOptions { get; set; }
        public Jobserviceoptions JobServiceOptions { get; set; }
        public Defaultcronexpressions1 DefaultCronExpressions { get; set; }
        public Notificationoptions1 NotificationOptions { get; set; }
        public Identityserveroptions IdentityServerOptions { get; set; }
        public Certificateloaderconfiguration CertificateLoaderConfiguration { get; set; }
        public Certificateloadertype CertificateLoaderType { get; set; }
        public Fileconfiguration FileConfiguration { get; set; }
        public Storeconfiguration StoreConfiguration { get; set; }
        public Storelocation StoreLocation { get; set; }
        public Storename StoreName { get; set; }
        public Identityclientoptions IdentityClientOptions { get; set; }
        public Oauthclientoptions OAuthClientOptions { get; set; }
        public Tasperoptions TasperOptions { get; set; }
        public Licenseoptions LicenseOptions { get; set; }
        public Zentityframeworkextensionsoptions ZEntityFrameworkExtensionsOptions { get; set; }
        public Modeloptions1 ModelOptions { get; set; }
        public Usermodeloptions UserModelOptions { get; set; }
        public Orgunitmodeloptions OrgUnitModelOptions { get; set; }
        public Employeemodeloptions EmployeeModelOptions { get; set; }
        public Loggingoptions LoggingOptions { get; set; }
        public Profileoptions ProfileOptions { get; set; }
        public Shopoptions ShopOptions { get; set; }
        public Singleresultofproductgroup SingleResultOfProductGroup { get; set; }
        public Singleresultoforgunitbudget SingleResultOfOrgUnitBudget { get; set; }
        public Adjustbudgetparameters AdjustBudgetParameters { get; set; }
        public Budgetadjustmenttype BudgetAdjustmentType { get; set; }
        public Prioritizeorgunitbudgetsparameters PrioritizeOrgUnitBudgetsParameters { get; set; }
        public Idpriority IdPriority { get; set; }
        public Singleresultofemployeebudget SingleResultOfEmployeeBudget { get; set; }
        public Adjustbudgetsparameters AdjustBudgetsParameters { get; set; }
        public Adjustbudgetparameters2 AdjustBudgetParameters2 { get; set; }
        public Singleresultofemployeeimport SingleResultOfEmployeeImport { get; set; }
        public Orgunitchannel OrgUnitChannel { get; set; }
        public Orgunitclassconfigurationofichannel OrgUnitClassConfigurationOfIChannel { get; set; }
        public Singleresultoforgunitchannel SingleResultOfOrgUnitChannel { get; set; }
        public Orgunitcryptor OrgUnitCryptor { get; set; }
        public Orgunitclassconfigurationoficryptor OrgUnitClassConfigurationOfICryptor { get; set; }
        public Singleresultoforgunitcryptor SingleResultOfOrgUnitCryptor { get; set; }
        public Singleresultofsurveyresponse SingleResultOfSurveyResponse { get; set; }
        public Singleresultofproductsupplier SingleResultOfProductSupplier { get; set; }
        public Orgunitconnector OrgUnitConnector { get; set; }
        public Iorgunitchannel IOrgUnitChannel { get; set; }
        public Iorgunitcryptor IOrgUnitCryptor { get; set; }
        public Orgunitclassconfigurationoficonnector OrgUnitClassConfigurationOfIConnector { get; set; }
        public Singleresultoforgunitconnector SingleResultOfOrgUnitConnector { get; set; }
        public Templateresource TemplateResource { get; set; }
        public Singleresultoftemplateresource SingleResultOfTemplateResource { get; set; }
        public Singleresultoftaggedcontentitem SingleResultOfTaggedContentItem { get; set; }
        public Singleresultoftracktracemessage SingleResultOfTrackTraceMessage { get; set; }
        public Singleresultofcatalogsubscription SingleResultOfCatalogSubscription { get; set; }
        public Productchoicebatch ProductChoiceBatch { get; set; }
        public Productchoicebatchstatus ProductChoiceBatchStatus { get; set; }
        public Productchoice ProductChoice { get; set; }
        public Iselectproductcode1 IselectProductCode { get; set; }
        public Valuetype1 ValueType { get; set; }
        public Iselectwagecode1 IselectWageCode { get; set; }
        public Singleresultofproductchoicebatch SingleResultOfProductChoiceBatch { get; set; }
        public Orgunitauthenticator OrgUnitAuthenticator { get; set; }
        public Orgunitclassconfigurationofiauthenticator OrgUnitClassConfigurationOfIAuthenticator { get; set; }
        public Singleresultoforgunitauthenticator SingleResultOfOrgUnitAuthenticator { get; set; }
        public Applicationconfiguration ApplicationConfiguration { get; set; }
        public Singleresultofapplicationconfiguration SingleResultOfApplicationConfiguration { get; set; }
        public Singleresultofemployeedatamodification SingleResultOfEmployeeDataModification { get; set; }
        public Modifyparameters ModifyParameters { get; set; }
        public Usermodifiableemployeedata UserModifiableEmployeeData { get; set; }
        public Rejectparameters2 RejectParameters2 { get; set; }
        public Approveparameters2 ApproveParameters2 { get; set; }
        public Singleresultofproductimportspecification SingleResultOfProductImportSpecification { get; set; }
        public Productimportlog ProductImportLog { get; set; }
        public Productimportstatus ProductImportStatus { get; set; }
        public Productimportidentifier ProductImportIdentifier { get; set; }
        public Productspecification ProductSpecification { get; set; }
        public Createtransactionparameters CreateTransactionParameters { get; set; }
        public Enumerationitem EnumerationItem { get; set; }
        public Unsubscribeparameters UnsubscribeParameters { get; set; }
        public Runtestparameters RunTestParameters { get; set; }
        public Productspecificationtestresultmodel ProductSpecificationTestResultModel { get; set; }
        public Discountrulemodel DiscountRuleModel { get; set; }
        public Catalogdiscountrulemodel CatalogDiscountRuleModel { get; set; }
        public Productdiscountrulemodel ProductDiscountRuleModel { get; set; }
        public Productgroupmodel ProductGroupModel { get; set; }
        public Generateparameters GenerateParameters { get; set; }
    }

    public class Tag
    {
        public string type { get; set; }
        public bool additionalProperties { get; set; }
        public string[] required { get; set; }
        public Properties2 properties { get; set; }
    }

    public class Properties2
    {
        public Id Id { get; set; }
        public Parentid ParentId { get; set; }
        public Parent Parent { get; set; }
        public Rootid RootId { get; set; }
        public Root Root { get; set; }
        public Children Children { get; set; }
        public Ancestors Ancestors { get; set; }
        public Descendants Descendants { get; set; }
        public Level Level { get; set; }
        public Path Path { get; set; }
        public Displaypath DisplayPath { get; set; }
        public Key Key { get; set; }
        public Name Name { get; set; }
        public Displayname DisplayName { get; set; }
        public Shortdescription ShortDescription { get; set; }
        public Description Description { get; set; }
        public Issensitive IsSensitive { get; set; }
        public Issystementity IsSystemEntity { get; set; }
        public Relatedtags RelatedTags { get; set; }
        public Inverserelatedtags InverseRelatedTags { get; set; }
        public Taggedcontentitems TaggedContentItems { get; set; }
        public Surveyresponses SurveyResponses { get; set; }
        public Products Products { get; set; }
        public Productgroups ProductGroups { get; set; }
    }

    public class Id
    {
        public string type { get; set; }
        public string format { get; set; }
    }

    public class Parentid
    {
        public string type { get; set; }
        public string format { get; set; }
        public bool nullable { get; set; }
    }

    public class Parent
    {
        public bool nullable { get; set; }
        public Oneof67[] oneOf { get; set; }
    }

    public class Oneof67
    {
        public string _ref { get; set; }
    }

    public class Rootid
    {
        public string type { get; set; }
        public string format { get; set; }
        public bool nullable { get; set; }
    }

    public class Root
    {
        public bool nullable { get; set; }
        public Oneof68[] oneOf { get; set; }
    }

    public class Oneof68
    {
        public string _ref { get; set; }
    }

    public class Children
    {
        public string type { get; set; }
        public bool nullable { get; set; }
        public Items53 items { get; set; }
    }

    public class Items53
    {
        public string _ref { get; set; }
    }

    public class Ancestors
    {
        public string type { get; set; }
        public bool nullable { get; set; }
        public Items54 items { get; set; }
    }

    public class Items54
    {
        public string _ref { get; set; }
    }

    public class Descendants
    {
        public string type { get; set; }
        public bool nullable { get; set; }
        public Items55 items { get; set; }
    }

    public class Items55
    {
        public string _ref { get; set; }
    }

    public class Level
    {
        public string type { get; set; }
        public string format { get; set; }
    }

    public class Path
    {
        public string type { get; set; }
        public bool nullable { get; set; }
    }

    public class Displaypath
    {
        public string type { get; set; }
        public bool nullable { get; set; }
    }

    public class Key
    {
        public string type { get; set; }
        public int maxLength { get; set; }
        public bool nullable { get; set; }
    }

    public class Name
    {
        public string type { get; set; }
        public int maxLength { get; set; }
        public int minLength { get; set; }
    }

    public class Displayname
    {
        public string type { get; set; }
        public bool nullable { get; set; }
    }

    public class Shortdescription
    {
        public string type { get; set; }
        public bool nullable { get; set; }
    }

    public class Description
    {
        public string type { get; set; }
        public bool nullable { get; set; }
    }

    public class Issensitive
    {
        public string type { get; set; }
    }

    public class Issystementity
    {
        public string type { get; set; }
    }

    public class Relatedtags
    {
        public string type { get; set; }
        public bool nullable { get; set; }
        public Items56 items { get; set; }
    }

    public class Items56
    {
        public string _ref { get; set; }
    }

    public class Inverserelatedtags
    {
        public string type { get; set; }
        public bool nullable { get; set; }
        public Items57 items { get; set; }
    }

    public class Items57
    {
        public string _ref { get; set; }
    }

    public class Taggedcontentitems
    {
        public string type { get; set; }
        public bool nullable { get; set; }
        public Items58 items { get; set; }
    }

    public class Items58
    {
        public string _ref { get; set; }
    }

    public class Surveyresponses
    {
        public string type { get; set; }
        public bool nullable { get; set; }
        public Items59 items { get; set; }
    }

    public class Items59
    {
        public string _ref { get; set; }
    }

    public class Products
    {
        public string type { get; set; }
        public bool nullable { get; set; }
        public Items60 items { get; set; }
    }

    public class Items60
    {
        public string _ref { get; set; }
    }

    public class Productgroups
    {
        public string type { get; set; }
        public bool nullable { get; set; }
        public Items61 items { get; set; }
    }

    public class Items61
    {
        public string _ref { get; set; }
    }

    public class Taggedcontentitem
    {
        public string type { get; set; }
        public bool additionalProperties { get; set; }
        public string[] required { get; set; }
        public Properties3 properties { get; set; }
    }

    public class Properties3
    {
        public Id1 Id { get; set; }
        public Externalid ExternalId { get; set; }
        public Tags Tags { get; set; }
    }

    public class Id1
    {
        public string type { get; set; }
        public string format { get; set; }
    }

    public class Externalid
    {
        public string type { get; set; }
        public int maxLength { get; set; }
        public int minLength { get; set; }
    }

    public class Tags
    {
        public string type { get; set; }
        public bool nullable { get; set; }
        public Items62 items { get; set; }
    }

    public class Items62
    {
        public string _ref { get; set; }
    }

    public class Surveyresponse
    {
        public string type { get; set; }
        public bool additionalProperties { get; set; }
        public Properties4 properties { get; set; }
    }

    public class Properties4
    {
        public Id2 Id { get; set; }
        public Profileid ProfileId { get; set; }
        public Profile Profile { get; set; }
        public Surveyid SurveyId { get; set; }
        public Survey Survey { get; set; }
        public Createddate CreatedDate { get; set; }
        public Createdby CreatedBy { get; set; }
        public Lastmodifieddate LastModifiedDate { get; set; }
        public Lastmodifiedby LastModifiedBy { get; set; }
        public Serializeddata SerializedData { get; set; }
        public Tags1 Tags { get; set; }
        public Isfinished IsFinished { get; set; }
    }

    public class Id2
    {
        public string type { get; set; }
        public string format { get; set; }
    }

    public class Profileid
    {
        public string type { get; set; }
        public string format { get; set; }
    }

    public class Profile
    {
        public bool nullable { get; set; }
        public Oneof69[] oneOf { get; set; }
    }

    public class Oneof69
    {
        public string _ref { get; set; }
    }

    public class Surveyid
    {
        public string type { get; set; }
        public string format { get; set; }
    }

    public class Survey
    {
        public bool nullable { get; set; }
        public Oneof70[] oneOf { get; set; }
    }

    public class Oneof70
    {
        public string _ref { get; set; }
    }

    public class Createddate
    {
        public string type { get; set; }
        public string format { get; set; }
    }

    public class Createdby
    {
        public string type { get; set; }
        public bool nullable { get; set; }
    }

    public class Lastmodifieddate
    {
        public string type { get; set; }
        public string format { get; set; }
    }

    public class Lastmodifiedby
    {
        public string type { get; set; }
        public bool nullable { get; set; }
    }

    public class Serializeddata
    {
        public string type { get; set; }
        public bool nullable { get; set; }
    }

    public class Tags1
    {
        public string type { get; set; }
        public bool nullable { get; set; }
        public Items63 items { get; set; }
    }

    public class Items63
    {
        public string _ref { get; set; }
    }

    public class Isfinished
    {
        public string type { get; set; }
    }

    public class Profile1
    {
        public string type { get; set; }
        public bool additionalProperties { get; set; }
        public Properties5 properties { get; set; }
    }

    public class Properties5
    {
        public Id3 Id { get; set; }
        public Employeeid EmployeeId { get; set; }
        public Employee Employee { get; set; }
        public Profile_Tags Profile_Tags { get; set; }
        public Surveyresponses1 SurveyResponses { get; set; }
        public Plans Plans { get; set; }
        public Wishlistproducts WishlistProducts { get; set; }
    }

    public class Id3
    {
        public string type { get; set; }
        public string format { get; set; }
    }

    public class Employeeid
    {
        public string type { get; set; }
        public string format { get; set; }
    }

    public class Employee
    {
        public bool nullable { get; set; }
        public Oneof71[] oneOf { get; set; }
    }

    public class Oneof71
    {
        public string _ref { get; set; }
    }

    public class Profile_Tags
    {
        public string type { get; set; }
        public bool nullable { get; set; }
        public Items64 items { get; set; }
    }

    public class Items64
    {
        public string _ref { get; set; }
    }

    public class Surveyresponses1
    {
        public string type { get; set; }
        public bool nullable { get; set; }
        public Items65 items { get; set; }
    }

    public class Items65
    {
        public string _ref { get; set; }
    }

    public class Plans
    {
        public string type { get; set; }
        public bool nullable { get; set; }
        public Items66 items { get; set; }
    }

    public class Items66
    {
        public string _ref { get; set; }
    }

    public class Wishlistproducts
    {
        public string type { get; set; }
        public bool nullable { get; set; }
        public Items67 items { get; set; }
    }

    public class Items67
    {
        public string _ref { get; set; }
    }

    public class Employee1
    {
        public string type { get; set; }
        public bool additionalProperties { get; set; }
        public string[] required { get; set; }
        public Properties6 properties { get; set; }
    }

    public class Properties6
    {
        public Id4 Id { get; set; }
        public Isactive IsActive { get; set; }
        public User User { get; set; }
        public Orgunitid OrgUnitId { get; set; }
        public Orgunit OrgUnit { get; set; }
        public Employeenumber EmployeeNumber { get; set; }
        public Periodemployees PeriodEmployees { get; set; }
        public Currentperiodemployee CurrentPeriodEmployee { get; set; }
        public Isregistered IsRegistered { get; set; }
        public Displayname1 DisplayName { get; set; }
        public Files Files { get; set; }
        public Guid Guid { get; set; }
        public Functiongroupid FunctionGroupId { get; set; }
        public Functiongroup FunctionGroup { get; set; }
        public Profiles Profiles { get; set; }
        public Employeedatamodifications EmployeeDataModifications { get; set; }
        public Employeebudgets EmployeeBudgets { get; set; }
        public Transactions Transactions { get; set; }
    }

    public class Id4
    {
        public string type { get; set; }
        public string format { get; set; }
    }

    public class Isactive
    {
        public string type { get; set; }
    }

    public class User
    {
        public bool nullable { get; set; }
        public Oneof72[] oneOf { get; set; }
    }

    public class Oneof72
    {
        public string _ref { get; set; }
    }

    public class Orgunitid
    {
        public string type { get; set; }
        public string format { get; set; }
    }

    public class Orgunit
    {
        public bool nullable { get; set; }
        public Oneof73[] oneOf { get; set; }
    }

    public class Oneof73
    {
        public string _ref { get; set; }
    }

    public class Employeenumber
    {
        public string type { get; set; }
        public int maxLength { get; set; }
        public int minLength { get; set; }
    }

    public class Periodemployees
    {
        public string type { get; set; }
        public bool nullable { get; set; }
        public Items68 items { get; set; }
    }

    public class Items68
    {
        public string _ref { get; set; }
    }

    public class Currentperiodemployee
    {
        public bool nullable { get; set; }
        public Oneof74[] oneOf { get; set; }
    }

    public class Oneof74
    {
        public string _ref { get; set; }
    }

    public class Isregistered
    {
        public string type { get; set; }
    }

    public class Displayname1
    {
        public string type { get; set; }
        public bool nullable { get; set; }
    }

    public class Files
    {
        public string type { get; set; }
        public bool nullable { get; set; }
        public Items69 items { get; set; }
    }

    public class Items69
    {
        public string _ref { get; set; }
    }

    public class Guid
    {
        public string type { get; set; }
        public string format { get; set; }
        public string _default { get; set; }
    }

    public class Functiongroupid
    {
        public string type { get; set; }
        public string format { get; set; }
        public bool nullable { get; set; }
    }

    public class Functiongroup
    {
        public bool nullable { get; set; }
        public Oneof75[] oneOf { get; set; }
    }

    public class Oneof75
    {
        public string _ref { get; set; }
    }

    public class Profiles
    {
        public string type { get; set; }
        public bool nullable { get; set; }
        public Items70 items { get; set; }
    }

    public class Items70
    {
        public string _ref { get; set; }
    }

    public class Employeedatamodifications
    {
        public string type { get; set; }
        public bool nullable { get; set; }
        public Items71 items { get; set; }
    }

    public class Items71
    {
        public string _ref { get; set; }
    }

    public class Employeebudgets
    {
        public string type { get; set; }
        public bool nullable { get; set; }
        public Items72 items { get; set; }
    }

    public class Items72
    {
        public string _ref { get; set; }
    }

    public class Transactions
    {
        public string type { get; set; }
        public bool nullable { get; set; }
        public Items73 items { get; set; }
    }

    public class Items73
    {
        public string _ref { get; set; }
    }

    public class User1
    {
        public Allof[] allOf { get; set; }
    }

    public class Allof
    {
        public string _ref { get; set; }
        public string type { get; set; }
        public bool additionalProperties { get; set; }
        public Properties7 properties { get; set; }
    }

    public class Properties7
    {
        public Employee2 Employee { get; set; }
        public Managerfororgunit ManagerForOrgUnit { get; set; }
        public Managerfororgunitid ManagerForOrgUnitId { get; set; }
        public Fullname FullName { get; set; }
        public Displayname2 DisplayName { get; set; }
        public Issubscribedtonewsletter IsSubscribedToNewsletter { get; set; }
        public Unsubscribehash UnsubscribeHash { get; set; }
        public Orgunitid1 OrgUnitId { get; set; }
        public Orgunit1 OrgUnit { get; set; }
        public Email Email { get; set; }
        public Emailconfirmed EmailConfirmed { get; set; }
        public Passwordhash PasswordHash { get; set; }
        public Securitystamp SecurityStamp { get; set; }
        public Phonenumber PhoneNumber { get; set; }
        public Phonenumberconfirmed PhoneNumberConfirmed { get; set; }
        public Twofactorenabled TwoFactorEnabled { get; set; }
        public Lockoutenddateutc LockoutEndDateUtc { get; set; }
        public Lockoutenabled LockoutEnabled { get; set; }
        public Accessfailedcount AccessFailedCount { get; set; }
        public Roles Roles { get; set; }
        public Claims Claims { get; set; }
        public Logins Logins { get; set; }
        public Username UserName { get; set; }
        public Createddate1 CreatedDate { get; set; }
        public Createdby1 CreatedBy { get; set; }
        public Lastmodifieddate1 LastModifiedDate { get; set; }
        public Lastmodifiedby1 LastModifiedBy { get; set; }
    }

    public class Employee2
    {
        public bool nullable { get; set; }
        public Oneof76[] oneOf { get; set; }
    }

    public class Oneof76
    {
        public string _ref { get; set; }
    }

    public class Managerfororgunit
    {
        public bool nullable { get; set; }
        public Oneof77[] oneOf { get; set; }
    }

    public class Oneof77
    {
        public string _ref { get; set; }
    }

    public class Managerfororgunitid
    {
        public string type { get; set; }
        public string format { get; set; }
        public bool nullable { get; set; }
    }

    public class Fullname
    {
        public string type { get; set; }
        public bool nullable { get; set; }
    }

    public class Displayname2
    {
        public string type { get; set; }
        public bool nullable { get; set; }
    }

    public class Issubscribedtonewsletter
    {
        public string type { get; set; }
        public bool nullable { get; set; }
    }

    public class Unsubscribehash
    {
        public string type { get; set; }
        public bool nullable { get; set; }
    }

    public class Orgunitid1
    {
        public string type { get; set; }
        public string format { get; set; }
        public bool nullable { get; set; }
    }

    public class Orgunit1
    {
        public bool nullable { get; set; }
        public Oneof78[] oneOf { get; set; }
    }

    public class Oneof78
    {
        public string _ref { get; set; }
    }

    public class Email
    {
        public string type { get; set; }
        public bool nullable { get; set; }
    }

    public class Emailconfirmed
    {
        public string type { get; set; }
    }

    public class Passwordhash
    {
        public string type { get; set; }
        public bool nullable { get; set; }
    }

    public class Securitystamp
    {
        public string type { get; set; }
        public bool nullable { get; set; }
    }

    public class Phonenumber
    {
        public string type { get; set; }
        public bool nullable { get; set; }
    }

    public class Phonenumberconfirmed
    {
        public string type { get; set; }
    }

    public class Twofactorenabled
    {
        public string type { get; set; }
    }

    public class Lockoutenddateutc
    {
        public string type { get; set; }
        public string format { get; set; }
        public bool nullable { get; set; }
    }

    public class Lockoutenabled
    {
        public string type { get; set; }
    }

    public class Accessfailedcount
    {
        public string type { get; set; }
        public string format { get; set; }
    }

    public class Roles
    {
        public string type { get; set; }
        public bool nullable { get; set; }
        public Items74 items { get; set; }
    }

    public class Items74
    {
        public string _ref { get; set; }
    }

    public class Claims
    {
        public string type { get; set; }
        public bool nullable { get; set; }
        public Items75 items { get; set; }
    }

    public class Items75
    {
        public string _ref { get; set; }
    }

    public class Logins
    {
        public string type { get; set; }
        public bool nullable { get; set; }
        public Items76 items { get; set; }
    }

    public class Items76
    {
        public string _ref { get; set; }
    }

    public class Username
    {
        public string type { get; set; }
        public bool nullable { get; set; }
    }

    public class Createddate1
    {
        public string type { get; set; }
        public string format { get; set; }
    }

    public class Createdby1
    {
        public string type { get; set; }
        public bool nullable { get; set; }
    }

    public class Lastmodifieddate1
    {
        public string type { get; set; }
        public string format { get; set; }
    }

    public class Lastmodifiedby1
    {
        public string type { get; set; }
        public bool nullable { get; set; }
    }

    public class Orgunit2
    {
        public string type { get; set; }
        public bool additionalProperties { get; set; }
        public string[] required { get; set; }
        public Properties8 properties { get; set; }
    }

    public class Properties8
    {
        public Id5 Id { get; set; }
        public Parentid1 ParentId { get; set; }
        public Parent1 Parent { get; set; }
        public Rootid1 RootId { get; set; }
        public Root1 Root { get; set; }
        public Children1 Children { get; set; }
        public Ancestors1 Ancestors { get; set; }
        public Descendants1 Descendants { get; set; }
        public Level1 Level { get; set; }
        public Path1 Path { get; set; }
        public Status Status { get; set; }
        public Effectivestatus EffectiveStatus { get; set; }
        public Operationmode OperationMode { get; set; }
        public Effectiveoperationmode EffectiveOperationMode { get; set; }
        public Useractivationflow UserActivationFlow { get; set; }
        public Employeeimporttype EmployeeImportType { get; set; }
        public Employerperiodtype EmployerPeriodType { get; set; }
        public Ikbsubscriptiontype IkbSubscriptionType { get; set; }
        public Perioddaysthreshold PeriodDaysThreshold { get; set; }
        public Numberofdaysoutofservicebeforedisabling NumberOfDaysOutOfServiceBeforeDisabling { get; set; }
        public Termsofservicerequirements TermsOfServiceRequirements { get; set; }
        public Shoppricedisplaypolicy ShopPriceDisplayPolicy { get; set; }
        public Shoptaxationpolicy ShopTaxationPolicy { get; set; }
        public Cao Cao { get; set; }
        public Effectiveconfiguration EffectiveConfiguration { get; set; }
        public Orgunitcode OrgUnitCode { get; set; }
        public Name1 Name { get; set; }
        public Address Address { get; set; }
        public Postalcode PostalCode { get; set; }
        public City City { get; set; }
        public Phonenumber1 PhoneNumber { get; set; }
        public Chamberofcommercenumber ChamberOfCommerceNumber { get; set; }
        public Contactname ContactName { get; set; }
        public Subdomain Subdomain { get; set; }
        public Secret Secret { get; set; }
        public Administrationid AdministrationId { get; set; }
        public Serializedadditionalvalidators SerializedAdditionalValidators { get; set; }
        public Managers Managers { get; set; }
        public Employees Employees { get; set; }
        public Employeeimports EmployeeImports { get; set; }
        public Functiongroupmappings FunctionGroupMappings { get; set; }
        public Usebudgets UseBudgets { get; set; }
        public Catalogsubscriptions CatalogSubscriptions { get; set; }
        public Orgunitbudgets OrgUnitBudgets { get; set; }
    }

    public class Id5
    {
        public string type { get; set; }
        public string format { get; set; }
    }

    public class Parentid1
    {
        public string type { get; set; }
        public string format { get; set; }
        public bool nullable { get; set; }
    }

    public class Parent1
    {
        public bool nullable { get; set; }
        public Oneof79[] oneOf { get; set; }
    }

    public class Oneof79
    {
        public string _ref { get; set; }
    }

    public class Rootid1
    {
        public string type { get; set; }
        public string format { get; set; }
        public bool nullable { get; set; }
    }

    public class Root1
    {
        public bool nullable { get; set; }
        public Oneof80[] oneOf { get; set; }
    }

    public class Oneof80
    {
        public string _ref { get; set; }
    }

    public class Children1
    {
        public string type { get; set; }
        public bool nullable { get; set; }
        public Items77 items { get; set; }
    }

    public class Items77
    {
        public string _ref { get; set; }
    }

    public class Ancestors1
    {
        public string type { get; set; }
        public bool nullable { get; set; }
        public Items78 items { get; set; }
    }

    public class Items78
    {
        public string _ref { get; set; }
    }

    public class Descendants1
    {
        public string type { get; set; }
        public bool nullable { get; set; }
        public Items79 items { get; set; }
    }

    public class Items79
    {
        public string _ref { get; set; }
    }

    public class Level1
    {
        public string type { get; set; }
        public string format { get; set; }
    }

    public class Path1
    {
        public string type { get; set; }
        public bool nullable { get; set; }
    }

    public class Status
    {
        public string _ref { get; set; }
    }

    public class Effectivestatus
    {
        public string _ref { get; set; }
    }

    public class Operationmode
    {
        public string _ref { get; set; }
    }

    public class Effectiveoperationmode
    {
        public string _ref { get; set; }
    }

    public class Useractivationflow
    {
        public string _ref { get; set; }
    }

    public class Employeeimporttype
    {
        public string _ref { get; set; }
    }

    public class Employerperiodtype
    {
        public string _ref { get; set; }
    }

    public class Ikbsubscriptiontype
    {
        public string _ref { get; set; }
    }

    public class Perioddaysthreshold
    {
        public string type { get; set; }
        public string format { get; set; }
        public bool nullable { get; set; }
    }

    public class Numberofdaysoutofservicebeforedisabling
    {
        public string type { get; set; }
        public string format { get; set; }
        public bool nullable { get; set; }
    }

    public class Termsofservicerequirements
    {
        public string _ref { get; set; }
    }

    public class Shoppricedisplaypolicy
    {
        public string _ref { get; set; }
    }

    public class Shoptaxationpolicy
    {
        public string _ref { get; set; }
    }

    public class Cao
    {
        public string _ref { get; set; }
    }

    public class Effectiveconfiguration
    {
        public bool nullable { get; set; }
        public Oneof81[] oneOf { get; set; }
    }

    public class Oneof81
    {
        public string _ref { get; set; }
    }

    public class Orgunitcode
    {
        public string type { get; set; }
        public int maxLength { get; set; }
        public int minLength { get; set; }
        public string pattern { get; set; }
    }

    public class Name1
    {
        public string type { get; set; }
        public int maxLength { get; set; }
        public int minLength { get; set; }
    }

    public class Address
    {
        public string type { get; set; }
        public bool nullable { get; set; }
    }

    public class Postalcode
    {
        public string type { get; set; }
        public bool nullable { get; set; }
    }

    public class City
    {
        public string type { get; set; }
        public int minLength { get; set; }
    }

    public class Phonenumber1
    {
        public string type { get; set; }
        public bool nullable { get; set; }
    }

    public class Chamberofcommercenumber
    {
        public string type { get; set; }
        public bool nullable { get; set; }
    }

    public class Contactname
    {
        public string type { get; set; }
        public bool nullable { get; set; }
    }

    public class Subdomain
    {
        public string type { get; set; }
        public int maxLength { get; set; }
        public bool nullable { get; set; }
    }

    public class Secret
    {
        public string type { get; set; }
        public string format { get; set; }
        public string _default { get; set; }
        public int minLength { get; set; }
    }

    public class Administrationid
    {
        public string type { get; set; }
        public bool nullable { get; set; }
    }

    public class Serializedadditionalvalidators
    {
        public string type { get; set; }
        public bool nullable { get; set; }
    }

    public class Managers
    {
        public string type { get; set; }
        public bool nullable { get; set; }
        public Items80 items { get; set; }
    }

    public class Items80
    {
        public string _ref { get; set; }
    }

    public class Employees
    {
        public string type { get; set; }
        public bool nullable { get; set; }
        public Items81 items { get; set; }
    }

    public class Items81
    {
        public string _ref { get; set; }
    }

    public class Employeeimports
    {
        public string type { get; set; }
        public bool nullable { get; set; }
        public Items82 items { get; set; }
    }

    public class Items82
    {
        public string _ref { get; set; }
    }

    public class Functiongroupmappings
    {
        public string type { get; set; }
        public bool nullable { get; set; }
        public Items83 items { get; set; }
    }

    public class Items83
    {
        public string _ref { get; set; }
    }

    public class Usebudgets
    {
        public string type { get; set; }
        public int _default { get; set; }
    }

    public class Catalogsubscriptions
    {
        public string type { get; set; }
        public bool nullable { get; set; }
        public Items84 items { get; set; }
    }

    public class Items84
    {
        public string _ref { get; set; }
    }

    public class Orgunitbudgets
    {
        public string type { get; set; }
        public bool nullable { get; set; }
        public Items85 items { get; set; }
    }

    public class Items85
    {
        public string _ref { get; set; }
    }

    public class Status1
    {
        public string type { get; set; }
        public string description { get; set; }
        public string[] xenumNames { get; set; }
        public string[] _enum { get; set; }
    }

    public class Operationmode1
    {
        public string type { get; set; }
        public string description { get; set; }
        public string[] xenumNames { get; set; }
        public string[] _enum { get; set; }
    }

    public class Useractivationflow1
    {
        public string type { get; set; }
        public string description { get; set; }
        public string[] xenumNames { get; set; }
        public string[] _enum { get; set; }
    }

    public class Importtype
    {
        public string type { get; set; }
        public string description { get; set; }
        public string[] xenumNames { get; set; }
        public string[] _enum { get; set; }
    }

    public class Employerperiodtype1
    {
        public string type { get; set; }
        public string description { get; set; }
        public string[] xenumNames { get; set; }
        public string[] _enum { get; set; }
    }

    public class Ikbsubscriptiontype1
    {
        public string type { get; set; }
        public string description { get; set; }
        public string[] xenumNames { get; set; }
        public string[] _enum { get; set; }
    }

    public class Termsofservicerequirements1
    {
        public string type { get; set; }
        public string description { get; set; }
        public string[] xenumNames { get; set; }
        public string[] _enum { get; set; }
    }

    public class Shoppricedisplaypolicy1
    {
        public string type { get; set; }
        public string description { get; set; }
        public string[] xenumNames { get; set; }
        public string[] _enum { get; set; }
    }

    public class Shoptaxationpolicy1
    {
        public string type { get; set; }
        public string description { get; set; }
        public string[] xenumNames { get; set; }
        public string[] _enum { get; set; }
    }

    public class Cao1
    {
        public string type { get; set; }
        public string description { get; set; }
        public string[] xenumNames { get; set; }
        public string[] _enum { get; set; }
    }

    public class Orgunitconfiguration
    {
        public string type { get; set; }
        public bool additionalProperties { get; set; }
        public Properties9 properties { get; set; }
    }

    public class Properties9
    {
        public Orgunitid2 OrgUnitId { get; set; }
        public Orgunit3 OrgUnit { get; set; }
        public Cao2 Cao { get; set; }
        public Useractivationflow2 UserActivationFlow { get; set; }
        public Employeeimporttype1 EmployeeImportType { get; set; }
        public Employerperiodtype2 EmployerPeriodType { get; set; }
        public Ikbsubscriptiontype2 IkbSubscriptionType { get; set; }
        public Perioddaysthreshold1 PeriodDaysThreshold { get; set; }
        public Numberofdaysoutofservicebeforedisabling1 NumberOfDaysOutOfServiceBeforeDisabling { get; set; }
        public Shoppricedisplaypolicy2 ShopPriceDisplayPolicy { get; set; }
        public Shoptaxationpolicy2 ShopTaxationPolicy { get; set; }
        public Termsofservicerequirements2 TermsOfServiceRequirements { get; set; }
    }

    public class Orgunitid2
    {
        public string type { get; set; }
        public string format { get; set; }
    }

    public class Orgunit3
    {
        public bool nullable { get; set; }
        public Oneof82[] oneOf { get; set; }
    }

    public class Oneof82
    {
        public string _ref { get; set; }
    }

    public class Cao2
    {
        public string _ref { get; set; }
    }

    public class Useractivationflow2
    {
        public string _ref { get; set; }
    }

    public class Employeeimporttype1
    {
        public string _ref { get; set; }
    }

    public class Employerperiodtype2
    {
        public string _ref { get; set; }
    }

    public class Ikbsubscriptiontype2
    {
        public string _ref { get; set; }
    }

    public class Perioddaysthreshold1
    {
        public string type { get; set; }
        public string format { get; set; }
        public bool nullable { get; set; }
    }

    public class Numberofdaysoutofservicebeforedisabling1
    {
        public string type { get; set; }
        public string format { get; set; }
        public bool nullable { get; set; }
    }

    public class Shoppricedisplaypolicy2
    {
        public string _ref { get; set; }
    }

    public class Shoptaxationpolicy2
    {
        public string _ref { get; set; }
    }

    public class Termsofservicerequirements2
    {
        public string _ref { get; set; }
    }

    public class Employeeimport
    {
        public string type { get; set; }
        public bool additionalProperties { get; set; }
        public Properties10 properties { get; set; }
    }

    public class Properties10
    {
        public Id6 Id { get; set; }
        public Createddate2 CreatedDate { get; set; }
        public Createdby2 CreatedBy { get; set; }
        public Lastmodifieddate2 LastModifiedDate { get; set; }
        public Lastmodifiedby2 LastModifiedBy { get; set; }
        public Orgunitid3 OrgUnitId { get; set; }
        public Orgunit4 OrgUnit { get; set; }
        public Activationletterfileid ActivationLetterFileId { get; set; }
        public Activationletterfile ActivationLetterFile { get; set; }
        public Employeeimportfileid EmployeeImportFileId { get; set; }
        public Employeeimportfile EmployeeImportFile { get; set; }
        public Employeeimportmiddlewarefileid EmployeeImportMiddlewareFileId { get; set; }
        public Employeeimportmiddlewarefile EmployeeImportMiddlewareFile { get; set; }
        public Tracktracecodeid TrackTraceCodeId { get; set; }
        public Tracktracecode TrackTraceCode { get; set; }
        public Amountadded AmountAdded { get; set; }
        public Addedemployeeids AddedEmployeeIds { get; set; }
        public Amountupdated AmountUpdated { get; set; }
        public Updatedemployeeids UpdatedEmployeeIds { get; set; }
        public Amountdeleted AmountDeleted { get; set; }
        public Deletedemployeeids DeletedEmployeeIds { get; set; }
        public Status2 Status { get; set; }
        public Type Type { get; set; }
    }

    public class Id6
    {
        public string type { get; set; }
        public string format { get; set; }
    }

    public class Createddate2
    {
        public string type { get; set; }
        public string format { get; set; }
    }

    public class Createdby2
    {
        public string type { get; set; }
        public bool nullable { get; set; }
    }

    public class Lastmodifieddate2
    {
        public string type { get; set; }
        public string format { get; set; }
    }

    public class Lastmodifiedby2
    {
        public string type { get; set; }
        public bool nullable { get; set; }
    }

    public class Orgunitid3
    {
        public string type { get; set; }
        public string format { get; set; }
    }

    public class Orgunit4
    {
        public bool nullable { get; set; }
        public Oneof83[] oneOf { get; set; }
    }

    public class Oneof83
    {
        public string _ref { get; set; }
    }

    public class Activationletterfileid
    {
        public string type { get; set; }
        public string format { get; set; }
        public bool nullable { get; set; }
    }

    public class Activationletterfile
    {
        public bool nullable { get; set; }
        public Oneof84[] oneOf { get; set; }
    }

    public class Oneof84
    {
        public string _ref { get; set; }
    }

    public class Employeeimportfileid
    {
        public string type { get; set; }
        public string format { get; set; }
        public bool nullable { get; set; }
    }

    public class Employeeimportfile
    {
        public bool nullable { get; set; }
        public Oneof85[] oneOf { get; set; }
    }

    public class Oneof85
    {
        public string _ref { get; set; }
    }

    public class Employeeimportmiddlewarefileid
    {
        public string type { get; set; }
        public string format { get; set; }
        public bool nullable { get; set; }
    }

    public class Employeeimportmiddlewarefile
    {
        public bool nullable { get; set; }
        public Oneof86[] oneOf { get; set; }
    }

    public class Oneof86
    {
        public string _ref { get; set; }
    }

    public class Tracktracecodeid
    {
        public string type { get; set; }
        public string format { get; set; }
    }

    public class Tracktracecode
    {
        public bool nullable { get; set; }
        public Oneof87[] oneOf { get; set; }
    }

    public class Oneof87
    {
        public string _ref { get; set; }
    }

    public class Amountadded
    {
        public string type { get; set; }
        public string format { get; set; }
    }

    public class Addedemployeeids
    {
        public string type { get; set; }
        public bool nullable { get; set; }
    }

    public class Amountupdated
    {
        public string type { get; set; }
        public string format { get; set; }
    }

    public class Updatedemployeeids
    {
        public string type { get; set; }
        public bool nullable { get; set; }
    }

    public class Amountdeleted
    {
        public string type { get; set; }
        public string format { get; set; }
    }

    public class Deletedemployeeids
    {
        public string type { get; set; }
        public bool nullable { get; set; }
    }

    public class Status2
    {
        public string _ref { get; set; }
    }

    public class Type
    {
        public string _ref { get; set; }
    }

    public class Activationletterfile1
    {
        public Allof1[] allOf { get; set; }
    }

    public class Allof1
    {
        public string _ref { get; set; }
        public string type { get; set; }
        public bool additionalProperties { get; set; }
    }

    public class File2
    {
        public string type { get; set; }
        public bool xabstract { get; set; }
        public bool additionalProperties { get; set; }
        public string[] required { get; set; }
        public Properties11 properties { get; set; }
    }

    public class Properties11
    {
        public Id7 Id { get; set; }
        public Name2 Name { get; set; }
        public Data Data { get; set; }
        public Created Created { get; set; }
        public Modified Modified { get; set; }
        public Orgunitid4 OrgUnitId { get; set; }
        public Orgunit5 OrgUnit { get; set; }
        public Mediatype MediaType { get; set; }
    }

    public class Id7
    {
        public string type { get; set; }
        public string format { get; set; }
    }

    public class Name2
    {
        public string type { get; set; }
        public int minLength { get; set; }
    }

    public class Data
    {
        public string type { get; set; }
        public string format { get; set; }
        public int minLength { get; set; }
    }

    public class Created
    {
        public string type { get; set; }
        public string format { get; set; }
        public int minLength { get; set; }
    }

    public class Modified
    {
        public string type { get; set; }
        public string format { get; set; }
        public bool nullable { get; set; }
    }

    public class Orgunitid4
    {
        public string type { get; set; }
        public string format { get; set; }
        public bool nullable { get; set; }
    }

    public class Orgunit5
    {
        public bool nullable { get; set; }
        public Oneof88[] oneOf { get; set; }
    }

    public class Oneof88
    {
        public string _ref { get; set; }
    }

    public class Mediatype
    {
        public string type { get; set; }
        public bool nullable { get; set; }
    }

    public class Employeeimportfile1
    {
        public Allof2[] allOf { get; set; }
    }

    public class Allof2
    {
        public string _ref { get; set; }
        public string type { get; set; }
        public bool additionalProperties { get; set; }
    }

    public class Employeeimportmiddlewarefile1
    {
        public Allof3[] allOf { get; set; }
    }

    public class Allof3
    {
        public string _ref { get; set; }
        public string type { get; set; }
        public bool additionalProperties { get; set; }
    }

    public class Tracktracecode1
    {
        public string type { get; set; }
        public bool additionalProperties { get; set; }
        public string[] required { get; set; }
        public Properties12 properties { get; set; }
    }

    public class Properties12
    {
        public Id8 Id { get; set; }
        public Code Code { get; set; }
        public Created1 Created { get; set; }
        public Orgunitid5 OrgUnitId { get; set; }
        public Orgunit6 OrgUnit { get; set; }
        public Messages Messages { get; set; }
    }

    public class Id8
    {
        public string type { get; set; }
        public string format { get; set; }
    }

    public class Code
    {
        public string type { get; set; }
        public int maxLength { get; set; }
        public int minLength { get; set; }
    }

    public class Created1
    {
        public string type { get; set; }
        public string format { get; set; }
    }

    public class Orgunitid5
    {
        public string type { get; set; }
        public string format { get; set; }
        public bool nullable { get; set; }
    }

    public class Orgunit6
    {
        public bool nullable { get; set; }
        public Oneof89[] oneOf { get; set; }
    }

    public class Oneof89
    {
        public string _ref { get; set; }
    }

    public class Messages
    {
        public string type { get; set; }
        public bool nullable { get; set; }
        public Items86 items { get; set; }
    }

    public class Items86
    {
        public string _ref { get; set; }
    }

    public class Tracktracemessage
    {
        public string type { get; set; }
        public bool additionalProperties { get; set; }
        public Properties13 properties { get; set; }
    }

    public class Properties13
    {
        public Id9 Id { get; set; }
        public Tracktracecodeid1 TrackTraceCodeId { get; set; }
        public Timestamp Timestamp { get; set; }
        public Loglevel LogLevel { get; set; }
        public Message Message { get; set; }
    }

    public class Id9
    {
        public string type { get; set; }
        public string format { get; set; }
    }

    public class Tracktracecodeid1
    {
        public string type { get; set; }
        public string format { get; set; }
    }

    public class Timestamp
    {
        public string type { get; set; }
        public string format { get; set; }
    }

    public class Loglevel
    {
        public string _ref { get; set; }
    }

    public class Message
    {
        public string type { get; set; }
        public bool nullable { get; set; }
    }

    public class Tracktraceloglevel
    {
        public string type { get; set; }
        public string description { get; set; }
        public string[] xenumNames { get; set; }
        public string[] _enum { get; set; }
    }

    public class Importstatus
    {
        public string type { get; set; }
        public string description { get; set; }
        public string[] xenumNames { get; set; }
        public string[] _enum { get; set; }
    }

    public class Orgunitfunctiongroupmapping
    {
        public string type { get; set; }
        public bool additionalProperties { get; set; }
        public string[] required { get; set; }
        public Properties14 properties { get; set; }
    }

    public class Properties14
    {
        public Id10 Id { get; set; }
        public Orgunitid6 OrgUnitId { get; set; }
        public Orgunit7 OrgUnit { get; set; }
        public Localfunctiongroup LocalFunctionGroup { get; set; }
        public Functiongroupid1 FunctionGroupId { get; set; }
        public Functiongroup1 FunctionGroup { get; set; }
    }

    public class Id10
    {
        public string type { get; set; }
        public string format { get; set; }
    }

    public class Orgunitid6
    {
        public string type { get; set; }
        public string format { get; set; }
    }

    public class Orgunit7
    {
        public bool nullable { get; set; }
        public Oneof90[] oneOf { get; set; }
    }

    public class Oneof90
    {
        public string _ref { get; set; }
    }

    public class Localfunctiongroup
    {
        public string type { get; set; }
        public int maxLength { get; set; }
        public int minLength { get; set; }
    }

    public class Functiongroupid1
    {
        public string type { get; set; }
        public string format { get; set; }
    }

    public class Functiongroup1
    {
        public bool nullable { get; set; }
        public Oneof91[] oneOf { get; set; }
    }

    public class Oneof91
    {
        public string _ref { get; set; }
    }

    public class Functiongroup2
    {
        public string type { get; set; }
        public bool additionalProperties { get; set; }
        public Properties15 properties { get; set; }
    }

    public class Properties15
    {
        public Id11 Id { get; set; }
        public Issystementity1 IsSystemEntity { get; set; }
        public Name3 Name { get; set; }
        public Productgroups1 ProductGroups { get; set; }
    }

    public class Id11
    {
        public string type { get; set; }
        public string format { get; set; }
    }

    public class Issystementity1
    {
        public string type { get; set; }
    }

    public class Name3
    {
        public string type { get; set; }
        public int maxLength { get; set; }
        public bool nullable { get; set; }
    }

    public class Productgroups1
    {
        public string type { get; set; }
        public bool nullable { get; set; }
        public Items87 items { get; set; }
    }

    public class Items87
    {
        public string _ref { get; set; }
    }

    public class Productgroup
    {
        public string type { get; set; }
        public bool additionalProperties { get; set; }
        public Properties16 properties { get; set; }
    }

    public class Properties16
    {
        public Id12 Id { get; set; }
        public Orgunitid7 OrgUnitId { get; set; }
        public Orgunit8 OrgUnit { get; set; }
        public Filteronfunctiongroups FilterOnFunctionGroups { get; set; }
        public Functiongroups FunctionGroups { get; set; }
        public Filteroncatalogs FilterOnCatalogs { get; set; }
        public Catalogs Catalogs { get; set; }
        public Filterontags FilterOnTags { get; set; }
        public Tags2 Tags { get; set; }
        public Filteronproductsuppliers FilterOnProductSuppliers { get; set; }
        public Productsuppliers ProductSuppliers { get; set; }
        public Productgrouptype ProductGroupType { get; set; }
        public Name4 Name { get; set; }
        public Priceadjustmentfactor PriceAdjustmentFactor { get; set; }
        public Approvalthresholdprice ApprovalThresholdPrice { get; set; }
        public Taxationindication TaxationIndication { get; set; }
    }

    public class Id12
    {
        public string type { get; set; }
        public string format { get; set; }
    }

    public class Orgunitid7
    {
        public string type { get; set; }
        public string format { get; set; }
    }

    public class Orgunit8
    {
        public bool nullable { get; set; }
        public Oneof92[] oneOf { get; set; }
    }

    public class Oneof92
    {
        public string _ref { get; set; }
    }

    public class Filteronfunctiongroups
    {
        public string type { get; set; }
    }

    public class Functiongroups
    {
        public string type { get; set; }
        public bool nullable { get; set; }
        public Items88 items { get; set; }
    }

    public class Items88
    {
        public string _ref { get; set; }
    }

    public class Filteroncatalogs
    {
        public string type { get; set; }
    }

    public class Catalogs
    {
        public string type { get; set; }
        public bool nullable { get; set; }
        public Items89 items { get; set; }
    }

    public class Items89
    {
        public string _ref { get; set; }
    }

    public class Filterontags
    {
        public string type { get; set; }
    }

    public class Tags2
    {
        public string type { get; set; }
        public bool nullable { get; set; }
        public Items90 items { get; set; }
    }

    public class Items90
    {
        public string _ref { get; set; }
    }

    public class Filteronproductsuppliers
    {
        public string type { get; set; }
    }

    public class Productsuppliers
    {
        public string type { get; set; }
        public bool nullable { get; set; }
        public Items91 items { get; set; }
    }

    public class Items91
    {
        public string _ref { get; set; }
    }

    public class Productgrouptype
    {
        public string _ref { get; set; }
    }

    public class Name4
    {
        public string type { get; set; }
        public bool nullable { get; set; }
    }

    public class Priceadjustmentfactor
    {
        public string type { get; set; }
        public string format { get; set; }
    }

    public class Approvalthresholdprice
    {
        public bool nullable { get; set; }
        public Oneof93[] oneOf { get; set; }
    }

    public class Oneof93
    {
        public string _ref { get; set; }
    }

    public class Taxationindication
    {
        public bool nullable { get; set; }
        public Oneof94[] oneOf { get; set; }
    }

    public class Oneof94
    {
        public string _ref { get; set; }
    }

    public class Catalog
    {
        public string type { get; set; }
        public bool additionalProperties { get; set; }
        public string[] required { get; set; }
        public Properties17 properties { get; set; }
    }

    public class Properties17
    {
        public Id13 Id { get; set; }
        public Isactive1 IsActive { get; set; }
        public Name5 Name { get; set; }
        public Displayname3 DisplayName { get; set; }
        public Ownerid OwnerId { get; set; }
        public Owner Owner { get; set; }
        public Catalogsubscriptions1 CatalogSubscriptions { get; set; }
        public Products1 Products { get; set; }
        public Productgroups2 ProductGroups { get; set; }
        public Productimportspecifications ProductImportSpecifications { get; set; }
    }

    public class Id13
    {
        public string type { get; set; }
        public string format { get; set; }
    }

    public class Isactive1
    {
        public string type { get; set; }
    }

    public class Name5
    {
        public string type { get; set; }
        public int maxLength { get; set; }
        public int minLength { get; set; }
    }

    public class Displayname3
    {
        public string type { get; set; }
        public bool nullable { get; set; }
    }

    public class Ownerid
    {
        public string type { get; set; }
        public string format { get; set; }
        public bool nullable { get; set; }
    }

    public class Owner
    {
        public bool nullable { get; set; }
        public Oneof95[] oneOf { get; set; }
    }

    public class Oneof95
    {
        public string _ref { get; set; }
    }

    public class Catalogsubscriptions1
    {
        public string type { get; set; }
        public bool nullable { get; set; }
        public Items92 items { get; set; }
    }

    public class Items92
    {
        public string _ref { get; set; }
    }

    public class Products1
    {
        public string type { get; set; }
        public bool nullable { get; set; }
        public Items93 items { get; set; }
    }

    public class Items93
    {
        public string _ref { get; set; }
    }

    public class Productgroups2
    {
        public string type { get; set; }
        public bool nullable { get; set; }
        public Items94 items { get; set; }
    }

    public class Items94
    {
        public string _ref { get; set; }
    }

    public class Productimportspecifications
    {
        public string type { get; set; }
        public bool nullable { get; set; }
        public Items95 items { get; set; }
    }

    public class Items95
    {
        public string _ref { get; set; }
    }

    public class Catalogsubscription
    {
        public string type { get; set; }
        public bool additionalProperties { get; set; }
        public Properties18 properties { get; set; }
    }

    public class Properties18
    {
        public Id14 Id { get; set; }
        public Orgunitid8 OrgUnitId { get; set; }
        public Orgunit9 OrgUnit { get; set; }
        public Catalogid CatalogId { get; set; }
        public Catalog1 Catalog { get; set; }
        public From From { get; set; }
        public To To { get; set; }
        public Iscurrentlysubscribed IsCurrentlySubscribed { get; set; }
    }

    public class Id14
    {
        public string type { get; set; }
        public string format { get; set; }
    }

    public class Orgunitid8
    {
        public string type { get; set; }
        public string format { get; set; }
    }

    public class Orgunit9
    {
        public bool nullable { get; set; }
        public Oneof96[] oneOf { get; set; }
    }

    public class Oneof96
    {
        public string _ref { get; set; }
    }

    public class Catalogid
    {
        public string type { get; set; }
        public string format { get; set; }
    }

    public class Catalog1
    {
        public bool nullable { get; set; }
        public Oneof97[] oneOf { get; set; }
    }

    public class Oneof97
    {
        public string _ref { get; set; }
    }

    public class From
    {
        public string type { get; set; }
        public string format { get; set; }
    }

    public class To
    {
        public string type { get; set; }
        public string format { get; set; }
    }

    public class Iscurrentlysubscribed
    {
        public string type { get; set; }
    }

    public class Product
    {
        public string type { get; set; }
        public bool additionalProperties { get; set; }
        public string[] required { get; set; }
        public Properties19 properties { get; set; }
    }

    public class Properties19
    {
        public Id15 Id { get; set; }
        public Externalid1 ExternalId { get; set; }
        public Isactive2 IsActive { get; set; }
        public Createddate3 CreatedDate { get; set; }
        public Createdby3 CreatedBy { get; set; }
        public Lastmodifieddate3 LastModifiedDate { get; set; }
        public Lastmodifiedby3 LastModifiedBy { get; set; }
        public Iscomplete IsComplete { get; set; }
        public Isavailable IsAvailable { get; set; }
        public Startdate StartDate { get; set; }
        public Title Title { get; set; }
        public Summary Summary { get; set; }
        public Description1 Description { get; set; }
        public Externalurl ExternalUrl { get; set; }
        public Schedulesummary ScheduleSummary { get; set; }
        public Locationsummary LocationSummary { get; set; }
        public Productcategoryid ProductCategoryId { get; set; }
        public Productcategory ProductCategory { get; set; }
        public Catalogid1 CatalogId { get; set; }
        public Catalog2 Catalog { get; set; }
        public Productsupplierid ProductSupplierId { get; set; }
        public Productsupplier ProductSupplier { get; set; }
        public Productimportdocumentid ProductImportDocumentId { get; set; }
        public Productimportdocument ProductImportDocument { get; set; }
        public Productimportspecificationid ProductImportSpecificationId { get; set; }
        public Importsource ImportSource { get; set; }
        public Importformat ImportFormat { get; set; }
        public Programcosts ProgramCosts { get; set; }
        public Tags3 Tags { get; set; }
        public Wishlistprofiles WishlistProfiles { get; set; }
        public Averagerating AverageRating { get; set; }
        public Numberofratings NumberOfRatings { get; set; }
    }

    public class Id15
    {
        public string type { get; set; }
        public string format { get; set; }
    }

    public class Externalid1
    {
        public string type { get; set; }
        public bool nullable { get; set; }
    }

    public class Isactive2
    {
        public string type { get; set; }
    }

    public class Createddate3
    {
        public string type { get; set; }
        public string format { get; set; }
    }

    public class Createdby3
    {
        public string type { get; set; }
        public bool nullable { get; set; }
    }

    public class Lastmodifieddate3
    {
        public string type { get; set; }
        public string format { get; set; }
    }

    public class Lastmodifiedby3
    {
        public string type { get; set; }
        public bool nullable { get; set; }
    }

    public class Iscomplete
    {
        public string type { get; set; }
    }

    public class Isavailable
    {
        public string type { get; set; }
    }

    public class Startdate
    {
        public string type { get; set; }
        public string format { get; set; }
        public bool nullable { get; set; }
    }

    public class Title
    {
        public string type { get; set; }
        public int maxLength { get; set; }
        public int minLength { get; set; }
    }

    public class Summary
    {
        public string type { get; set; }
        public bool nullable { get; set; }
    }

    public class Description1
    {
        public string type { get; set; }
        public bool nullable { get; set; }
    }

    public class Externalurl
    {
        public string type { get; set; }
        public bool nullable { get; set; }
    }

    public class Schedulesummary
    {
        public string type { get; set; }
        public bool nullable { get; set; }
    }

    public class Locationsummary
    {
        public string type { get; set; }
        public bool nullable { get; set; }
    }

    public class Productcategoryid
    {
        public string type { get; set; }
        public string format { get; set; }
        public bool nullable { get; set; }
    }

    public class Productcategory
    {
        public bool nullable { get; set; }
        public Oneof98[] oneOf { get; set; }
    }

    public class Oneof98
    {
        public string _ref { get; set; }
    }

    public class Catalogid1
    {
        public string type { get; set; }
        public string format { get; set; }
    }

    public class Catalog2
    {
        public bool nullable { get; set; }
        public Oneof99[] oneOf { get; set; }
    }

    public class Oneof99
    {
        public string _ref { get; set; }
    }

    public class Productsupplierid
    {
        public string type { get; set; }
        public string format { get; set; }
    }

    public class Productsupplier
    {
        public bool nullable { get; set; }
        public Oneof100[] oneOf { get; set; }
    }

    public class Oneof100
    {
        public string _ref { get; set; }
    }

    public class Productimportdocumentid
    {
        public string type { get; set; }
        public string format { get; set; }
        public bool nullable { get; set; }
    }

    public class Productimportdocument
    {
        public bool nullable { get; set; }
        public Oneof101[] oneOf { get; set; }
    }

    public class Oneof101
    {
        public string _ref { get; set; }
    }

    public class Productimportspecificationid
    {
        public string type { get; set; }
        public string format { get; set; }
        public bool nullable { get; set; }
    }

    public class Importsource
    {
        public string _ref { get; set; }
    }

    public class Importformat
    {
        public string _ref { get; set; }
    }

    public class Programcosts
    {
        public string type { get; set; }
        public bool nullable { get; set; }
        public Items96 items { get; set; }
    }

    public class Items96
    {
        public string _ref { get; set; }
    }

    public class Tags3
    {
        public string type { get; set; }
        public bool nullable { get; set; }
        public Items97 items { get; set; }
    }

    public class Items97
    {
        public string _ref { get; set; }
    }

    public class Wishlistprofiles
    {
        public string type { get; set; }
        public bool nullable { get; set; }
        public Items98 items { get; set; }
    }

    public class Items98
    {
        public string _ref { get; set; }
    }

    public class Averagerating
    {
        public string type { get; set; }
        public string format { get; set; }
    }

    public class Numberofratings
    {
        public string type { get; set; }
        public string format { get; set; }
    }

    public class Productcategory1
    {
        public string type { get; set; }
        public bool additionalProperties { get; set; }
        public Properties20 properties { get; set; }
    }

    public class Properties20
    {
        public Id16 Id { get; set; }
        public Name6 Name { get; set; }
        public Productgroups3 ProductGroups { get; set; }
    }

    public class Id16
    {
        public string type { get; set; }
        public string format { get; set; }
    }

    public class Name6
    {
        public string type { get; set; }
        public int maxLength { get; set; }
        public bool nullable { get; set; }
    }

    public class Productgroups3
    {
        public string type { get; set; }
        public bool nullable { get; set; }
        public Items99 items { get; set; }
    }

    public class Items99
    {
        public string _ref { get; set; }
    }

    public class Productsupplier1
    {
        public string type { get; set; }
        public bool additionalProperties { get; set; }
        public string[] required { get; set; }
        public Properties21 properties { get; set; }
    }

    public class Properties21
    {
        public Id17 Id { get; set; }
        public Externalid2 ExternalId { get; set; }
        public Name7 Name { get; set; }
        public Invoiceemail InvoiceEmail { get; set; }
        public Transactionemail TransactionEmail { get; set; }
        public Products2 Products { get; set; }
        public Productgroups4 ProductGroups { get; set; }
        public Users Users { get; set; }
    }

    public class Id17
    {
        public string type { get; set; }
        public string format { get; set; }
    }

    public class Externalid2
    {
        public string type { get; set; }
        public int maxLength { get; set; }
        public int minLength { get; set; }
    }

    public class Name7
    {
        public string type { get; set; }
        public int maxLength { get; set; }
        public int minLength { get; set; }
    }

    public class Invoiceemail
    {
        public string type { get; set; }
        public string format { get; set; }
        public int maxLength { get; set; }
        public bool nullable { get; set; }
    }

    public class Transactionemail
    {
        public string type { get; set; }
        public string format { get; set; }
        public int maxLength { get; set; }
        public bool nullable { get; set; }
    }

    public class Products2
    {
        public string type { get; set; }
        public bool nullable { get; set; }
        public Items100 items { get; set; }
    }

    public class Items100
    {
        public string _ref { get; set; }
    }

    public class Productgroups4
    {
        public string type { get; set; }
        public bool nullable { get; set; }
        public Items101 items { get; set; }
    }

    public class Items101
    {
        public string _ref { get; set; }
    }

    public class Users
    {
        public string type { get; set; }
        public bool nullable { get; set; }
        public Items102 items { get; set; }
    }

    public class Items102
    {
        public string _ref { get; set; }
    }

    public class Productimportdocument1
    {
        public string type { get; set; }
        public bool additionalProperties { get; set; }
        public Properties22 properties { get; set; }
    }

    public class Properties22
    {
        public Id18 Id { get; set; }
        public Data1 Data { get; set; }
        public Hash Hash { get; set; }
    }

    public class Id18
    {
        public string type { get; set; }
        public string format { get; set; }
    }

    public class Data1
    {
        public string type { get; set; }
        public bool nullable { get; set; }
    }

    public class Hash
    {
        public string type { get; set; }
        public bool nullable { get; set; }
    }

    public class Importsource1
    {
        public string type { get; set; }
        public string description { get; set; }
        public string[] xenumNames { get; set; }
        public string[] _enum { get; set; }
    }

    public class Importformat1
    {
        public string type { get; set; }
        public string description { get; set; }
        public string[] xenumNames { get; set; }
        public string[] _enum { get; set; }
    }

    public class Programcost
    {
        public string type { get; set; }
        public bool additionalProperties { get; set; }
        public Properties23 properties { get; set; }
    }

    public class Properties23
    {
        public Id19 Id { get; set; }
        public Productid ProductId { get; set; }
        public Product1 Product { get; set; }
        public Costtypeid CostTypeId { get; set; }
        public Costtype CostType { get; set; }
        public Amount Amount { get; set; }
        public Amounttax AmountTax { get; set; }
        public Costtypevalue CostTypeValue { get; set; }
    }

    public class Id19
    {
        public string type { get; set; }
        public string format { get; set; }
    }

    public class Productid
    {
        public string type { get; set; }
        public string format { get; set; }
    }

    public class Product1
    {
        public bool nullable { get; set; }
        public Oneof102[] oneOf { get; set; }
    }

    public class Oneof102
    {
        public string _ref { get; set; }
    }

    public class Costtypeid
    {
        public string type { get; set; }
        public string format { get; set; }
    }

    public class Costtype
    {
        public bool nullable { get; set; }
        public Oneof103[] oneOf { get; set; }
    }

    public class Oneof103
    {
        public string _ref { get; set; }
    }

    public class Amount
    {
        public bool nullable { get; set; }
        public Oneof104[] oneOf { get; set; }
    }

    public class Oneof104
    {
        public string _ref { get; set; }
    }

    public class Amounttax
    {
        public bool nullable { get; set; }
        public Oneof105[] oneOf { get; set; }
    }

    public class Oneof105
    {
        public string _ref { get; set; }
    }

    public class Costtypevalue
    {
        public string _ref { get; set; }
    }

    public class Costtype1
    {
        public string type { get; set; }
        public bool additionalProperties { get; set; }
        public Properties24 properties { get; set; }
    }

    public class Properties24
    {
        public Id20 Id { get; set; }
        public Value Value { get; set; }
        public Name8 Name { get; set; }
        public Description2 Description { get; set; }
        public Discountrules DiscountRules { get; set; }
    }

    public class Id20
    {
        public string type { get; set; }
        public string format { get; set; }
    }

    public class Value
    {
        public string _ref { get; set; }
    }

    public class Name8
    {
        public string type { get; set; }
        public bool nullable { get; set; }
    }

    public class Description2
    {
        public string type { get; set; }
        public bool nullable { get; set; }
    }

    public class Discountrules
    {
        public string type { get; set; }
        public bool nullable { get; set; }
        public Items103 items { get; set; }
    }

    public class Items103
    {
        public string _ref { get; set; }
    }

    public class Costtypevalue1
    {
        public string type { get; set; }
        public string description { get; set; }
        public string[] xenumNames { get; set; }
        public string[] _enum { get; set; }
    }

    public class Discountrule
    {
        public string type { get; set; }
        public bool additionalProperties { get; set; }
        public Properties25 properties { get; set; }
    }

    public class Properties25
    {
        public Id21 Id { get; set; }
        public Tag1 Tag { get; set; }
        public Orgunit10 OrgUnit { get; set; }
        public Orgunitid9 OrgUnitId { get; set; }
        public Catalog3 Catalog { get; set; }
        public Catalogid2 CatalogId { get; set; }
        public Effectivefromdate EffectiveFromDate { get; set; }
        public Discountfactor DiscountFactor { get; set; }
        public Resellerfeefactor ResellerFeeFactor { get; set; }
        public Calculationmethod CalculationMethod { get; set; }
        public Excludedcosttypes ExcludedCostTypes { get; set; }
    }

    public class Id21
    {
        public string type { get; set; }
        public string format { get; set; }
    }

    public class Tag1
    {
        public string type { get; set; }
        public bool nullable { get; set; }
    }

    public class Orgunit10
    {
        public bool nullable { get; set; }
        public Oneof106[] oneOf { get; set; }
    }

    public class Oneof106
    {
        public string _ref { get; set; }
    }

    public class Orgunitid9
    {
        public string type { get; set; }
        public string format { get; set; }
        public bool nullable { get; set; }
    }

    public class Catalog3
    {
        public bool nullable { get; set; }
        public Oneof107[] oneOf { get; set; }
    }

    public class Oneof107
    {
        public string _ref { get; set; }
    }

    public class Catalogid2
    {
        public string type { get; set; }
        public string format { get; set; }
    }

    public class Effectivefromdate
    {
        public string type { get; set; }
        public string format { get; set; }
    }

    public class Discountfactor
    {
        public string type { get; set; }
        public string format { get; set; }
    }

    public class Resellerfeefactor
    {
        public string type { get; set; }
        public string format { get; set; }
    }

    public class Calculationmethod
    {
        public string _ref { get; set; }
    }

    public class Excludedcosttypes
    {
        public string type { get; set; }
        public bool nullable { get; set; }
        public Items104 items { get; set; }
    }

    public class Items104
    {
        public string _ref { get; set; }
    }

    public class Discountcalculationmethod
    {
        public string type { get; set; }
        public string description { get; set; }
        public string[] xenumNames { get; set; }
        public string[] _enum { get; set; }
    }

    public class Monetaryquantity
    {
        public string type { get; set; }
        public bool additionalProperties { get; set; }
        public string[] required { get; set; }
        public Properties26 properties { get; set; }
    }

    public class Properties26
    {
        public Amount1 Amount { get; set; }
        public Currency Currency { get; set; }
    }

    public class Amount1
    {
        public string type { get; set; }
        public string format { get; set; }
        public bool nullable { get; set; }
    }

    public class Currency
    {
        public string type { get; set; }
        public int maxLength { get; set; }
        public int minLength { get; set; }
    }

    public class Productimportspecification
    {
        public string type { get; set; }
        public bool xabstract { get; set; }
        public bool additionalProperties { get; set; }
        public Properties27 properties { get; set; }
    }

    public class Properties27
    {
        public Id22 Id { get; set; }
        public Name9 Name { get; set; }
        public Lastimportdate LastImportDate { get; set; }
        public Catalogid3 CatalogId { get; set; }
        public Catalog4 Catalog { get; set; }
    }

    public class Id22
    {
        public string type { get; set; }
        public string format { get; set; }
    }

    public class Name9
    {
        public string type { get; set; }
        public bool nullable { get; set; }
    }

    public class Lastimportdate
    {
        public string type { get; set; }
        public string format { get; set; }
        public bool nullable { get; set; }
    }

    public class Catalogid3
    {
        public string type { get; set; }
        public string format { get; set; }
    }

    public class Catalog4
    {
        public bool nullable { get; set; }
        public Oneof108[] oneOf { get; set; }
    }

    public class Oneof108
    {
        public string _ref { get; set; }
    }

    public class Productgrouptype1
    {
        public string type { get; set; }
        public string description { get; set; }
        public string[] xenumNames { get; set; }
        public string[] _enum { get; set; }
    }

    public class Taxationindication1
    {
        public string type { get; set; }
        public string description { get; set; }
        public string[] xenumNames { get; set; }
        public string[] _enum { get; set; }
    }

    public class Orgunitbudget
    {
        public Allof4[] allOf { get; set; }
    }

    public class Allof4
    {
        public string _ref { get; set; }
        public string type { get; set; }
        public bool additionalProperties { get; set; }
        public Properties28 properties { get; set; }
    }

    public class Properties28
    {
        public Orgunitid10 OrgUnitId { get; set; }
        public Orgunit11 OrgUnit { get; set; }
        public Priority Priority { get; set; }
        public Warningthreshold WarningThreshold { get; set; }
        public Employeebudgets1 EmployeeBudgets { get; set; }
        public Sumofapprovedtransactionssofar SumOfApprovedTransactionsSoFar { get; set; }
        public Currentbalance CurrentBalance { get; set; }
        public Computedcurrentbalanceamount ComputedCurrentBalanceAmount { get; set; }
    }

    public class Orgunitid10
    {
        public string type { get; set; }
        public string format { get; set; }
    }

    public class Orgunit11
    {
        public bool nullable { get; set; }
        public Oneof109[] oneOf { get; set; }
    }

    public class Oneof109
    {
        public string _ref { get; set; }
    }

    public class Priority
    {
        public string type { get; set; }
        public string format { get; set; }
    }

    public class Warningthreshold
    {
        public bool nullable { get; set; }
        public Oneof110[] oneOf { get; set; }
    }

    public class Oneof110
    {
        public string _ref { get; set; }
    }

    public class Employeebudgets1
    {
        public string type { get; set; }
        public bool nullable { get; set; }
        public Items105 items { get; set; }
    }

    public class Items105
    {
        public string _ref { get; set; }
    }

    public class Sumofapprovedtransactionssofar
    {
        public bool nullable { get; set; }
        public Oneof111[] oneOf { get; set; }
    }

    public class Oneof111
    {
        public string _ref { get; set; }
    }

    public class Currentbalance
    {
        public bool nullable { get; set; }
        public Oneof112[] oneOf { get; set; }
    }

    public class Oneof112
    {
        public string _ref { get; set; }
    }

    public class Computedcurrentbalanceamount
    {
        public string type { get; set; }
        public string format { get; set; }
        public bool nullable { get; set; }
    }

    public class Employeebudget
    {
        public Allof5[] allOf { get; set; }
    }

    public class Allof5
    {
        public string _ref { get; set; }
        public string type { get; set; }
        public bool additionalProperties { get; set; }
        public Properties29 properties { get; set; }
    }

    public class Properties29
    {
        public Employeeid1 EmployeeId { get; set; }
        public Employee3 Employee { get; set; }
        public Orgunitbudgetid OrgUnitBudgetId { get; set; }
        public Orgunitbudget1 OrgUnitBudget { get; set; }
        public Transactions1 Transactions { get; set; }
        public Sumofapprovedtransactionssofar1 SumOfApprovedTransactionsSoFar { get; set; }
        public Currentbalance1 CurrentBalance { get; set; }
        public Computedcurrentbalanceamount1 ComputedCurrentBalanceAmount { get; set; }
    }

    public class Employeeid1
    {
        public string type { get; set; }
        public string format { get; set; }
    }

    public class Employee3
    {
        public bool nullable { get; set; }
        public Oneof113[] oneOf { get; set; }
    }

    public class Oneof113
    {
        public string _ref { get; set; }
    }

    public class Orgunitbudgetid
    {
        public string type { get; set; }
        public string format { get; set; }
    }

    public class Orgunitbudget1
    {
        public bool nullable { get; set; }
        public Oneof114[] oneOf { get; set; }
    }

    public class Oneof114
    {
        public string _ref { get; set; }
    }

    public class Transactions1
    {
        public string type { get; set; }
        public bool nullable { get; set; }
        public Items106 items { get; set; }
    }

    public class Items106
    {
        public string _ref { get; set; }
    }

    public class Sumofapprovedtransactionssofar1
    {
        public bool nullable { get; set; }
        public Oneof115[] oneOf { get; set; }
    }

    public class Oneof115
    {
        public string _ref { get; set; }
    }

    public class Currentbalance1
    {
        public bool nullable { get; set; }
        public Oneof116[] oneOf { get; set; }
    }

    public class Oneof116
    {
        public string _ref { get; set; }
    }

    public class Computedcurrentbalanceamount1
    {
        public string type { get; set; }
        public string format { get; set; }
        public bool nullable { get; set; }
    }

    public class Transaction
    {
        public string type { get; set; }
        public bool additionalProperties { get; set; }
        public Properties30 properties { get; set; }
    }

    public class Properties30
    {
        public Id23 Id { get; set; }
        public Createddate4 CreatedDate { get; set; }
        public Createdby4 CreatedBy { get; set; }
        public Lastmodifieddate4 LastModifiedDate { get; set; }
        public Lastmodifiedby4 LastModifiedBy { get; set; }
        public Employeebudgetid EmployeeBudgetId { get; set; }
        public Employeebudget1 EmployeeBudget { get; set; }
        public Usebudgets1 UseBudgets { get; set; }
        public Employeeid2 EmployeeId { get; set; }
        public Employee4 Employee { get; set; }
        public Employeenotes EmployeeNotes { get; set; }
        public Refundnotes RefundNotes { get; set; }
        public Tracktracecodeid2 TrackTraceCodeId { get; set; }
        public Tracktracecode2 TrackTraceCode { get; set; }
        public Productid1 ProductId { get; set; }
        public Product2 Product { get; set; }
        public Taxationpolicy TaxationPolicy { get; set; }
        public Priceadjustmentfactor1 PriceAdjustmentFactor { get; set; }
        public Listprice ListPrice { get; set; }
        public Listpricetax ListPriceTax { get; set; }
        public Employeelistprice EmployeeListPrice { get; set; }
        public Employeelistpricetax EmployeeListPriceTax { get; set; }
        public Amount2 Amount { get; set; }
        public State State { get; set; }
        public Isapprovalrequired IsApprovalRequired { get; set; }
        public Orgunitnotes OrgUnitNotes { get; set; }
        public Status3 Status { get; set; }
        public Taxationindication2 TaxationIndication { get; set; }
        public Isvalid IsValid { get; set; }
        public Employeedisplayname EmployeeDisplayName { get; set; }
        public Orgunitbudgetdisplayname OrgUnitBudgetDisplayName { get; set; }
        public Serializedproductcostcomponent SerializedProductCostComponent { get; set; }
        public Productcostcomponentid ProductCostComponentId { get; set; }
        public Productcostcomponent ProductCostComponent { get; set; }
        public Isexported IsExported { get; set; }
        public Isexportedforproductsupplier IsExportedForProductSupplier { get; set; }
        public Rating Rating { get; set; }
    }

    public class Id23
    {
        public string type { get; set; }
        public string format { get; set; }
    }

    public class Createddate4
    {
        public string type { get; set; }
        public string format { get; set; }
    }

    public class Createdby4
    {
        public string type { get; set; }
        public bool nullable { get; set; }
    }

    public class Lastmodifieddate4
    {
        public string type { get; set; }
        public string format { get; set; }
    }

    public class Lastmodifiedby4
    {
        public string type { get; set; }
        public bool nullable { get; set; }
    }

    public class Employeebudgetid
    {
        public string type { get; set; }
        public string format { get; set; }
        public bool nullable { get; set; }
    }

    public class Employeebudget1
    {
        public bool nullable { get; set; }
        public Oneof117[] oneOf { get; set; }
    }

    public class Oneof117
    {
        public string _ref { get; set; }
    }

    public class Usebudgets1
    {
        public string type { get; set; }
    }

    public class Employeeid2
    {
        public string type { get; set; }
        public string format { get; set; }
    }

    public class Employee4
    {
        public bool nullable { get; set; }
        public Oneof118[] oneOf { get; set; }
    }

    public class Oneof118
    {
        public string _ref { get; set; }
    }

    public class Employeenotes
    {
        public string type { get; set; }
        public bool nullable { get; set; }
    }

    public class Refundnotes
    {
        public string type { get; set; }
        public bool nullable { get; set; }
    }

    public class Tracktracecodeid2
    {
        public string type { get; set; }
        public string format { get; set; }
    }

    public class Tracktracecode2
    {
        public bool nullable { get; set; }
        public Oneof119[] oneOf { get; set; }
    }

    public class Oneof119
    {
        public string _ref { get; set; }
    }

    public class Productid1
    {
        public string type { get; set; }
        public string format { get; set; }
    }

    public class Product2
    {
        public bool nullable { get; set; }
        public Oneof120[] oneOf { get; set; }
    }

    public class Oneof120
    {
        public string _ref { get; set; }
    }

    public class Taxationpolicy
    {
        public string _ref { get; set; }
    }

    public class Priceadjustmentfactor1
    {
        public string type { get; set; }
        public string format { get; set; }
    }

    public class Listprice
    {
        public bool nullable { get; set; }
        public Oneof121[] oneOf { get; set; }
    }

    public class Oneof121
    {
        public string _ref { get; set; }
    }

    public class Listpricetax
    {
        public bool nullable { get; set; }
        public Oneof122[] oneOf { get; set; }
    }

    public class Oneof122
    {
        public string _ref { get; set; }
    }

    public class Employeelistprice
    {
        public bool nullable { get; set; }
        public Oneof123[] oneOf { get; set; }
    }

    public class Oneof123
    {
        public string _ref { get; set; }
    }

    public class Employeelistpricetax
    {
        public bool nullable { get; set; }
        public Oneof124[] oneOf { get; set; }
    }

    public class Oneof124
    {
        public string _ref { get; set; }
    }

    public class Amount2
    {
        public bool nullable { get; set; }
        public Oneof125[] oneOf { get; set; }
    }

    public class Oneof125
    {
        public string _ref { get; set; }
    }

    public class State
    {
        public string _ref { get; set; }
    }

    public class Isapprovalrequired
    {
        public string type { get; set; }
    }

    public class Orgunitnotes
    {
        public string type { get; set; }
        public bool nullable { get; set; }
    }

    public class Status3
    {
        public string _ref { get; set; }
    }

    public class Taxationindication2
    {
        public bool nullable { get; set; }
        public Oneof126[] oneOf { get; set; }
    }

    public class Oneof126
    {
        public string _ref { get; set; }
    }

    public class Isvalid
    {
        public string type { get; set; }
    }

    public class Employeedisplayname
    {
        public string type { get; set; }
        public bool nullable { get; set; }
    }

    public class Orgunitbudgetdisplayname
    {
        public string type { get; set; }
        public bool nullable { get; set; }
    }

    public class Serializedproductcostcomponent
    {
        public string type { get; set; }
        public bool nullable { get; set; }
    }

    public class Productcostcomponentid
    {
        public string type { get; set; }
        public bool nullable { get; set; }
    }

    public class Productcostcomponent
    {
        public bool nullable { get; set; }
        public Oneof127[] oneOf { get; set; }
    }

    public class Oneof127
    {
        public string _ref { get; set; }
    }

    public class Isexported
    {
        public string type { get; set; }
    }

    public class Isexportedforproductsupplier
    {
        public string type { get; set; }
    }

    public class Rating
    {
        public bool nullable { get; set; }
        public Oneof128[] oneOf { get; set; }
    }

    public class Oneof128
    {
        public string _ref { get; set; }
    }

    public class Transactionstate
    {
        public string type { get; set; }
        public string description { get; set; }
        public string[] xenumNames { get; set; }
        public string[] _enum { get; set; }
    }

    public class Transactionstatus
    {
        public string type { get; set; }
        public string description { get; set; }
        public string[] xenumNames { get; set; }
        public string[] _enum { get; set; }
    }

    public class Productcostcomponent1
    {
        public string type { get; set; }
        public bool additionalProperties { get; set; }
        public Properties31 properties { get; set; }
    }

    public class Properties31
    {
        public Id24 Id { get; set; }
        public Costcomponentid CostComponentId { get; set; }
        public Location Location { get; set; }
        public Startdate1 StartDate { get; set; }
        public Enddate EndDate { get; set; }
        public Costs Costs { get; set; }
        public Pricingspecification PricingSpecification { get; set; }
        public Pricespecification PriceSpecification { get; set; }
    }

    public class Id24
    {
        public string type { get; set; }
        public bool nullable { get; set; }
    }

    public class Costcomponentid
    {
        public string type { get; set; }
        public bool nullable { get; set; }
    }

    public class Location
    {
        public string type { get; set; }
        public bool nullable { get; set; }
    }

    public class Startdate1
    {
        public string type { get; set; }
        public string format { get; set; }
        public bool nullable { get; set; }
    }

    public class Enddate
    {
        public string type { get; set; }
        public string format { get; set; }
        public bool nullable { get; set; }
    }

    public class Costs
    {
        public string type { get; set; }
        public bool nullable { get; set; }
        public Items107 items { get; set; }
    }

    public class Items107
    {
        public string _ref { get; set; }
    }

    public class Pricingspecification
    {
        public bool nullable { get; set; }
        public Oneof129[] oneOf { get; set; }
    }

    public class Oneof129
    {
        public string _ref { get; set; }
    }

    public class Pricespecification
    {
        public bool nullable { get; set; }
        public Oneof130[] oneOf { get; set; }
    }

    public class Oneof130
    {
        public string _ref { get; set; }
    }

    public class Productcost
    {
        public string type { get; set; }
        public bool additionalProperties { get; set; }
        public Properties32 properties { get; set; }
    }

    public class Properties32
    {
        public Costtype2 CostType { get; set; }
        public Pricespecification1 PriceSpecification { get; set; }
    }

    public class Costtype2
    {
        public bool nullable { get; set; }
        public Oneof131[] oneOf { get; set; }
    }

    public class Oneof131
    {
        public string _ref { get; set; }
    }

    public class Pricespecification1
    {
        public bool nullable { get; set; }
        public Oneof132[] oneOf { get; set; }
    }

    public class Oneof132
    {
        public string _ref { get; set; }
    }

    public class Costtypecomponent
    {
        public string type { get; set; }
        public bool additionalProperties { get; set; }
        public Properties33 properties { get; set; }
    }

    public class Properties33
    {
        public Value1 Value { get; set; }
        public Description3 Description { get; set; }
    }

    public class Value1
    {
        public string _ref { get; set; }
    }

    public class Description3
    {
        public string type { get; set; }
        public bool nullable { get; set; }
    }

    public class Pricespecification2
    {
        public string type { get; set; }
        public bool additionalProperties { get; set; }
        public Properties34 properties { get; set; }
    }

    public class Properties34
    {
        public Listprice1 ListPrice { get; set; }
        public Listpricetax1 ListPriceTax { get; set; }
        public Employeelistprice1 EmployeeListPrice { get; set; }
        public Employeelistpricetax1 EmployeeListPriceTax { get; set; }
        public Displaylistprice DisplayListPrice { get; set; }
        public Displayemployeelistprice DisplayEmployeeListPrice { get; set; }
        public Discountamount DiscountAmount { get; set; }
        public Taxdiscountamount TaxDiscountAmount { get; set; }
        public Resellerfeeamount ResellerFeeAmount { get; set; }
        public Taxresellerfeeamount TaxResellerFeeAmount { get; set; }
    }

    public class Listprice1
    {
        public bool nullable { get; set; }
        public Oneof133[] oneOf { get; set; }
    }

    public class Oneof133
    {
        public string _ref { get; set; }
    }

    public class Listpricetax1
    {
        public bool nullable { get; set; }
        public Oneof134[] oneOf { get; set; }
    }

    public class Oneof134
    {
        public string _ref { get; set; }
    }

    public class Employeelistprice1
    {
        public bool nullable { get; set; }
        public Oneof135[] oneOf { get; set; }
    }

    public class Oneof135
    {
        public string _ref { get; set; }
    }

    public class Employeelistpricetax1
    {
        public bool nullable { get; set; }
        public Oneof136[] oneOf { get; set; }
    }

    public class Oneof136
    {
        public string _ref { get; set; }
    }

    public class Displaylistprice
    {
        public bool nullable { get; set; }
        public Oneof137[] oneOf { get; set; }
    }

    public class Oneof137
    {
        public string _ref { get; set; }
    }

    public class Displayemployeelistprice
    {
        public bool nullable { get; set; }
        public Oneof138[] oneOf { get; set; }
    }

    public class Oneof138
    {
        public string _ref { get; set; }
    }

    public class Discountamount
    {
        public bool nullable { get; set; }
        public Oneof139[] oneOf { get; set; }
    }

    public class Oneof139
    {
        public string _ref { get; set; }
    }

    public class Taxdiscountamount
    {
        public bool nullable { get; set; }
        public Oneof140[] oneOf { get; set; }
    }

    public class Oneof140
    {
        public string _ref { get; set; }
    }

    public class Resellerfeeamount
    {
        public bool nullable { get; set; }
        public Oneof141[] oneOf { get; set; }
    }

    public class Oneof141
    {
        public string _ref { get; set; }
    }

    public class Taxresellerfeeamount
    {
        public bool nullable { get; set; }
        public Oneof142[] oneOf { get; set; }
    }

    public class Oneof142
    {
        public string _ref { get; set; }
    }

    public class Pricingspecification1
    {
        public string type { get; set; }
        public bool additionalProperties { get; set; }
        public Properties35 properties { get; set; }
    }

    public class Properties35
    {
        public Taxationpolicy1 TaxationPolicy { get; set; }
        public Discountruleid DiscountRuleId { get; set; }
        public Discountfactor1 DiscountFactor { get; set; }
        public Resellerfeefactor1 ResellerFeeFactor { get; set; }
        public Calculationmethod1 CalculationMethod { get; set; }
        public Excludedcosttypes1 ExcludedCostTypes { get; set; }
    }

    public class Taxationpolicy1
    {
        public string _ref { get; set; }
    }

    public class Discountruleid
    {
        public string type { get; set; }
        public string format { get; set; }
        public bool nullable { get; set; }
    }

    public class Discountfactor1
    {
        public string type { get; set; }
        public string format { get; set; }
    }

    public class Resellerfeefactor1
    {
        public string type { get; set; }
        public string format { get; set; }
    }

    public class Calculationmethod1
    {
        public string _ref { get; set; }
    }

    public class Excludedcosttypes1
    {
        public string type { get; set; }
        public bool nullable { get; set; }
        public Items108 items { get; set; }
    }

    public class Items108
    {
        public string _ref { get; set; }
    }

    public class Transactionrating
    {
        public string type { get; set; }
        public bool additionalProperties { get; set; }
        public string[] required { get; set; }
        public Properties36 properties { get; set; }
    }

    public class Properties36
    {
        public Transactionid TransactionId { get; set; }
        public Transaction1 Transaction { get; set; }
        public Createddate5 CreatedDate { get; set; }
        public Createdby5 CreatedBy { get; set; }
        public Lastmodifieddate5 LastModifiedDate { get; set; }
        public Lastmodifiedby5 LastModifiedBy { get; set; }
        public Value2 Value { get; set; }
    }

    public class Transactionid
    {
        public string type { get; set; }
        public string format { get; set; }
    }

    public class Transaction1
    {
        public string _ref { get; set; }
    }

    public class Createddate5
    {
        public string type { get; set; }
        public string format { get; set; }
    }

    public class Createdby5
    {
        public string type { get; set; }
        public bool nullable { get; set; }
    }

    public class Lastmodifieddate5
    {
        public string type { get; set; }
        public string format { get; set; }
    }

    public class Lastmodifiedby5
    {
        public string type { get; set; }
        public bool nullable { get; set; }
    }

    public class Value2
    {
        public string type { get; set; }
        public string format { get; set; }
    }

    public class Budget
    {
        public string type { get; set; }
        public bool xabstract { get; set; }
        public bool additionalProperties { get; set; }
        public Properties37 properties { get; set; }
    }

    public class Properties37
    {
        public Id25 Id { get; set; }
        public Createddate6 CreatedDate { get; set; }
        public Createdby6 CreatedBy { get; set; }
        public Lastmodifieddate6 LastModifiedDate { get; set; }
        public Lastmodifiedby6 LastModifiedBy { get; set; }
        public Description4 Description { get; set; }
        public Startdate2 StartDate { get; set; }
        public Enddate1 EndDate { get; set; }
        public Initialamount InitialAmount { get; set; }
        public Adjustments Adjustments { get; set; }
        public Currentamount CurrentAmount { get; set; }
        public Iscurrentlyactive IsCurrentlyActive { get; set; }
    }

    public class Id25
    {
        public string type { get; set; }
        public string format { get; set; }
    }

    public class Createddate6
    {
        public string type { get; set; }
        public string format { get; set; }
    }

    public class Createdby6
    {
        public string type { get; set; }
        public bool nullable { get; set; }
    }

    public class Lastmodifieddate6
    {
        public string type { get; set; }
        public string format { get; set; }
    }

    public class Lastmodifiedby6
    {
        public string type { get; set; }
        public bool nullable { get; set; }
    }

    public class Description4
    {
        public string type { get; set; }
        public bool nullable { get; set; }
    }

    public class Startdate2
    {
        public string type { get; set; }
        public string format { get; set; }
    }

    public class Enddate1
    {
        public string type { get; set; }
        public string format { get; set; }
    }

    public class Initialamount
    {
        public bool nullable { get; set; }
        public Oneof143[] oneOf { get; set; }
    }

    public class Oneof143
    {
        public string _ref { get; set; }
    }

    public class Adjustments
    {
        public string type { get; set; }
        public bool nullable { get; set; }
        public Items109 items { get; set; }
    }

    public class Items109
    {
        public string _ref { get; set; }
    }

    public class Currentamount
    {
        public bool nullable { get; set; }
        public Oneof144[] oneOf { get; set; }
    }

    public class Oneof144
    {
        public string _ref { get; set; }
    }

    public class Iscurrentlyactive
    {
        public string type { get; set; }
    }

    public class Budgetadjustment
    {
        public string type { get; set; }
        public bool additionalProperties { get; set; }
        public Properties38 properties { get; set; }
    }

    public class Properties38
    {
        public Id26 Id { get; set; }
        public Createddate7 CreatedDate { get; set; }
        public Createdby7 CreatedBy { get; set; }
        public Lastmodifieddate7 LastModifiedDate { get; set; }
        public Lastmodifiedby7 LastModifiedBy { get; set; }
        public Reason Reason { get; set; }
        public Initialamount1 InitialAmount { get; set; }
        public Adjustedamount AdjustedAmount { get; set; }
        public Budgetid BudgetId { get; set; }
        public Budget1 Budget { get; set; }
    }

    public class Id26
    {
        public string type { get; set; }
        public string format { get; set; }
    }

    public class Createddate7
    {
        public string type { get; set; }
        public string format { get; set; }
    }

    public class Createdby7
    {
        public string type { get; set; }
        public bool nullable { get; set; }
    }

    public class Lastmodifieddate7
    {
        public string type { get; set; }
        public string format { get; set; }
    }

    public class Lastmodifiedby7
    {
        public string type { get; set; }
        public bool nullable { get; set; }
    }

    public class Reason
    {
        public string type { get; set; }
        public bool nullable { get; set; }
    }

    public class Initialamount1
    {
        public bool nullable { get; set; }
        public Oneof145[] oneOf { get; set; }
    }

    public class Oneof145
    {
        public string _ref { get; set; }
    }

    public class Adjustedamount
    {
        public bool nullable { get; set; }
        public Oneof146[] oneOf { get; set; }
    }

    public class Oneof146
    {
        public string _ref { get; set; }
    }

    public class Budgetid
    {
        public string type { get; set; }
        public string format { get; set; }
    }

    public class Budget1
    {
        public bool nullable { get; set; }
        public Oneof147[] oneOf { get; set; }
    }

    public class Oneof147
    {
        public string _ref { get; set; }
    }

    public class Userrole
    {
        public Allof6[] allOf { get; set; }
    }

    public class Allof6
    {
        public string _ref { get; set; }
        public string type { get; set; }
        public bool additionalProperties { get; set; }
    }

    public class Identityuserroleofint64
    {
        public string type { get; set; }
        public bool additionalProperties { get; set; }
        public Properties39 properties { get; set; }
    }

    public class Properties39
    {
        public Userid UserId { get; set; }
        public Roleid RoleId { get; set; }
    }

    public class Userid
    {
        public string type { get; set; }
        public string format { get; set; }
    }

    public class Roleid
    {
        public string type { get; set; }
        public string format { get; set; }
    }

    public class Userclaim
    {
        public Allof7[] allOf { get; set; }
    }

    public class Allof7
    {
        public string _ref { get; set; }
        public string type { get; set; }
        public bool additionalProperties { get; set; }
    }

    public class Identityuserclaimofint64
    {
        public string type { get; set; }
        public bool additionalProperties { get; set; }
        public Properties40 properties { get; set; }
    }

    public class Properties40
    {
        public Id27 Id { get; set; }
        public Userid1 UserId { get; set; }
        public Claimtype ClaimType { get; set; }
        public Claimvalue ClaimValue { get; set; }
    }

    public class Id27
    {
        public string type { get; set; }
        public string format { get; set; }
    }

    public class Userid1
    {
        public string type { get; set; }
        public string format { get; set; }
    }

    public class Claimtype
    {
        public string type { get; set; }
        public bool nullable { get; set; }
    }

    public class Claimvalue
    {
        public string type { get; set; }
        public bool nullable { get; set; }
    }

    public class Userlogin
    {
        public Allof8[] allOf { get; set; }
    }

    public class Allof8
    {
        public string _ref { get; set; }
        public string type { get; set; }
        public bool additionalProperties { get; set; }
    }

    public class Identityuserloginofint64
    {
        public string type { get; set; }
        public bool additionalProperties { get; set; }
        public Properties41 properties { get; set; }
    }

    public class Properties41
    {
        public Loginprovider LoginProvider { get; set; }
        public Providerkey ProviderKey { get; set; }
        public Userid2 UserId { get; set; }
    }

    public class Loginprovider
    {
        public string type { get; set; }
        public bool nullable { get; set; }
    }

    public class Providerkey
    {
        public string type { get; set; }
        public bool nullable { get; set; }
    }

    public class Userid2
    {
        public string type { get; set; }
        public string format { get; set; }
    }

    public class Identityuserofint64anduserloginanduserroleanduserclaim
    {
        public string type { get; set; }
        public bool additionalProperties { get; set; }
        public Properties42 properties { get; set; }
    }

    public class Properties42
    {
        public Roles1 Roles { get; set; }
        public Claims1 Claims { get; set; }
        public Logins1 Logins { get; set; }
        public Email1 Email { get; set; }
        public Emailconfirmed1 EmailConfirmed { get; set; }
        public Passwordhash1 PasswordHash { get; set; }
        public Securitystamp1 SecurityStamp { get; set; }
        public Phonenumber2 PhoneNumber { get; set; }
        public Phonenumberconfirmed1 PhoneNumberConfirmed { get; set; }
        public Twofactorenabled1 TwoFactorEnabled { get; set; }
        public Lockoutenddateutc1 LockoutEndDateUtc { get; set; }
        public Lockoutenabled1 LockoutEnabled { get; set; }
        public Accessfailedcount1 AccessFailedCount { get; set; }
        public Id28 Id { get; set; }
        public Username1 UserName { get; set; }
    }

    public class Roles1
    {
        public string type { get; set; }
        public bool nullable { get; set; }
        public Items110 items { get; set; }
    }

    public class Items110
    {
        public string _ref { get; set; }
    }

    public class Claims1
    {
        public string type { get; set; }
        public bool nullable { get; set; }
        public Items111 items { get; set; }
    }

    public class Items111
    {
        public string _ref { get; set; }
    }

    public class Logins1
    {
        public string type { get; set; }
        public bool nullable { get; set; }
        public Items112 items { get; set; }
    }

    public class Items112
    {
        public string _ref { get; set; }
    }

    public class Email1
    {
        public string type { get; set; }
        public bool nullable { get; set; }
    }

    public class Emailconfirmed1
    {
        public string type { get; set; }
    }

    public class Passwordhash1
    {
        public string type { get; set; }
        public bool nullable { get; set; }
    }

    public class Securitystamp1
    {
        public string type { get; set; }
        public bool nullable { get; set; }
    }

    public class Phonenumber2
    {
        public string type { get; set; }
        public bool nullable { get; set; }
    }

    public class Phonenumberconfirmed1
    {
        public string type { get; set; }
    }

    public class Twofactorenabled1
    {
        public string type { get; set; }
    }

    public class Lockoutenddateutc1
    {
        public string type { get; set; }
        public string format { get; set; }
        public bool nullable { get; set; }
    }

    public class Lockoutenabled1
    {
        public string type { get; set; }
    }

    public class Accessfailedcount1
    {
        public string type { get; set; }
        public string format { get; set; }
    }

    public class Id28
    {
        public string type { get; set; }
        public string format { get; set; }
    }

    public class Username1
    {
        public string type { get; set; }
        public bool nullable { get; set; }
    }

    public class Periodemployee
    {
        public string type { get; set; }
        public bool additionalProperties { get; set; }
        public string[] required { get; set; }
        public Properties43 properties { get; set; }
    }

    public class Properties43
    {
        public Id29 Id { get; set; }
        public Employee5 Employee { get; set; }
        public Employeeid3 EmployeeId { get; set; }
        public Citizenservicenumber CitizenServiceNumber { get; set; }
        public Initials Initials { get; set; }
        public Firstname FirstName { get; set; }
        public Insertion Insertion { get; set; }
        public Lastname LastName { get; set; }
        public Maidenname MaidenName { get; set; }
        public Dateofbirth DateOfBirth { get; set; }
        public Gender Gender { get; set; }
        public Civilstatus CivilStatus { get; set; }
        public Civilstatusstartdate CivilStatusStartDate { get; set; }
        public Numberofchildren NumberOfChildren { get; set; }
        public Street Street { get; set; }
        public Housenumber HouseNumber { get; set; }
        public Housenumbersuffix HouseNumberSuffix { get; set; }
        public Postalcode1 PostalCode { get; set; }
        public City1 City { get; set; }
        public Countrycode CountryCode { get; set; }
        public Phone Phone { get; set; }
        public Mobilephone MobilePhone { get; set; }
        public Emergencyphone EmergencyPhone { get; set; }
        public Emergencyname EmergencyName { get; set; }
        public Bankcountrycode BankCountryCode { get; set; }
        public Bankbic BankBic { get; set; }
        public Bankiban BankIban { get; set; }
        public Functionname FunctionName { get; set; }
        public Parttimefactor ParttimeFactor { get; set; }
        public Servicestartdate ServiceStartDate { get; set; }
        public Serviceenddate ServiceEndDate { get; set; }
        public Hourlywage HourlyWage { get; set; }
        public Monthlywage MonthlyWage { get; set; }
        public Wagetaxcredit WageTaxCredit { get; set; }
        public Individualbudgetbalance IndividualBudgetBalance { get; set; }
        public Individualbudgetbalanceforperiod IndividualBudgetBalanceForPeriod { get; set; }
        public Individualbudgetleaveforperiod IndividualBudgetLeaveForPeriod { get; set; }
        public Vitalityhoursbalance VitalityHoursBalance { get; set; }
        public Careerbudgetbalance CareerBudgetBalance { get; set; }
        public Salaryvalues SalaryValues { get; set; }
        public Leavevalues LeaveValues { get; set; }
        public Illnessanddisabilityvalues IllnessAndDisabilityValues { get; set; }
        public Retirementvalues RetirementValues { get; set; }
        public Provisionsandinsurancevalues ProvisionsAndInsuranceValues { get; set; }
        public Sustainableemployabilityvalues SustainableEmployabilityValues { get; set; }
        public Keyvaluestore KeyValueStore { get; set; }
        public Emailaddress EmailAddress { get; set; }
        public Period Period { get; set; }
        public Year Year { get; set; }
        public Displayname4 DisplayName { get; set; }
        public Orgunitid11 OrgUnitId { get; set; }
        public Iscurrent IsCurrent { get; set; }
    }

    public class Id29
    {
        public string type { get; set; }
        public string format { get; set; }
    }

    public class Employee5
    {
        public bool nullable { get; set; }
        public Oneof148[] oneOf { get; set; }
    }

    public class Oneof148
    {
        public string _ref { get; set; }
    }

    public class Employeeid3
    {
        public string type { get; set; }
        public string format { get; set; }
    }

    public class Citizenservicenumber
    {
        public string title { get; set; }
        public string type { get; set; }
        public string format { get; set; }
        public bool nullable { get; set; }
    }

    public class Initials
    {
        public string title { get; set; }
        public string type { get; set; }
        public bool nullable { get; set; }
    }

    public class Firstname
    {
        public string title { get; set; }
        public string type { get; set; }
        public int minLength { get; set; }
    }

    public class Insertion
    {
        public string type { get; set; }
        public bool nullable { get; set; }
    }

    public class Lastname
    {
        public string title { get; set; }
        public string type { get; set; }
        public int minLength { get; set; }
    }

    public class Maidenname
    {
        public string title { get; set; }
        public string type { get; set; }
        public bool nullable { get; set; }
    }

    public class Dateofbirth
    {
        public string title { get; set; }
        public string type { get; set; }
        public string format { get; set; }
        public bool nullable { get; set; }
    }

    public class Gender
    {
        public string _ref { get; set; }
    }

    public class Civilstatus
    {
        public string title { get; set; }
        public Oneof149[] oneOf { get; set; }
    }

    public class Oneof149
    {
        public string _ref { get; set; }
    }

    public class Civilstatusstartdate
    {
        public string type { get; set; }
        public string format { get; set; }
        public bool nullable { get; set; }
    }

    public class Numberofchildren
    {
        public string type { get; set; }
        public string format { get; set; }
        public bool nullable { get; set; }
    }

    public class Street
    {
        public string type { get; set; }
        public bool nullable { get; set; }
    }

    public class Housenumber
    {
        public string type { get; set; }
        public bool nullable { get; set; }
    }

    public class Housenumbersuffix
    {
        public string type { get; set; }
        public bool nullable { get; set; }
    }

    public class Postalcode1
    {
        public string type { get; set; }
        public bool nullable { get; set; }
    }

    public class City1
    {
        public string type { get; set; }
        public bool nullable { get; set; }
    }

    public class Countrycode
    {
        public string type { get; set; }
        public int maxLength { get; set; }
        public bool nullable { get; set; }
    }

    public class Phone
    {
        public string type { get; set; }
        public bool nullable { get; set; }
    }

    public class Mobilephone
    {
        public string type { get; set; }
        public bool nullable { get; set; }
    }

    public class Emergencyphone
    {
        public string type { get; set; }
        public bool nullable { get; set; }
    }

    public class Emergencyname
    {
        public string type { get; set; }
        public bool nullable { get; set; }
    }

    public class Bankcountrycode
    {
        public string type { get; set; }
        public int maxLength { get; set; }
        public bool nullable { get; set; }
    }

    public class Bankbic
    {
        public string type { get; set; }
        public bool nullable { get; set; }
    }

    public class Bankiban
    {
        public string type { get; set; }
        public bool nullable { get; set; }
    }

    public class Functionname
    {
        public string title { get; set; }
        public string type { get; set; }
        public bool nullable { get; set; }
    }

    public class Parttimefactor
    {
        public string title { get; set; }
        public string type { get; set; }
        public string format { get; set; }
        public float maximum { get; set; }
        public float minimum { get; set; }
        public bool nullable { get; set; }
    }

    public class Servicestartdate
    {
        public string title { get; set; }
        public string type { get; set; }
        public string format { get; set; }
        public bool nullable { get; set; }
    }

    public class Serviceenddate
    {
        public string title { get; set; }
        public string type { get; set; }
        public string format { get; set; }
        public bool nullable { get; set; }
    }

    public class Hourlywage
    {
        public string title { get; set; }
        public string type { get; set; }
        public string format { get; set; }
        public float maximum { get; set; }
        public float minimum { get; set; }
        public bool nullable { get; set; }
    }

    public class Monthlywage
    {
        public string title { get; set; }
        public string type { get; set; }
        public string format { get; set; }
        public float maximum { get; set; }
        public float minimum { get; set; }
        public bool nullable { get; set; }
    }

    public class Wagetaxcredit
    {
        public string type { get; set; }
        public bool nullable { get; set; }
    }

    public class Individualbudgetbalance
    {
        public string title { get; set; }
        public string type { get; set; }
        public string format { get; set; }
        public bool nullable { get; set; }
    }

    public class Individualbudgetbalanceforperiod
    {
        public string type { get; set; }
        public string format { get; set; }
        public bool nullable { get; set; }
    }

    public class Individualbudgetleaveforperiod
    {
        public string type { get; set; }
        public string format { get; set; }
        public bool nullable { get; set; }
    }

    public class Vitalityhoursbalance
    {
        public string type { get; set; }
        public string format { get; set; }
        public bool nullable { get; set; }
    }

    public class Careerbudgetbalance
    {
        public string type { get; set; }
        public string format { get; set; }
        public bool nullable { get; set; }
    }

    public class Salaryvalues
    {
        public string type { get; set; }
        public bool nullable { get; set; }
    }

    public class Leavevalues
    {
        public string type { get; set; }
        public bool nullable { get; set; }
    }

    public class Illnessanddisabilityvalues
    {
        public string type { get; set; }
        public bool nullable { get; set; }
    }

    public class Retirementvalues
    {
        public string type { get; set; }
        public bool nullable { get; set; }
    }

    public class Provisionsandinsurancevalues
    {
        public string type { get; set; }
        public bool nullable { get; set; }
    }

    public class Sustainableemployabilityvalues
    {
        public string type { get; set; }
        public bool nullable { get; set; }
    }

    public class Keyvaluestore
    {
        public string type { get; set; }
        public bool nullable { get; set; }
    }

    public class Emailaddress
    {
        public string title { get; set; }
        public string type { get; set; }
        public string format { get; set; }
        public int maxLength { get; set; }
        public int minLength { get; set; }
    }

    public class Period
    {
        public string title { get; set; }
        public string type { get; set; }
        public float maximum { get; set; }
        public float minimum { get; set; }
        public bool nullable { get; set; }
    }

    public class Year
    {
        public string title { get; set; }
        public string type { get; set; }
        public float maximum { get; set; }
        public float minimum { get; set; }
        public bool nullable { get; set; }
    }

    public class Displayname4
    {
        public string type { get; set; }
        public bool nullable { get; set; }
    }

    public class Orgunitid11
    {
        public string type { get; set; }
        public string format { get; set; }
    }

    public class Iscurrent
    {
        public string type { get; set; }
    }

    public class Gender1
    {
        public string type { get; set; }
        public string description { get; set; }
        public string[] xenumNames { get; set; }
        public string[] _enum { get; set; }
    }

    public class Civilstatus1
    {
        public string type { get; set; }
        public string description { get; set; }
        public string[] xenumNames { get; set; }
        public string[] _enum { get; set; }
    }

    public class Iperiodemployee
    {
        public string type { get; set; }
        public bool xabstract { get; set; }
        public bool additionalProperties { get; set; }
    }

    public class Employeefile
    {
        public Allof9[] allOf { get; set; }
    }

    public class Allof9
    {
        public string _ref { get; set; }
        public string type { get; set; }
        public bool additionalProperties { get; set; }
        public Properties44 properties { get; set; }
    }

    public class Properties44
    {
        public Employee6 Employee { get; set; }
        public Employeeid4 EmployeeId { get; set; }
        public Period1 Period { get; set; }
        public Year1 Year { get; set; }
        public Filetype FileType { get; set; }
    }

    public class Employee6
    {
        public bool nullable { get; set; }
        public Oneof150[] oneOf { get; set; }
    }

    public class Oneof150
    {
        public string _ref { get; set; }
    }

    public class Employeeid4
    {
        public string type { get; set; }
        public string format { get; set; }
    }

    public class Period1
    {
        public string type { get; set; }
        public bool nullable { get; set; }
    }

    public class Year1
    {
        public string type { get; set; }
        public bool nullable { get; set; }
    }

    public class Filetype
    {
        public string _ref { get; set; }
    }

    public class Employeefiletype
    {
        public string type { get; set; }
        public string description { get; set; }
        public string[] xenumNames { get; set; }
        public string[] _enum { get; set; }
    }

    public class Employeedatamodification
    {
        public string type { get; set; }
        public bool additionalProperties { get; set; }
        public Properties45 properties { get; set; }
    }

    public class Properties45
    {
        public Id30 Id { get; set; }
        public Createddate8 CreatedDate { get; set; }
        public Createdby8 CreatedBy { get; set; }
        public Lastmodifieddate8 LastModifiedDate { get; set; }
        public Lastmodifiedby8 LastModifiedBy { get; set; }
        public Employee7 Employee { get; set; }
        public Employeeid5 EmployeeId { get; set; }
        public Orgunitid12 OrgUnitId { get; set; }
        public Tracktracecodeid3 TrackTraceCodeId { get; set; }
        public Tracktracecode3 TrackTraceCode { get; set; }
        public Effectivedate EffectiveDate { get; set; }
        public Workflowstatus WorkflowStatus { get; set; }
        public Workflowstatusreason WorkflowStatusReason { get; set; }
        public Civilstatus2 CivilStatus { get; set; }
        public Civilstatusstartdate1 CivilStatusStartDate { get; set; }
        public Numberofchildren1 NumberOfChildren { get; set; }
        public Street1 Street { get; set; }
        public Housenumber1 HouseNumber { get; set; }
        public Housenumbersuffix1 HouseNumberSuffix { get; set; }
        public Postalcode2 PostalCode { get; set; }
        public City2 City { get; set; }
        public Countrycode1 CountryCode { get; set; }
        public Phone1 Phone { get; set; }
        public Mobilephone1 MobilePhone { get; set; }
        public Emergencyphone1 EmergencyPhone { get; set; }
        public Emergencyname1 EmergencyName { get; set; }
        public Bankcountrycode1 BankCountryCode { get; set; }
        public Bankbic1 BankBic { get; set; }
        public Bankiban1 BankIban { get; set; }
    }

    public class Id30
    {
        public string type { get; set; }
        public string format { get; set; }
    }

    public class Createddate8
    {
        public string type { get; set; }
        public string format { get; set; }
    }

    public class Createdby8
    {
        public string type { get; set; }
        public bool nullable { get; set; }
    }

    public class Lastmodifieddate8
    {
        public string type { get; set; }
        public string format { get; set; }
    }

    public class Lastmodifiedby8
    {
        public string type { get; set; }
        public bool nullable { get; set; }
    }

    public class Employee7
    {
        public bool nullable { get; set; }
        public Oneof151[] oneOf { get; set; }
    }

    public class Oneof151
    {
        public string _ref { get; set; }
    }

    public class Employeeid5
    {
        public string type { get; set; }
        public string format { get; set; }
    }

    public class Orgunitid12
    {
        public string type { get; set; }
        public string format { get; set; }
    }

    public class Tracktracecodeid3
    {
        public string type { get; set; }
        public string format { get; set; }
    }

    public class Tracktracecode3
    {
        public bool nullable { get; set; }
        public Oneof152[] oneOf { get; set; }
    }

    public class Oneof152
    {
        public string _ref { get; set; }
    }

    public class Effectivedate
    {
        public string type { get; set; }
        public string format { get; set; }
        public bool nullable { get; set; }
    }

    public class Workflowstatus
    {
        public string _ref { get; set; }
    }

    public class Workflowstatusreason
    {
        public string type { get; set; }
        public bool nullable { get; set; }
    }

    public class Civilstatus2
    {
        public string title { get; set; }
        public Oneof153[] oneOf { get; set; }
    }

    public class Oneof153
    {
        public string _ref { get; set; }
    }

    public class Civilstatusstartdate1
    {
        public string type { get; set; }
        public string format { get; set; }
        public bool nullable { get; set; }
    }

    public class Numberofchildren1
    {
        public string type { get; set; }
        public string format { get; set; }
        public bool nullable { get; set; }
    }

    public class Street1
    {
        public string type { get; set; }
        public bool nullable { get; set; }
    }

    public class Housenumber1
    {
        public string type { get; set; }
        public bool nullable { get; set; }
    }

    public class Housenumbersuffix1
    {
        public string type { get; set; }
        public bool nullable { get; set; }
    }

    public class Postalcode2
    {
        public string type { get; set; }
        public bool nullable { get; set; }
    }

    public class City2
    {
        public string type { get; set; }
        public bool nullable { get; set; }
    }

    public class Countrycode1
    {
        public string type { get; set; }
        public int maxLength { get; set; }
        public bool nullable { get; set; }
    }

    public class Phone1
    {
        public string type { get; set; }
        public bool nullable { get; set; }
    }

    public class Mobilephone1
    {
        public string type { get; set; }
        public bool nullable { get; set; }
    }

    public class Emergencyphone1
    {
        public string type { get; set; }
        public bool nullable { get; set; }
    }

    public class Emergencyname1
    {
        public string type { get; set; }
        public bool nullable { get; set; }
    }

    public class Bankcountrycode1
    {
        public string type { get; set; }
        public int maxLength { get; set; }
        public bool nullable { get; set; }
    }

    public class Bankbic1
    {
        public string type { get; set; }
        public bool nullable { get; set; }
    }

    public class Bankiban1
    {
        public string type { get; set; }
        public bool nullable { get; set; }
    }

    public class Workflowstatus1
    {
        public string type { get; set; }
        public string description { get; set; }
        public string[] xenumNames { get; set; }
        public string[] _enum { get; set; }
    }

    public class Profile_Tag
    {
        public string type { get; set; }
        public bool additionalProperties { get; set; }
        public Properties46 properties { get; set; }
    }

    public class Properties46
    {
        public Id31 Id { get; set; }
        public Profileid1 ProfileId { get; set; }
        public Profile2 Profile { get; set; }
        public Tagid TagId { get; set; }
        public Tag2 Tag { get; set; }
        public Taginclusion TagInclusion { get; set; }
    }

    public class Id31
    {
        public string type { get; set; }
        public string format { get; set; }
    }

    public class Profileid1
    {
        public string type { get; set; }
        public string format { get; set; }
    }

    public class Profile2
    {
        public bool nullable { get; set; }
        public Oneof154[] oneOf { get; set; }
    }

    public class Oneof154
    {
        public string _ref { get; set; }
    }

    public class Tagid
    {
        public string type { get; set; }
        public string format { get; set; }
    }

    public class Tag2
    {
        public bool nullable { get; set; }
        public Oneof155[] oneOf { get; set; }
    }

    public class Oneof155
    {
        public string _ref { get; set; }
    }

    public class Taginclusion
    {
        public string _ref { get; set; }
    }

    public class Taginclusion1
    {
        public string type { get; set; }
        public string description { get; set; }
        public string[] xenumNames { get; set; }
        public string[] _enum { get; set; }
    }

    public class Plan
    {
        public string type { get; set; }
        public bool additionalProperties { get; set; }
        public string[] required { get; set; }
        public Properties47 properties { get; set; }
    }

    public class Properties47
    {
        public Id32 Id { get; set; }
        public Createddate9 CreatedDate { get; set; }
        public Createdby9 CreatedBy { get; set; }
        public Lastmodifieddate9 LastModifiedDate { get; set; }
        public Lastmodifiedby9 LastModifiedBy { get; set; }
        public Deadline Deadline { get; set; }
        public Isdone IsDone { get; set; }
        public Isfeedbackenabled IsFeedbackEnabled { get; set; }
        public Name10 Name { get; set; }
        public Description5 Description { get; set; }
        public Profileid2 ProfileId { get; set; }
        public Profile3 Profile { get; set; }
        public Tagid1 TagId { get; set; }
        public Tag3 Tag { get; set; }
        public Comments Comments { get; set; }
    }

    public class Id32
    {
        public string type { get; set; }
        public string format { get; set; }
    }

    public class Createddate9
    {
        public string type { get; set; }
        public string format { get; set; }
    }

    public class Createdby9
    {
        public string type { get; set; }
        public bool nullable { get; set; }
    }

    public class Lastmodifieddate9
    {
        public string type { get; set; }
        public string format { get; set; }
    }

    public class Lastmodifiedby9
    {
        public string type { get; set; }
        public bool nullable { get; set; }
    }

    public class Deadline
    {
        public string type { get; set; }
        public string format { get; set; }
        public bool nullable { get; set; }
        public string example { get; set; }
    }

    public class Isdone
    {
        public string type { get; set; }
    }

    public class Isfeedbackenabled
    {
        public string type { get; set; }
    }

    public class Name10
    {
        public string type { get; set; }
        public int minLength { get; set; }
    }

    public class Description5
    {
        public string type { get; set; }
        public bool nullable { get; set; }
    }

    public class Profileid2
    {
        public string type { get; set; }
        public string format { get; set; }
    }

    public class Profile3
    {
        public bool nullable { get; set; }
        public Oneof156[] oneOf { get; set; }
    }

    public class Oneof156
    {
        public string _ref { get; set; }
    }

    public class Tagid1
    {
        public string type { get; set; }
        public string format { get; set; }
    }

    public class Tag3
    {
        public bool nullable { get; set; }
        public Oneof157[] oneOf { get; set; }
    }

    public class Oneof157
    {
        public string _ref { get; set; }
    }

    public class Comments
    {
        public string type { get; set; }
        public bool nullable { get; set; }
        public Items113 items { get; set; }
    }

    public class Items113
    {
        public string _ref { get; set; }
    }

    public class Plancomment
    {
        public string type { get; set; }
        public bool additionalProperties { get; set; }
        public string[] required { get; set; }
        public Properties48 properties { get; set; }
    }

    public class Properties48
    {
        public Id33 Id { get; set; }
        public Createddate10 CreatedDate { get; set; }
        public Createdby10 CreatedBy { get; set; }
        public Lastmodifieddate10 LastModifiedDate { get; set; }
        public Lastmodifiedby10 LastModifiedBy { get; set; }
        public Message1 Message { get; set; }
        public Planid PlanId { get; set; }
        public Plan1 Plan { get; set; }
    }

    public class Id33
    {
        public string type { get; set; }
        public string format { get; set; }
    }

    public class Createddate10
    {
        public string type { get; set; }
        public string format { get; set; }
    }

    public class Createdby10
    {
        public string type { get; set; }
        public bool nullable { get; set; }
    }

    public class Lastmodifieddate10
    {
        public string type { get; set; }
        public string format { get; set; }
    }

    public class Lastmodifiedby10
    {
        public string type { get; set; }
        public bool nullable { get; set; }
    }

    public class Message1
    {
        public string type { get; set; }
        public int minLength { get; set; }
    }

    public class Planid
    {
        public string type { get; set; }
        public string format { get; set; }
    }

    public class Plan1
    {
        public bool nullable { get; set; }
        public Oneof158[] oneOf { get; set; }
    }

    public class Oneof158
    {
        public string _ref { get; set; }
    }

    public class Survey1
    {
        public string type { get; set; }
        public bool additionalProperties { get; set; }
        public Properties49 properties { get; set; }
    }

    public class Properties49
    {
        public Id34 Id { get; set; }
        public Key1 Key { get; set; }
        public Version Version { get; set; }
        public Type1 Type { get; set; }
        public Serializeddata1 SerializedData { get; set; }
        public Responses212 Responses { get; set; }
    }

    public class Id34
    {
        public string type { get; set; }
        public string format { get; set; }
    }

    public class Key1
    {
        public string type { get; set; }
        public int maxLength { get; set; }
        public bool nullable { get; set; }
    }

    public class Version
    {
        public string type { get; set; }
        public string format { get; set; }
    }

    public class Type1
    {
        public string type { get; set; }
        public bool nullable { get; set; }
    }

    public class Serializeddata1
    {
        public string type { get; set; }
        public bool nullable { get; set; }
    }

    public class Responses212
    {
        public string type { get; set; }
        public bool nullable { get; set; }
        public Items114 items { get; set; }
    }

    public class Items114
    {
        public string _ref { get; set; }
    }

    public class Singleresultoftag
    {
        public Allof10[] allOf { get; set; }
    }

    public class Allof10
    {
        public string _ref { get; set; }
        public string type { get; set; }
        public bool additionalProperties { get; set; }
        public Properties50 properties { get; set; }
    }

    public class Properties50
    {
        public Queryable Queryable { get; set; }
    }

    public class Queryable
    {
        public string type { get; set; }
        public bool nullable { get; set; }
        public Items115 items { get; set; }
    }

    public class Items115
    {
        public string _ref { get; set; }
    }

    public class Singleresult
    {
        public string type { get; set; }
        public string description { get; set; }
        public bool xabstract { get; set; }
        public bool additionalProperties { get; set; }
        public Properties51 properties { get; set; }
    }

    public class Properties51
    {
        public Queryable1 Queryable { get; set; }
    }

    public class Queryable1
    {
        public string type { get; set; }
        public string description { get; set; }
        public bool nullable { get; set; }
        public Items116 items { get; set; }
    }

    public class Items116
    {
    }

    public class Registerorgunitimpersonationparameters
    {
        public string type { get; set; }
        public bool additionalProperties { get; set; }
        public string[] required { get; set; }
        public Properties52 properties { get; set; }
    }

    public class Properties52
    {
        public Orgunitid13 OrgUnitId { get; set; }
    }

    public class Orgunitid13
    {
        public string type { get; set; }
        public string format { get; set; }
    }

    public class Singleresultoffile
    {
        public Allof11[] allOf { get; set; }
    }

    public class Allof11
    {
        public string _ref { get; set; }
        public string type { get; set; }
        public bool additionalProperties { get; set; }
        public Properties53 properties { get; set; }
    }

    public class Properties53
    {
        public Queryable2 Queryable { get; set; }
    }

    public class Queryable2
    {
        public string type { get; set; }
        public bool nullable { get; set; }
        public Items117 items { get; set; }
    }

    public class Items117
    {
        public string _ref { get; set; }
    }

    public class Singleresultofplan
    {
        public Allof12[] allOf { get; set; }
    }

    public class Allof12
    {
        public string _ref { get; set; }
        public string type { get; set; }
        public bool additionalProperties { get; set; }
        public Properties54 properties { get; set; }
    }

    public class Properties54
    {
        public Queryable3 Queryable { get; set; }
    }

    public class Queryable3
    {
        public string type { get; set; }
        public bool nullable { get; set; }
        public Items118 items { get; set; }
    }

    public class Items118
    {
        public string _ref { get; set; }
    }

    public class Role
    {
        public Allof13[] allOf { get; set; }
    }

    public class Allof13
    {
        public string _ref { get; set; }
        public string type { get; set; }
        public bool additionalProperties { get; set; }
        public Properties55 properties { get; set; }
    }

    public class Properties55
    {
        public Issystemrole IsSystemRole { get; set; }
        public Oauthname OAuthName { get; set; }
        public Name11 Name { get; set; }
    }

    public class Issystemrole
    {
        public string type { get; set; }
    }

    public class Oauthname
    {
        public string type { get; set; }
        public bool nullable { get; set; }
    }

    public class Name11
    {
        public string type { get; set; }
        public bool nullable { get; set; }
    }

    public class Identityroleofint64anduserrole
    {
        public string type { get; set; }
        public bool additionalProperties { get; set; }
        public Properties56 properties { get; set; }
    }

    public class Properties56
    {
        public Users1 Users { get; set; }
        public Id35 Id { get; set; }
        public Name12 Name { get; set; }
    }

    public class Users1
    {
        public string type { get; set; }
        public bool nullable { get; set; }
        public Items119 items { get; set; }
    }

    public class Items119
    {
        public string _ref { get; set; }
    }

    public class Id35
    {
        public string type { get; set; }
        public string format { get; set; }
    }

    public class Name12
    {
        public string type { get; set; }
        public bool nullable { get; set; }
    }

    public class Singleresultofrole
    {
        public Allof14[] allOf { get; set; }
    }

    public class Allof14
    {
        public string _ref { get; set; }
        public string type { get; set; }
        public bool additionalProperties { get; set; }
        public Properties57 properties { get; set; }
    }

    public class Properties57
    {
        public Queryable4 Queryable { get; set; }
    }

    public class Queryable4
    {
        public string type { get; set; }
        public bool nullable { get; set; }
        public Items120 items { get; set; }
    }

    public class Items120
    {
        public string _ref { get; set; }
    }

    public class Singleresultofuser
    {
        public Allof15[] allOf { get; set; }
    }

    public class Allof15
    {
        public string _ref { get; set; }
        public string type { get; set; }
        public bool additionalProperties { get; set; }
        public Properties58 properties { get; set; }
    }

    public class Properties58
    {
        public Queryable5 Queryable { get; set; }
    }

    public class Queryable5
    {
        public string type { get; set; }
        public bool nullable { get; set; }
        public Items121 items { get; set; }
    }

    public class Items121
    {
        public string _ref { get; set; }
    }

    public class Userpasswordreset
    {
        public string type { get; set; }
        public bool additionalProperties { get; set; }
        public Properties59 properties { get; set; }
    }

    public class Properties59
    {
        public Email2 Email { get; set; }
        public Password Password { get; set; }
    }

    public class Email2
    {
        public string type { get; set; }
        public bool nullable { get; set; }
    }

    public class Password
    {
        public string type { get; set; }
        public bool nullable { get; set; }
    }

    public class Setrolesparameters
    {
        public string type { get; set; }
        public bool additionalProperties { get; set; }
        public Properties60 properties { get; set; }
    }

    public class Properties60
    {
        public Roles2 Roles { get; set; }
    }

    public class Roles2
    {
        public string type { get; set; }
        public bool nullable { get; set; }
        public Items122 items { get; set; }
    }

    public class Items122
    {
        public string type { get; set; }
    }

    public class Singleresultofsurvey
    {
        public Allof16[] allOf { get; set; }
    }

    public class Allof16
    {
        public string _ref { get; set; }
        public string type { get; set; }
        public bool additionalProperties { get; set; }
        public Properties61 properties { get; set; }
    }

    public class Properties61
    {
        public Queryable6 Queryable { get; set; }
    }

    public class Queryable6
    {
        public string type { get; set; }
        public bool nullable { get; set; }
        public Items123 items { get; set; }
    }

    public class Items123
    {
        public string _ref { get; set; }
    }

    public class Singleresultofcatalog
    {
        public Allof17[] allOf { get; set; }
    }

    public class Allof17
    {
        public string _ref { get; set; }
        public string type { get; set; }
        public bool additionalProperties { get; set; }
        public Properties62 properties { get; set; }
    }

    public class Properties62
    {
        public Queryable7 Queryable { get; set; }
    }

    public class Queryable7
    {
        public string type { get; set; }
        public bool nullable { get; set; }
        public Items124 items { get; set; }
    }

    public class Items124
    {
        public string _ref { get; set; }
    }

    public class Singleresultoforgunit
    {
        public Allof18[] allOf { get; set; }
    }

    public class Allof18
    {
        public string _ref { get; set; }
        public string type { get; set; }
        public bool additionalProperties { get; set; }
        public Properties63 properties { get; set; }
    }

    public class Properties63
    {
        public Queryable8 Queryable { get; set; }
    }

    public class Queryable8
    {
        public string type { get; set; }
        public bool nullable { get; set; }
        public Items125 items { get; set; }
    }

    public class Items125
    {
        public string _ref { get; set; }
    }

    public class Singleresultofproduct
    {
        public Allof19[] allOf { get; set; }
    }

    public class Allof19
    {
        public string _ref { get; set; }
        public string type { get; set; }
        public bool additionalProperties { get; set; }
        public Properties64 properties { get; set; }
    }

    public class Properties64
    {
        public Queryable9 Queryable { get; set; }
    }

    public class Queryable9
    {
        public string type { get; set; }
        public bool nullable { get; set; }
        public Items126 items { get; set; }
    }

    public class Items126
    {
        public string _ref { get; set; }
    }

    public class Productrunspecification
    {
        public string type { get; set; }
        public bool additionalProperties { get; set; }
        public Properties65 properties { get; set; }
    }

    public class Properties65
    {
        public Costcomponentid1 CostComponentId { get; set; }
        public Location1 Location { get; set; }
        public Startdate3 StartDate { get; set; }
        public Enddate2 EndDate { get; set; }
    }

    public class Costcomponentid1
    {
        public string type { get; set; }
        public bool nullable { get; set; }
    }

    public class Location1
    {
        public string type { get; set; }
        public bool nullable { get; set; }
    }

    public class Startdate3
    {
        public string type { get; set; }
        public string format { get; set; }
        public bool nullable { get; set; }
    }

    public class Enddate2
    {
        public string type { get; set; }
        public string format { get; set; }
        public bool nullable { get; set; }
    }

    public class Bulkassignparameters
    {
        public string type { get; set; }
        public bool additionalProperties { get; set; }
        public string[] required { get; set; }
        public Properties66 properties { get; set; }
    }

    public class Properties66
    {
        public Tagids TagIds { get; set; }
        public Filter Filter { get; set; }
        public Assignmentmethod AssignmentMethod { get; set; }
    }

    public class Tagids
    {
        public string type { get; set; }
        public Items127 items { get; set; }
    }

    public class Items127
    {
        public string type { get; set; }
        public string format { get; set; }
    }

    public class Filter
    {
        public string type { get; set; }
        public bool nullable { get; set; }
    }

    public class Assignmentmethod
    {
        public int minLength { get; set; }
        public Oneof159[] oneOf { get; set; }
    }

    public class Oneof159
    {
        public string _ref { get; set; }
    }

    public class Assignmentmethod1
    {
        public string type { get; set; }
        public string description { get; set; }
        public string[] xenumNames { get; set; }
        public string[] _enum { get; set; }
    }

    public class Singleresultofprofile
    {
        public Allof20[] allOf { get; set; }
    }

    public class Allof20
    {
        public string _ref { get; set; }
        public string type { get; set; }
        public bool additionalProperties { get; set; }
        public Properties67 properties { get; set; }
    }

    public class Properties67
    {
        public Queryable10 Queryable { get; set; }
    }

    public class Queryable10
    {
        public string type { get; set; }
        public bool nullable { get; set; }
        public Items128 items { get; set; }
    }

    public class Items128
    {
        public string _ref { get; set; }
    }

    public class Deletetagparameters
    {
        public string type { get; set; }
        public bool additionalProperties { get; set; }
        public string[] required { get; set; }
        public Properties68 properties { get; set; }
    }

    public class Properties68
    {
        public Tagid2 TagId { get; set; }
    }

    public class Tagid2
    {
        public string type { get; set; }
        public string format { get; set; }
    }

    public class Excludetagparameters
    {
        public string type { get; set; }
        public bool additionalProperties { get; set; }
        public string[] required { get; set; }
        public Properties69 properties { get; set; }
    }

    public class Properties69
    {
        public Tagid3 TagId { get; set; }
    }

    public class Tagid3
    {
        public string type { get; set; }
        public string format { get; set; }
    }

    public class Includetagparameters
    {
        public string type { get; set; }
        public bool additionalProperties { get; set; }
        public string[] required { get; set; }
        public Properties70 properties { get; set; }
    }

    public class Properties70
    {
        public Tagid4 TagId { get; set; }
    }

    public class Tagid4
    {
        public string type { get; set; }
        public string format { get; set; }
    }

    public class Profilebubblefilterviewmodel
    {
        public string type { get; set; }
        public bool additionalProperties { get; set; }
        public Properties71 properties { get; set; }
    }

    public class Properties71
    {
        public Implicitlyincludedtags ImplicitlyIncludedTags { get; set; }
        public Explicitlyincludedtags ExplicitlyIncludedTags { get; set; }
        public Explicitlyexcludedtags ExplicitlyExcludedTags { get; set; }
    }

    public class Implicitlyincludedtags
    {
        public string type { get; set; }
        public bool nullable { get; set; }
        public Items129 items { get; set; }
    }

    public class Items129
    {
        public string type { get; set; }
    }

    public class Explicitlyincludedtags
    {
        public string type { get; set; }
        public bool nullable { get; set; }
        public Items130 items { get; set; }
    }

    public class Items130
    {
        public string type { get; set; }
    }

    public class Explicitlyexcludedtags
    {
        public string type { get; set; }
        public bool nullable { get; set; }
        public Items131 items { get; set; }
    }

    public class Items131
    {
        public string type { get; set; }
    }

    public class Singleresultofcosttype
    {
        public Allof21[] allOf { get; set; }
    }

    public class Allof21
    {
        public string _ref { get; set; }
        public string type { get; set; }
        public bool additionalProperties { get; set; }
        public Properties72 properties { get; set; }
    }

    public class Properties72
    {
        public Queryable11 Queryable { get; set; }
    }

    public class Queryable11
    {
        public string type { get; set; }
        public bool nullable { get; set; }
        public Items132 items { get; set; }
    }

    public class Items132
    {
        public string _ref { get; set; }
    }

    public class Singleresultofemployee
    {
        public Allof22[] allOf { get; set; }
    }

    public class Allof22
    {
        public string _ref { get; set; }
        public string type { get; set; }
        public bool additionalProperties { get; set; }
        public Properties73 properties { get; set; }
    }

    public class Properties73
    {
        public Queryable12 Queryable { get; set; }
    }

    public class Queryable12
    {
        public string type { get; set; }
        public bool nullable { get; set; }
        public Items133 items { get; set; }
    }

    public class Items133
    {
        public string _ref { get; set; }
    }

    public class Notification
    {
        public string type { get; set; }
        public bool additionalProperties { get; set; }
        public string[] required { get; set; }
        public Properties74 properties { get; set; }
    }

    public class Properties74
    {
        public Id36 Id { get; set; }
        public Employeeid6 EmployeeId { get; set; }
        public Employee8 Employee { get; set; }
        public To1 To { get; set; }
        public Subject Subject { get; set; }
        public Body Body { get; set; }
        public Queueddate QueuedDate { get; set; }
        public Sentdate SentDate { get; set; }
        public Queuestatus QueueStatus { get; set; }
        public Notificationtype NotificationType { get; set; }
        public Sendtriescounter SendTriesCounter { get; set; }
        public Isbodyhtml IsBodyHtml { get; set; }
    }

    public class Id36
    {
        public string type { get; set; }
        public string format { get; set; }
    }

    public class Employeeid6
    {
        public string type { get; set; }
        public string format { get; set; }
        public bool nullable { get; set; }
    }

    public class Employee8
    {
        public bool nullable { get; set; }
        public Oneof160[] oneOf { get; set; }
    }

    public class Oneof160
    {
        public string _ref { get; set; }
    }

    public class To1
    {
        public string type { get; set; }
        public int maxLength { get; set; }
        public int minLength { get; set; }
    }

    public class Subject
    {
        public string type { get; set; }
        public bool nullable { get; set; }
    }

    public class Body
    {
        public string type { get; set; }
        public int minLength { get; set; }
    }

    public class Queueddate
    {
        public string type { get; set; }
        public string format { get; set; }
    }

    public class Sentdate
    {
        public string type { get; set; }
        public string format { get; set; }
        public bool nullable { get; set; }
    }

    public class Queuestatus
    {
        public string _ref { get; set; }
    }

    public class Notificationtype
    {
        public string _ref { get; set; }
    }

    public class Sendtriescounter
    {
        public string type { get; set; }
    }

    public class Isbodyhtml
    {
        public string type { get; set; }
    }

    public class Queuestatus1
    {
        public string type { get; set; }
        public string description { get; set; }
        public string[] xenumNames { get; set; }
        public string[] _enum { get; set; }
    }

    public class Notificationtype1
    {
        public string type { get; set; }
        public string description { get; set; }
        public string[] xenumNames { get; set; }
        public string[] _enum { get; set; }
    }

    public class Singleresultofperiodemployee
    {
        public Allof23[] allOf { get; set; }
    }

    public class Allof23
    {
        public string _ref { get; set; }
        public string type { get; set; }
        public bool additionalProperties { get; set; }
        public Properties75 properties { get; set; }
    }

    public class Properties75
    {
        public Queryable13 Queryable { get; set; }
    }

    public class Queryable13
    {
        public string type { get; set; }
        public bool nullable { get; set; }
        public Items134 items { get; set; }
    }

    public class Items134
    {
        public string _ref { get; set; }
    }

    public class Bulkcreatenotificationsparameters
    {
        public string type { get; set; }
        public bool additionalProperties { get; set; }
        public Properties76 properties { get; set; }
    }

    public class Properties76
    {
        public Filter1 Filter { get; set; }
        public Body1 Body { get; set; }
        public Subject1 Subject { get; set; }
    }

    public class Filter1
    {
        public string type { get; set; }
        public bool nullable { get; set; }
    }

    public class Body1
    {
        public string type { get; set; }
        public bool nullable { get; set; }
    }

    public class Subject1
    {
        public string type { get; set; }
        public bool nullable { get; set; }
    }

    public class Marknotificationasreadparameters
    {
        public string type { get; set; }
        public bool additionalProperties { get; set; }
        public string[] required { get; set; }
        public Properties77 properties { get; set; }
    }

    public class Properties77
    {
        public Notificationid NotificationId { get; set; }
    }

    public class Notificationid
    {
        public string type { get; set; }
        public string format { get; set; }
    }

    public class Activation
    {
        public string type { get; set; }
        public bool additionalProperties { get; set; }
        public Properties78 properties { get; set; }
    }

    public class Properties78
    {
        public Id37 Id { get; set; }
        public Createddate11 CreatedDate { get; set; }
        public Createdby11 CreatedBy { get; set; }
        public Lastmodifieddate11 LastModifiedDate { get; set; }
        public Lastmodifiedby11 LastModifiedBy { get; set; }
        public Isactive3 IsActive { get; set; }
        public Activationflow ActivationFlow { get; set; }
        public Activationemailaddress ActivationEmailAddress { get; set; }
        public Activationusername ActivationUserName { get; set; }
        public Employeeid7 EmployeeId { get; set; }
        public Employee9 Employee { get; set; }
        public Orgunitid14 OrgUnitId { get; set; }
        public Orgunit12 OrgUnit { get; set; }
        public Roleid1 RoleId { get; set; }
        public Role1 Role { get; set; }
        public Tracktracecodeid4 TrackTraceCodeId { get; set; }
        public Tracktracecode4 TrackTraceCode { get; set; }
        public Userid3 UserId { get; set; }
        public User2 User { get; set; }
        public Disableemailconfirmation DisableEmailConfirmation { get; set; }
        public Activationtoken ActivationToken { get; set; }
    }

    public class Id37
    {
        public string type { get; set; }
        public string format { get; set; }
    }

    public class Createddate11
    {
        public string type { get; set; }
        public string format { get; set; }
    }

    public class Createdby11
    {
        public string type { get; set; }
        public bool nullable { get; set; }
    }

    public class Lastmodifieddate11
    {
        public string type { get; set; }
        public string format { get; set; }
    }

    public class Lastmodifiedby11
    {
        public string type { get; set; }
        public bool nullable { get; set; }
    }

    public class Isactive3
    {
        public string type { get; set; }
    }

    public class Activationflow
    {
        public string _ref { get; set; }
    }

    public class Activationemailaddress
    {
        public string type { get; set; }
        public bool nullable { get; set; }
    }

    public class Activationusername
    {
        public string type { get; set; }
        public bool nullable { get; set; }
    }

    public class Employeeid7
    {
        public string type { get; set; }
        public string format { get; set; }
        public bool nullable { get; set; }
    }

    public class Employee9
    {
        public bool nullable { get; set; }
        public Oneof161[] oneOf { get; set; }
    }

    public class Oneof161
    {
        public string _ref { get; set; }
    }

    public class Orgunitid14
    {
        public string type { get; set; }
        public string format { get; set; }
    }

    public class Orgunit12
    {
        public bool nullable { get; set; }
        public Oneof162[] oneOf { get; set; }
    }

    public class Oneof162
    {
        public string _ref { get; set; }
    }

    public class Roleid1
    {
        public string type { get; set; }
        public string format { get; set; }
    }

    public class Role1
    {
        public bool nullable { get; set; }
        public Oneof163[] oneOf { get; set; }
    }

    public class Oneof163
    {
        public string _ref { get; set; }
    }

    public class Tracktracecodeid4
    {
        public string type { get; set; }
        public string format { get; set; }
    }

    public class Tracktracecode4
    {
        public bool nullable { get; set; }
        public Oneof164[] oneOf { get; set; }
    }

    public class Oneof164
    {
        public string _ref { get; set; }
    }

    public class Userid3
    {
        public string type { get; set; }
        public string format { get; set; }
        public bool nullable { get; set; }
    }

    public class User2
    {
        public bool nullable { get; set; }
        public Oneof165[] oneOf { get; set; }
    }

    public class Oneof165
    {
        public string _ref { get; set; }
    }

    public class Disableemailconfirmation
    {
        public string type { get; set; }
    }

    public class Activationtoken
    {
        public string type { get; set; }
        public bool nullable { get; set; }
    }

    public class Activationflow1
    {
        public string type { get; set; }
        public string description { get; set; }
        public string[] xenumNames { get; set; }
        public string[] _enum { get; set; }
    }

    public class Singleresultofactivation
    {
        public Allof24[] allOf { get; set; }
    }

    public class Allof24
    {
        public string _ref { get; set; }
        public string type { get; set; }
        public bool additionalProperties { get; set; }
        public Properties79 properties { get; set; }
    }

    public class Properties79
    {
        public Queryable14 Queryable { get; set; }
    }

    public class Queryable14
    {
        public string type { get; set; }
        public bool nullable { get; set; }
        public Items135 items { get; set; }
    }

    public class Items135
    {
        public string _ref { get; set; }
    }

    public class Addmanagerparameters
    {
        public string type { get; set; }
        public bool additionalProperties { get; set; }
        public string[] required { get; set; }
        public Properties80 properties { get; set; }
    }

    public class Properties80
    {
        public Orgunitid15 OrgUnitId { get; set; }
        public Activationemailaddress1 ActivationEmailAddress { get; set; }
    }

    public class Orgunitid15
    {
        public string type { get; set; }
        public string format { get; set; }
    }

    public class Activationemailaddress1
    {
        public string type { get; set; }
        public bool nullable { get; set; }
    }

    public class Singleresultofplancomment
    {
        public Allof25[] allOf { get; set; }
    }

    public class Allof25
    {
        public string _ref { get; set; }
        public string type { get; set; }
        public bool additionalProperties { get; set; }
        public Properties81 properties { get; set; }
    }

    public class Properties81
    {
        public Queryable15 Queryable { get; set; }
    }

    public class Queryable15
    {
        public string type { get; set; }
        public bool nullable { get; set; }
        public Items136 items { get; set; }
    }

    public class Items136
    {
        public string _ref { get; set; }
    }

    public class Singleresultoftransaction
    {
        public Allof26[] allOf { get; set; }
    }

    public class Allof26
    {
        public string _ref { get; set; }
        public string type { get; set; }
        public bool additionalProperties { get; set; }
        public Properties82 properties { get; set; }
    }

    public class Properties82
    {
        public Queryable16 Queryable { get; set; }
    }

    public class Queryable16
    {
        public string type { get; set; }
        public bool nullable { get; set; }
        public Items137 items { get; set; }
    }

    public class Items137
    {
        public string _ref { get; set; }
    }

    public class Odataactionparameters
    {
        public string type { get; set; }
        public string description { get; set; }
        public Additionalproperties additionalProperties { get; set; }
    }

    public class Additionalproperties
    {
    }

    public class Bulkrefundparameters
    {
        public string type { get; set; }
        public bool additionalProperties { get; set; }
        public Properties83 properties { get; set; }
    }

    public class Properties83
    {
        public Filter2 Filter { get; set; }
        public Notes Notes { get; set; }
    }

    public class Filter2
    {
        public string type { get; set; }
        public bool nullable { get; set; }
    }

    public class Notes
    {
        public string type { get; set; }
        public bool nullable { get; set; }
    }

    public class Bulkrejectparameters
    {
        public string type { get; set; }
        public bool additionalProperties { get; set; }
        public Properties84 properties { get; set; }
    }

    public class Properties84
    {
        public Filter3 Filter { get; set; }
        public Notes1 Notes { get; set; }
    }

    public class Filter3
    {
        public string type { get; set; }
        public bool nullable { get; set; }
    }

    public class Notes1
    {
        public string type { get; set; }
        public bool nullable { get; set; }
    }

    public class Bulkapproveparameters
    {
        public string type { get; set; }
        public bool additionalProperties { get; set; }
        public Properties85 properties { get; set; }
    }

    public class Properties85
    {
        public Filter4 Filter { get; set; }
        public Notes2 Notes { get; set; }
    }

    public class Filter4
    {
        public string type { get; set; }
        public bool nullable { get; set; }
    }

    public class Notes2
    {
        public string type { get; set; }
        public bool nullable { get; set; }
    }

    public class Refundparameters
    {
        public string type { get; set; }
        public bool additionalProperties { get; set; }
        public Properties86 properties { get; set; }
    }

    public class Properties86
    {
        public Notes3 Notes { get; set; }
    }

    public class Notes3
    {
        public string type { get; set; }
        public bool nullable { get; set; }
    }

    public class Rejectparameters
    {
        public string type { get; set; }
        public bool additionalProperties { get; set; }
        public Properties87 properties { get; set; }
    }

    public class Properties87
    {
        public Reason1 Reason { get; set; }
    }

    public class Reason1
    {
        public string type { get; set; }
        public bool nullable { get; set; }
    }

    public class Approveparameters
    {
        public string type { get; set; }
        public bool additionalProperties { get; set; }
        public Properties88 properties { get; set; }
    }

    public class Properties88
    {
        public Reason2 Reason { get; set; }
    }

    public class Reason2
    {
        public string type { get; set; }
        public bool nullable { get; set; }
    }

    public class Confirmparameters
    {
        public string type { get; set; }
        public bool additionalProperties { get; set; }
        public Properties89 properties { get; set; }
    }

    public class Properties89
    {
        public Costcomponentid2 CostComponentId { get; set; }
        public Employeenotes1 EmployeeNotes { get; set; }
    }

    public class Costcomponentid2
    {
        public string type { get; set; }
        public bool nullable { get; set; }
    }

    public class Employeenotes1
    {
        public string type { get; set; }
        public bool nullable { get; set; }
    }

    public class Rateproductparameters
    {
        public string type { get; set; }
        public bool additionalProperties { get; set; }
        public string[] required { get; set; }
        public Properties90 properties { get; set; }
    }

    public class Properties90
    {
        public Rating1 Rating { get; set; }
    }

    public class Rating1
    {
        public string type { get; set; }
        public string format { get; set; }
    }

    public class Singleresultofdiscountrule
    {
        public Allof27[] allOf { get; set; }
    }

    public class Allof27
    {
        public string _ref { get; set; }
        public string type { get; set; }
        public bool additionalProperties { get; set; }
        public Properties91 properties { get; set; }
    }

    public class Properties91
    {
        public Queryable17 Queryable { get; set; }
    }

    public class Queryable17
    {
        public string type { get; set; }
        public bool nullable { get; set; }
        public Items138 items { get; set; }
    }

    public class Items138
    {
        public string _ref { get; set; }
    }

    public class Bulkcopyparameters
    {
        public string type { get; set; }
        public bool additionalProperties { get; set; }
        public Properties92 properties { get; set; }
    }

    public class Properties92
    {
        public Orgunitid16 OrgUnitId { get; set; }
        public Effectivefromdate1 EffectiveFromDate { get; set; }
        public Filter5 Filter { get; set; }
        public Tag4 Tag { get; set; }
    }

    public class Orgunitid16
    {
        public string type { get; set; }
        public string format { get; set; }
    }

    public class Effectivefromdate1
    {
        public string type { get; set; }
        public string format { get; set; }
    }

    public class Filter5
    {
        public string type { get; set; }
        public bool nullable { get; set; }
    }

    public class Tag4
    {
        public string type { get; set; }
        public bool nullable { get; set; }
    }

    public class Bulkdeleteparameters
    {
        public string type { get; set; }
        public bool additionalProperties { get; set; }
        public Properties93 properties { get; set; }
    }

    public class Properties93
    {
        public Filter6 Filter { get; set; }
    }

    public class Filter6
    {
        public string type { get; set; }
        public bool nullable { get; set; }
    }

    public class Singleresultofnotification
    {
        public Allof28[] allOf { get; set; }
    }

    public class Allof28
    {
        public string _ref { get; set; }
        public string type { get; set; }
        public bool additionalProperties { get; set; }
        public Properties94 properties { get; set; }
    }

    public class Properties94
    {
        public Queryable18 Queryable { get; set; }
    }

    public class Queryable18
    {
        public string type { get; set; }
        public bool nullable { get; set; }
        public Items139 items { get; set; }
    }

    public class Items139
    {
        public string _ref { get; set; }
    }

    public class Orgunitreportmodel
    {
        public string type { get; set; }
        public bool additionalProperties { get; set; }
        public Properties95 properties { get; set; }
    }

    public class Properties95
    {
        public Orgunitname OrgUnitName { get; set; }
        public Employeecount EmployeeCount { get; set; }
        public Activatedcount ActivatedCount { get; set; }
    }

    public class Orgunitname
    {
        public string type { get; set; }
        public bool nullable { get; set; }
    }

    public class Employeecount
    {
        public string type { get; set; }
        public string format { get; set; }
    }

    public class Activatedcount
    {
        public string type { get; set; }
        public string format { get; set; }
    }

    public class Instanceinformation
    {
        public string type { get; set; }
        public bool additionalProperties { get; set; }
        public Properties96 properties { get; set; }
    }

    public class Properties96
    {
        public Instancetype InstanceType { get; set; }
        public Version1 Version { get; set; }
        public Notificationoptions NotificationOptions { get; set; }
        public Modeloptions ModelOptions { get; set; }
        public Fullconfiguration FullConfiguration { get; set; }
    }

    public class Instancetype
    {
        public string _ref { get; set; }
    }

    public class Version1
    {
        public string type { get; set; }
        public bool nullable { get; set; }
    }

    public class Notificationoptions
    {
        public bool nullable { get; set; }
        public Oneof166[] oneOf { get; set; }
    }

    public class Oneof166
    {
        public string _ref { get; set; }
    }

    public class Modeloptions
    {
        public bool nullable { get; set; }
        public Oneof167[] oneOf { get; set; }
    }

    public class Oneof167
    {
        public string _ref { get; set; }
    }

    public class Fullconfiguration
    {
        public bool nullable { get; set; }
        public Oneof168[] oneOf { get; set; }
    }

    public class Oneof168
    {
        public string _ref { get; set; }
    }

    public class Instancetype1
    {
        public string type { get; set; }
        public string description { get; set; }
        public string[] xenumNames { get; set; }
        public string[] _enum { get; set; }
    }

    public class Instanceinformationnotificationoptions
    {
        public string type { get; set; }
        public bool additionalProperties { get; set; }
        public Properties97 properties { get; set; }
    }

    public class Properties97
    {
        public Smtpserver SmtpServer { get; set; }
        public Ismailwhitelistactive IsMailWhitelistActive { get; set; }
        public Mailwhitelist MailWhitelist { get; set; }
    }

    public class Smtpserver
    {
        public string type { get; set; }
        public bool nullable { get; set; }
    }

    public class Ismailwhitelistactive
    {
        public string type { get; set; }
    }

    public class Mailwhitelist
    {
        public string type { get; set; }
        public bool nullable { get; set; }
        public Items140 items { get; set; }
    }

    public class Items140
    {
        public string type { get; set; }
    }

    public class Instanceinformationmodeloptions
    {
        public string type { get; set; }
        public bool additionalProperties { get; set; }
        public Properties98 properties { get; set; }
    }

    public class Properties98
    {
        public Defaultcsvspecification DefaultCsvSpecification { get; set; }
        public Usecurrentperiodforemptyperiod UseCurrentPeriodForEmptyPeriod { get; set; }
        public Issubdomainrequired IsSubdomainRequired { get; set; }
    }

    public class Defaultcsvspecification
    {
        public string _ref { get; set; }
    }

    public class Usecurrentperiodforemptyperiod
    {
        public string type { get; set; }
    }

    public class Issubdomainrequired
    {
        public string type { get; set; }
    }

    public class Csvspecification
    {
        public string type { get; set; }
        public string description { get; set; }
        public string[] xenumNames { get; set; }
        public string[] _enum { get; set; }
    }

    public class Appoptions
    {
        public string type { get; set; }
        public bool additionalProperties { get; set; }
        public Properties99 properties { get; set; }
    }

    public class Properties99
    {
        public Instancetype2 InstanceType { get; set; }
        public Instancetitle InstanceTitle { get; set; }
        public Deployenvironment DeployEnvironment { get; set; }
        public Modules Modules { get; set; }
        public Connectivitycenterapi ConnectivityCenterApi { get; set; }
        public Tasperapi TasperApi { get; set; }
        public Publicapi PublicApi { get; set; }
        public Swagger Swagger { get; set; }
        public Jobservice JobService { get; set; }
        public Notifications Notifications { get; set; }
        public Identityserver IdentityServer { get; set; }
        public Identityclient IdentityClient { get; set; }
        public Portaladmin PortalAdmin { get; set; }
        public Drupaldynamicsso DrupalDynamicSso { get; set; }
        public Drupalsso DrupalSso { get; set; }
        public Superadmincc SuperAdminCc { get; set; }
        public Orgunitmanager OrgUnitManager { get; set; }
        public Taspersso TasperSso { get; set; }
        public Taspercc TasperCc { get; set; }
        public Licenses Licenses { get; set; }
        public Model Model { get; set; }
        public Logging Logging { get; set; }
        public Connectionstrings ConnectionStrings { get; set; }
        public Profile4 Profile { get; set; }
        public Shop Shop { get; set; }
    }

    public class Instancetype2
    {
        public string _ref { get; set; }
    }

    public class Instancetitle
    {
        public string type { get; set; }
        public bool nullable { get; set; }
    }

    public class Deployenvironment
    {
        public string _ref { get; set; }
    }

    public class Modules
    {
        public string type { get; set; }
        public bool nullable { get; set; }
        public Items141 items { get; set; }
    }

    public class Items141
    {
        public string type { get; set; }
    }

    public class Connectivitycenterapi
    {
        public bool nullable { get; set; }
        public Oneof169[] oneOf { get; set; }
    }

    public class Oneof169
    {
        public string _ref { get; set; }
    }

    public class Tasperapi
    {
        public bool nullable { get; set; }
        public Oneof170[] oneOf { get; set; }
    }

    public class Oneof170
    {
        public string _ref { get; set; }
    }

    public class Publicapi
    {
        public bool nullable { get; set; }
        public Oneof171[] oneOf { get; set; }
    }

    public class Oneof171
    {
        public string _ref { get; set; }
    }

    public class Swagger
    {
        public bool nullable { get; set; }
        public Oneof172[] oneOf { get; set; }
    }

    public class Oneof172
    {
        public string _ref { get; set; }
    }

    public class Jobservice
    {
        public bool nullable { get; set; }
        public Oneof173[] oneOf { get; set; }
    }

    public class Oneof173
    {
        public string _ref { get; set; }
    }

    public class Notifications
    {
        public bool nullable { get; set; }
        public Oneof174[] oneOf { get; set; }
    }

    public class Oneof174
    {
        public string _ref { get; set; }
    }

    public class Identityserver
    {
        public bool nullable { get; set; }
        public Oneof175[] oneOf { get; set; }
    }

    public class Oneof175
    {
        public string _ref { get; set; }
    }

    public class Identityclient
    {
        public bool nullable { get; set; }
        public Oneof176[] oneOf { get; set; }
    }

    public class Oneof176
    {
        public string _ref { get; set; }
    }

    public class Portaladmin
    {
        public bool nullable { get; set; }
        public Oneof177[] oneOf { get; set; }
    }

    public class Oneof177
    {
        public string _ref { get; set; }
    }

    public class Drupaldynamicsso
    {
        public bool nullable { get; set; }
        public Oneof178[] oneOf { get; set; }
    }

    public class Oneof178
    {
        public string _ref { get; set; }
    }

    public class Drupalsso
    {
        public bool nullable { get; set; }
        public Oneof179[] oneOf { get; set; }
    }

    public class Oneof179
    {
        public string _ref { get; set; }
    }

    public class Superadmincc
    {
        public bool nullable { get; set; }
        public Oneof180[] oneOf { get; set; }
    }

    public class Oneof180
    {
        public string _ref { get; set; }
    }

    public class Orgunitmanager
    {
        public bool nullable { get; set; }
        public Oneof181[] oneOf { get; set; }
    }

    public class Oneof181
    {
        public string _ref { get; set; }
    }

    public class Taspersso
    {
        public bool nullable { get; set; }
        public Oneof182[] oneOf { get; set; }
    }

    public class Oneof182
    {
        public string _ref { get; set; }
    }

    public class Taspercc
    {
        public bool nullable { get; set; }
        public Oneof183[] oneOf { get; set; }
    }

    public class Oneof183
    {
        public string _ref { get; set; }
    }

    public class Licenses
    {
        public bool nullable { get; set; }
        public Oneof184[] oneOf { get; set; }
    }

    public class Oneof184
    {
        public string _ref { get; set; }
    }

    public class Model
    {
        public bool nullable { get; set; }
        public Oneof185[] oneOf { get; set; }
    }

    public class Oneof185
    {
        public string _ref { get; set; }
    }

    public class Logging
    {
        public bool nullable { get; set; }
        public Oneof186[] oneOf { get; set; }
    }

    public class Oneof186
    {
        public string _ref { get; set; }
    }

    public class Connectionstrings
    {
        public string type { get; set; }
        public bool nullable { get; set; }
        public Additionalproperties1 additionalProperties { get; set; }
    }

    public class Additionalproperties1
    {
        public string type { get; set; }
    }

    public class Profile4
    {
        public bool nullable { get; set; }
        public Oneof187[] oneOf { get; set; }
    }

    public class Oneof187
    {
        public string _ref { get; set; }
    }

    public class Shop
    {
        public bool nullable { get; set; }
        public Oneof188[] oneOf { get; set; }
    }

    public class Oneof188
    {
        public string _ref { get; set; }
    }

    public class Deployenvironment1
    {
        public string type { get; set; }
        public string description { get; set; }
        public string[] xenumNames { get; set; }
        public string[] _enum { get; set; }
    }

    public class Connectivityapioptions
    {
        public string type { get; set; }
        public bool additionalProperties { get; set; }
        public Properties100 properties { get; set; }
    }

    public class Properties100
    {
        public Rooturl RootUrl { get; set; }
        public Isswaggerenabled IsSwaggerEnabled { get; set; }
        public Apititle ApiTitle { get; set; }
    }

    public class Rooturl
    {
        public string type { get; set; }
        public bool nullable { get; set; }
    }

    public class Isswaggerenabled
    {
        public string type { get; set; }
    }

    public class Apititle
    {
        public string type { get; set; }
        public bool nullable { get; set; }
    }

    public class Swaggeroptions
    {
        public string type { get; set; }
        public bool additionalProperties { get; set; }
        public Properties101 properties { get; set; }
    }

    public class Properties101
    {
        public Flow Flow { get; set; }
        public Clientid ClientId { get; set; }
        public Clientsecret ClientSecret { get; set; }
        public Clientlogourl ClientLogoUrl { get; set; }
    }

    public class Flow
    {
        public string type { get; set; }
        public bool nullable { get; set; }
    }

    public class Clientid
    {
        public string type { get; set; }
        public bool nullable { get; set; }
    }

    public class Clientsecret
    {
        public string type { get; set; }
        public bool nullable { get; set; }
    }

    public class Clientlogourl
    {
        public string type { get; set; }
        public bool nullable { get; set; }
    }

    public class Jobserviceoptions
    {
        public string type { get; set; }
        public bool additionalProperties { get; set; }
        public Properties102 properties { get; set; }
    }

    public class Properties102
    {
        public Numberofhangfireworkers NumberOfHangfireWorkers { get; set; }
        public Instancename InstanceName { get; set; }
        public Defaultcronexpressions DefaultCronExpressions { get; set; }
    }

    public class Numberofhangfireworkers
    {
        public string type { get; set; }
        public string format { get; set; }
        public bool nullable { get; set; }
    }

    public class Instancename
    {
        public string type { get; set; }
        public bool nullable { get; set; }
    }

    public class Defaultcronexpressions
    {
        public bool nullable { get; set; }
        public Oneof189[] oneOf { get; set; }
    }

    public class Oneof189
    {
        public string _ref { get; set; }
    }

    public class Defaultcronexpressions1
    {
        public string type { get; set; }
        public bool additionalProperties { get; set; }
        public Properties103 properties { get; set; }
    }

    public class Properties103
    {
        public Employeegetconnectorjob EmployeeGetConnectorJob { get; set; }
    }

    public class Employeegetconnectorjob
    {
        public string type { get; set; }
        public bool nullable { get; set; }
    }

    public class Notificationoptions1
    {
        public string type { get; set; }
        public bool additionalProperties { get; set; }
        public Properties104 properties { get; set; }
    }

    public class Properties104
    {
        public Numberofnotificationsperjobrun NumberOfNotificationsPerJobRun { get; set; }
        public Maxsendtries MaxSendTries { get; set; }
        public Smtpserver1 SmtpServer { get; set; }
        public Smtpport SmtpPort { get; set; }
        public Smtpusessl SmtpUseSsl { get; set; }
        public Mailfrom MailFrom { get; set; }
        public Mailwhitelist1 MailWhitelist { get; set; }
    }

    public class Numberofnotificationsperjobrun
    {
        public string type { get; set; }
        public string format { get; set; }
    }

    public class Maxsendtries
    {
        public string type { get; set; }
    }

    public class Smtpserver1
    {
        public string type { get; set; }
        public bool nullable { get; set; }
    }

    public class Smtpport
    {
        public string type { get; set; }
        public string format { get; set; }
    }

    public class Smtpusessl
    {
        public string type { get; set; }
    }

    public class Mailfrom
    {
        public string type { get; set; }
        public bool nullable { get; set; }
    }

    public class Mailwhitelist1
    {
        public string type { get; set; }
        public bool nullable { get; set; }
        public Items142 items { get; set; }
    }

    public class Items142
    {
        public string type { get; set; }
    }

    public class Identityserveroptions
    {
        public string type { get; set; }
        public bool additionalProperties { get; set; }
        public Properties105 properties { get; set; }
    }

    public class Properties105
    {
        public Sitetitle SiteTitle { get; set; }
        public Cookieexpiretimeinminutes CookieExpireTimeInMinutes { get; set; }
        public Accesstokenlifetimeinminutes AccessTokenLifetimeInMinutes { get; set; }
        public Rooturl1 RootUrl { get; set; }
        public Wallpaperpath WallpaperPath { get; set; }
        public Windowsauthenticationidentityprovider WindowsAuthenticationIdentityProvider { get; set; }
        public Windowsauthenticationadmingroup WindowsAuthenticationAdminGroup { get; set; }
        public Useidentityserverinitiatedtokenrevocation UseIdentityServerInitiatedTokenRevocation { get; set; }
        public Enablecspreportendpoint EnableCspReportEndpoint { get; set; }
        public Certificate Certificate { get; set; }
    }

    public class Sitetitle
    {
        public string type { get; set; }
        public bool nullable { get; set; }
    }

    public class Cookieexpiretimeinminutes
    {
        public string type { get; set; }
        public string format { get; set; }
    }

    public class Accesstokenlifetimeinminutes
    {
        public string type { get; set; }
        public string format { get; set; }
    }

    public class Rooturl1
    {
        public string type { get; set; }
        public bool nullable { get; set; }
    }

    public class Wallpaperpath
    {
        public string type { get; set; }
        public bool nullable { get; set; }
    }

    public class Windowsauthenticationidentityprovider
    {
        public string type { get; set; }
        public bool nullable { get; set; }
    }

    public class Windowsauthenticationadmingroup
    {
        public string type { get; set; }
        public bool nullable { get; set; }
    }

    public class Useidentityserverinitiatedtokenrevocation
    {
        public string type { get; set; }
    }

    public class Enablecspreportendpoint
    {
        public string type { get; set; }
    }

    public class Certificate
    {
        public bool nullable { get; set; }
        public Oneof190[] oneOf { get; set; }
    }

    public class Oneof190
    {
        public string _ref { get; set; }
    }

    public class Certificateloaderconfiguration
    {
        public string type { get; set; }
        public bool additionalProperties { get; set; }
        public Properties106 properties { get; set; }
    }

    public class Properties106
    {
        public Type2 Type { get; set; }
        public File3 File { get; set; }
        public Store Store { get; set; }
    }

    public class Type2
    {
        public string _ref { get; set; }
    }

    public class File3
    {
        public bool nullable { get; set; }
        public Oneof191[] oneOf { get; set; }
    }

    public class Oneof191
    {
        public string _ref { get; set; }
    }

    public class Store
    {
        public bool nullable { get; set; }
        public Oneof192[] oneOf { get; set; }
    }

    public class Oneof192
    {
        public string _ref { get; set; }
    }

    public class Certificateloadertype
    {
        public string type { get; set; }
        public string description { get; set; }
        public string[] xenumNames { get; set; }
        public string[] _enum { get; set; }
    }

    public class Fileconfiguration
    {
        public string type { get; set; }
        public bool additionalProperties { get; set; }
        public Properties107 properties { get; set; }
    }

    public class Properties107
    {
        public Location2 Location { get; set; }
        public Isrelativelocation IsRelativeLocation { get; set; }
        public Password1 Password { get; set; }
    }

    public class Location2
    {
        public string type { get; set; }
        public bool nullable { get; set; }
    }

    public class Isrelativelocation
    {
        public string type { get; set; }
    }

    public class Password1
    {
        public string type { get; set; }
        public bool nullable { get; set; }
    }

    public class Storeconfiguration
    {
        public string type { get; set; }
        public bool additionalProperties { get; set; }
        public Properties108 properties { get; set; }
    }

    public class Properties108
    {
        public Location3 Location { get; set; }
        public Name13 Name { get; set; }
        public Serialnumber SerialNumber { get; set; }
    }

    public class Location3
    {
        public string _ref { get; set; }
    }

    public class Name13
    {
        public string _ref { get; set; }
    }

    public class Serialnumber
    {
        public string type { get; set; }
        public bool nullable { get; set; }
    }

    public class Storelocation
    {
        public string type { get; set; }
        public string description { get; set; }
        public string[] xenumNames { get; set; }
        public string[] _enum { get; set; }
    }

    public class Storename
    {
        public string type { get; set; }
        public string description { get; set; }
        public string[] xenumNames { get; set; }
        public string[] _enum { get; set; }
    }

    public class Identityclientoptions
    {
        public Allof29[] allOf { get; set; }
    }

    public class Allof29
    {
        public string _ref { get; set; }
        public string type { get; set; }
        public bool additionalProperties { get; set; }
        public Properties109 properties { get; set; }
    }

    public class Properties109
    {
        public Enabletestmode EnableTestMode { get; set; }
        public Defaultdisableemailconfirmation DefaultDisableEmailConfirmation { get; set; }
        public Usertokenlifetimeinminutes UserTokenLifetimeInMinutes { get; set; }
    }

    public class Enabletestmode
    {
        public string type { get; set; }
    }

    public class Defaultdisableemailconfirmation
    {
        public string type { get; set; }
    }

    public class Usertokenlifetimeinminutes
    {
        public string type { get; set; }
        public string format { get; set; }
    }

    public class Oauthclientoptions
    {
        public string type { get; set; }
        public bool additionalProperties { get; set; }
        public Properties110 properties { get; set; }
    }

    public class Properties110
    {
        public Isactive4 IsActive { get; set; }
        public Rooturl2 RootUrl { get; set; }
        public Redirectpaths RedirectPaths { get; set; }
        public Postlogoutredirectpaths PostLogoutRedirectPaths { get; set; }
        public Logoutpath LogoutPath { get; set; }
        public Clientidprefix ClientIdPrefix { get; set; }
        public Clientid1 ClientId { get; set; }
        public Clientsecret1 ClientSecret { get; set; }
        public Clientname ClientName { get; set; }
        public Clientlogopath ClientLogoPath { get; set; }
        public Displayallauthenticators DisplayAllAuthenticators { get; set; }
        public Enablelocallogin EnableLocalLogin { get; set; }
        public Flow1 Flow { get; set; }
    }

    public class Isactive4
    {
        public string type { get; set; }
    }

    public class Rooturl2
    {
        public string type { get; set; }
        public bool nullable { get; set; }
    }

    public class Redirectpaths
    {
        public string type { get; set; }
        public bool nullable { get; set; }
        public Items143 items { get; set; }
    }

    public class Items143
    {
        public string type { get; set; }
    }

    public class Postlogoutredirectpaths
    {
        public string type { get; set; }
        public bool nullable { get; set; }
        public Items144 items { get; set; }
    }

    public class Items144
    {
        public string type { get; set; }
    }

    public class Logoutpath
    {
        public string type { get; set; }
        public bool nullable { get; set; }
    }

    public class Clientidprefix
    {
        public string type { get; set; }
        public bool nullable { get; set; }
    }

    public class Clientid1
    {
        public string type { get; set; }
        public bool nullable { get; set; }
    }

    public class Clientsecret1
    {
        public string type { get; set; }
        public bool nullable { get; set; }
    }

    public class Clientname
    {
        public string type { get; set; }
        public bool nullable { get; set; }
    }

    public class Clientlogopath
    {
        public string type { get; set; }
        public bool nullable { get; set; }
    }

    public class Displayallauthenticators
    {
        public string type { get; set; }
    }

    public class Enablelocallogin
    {
        public string type { get; set; }
        public bool nullable { get; set; }
    }

    public class Flow1
    {
        public string type { get; set; }
        public bool nullable { get; set; }
    }

    public class Tasperoptions
    {
        public Allof30[] allOf { get; set; }
    }

    public class Allof30
    {
        public string _ref { get; set; }
        public string type { get; set; }
        public bool additionalProperties { get; set; }
        public Properties111 properties { get; set; }
    }

    public class Properties111
    {
        public Adminpath AdminPath { get; set; }
    }

    public class Adminpath
    {
        public string type { get; set; }
        public bool nullable { get; set; }
    }

    public class Licenseoptions
    {
        public string type { get; set; }
        public bool additionalProperties { get; set; }
        public Properties112 properties { get; set; }
    }

    public class Properties112
    {
        public Zentityframeworkextensions ZEntityFrameworkExtensions { get; set; }
    }

    public class Zentityframeworkextensions
    {
        public bool nullable { get; set; }
        public Oneof193[] oneOf { get; set; }
    }

    public class Oneof193
    {
        public string _ref { get; set; }
    }

    public class Zentityframeworkextensionsoptions
    {
        public string type { get; set; }
        public bool additionalProperties { get; set; }
        public Properties113 properties { get; set; }
    }

    public class Properties113
    {
        public Name14 Name { get; set; }
        public Key2 Key { get; set; }
    }

    public class Name14
    {
        public string type { get; set; }
        public bool nullable { get; set; }
    }

    public class Key2
    {
        public string type { get; set; }
        public bool nullable { get; set; }
    }

    public class Modeloptions1
    {
        public string type { get; set; }
        public bool additionalProperties { get; set; }
        public Properties114 properties { get; set; }
    }

    public class Properties114
    {
        public User3 User { get; set; }
        public Orgunit13 OrgUnit { get; set; }
        public Employee10 Employee { get; set; }
        public Defaultcsvspecification1 DefaultCsvSpecification { get; set; }
        public Allowedcsvspecifications AllowedCsvSpecifications { get; set; }
    }

    public class User3
    {
        public bool nullable { get; set; }
        public Oneof194[] oneOf { get; set; }
    }

    public class Oneof194
    {
        public string _ref { get; set; }
    }

    public class Orgunit13
    {
        public bool nullable { get; set; }
        public Oneof195[] oneOf { get; set; }
    }

    public class Oneof195
    {
        public string _ref { get; set; }
    }

    public class Employee10
    {
        public bool nullable { get; set; }
        public Oneof196[] oneOf { get; set; }
    }

    public class Oneof196
    {
        public string _ref { get; set; }
    }

    public class Defaultcsvspecification1
    {
        public string _ref { get; set; }
    }

    public class Allowedcsvspecifications
    {
        public string type { get; set; }
        public bool nullable { get; set; }
        public Items145 items { get; set; }
    }

    public class Items145
    {
        public string _ref { get; set; }
    }

    public class Usermodeloptions
    {
        public string type { get; set; }
        public bool additionalProperties { get; set; }
        public Properties115 properties { get; set; }
    }

    public class Properties115
    {
        public Issubscribedtonewsletterbydefault IsSubscribedToNewsletterByDefault { get; set; }
    }

    public class Issubscribedtonewsletterbydefault
    {
        public string type { get; set; }
    }

    public class Orgunitmodeloptions
    {
        public string type { get; set; }
        public bool additionalProperties { get; set; }
        public Properties116 properties { get; set; }
    }

    public class Properties116
    {
        public Issubdomainrequired1 IsSubdomainRequired { get; set; }
        public Defaultnumberofdaysoutofservicebeforedisabling DefaultNumberOfDaysOutOfServiceBeforeDisabling { get; set; }
        public Defaultcao DefaultCao { get; set; }
        public Defaultimporttype DefaultImportType { get; set; }
        public Defaultikbsubscriptiontype DefaultIkbSubscriptionType { get; set; }
        public Defaultstatus DefaultStatus { get; set; }
        public Defaultoperationmode DefaultOperationMode { get; set; }
        public Defaultemployerperiodtype DefaultEmployerPeriodType { get; set; }
        public Defaultuseractivationflow DefaultUserActivationFlow { get; set; }
        public Defaulttermsofservicerequirements DefaultTermsOfServiceRequirements { get; set; }
        public Defaultshoppricedisplaypolicy DefaultShopPriceDisplayPolicy { get; set; }
        public Defaultshoptaxationpolicy DefaultShopTaxationPolicy { get; set; }
        public Allowedikbsubscriptiontypes AllowedIkbSubscriptionTypes { get; set; }
        public Allowedemployerperiodtypes AllowedEmployerPeriodTypes { get; set; }
        public Invisiblegridcolumns InvisibleGridColumns { get; set; }
        public Invisibleeditorfields InvisibleEditorFields { get; set; }
    }

    public class Issubdomainrequired1
    {
        public string type { get; set; }
    }

    public class Defaultnumberofdaysoutofservicebeforedisabling
    {
        public string type { get; set; }
        public string format { get; set; }
        public bool nullable { get; set; }
    }

    public class Defaultcao
    {
        public string _ref { get; set; }
    }

    public class Defaultimporttype
    {
        public string _ref { get; set; }
    }

    public class Defaultikbsubscriptiontype
    {
        public string _ref { get; set; }
    }

    public class Defaultstatus
    {
        public string _ref { get; set; }
    }

    public class Defaultoperationmode
    {
        public string _ref { get; set; }
    }

    public class Defaultemployerperiodtype
    {
        public string _ref { get; set; }
    }

    public class Defaultuseractivationflow
    {
        public string _ref { get; set; }
    }

    public class Defaulttermsofservicerequirements
    {
        public string _ref { get; set; }
    }

    public class Defaultshoppricedisplaypolicy
    {
        public string _ref { get; set; }
    }

    public class Defaultshoptaxationpolicy
    {
        public string _ref { get; set; }
    }

    public class Allowedikbsubscriptiontypes
    {
        public string type { get; set; }
        public bool nullable { get; set; }
        public Items146 items { get; set; }
    }

    public class Items146
    {
        public string _ref { get; set; }
    }

    public class Allowedemployerperiodtypes
    {
        public string type { get; set; }
        public bool nullable { get; set; }
        public Items147 items { get; set; }
    }

    public class Items147
    {
        public string _ref { get; set; }
    }

    public class Invisiblegridcolumns
    {
        public string type { get; set; }
        public bool nullable { get; set; }
        public Items148 items { get; set; }
    }

    public class Items148
    {
        public string type { get; set; }
    }

    public class Invisibleeditorfields
    {
        public string type { get; set; }
        public bool nullable { get; set; }
        public Items149 items { get; set; }
    }

    public class Items149
    {
        public string type { get; set; }
    }

    public class Employeemodeloptions
    {
        public string type { get; set; }
        public bool additionalProperties { get; set; }
        public Properties117 properties { get; set; }
    }

    public class Properties117
    {
        public Usecurrentperiodforemptyperiod1 UseCurrentPeriodForEmptyPeriod { get; set; }
        public Additionalvalidators AdditionalValidators { get; set; }
        public Allowedadditionalvalidators AllowedAdditionalValidators { get; set; }
        public Defaultemployeefilenameparser DefaultEmployeeFileNameParser { get; set; }
        public Monthlyperioddaysthreshold MonthlyPeriodDaysThreshold { get; set; }
        public Fourweeklyperioddaysthreshold FourWeeklyPeriodDaysThreshold { get; set; }
        public Annualperioddaysthreshold AnnualPeriodDaysThreshold { get; set; }
    }

    public class Usecurrentperiodforemptyperiod1
    {
        public string type { get; set; }
    }

    public class Additionalvalidators
    {
        public string type { get; set; }
        public bool nullable { get; set; }
        public Items150 items { get; set; }
    }

    public class Items150
    {
        public string type { get; set; }
    }

    public class Allowedadditionalvalidators
    {
        public string type { get; set; }
        public bool nullable { get; set; }
        public Items151 items { get; set; }
    }

    public class Items151
    {
        public string type { get; set; }
    }

    public class Defaultemployeefilenameparser
    {
        public string type { get; set; }
        public bool nullable { get; set; }
    }

    public class Monthlyperioddaysthreshold
    {
        public string type { get; set; }
        public string format { get; set; }
    }

    public class Fourweeklyperioddaysthreshold
    {
        public string type { get; set; }
        public string format { get; set; }
    }

    public class Annualperioddaysthreshold
    {
        public string type { get; set; }
        public string format { get; set; }
    }

    public class Loggingoptions
    {
        public string type { get; set; }
        public bool additionalProperties { get; set; }
        public Properties118 properties { get; set; }
    }

    public class Properties118
    {
        public Tracktraceprefix TrackTracePrefix { get; set; }
        public Tracktracevariablepartlength TrackTraceVariablePartLength { get; set; }
    }

    public class Tracktraceprefix
    {
        public string type { get; set; }
        public bool nullable { get; set; }
    }

    public class Tracktracevariablepartlength
    {
        public string type { get; set; }
        public string format { get; set; }
    }

    public class Profileoptions
    {
        public string type { get; set; }
        public bool additionalProperties { get; set; }
        public Properties119 properties { get; set; }
    }

    public class Properties119
    {
        public Checkplandeadlines CheckPlanDeadlines { get; set; }
        public Checkincompletesurveys CheckIncompleteSurveys { get; set; }
        public Daysafterlastmodifiedforincompletesurvey DaysAfterLastModifiedForIncompleteSurvey { get; set; }
        public Checkperiodicsurveys CheckPeriodicSurveys { get; set; }
        public Daysafterlastmodifiedforperiodicsurvey DaysAfterLastModifiedForPeriodicSurvey { get; set; }
        public Checknosurveys CheckNoSurveys { get; set; }
        public Daysafterregistrationfornosurvey DaysAfterRegistrationForNoSurvey { get; set; }
    }

    public class Checkplandeadlines
    {
        public string type { get; set; }
    }

    public class Checkincompletesurveys
    {
        public string type { get; set; }
    }

    public class Daysafterlastmodifiedforincompletesurvey
    {
        public string type { get; set; }
        public string format { get; set; }
    }

    public class Checkperiodicsurveys
    {
        public string type { get; set; }
    }

    public class Daysafterlastmodifiedforperiodicsurvey
    {
        public string type { get; set; }
        public string format { get; set; }
    }

    public class Checknosurveys
    {
        public string type { get; set; }
    }

    public class Daysafterregistrationfornosurvey
    {
        public string type { get; set; }
        public string format { get; set; }
    }

    public class Shopoptions
    {
        public string type { get; set; }
        public bool additionalProperties { get; set; }
        public Properties120 properties { get; set; }
    }

    public class Properties120
    {
        public Checkrateabletransactions CheckRateableTransactions { get; set; }
        public Daysafterlastmodifiedforrateabletransaction DaysAfterLastModifiedForRateableTransaction { get; set; }
    }

    public class Checkrateabletransactions
    {
        public string type { get; set; }
    }

    public class Daysafterlastmodifiedforrateabletransaction
    {
        public string type { get; set; }
        public string format { get; set; }
    }

    public class Singleresultofproductgroup
    {
        public Allof31[] allOf { get; set; }
    }

    public class Allof31
    {
        public string _ref { get; set; }
        public string type { get; set; }
        public bool additionalProperties { get; set; }
        public Properties121 properties { get; set; }
    }

    public class Properties121
    {
        public Queryable19 Queryable { get; set; }
    }

    public class Queryable19
    {
        public string type { get; set; }
        public bool nullable { get; set; }
        public Items152 items { get; set; }
    }

    public class Items152
    {
        public string _ref { get; set; }
    }

    public class Singleresultoforgunitbudget
    {
        public Allof32[] allOf { get; set; }
    }

    public class Allof32
    {
        public string _ref { get; set; }
        public string type { get; set; }
        public bool additionalProperties { get; set; }
        public Properties122 properties { get; set; }
    }

    public class Properties122
    {
        public Queryable20 Queryable { get; set; }
    }

    public class Queryable20
    {
        public string type { get; set; }
        public bool nullable { get; set; }
        public Items153 items { get; set; }
    }

    public class Items153
    {
        public string _ref { get; set; }
    }

    public class Adjustbudgetparameters
    {
        public string type { get; set; }
        public bool additionalProperties { get; set; }
        public string[] required { get; set; }
        public Properties123 properties { get; set; }
    }

    public class Properties123
    {
        public Adjustmenttype AdjustmentType { get; set; }
        public Adjustmentamount AdjustmentAmount { get; set; }
        public Reason3 Reason { get; set; }
    }

    public class Adjustmenttype
    {
        public int minLength { get; set; }
        public Oneof197[] oneOf { get; set; }
    }

    public class Oneof197
    {
        public string _ref { get; set; }
    }

    public class Adjustmentamount
    {
        public bool nullable { get; set; }
        public Oneof198[] oneOf { get; set; }
    }

    public class Oneof198
    {
        public string _ref { get; set; }
    }

    public class Reason3
    {
        public string type { get; set; }
        public bool nullable { get; set; }
    }

    public class Budgetadjustmenttype
    {
        public string type { get; set; }
        public string description { get; set; }
        public string[] xenumNames { get; set; }
        public string[] _enum { get; set; }
    }

    public class Prioritizeorgunitbudgetsparameters
    {
        public string type { get; set; }
        public bool additionalProperties { get; set; }
        public Properties124 properties { get; set; }
    }

    public class Properties124
    {
        public Idpriorities IdPriorities { get; set; }
    }

    public class Idpriorities
    {
        public string type { get; set; }
        public bool nullable { get; set; }
        public Items154 items { get; set; }
    }

    public class Items154
    {
        public string _ref { get; set; }
    }

    public class Idpriority
    {
        public string type { get; set; }
        public bool additionalProperties { get; set; }
        public Properties125 properties { get; set; }
    }

    public class Properties125
    {
        public Id38 Id { get; set; }
        public Priority1 Priority { get; set; }
    }

    public class Id38
    {
        public string type { get; set; }
        public string format { get; set; }
    }

    public class Priority1
    {
        public string type { get; set; }
        public string format { get; set; }
    }

    public class Singleresultofemployeebudget
    {
        public Allof33[] allOf { get; set; }
    }

    public class Allof33
    {
        public string _ref { get; set; }
        public string type { get; set; }
        public bool additionalProperties { get; set; }
        public Properties126 properties { get; set; }
    }

    public class Properties126
    {
        public Queryable21 Queryable { get; set; }
    }

    public class Queryable21
    {
        public string type { get; set; }
        public bool nullable { get; set; }
        public Items155 items { get; set; }
    }

    public class Items155
    {
        public string _ref { get; set; }
    }

    public class Adjustbudgetsparameters
    {
        public string type { get; set; }
        public bool additionalProperties { get; set; }
        public string[] required { get; set; }
        public Properties127 properties { get; set; }
    }

    public class Properties127
    {
        public Adjustmenttype1 AdjustmentType { get; set; }
        public Adjustmentamount1 AdjustmentAmount { get; set; }
        public Filter7 Filter { get; set; }
        public Reason4 Reason { get; set; }
    }

    public class Adjustmenttype1
    {
        public int minLength { get; set; }
        public Oneof199[] oneOf { get; set; }
    }

    public class Oneof199
    {
        public string _ref { get; set; }
    }

    public class Adjustmentamount1
    {
        public bool nullable { get; set; }
        public Oneof200[] oneOf { get; set; }
    }

    public class Oneof200
    {
        public string _ref { get; set; }
    }

    public class Filter7
    {
        public string type { get; set; }
        public bool nullable { get; set; }
    }

    public class Reason4
    {
        public string type { get; set; }
        public bool nullable { get; set; }
    }

    public class Adjustbudgetparameters2
    {
        public string type { get; set; }
        public bool additionalProperties { get; set; }
        public string[] required { get; set; }
        public Properties128 properties { get; set; }
    }

    public class Properties128
    {
        public Adjustmenttype2 AdjustmentType { get; set; }
        public Adjustmentamount2 AdjustmentAmount { get; set; }
        public Reason5 Reason { get; set; }
    }

    public class Adjustmenttype2
    {
        public int minLength { get; set; }
        public Oneof201[] oneOf { get; set; }
    }

    public class Oneof201
    {
        public string _ref { get; set; }
    }

    public class Adjustmentamount2
    {
        public bool nullable { get; set; }
        public Oneof202[] oneOf { get; set; }
    }

    public class Oneof202
    {
        public string _ref { get; set; }
    }

    public class Reason5
    {
        public string type { get; set; }
        public bool nullable { get; set; }
    }

    public class Singleresultofemployeeimport
    {
        public Allof34[] allOf { get; set; }
    }

    public class Allof34
    {
        public string _ref { get; set; }
        public string type { get; set; }
        public bool additionalProperties { get; set; }
        public Properties129 properties { get; set; }
    }

    public class Properties129
    {
        public Queryable22 Queryable { get; set; }
    }

    public class Queryable22
    {
        public string type { get; set; }
        public bool nullable { get; set; }
        public Items156 items { get; set; }
    }

    public class Items156
    {
        public string _ref { get; set; }
    }

    public class Orgunitchannel
    {
        public Allof35[] allOf { get; set; }
    }

    public class Allof35
    {
        public string _ref { get; set; }
        public string type { get; set; }
        public bool additionalProperties { get; set; }
        public Properties130 properties { get; set; }
    }

    public class Properties130
    {
        public Dependsongenericconfigurationtype DependsOnGenericConfigurationType { get; set; }
    }

    public class Dependsongenericconfigurationtype
    {
        public string type { get; set; }
        public bool nullable { get; set; }
    }

    public class Orgunitclassconfigurationofichannel
    {
        public string type { get; set; }
        public bool xabstract { get; set; }
        public bool additionalProperties { get; set; }
        public string[] required { get; set; }
        public Properties131 properties { get; set; }
    }

    public class Properties131
    {
        public Id39 Id { get; set; }
        public Orgunit14 OrgUnit { get; set; }
        public Orgunitid17 OrgUnitId { get; set; }
        public Isactive5 IsActive { get; set; }
        public Serializedconfiguration SerializedConfiguration { get; set; }
        public Description6 Description { get; set; }
        public Genericconfigurationtype GenericConfigurationType { get; set; }
    }

    public class Id39
    {
        public string type { get; set; }
        public string format { get; set; }
    }

    public class Orgunit14
    {
        public bool nullable { get; set; }
        public Oneof203[] oneOf { get; set; }
    }

    public class Oneof203
    {
        public string _ref { get; set; }
    }

    public class Orgunitid17
    {
        public string type { get; set; }
        public string format { get; set; }
    }

    public class Isactive5
    {
        public string type { get; set; }
    }

    public class Serializedconfiguration
    {
        public string type { get; set; }
        public int minLength { get; set; }
    }

    public class Description6
    {
        public string type { get; set; }
        public bool nullable { get; set; }
    }

    public class Genericconfigurationtype
    {
        public string type { get; set; }
        public int minLength { get; set; }
    }

    public class Singleresultoforgunitchannel
    {
        public Allof36[] allOf { get; set; }
    }

    public class Allof36
    {
        public string _ref { get; set; }
        public string type { get; set; }
        public bool additionalProperties { get; set; }
        public Properties132 properties { get; set; }
    }

    public class Properties132
    {
        public Queryable23 Queryable { get; set; }
    }

    public class Queryable23
    {
        public string type { get; set; }
        public bool nullable { get; set; }
        public Items157 items { get; set; }
    }

    public class Items157
    {
        public string _ref { get; set; }
    }

    public class Orgunitcryptor
    {
        public Allof37[] allOf { get; set; }
    }

    public class Allof37
    {
        public string _ref { get; set; }
        public string type { get; set; }
        public bool additionalProperties { get; set; }
        public Properties133 properties { get; set; }
    }

    public class Properties133
    {
        public Dependsongenericconfigurationtype1 DependsOnGenericConfigurationType { get; set; }
    }

    public class Dependsongenericconfigurationtype1
    {
        public string type { get; set; }
        public bool nullable { get; set; }
    }

    public class Orgunitclassconfigurationoficryptor
    {
        public string type { get; set; }
        public bool xabstract { get; set; }
        public bool additionalProperties { get; set; }
        public string[] required { get; set; }
        public Properties134 properties { get; set; }
    }

    public class Properties134
    {
        public Id40 Id { get; set; }
        public Orgunit15 OrgUnit { get; set; }
        public Orgunitid18 OrgUnitId { get; set; }
        public Isactive6 IsActive { get; set; }
        public Serializedconfiguration1 SerializedConfiguration { get; set; }
        public Description7 Description { get; set; }
        public Genericconfigurationtype1 GenericConfigurationType { get; set; }
    }

    public class Id40
    {
        public string type { get; set; }
        public string format { get; set; }
    }

    public class Orgunit15
    {
        public bool nullable { get; set; }
        public Oneof204[] oneOf { get; set; }
    }

    public class Oneof204
    {
        public string _ref { get; set; }
    }

    public class Orgunitid18
    {
        public string type { get; set; }
        public string format { get; set; }
    }

    public class Isactive6
    {
        public string type { get; set; }
    }

    public class Serializedconfiguration1
    {
        public string type { get; set; }
        public int minLength { get; set; }
    }

    public class Description7
    {
        public string type { get; set; }
        public bool nullable { get; set; }
    }

    public class Genericconfigurationtype1
    {
        public string type { get; set; }
        public int minLength { get; set; }
    }

    public class Singleresultoforgunitcryptor
    {
        public Allof38[] allOf { get; set; }
    }

    public class Allof38
    {
        public string _ref { get; set; }
        public string type { get; set; }
        public bool additionalProperties { get; set; }
        public Properties135 properties { get; set; }
    }

    public class Properties135
    {
        public Queryable24 Queryable { get; set; }
    }

    public class Queryable24
    {
        public string type { get; set; }
        public bool nullable { get; set; }
        public Items158 items { get; set; }
    }

    public class Items158
    {
        public string _ref { get; set; }
    }

    public class Singleresultofsurveyresponse
    {
        public Allof39[] allOf { get; set; }
    }

    public class Allof39
    {
        public string _ref { get; set; }
        public string type { get; set; }
        public bool additionalProperties { get; set; }
        public Properties136 properties { get; set; }
    }

    public class Properties136
    {
        public Queryable25 Queryable { get; set; }
    }

    public class Queryable25
    {
        public string type { get; set; }
        public bool nullable { get; set; }
        public Items159 items { get; set; }
    }

    public class Items159
    {
        public string _ref { get; set; }
    }

    public class Singleresultofproductsupplier
    {
        public Allof40[] allOf { get; set; }
    }

    public class Allof40
    {
        public string _ref { get; set; }
        public string type { get; set; }
        public bool additionalProperties { get; set; }
        public Properties137 properties { get; set; }
    }

    public class Properties137
    {
        public Queryable26 Queryable { get; set; }
    }

    public class Queryable26
    {
        public string type { get; set; }
        public bool nullable { get; set; }
        public Items160 items { get; set; }
    }

    public class Items160
    {
        public string _ref { get; set; }
    }

    public class Orgunitconnector
    {
        public Allof41[] allOf { get; set; }
    }

    public class Allof41
    {
        public string _ref { get; set; }
        public string type { get; set; }
        public bool additionalProperties { get; set; }
        public Properties138 properties { get; set; }
    }

    public class Properties138
    {
        public Orgunitchannelid OrgUnitChannelId { get; set; }
        public Orgunitchannel1 OrgUnitChannel { get; set; }
        public Orgunitcryptorid OrgUnitCryptorId { get; set; }
        public Orgunitcryptor1 OrgUnitCryptor { get; set; }
        public Cronexpression CronExpression { get; set; }
    }

    public class Orgunitchannelid
    {
        public string type { get; set; }
        public string format { get; set; }
        public bool nullable { get; set; }
    }

    public class Orgunitchannel1
    {
        public bool nullable { get; set; }
        public Oneof205[] oneOf { get; set; }
    }

    public class Oneof205
    {
        public string _ref { get; set; }
    }

    public class Orgunitcryptorid
    {
        public string type { get; set; }
        public string format { get; set; }
        public bool nullable { get; set; }
    }

    public class Orgunitcryptor1
    {
        public bool nullable { get; set; }
        public Oneof206[] oneOf { get; set; }
    }

    public class Oneof206
    {
        public string _ref { get; set; }
    }

    public class Cronexpression
    {
        public string type { get; set; }
        public bool nullable { get; set; }
    }

    public class Iorgunitchannel
    {
        public string type { get; set; }
        public bool xabstract { get; set; }
        public bool additionalProperties { get; set; }
    }

    public class Iorgunitcryptor
    {
        public string type { get; set; }
        public bool xabstract { get; set; }
        public bool additionalProperties { get; set; }
    }

    public class Orgunitclassconfigurationoficonnector
    {
        public string type { get; set; }
        public bool xabstract { get; set; }
        public bool additionalProperties { get; set; }
        public string[] required { get; set; }
        public Properties139 properties { get; set; }
    }

    public class Properties139
    {
        public Id41 Id { get; set; }
        public Orgunit16 OrgUnit { get; set; }
        public Orgunitid19 OrgUnitId { get; set; }
        public Isactive7 IsActive { get; set; }
        public Serializedconfiguration2 SerializedConfiguration { get; set; }
        public Description8 Description { get; set; }
        public Genericconfigurationtype2 GenericConfigurationType { get; set; }
    }

    public class Id41
    {
        public string type { get; set; }
        public string format { get; set; }
    }

    public class Orgunit16
    {
        public bool nullable { get; set; }
        public Oneof207[] oneOf { get; set; }
    }

    public class Oneof207
    {
        public string _ref { get; set; }
    }

    public class Orgunitid19
    {
        public string type { get; set; }
        public string format { get; set; }
    }

    public class Isactive7
    {
        public string type { get; set; }
    }

    public class Serializedconfiguration2
    {
        public string type { get; set; }
        public int minLength { get; set; }
    }

    public class Description8
    {
        public string type { get; set; }
        public bool nullable { get; set; }
    }

    public class Genericconfigurationtype2
    {
        public string type { get; set; }
        public int minLength { get; set; }
    }

    public class Singleresultoforgunitconnector
    {
        public Allof42[] allOf { get; set; }
    }

    public class Allof42
    {
        public string _ref { get; set; }
        public string type { get; set; }
        public bool additionalProperties { get; set; }
        public Properties140 properties { get; set; }
    }

    public class Properties140
    {
        public Queryable27 Queryable { get; set; }
    }

    public class Queryable27
    {
        public string type { get; set; }
        public bool nullable { get; set; }
        public Items161 items { get; set; }
    }

    public class Items161
    {
        public string _ref { get; set; }
    }

    public class Templateresource
    {
        public string type { get; set; }
        public bool additionalProperties { get; set; }
        public string[] required { get; set; }
        public Properties141 properties { get; set; }
    }

    public class Properties141
    {
        public Id42 Id { get; set; }
        public Resourcecode ResourceCode { get; set; }
        public Culturename CultureName { get; set; }
        public Orgunitid20 OrgUnitId { get; set; }
        public Orgunit17 OrgUnit { get; set; }
        public Name15 Name { get; set; }
        public Subjecttemplate SubjectTemplate { get; set; }
        public Bodytemplate BodyTemplate { get; set; }
        public Cultureinfo CultureInfo { get; set; }
    }

    public class Id42
    {
        public string type { get; set; }
        public string format { get; set; }
    }

    public class Resourcecode
    {
        public string type { get; set; }
        public int maxLength { get; set; }
        public int minLength { get; set; }
        public string pattern { get; set; }
    }

    public class Culturename
    {
        public string type { get; set; }
        public int maxLength { get; set; }
        public int minLength { get; set; }
        public string pattern { get; set; }
    }

    public class Orgunitid20
    {
        public string type { get; set; }
        public string format { get; set; }
        public bool nullable { get; set; }
    }

    public class Orgunit17
    {
        public bool nullable { get; set; }
        public Oneof208[] oneOf { get; set; }
    }

    public class Oneof208
    {
        public string _ref { get; set; }
    }

    public class Name15
    {
        public string type { get; set; }
        public bool nullable { get; set; }
    }

    public class Subjecttemplate
    {
        public string type { get; set; }
        public bool nullable { get; set; }
    }

    public class Bodytemplate
    {
        public string type { get; set; }
        public int minLength { get; set; }
    }

    public class Cultureinfo
    {
        public string type { get; set; }
        public bool nullable { get; set; }
    }

    public class Singleresultoftemplateresource
    {
        public Allof43[] allOf { get; set; }
    }

    public class Allof43
    {
        public string _ref { get; set; }
        public string type { get; set; }
        public bool additionalProperties { get; set; }
        public Properties142 properties { get; set; }
    }

    public class Properties142
    {
        public Queryable28 Queryable { get; set; }
    }

    public class Queryable28
    {
        public string type { get; set; }
        public bool nullable { get; set; }
        public Items162 items { get; set; }
    }

    public class Items162
    {
        public string _ref { get; set; }
    }

    public class Singleresultoftaggedcontentitem
    {
        public Allof44[] allOf { get; set; }
    }

    public class Allof44
    {
        public string _ref { get; set; }
        public string type { get; set; }
        public bool additionalProperties { get; set; }
        public Properties143 properties { get; set; }
    }

    public class Properties143
    {
        public Queryable29 Queryable { get; set; }
    }

    public class Queryable29
    {
        public string type { get; set; }
        public bool nullable { get; set; }
        public Items163 items { get; set; }
    }

    public class Items163
    {
        public string _ref { get; set; }
    }

    public class Singleresultoftracktracemessage
    {
        public Allof45[] allOf { get; set; }
    }

    public class Allof45
    {
        public string _ref { get; set; }
        public string type { get; set; }
        public bool additionalProperties { get; set; }
        public Properties144 properties { get; set; }
    }

    public class Properties144
    {
        public Queryable30 Queryable { get; set; }
    }

    public class Queryable30
    {
        public string type { get; set; }
        public bool nullable { get; set; }
        public Items164 items { get; set; }
    }

    public class Items164
    {
        public string _ref { get; set; }
    }

    public class Singleresultofcatalogsubscription
    {
        public Allof46[] allOf { get; set; }
    }

    public class Allof46
    {
        public string _ref { get; set; }
        public string type { get; set; }
        public bool additionalProperties { get; set; }
        public Properties145 properties { get; set; }
    }

    public class Properties145
    {
        public Queryable31 Queryable { get; set; }
    }

    public class Queryable31
    {
        public string type { get; set; }
        public bool nullable { get; set; }
        public Items165 items { get; set; }
    }

    public class Items165
    {
        public string _ref { get; set; }
    }

    public class Productchoicebatch
    {
        public string type { get; set; }
        public bool additionalProperties { get; set; }
        public Properties146 properties { get; set; }
    }

    public class Properties146
    {
        public Id43 Id { get; set; }
        public Status4 Status { get; set; }
        public Tracktracecodeid5 TrackTraceCodeId { get; set; }
        public Tracktracecode5 TrackTraceCode { get; set; }
        public Productchoices ProductChoices { get; set; }
        public Created2 Created { get; set; }
    }

    public class Id43
    {
        public string type { get; set; }
        public string format { get; set; }
    }

    public class Status4
    {
        public string _ref { get; set; }
    }

    public class Tracktracecodeid5
    {
        public string type { get; set; }
        public string format { get; set; }
    }

    public class Tracktracecode5
    {
        public bool nullable { get; set; }
        public Oneof209[] oneOf { get; set; }
    }

    public class Oneof209
    {
        public string _ref { get; set; }
    }

    public class Productchoices
    {
        public string type { get; set; }
        public bool nullable { get; set; }
        public Items166 items { get; set; }
    }

    public class Items166
    {
        public string _ref { get; set; }
    }

    public class Created2
    {
        public string type { get; set; }
        public string format { get; set; }
    }

    public class Productchoicebatchstatus
    {
        public string type { get; set; }
        public string description { get; set; }
        public string[] xenumNames { get; set; }
        public string[] _enum { get; set; }
    }

    public class Productchoice
    {
        public string type { get; set; }
        public bool additionalProperties { get; set; }
        public Properties147 properties { get; set; }
    }

    public class Properties147
    {
        public Id44 Id { get; set; }
        public Employeenumber1 EmployeeNumber { get; set; }
        public Companyproductcode CompanyProductCode { get; set; }
        public Iselectproductcode IselectProductCode { get; set; }
        public Value3 Value { get; set; }
        public Valuetype ValueType { get; set; }
        public Companywagecode CompanyWageCode { get; set; }
        public Iselectwagecode IselectWageCode { get; set; }
        public Choicedate ChoiceDate { get; set; }
        public Periodstartdate PeriodStartDate { get; set; }
        public Periodenddate PeriodEndDate { get; set; }
        public Period2 Period { get; set; }
        public Year2 Year { get; set; }
        public Productchoicebatchid ProductChoiceBatchId { get; set; }
        public Productchoicebatch1 ProductChoiceBatch { get; set; }
    }

    public class Id44
    {
        public string type { get; set; }
        public string format { get; set; }
    }

    public class Employeenumber1
    {
        public string type { get; set; }
        public bool nullable { get; set; }
    }

    public class Companyproductcode
    {
        public string type { get; set; }
        public bool nullable { get; set; }
    }

    public class Iselectproductcode
    {
        public string _ref { get; set; }
    }

    public class Value3
    {
        public string type { get; set; }
        public string format { get; set; }
    }

    public class Valuetype
    {
        public string _ref { get; set; }
    }

    public class Companywagecode
    {
        public string type { get; set; }
        public bool nullable { get; set; }
    }

    public class Iselectwagecode
    {
        public string _ref { get; set; }
    }

    public class Choicedate
    {
        public string type { get; set; }
        public string format { get; set; }
    }

    public class Periodstartdate
    {
        public string type { get; set; }
        public string format { get; set; }
    }

    public class Periodenddate
    {
        public string type { get; set; }
        public string format { get; set; }
    }

    public class Period2
    {
        public string type { get; set; }
    }

    public class Year2
    {
        public string type { get; set; }
    }

    public class Productchoicebatchid
    {
        public string type { get; set; }
        public string format { get; set; }
    }

    public class Productchoicebatch1
    {
        public bool nullable { get; set; }
        public Oneof210[] oneOf { get; set; }
    }

    public class Oneof210
    {
        public string _ref { get; set; }
    }

    public class Iselectproductcode1
    {
        public string type { get; set; }
        public string description { get; set; }
        public string[] xenumNames { get; set; }
        public string[] _enum { get; set; }
    }

    public class Valuetype1
    {
        public string type { get; set; }
        public string description { get; set; }
        public string[] xenumNames { get; set; }
        public string[] _enum { get; set; }
    }

    public class Iselectwagecode1
    {
        public string type { get; set; }
        public string description { get; set; }
        public string[] xenumNames { get; set; }
        public string[] _enum { get; set; }
    }

    public class Singleresultofproductchoicebatch
    {
        public Allof47[] allOf { get; set; }
    }

    public class Allof47
    {
        public string _ref { get; set; }
        public string type { get; set; }
        public bool additionalProperties { get; set; }
        public Properties148 properties { get; set; }
    }

    public class Properties148
    {
        public Queryable32 Queryable { get; set; }
    }

    public class Queryable32
    {
        public string type { get; set; }
        public bool nullable { get; set; }
        public Items167 items { get; set; }
    }

    public class Items167
    {
        public string _ref { get; set; }
    }

    public class Orgunitauthenticator
    {
        public Allof48[] allOf { get; set; }
    }

    public class Allof48
    {
        public string _ref { get; set; }
        public string type { get; set; }
        public bool additionalProperties { get; set; }
    }

    public class Orgunitclassconfigurationofiauthenticator
    {
        public string type { get; set; }
        public bool xabstract { get; set; }
        public bool additionalProperties { get; set; }
        public string[] required { get; set; }
        public Properties149 properties { get; set; }
    }

    public class Properties149
    {
        public Id45 Id { get; set; }
        public Orgunit18 OrgUnit { get; set; }
        public Orgunitid21 OrgUnitId { get; set; }
        public Isactive8 IsActive { get; set; }
        public Serializedconfiguration3 SerializedConfiguration { get; set; }
        public Description9 Description { get; set; }
        public Genericconfigurationtype3 GenericConfigurationType { get; set; }
    }

    public class Id45
    {
        public string type { get; set; }
        public string format { get; set; }
    }

    public class Orgunit18
    {
        public bool nullable { get; set; }
        public Oneof211[] oneOf { get; set; }
    }

    public class Oneof211
    {
        public string _ref { get; set; }
    }

    public class Orgunitid21
    {
        public string type { get; set; }
        public string format { get; set; }
    }

    public class Isactive8
    {
        public string type { get; set; }
    }

    public class Serializedconfiguration3
    {
        public string type { get; set; }
        public int minLength { get; set; }
    }

    public class Description9
    {
        public string type { get; set; }
        public bool nullable { get; set; }
    }

    public class Genericconfigurationtype3
    {
        public string type { get; set; }
        public int minLength { get; set; }
    }

    public class Singleresultoforgunitauthenticator
    {
        public Allof49[] allOf { get; set; }
    }

    public class Allof49
    {
        public string _ref { get; set; }
        public string type { get; set; }
        public bool additionalProperties { get; set; }
        public Properties150 properties { get; set; }
    }

    public class Properties150
    {
        public Queryable33 Queryable { get; set; }
    }

    public class Queryable33
    {
        public string type { get; set; }
        public bool nullable { get; set; }
        public Items168 items { get; set; }
    }

    public class Items168
    {
        public string _ref { get; set; }
    }

    public class Applicationconfiguration
    {
        public string type { get; set; }
        public bool additionalProperties { get; set; }
        public Properties151 properties { get; set; }
    }

    public class Properties151
    {
        public Id46 Id { get; set; }
        public Cao3 Cao { get; set; }
        public Useractivationflow3 UserActivationFlow { get; set; }
        public Employeeimporttype2 EmployeeImportType { get; set; }
        public Employerperiodtype3 EmployerPeriodType { get; set; }
        public Ikbsubscriptiontype3 IkbSubscriptionType { get; set; }
        public Perioddaysthreshold2 PeriodDaysThreshold { get; set; }
        public Numberofdaysoutofservicebeforedisabling2 NumberOfDaysOutOfServiceBeforeDisabling { get; set; }
        public Shoppricedisplaypolicy3 ShopPriceDisplayPolicy { get; set; }
        public Shoptaxationpolicy3 ShopTaxationPolicy { get; set; }
        public Termsofservicerequirements3 TermsOfServiceRequirements { get; set; }
    }

    public class Id46
    {
        public string type { get; set; }
        public string format { get; set; }
    }

    public class Cao3
    {
        public string _ref { get; set; }
    }

    public class Useractivationflow3
    {
        public string _ref { get; set; }
    }

    public class Employeeimporttype2
    {
        public string _ref { get; set; }
    }

    public class Employerperiodtype3
    {
        public string _ref { get; set; }
    }

    public class Ikbsubscriptiontype3
    {
        public string _ref { get; set; }
    }

    public class Perioddaysthreshold2
    {
        public string type { get; set; }
        public string format { get; set; }
        public bool nullable { get; set; }
    }

    public class Numberofdaysoutofservicebeforedisabling2
    {
        public string type { get; set; }
        public string format { get; set; }
        public bool nullable { get; set; }
    }

    public class Shoppricedisplaypolicy3
    {
        public string _ref { get; set; }
    }

    public class Shoptaxationpolicy3
    {
        public string _ref { get; set; }
    }

    public class Termsofservicerequirements3
    {
        public string _ref { get; set; }
    }

    public class Singleresultofapplicationconfiguration
    {
        public Allof50[] allOf { get; set; }
    }

    public class Allof50
    {
        public string _ref { get; set; }
        public string type { get; set; }
        public bool additionalProperties { get; set; }
        public Properties152 properties { get; set; }
    }

    public class Properties152
    {
        public Queryable34 Queryable { get; set; }
    }

    public class Queryable34
    {
        public string type { get; set; }
        public bool nullable { get; set; }
        public Items169 items { get; set; }
    }

    public class Items169
    {
        public string _ref { get; set; }
    }

    public class Singleresultofemployeedatamodification
    {
        public Allof51[] allOf { get; set; }
    }

    public class Allof51
    {
        public string _ref { get; set; }
        public string type { get; set; }
        public bool additionalProperties { get; set; }
        public Properties153 properties { get; set; }
    }

    public class Properties153
    {
        public Queryable35 Queryable { get; set; }
    }

    public class Queryable35
    {
        public string type { get; set; }
        public bool nullable { get; set; }
        public Items170 items { get; set; }
    }

    public class Items170
    {
        public string _ref { get; set; }
    }

    public class Modifyparameters
    {
        public string type { get; set; }
        public bool additionalProperties { get; set; }
        public string[] required { get; set; }
        public Properties154 properties { get; set; }
    }

    public class Properties154
    {
        public Effectivedate1 EffectiveDate { get; set; }
        public Employeedata EmployeeData { get; set; }
    }

    public class Effectivedate1
    {
        public string type { get; set; }
        public string format { get; set; }
        public int minLength { get; set; }
    }

    public class Employeedata
    {
        public bool nullable { get; set; }
        public Oneof212[] oneOf { get; set; }
    }

    public class Oneof212
    {
        public string _ref { get; set; }
    }

    public class Usermodifiableemployeedata
    {
        public string type { get; set; }
        public bool additionalProperties { get; set; }
        public Properties155 properties { get; set; }
    }

    public class Properties155
    {
        public Civilstatus3 CivilStatus { get; set; }
        public Civilstatusstartdate2 CivilStatusStartDate { get; set; }
        public Numberofchildren2 NumberOfChildren { get; set; }
        public Street2 Street { get; set; }
        public Housenumber2 HouseNumber { get; set; }
        public Housenumbersuffix2 HouseNumberSuffix { get; set; }
        public Postalcode3 PostalCode { get; set; }
        public City3 City { get; set; }
        public Countrycode2 CountryCode { get; set; }
        public Phone2 Phone { get; set; }
        public Mobilephone2 MobilePhone { get; set; }
        public Emergencyphone2 EmergencyPhone { get; set; }
        public Emergencyname2 EmergencyName { get; set; }
        public Bankcountrycode2 BankCountryCode { get; set; }
        public Bankbic2 BankBic { get; set; }
        public Bankiban2 BankIban { get; set; }
    }

    public class Civilstatus3
    {
        public string _ref { get; set; }
    }

    public class Civilstatusstartdate2
    {
        public string type { get; set; }
        public string format { get; set; }
        public bool nullable { get; set; }
    }

    public class Numberofchildren2
    {
        public string type { get; set; }
        public string format { get; set; }
        public bool nullable { get; set; }
    }

    public class Street2
    {
        public string type { get; set; }
        public bool nullable { get; set; }
    }

    public class Housenumber2
    {
        public string type { get; set; }
        public bool nullable { get; set; }
    }

    public class Housenumbersuffix2
    {
        public string type { get; set; }
        public bool nullable { get; set; }
    }

    public class Postalcode3
    {
        public string type { get; set; }
        public bool nullable { get; set; }
    }

    public class City3
    {
        public string type { get; set; }
        public bool nullable { get; set; }
    }

    public class Countrycode2
    {
        public string type { get; set; }
        public bool nullable { get; set; }
    }

    public class Phone2
    {
        public string type { get; set; }
        public bool nullable { get; set; }
    }

    public class Mobilephone2
    {
        public string type { get; set; }
        public bool nullable { get; set; }
    }

    public class Emergencyphone2
    {
        public string type { get; set; }
        public bool nullable { get; set; }
    }

    public class Emergencyname2
    {
        public string type { get; set; }
        public bool nullable { get; set; }
    }

    public class Bankcountrycode2
    {
        public string type { get; set; }
        public bool nullable { get; set; }
    }

    public class Bankbic2
    {
        public string type { get; set; }
        public bool nullable { get; set; }
    }

    public class Bankiban2
    {
        public string type { get; set; }
        public bool nullable { get; set; }
    }

    public class Rejectparameters2
    {
        public string type { get; set; }
        public bool additionalProperties { get; set; }
        public Properties156 properties { get; set; }
    }

    public class Properties156
    {
        public Reason6 Reason { get; set; }
    }

    public class Reason6
    {
        public string type { get; set; }
        public bool nullable { get; set; }
    }

    public class Approveparameters2
    {
        public string type { get; set; }
        public bool additionalProperties { get; set; }
        public Properties157 properties { get; set; }
    }

    public class Properties157
    {
        public Reason7 Reason { get; set; }
    }

    public class Reason7
    {
        public string type { get; set; }
        public bool nullable { get; set; }
    }

    public class Singleresultofproductimportspecification
    {
        public Allof52[] allOf { get; set; }
    }

    public class Allof52
    {
        public string _ref { get; set; }
        public string type { get; set; }
        public bool additionalProperties { get; set; }
        public Properties158 properties { get; set; }
    }

    public class Properties158
    {
        public Queryable36 Queryable { get; set; }
    }

    public class Queryable36
    {
        public string type { get; set; }
        public bool nullable { get; set; }
        public Items171 items { get; set; }
    }

    public class Items171
    {
        public string _ref { get; set; }
    }

    public class Productimportlog
    {
        public string type { get; set; }
        public bool additionalProperties { get; set; }
        public Properties159 properties { get; set; }
    }

    public class Properties159
    {
        public Id47 Id { get; set; }
        public Productimportspecificationid1 ProductImportSpecificationId { get; set; }
        public Productimportspecification1 ProductImportSpecification { get; set; }
        public Tracktracecodeid6 TrackTraceCodeId { get; set; }
        public Tracktracecode6 TrackTraceCode { get; set; }
        public Importstatus1 ImportStatus { get; set; }
        public Importstarttimestamp ImportStartTimestamp { get; set; }
        public Importendtimestamp ImportEndTimestamp { get; set; }
        public Importedproducts ImportedProducts { get; set; }
        public Serializedimportedproducts SerializedImportedProducts { get; set; }
        public Amounttotal AmountTotal { get; set; }
        public Amountfailed AmountFailed { get; set; }
        public Amountdeactivated AmountDeactivated { get; set; }
    }

    public class Id47
    {
        public string type { get; set; }
        public string format { get; set; }
    }

    public class Productimportspecificationid1
    {
        public string type { get; set; }
        public string format { get; set; }
    }

    public class Productimportspecification1
    {
        public bool nullable { get; set; }
        public Oneof213[] oneOf { get; set; }
    }

    public class Oneof213
    {
        public string _ref { get; set; }
    }

    public class Tracktracecodeid6
    {
        public string type { get; set; }
        public string format { get; set; }
    }

    public class Tracktracecode6
    {
        public bool nullable { get; set; }
        public Oneof214[] oneOf { get; set; }
    }

    public class Oneof214
    {
        public string _ref { get; set; }
    }

    public class Importstatus1
    {
        public string _ref { get; set; }
    }

    public class Importstarttimestamp
    {
        public string type { get; set; }
        public string format { get; set; }
    }

    public class Importendtimestamp
    {
        public string type { get; set; }
        public string format { get; set; }
        public bool nullable { get; set; }
    }

    public class Importedproducts
    {
        public string type { get; set; }
        public bool nullable { get; set; }
        public Items172 items { get; set; }
    }

    public class Items172
    {
        public string _ref { get; set; }
    }

    public class Serializedimportedproducts
    {
        public string type { get; set; }
        public bool nullable { get; set; }
    }

    public class Amounttotal
    {
        public string type { get; set; }
        public string format { get; set; }
    }

    public class Amountfailed
    {
        public string type { get; set; }
        public string format { get; set; }
    }

    public class Amountdeactivated
    {
        public string type { get; set; }
        public string format { get; set; }
    }

    public class Productimportstatus
    {
        public string type { get; set; }
        public string description { get; set; }
        public string[] xenumNames { get; set; }
        public string[] _enum { get; set; }
    }

    public class Productimportidentifier
    {
        public string type { get; set; }
        public bool additionalProperties { get; set; }
        public Properties160 properties { get; set; }
    }

    public class Properties160
    {
        public Catalogname CatalogName { get; set; }
        public Productexternalid ProductExternalId { get; set; }
        public Supplierexternalid SupplierExternalId { get; set; }
    }

    public class Catalogname
    {
        public string type { get; set; }
        public bool nullable { get; set; }
    }

    public class Productexternalid
    {
        public string type { get; set; }
        public bool nullable { get; set; }
    }

    public class Supplierexternalid
    {
        public string type { get; set; }
        public bool nullable { get; set; }
    }

    public class Productspecification
    {
        public string type { get; set; }
        public bool additionalProperties { get; set; }
        public Properties161 properties { get; set; }
    }

    public class Properties161
    {
        public Id48 Id { get; set; }
        public Orgunitid22 OrgUnitId { get; set; }
        public Orgunit19 OrgUnit { get; set; }
        public Functiongroupid2 FunctionGroupId { get; set; }
        public Functiongroup3 FunctionGroup { get; set; }
        public Productid2 ProductId { get; set; }
        public Product3 Product { get; set; }
        public Isapprovalrequired1 IsApprovalRequired { get; set; }
        public Taxationindication3 TaxationIndication { get; set; }
        public Taxationpolicy2 TaxationPolicy { get; set; }
        public Listprice2 ListPrice { get; set; }
        public Listpricetax2 ListPriceTax { get; set; }
        public Employeelistprice2 EmployeeListPrice { get; set; }
        public Employeelistpricetax2 EmployeeListPriceTax { get; set; }
        public Displaylistprice1 DisplayListPrice { get; set; }
        public Displayemployeelistprice1 DisplayEmployeeListPrice { get; set; }
        public Discountamount1 DiscountAmount { get; set; }
        public Taxdiscountamount1 TaxDiscountAmount { get; set; }
        public Resellerfeeamount1 ResellerFeeAmount { get; set; }
        public Taxresellerfeeamount1 TaxResellerFeeAmount { get; set; }
        public Discountruleid1 DiscountRuleId { get; set; }
        public Discountfactor2 DiscountFactor { get; set; }
        public Resellerfeefactor2 ResellerFeeFactor { get; set; }
        public Calculationmethod2 CalculationMethod { get; set; }
        public Excludedcosttypes2 ExcludedCostTypes { get; set; }
        public Serializedexcludedcosttypes SerializedExcludedCostTypes { get; set; }
    }

    public class Id48
    {
        public string type { get; set; }
        public string format { get; set; }
    }

    public class Orgunitid22
    {
        public string type { get; set; }
        public string format { get; set; }
    }

    public class Orgunit19
    {
        public bool nullable { get; set; }
        public Oneof215[] oneOf { get; set; }
    }

    public class Oneof215
    {
        public string _ref { get; set; }
    }

    public class Functiongroupid2
    {
        public string type { get; set; }
        public string format { get; set; }
        public bool nullable { get; set; }
    }

    public class Functiongroup3
    {
        public bool nullable { get; set; }
        public Oneof216[] oneOf { get; set; }
    }

    public class Oneof216
    {
        public string _ref { get; set; }
    }

    public class Productid2
    {
        public string type { get; set; }
        public string format { get; set; }
    }

    public class Product3
    {
        public bool nullable { get; set; }
        public Oneof217[] oneOf { get; set; }
    }

    public class Oneof217
    {
        public string _ref { get; set; }
    }

    public class Isapprovalrequired1
    {
        public string type { get; set; }
    }

    public class Taxationindication3
    {
        public bool nullable { get; set; }
        public Oneof218[] oneOf { get; set; }
    }

    public class Oneof218
    {
        public string _ref { get; set; }
    }

    public class Taxationpolicy2
    {
        public string _ref { get; set; }
    }

    public class Listprice2
    {
        public bool nullable { get; set; }
        public Oneof219[] oneOf { get; set; }
    }

    public class Oneof219
    {
        public string _ref { get; set; }
    }

    public class Listpricetax2
    {
        public bool nullable { get; set; }
        public Oneof220[] oneOf { get; set; }
    }

    public class Oneof220
    {
        public string _ref { get; set; }
    }

    public class Employeelistprice2
    {
        public bool nullable { get; set; }
        public Oneof221[] oneOf { get; set; }
    }

    public class Oneof221
    {
        public string _ref { get; set; }
    }

    public class Employeelistpricetax2
    {
        public bool nullable { get; set; }
        public Oneof222[] oneOf { get; set; }
    }

    public class Oneof222
    {
        public string _ref { get; set; }
    }

    public class Displaylistprice1
    {
        public bool nullable { get; set; }
        public Oneof223[] oneOf { get; set; }
    }

    public class Oneof223
    {
        public string _ref { get; set; }
    }

    public class Displayemployeelistprice1
    {
        public bool nullable { get; set; }
        public Oneof224[] oneOf { get; set; }
    }

    public class Oneof224
    {
        public string _ref { get; set; }
    }

    public class Discountamount1
    {
        public bool nullable { get; set; }
        public Oneof225[] oneOf { get; set; }
    }

    public class Oneof225
    {
        public string _ref { get; set; }
    }

    public class Taxdiscountamount1
    {
        public bool nullable { get; set; }
        public Oneof226[] oneOf { get; set; }
    }

    public class Oneof226
    {
        public string _ref { get; set; }
    }

    public class Resellerfeeamount1
    {
        public bool nullable { get; set; }
        public Oneof227[] oneOf { get; set; }
    }

    public class Oneof227
    {
        public string _ref { get; set; }
    }

    public class Taxresellerfeeamount1
    {
        public bool nullable { get; set; }
        public Oneof228[] oneOf { get; set; }
    }

    public class Oneof228
    {
        public string _ref { get; set; }
    }

    public class Discountruleid1
    {
        public string type { get; set; }
        public string format { get; set; }
        public bool nullable { get; set; }
    }

    public class Discountfactor2
    {
        public string type { get; set; }
        public string format { get; set; }
    }

    public class Resellerfeefactor2
    {
        public string type { get; set; }
        public string format { get; set; }
    }

    public class Calculationmethod2
    {
        public string _ref { get; set; }
    }

    public class Excludedcosttypes2
    {
        public string type { get; set; }
        public bool nullable { get; set; }
        public Items173 items { get; set; }
    }

    public class Items173
    {
        public string _ref { get; set; }
    }

    public class Serializedexcludedcosttypes
    {
        public string type { get; set; }
        public bool nullable { get; set; }
    }

    public class Createtransactionparameters
    {
        public string type { get; set; }
        public bool additionalProperties { get; set; }
        public string[] required { get; set; }
        public Properties162 properties { get; set; }
    }

    public class Properties162
    {
        public Productid3 ProductId { get; set; }
    }

    public class Productid3
    {
        public string type { get; set; }
        public string format { get; set; }
    }

    public class Enumerationitem
    {
        public string type { get; set; }
        public bool additionalProperties { get; set; }
        public Properties163 properties { get; set; }
    }

    public class Properties163
    {
        public Key3 Key { get; set; }
        public Value4 Value { get; set; }
    }

    public class Key3
    {
        public string type { get; set; }
        public string format { get; set; }
    }

    public class Value4
    {
        public string type { get; set; }
        public bool nullable { get; set; }
    }

    public class Unsubscribeparameters
    {
        public string type { get; set; }
        public bool additionalProperties { get; set; }
        public Properties164 properties { get; set; }
    }

    public class Properties164
    {
        public Email3 Email { get; set; }
        public Unsubscribehash1 UnsubscribeHash { get; set; }
    }

    public class Email3
    {
        public string type { get; set; }
        public bool nullable { get; set; }
    }

    public class Unsubscribehash1
    {
        public string type { get; set; }
        public bool nullable { get; set; }
    }

    public class Runtestparameters
    {
        public string type { get; set; }
        public bool additionalProperties { get; set; }
        public string[] required { get; set; }
        public Properties165 properties { get; set; }
    }

    public class Properties165
    {
        public Orgunitid23 OrgUnitId { get; set; }
        public Productid4 ProductId { get; set; }
        public Effectivedate2 EffectiveDate { get; set; }
        public Costcomponentid3 CostComponentId { get; set; }
    }

    public class Orgunitid23
    {
        public string type { get; set; }
        public string format { get; set; }
    }

    public class Productid4
    {
        public string type { get; set; }
        public string format { get; set; }
    }

    public class Effectivedate2
    {
        public string type { get; set; }
        public string format { get; set; }
        public int minLength { get; set; }
    }

    public class Costcomponentid3
    {
        public string type { get; set; }
        public bool nullable { get; set; }
    }

    public class Productspecificationtestresultmodel
    {
        public string type { get; set; }
        public bool additionalProperties { get; set; }
        public Properties166 properties { get; set; }
    }

    public class Properties166
    {
        public Matchingdiscountrules MatchingDiscountRules { get; set; }
        public Matchingproductgroups MatchingProductGroups { get; set; }
        public Productcostcomponent2 ProductCostComponent { get; set; }
    }

    public class Matchingdiscountrules
    {
        public string type { get; set; }
        public bool nullable { get; set; }
        public Items174 items { get; set; }
    }

    public class Items174
    {
        public string _ref { get; set; }
    }

    public class Matchingproductgroups
    {
        public string type { get; set; }
        public bool nullable { get; set; }
        public Items175 items { get; set; }
    }

    public class Items175
    {
        public string _ref { get; set; }
    }

    public class Productcostcomponent2
    {
        public bool nullable { get; set; }
        public Oneof229[] oneOf { get; set; }
    }

    public class Oneof229
    {
        public string _ref { get; set; }
    }

    public class Discountrulemodel
    {
        public string type { get; set; }
        public bool additionalProperties { get; set; }
        public Properties167 properties { get; set; }
    }

    public class Properties167
    {
        public Discountruleid2 DiscountRuleId { get; set; }
        public Isorgunitspecific IsOrgUnitSpecific { get; set; }
        public Tag5 Tag { get; set; }
        public Effectivefromdate2 EffectiveFromDate { get; set; }
        public Discountfactor3 DiscountFactor { get; set; }
        public Resellerfeefactor3 ResellerFeeFactor { get; set; }
        public Calculationmethod3 CalculationMethod { get; set; }
        public Excludedcosttypes3 ExcludedCostTypes { get; set; }
        public Catalog5 Catalog { get; set; }
        public Product4 Product { get; set; }
    }

    public class Discountruleid2
    {
        public string type { get; set; }
        public string format { get; set; }
    }

    public class Isorgunitspecific
    {
        public string type { get; set; }
    }

    public class Tag5
    {
        public string type { get; set; }
        public bool nullable { get; set; }
    }

    public class Effectivefromdate2
    {
        public string type { get; set; }
        public string format { get; set; }
    }

    public class Discountfactor3
    {
        public string type { get; set; }
        public string format { get; set; }
    }

    public class Resellerfeefactor3
    {
        public string type { get; set; }
        public string format { get; set; }
    }

    public class Calculationmethod3
    {
        public string _ref { get; set; }
    }

    public class Excludedcosttypes3
    {
        public string type { get; set; }
        public bool nullable { get; set; }
        public Items176 items { get; set; }
    }

    public class Items176
    {
        public string _ref { get; set; }
    }

    public class Catalog5
    {
        public bool nullable { get; set; }
        public Oneof230[] oneOf { get; set; }
    }

    public class Oneof230
    {
        public string _ref { get; set; }
    }

    public class Product4
    {
        public bool nullable { get; set; }
        public Oneof231[] oneOf { get; set; }
    }

    public class Oneof231
    {
        public string _ref { get; set; }
    }

    public class Catalogdiscountrulemodel
    {
        public string type { get; set; }
        public bool additionalProperties { get; set; }
        public Properties168 properties { get; set; }
    }

    public class Properties168
    {
        public Catalogid4 CatalogId { get; set; }
        public Name16 Name { get; set; }
    }

    public class Catalogid4
    {
        public string type { get; set; }
        public string format { get; set; }
    }

    public class Name16
    {
        public string type { get; set; }
        public bool nullable { get; set; }
    }

    public class Productdiscountrulemodel
    {
        public string type { get; set; }
        public bool additionalProperties { get; set; }
        public Properties169 properties { get; set; }
    }

    public class Properties169
    {
        public Productid5 ProductId { get; set; }
        public Title1 Title { get; set; }
    }

    public class Productid5
    {
        public string type { get; set; }
        public string format { get; set; }
    }

    public class Title1
    {
        public string type { get; set; }
        public bool nullable { get; set; }
    }

    public class Productgroupmodel
    {
        public string type { get; set; }
        public bool additionalProperties { get; set; }
        public Properties170 properties { get; set; }
    }

    public class Properties170
    {
        public Functiongroup4 FunctionGroup { get; set; }
        public Isapprovalrequired2 IsApprovalRequired { get; set; }
        public Taxationindication4 TaxationIndication { get; set; }
    }

    public class Functiongroup4
    {
        public string type { get; set; }
        public bool nullable { get; set; }
    }

    public class Isapprovalrequired2
    {
        public string type { get; set; }
    }

    public class Taxationindication4
    {
        public bool nullable { get; set; }
        public Oneof232[] oneOf { get; set; }
    }

    public class Oneof232
    {
        public string _ref { get; set; }
    }

    public class Generateparameters
    {
        public string type { get; set; }
        public bool additionalProperties { get; set; }
    }

    public class Securityschemes
    {
        public Oauth2 oauth2 { get; set; }
    }

    public class Oauth2
    {
        public string type { get; set; }
        public string description { get; set; }
        public Flows flows { get; set; }
    }

    public class Flows
    {
        public Implicit _implicit { get; set; }
    }

    public class Implicit
    {
        public string authorizationUrl { get; set; }
        public Scopes scopes { get; set; }
    }

    public class Scopes
    {
        public string cc_api { get; set; }
    }

    public class Server
    {
        public string url { get; set; }
    }

    public class Security
    {
        public string[] oauth2 { get; set; }
    }

}
