using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SDKWebPortalWebAPI.Models
{
    public class PersonelAnswers
    {
        [ForeignKey("HouseId")]
        public int HouseId { get; set; }
        public int Id { get; set; }
        public int QuestionId { get; set; }
        public int FamilyMemberId { get; set; }
        public string Answers { get; set; }
    }
}
