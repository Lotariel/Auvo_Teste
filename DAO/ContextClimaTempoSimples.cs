namespace AUvo_Teste.DAO
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class ContextClimaTempoSimples : DbContext
    {
        public ContextClimaTempoSimples()
            : base("name=ContextClimaTempoSimples")
        {
        }

        public virtual DbSet<Cidade> Cidade { get; set; }
        public virtual DbSet<Estado> Estado { get; set; }
        public virtual DbSet<PrevisaoClima> PrevisaoClima { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PrevisaoClima>()
                .Property(e => e.TemperaturaMinima)
                .HasPrecision(3, 1);

            modelBuilder.Entity<PrevisaoClima>()
                .Property(e => e.TemperaturaMaxima)
                .HasPrecision(3, 1);
        }
    }
}
