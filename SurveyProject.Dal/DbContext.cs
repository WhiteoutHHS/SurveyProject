using Microsoft.EntityFrameworkCore;
using SurveyProject.Core.DTOs;


namespace SurveyProject.DAL
{
    public class Context:DbContext
    {
        public DbSet<UserDTO> Users { get; set; }

        public DbSet<SurveyDTO> Surveys { get; set; }

        public DbSet<RoomDTO> Rooms { get; set; }

        public DbSet<QuestionDTO> Questions { get; set; }

        public DbSet<ParticipantDTO> Participants { get; set; }

        public DbSet<AnswerDTO> Answers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connectionString = Environment.GetEnvironmentVariable("SurveyProject")!;
            optionsBuilder.UseNpgsql(connectionString);
        }
    }
}