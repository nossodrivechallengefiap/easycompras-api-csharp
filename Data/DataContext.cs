using System;
using Microsoft.EntityFrameworkCore;

namespace WebApplication1.Data
{
    public class DataContext : DbContext
	{
        public DataContext(DbContextOptions<DataContext> options)
            : base(options)
        {

        }

        public DbSet<Endereco> Enderecos { get; set; }
	}
}

