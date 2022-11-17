using Microsoft.EntityFrameworkCore;
using Lanchao.Model;

namespace Lanchao.Data{
    public class DataContext: DbContext{
        public DataContext(DbContextOptions<DataContext> options): base(options){

        }

        public DbSet<Categoria> Categorias { get; set; } 
        
    }
}