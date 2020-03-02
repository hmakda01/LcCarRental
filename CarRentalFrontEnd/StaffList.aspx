<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StaffList.aspx.cs" Inherits="StaffList" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:ListBox ID="lstStaff" runat="server" OnSelectedIndexChanged="lstStaff_SelectedIndexChanged" style="z-index: 1; left: 138px; top: 117px; position: absolute; height: 171px; width: 299px"></asp:ListBox>
        </div>
        <asp:Button ID="btnDelete" runat="server" style="z-index: 1; top: 411px; position: absolute; height: 30px; width: 90px; left: 342px" Text="Delete" OnClick="btnDelete_Click" />
        <asp:Button ID="btnAdd" runat="server" style="z-index: 1; left: 116px; top: 410px; position: absolute; height: 30px; width: 99px; right: 992px" Text="Add" OnClick="btnAdd_Click" />
        <asp:Button ID="btnEdit" runat="server" style="z-index: 1; top: 411px; position: absolute; height: 30px; width: 90px; left: 237px; bottom: 421px" Text="Edit" OnClick="btnEdit_Click" />
        <asp:Button ID="btnApply" runat="server" style="z-index: 1; left: 127px; top: 363px; position: absolute; height: 26px; width: 100px; margin-bottom: 1px" Text="Apply" OnClick="btnApply_Click" />
        <asp:Button ID="btnDisplayAll" runat="server" style="z-index: 1; left: 277px; top: 367px; position: absolute; height: 26px; width: 100px" Text="Display All" />
        <p>
            &nbsp;</p>
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 394px; top: 475px; position: absolute"></asp:Label>
        <asp:TextBox ID="txtStaffLastName" runat="server" style="z-index: 1; left: 139px; top: 329px; position: absolute; height: 15px; width: 272px"></asp:TextBox>
    </form>
</body>
</html>
