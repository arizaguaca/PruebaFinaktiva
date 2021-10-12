using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Infrastructure.Entities
{
    [Table("Tb_User", Schema = "dbo")]
    public class UsersModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]        
        public int idUser { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public int idRol { get; set; }

 
 
    }
}
