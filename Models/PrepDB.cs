using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using webApp.Data;

namespace webApp.Models
{


    public static class PrepDB
    {

        public static void PrepPopulation(IApplicationBuilder app)
        {

            using (var serviceScope = app.ApplicationServices.CreateScope())
            {
                SeedData(serviceScope.ServiceProvider.GetService<webAppContext>());

            }     
             static void SeedData (webAppContext context)
            {
                System.Console.Write("Appling Migrations ...");

                context.Database.Migrate();
                if (!context.Movie.Any())
                {
                    System.Console.Write("Adding Data ...");
                    context.Movie.AddRange(
                        new Movie() { Title = "Piotrus Pan i Stu Rozbójnikow", Price = 111, Genre = "Action"},
                        new Movie() { Title = "Tommy Jerry i Komnata Tajemnic", Price = 50, Genre = "Kids" },
                        new Movie() { Title = "Ogniem i bejsbolem", Price = 60, Genre = "History" });
                    context.SaveChanges();
                }
                else
                {
                    System.Console.Write("Already have data ....");
                }
            }
        }

    }


}
