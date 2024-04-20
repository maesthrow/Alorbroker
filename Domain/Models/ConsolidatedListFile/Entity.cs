namespace Domain.Models.ConsolidatedListFile
{

    public class Entity : BaseModel
    {
        #region Properties

        public required string DataId { get; set; }

        public string VersionNum { get; set; }

        public string Name { get; set; }

        public string UnListType { get; set; }

        public string ReferenceNumber { get; set; }

        public string ListedOn { get; set; }

        public string? NameOriginalScript { get; set; }

        public string Comments { get; set; }

        public string SortKey { get; set; }

        public string SortKeyLastMod { get; set; }

        public List<EntityAlias>? Aliases { get; set; }

        public List<EntityAddress>? Addresses { get; set; }

        #endregion
    }

}