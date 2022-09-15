<%@ Page Title="" Language="C#" MasterPageFile="~/Navbar.Master" AutoEventWireup="true" CodeBehind="Profile.aspx.cs" Inherits="WebAssignment.Views.Profile" %>
<%@ MasterType VirtualPath="~/Navbar.Master" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <!--Reference
        bootdey.com/snippets/view/edit-profile-form#html
        -->
    <link rel="stylesheet" href="../CSS/Profile.css"/>
    <link rel="stylesheet" href="../CSS/Shared.css">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
    <h1 class="text-primary">Update Profile</h1>
      <hr>
        <asp:Label ID="lblMsg" runat="server" Text=""></asp:Label>

        <!--profile info-->
        <div>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Email is required" ControlToValidate="txtEmail" ForeColor="Red"></asp:RequiredFieldValidator>
            <br />
            <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ErrorMessage="This is not a valid email address" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" ControlToValidate="txtEmail" ForeColor="Red"></asp:RegularExpressionValidator>
            <br />
          <div class="row">
            <label class="col-lg-3 col-md-3 col-sm-3 col-xs-3 control-label">Email:</label>
            <div class="col-lg-8 col-md-8 col-sm-8 col-xs-8">
              <asp:TextBox ID="txtEmail" runat="server" class="form-control" placeholder="Enter new email" ReadOnly ="true"></asp:TextBox>
            </div>
          </div>
          <div class="row">
            <label class="col-lg-3 col-md-3 col-sm-3 col-xs-3 control-label">Name:</label>
            <div class="col-lg-8 col-md-8 col-sm-8 col-xs-8">
              <asp:TextBox ID="txtName" runat="server" class="form-control" placeholder="Enter your name"></asp:TextBox>
            </div>
          </div>
          <div class="row">
            <label class="col-lg-3 col-md-3 col-sm-3 col-xs-3 control-label">Address:</label>
            <div class="col-lg-8 col-md-8 col-sm-8 col-xs-8">
              <asp:TextBox ID="txtAddress" runat="server" class="form-control" placeholder="Enter new address"></asp:TextBox>
            </div>
          </div>
          <div class="row">
            <label class="col-lg-3 col-md-3 col-sm-3 col-xs-3 control-label">Postal Code:</label>
            <div class="col-lg-8 col-md-8 col-sm-8 col-xs-8">
              <asp:TextBox ID="txtPostal" runat="server" class="form-control" placeholder="Enter 6 digit postal code"></asp:TextBox>
            </div>
          </div>
          <div class="row">
            <label class="col-lg-3 col-md-3 col-sm-3 col-xs-3 control-label">Country:</label>
            <div class="col-lg-8 col-md-8 col-sm-8 col-xs-8">
              <asp:TextBox ID="txtCnty" runat="server" class="form-control" placeholder="Enter country"></asp:TextBox>
            </div>
          </div>
         <div class="row">
                <asp:Button ID="btnUpdate" runat="server" Text="Update" class="col-lg-12 col-md-12 col-sm-12 col-xs-12 btn btn-success btn-rounded" OnClick="btnUpdate_Click"/>
          </div>
        </div>

      </div>
<hr>
</asp:Content>
