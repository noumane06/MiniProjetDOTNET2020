using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EntityBiblio;
using ContextLibrary;
namespace MiniProjetDOTNET2020.ProfControllers
{
    public partial class EditProf : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DBContext db = new DBContext();
            ProfView.DataSource = db.Professors.Select(c => new { c.Id ,c.Nom, c.Prenom, c.Tel, c.Email, c.CIN1, c.Departement.NomDep }).ToList();
            ProfView.DataBind();
        }

        protected void ProfView_SelectedIndexChanged(object sender, EventArgs e)
        {
              DBContext dBContext = new DBContext();

              int Id = int.Parse(ProfView.SelectedValue.ToString());
              EntityBiblio.Model.Professor prof = (from c in dBContext.Professors where c.Id == Id select c).Single();

              var elmProf = dBContext.Departements.Where(b => b.Id == prof.IdDep).FirstOrDefault();

              NomProf.Text = prof.Nom ;
              prenomProf.Text = prof.Prenom;   
              Tel.Text = prof.Tel;
              Cin.Text = prof.CIN1;
              Email.Text = prof.Email;
              Depart.SelectedValue = elmProf.NomDep;
            
        }

        protected void Depart_PreRend(object sender, EventArgs e)
        {
            DBContext dBContext = new DBContext();

            Depart.DataSource = (from d in dBContext.Departements select d.NomDep).ToList();
            Depart.DataBind();
        }

        protected void AddButton_Click(object sender, EventArgs e)
        {
            int Id = int.Parse(ProfView.SelectedValue.ToString());
            DBContext dBContext = new DBContext();
            EntityBiblio.Model.Professor prof = (from c in dBContext.Professors where c.Id == Id select c).Single();
            var elmProf = dBContext.Departements.Where(b => b.NomDep == Depart.SelectedValue).FirstOrDefault();
            prof.Nom = NomProf.Text;
            prof.Prenom = prenomProf.Text;
            prof.Tel = Tel.Text;
            prof.CIN1 = Cin.Text;
            prof.Email = Email.Text;
            prof.IdDep = elmProf.Id;
            dBContext.SaveChanges();
            Response.Redirect("/Professor.aspx");
        }
    }
}