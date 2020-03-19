<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StaffList.aspx.cs" Inherits="StaffList" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="background-color: skyblue">
    <form id="form1" runat="server">
        <div>
            <asp:ListBox ID="lstStaff" runat="server" OnSelectedIndexChanged="lstStaff_SelectedIndexChanged" style="z-index: 1; left: 383px; top: 192px; position: absolute; height: 217px; width: 362px"></asp:ListBox>
        </div>
        <asp:Button ID="btnDelete" runat="server" style="z-index: 1; top: 523px; position: absolute; height: 30px; width: 90px; left: 626px" Text="Delete" OnClick="btnDelete_Click" BackColor="White" />
        <asp:Button ID="btnAdd" runat="server" style="z-index: 1; left: 425px; top: 523px; position: absolute; height: 30px; width: 90px; right: 790px" Text="Add" OnClick="btnAdd_Click" BackColor="White" />
        <asp:Button ID="btnEdit" runat="server" style="z-index: 1; top: 523px; position: absolute; height: 30px; width: 90px; left: 525px; bottom: 111px" Text="Edit" OnClick="btnEdit_Click" BackColor="White" />
        <asp:Label ID="Label3" runat="server" style="z-index: 1; left: 430px; top: 416px; position: absolute; right: 672px" Text="Please Enter the Staff Last Name:"></asp:Label>
        <asp:Button ID="btnApply" runat="server" style="z-index: 1; left: 426px; top: 475px; position: absolute; height: 26px; width: 100px; margin-bottom: 1px; right: 779px;" Text="Apply" OnClick="btnApply_Click" BackColor="White" ForeColor="Black" />
        <asp:Button ID="btnDisplayAll" runat="server" style="z-index: 1; left: 617px; top: 477px; position: absolute; height: 26px; width: 100px" Text="Display All" OnClick="btnDisplayAll_Click" BackColor="White" />
        <p>
            &nbsp;</p>
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 420px; top: 574px; position: absolute" ForeColor="Red"></asp:Label>
        <asp:TextBox ID="txtStaffLastName" runat="server" style="z-index: 1; left: 427px; top: 440px; position: absolute; height: 15px; width: 272px" BackColor="White"></asp:TextBox>
        <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="40pt" style="z-index: 1; left: 9px; top: 96px; position: absolute; height: 57px; width: 283px" Text="LCCarHire"></asp:Label>
        <asp:Label ID="Label2" runat="server" Font-Bold="True" Font-Size="30pt" style="z-index: 1; left: 460px; top: 137px; position: absolute" Text="Staff Page"></asp:Label>
    </form>
</body>
</html>
