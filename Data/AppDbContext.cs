using Microsoft.EntityFrameworkCore;
using System.Data.OracleClient;  
using Nama.Models;

namespace Nama.Data
{
    /**
     * Application Database Context
     */
    public class AppDbContext : DbContext
    {
        /**
         * Data Sets
         */
        public DbSet<User> Users { get; set; }
        public DbSet<Reporte> Reportes { get; set; }
        public DbSet<Avance> Avances { get; set; }
        
        /**
         * AppDbContext constructor.
         * @param options Context options
         */
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) {}
        
    }
}
