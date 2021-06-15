using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MaxService.Models.Cliente
{

  [ Table ("T_Registro")]
    public class Registro
    {
      [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
      [Column("RegistroId")] 
      public int RegistroId { get; set; }
    
      [Required]
      [Column("Nombre")]
      public string Nombre { get; set; }

      [Required]
      [Column("Apellido")]
      public string Apellido { get; set; }

      [Required]
      [Column("Correo")]
      public string Correo { get; set; }  
      
      [Required]
      [Column("Documento") ]
      public int Documento { get; set; }  

      [Required]
      [Column("FechaActual")]
      public string FechaActual { get; set; }

      [Required]
      [Column("FechaEntrega")]
      public string FechaEntrega { get; set; }    
  
      [Required]
      [Column("DireccionEntrega")]
      public string DireccionEntrega { get; set; }

      [Required]
      [Column("ModoPago")]
      public string ModoPago { get; set; }

      [Required]
      [Column("PlazoPago")]
      public string PlazoPago { get; set; }

      [Required]
      [Column("Adjunto")]
      public string Adjunto { get; set; }
    }
}