using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurveyProject.Core.DTOs
{
    public class ParticipantDTO
    {
        public UserDTO Creator { get; set; }
        public RoomDTO Room { get; set; }
        public int ParticipantType { get; set; }
    }
}
