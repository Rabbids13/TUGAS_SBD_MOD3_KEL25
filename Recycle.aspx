<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Recycle.aspx.cs" Inherits="TugasModul3Kel25.Recycle" EnableEventValidation = "false"%>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Recycle</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:LinkButton  ID="btnSepeda" runat="server" PostBackUrl="SEPEDA.aspx"><span style="margin-right: 30px;">Sepeda</span></asp:LinkButton>
            <asp:LinkButton ID="btnPeminjam" runat="server" PostBackUrl="PEMINJAM.aspx"><span style="margin-right: 30px;">Peminjam</span></asp:LinkButton>
            <asp:LinkButton ID="btnAlamatPeminjam" runat="server" PostBackUrl="ALAMAT_PEMINJAM.aspx"><span style="margin-right: 30px;">Alamat Peminjam</span></asp:LinkButton>
            <h3>Peminjam</h3>
            <asp:GridView ID="gvPEMINJAM" runat="server" DataKeyNames="NIP_PEMINJAM, NAMA" OnRowDataBound="gvPEMINJAM_RowDataBound" OnSelectedIndexChanged="gvPEMINJAM_SelectedIndexChanged" >
            </asp:GridView>
            <h3>Sepeda</h3>
            <asp:GridView ID="gvSEPEDA" runat="server" DataKeyNames="NIP_PEMINJAM, WARNA, JUMLAH" OnRowDataBound="gvSEPEDA_RowDataBound" OnSelectedIndexChanged="gvSEPEDA_SelectedIndexChanged" >
            </asp:GridView>
            <h3>Alamat Peminjam</h3>
            <asp:GridView ID="gvALAMAT_PEMINJAM" runat="server" DataKeyNames="NIP_PEMINJAM, ALAMAT_LENGKAP" OnRowDataBound="gvALAMAT_PEMINJAM_RowDataBound" OnSelectedIndexChanged="gvALAMAT_PEMINJAM_SelectedIndexChanged">
            </asp:GridView>
        </div>
    </form>
</body>
</html>
