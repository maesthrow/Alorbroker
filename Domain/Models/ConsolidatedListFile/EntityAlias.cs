namespace Domain.Models.ConsolidatedListFile
{

    public class EntityAlias : BaseModel
    {
        #region Properties

        public string Quality { get; set; }

        public string AliasName { get; set; }

        public string? Note { get; set; }

        #endregion
    }

}