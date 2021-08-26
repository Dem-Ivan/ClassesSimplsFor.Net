using SampleForHttp.Models;
using SampleForHttp.Services;
using System;
using System.Threading.Tasks;

namespace SampleForHttp
{
    class Program
    {
        static async Task Main(string[] args)
        {
            string token = "Bearer eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJ1c2VyIjoi0JHQvtCz0LTQsNC9IiwidGVuYW50IjoiNzI5IiwibmJmIjoxNjI5OTk0MjUwLCJleHAiOjE2MzAwODA2NTAsImlzcyI6IlRlc3QtQmFja2VuZC0xIiwiYXVkIjoiQmFza2V0QmFsbENsdWJTYW1wbGUifQ.Lzsq4ax6wMHXR3Sy_cTaX7uOYByC8X5QkQZmjW7-NDY";

            TeamService teamService = new TeamService(token);

            Team team = new Team()
            {
                Name = "Arsenal",
                FoundationYear = 2009,
                Division = "adc",
                Conference = "A",
                ImageUrl = "myImage"                
            };

            await teamService.Add(team);

            await teamService.GetTeams();
        }
    }
}
