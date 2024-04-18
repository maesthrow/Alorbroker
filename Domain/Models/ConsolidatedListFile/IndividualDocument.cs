using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Models.ConsolidatedListFile
{

    public class IndividualDocument : BaseModel
    {
        #region Properties

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

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