<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomerList.aspx.cs" Inherits="CustomerList" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:ListBox ID="lstCustomer" runat="server" Height="265px" Width="341px"></asp:ListBox>
        <p>
            <asp:Label ID="lblError" runat="server"></asp:Label>
        </p>
        <p>
            <asp:Label ID="Label2" runat="server" Text="Please Enter a Customer Username"></asp:Label>
        </p>
        <asp:TextBox ID="txtUsername" runat="server" Width="199px"></asp:TextBox>
        <p>
            <asp:Button ID="btnApply" runat="server" Text="Apply" />
            <asp:Button ID="btnDisplayAll" runat="server" Text="Display All" />
        </p>
        <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" Text="Add" Width="48px" />
        <asp:Button ID="btnEdit" runat="server" OnClick="btnEdit_Click" Text="Edit" Width="48px" />
        <asp:Button ID="btnDelete" runat="server" OnClick="btnDelete_Click" Text="Delete" />
    </form>
</body>
</html>
