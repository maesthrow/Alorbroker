using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Models.ConsolidatedListFile
{

    public class IndividualPlaceOfBirth : BaseModel
    {
        #region Properties

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public string? Street { get; set; }

        public string? City { get; set; }

        public string? StateProvince { get; set; }

        public string? Country { get; set; }

        public string? Note { get; set; }

        #endregion
    }

}