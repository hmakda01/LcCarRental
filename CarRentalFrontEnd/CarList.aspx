<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CarList.aspx.cs" Inherits="CarList" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:ListBox ID="lstCars" runat="server" style="z-index: 1; left: 96px; top: 107px; position: absolute; height: 214px; width: 249px"></asp:ListBox>
        <asp:Button ID="btnAdd" runat="server" style="z-index: 1; left: 347px; top: 386px; position: absolute; width: 49px;" Text="Add" OnClick="btnAdd_Click" />
        <asp:Button ID="btnDelete" runat="server" style="z-index: 1; left: 489px; top: 387px; position: absolute" Text="Delete" OnClick="btnDelete_Click1" />
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 477px; top: 303px; position: absolute; height: 24px; width: 98px"></asp:Label>
        <asp:Button ID="btnApply" runat="server" style="z-index: 1; left: 88px; top: 423px; position: absolute; width: 53px;" Text="Apply" OnClick="btnApply_Click" />
        <asp:TextBox ID="tctCNSearch" runat="server" style="z-index: 1; left: 84px; top: 382px; position: absolute" OnTextChanged="tctCNSearch_TextChanged"></asp:TextBox>
        <asp:Button ID="btnDisplayAll" runat="server" style="z-index: 1; left: 156px; top: 423px; position: absolute" Text="Display All" OnClick="btnDisplayAll_Click" />
        <asp:Label ID="lblCNSearch" runat="server" style="z-index: 1; left: 83px; top: 351px; position: absolute" Text="Please enter a car Reg"></asp:Label>
        <asp:Button ID="btnEdit" runat="server" style="z-index: 1; left: 417px; top: 387px; position: absolute; width: 53px; height: 26px;" Text="Edit" OnClick="btnEdit_Click" />
    </form>
</body>
</html>

