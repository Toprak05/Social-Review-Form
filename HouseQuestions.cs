using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SDKWebPortalWebAPI.Models
{
    public class HouseQuestions
    {
        [ForeignKey("HouseId")]
        public int HouseId { get; set; }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Questions { get; set; }

        public virtual House House { get; set; }
    }
}
