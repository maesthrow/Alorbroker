using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Models
{

    public abstract class BaseModel { }

    public class ConsolidatedList : BaseModel
    {
        #region Properties

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public required string DateGenerated { get; set; }

        public List<Individual> Individuals { get; set; }

        public List<Entity> Entities { get; set; }

        #endregion
    }

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

    public class IndividualAlias : BaseModel
    {
        #region Properties

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public string Quality { get; set; }

        public string AliasName { get; set; }

        public string? Note { get; set; }

        public string? CityOfBirth { get; set; }

        public string? CountryOfBirth { get; set; }

        public string? DateOfBirth { get; set; }

        #endregion
    }

    public class IndividualAddress : BaseModel
    {
        #region Properties

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public string? Street { get; set; }

        public string? City { get; set; }

        public string? StateProvince { get; set; }

        public string? Country { get; set; }

        public string? ZipCode { get; set; }

        public string? Note { get; set; }

        #endregion
    }

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

    public class Entity : BaseModel
    {
        #region Properties

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

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

    public class EntityAlias : BaseModel
    {
        #region Properties

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public string Quality { get; set; }

        public string AliasName { get; set; }

        public string? Note { get; set; }

        #endregion
    }

    public class EntityAddress : BaseModel
    {
        #region Properties

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public string? Street { get; set; }

        public string? City { get; set; }

        public string? ZipCode { get; set; }

        public string? StateProvince { get; set; }

        public string? Country { get; set; }

        public string? Note { get; set; }

        #endregion
    }

}