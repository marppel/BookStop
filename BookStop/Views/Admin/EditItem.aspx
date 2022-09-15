<%@ Page Title="" Language="C#" MasterPageFile="~/NavbarAdmin.Master" AutoEventWireup="true" CodeBehind="EditItem.aspx.cs" Inherits="WebAssignment.Views.Admin.EditItem" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" href="../../CSS/Profile.css"/>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<div class="container bootstrap snippets bootdey">
    <div class="container bootstrap snippets bootdey">
    <h1 class="text-primary">Edit Product</h1>
      <hr>
	<div class="row">
      <!--Left column image insert-->
      <div class="col-lg-4 col-md-4 col-sm-4 col-xs-4">
        <div class="text-center">
          <img id="PImage" src="../../Images/insert%20image.png" runat="server" class="avatar img-circle img-thumbnail img-fluid" alt="avatar">
           <asp:Label ID="imgName" runat="server" Text="" CssClass="col-lg-5"></asp:Label>
            <br />   
            <h6>Upload new photo</h6>
            <asp:FileUpload ID="FileUpload" runat="server" CssClass="" />
        </div>
      </div>
      
      <!--Alert-->
      <div class="col-lg-8 col-md-8 col-sm-8 col-xs-8 personal-info">

        <!--Right column content info-->
        <div>
          <div class="form-group">
            <label class="col-lg-3 col-md-3 col-sm-3 col-xs-3 control-label">Name:</label>
            <div class="col-lg-8 col-md-8 col-sm-8 col-xs-8">
              <asp:TextBox ID="txtPName" runat="server" class="form-control" placeholder="Enter product name"></asp:TextBox>
              <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Name cannot be empty" ForeColor="Red" ControlToValidate="txtPName"></asp:RequiredFieldValidator>
            </div>
          </div>
          <div class="form-group">
            <label class="col-lg-3 col-md-3 col-sm-3 col-xs-3 control-label">Author:</label>
            <div class="col-lg-8 col-md-8 col-sm-8 col-xs-8">
                <asp:TextBox ID="txtPAuthor" runat="server" class="form-control" placeholder="Enter author name"></asp:TextBox>
            </div>
          </div>
          <div class="form-group">
            <label class="col-lg-3 col-md-3 col-sm-3 col-xs-3 control-label">Description:</label>
            <div class="col-lg-8 col-md-8 col-sm-8 col-xs-8">
              <asp:TextBox ID="txtPDesc" runat="server" class="form-control" placeholder="Enter product description"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Description cannot be empty" ForeColor="Red" ControlToValidate="txtPDesc"></asp:RequiredFieldValidator>
            </div>
          </div>
          <div class="form-group">
            <label class="col-lg-3 col-md-3 col-sm-3 col-xs-3 control-label">Price ($):</label>
            <div class="col-lg-8 col-md-8 col-sm-8 col-xs-8">
              <asp:TextBox ID="txtPPrice" runat="server" class="form-control" placeholder="Enter product price"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="Price cannot be empty" ControlToValidate="txtPPrice" ForeColor="Red"></asp:RequiredFieldValidator>
            </div>
          </div>
          <div class="form-group">
            <label class="col-lg-3 col-md-3 col-sm-3 col-xs-3 control-label">Stock Quantity:</label>
            <div class="col-lg-8 col-md-8 col-sm-8 col-xs-8">
              <asp:TextBox ID="txtStockQty" runat="server" class="form-control" placeholder="Enter stock quantity"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="Stock quantity cannot be empty" ForeColor="Red" ControlToValidate="txtStockQty"></asp:RequiredFieldValidator>
            </div>
          </div>
          <div class="form-group">
            <label class="col-lg-3 col-md-3 col-sm-3 col-xs-3 control-label">Category:</label>
            <div class="col-lg-8 col-md-8 col-sm-8 col-xs-8">
                <asp:DropDownList ID="ddlCat" runat="server">
                </asp:DropDownList>
            </div>
          </div>
         <div class="form-group">
                <asp:Button ID="btnCancel" runat="server" Text="Cancel" class="btn btn-danger btn-rounded" OnClick="btnCancel_Click" CausesValidation="False" UseSubmitBehavior="False"/>
                <asp:Button ID="btnUpdate" runat="server" Text="Update" class="btn btn-success btn-rounded" OnClick="btnUpdate_Click"/>
          </div>
        </div>
      </div>
  </div>
</div>
</div>
<hr>
</asp:Content>
