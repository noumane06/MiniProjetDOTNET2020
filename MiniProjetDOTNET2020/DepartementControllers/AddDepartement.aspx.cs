using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ContextLibrary;
using EntityBiblio.Model;

namespace MiniProjetDOTNET2020.DepartementControllers
{
    public partial class AddDepartement : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {

        }


        protected void Button1_Click(object sender, EventArgs e)
        {
            DBContext db = new DBContext();

            EntityBiblio.Model.Departement De = new EntityBiblio.Model.Departement();
            De.NomDep = textbox1.Text;
            De.Budget = Double.Parse(textbox2.Text);
            db.Departements.Add(De);
            db.SaveChanges();
            Response.Redirect("/Depart.aspx");
        }
    }
}