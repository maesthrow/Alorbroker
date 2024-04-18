using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Models.ConsolidatedListFile
{

    public class Individual : BaseModel
    {
        #region Properties

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public required string DataId { get; set; }

        public string FirstName { get; set; }

        public string? LastName { get; set; }

        public string? ThirdName { get; set; }

        public string? FourthName { get; set; }

        public string UnListType { get; set; }

        public string ReferenceNumber { get; set; }

        public string ListedOn { get; set; }

        public string? Gender { get; set; }

        public string? NameOriginalScript { get; set; }

        public string? Comments { get; set; }

        public string SortKey { get; set; }

        public string SortKeyLastMod { get; set; }

        public List<IndividualAlias>? Aliases { get; set; }

        public List<IndividualAddress>? Addresses { get; set; }

        public List<IndividualDateOfBirth> DatesOfBirth { get; set; }

        public List<IndividualPlaceOfBirth>? PlacesOfBirth { get; set; }

        public List<IndividualDocument>? Documents { get; set; }

        #endregion
    }

}