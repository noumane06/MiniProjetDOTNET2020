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
    public partial class Departement : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DBContext dBContext = new DBContext();
            GridView1.DataSource = dBContext.Departements.Select(c => new { c.Id, c.NomDep, c.Budget }).ToList();
            Console.WriteLine(GridView1.DataSource.ToString());
            GridView1.DataBind();
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            
        }
    }
}