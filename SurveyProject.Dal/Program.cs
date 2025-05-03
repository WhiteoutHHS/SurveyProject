using SurveyProject.DAL;
using Microsoft.EntityFrameworkCore;

namespace SurveyProject.Dal
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Context context = new Context();

			context.Database.EnsureCreated();
		}
	}
}
