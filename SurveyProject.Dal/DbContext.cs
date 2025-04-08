//using Microsoft.EntityFrameworkCore;
//using SurveyProject.Core.DTOs;


//namespace SurveyProject.DAL
//{
//    public class DbContext : DbContext
//    {
//        public DbSet<UserDTO> Users { get; set; }

//        public DbSet<ShelterDto> Shelters { get; set; }

//        public DbSet<AnimalDto> Animals { get; set; }

//        public DbSet<TagDto> Tags { get; set; }

//        public DbSet<ReviewDto> Reviews { get; set; }

//        public DbSet<DonationDto> Donations { get; set; }

//        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//        {
//            string connectionString = Environment.GetEnvironmentVariable("HOMELESSANIMALSSHELTERIIN_ACCESS")!;
//            optionsBuilder.UseNpgsql(connectionString);
//        }
//    }
//}