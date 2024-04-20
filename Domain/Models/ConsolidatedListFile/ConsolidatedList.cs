namespace Domain.Models.ConsolidatedListFile
{

    public class ConsolidatedList : BaseModel
    {
        #region Properties

        public required string DateGenerated { get; set; }

        public List<Individual> Individuals { get; set; }

        public List<Entity> Entities { get; set; }

        #endregion
    }

}