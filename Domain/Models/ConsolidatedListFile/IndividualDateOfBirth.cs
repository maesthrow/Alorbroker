using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Models.ConsolidatedListFile
{

    public class IndividualDateOfBirth : BaseModel
    {
        #region Properties

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public string TypeOfDate { get; set; }

        public string? Date { get; set; }

        public string? FromYear { get; set; }

        public string? ToYear { get; set; }

        public string? Note { get; set; }

        public string? Year { get; set; }

        #endregion
    }

}