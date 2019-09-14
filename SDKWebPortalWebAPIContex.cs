using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SDKWebPortalWebAPI.Models
{
    public class SDKWebPortalWebAPIContex : DbContext
    {
        public SDKWebPortalWebAPIContex(DbContextOptions<SDKWebPortalWebAPIContex> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<FamilyMembers>()
                .HasAlternateKey(c => c.TC)
                .HasName("AlternateKey_TC");
        }

        public DbSet<FamilyMembers> FamilyMembers { get; set; }
        public DbSet<House> House { get; set; }
        public DbSet<HouseAnswers> HouseAnswers { get; set; }
        public DbSet<HouseQuestions> HouseQuestions { get; set; }
        public DbSet<ObservationAnswers> ObservationAnswers { get; set; }
        public DbSet<ObservationQuestions> ObservationQuestions { get; set; }
        public DbSet<PersonelAnswers> PersonelAnswers { get; set; }
        public DbSet<PersonelQuestions> PersonelQuestions { get; set; }
        public object Input { get; internal set; }
    }
}
