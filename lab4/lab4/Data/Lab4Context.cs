using lab4.Models;
using lab4.Models.Many_to_Many;
using lab4.Models.One_to_Many;
using lab4.Models.One_to_One;
using Microsoft.EntityFrameworkCore;

namespace lab4.Data
{
    public class Lab4Context : DbContext
    {
        public DbSet<Student> Students { get; set; }


        // One to One
        public DbSet<Materie> Materii { get; set; }
        public DbSet<Profesor> Profesori { get; set; }


        // One to Many
        public DbSet<Facultate> Facultati { get; set; }
        public DbSet<Universitate> Universitati { get; set; }

        // Many to Many

        public DbSet<Boboc> Boboci { get; set; }
        public DbSet<Asociatie> Asociatii { get; set; }
        public DbSet<ModelsRelations> ModelsRelations { get; set; }

        public Lab4Context(DbContextOptions<Lab4Context> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // One to Many
            modelBuilder.Entity<Universitate>()
                        .HasMany(u => u.Facultati)
                        .WithOne(m2 => m2.Universitate);

            // One to One
            modelBuilder.Entity<Profesor>()
                .HasOne(m => m.Materie)
                .WithOne(m6 => m6.Profesor)
                .HasForeignKey<Materie>(p => p.ProfesorId);


            // Many to Many
            modelBuilder.Entity<ModelsRelations>().HasKey(mr => new { mr.BobocId, mr.AsociatieId });

            // One to many for m-m
            modelBuilder.Entity<ModelsRelations>()
                        .HasOne(b => b.Boboc)
                        .WithMany(a => a.ModelsRelations)
                        .HasForeignKey(b => b.BobocId);

            modelBuilder.Entity<ModelsRelations>()
                        .HasOne(a => a.Asociatie)
                        .WithMany(b => b.ModelsRelations)
                        .HasForeignKey(a => a.AsociatieId);

            base.OnModelCreating(modelBuilder);
        }
    }

}
