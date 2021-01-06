using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EntityBiblio.Model
{
    public class Cours
    {
        private int _id;
        private string nom;
        private string module;
        private string description;

        [Key]
        public int Id { get => _id; set => _id = value; }
        [Column("NomCours")]
        [Required]
        public string Nom { get => nom; set => nom = value; }
        [Column("Module")]
        [Required]
        public string Module { get => module; set => module = value; }
        [Column("Description")]
        [Required]
        public string Description { get => description; set => description = value; }
        [ForeignKey("Professor")]
        public int IdProfessor { get; set; }
        public Professor Professor { get; set; }
    }
}
