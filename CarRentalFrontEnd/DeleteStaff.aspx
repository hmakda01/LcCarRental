<%@ Page Language="C#" AutoEventWireup="true" CodeFile="DeleteStaff.aspx.cs" Inherits="Delete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="Label1" runat="server" style="z-index: 1; left: 105px; top: 73px; position: absolute" Text="Are you sure you want to delete this?"></asp:Label>
        <asp:Button ID="btnYES" runat="server" OnClick="btnYES_Click" style="z-index: 1; left: 134px; top: 117px; position: absolute; height: 30px; width: 68px" Text="Yes" />
        <asp:Button ID="btnNo" runat="server" style="z-index: 1; left: 254px; top: 118px; position: absolute; height: 29px; width: 58px" Text="No" OnClick="btnNo_Click" />
    </form>
</body>
</html>
