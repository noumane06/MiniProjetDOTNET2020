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
    public partial class Professor : System.Web.UI.Page
    { 
        DBContext dB = new DBContext();
        protected void Page_Load(object sender, EventArgs e)
        {
           
            GridView1.DataSource = dB.Professors.Select(c => new { c.Id,c.Nom , c.Prenom , c.Tel , c.Email , c.CIN1 , c.Departement.NomDep }).ToList();
            GridView1.DataBind();
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int Id = Convert.ToInt32(GridView1.DataKeys[e.RowIndex].Value.ToString());
            EntityBiblio.Model.Professor Prof = (from p in dB.Professors where p.Id == Id select p).Single();
            dB.Professors.Remove(Prof);
            dB.SaveChanges();
            Response.Redirect("/Professor.aspx");
        }
    }
}