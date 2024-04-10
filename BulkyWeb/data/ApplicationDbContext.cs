using Microsoft.EntityFrameworkCore;

namespace BulkyWeb.data
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options): base (options)
        {
            
        }
    }
}
