using Consultorio.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Linq;

namespace Consultorio.Data
{
    public static class SeedDatabase
    {
        public static void Initialize(IHost app)
        {
            using (var scope = app.Services.CreateScope())
            {
                var serviceProvider = scope.ServiceProvider;
                var context = serviceProvider.GetRequiredService<ConsultorioContext>();
                context.Database.Migrate(); // update-database

                if (!context.Paciente.Any())
                {
                    context.Paciente.Add(new Paciente { Nome = "Italo", Nascimento = new DateTime(1980, 10, 08), Descricao = "Paciente 1 - Italo" });
                    context.Paciente.Add(new Paciente { Nome = "Eduardo", Nascimento = new DateTime(1995, 01, 25), Descricao = "Paciente 2 - Eduardo" });
                    context.Paciente.Add(new Paciente { Nome = "Janio", Nascimento = new DateTime(2000, 7, 5), Descricao = "Paciente 3 - Janio" });
                    context.Paciente.Add(new Paciente { Nome = "Filipe", Nascimento = new DateTime(2000, 7, 5), Descricao = "Paciente 4 - Filipe" });
                    context.Paciente.Add(new Paciente { Nome = "Gabriel", Nascimento = new DateTime(2000, 7, 5), Descricao = "Paciente 5 - Gabriel" });
                    context.Paciente.Add(new Paciente { Nome = "Chubi Chubi", Nascimento = new DateTime(1914, 9, 12), Descricao = "Somebody crazy" });
                    context.Paciente.Add(new Paciente { Nome = "Aderbaldo", Nascimento = new DateTime(1871, 12, 12), Descricao = "Somebody crazy" });
                    context.Paciente.Add(new Paciente { Nome = "Clorosvaldo de Sódio", Nascimento = new DateTime(2035, 9, 10), Descricao = "Somebody crazy" });
                    context.Paciente.Add(new Paciente { Nome = "Magneto", Nascimento = new DateTime(1922, 1, 9), Descricao = "Somebody crazy" });
                    context.Paciente.Add(new Paciente { Nome = "Ant Man", Nascimento = new DateTime(2021, 2, 8), Descricao = "Somebody crazy" });
                    context.Paciente.Add(new Paciente { Nome = "Doctor Strange", Nascimento = new DateTime(2784, 3, 7), Descricao = "Somebody crazy" });
                    context.Paciente.Add(new Paciente { Nome = "Scarlett", Nascimento = new DateTime(2005, 4, 6), Descricao = "Somebody crazy" });
                    context.Paciente.Add(new Paciente { Nome = "Marvel Captain", Nascimento = new DateTime(1945, 5, 5), Descricao = "Somebody crazy" });
                    context.Paciente.Add(new Paciente { Nome = "Ovne", Nascimento = new DateTime(1949, 6, 4), Descricao = "Somebody crazy" });
                    context.Paciente.Add(new Paciente { Nome = "Tony Stark", Nascimento = new DateTime(2020, 7, 3), Descricao = "Somebody crazy" });
                    context.Paciente.Add(new Paciente { Nome = "Tea Queen", Nascimento = new DateTime(2017, 8, 2), Descricao = "Somebody crazy" });
                    context.Paciente.Add(new Paciente { Nome = "Kara", Nascimento = new DateTime(2018, 9, 1), Descricao = "Somebody crazy" });
                    context.Paciente.Add(new Paciente { Nome = "Clark Kent", Nascimento = new DateTime(1978, 10, 11), Descricao = "Somebody crazy" });
                    context.Paciente.Add(new Paciente { Nome = "Van a Diesel", Nascimento = new DateTime(1800, 11, 10), Descricao = "Somebody crazy" });
                    context.Paciente.Add(new Paciente { Nome = "Mike", Nascimento = new DateTime(2022, 12, 9), Descricao = "Somebody crazy" });
                    context.Paciente.Add(new Paciente { Nome = "Harvey Specter", Nascimento = new DateTime(2022, 1, 8), Descricao = "Somebody crazy" });
                }
                context.SaveChanges();
            }

                
        }
    }
}
