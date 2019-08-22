<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="First Name"></asp:Label>
            <asp:TextBox ID="TxtFN" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Label2" runat="server" Text="Last Name"></asp:Label>
            <asp:TextBox ID="TxtLN" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Label3" runat="server" Text="Company"></asp:Label>
            <asp:TextBox ID="TxtCompany" runat="server"></asp:TextBox><br />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Add" />
        </div>
        <asp:GridView ID="GridView1" runat="server">
        </asp:GridView>
    </form>
</body>
</html>
