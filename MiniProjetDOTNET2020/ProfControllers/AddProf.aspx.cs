using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ContextLibrary;
using EntityBiblio.Model;

namespace MiniProjetDOTNET2020.ProfControllers
{
    public partial class AddProf : System.Web.UI.Page
    {
        DBContext dB = new DBContext();
        protected void Page_Load(object sender, EventArgs e)
        {
            
            Depart.DataSource = (from d in dB.Departements select d.NomDep).ToList();
            Depart.DataBind();

        }

        protected void Depart_SelectedIndexChanged(object sender, EventArgs e)
        {
            EntityBiblio.Model.Professor prof = new EntityBiblio.Model.Professor();
            var elmId = dB.Departements.Where(b => b.NomDep == Depart.SelectedValue).FirstOrDefault();
            prof.Nom = NomProf.Text;
            prof.Prenom = prenomProf.Text;
            prof.Tel = Tel.Text;
            prof.Email = Email.Text;
            prof.CIN1 = Cin.Text;
            prof.IdDep = elmId.Id;
            dB.Professors.Add(prof);
            dB.SaveChanges();
            Response.Redirect("/Professor.aspx");
        }
    }
}