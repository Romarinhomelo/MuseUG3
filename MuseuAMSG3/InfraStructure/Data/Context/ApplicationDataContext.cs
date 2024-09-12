using Microsoft.EntityFrameworkCore;
using MuseuAMSG3.Models;

namespace MuseuAMSG3.InfraStructure.Data.Context
{ 




        public class ApplicationDataContext : DbContext
{
    public ApplicationDataContext(DbContextOptions<ApplicationDataContext> options) : base(options)
    {

    }
    public DbSet<Cliente> Cliente { get; set; }
}
}

