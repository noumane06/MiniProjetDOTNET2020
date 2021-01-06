using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EntityBiblio.Model
{
    [Table("Departement")]
    public class Departement
    {

        private int _id;
        private string nomDep;
        private double budget;

        [Key]
        public int Id { get => _id; set => _id = value; }
        [Column("NomDep")]
        [Required]
        public string NomDep { get => nomDep; set => nomDep = value; }
        [Column("Budget")]
        [Required]
        public double Budget { get => budget; set => budget = value; }
        public ICollection<Professor> Professors { get; set; }

    }
}
