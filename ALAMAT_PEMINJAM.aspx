<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ALAMAT_PEMINJAM.aspx.cs" Inherits="TugasModul3Kel25.ALAMAT_PEMINJAM"  %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Peminjaman Sepeda</title>
</head>
<body>
    
    <form id="form1" runat="server">
        <div>
            <asp:LinkButton  ID="btnSepeda" runat="server" PostBackUrl="SEPEDA.aspx"><span style="margin-right: 30px;">Sepeda</span></asp:LinkButton>
            <asp:LinkButton ID="btnPeminjam" runat="server" PostBackUrl="PEMINJAM.aspx"><span style="margin-right: 30px;">Peminjam</span></asp:LinkButton>
            <asp:LinkButton ID="btnRecycle" runat="server" PostBackUrl="Recycle.aspx">Recycle</asp:LinkButton>
            <table>
                <tr>
                <td>NIP :</td>
                <td><asp:TextBox ID="txtNIP_PEMINJAM" runat="server"></asp:TextBox> </td>
                </tr>
                <tr>
                <td>Alamat Lengkap :</td>
                <td><asp:TextBox ID="txtALAMAT_LENGKAP" runat="server"></asp:TextBox> </td>
                </tr>
                <tr>
                <td>
                </td>
                <td>
                <asp:Button ID="btnAdd" runat="server" Text="ADD" OnClick="btnAdd_Click" />
                <asp:Button ID="btnDelete" runat="server" Text="DELETE" OnClick="btnDelete_Click" />
                <asp:Button ID="btnUpdate" runat="server" Text="UPDATE" OnClick="btnUpdate_Click" />
                <asp:Button ID="btnClear" runat="server" Text="CLEAR" OnClick="btnClear_Click" />

                </td>
                </tr>
            </table>
        </div>
        <asp:GridView ID="GridViewJoin" runat="server" DataKeyNames="NIP_PEMINJAM, ALAMAT_LENGKAP" OnRowDataBound="GridViewJoin_RowDataBound" OnSelectedIndexChanged="GridViewJoin_SelectedIndexChanged">
        </asp:GridView>
    </form>
</body>
</html>