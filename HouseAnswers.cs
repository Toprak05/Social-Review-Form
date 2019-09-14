using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Threading.Tasks;

namespace SDKWebPortalWebAPI.Models
{
    public class HouseAnswers
    {
        [ForeignKey("HouseId")]
        public int HouseId { get; set; }
        public int Id { get; set; }
        public int QuestionId { get; set; }
        public string Answers { get; set; }
    }
}
