<%@ Page Title="" Language="C#" MasterPageFile="~/Navbar.Master" AutoEventWireup="true" CodeBehind="About.aspx.cs" Inherits="WebAssignment.Views.About" %>
<%@ MasterType VirtualPath="~/Navbar.Master" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
     <link rel="stylesheet" href="../CSS/Shared.css">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <!--Content-->
    <div class="card" style="margin:30px; border:none;">
        <div class="row d-flex justify-content-center">
            <h2>A bookshop website that sells all your reading needs. Purchase your favourite titles here!</h2>
        </div>
        <div class="row d-flex justify-content-center">
            <h3>Created: 31/1/2022 by Marabel Bei Yi Kwok</h3>
        </div>
    </div>
</asp:Content>
