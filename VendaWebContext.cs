namespace EntityFrameworkDatabaseCode
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using System.Diagnostics;

    public partial class VendaWebContext : DbContext
    {
        public VendaWebContext()
            : base("name=VendaWebContext")
        {
            Database.Log = s => Debug.WriteLine(s);
        }

        public virtual DbSet<Cliente> Cliente { get; set; }
        public virtual DbSet<Pedido> Pedido { get; set; }
        public virtual DbSet<PedidoProduto> PedidoProduto { get; set; }
        public virtual DbSet<Produto> Produto { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cliente>()
                .Property(e => e.Nome)
                .IsFixedLength();

            modelBuilder.Entity<Cliente>()
                .Property(e => e.Telefone)
                .IsFixedLength();

            modelBuilder.Entity<Cliente>()
                .Property(e => e.Email)
                .IsFixedLength();

            modelBuilder.Entity<Produto>()
                .Property(e => e.Nome)
                .IsFixedLength();
        }
    }
}
