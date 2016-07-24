using Code.First.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Code.First.Data
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new CodeFirstContext(
                serviceProvider.GetRequiredService<DbContextOptions<CodeFirstContext>>()))
            {
                if (context.Genders.Any())
                {
                    return;
                }

                context.Genders.AddRange(
                     new Gender
                     {
                         GenderName = "Female"
                     },

                     new Gender
                     {
                         GenderName = "Male"
                     }
                );
                context.SaveChanges();
            }
        }
    }
}
