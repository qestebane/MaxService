using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace MaxService.Models.Mantenimiento
{
    public class Login
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column ("Id")]
        public int Id {get;set;}
        [Column ("Email")]
        public String Email {get; set;}
        [Column ("Password")]
        public String Password {get; set;}
    }
}