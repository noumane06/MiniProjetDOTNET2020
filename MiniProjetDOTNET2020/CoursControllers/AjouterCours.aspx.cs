using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ContextLibrary;
using EntityBiblio.Model;
namespace MiniProjetDOTNET2020
{
    public partial class AjouterCours : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DBContext dB = new DBContext();
            Proff.DataSource = (from prof in dB.Professors select prof.Nom).ToList();
            Proff.DataBind();
        }   

        protected void Proff_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void AddButton_Click(object sender, EventArgs e)
        {
            Cours Cours = new Cours();
            DBContext dB = new DBContext();

            var elmId = dB.Professors.Where(b => b.Nom == Proff.SelectedValue).FirstOrDefault();
            Cours.Nom = NomCours.Text;
            Cours.Module = NomModule.Text;
            Cours.Description = Descr.Text;
            Cours.IdProfessor = elmId.Id;
            dB.Cours.Add(Cours);
            dB.SaveChanges();
            Response.Redirect("/Cours.aspx");
        }
    }
}