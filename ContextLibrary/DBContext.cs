using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using EntityBiblio.Model; 

namespace ContextLibrary
{
    public class DBContext : DbContext
    {
        public DBContext() : base("Data Source=NORMANE-LAPTOP;Initial Catalog=DBMiniProjet;Integrated Security=True")
        {

        }
        public DbSet<Cours> Cours { get; set; }
        public DbSet<Departement> Departements { get; set; }
        public DbSet<Professor> Professors { get; set; }
    }
}
