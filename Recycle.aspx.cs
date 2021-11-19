using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Data;
using System.Data.SqlClient;

namespace TugasModul3Kel25
{
    public partial class Recycle : System.Web.UI.Page
    {

        SqlConnection con = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter sda = new SqlDataAdapter();
        DataTable dt = new DataTable();
        DataSet ds = new DataSet();

        protected void Page_Load(object sender, EventArgs e)
        {
            con.ConnectionString = "Data Source=LAPTOP-F0QS3278\\SQLEXPRESS;Initial Catalog=Tugas_KEL25;Integrated Security=True";
            con.Open();
            if (!Page.IsPostBack)
            {
                DataShow();
            }

        }

        private void DataShow()
        {
            ds = new DataSet();
            cmd.CommandText = "SELECT * FROM PEMINJAM WHERE is_delete = 1";
            cmd.Connection = con;
            sda = new SqlDataAdapter(cmd);
            sda.Fill(ds);
            cmd.ExecuteNonQuery();
            gvPEMINJAM.DataSource = ds;
            gvPEMINJAM.DataBind();

            DataSet ds2 = new DataSet();
            SqlCommand cmd2 = new SqlCommand();
            cmd2.CommandText = "SELECT * FROM SEPEDA WHERE is_delete = 1";
            cmd2.Connection = con;
            SqlDataAdapter sda2 = new SqlDataAdapter(cmd2);
            sda2.Fill(ds2);
            cmd2.ExecuteNonQuery();
            gvSEPEDA.DataSource = ds2;
            gvSEPEDA.DataBind();

            DataSet ds3 = new DataSet();
            SqlCommand cmd3 = new SqlCommand();
            cmd3.CommandText = "SELECT * FROM ALAMAT_PEMINJAM WHERE is_delete = 1";
            cmd3.Connection = con;
            SqlDataAdapter sda3 = new SqlDataAdapter(cmd3);
            sda3.Fill(ds3);
            cmd3.ExecuteNonQuery();
            gvALAMAT_PEMINJAM.DataSource = ds3;
            gvALAMAT_PEMINJAM.DataBind();

            con.Close();
        }

     
        protected void gvPEMINJAM_SelectedIndexChanged(object sender, EventArgs e)
        {
            string nip  = gvPEMINJAM.SelectedRow.Cells[0].Text;
            cmd.CommandText = "UPDATE PEMINJAM SET is_delete = 0 WHERE NIP_PEMINJAM = '" + nip + "'";
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            DataShow();
        }

        protected void gvPEMINJAM_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                e.Row.Cells[2].Attributes["onclick"] = Page.ClientScript.GetPostBackClientHyperlink(gvPEMINJAM, "Select$" + e.Row.RowIndex);
                e.Row.Cells[2].Attributes["style"] = "cursor:pointer";
            }
        }

        protected void gvSEPEDA_SelectedIndexChanged(object sender, EventArgs e)
        {
            string nip = gvSEPEDA.SelectedRow.Cells[0].Text;
            cmd.CommandText = "UPDATE SEPEDA SET is_delete = 0 WHERE NIP_PEMINJAM = '" + nip + "'";
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            DataShow();
        }

        protected void gvSEPEDA_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                e.Row.Cells[3].Attributes["onclick"] = Page.ClientScript.GetPostBackClientHyperlink(gvSEPEDA, "Select$" + e.Row.RowIndex);
                e.Row.Cells[3].Attributes["style"] = "cursor:pointer";
            }
        }

        protected void gvALAMAT_PEMINJAM_SelectedIndexChanged(object sender, EventArgs e)
        {
            string nip = gvALAMAT_PEMINJAM.SelectedRow.Cells[0].Text;
            cmd.CommandText = "UPDATE ALAMAT_PEMINJAM SET is_delete = 0 WHERE NIP_PEMINJAM = '" + nip + "'";
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            DataShow();
        }

        protected void gvALAMAT_PEMINJAM_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                e.Row.Cells[2].Attributes["onclick"] = Page.ClientScript.GetPostBackClientHyperlink(gvALAMAT_PEMINJAM, "Select$" + e.Row.RowIndex);
                e.Row.Cells[2].Attributes["style"] = "cursor:pointer";
            }
        }
    }
}