using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurveyProject.Core.DTOs
{
    public class QuestionDTO
    {
        public int Id { get; set; }
        public string? Text { get; set; }
        public int AnswerType { get; set; }
        public SurveyDTO Survey { get; set; }
    }
}

//public List<AnswerDTO>? Answers { get; set; }//