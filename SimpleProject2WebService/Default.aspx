<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="SimpleProject2WebService.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div style="height: 506px">
    
        <br />
        First Name:<br />
        <asp:TextBox ID="TxtFirstName" runat="server"></asp:TextBox>
        <br />
        <br />
        Last Name:<br />
        <asp:TextBox ID="TxtLastName" runat="server"></asp:TextBox>
        <br />
        <br />
        Position:<br />
        <asp:TextBox ID="TxtPosition" runat="server"></asp:TextBox>
        <br />
        <br />
        Manager:<br />
        <asp:TextBox ID="TxtManager" runat="server"></asp:TextBox>
        <br />
        <br />
        Department:<br />
        <asp:DropDownList ID="DdlDepartment" runat="server">
            <asp:ListItem>Select your Department</asp:ListItem>
            <asp:ListItem>IT</asp:ListItem>
            <asp:ListItem>Audit</asp:ListItem>
            <asp:ListItem>Logistics</asp:ListItem>
            <asp:ListItem>Payments</asp:ListItem>
            <asp:ListItem>Inquiry</asp:ListItem>
            <asp:ListItem>Sales</asp:ListItem>
        </asp:DropDownList>
        <br />
        <br />
        <asp:Button ID="BtnAdd" runat="server" Text="Add" Visible="False" />
        <br />
        <br />
        <br />
        <asp:Button ID="BtnDetails" runat="server" Text="Details Page" />
    
    </div>
        <asp:Panel ID="Panel1" runat="server">
        </asp:Panel>
    </form>
</body>
</html>
