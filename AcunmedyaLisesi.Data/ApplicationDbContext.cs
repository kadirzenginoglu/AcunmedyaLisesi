using AcunmedyaLisesi.Web.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YeniAcunmedyaLisesi.Models.Models;

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

       
        public virtual DbSet<Egitimciler> Egitimcies { get; set; }
        public virtual DbSet<Dersler> Dersler {  get; set; }        
        public virtual DbSet<Ogrenciler> Ogrencies { get; set; }
        public virtual DbSet<Sinavlar> Sınavlars { get; set; }
        public virtual DbSet<User> Users { get; set; }






    }
}
