using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SDKWebPortalWebAPI.Models
{
    public class FamilyMembers
    {
        [ForeignKey("HouseId")]
        public int HouseId { get; set; }
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        public int TC { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Surname { get; set; }        
    }
}
