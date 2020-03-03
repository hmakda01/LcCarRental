﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Order.aspx.cs" Inherits="Order" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="lblCarReg" runat="server" Text="Car Reg"></asp:Label>
        <asp:TextBox ID="TxtBCarReg" runat="server"></asp:TextBox>
        <p>
            <asp:Label ID="lblCustomerID" runat="server" Text="CustomerID"></asp:Label>
            <asp:TextBox ID="TxtbCustomerID" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="LblOrderId" runat="server" Text="OrderId"></asp:Label>
            <asp:TextBox ID="TxtBOrderID" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="lblStaffID" runat="server" Text="StaffID"></asp:Label>
            <asp:TextBox ID="txtbStaffId" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="lblDate" runat="server" Text="Date"></asp:Label>
            <asp:TextBox ID="TxtBDate" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="lblEmail" runat="server" Text="Email"></asp:Label>
            <asp:TextBox ID="TxtBEmail" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="lblPrice" runat="server" Text="Price"></asp:Label>
            <asp:TextBox ID="TxtBPrice" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="LblError1" runat="server" Text="[lblError]"></asp:Label>
        </p>
        <p>
            <asp:Button ID="BtnOK" runat="server" Text="Ok" OnClick="BtnOK_Click" />
            <asp:Button ID="BtnCancel" runat="server" style="margin-left: 30px" Text="Cancel" />
        </p>
    </form>
</body>
</html>
