using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurveyProject.Core.DTOs
{
    public class ParticipantDTO
    {
<<<<<<< HEAD
        public UserDTO Creator { get; set; }
        public RoomDTO Room { get; set; }
        public int ParticipantType { get; set; }
=======
        public RoomDTO Room {  get; set; }
        public UserDTO User { get; set; }
        public int ParticipantId { get; set; }
>>>>>>> 6d4466f (edit DTOs)
    }
}
