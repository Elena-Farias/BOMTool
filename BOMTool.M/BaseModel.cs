using System.ComponentModel.DataAnnotations;
using System; 
using BOMTool.M;

namespace BOMTool.M
{
    public class BaseModel
    {
        public System.DateTime CreatedDate {get; set;} 

        [MaxLength (9)]
       public string CreatedAt  {get; set;}


       public System.DateTime UpdatedDate  {get; set;} 


       [MaxLength (9)]
       public string UpdatedAt {get; set;} 
    }
}