using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EntityBiblio.Model;
using ContextLibrary;

namespace MiniProjetDOTNET2020.DepartementControllers
{
    public partial class ModifierDepartement : System.Web.UI.Page
    {
        DBContext dBContext = new DBContext();
        protected void Page_Load(object sender, EventArgs e)
        {
            
            DepView.DataSource = dBContext.Departements.Select(c => new { c.Id, c.NomDep, c.Budget }).ToList();
            DepView.DataBind();
        }

        protected void DepView_SelectedIndexChanged(object sender, EventArgs e)
        {
            int Id = int.Parse(DepView.SelectedValue.ToString());
            EntityBiblio.Model.Departement dep = (from d in dBContext.Departements where d.Id == Id select d).Single();
            textbox1.Text = dep.NomDep;
            textbox2.Text = dep.Budget.ToString();

        }

        protected void EditButton_Click(object sender, EventArgs e)
        {
            int Id = int.Parse(DepView.SelectedValue.ToString());
            EntityBiblio.Model.Departement dep = (from d in dBContext.Departements where d.Id == Id select d).Single();
            dep.NomDep = textbox1.Text;
            dep.Budget = Double.Parse(textbox2.Text);
            dBContext.SaveChanges();
            Response.Redirect("/Depart.aspx");
        }
    }
}