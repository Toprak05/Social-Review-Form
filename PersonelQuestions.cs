using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SDKWebPortalWebAPI.Models
{
    public class PersonelQuestions
    {
        [ForeignKey("HouseId")]
        public int HouseId { get; set; }
        public int Id { get; set; }
        public string Questions { get; set; }
    }
}
