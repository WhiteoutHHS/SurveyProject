using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurveyProject.Core.DTOs
{
    public class RoomDTO
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public List<SurveyDTO>? SurveysInRoom { get; set; }
    }
}
