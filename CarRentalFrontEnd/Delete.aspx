<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Delete.aspx.cs" Inherits="Delete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="Label1" runat="server" style="z-index: 1; left: 89px; top: 101px; position: absolute; height: 25px; width: 367px" Text="Are you sure you want to delete this car?"></asp:Label>
        <asp:Button ID="btnYes" runat="server" OnClick="btnYes_Click" style="z-index: 1; left: 201px; top: 152px; position: absolute; height: 26px;" Text="yes" />
        <asp:Button ID="btnNo" runat="server" style="z-index: 1; left: 273px; top: 152px; position: absolute" Text="No" OnClick="btnNo_Click" />
    </form>
</body>
</html>

