using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EntityBiblio.Model;
using ContextLibrary;
namespace MiniProjetDOTNET2020
{
    public partial class ModifierCours : System.Web.UI.Page
    {
        DBContext dBContext = new DBContext();
        protected void Page_Load(object sender, EventArgs e)
        {
            CoursView.DataSource = dBContext.Cours.Select(c => new { c.Id, c.Nom, c.Module, c.IdProfessor }).ToList();
            CoursView.DataBind();

        }

     
   

        protected void CoursView_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            int Id = int.Parse(CoursView.SelectedValue.ToString());
            Cours cours = (from c in dBContext.Cours where c.Id == Id select c).Single();

            var elmProf = dBContext.Professors.Where(b => b.Id == cours.IdProfessor).FirstOrDefault();
            NomCours.Text = cours.Nom;
            NomModule.Text = cours.Module.ToString();
            Descr.Text = cours.Description;
            DropDownList1.SelectedValue = elmProf.Nom;
            
        }

        protected void EditButton_Click(object sender, EventArgs e)
        {
            int Id = int.Parse(CoursView.SelectedValue.ToString());

            Cours cours = (from c in dBContext.Cours where c.Id == Id select c).Single();

            var elmId = dBContext.Professors.Where(b => b.Nom == DropDownList1.SelectedValue).FirstOrDefault();

            cours.Nom = NomCours.Text;
            cours.Module = NomModule.Text;
            cours.Description = Descr.Text;
            cours.IdProfessor = elmId.Id;
            dBContext.SaveChanges();
            Response.Redirect("/Cours.aspx");

        }

        protected void Proff_SelectedIndexChanged1(object sender, EventArgs e)
        {

        }

        protected void DropDownList1_PreRender(object sender, EventArgs e)
        {
            DropDownList1.DataSource = (from prof in dBContext.Professors select prof.Nom).ToList();
            DropDownList1.DataBind();
        }
    }
}