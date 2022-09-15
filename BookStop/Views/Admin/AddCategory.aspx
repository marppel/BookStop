<%@ Page Title="" Language="C#" MasterPageFile="~/NavbarAdmin.Master" AutoEventWireup="true" CodeBehind="AddCategory.aspx.cs" Inherits="WebAssignment.Views.Admin.AddCategory" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" href="../../CSS/Profile.css"/>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <!--Title-->
    <div class="container bootstrap snippets bootdey">
    <h1 class="text-primary">Add Category</h1>
      <hr>
        <asp:Label runat="server" ID="lblMsg"></asp:Label>
	<div class="row">
      <asp:Label runat="server" ID="lblErr"></asp:Label>

      <!-- Alert -->
      <div class="col-lg-12 col-md-12 col-sm-12 col-xs-12 personal-info" >
          <asp:Label runat="server" ID="lblCatAddErr"></asp:Label>
        
        <!--Content-->
        <div>
          <div class="form-group">
            <label class="col-lg-3 col-md-3 col-sm-3 col-xs-3 control-label">Category ID:</label>
            <div class="col-lg-8 col-md-8 col-sm-8 col-xs-8">
              <asp:TextBox ID="txtID" runat="server" class="form-control" placeholder="Eg. ABC123"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="ID is required" ControlToValidate="txtID" ForeColor="Red"></asp:RequiredFieldValidator>
            </div>
          </div>
          <div class="form-group">
            <label class="col-lg-3 col-md-3 col-sm-3 col-xs-3 control-label">Description:</label>
            <div class="col-lg-8 col-md-8 col-sm-8 col-xs-8">
              <asp:TextBox ID="txtDesc" runat="server" class="form-control" placeholder="Eg. Children's Books"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Description is required" ControlToValidate="txtDesc" ForeColor="Red"></asp:RequiredFieldValidator>
            </div>
          </div>
         <div class="form-group col-lg-12 col-md-12 col-sm-12 col-xs-12 form-group">
             <asp:Button ID="btnCancel" runat="server" Text="Cancel" class="btn btn-danger" CausesValidation="False" OnClick="btnCancel_Click" UseSubmitBehavior="False"/>
             <asp:Button ID="btnAdd" runat="server" Text="Add" class="btn btn-success" OnClick="btnAdd_Click"/>
          </div>
        </div>
      </div>
  </div>
</div>
<hr>
</asp:Content>
