<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Trial2.WebForm1" %>



<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Web Form Example</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            
            <asp:Label ID="Label1" runat="server" Text="Number 1"></asp:Label>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>

            
        </div>
        <p>
            <asp:Label ID="Label2" runat="server" Text="Number 2"></asp:Label>
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>

            </p>
        <p>
            <asp:Button ID="Button1" runat="server" Text="Calculate" OnClick="Button1_Click" />

            </p>
        <p>
            <asp:Label ID="Label3" runat="server"></asp:Label>
        </p>


        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/WebForm2.aspx">See previous results</asp:HyperLink>
    </form>
</body>
</html>
