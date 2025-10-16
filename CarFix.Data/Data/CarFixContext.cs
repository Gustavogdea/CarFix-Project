using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarFix.Data.Data;

public class CarFixContext : DbContext
{
    private static readonly string _catalog = "CarFixDb";

    public string connectionString = $"Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog={_catalog};Integrated Security=True;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(connectionString, b => b.MigrationsAssembly("CarFix.Data"));
    }
}
