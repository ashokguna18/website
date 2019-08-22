using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class _Default : System.Web.UI.Page
{
    private DataTable dt;
    private DataRow dr;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            dt = new DataTable();

            dt.Columns.Add("FirstName");
            dt.Columns.Add("LastName");
            dt.Columns.Add("CompanyName");

            dr = dt.NewRow();
            dr[0] = "ramesh";
            dr[1] = "ramanaiya";
            dr[2] = "HW";
            dt.Rows.Add(dr);

            dr = dt.NewRow();
            dr[0] = "Ashok";
            dr[1] = "";
            dr[2] = "HW";
            dt.Rows.Add(dr);

            GridView1.DataSource = dt;
            GridView1.DataBind();
            ViewState["tempData"] = dt;
        }
        else
        {
            dt = ViewState["tempData"] as DataTable;
            GridView1.DataSource = dt;
            GridView1.DataBind();
        }
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        dt = ViewState["tempData"] as DataTable;
        dr = dt.NewRow();
        dr[0] = TxtFN.Text;
        dr[1] = TxtLN.Text;
        dr[2] = TxtCompany.Text;
        dt.Rows.Add(dr);
        GridView1.DataSource = dt;
        GridView1.DataBind();
        TxtFN.Text = "";
        TxtLN.Text = "";
        TxtCompany.Text = "";
    }
}