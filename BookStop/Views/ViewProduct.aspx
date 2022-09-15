<%@ Page Title="" Language="C#" MasterPageFile="~/Navbar.Master" AutoEventWireup="true" CodeBehind="ViewProduct.aspx.cs" Inherits="WebAssignment.Views.ViewProduct" %>
<%@ MasterType VirtualPath="~/Navbar.Master" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <!-- References
        https://www.bootdey.com/snippets/view/bs4-product-detail#html
    -->
    <link rel="stylesheet" href="../CSS/Shared.css">
    <link rel="stylesheet" href="../CSS/ViewProduct.css">
    <link href="https://maxcdn.bootstrapcdn.com/font-awesome/4.7.0/css/font-awesome.min.css" rel="stylesheet">
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/3.4.1/css/bootstrap.min.css" integrity="sha384-HSMxcRTRxnN+Bdg0JdbxYKrThecOKuH5zCYotlSAcp1+c8xmyTe9GYg1l9a69psu" crossorigin="anonymous">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<div class="container">
    <div class="card">
        <div class="card-body">

            <!--Title-->
            <h3 class="card-title"></h3>
            <h6 class="card-subtitle"></h6>
            <div class="row">

                <!--Left column content-->
                <div class="col-lg-5 col-sm-6">
                    <div class="white-box text-center">
                        <asp:Image ID="PImage" src="../../Images/insert%20image.png" runat="server" class="img-thumbnail"/>
                    </div>
                </div>

                <!--Right column content-->
                <div class="col-lg-7 col-sm-6">

                    <!--Product title-->
                    <asp:Label ID="lblName" runat="server" Text="Harry Potter and the Cursed Child" class="h1"></asp:Label>
                    <br />

                    <!--Author-->
                    <label class="h2">By: </label>
                    <asp:Label ID="lblAuthor" runat="server" Text="J.K Rowling" class="h2"></asp:Label>
                    <br />
                    <br />

                    <!--Price-->
                    <asp:Label ID="lblPrice" runat="server" Text="$30.00" class="h3 mt-5"></asp:Label>
                    <br />
                    <br />
                    
                    <!--Description-->
                    <asp:Label ID="lblDesc" runat="server" Text="The story begins nineteen years after the events of the 2007 novel Harry Potter and the Deathly Hallows and follows Harry Potter, now Head of the Department of Magical Law Enforcement at the Ministry of Magic, and his younger son, Albus Severus Potter, who is about to attend Hogwarts School of Witchcraft and Wizardry."></asp:Label>
                    <br />
                    <br />

                    <!--Quantity-->
                    <asp:Label runat="server" ID="lblQty" Text="15"></asp:Label><asp:Label runat="server" ID="lblAvail" Text=" in stock"></asp:Label>
                    <hr />

                    <!--Add to Cart/Wishlist-->
                    <asp:Button ID="Button1" runat="server" Text="Add to wishlist" class="btn btn-info btn-rounded"/>
                    <asp:Button ID="Button2" runat="server" Text="Add to cart" class="btn btn-primary btn-rounded" CausesValidation="False"/>
                </div>

                <hr />
            </div>
        </div>
    </div>
</div>
<hr />
</asp:Content>
