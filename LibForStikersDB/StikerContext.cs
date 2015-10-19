namespace LibForStikersDB
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class StikerContext : DbContext
    {
        public StikerContext()
            : base("name=StikerContext1")
        {
        }

        public virtual DbSet<StikerModel> StikerModels { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
