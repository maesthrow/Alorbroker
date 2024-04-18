using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Models.ConsolidatedListFile
{

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

}