using Microsoft.EntityFrameworkCore;
using SurveyProject.NewCore.DTOs;


namespace SurveyProject.NewDal
{
    public class Context : DbContext
    {
        public DbSet<UserDTO> Users { get; set; }

        public DbSet<AnswerDTO> Ansver { get; set; }

        public DbSet<ParticipantDTO> Participant { get; set; }

        public DbSet<SurveyDTO> Survey { get; set; }

        public DbSet<RoomDTO> Room { get; set; }

        public DbSet<QuestionDTO> Question { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connectionString = Environment.GetEnvironmentVariable("HOMELESSANIMALSSHELTERIIN_ACCESS")!;
            optionsBuilder.UseNpgsql(connectionString);
        }
    }
}