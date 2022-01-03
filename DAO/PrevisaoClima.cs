namespace AUvo_Teste.DAO
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PrevisaoClima")]
    public partial class PrevisaoClima
    {
        [Key]
        [Column(Order = 0)]
        public int Id { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CidadeId { get; set; }

        [Key]
        [Column(Order = 2, TypeName = "date")]
        public DateTime DataPrevisao { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(15)]
        public string Clima { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? TemperaturaMinima { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? TemperaturaMaxima { get; set; }
    }
}
