<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AStaff.aspx.cs" Inherits="AStaff" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="background-color: skyblue">
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="Label1" runat="server" style="z-index: 1; left: 442px; top: 170px; position: absolute; height: 25px; width: 86px" Text="First Name"></asp:Label>
        <asp:Label ID="Label2" runat="server" style="z-index: 1; left: 445px; top: 206px; position: absolute; height: 26px; width: 72px" Text="Last Name"></asp:Label>
        <asp:Label ID="Label3" runat="server" style="z-index: 1; left: 448px; top: 253px; position: absolute; right: 813px; height: 19px;" Text=" Email"></asp:Label>
        <asp:Label ID="Label4" runat="server" style="z-index: 1; left: 446px; top: 295px; position: absolute" Text="Telephone Number"></asp:Label>
        <asp:Label ID="Label5" runat="server" style="z-index: 1; left: 449px; top: 337px; position: absolute" Text="Date Of Birth"></asp:Label>
        <asp:TextBox ID="txtStaffFirstName" runat="server" style="z-index: 1; left: 630px; top: 169px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtStaffLastName" runat="server" style="z-index: 1; left: 629px; top: 208px; position: absolute"></asp:TextBox>
         <asp:TextBox ID="txtStaffEmail" runat="server" style="z-index: 1; left: 631px; top: 249px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtTelephone" runat="server" style="z-index: 1; left: 631px; top: 291px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtStaffDateOfBirth" runat="server" style="z-index: 1; left: 632px; top: 332px; position: absolute"></asp:TextBox>
        <asp:Button ID="btnOk" runat="server" style="z-index: 1; left: 439px; top: 395px; position: absolute; height: 25px; width: 83px; bottom: 442px;" Text="Ok" OnClick="btnOk_Click" />
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 810px; top: 309px; position: absolute"></asp:Label>
        <asp:Button ID="btnCancel" runat="server" OnClick="btnCancel_Click" style="z-index: 1; left: 547px; top: 395px; position: absolute; height: 25px; width: 83px;" Text="Cancel" />
        <asp:Button ID="btnSave" runat="server" OnClick="btnSave_Click" style="z-index: 1; left: 709px; top: 368px; position: absolute; height: 25px; width: 80px; right: 516px;" Text="Save" />
        <p>
        <asp:Label ID="Label6" runat="server" Font-Bold="True" Font-Size="40pt" style="z-index: 1; left: 10px; top: 80px; position: absolute; height: 57px; width: 283px" Text="LCCarHire"></asp:Label>
        </p>
    </form>
</body>
</html>
