<%@ Page Title="" Language="C#" MasterPageFile="~/Navbar.Master" AutoEventWireup="true" CodeBehind="Contact.aspx.cs" Inherits="WebAssignment.Views.Contact" %>
<%@ MasterType VirtualPath="~/Navbar.Master" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" href="../CSS/Shared.css">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <!--Content-->
    <div class="card" style="margin:30px; border:none;">
        <div class="row d-flex justify-content-center">
            <h2>If you have any issues with placing an order, please contact:</h2>
        </div>
        <div class="row d-flex justify-content-center">
            <h4>Email: BookStopAdmin@gmail.com</h4>
        </div>
    </div>
        <div class="card" style="margin:30px; border:none;">
        <div class="row d-flex justify-content-center">
            <h2>If you have any issues with the website, please contact:</h2>
        </div>
        <div class="row d-flex justify-content-center">
            <h4>Email: BookStopDeveloper@gmail.com</h4>
        </div>
    </div>
</asp:Content>
