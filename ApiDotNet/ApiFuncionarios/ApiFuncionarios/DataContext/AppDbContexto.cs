using ApiFuncionarios.Models;
using Microsoft.EntityFrameworkCore;

namespace ApiFuncionarios.DataContext
{
    public class AppDbContexto : DbContext
    {
        public AppDbContexto(DbContextOptions<AppDbContexto>options) : base(options)
        {
            
        }

        public DbSet<FuncionarioModel> Funcionarios { get; set; }
    }
}
