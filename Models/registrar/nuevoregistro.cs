using System.ComponentModel.DataAnnotations.Schema;

namespace MaxService.Models.registrar
{

  [ Table ("nuevoregistro")]
    public class nuevoregistro
    {
      [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        [Column("Id")] 
        public int Id { get; set; }

        [Column("nombre")]
        public int nombre { get; set; }

        [Column("apellido")]
        public char apellido { get; set; }

       [Column("Correo")]
        public string correo { get; set; }  


       [Column("ruc") ]
        public  char  ruc  { get; set; }  
        [Column("dni") ]
        public  char  dni  { get; set; }  
  

    }
}