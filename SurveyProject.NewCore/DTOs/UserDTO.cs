using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurveyProject.NewCore.DTOs
{
    public class UserDTO
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public bool? male {  get; set; } 
        public DateTime? Birthday { get; set; }
        public List<SurveyDTO>? Surveys { get; set; }
        public List<RoomDTO>? Rooms { get; set; }
    }
}
