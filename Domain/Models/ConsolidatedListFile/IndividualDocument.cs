namespace Domain.Models.ConsolidatedListFile
{

    public class IndividualDocument : BaseModel
    {
        #region Properties

        public string? TypeOfDocument { get; set; }

        public string? TypeOfDocument2 { get; set; }

        public string? Number { get; set; }

        public string? IssuingCountry { get; set; }

        public string? DateOfIssue { get; set; }

        public string? CityOfIssue { get; set; }

        public string? Note { get; set; }

        public string? CountryOfIssue { get; set; }

        #endregion
    }

}