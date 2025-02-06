using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;

public partial class Index : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["conString"].ConnectionString);

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            //dispCourse();
            // txtDet.Attributes.Add("maxlength", "300");
        }
    }
    //private void dispCourse()
    //{
    //    con.Open();
    //    SqlCommand cmd = new SqlCommand("Select top 4 courseId,coursetitle,details,fee,image from tblCourses order by courseId desc", con);
    //    SqlDataReader dr = cmd.ExecuteReader();
    //    DataTable dt = new DataTable();
    //    dt.Load(dr);
    //    CoursesRepeater.DataSource = dt;
    //    CoursesRepeater.DataBind();
    //    dr.Close();
    //    con.Close();
    //}

    protected string Truncate(string input, int length)
    {
        if (string.IsNullOrEmpty(input)) return input;
        if (input.Length <= length) return input;
        return input.Substring(0, length) + "...";
    }
    protected void btnDiploma_Click(object sender, EventArgs e)
    {
        // Set session variable
        Session["courseType"] = 3;

        // Redirect to the target page
        Response.Redirect("Courses.aspx");
    }

    protected void btnSkill_Click(object sender, EventArgs e)
    {
        // Set session variable
        Session["courseType"] = 2;

        // Redirect to the target page
        Response.Redirect("Courses.aspx");
    }

    protected void btnBvoc_Click(object sender, EventArgs e)
    {
        // Set session variable
        Session["courseType"] = 1;

        // Redirect to the target page
        Response.Redirect("Courses.aspx");
    }
}