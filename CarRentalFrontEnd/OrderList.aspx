<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrderList.aspx.cs" Inherits="OrderList" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <p>
            &nbsp;</p>
        <asp:ListBox ID="lstOrder" runat="server" OnSelectedIndexChanged="lstOrder_SelectedIndexChanged" Height="331px" Width="299px"></asp:ListBox>
        <p>
            <asp:Button ID="BtnApply" runat="server" Text="Apply" />
            <asp:Button ID="BtnDisplayALL" runat="server" style="margin-left: 16px" Text="Display All" Width="94px" />
        </p>
        <asp:Button ID="BtnAdd" runat="server" OnClick="BtnAdd_Click" Text="Add" />
        <asp:Button ID="BtnEdit" runat="server" OnClick="BtnEdit_Click" style="margin-left: 18px" Text="Edit" />
        <asp:Button ID="BtnDelete" runat="server" OnClick="BtnDelete_Click" style="margin-left: 25px" Text="Delete" />
        <p>
            <asp:Label ID="lblError" runat="server" Text="LblError"></asp:Label>
        </p>
    </form>
</body>
</html>
