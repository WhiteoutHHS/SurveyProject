using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurveyProject.Core
{
    public class QuestionDTO
    {
        public string Text { get; set; }
        public int Id { get; set; }
        public int AnswerType { get; set; }
    }
}
