using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SDKWebPortalWebAPI.Models
{
    public class Output
    {
        public FamilyMembers FamilyMembers { get; set; }
        public House House { get; set; }
        public HouseAnswers HouseAnswers { get; set; }
        public HouseQuestions HouseQuestions { get; set; }
        public ObservationAnswers ObservationAnswers { get; set; }
        public ObservationQuestions ObservationQuestions { get; set; }
        public PersonelAnswers PersonelAnswers { get; set; }
        public PersonelQuestions PersonelQuestions { get; set; }
    }
    public class OutputList
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
