using System.ComponentModel.DataAnnotations;
using BOMTool.M;

namespace BOMTool.M
{
    public class Users : BaseModel
    {
        [Key]
        [Required]
        public int Id { get; set;}

        [Required]
        public int SSO { get; set;}
        
        [Required]
        [MaxLength (350)]
        public string UserName {get; set;}

        [Required]
        public bool Enabled {get; set;}
    }
}