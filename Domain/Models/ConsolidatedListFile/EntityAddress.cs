namespace Domain.Models.ConsolidatedListFile
{

    public class EntityAddress : BaseModel
    {
        #region Properties

        public string? Street { get; set; }

        public string? City { get; set; }

        public string? ZipCode { get; set; }

        public string? StateProvince { get; set; }

        public string? Country { get; set; }

        public string? Note { get; set; }

        #endregion
    }

}