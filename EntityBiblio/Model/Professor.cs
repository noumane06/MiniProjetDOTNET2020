using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EntityBiblio.Model
{
    [Table("Professor")]
    public class Professor
    {

        private int _id;
        private string nom , prenom , email,tel,CIN;

        [Key]
        public int Id { get => _id; set => _id = value; }
        [Column("ProfNom")]
        [Required]
        public string Nom { get => nom; set => nom = value; }
        [Column("ProfPrenom")]
        [Required]
        public string Prenom { get => prenom; set => prenom = value; }
        [Column("Email")]
        [Required]
        public string Email { get => email; set => email = value; }
        [Column("Tel")]
        public string Tel { get => tel; set => tel = value; }
        [Column("CIN")]
        [Required]
        public string CIN1 { get => CIN; set => CIN = value; }

        public ICollection<Cours> Cours { get; set; }

        [ForeignKey("Departement")]
        public int IdDep { get; set; }
        public Departement Departement { get; set; }

        public static implicit operator int(Professor v)
        {
            throw new NotImplementedException();
        }
    }
}
