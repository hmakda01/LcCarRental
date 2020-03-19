<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomerDelete.aspx.cs" Inherits="CustomerDelete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        Are you sure you want to delete this customer?<p>
            <asp:Button ID="btnYes" runat="server" OnClick="btnYes_Click" Text="Yes" Width="60px" />
            <asp:Button ID="btnNo" runat="server" Text="No" Width="60px" />
        </p>
    </form>
</body>
</html>
