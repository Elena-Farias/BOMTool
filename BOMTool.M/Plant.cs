using System.ComponentModel.DataAnnotations;
using BOMTool.M;

namespace BOMTool.M
{
        public class Plant : BaseModel
        {
            [Key]
            [Required]
            public int Id {get; set;}

            [Required]
            [MaxLength (100)]
            public string Name {get; set;}

            [Required]
            public int OracleId {get; set;}

            [Required]
            public bool Enabled {get; set; }

            //Foreign Key Users table
            public Users Users {get; set; }

        }
}