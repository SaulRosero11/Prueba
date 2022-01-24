using System;
using Microsoft.EntityFrameworkCore;
using Modelo;

namespace ModelosDB 
{
    public class DBconexion : DbContext
    {
        public DbSet<Address> Addresses { get; set; }
        public DbSet<payment> Payments { get; set; }
        public DbSet<staff> Staffs { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Relacion de 1-m entre staff y address
            modelBuilder.Entity<staff>()
                .HasOne(staff => staff.address)
                .WithMany(address => address.Staffs)
                .HasForeignKey(staff => staff.addressId);

            // Relacion de 1 - m entre staff y payment
            modelBuilder.Entity<payment>()
                .HasOne(payment => payment.Staff)
                .WithMany(staff => staff.Payments)
                .HasForeignKey(payment => payment.staffId);
        }

        //Conexion a la base de datos
        override protected void OnConfiguring(DbContextOptionsBuilder options)
        {
            String conSQLServer = "server = Tony; initial catalog = DBPrueba; trusted_connection = true;";

            /*
            String conNpgsql = "Host = localhost; " +
                               "Port = 5432; " +
                               "Database = DBUniversidad; " +
                               "Username = postgres; " +
                               "Password = 1234; ";

            */

            //Conexión a SQL-Server 
            options.UseSqlServer(conSQLServer);

            //Conxión a PGSQL
            //options.UseNpgsql(conNpgsql);
        }
    }
}
