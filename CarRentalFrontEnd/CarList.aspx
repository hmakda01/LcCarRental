<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CarList.aspx.cs" Inherits="CarList" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="background-color: skyblue">
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:ListBox ID="lstCars" runat="server" style="z-index: 1; left: 83px; top: 165px; position: absolute; height: 214px; width: 249px"></asp:ListBox>
        <asp:Button ID="btnAdd" runat="server" style="z-index: 1; left: 353px; top: 424px; position: absolute; width: 49px;" Text="Add" OnClick="btnAdd_Click" />
        <asp:Button ID="btnDelete" runat="server" style="z-index: 1; left: 480px; top: 425px; position: absolute" Text="Delete" OnClick="btnDelete_Click1" />
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 437px; top: 469px; position: absolute; height: 24px; width: 98px"></asp:Label>
        <asp:Button ID="btnApply" runat="server" style="z-index: 1; left: 89px; top: 488px; position: absolute; width: 53px;" Text="Apply" OnClick="btnApply_Click" />
        <asp:TextBox ID="tctCNSearch" runat="server" style="z-index: 1; left: 85px; top: 429px; position: absolute" OnTextChanged="tctCNSearch_TextChanged"></asp:TextBox>
        <asp:Button ID="btnDisplayAll" runat="server" style="z-index: 1; left: 161px; top: 488px; position: absolute" Text="Display All" OnClick="btnDisplayAll_Click" />
        <asp:Label ID="lblCNSearch" runat="server" style="z-index: 1; left: 81px; top: 400px; position: absolute" Text="Please enter a car Reg"></asp:Label>
        <asp:Button ID="btnEdit" runat="server" style="z-index: 1; left: 412px; top: 425px; position: absolute; width: 53px; height: 26px;" Text="Edit" OnClick="btnEdit_Click" />
    <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="40pt" style="z-index: 1; left: 275px; top: 46px; position: absolute; height: 57px; width: 283px" Text="LCCarHire"></asp:Label>
   <asp:Label ID="Label2" runat="server" Font-Bold="True" Font-Size="30pt" style="z-index: 1; left: 323px; top: 114px; position: absolute" Text="Car Page"></asp:Label>
        </form>
</body>
</html>

