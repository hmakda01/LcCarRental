<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AStaff.aspx.cs" Inherits="AStaff" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="Label1" runat="server" style="z-index: 1; left: 53px; top: 111px; position: absolute; height: 25px; width: 86px" Text="First Name"></asp:Label>
        <asp:Label ID="Label2" runat="server" style="z-index: 1; left: 51px; top: 162px; position: absolute; height: 26px; width: 72px" Text="Last Name"></asp:Label>
        <asp:Label ID="Label3" runat="server" style="z-index: 1; left: 52px; top: 211px; position: absolute; right: 1400px;" Text=" Email"></asp:Label>
        <asp:Label ID="Label4" runat="server" style="z-index: 1; left: 53px; top: 258px; position: absolute" Text="Telephone Number"></asp:Label>
        <asp:Label ID="Label5" runat="server" style="z-index: 1; left: 56px; top: 304px; position: absolute" Text="Date Of Birth"></asp:Label>
        <asp:TextBox ID="txtFirstName" runat="server" style="z-index: 1; left: 148px; top: 112px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtStaffFirstName" runat="server" style="z-index: 1; left: 148px; top: 112px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtStaffLastName" runat="server" style="z-index: 1; left: 150px; top: 165px; position: absolute"></asp:TextBox>
         <asp:TextBox ID="txtStaffEmail" runat="server" style="position: relative; top: 182px; left: 145px"></asp:TextBox>
        <asp:TextBox ID="txtTelephone" runat="server" style="z-index: 1; left: 183px; top: 258px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtStaffDateOfBirth" runat="server" style="z-index: 1; left: 178px; top: 305px; position: absolute"></asp:TextBox>
        <asp:Button ID="btnOk" runat="server" style="z-index: 1; left: 165px; top: 385px; position: absolute; height: 25px; width: 50px;" Text="Ok" OnClick="btnOk_Click" />
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 58px; top: 361px; position: absolute"></asp:Label>
        <asp:Label ID="Label6" runat="server" style="z-index: 1; left: 56px; top: 72px; position: absolute" Text="Staff Id"></asp:Label>
        <asp:TextBox ID="txtStaffId" runat="server" style="z-index: 1; left: 136px; top: 71px; position: absolute"></asp:TextBox>
    </form>
</body>
</html>
