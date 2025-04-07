using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurveyProject.Core.DTOs
{
    public class SurveyDTO
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public bool IsPublished { get; set; }
        public UserDTO Creator { get; set; }
        public RoomDTO? Room { get; set; }
        public List<QuestionDTO>? Questions { get; set; }
    }
}
