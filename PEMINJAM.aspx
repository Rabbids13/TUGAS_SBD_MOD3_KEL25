<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PEMINJAM.aspx.cs" Inherits="TugasModul3Kel25.PEMINJAM" EnableEventValidation = "false" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Peminjaman Sepeda</title>
</head>
<body>
    
    <form id="form1" runat="server">
        <div>
            <asp:LinkButton  ID="btnSepeda" runat="server" PostBackUrl="SEPEDA.aspx"><span style="margin-right: 30px;">Sepeda</span></asp:LinkButton>
            <asp:LinkButton ID="btnAlamatPeminjam" runat="server" PostBackUrl="ALAMAT_PEMINJAM.aspx"><span style="margin-right: 30px;">Alamat Peminjam</span></asp:LinkButton>
            <asp:LinkButton ID="btnRecycle" runat="server" PostBackUrl="Recycle.aspx">Recycle</asp:LinkButton>
            <table>
                <tr>
                <td>NIP :</td>
                <td><asp:TextBox ID="txtNIP_PEMINJAM" runat="server"></asp:TextBox> </td>
                </tr>
                <tr>
                <td>Nama :</td>
                <td><asp:TextBox ID="txtNAMA" runat="server"></asp:TextBox> </td>
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
        <asp:GridView ID="GridViewJoin" runat="server" DataKeyNames="NIP_PEMINJAM, NAMA" OnRowDataBound="GridViewJoin_RowDataBound" OnSelectedIndexChanged="GridViewJoin_SelectedIndexChanged">
        </asp:GridView>
        <h3>Data  Peminjam</h3>
        <asp:GridView ID="gvDATA_PEMINJAM" runat="server">
        </asp:GridView>
    </form>
</body>
</html>