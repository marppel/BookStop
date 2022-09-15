<%@ Page Title="" Language="C#" MasterPageFile="~/NavbarAdmin.Master" AutoEventWireup="true" CodeBehind="AddItem.aspx.cs" Inherits="WebAssignment.Views.Admin.AddItem" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" href="../../CSS/Profile.css"/>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container bootstrap snippets bootdey">
    <h1 class="text-primary">Add Product</h1>
      <hr>
	<div class="row">

      <!--Left column image insert-->
      <div class="col-lg-4 col-md-4 col-sm-4 col-xs-4">
        <div class="text-center">
          <img src="../../Images/insert%20image.png" runat="server" class="avatar img-circle img-thumbnail" alt="avatar">
           <asp:Label ID="imgName" runat="server" Text="" CssClass="col-lg-5"></asp:Label>
            <br />   
            <h6>Upload photo</h6>
            <asp:FileUpload ID="FileUpload" runat="server" CssClass="" />
        </div>
      </div>
      
      <!--Alert-->
      <div class="col-lg-8 col-md-8 col-sm-8 col-xs-8 personal-info">

        <!--Content info-->
        <div>
          <div class="form-group">
            <label class="col-lg-3 col-md-3 col-sm-3 col-xs-3 control-label">Name:</label>
            <div class="col-lg-8 col-md-8 col-sm-8 col-xs-8">
              <asp:TextBox ID="txtPName" runat="server" class="form-control" placeholder="Enter product name"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Name is required" ControlToValidate="txtPName" ForeColor="Red"></asp:RequiredFieldValidator>
            </div>
          </div>
          <div class="form-group">
            <label class="col-lg-3 col-md-3 col-sm-3 col-xs-3 control-label">Author:</label>
            <div class="col-lg-8 col-md-8 col-sm-8 col-xs-8">
                <asp:TextBox ID="txtPAuthor" runat="server" class="form-control" placeholder="Enter author name"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ErrorMessage="Author is required" ControlToValidate="txtPAuthor" ForeColor="Red"></asp:RequiredFieldValidator>
            </div>
          </div>
          <div class="form-group">
            <label class="col-lg-3 col-md-3 col-sm-3 col-xs-3 control-label">Description:</label>
            <div class="col-lg-8 col-md-8 col-sm-8 col-xs-8">
              <asp:TextBox ID="txtPDesc" runat="server" class="form-control" placeholder="Enter product description"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Description is required" ControlToValidate="txtPDesc" ForeColor="Red"></asp:RequiredFieldValidator>
            </div>
          </div>
          <div class="form-group">
            <label class="col-lg-3 col-md-3 col-sm-3 col-xs-3 control-label">Price ($):</label>
            <div class="col-lg-8 col-md-8 col-sm-8 col-xs-8">
              <asp:TextBox ID="txtPPrice" runat="server" class="form-control" placeholder="Enter product price"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="Price is required" ControlToValidate="txtPPrice" ForeColor="Red"></asp:RequiredFieldValidator>
                <br />
                <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ErrorMessage="Please enter a valid price" ControlToValidate="txtPPrice" ForeColor="Red" ValidationExpression="^\d+(,\d{1,2})?$"></asp:RegularExpressionValidator>
            </div>
          </div>
          <div class="form-group">
            <label class="col-lg-3 col-md-3 col-sm-3 col-xs-3 control-label">Stock Quantity:</label>
            <div class="col-lg-8 col-md-8 col-sm-8 col-xs-8">
              <asp:TextBox ID="txtStockQty" runat="server" class="form-control" placeholder="Enter stock quantity"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="Stock quantity is required" ControlToValidate="txtStockQty" ForeColor="Red"></asp:RequiredFieldValidator>
                <br />
                <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ErrorMessage="Please enter a numeric number" ControlToValidate="txtStockQty" ValidationExpression="^\d+$" ForeColor="Red"></asp:RegularExpressionValidator>
            </div>
          </div>
          <div class="form-group">
            <label class="col-lg-3 col-md-3 col-sm-3 col-xs-3 control-label">Category:</label>
            <div class="col-lg-8 col-md-8 col-sm-8 col-xs-8">
                <asp:DropDownList ID="ddlCat" runat="server">
                </asp:DropDownList>
            </div>
              <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ErrorMessage="Please select a category" ControlToValidate="ddlCat" ForeColor="Red"></asp:RequiredFieldValidator>
          </div>
         <div class="form-group col-lg-12">
                <asp:Button ID="btnCancel" runat="server" Text="Cancel" class="btn btn-danger" CausesValidation="False" OnClick="btnCancel_Click" UseSubmitBehavior="False" />
                <asp:Button ID="btnAdd" runat="server" Text="Add" class=" btn btn-success btn-rounded" OnClick="btnAdd_Click"/>
          </div>
        </div>
      </div>
  </div>
</div>
<hr>
</asp:Content>
