﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Models.ConsolidatedListFile
{

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

}