using Llp.Language.Models;
using Microsoft.EntityFrameworkCore;

namespace Llp.Language.Repositories
{
    public class LlpDbContext : DbContext
    {
        public LlpDbContext(DbContextOptions<LlpDbContext> options) : base(options)
        {
        }

        public DbSet<Models.User> Users { get; set; }
        public DbSet<Models.Language> Languages { get; set; }
        public DbSet<Result> Results { get; set; }
        public DbSet<Assessment> Assessments { get; set; }
        public DbSet<MediaType> mediaTypes { get; set; }
        public DbSet<LanguageSection> LanguageSections { get; set; }
    }
}
