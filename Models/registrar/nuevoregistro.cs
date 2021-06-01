using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MaxService.Models.registrar
{

  [ Table ("nuevoregistro")]
    public class nuevoregistro
    {
      [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        [Column("Id")] 
        public int Id { get; set; }


        [Required]
        [Column("nombre")]
        public string nombre { get; set; }

        [Column("apellido")]
        public string apellido { get; set; }

       [Column("Correo")]
        public string correo { get; set; }  

       [Required]
       [Column("ruc") ]
        public  char  ruc  { get; set; }  
        [Column("dni") ]
        public  char  dni  { get; set; }  
  

    }
}