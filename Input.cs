using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SDKWebPortalWebAPI.Models
{
    public class Input
    {
        public List<FamilyMembers> FamilyMembers { get; set; }
        public House House { get; set; }
        public List<HouseAnswers> HouseAnswers { get; set; }
        public List<HouseQuestions> HouseQuestions { get; set; }
        public List<ObservationAnswers> ObservationAnswers { get; set; }
        public List<ObservationQuestions> ObservationQuestions { get; set; }
        public List<PersonelAnswers> PersonelAnswers { get; set; }
        public List<PersonelQuestions> PersonelQuestions { get; set; }
    }
}
