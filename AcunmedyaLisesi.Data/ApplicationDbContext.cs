using AcunmedyaLisesi.Web.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcunmedyaLisesi.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext()
        {

        }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext>options):base(options) 
        {
            
        }

        public virtual DbSet<Bilisim> Bilisims { get; set; }
        public virtual DbSet<Egitimciler> Egitimcies { get; set; }
        public virtual DbSet<Fen> Fens { get; set; }
        public virtual DbSet<Matematik> Matematiks { get; set; }
        public virtual DbSet<Ogrenciler> Ogrencies { get; set; }
        public virtual DbSet<Sınavlar> Sınavlars { get; set; }






    }
}
