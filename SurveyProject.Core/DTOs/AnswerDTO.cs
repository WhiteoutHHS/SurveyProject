using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurveyProject.Core.DTOs
{
    public class AnswerDTO
    {
        public int Id { get; set; }
        public SurveyDTO Survey { get; set; }
    }
}
