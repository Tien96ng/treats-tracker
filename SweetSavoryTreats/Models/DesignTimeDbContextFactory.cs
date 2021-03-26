using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace SweetSavoryTreats.Models
{
  public class SweetSavoryTreatsContextFactory : IDesignTimeDbContextFactory<SweetSavoryTreatsContext>
  {

    SweetSavoryTreatsContext IDesignTimeDbContextFactory<SweetSavoryTreatsContext>.CreateDbContext(string[] args)
    {
      IConfigurationRoot configuration = new ConfigurationBuilder()
          .SetBasePath(Directory.GetCurrentDirectory())
          .AddJsonFile("appsettings.json")
          .Build();

      var builder = new DbContextOptionsBuilder<SweetSavoryTreatsContext>();

      builder.UseMySql(configuration["ConnectionStrings:DefaultConnection"], ServerVersion.AutoDetect(configuration["ConnectionStrings:DefaultConnection"]));

      return new SweetSavoryTreatsContext(builder.Options);
    }
  }
}