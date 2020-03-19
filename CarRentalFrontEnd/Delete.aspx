<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Delete.aspx.cs" Inherits="Delete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="background-color: skyblue">
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="Label1" runat="server" style="z-index: 1; left: 89px; top: 111px; position: absolute; height: 25px; width: 367px" Text="Are you sure you want to delete this car?"></asp:Label>
        <asp:Button ID="btnYes" runat="server" OnClick="btnYes_Click" style="z-index: 1; left: 211px; top: 150px; position: absolute; height: 26px; width: 54px;" Text="yes" />
        <asp:Button ID="btnNo" runat="server" style="z-index: 1; left: 280px; top: 150px; position: absolute; width: 50px;" Text="No" OnClick="btnNo_Click" />
    </form>
</body>
</html>

