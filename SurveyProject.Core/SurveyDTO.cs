using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurveyProject.Core
{
    public class SurveyDTO
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public List<QuestionDTO> Questions { get; set; }
    }
}
