using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurveyProject.Core.DTOs
{
    public class UserDTO
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string? Gender {  get; set; } 
        public string? Birthday { get; set; }
        public List<SurveyDTO>? Surveys { get; set; }
    }
}
