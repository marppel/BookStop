<%@ Page Title="" Language="C#" MasterPageFile="~/Navbar.Master" AutoEventWireup="true" CodeBehind="Wishlist.aspx.cs" Inherits="WebAssignment.Views.Wishlist" %>
<%@ MasterType VirtualPath="~/Navbar.Master" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <div class="container">

        <!--Main header title-->
        <div>
            <h3 class="text-primary" style="margin-top:40px">Wishlist </h3>
            <hr>
        </div>

        <!--Content-->
        <div>
            <ul class="list-group">
              <li class="list-group-item ">
                    <div class="row">
                        <div class="col-lg-3 col-md-3 col-sm-3 col-xs-3">
                            <asp:Image ID="Image1" src="../../Images/harry%20potter.jpg" runat="server" class="img-thumbnail" />
                        </div>
                        <div class="col-lg-6 col-md-6 col-sm-6 col-xs-6" style="padding:0px">
                          <asp:HyperLink ID="HyperLink1" runat="server" class="short-div h5" href="ViewProduct.aspx" Font-Underline="True" ForeColor="#3366FF">Harry Potter and the Cursed Child</asp:HyperLink>
                          <div class="short-div h6"><span>By: </span>J.K Rowling</div>
                          <div class="short-div"><span>Price: </span>$30.00</div>
                          <hr />
                          <div class="short-div">The story begins nineteen years after the events of the 2007 novel Harry Potter and the Deathly Hallows and follows Harry Potter, now Head of the Department of Magical Law Enforcement at the Ministry of Magic, and his younger son, Albus Severus Potter, who is about to attend Hogwarts School of Witchcraft and Wizardry.</div>
                          <br />
                        </div>
                        <div class="col-lg-3 col-md-3 col-sm-3 col-xs-3">
                          <asp:Button ID="btnDel" runat="server" Text="Remove" Class="btn btn-danger float-center btn-rounded" />
                        </div>
                    </div>
              </li>
            </ul>
        </div>

    </div>
</asp:Content>
