namespace LibForStikersDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("StikerInfo")]
    public partial class StikerInfo
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string StikerType { get; set; }

        [Required]
        [StringLength(150)]
        public string Text { get; set; }
    }
}
