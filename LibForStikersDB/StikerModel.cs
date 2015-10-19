namespace LibForStikersDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("StikerModel")]
    public partial class StikerModel
    {
        public int Id { get; set; }
        [Required]
        [StringLength(20)]
        public string Type { get; set; }

        [StringLength(150)]
        public string Text { get; set; }
    }
}
