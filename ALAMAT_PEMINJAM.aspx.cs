using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Data.SqlClient;
using System.Data;

namespace TugasModul3Kel25
{
    public partial class ALAMAT_PEMINJAM : System.Web.UI.Page
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

        public void DataShow()
        {
            ClearData();
            ds = new DataSet();
            cmd.CommandText = "SELECT * FROM ALAMAT_PEMINJAM WHERE is_delete = 0";
            cmd.Connection = con;
            sda = new SqlDataAdapter(cmd);
            sda.Fill(ds);
            cmd.ExecuteNonQuery();
            GridViewJoin.DataSource = ds;
            GridViewJoin.DataBind();
            con.Close();
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            dt = new DataTable();
            cmd.CommandText = "INSERT INTO ALAMAT_PEMINJAM VALUES('" + txtNIP_PEMINJAM.Text + "','" + txtALAMAT_LENGKAP.Text + "',0) ";
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            DataShow();
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            dt = new DataTable();
            cmd.CommandText = "UPDATE ALAMAT_PEMINJAM SET ALAMAT_LENKGAP = '" + txtALAMAT_LENGKAP.Text + "' WHERE NIP_PEMINJAM = '" + txtNIP_PEMINJAM.Text + "' ";
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            DataShow();
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            dt = new DataTable();
            cmd.CommandText = "UPDATE ALAMAT_PEMINJAM SET is_delete = 1 WHERE NIP_PEMINJAM = '" + txtNIP_PEMINJAM.Text + "'";
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            DataShow();
        }

        protected void btnClear_Click(object sender, EventArgs e)
        {
            ClearData();
        }

        public void ClearData()
        {
            txtNIP_PEMINJAM.Text = null;
            txtALAMAT_LENGKAP.Text = null;
           
        }

        protected void GridViewJoin_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                e.Row.Attributes["onclick"] = Page.ClientScript.GetPostBackClientHyperlink(GridViewJoin, "Select$" + e.Row.RowIndex);
                e.Row.Attributes["style"] = "cursor:pointer";
            }
        }
        protected void GridViewJoin_SelectedIndexChanged(object sender, EventArgs e)
        {
            string nip = GridViewJoin.SelectedRow.Cells[0].Text;
            string alamat = GridViewJoin.SelectedRow.Cells[1].Text;
            string jumlah = GridViewJoin.SelectedRow.Cells[1].Text;
            txtNIP_PEMINJAM.Text = nip;
            txtALAMAT_LENGKAP.Text = alamat;
        }


    }
}