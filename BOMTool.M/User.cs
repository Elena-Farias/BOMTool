using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace BOMTool.M
{
    public class User 
    {
        public Guid Id { get; set; }
        public string Sso { get; set; }
        public string FullName { get; set; }
    }
}
