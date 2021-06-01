using System.ComponentModel.DataAnnotations.Schema;

namespace MaxService_1.Models
{
    [Table("T_MarcaLlanta")]
    public class MarcaLlanta
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        [Column("MarcaLlantaId")] //PK
        public int MarcaLlantaId { get; set; }

        [Column("NombreMarca")]
        public string NombreMarca { get; set; }
    }
}