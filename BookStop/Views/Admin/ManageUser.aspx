<%@ Page Title="" Language="C#" MasterPageFile="~/NavbarAdmin.Master" AutoEventWireup="true" CodeBehind="ManageUser.aspx.cs" Inherits="WebAssignment.Views.ManageUser" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <!--Title-->
        <div>
            <h5 class="text-primary" style="margin-top:40px">User List</h5>
            <hr>
        </div>

        <!--Content-->
        <div>
            <ul class="list-group">
              <li class="list-group-item ">
                    <div class="row">
                        <div class="col-lg-6 col-md-6 col-sm-6 col-xs-6">
                            <asp:Label ID="Label1" runat="server" Text="Helena Eveland"></asp:Label>
                        </div>
                        <div class="col-lg-6 col-md-6 col-sm-6 col-xs-6">
                          <asp:Button ID="btnEnable" runat="server" Text="Enable" Class="btn btn-success float-center" CausesValidation="False"/>
                          <asp:Button ID="btnDisable" runat="server" Text="Disable" Class="btn btn-danger float-center" CausesValidation="False" OnClick="btnDisable_Click" />
                        </div>
                    </div>
              </li>
              <li class="list-group-item ">
                    <div class="row">
                        <div class="col-lg-6 col-md-6 col-sm-6 col-xs-6">
                            <asp:Label ID="Label2" runat="server" Text="Ike Samson"></asp:Label>
                        </div>
                        <div class="col-lg-6 col-md-6 col-sm-6 col-xs-6">
                          <asp:Button ID="Button1" runat="server" Text="Enable" Class="btn btn-success float-center" CausesValidation="False"/>
                          <asp:Button ID="Button2" runat="server" Text="Disable" Class="btn btn-danger float-center" CausesValidation="False" OnClick="btnDisable_Click" />
                        </div>
                    </div>
              </li>
            </ul>
        </div>
    </div>
</asp:Content>
