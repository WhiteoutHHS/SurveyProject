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
<<<<<<< HEAD
        public string? Text { get; set; }
        public enum QuestionType { get; set; }
=======
        public int AnswerType { get; set; }
>>>>>>> 6d4466f (edit DTOs)
        public SurveyDTO Survey { get; set; }
        public List<AnswerDTO>? Answers { get; set; }
    }
}

