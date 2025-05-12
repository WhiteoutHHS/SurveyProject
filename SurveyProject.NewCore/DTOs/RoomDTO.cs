using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurveyProject.NewCore.DTOs
{
    public class RoomDTO
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Code { get; set; }
        public List<SurveyDTO>? Surveys { get; set; }
        public List<UserDTO>? Users { get; set; }
    }
}
