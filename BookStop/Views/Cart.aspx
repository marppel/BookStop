<%@ Page Title="" Language="C#" MasterPageFile="~/Navbar.Master" AutoEventWireup="true" CodeBehind="Cart.aspx.cs" Inherits="WebAssignment.Views.Cart" %>
<%@ MasterType VirtualPath="~/Navbar.Master" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <!--Reference
        https://www.bootdey.com/snippets/view/shopping-cart-checkout
        -->
    <link rel="stylesheet" href="../CSS/Cart.css"/>
    <link href="https://maxcdn.bootstrapcdn.com/font-awesome/4.3.0/css/font-awesome.min.css" rel="stylesheet">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<div class="container">
    <!--Cart item-->
<div class="wrapper wrapper-content animated fadeInRight">
    <div class="row">
        <div class="col-md-9">
            <div class="ibox">

                <!--Header-->
                <div class="ibox-title">
                    <span class="pull-right"><asp:Label ID="Label6" runat="server" Text="(<strong>1</strong>) items"></asp:Label></span>
                    <h5>Items in your cart</h5>
                </div>

                <!--Content-->
                <div class="ibox-content">
                    <div class="table-responsive">
                        <table class="table shoping-cart-table">

                            <!--List view-->
                            <tbody>
                            <tr>
                                <td width="90">
                                    <div class="cart-product-imitation">
                                    </div>
                                </td>
                                <td class="desc">
                                    <h3>
                                    <a href="#" class="text-navy">
                                        <asp:Label ID="Label1" runat="server" href="ViewProduct.aspx" Text="Harry Potter and the Cursed Child"></asp:Label>
                                    </a>
                                    </h3>
                                    <div class="m-t-sm">
                                        <a href="#" class="text-muted"><i class="fa fa-trash"></i> Remove item</a>
                                    </div>
                                </td>

                                <td>
                                    <asp:Label ID="Label7" runat="server" Text="$180,00"></asp:Label>
                                    <!--<asp:Label ID="Label8" runat="server" Text="$230,00" Class="small text-muted" style="text-decoration: line-through;"></asp:Label>-->
                                </td>
                                <td width="65">
                                    <asp:TextBox ID="TextBox1" runat="server" class="form-control">1</asp:TextBox>
                                </td>
                                <td>
                                    <h4>
                                        <asp:Label ID="Label4" runat="server" Text="$180,00"></asp:Label>
                                    </h4>
                                </td>
                            </tr>
                            </tbody>

                        </table>
                    </div>

                </div>

                <!--Continue shoppinf-->
                <div class="ibox-content">
                    <asp:Button ID="btnContShop" runat="server" Text="Continue shopping" Class="btn btn-white btn-rounded" OnClick="btnContShop_Click"/>
                </div>
            </div>

            <!--shipping information-->
        </div>
        <div class="col-md-3">
            <div class="ibox">
                <div class="ibox-title">
                    <h5>Shipping information</h5>
                </div>
                <div class="ibox-content">
                    <asp:Label ID="Label2" runat="server" Text="Name:" class=""></asp:Label>
                    <asp:TextBox ID="txtInName" runat="server" placeholder="Enter name"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Name is required" ControlToValidate="txtInName" ForeColor="Red"></asp:RequiredFieldValidator>

                    <asp:Label ID="Label3" runat="server" Text="Address:" class=""></asp:Label>
                    <asp:TextBox ID="txtInAddress" runat="server" placeholder="Full shipping address"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Address is required" ControlToValidate="txtInAddress" ForeColor="Red"></asp:RequiredFieldValidator>

                    <br />
                    <asp:Label ID="Label5" runat="server" Text="Postal Code:" class=""></asp:Label>
                    <asp:TextBox ID="txtInPostCode" runat="server" placeholder="Postal code"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="Postal Code is required" ControlToValidate="txtInPostCode" ForeColor="Red"></asp:RequiredFieldValidator>

                    <asp:Label ID="lblCnty" runat="server" Text="Country:" class=""></asp:Label>
                    <asp:TextBox ID="txtInCnty" runat="server" placeholder="Enter country"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="Country is required" ControlToValidate="txtInCnty" ForeColor="Red"></asp:RequiredFieldValidator>

                </div>
            </div>

            <!--Total amount + Checkout-->
            <div class="ibox">
                <div class="ibox-title">
                    <h5>Cart Summary</h5>
                </div>
                <div class="ibox-content">
                    <span>
                        Total
                    </span>
                    <asp:Label ID="Label9" runat="server" Text="$180,00" class="h2 font-bold"></asp:Label>
                    <hr>
                    <div class="m-t-sm">
                        <div class="btn-group">
                        <asp:Button ID="btnCheckout2" runat="server" Text="Checkout" Class="btn btn-primary pull-right btn-rounded" OnClick="btnCheckout2_Click" />
                        </div>
                    </div>
                </div>
            </div>

        </div>
    </div>
</div>
</div>
</asp:Content>
