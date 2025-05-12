using SurveyProject.NewCore.Enums;


namespace SurveyProject.NewCore.DTOs
{
	public class ParticipantDTO
	{
		public int Id { get; set; }
		public UserDTO User { get; set; }
		public RoomDTO Room { get; set; }
		public ParticipantType Type { get; set; }
	}
}
