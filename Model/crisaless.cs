namespace Model
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class crisaless : DbContext
    {
        public crisaless()
            : base("name=crisaless")
        {
        }

        public virtual DbSet<FACTURA> FACTURA { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<FACTURA>()
                .Property(e => e.N_FACTURA)
                .IsFixedLength();

            modelBuilder.Entity<FACTURA>()
                .Property(e => e.PROVEEDOR)
                .IsFixedLength();
        }
    }
}
