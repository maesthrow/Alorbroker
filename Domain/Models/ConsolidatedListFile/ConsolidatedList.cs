using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Models.ConsolidatedListFile
{

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

}