﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Car.aspx.cs" Inherits="Car" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="background-color: skyblue">    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="lblCarReg" runat="server" style="z-index: 1; left: 167px; top: 141px; position: absolute" Text="Car Reg"></asp:Label>
        <asp:Label ID="lblCarName" runat="server" style="z-index: 1; left: 156px; top: 179px; position: absolute; bottom: 466px" Text="Car Name "></asp:Label>
        <asp:Label ID="lblPrice" runat="server" style="z-index: 1; left: 186px; top: 357px; position: absolute" Text="Price"></asp:Label>
        <asp:TextBox ID="txtPrice" runat="server" style="z-index: 1; left: 246px; top: 359px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtColour" runat="server" style="z-index: 1; left: 248px; top: 269px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtCarName" runat="server" style="z-index: 1; left: 248px; top: 181px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtCarModel" runat="server" style="z-index: 1; left: 248px; top: 221px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtEngineSize" runat="server" style="z-index: 1; left: 247px; top: 315px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtCarReg" runat="server" style="z-index: 1; left: 249px; top: 141px; position: absolute"></asp:TextBox>
        <asp:Label ID="lblColour" runat="server" style="z-index: 1; left: 176px; top: 268px; position: absolute" Text="Colour"></asp:Label>
        <asp:Label ID="lblEngineSize" runat="server" style="z-index: 1; left: 153px; top: 313px; position: absolute" Text="Engine Size"></asp:Label>
        <asp:Label ID="lblCarModel" runat="server" style="z-index: 1; left: 156px; top: 219px; position: absolute" Text="Car Model"></asp:Label>
        <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 463px; top: 408px; position: absolute" Text="Cancel" OnClick="btnCancel_Click" />
        <asp:Button ID="btnOk" runat="server" OnClick="btnOk_Click" style="z-index: 1; left: 537px; top: 408px; position: absolute; width: 41px;" Text="Ok" />
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 328px; top: 457px; position: absolute" Text="success"></asp:Label>
        <asp:Button ID="btnSave" runat="server" OnClick="btnSave_Click" style="z-index: 1; left: 403px; top: 409px; position: absolute" Text="Save" />
   <asp:Label ID="Label6" runat="server" Font-Bold="True" Font-Size="40pt" style="z-index: 1; left: 17px; top: 63px; position: absolute; height: 57px; width: 283px" Text="LCCarHire"></asp:Label>
    </form>
</body>
</html>

