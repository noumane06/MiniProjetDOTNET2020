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
    public partial class WebForm1 : System.Web.UI.Page
    { 
        DBContext dBContext = new DBContext();
        protected void Page_Load(object sender, EventArgs e)
        {
           
            CoursView.DataSource = dBContext.Cours.Select(c => new { c.Id, c.Nom, c.Module, c.IdProfessor }).ToList();
            CoursView.DataBind();
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int Id = Convert.ToInt32(CoursView.DataKeys[e.RowIndex].Value.ToString());
            Cours cours = (from c in dBContext.Cours where c.Id == Id select c).Single();
            dBContext.Cours.Remove(cours);
            dBContext.SaveChanges();
            Response.Redirect("Cours.aspx");
        }
    }
}