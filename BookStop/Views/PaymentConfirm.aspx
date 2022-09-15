<%@ Page Title="" Language="C#" MasterPageFile="~/Navbar.Master" AutoEventWireup="true" CodeBehind="PaymentConfirm.aspx.cs" Inherits="WebAssignment.Views.PaymentConfirm" %>
<%@ MasterType VirtualPath="~/Navbar.Master" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" href="../CSS/Shared.css">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <!--Content-->
    <div class="card" style="margin:30px; border:none;">
        <div class="row d-flex justify-content-center">
            <h2>Thank you for shopping with us!</h2>
        </div>
        <div class="row d-flex justify-content-center">
            <h2>A confirmation email will be sent to your email</h2>
        </div>
        <div class="row d-flex justify-content-center" style="padding-top:10px;">
           <asp:Button ID="btnContShop" runat="server" Text="Continue shopping" class="btn btn-primary btn-rounded" OnClick="btnContShop_Click"/>
        </div>
    </div>
</asp:Content>
