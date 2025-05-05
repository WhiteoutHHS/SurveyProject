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
<<<<<<< HEAD
        public enum ParticipantType { get; set; }
=======
        public int ParticipantType { get; set; }
        public UserDTO User { get; set; }
        public int ParticipantId { get; set; }
>>>>>>> 2efa0abd6f8481d4e9f472e46b731cb1f3354067
    }
}
