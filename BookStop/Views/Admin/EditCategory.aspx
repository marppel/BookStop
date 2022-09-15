<%@ Page Title="" Language="C#" MasterPageFile="~/NavbarAdmin.Master" AutoEventWireup="true" CodeBehind="EditCategory.aspx.cs" Inherits="WebAssignment.Views.Admin.EditCategory" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <!--Title-->
    <div class="container bootstrap snippets bootdey">
    <h1 class="text-primary">Edit Category</h1>
      <hr>
	<div class="row">
      
        <!-- Alert -->
      <div class="col-lg-12 col-md-12 col-sm-12 col-xs-12 personal-info" >
        <asp:Label runat="server" ID="lblCatEditErr"></asp:Label>
        
        <!--Content-->
        <div>
          <div class="form-group">
            <label class="col-lg-3 col-md-3 col-sm-3 col-xs-3 control-label">Category ID:</label>
            <div class="col-lg-8 col-md-8 col-sm-8 col-xs-8">
              <asp:TextBox ID="txtID" runat="server" class="form-control" placeholder="Eg. ABC123"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="ID cannot be empty" ControlToValidate="txtID" ForeColor="Red"></asp:RequiredFieldValidator>
            </div>
          </div>
          <div class="form-group">
            <label class="col-lg-3 col-md-3 col-sm-3 col-xs-3 control-label">Description:</label>
            <div class="col-lg-8 col-md-8 col-sm-8 col-xs-8">
              <asp:TextBox ID="txtDesc" runat="server" class="form-control" placeholder="Eg. Children's Books"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Description cannot be empty" ControlToValidate="txtDesc" ForeColor="Red"></asp:RequiredFieldValidator>
            </div>
          </div>
         <div class="form-group col-lg-12 col-md-12 col-sm-12 col-xs-12">
            <asp:Button ID="btnCancel" runat="server" Text="Cancel" class="btn btn-danger" CausesValidation="False" UseSubmitBehavior="False" OnClick="btnCancel_Click"/>
            <asp:Button ID="btnUpdate" runat="server" Text="Update" Class=" btn btn-success btn-rounded" OnClick="btnUpdate_Click"/>
          </div>
        </div>

      </div>
  </div>
</div>
<hr>
</asp:Content>
