using Microsoft.EntityFrameworkCore;

namespace SolutionName.EntityFrameworkLayer
{
    public partial class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(string cs) : this(GetOptions(cs))
        {
        }

        private static DbContextOptions<ApplicationDbContext> GetOptions(string cs)
        {
            var op = new DbContextOptionsBuilder<ApplicationDbContext>();
            op.UseSqlServer(cs);
            return op.Options;
        }
    }
}
