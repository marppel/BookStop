<%@ Page Title="" Language="C#" MasterPageFile="~/Navbar.Master" AutoEventWireup="true" CodeBehind="ListProduct.aspx.cs" Inherits="WebAssignment.Views.ListProduct" %>
<%@ MasterType VirtualPath="~/Navbar.Master" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" href="../CSS/ListProduct.css"/>
    <link rel="stylesheet" href="../CSS/Shared.css">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container bootstrap snippets bootdey">
        <div class="row">

            <!--If db has no data, show this msg-->
            <asp:Label ID="lblEmpty" runat="server" Text=""></asp:Label>

            <!--Datalist for category title-->
            <div class="col-lg-3">
                <div class="card" style="margin-top:60px">
                    <h5 class="text-info text-center" style="margin-top:20px">Categories</h5>
                    <hr>
                    <asp:DataList ID="dlViewCat" runat="server" RepeatColumns="1" RepeatDirection="Vertical">
                        <ItemTemplate >
                            <div class="text-center">
                                <asp:LinkButton ID="lbCat" runat="server" Text='<%# Bind("Desc") %>' CommandName="Go" CommandArgument='<%# Eval("uniqid") %>'></asp:LinkButton>
                            </div>
                        </ItemTemplate>
                    </asp:DataList> 
                </div>
            </div>

            <!--Content-->
            <div class="col-lg-9">

                <!--Search Results-->
                <div>
                    <asp:Label ID="Label2" runat="server" Text="Total Results: " class="h5 text-primary"><span runat="server" id="totalRslt">1</span></asp:Label>
                    <hr>
                </div>

                <!--Datalist for product view-->
                <div>
                    <ul class="list-group">
                        <asp:DataList ID="dlViewProd" runat="server" RepeatColumns="1" RepeatDirection="Vertical" OnItemCommand="dlViewProd_ItemCommand">
                            <ItemTemplate >
                                 <li class="list-group-item ">
                                    <div class="row">
                                        <div class="col-lg-5 col-md-5 col-sm-7 col-xs-5">
                                            <asp:Image ID="Image2" class="card-img-top" ImageUrl='<%# Bind("filePath", "{0}") %>' runat="server" height="270px"  width="262.5px"/>  
                                        </div>
                                        <div class="col-lg-7 col-md-7 col-sm-5 col-xs-7" style="padding:0px">
                                          <asp:LinkButton ID="HyperLink1" runat="server" class="short-div h5" Font-Underline="True" ForeColor="#3366FF" Text='<%# Bind("PName") %>' CommandName="CNViewProd" CommandArgument='<%# Eval("PID") %>'></asp:LinkButton>
                                          <div class="short-div h6"><span>By: </span><asp:Label ID="Label2" runat="server" Text='<%# Bind("PAuthor") %>'></asp:Label></div>
                                          <div class="short-div"><span>Price: </span><asp:Label ID="Label1" runat="server" Text='<%# Bind("PPrice") %>'></asp:Label></div>
                                           <div class="short-div"><span>Available: </span><asp:Label ID="Label3" runat="server" Text='<%# Bind("stkQty") %>'></asp:Label></div>
                                          <hr />
                                          <div class="short-div">The story begins nineteen years after the events of the 2007 novel Harry Potter and the Deathly Hallows and follows Harry Potter, now Head of the Department of Magical Law Enforcement at the Ministry of Magic, and his younger son, Albus Severus Potter, who is about to attend Hogwarts School of Witchcraft and Wizardry.</div>
                                          <br /> 
                                        </div>
                                    </div>
                                </li>
                            </ItemTemplate>
                        </asp:DataList>
                    </ul>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
