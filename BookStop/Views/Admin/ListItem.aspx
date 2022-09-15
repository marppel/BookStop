<%@ Page Title="" Language="C#" MasterPageFile="~/NavbarAdmin.Master" AutoEventWireup="true" CodeBehind="ListItem.aspx.cs" Inherits="WebAssignment.Views.Admin.ViewItem" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <!--
        https://getbootstrap.com/docs/4.0/components/list-group/
        -->
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">

        <!--Title-->
        <div>
            <h3 class="text-primary" style="margin-top:40px; display:inline-block;"">Product List </h3>&nbsp;&nbsp;
            <span><asp:Button ID="btnAddNew" runat="server" Text="Add" class="btn btn-info" CausesValidation="False" OnClick="btnAddNew_Click" UseSubmitBehavior="False"/></span>
            <hr>
            
        </div>

        <!--Content-->
        <!--GridView-->
        <div class="row">
            <asp:Label ID="lblNoItem" runat="server" Text="" class="text-center"></asp:Label>
            <div class="col-12">
                <asp:GridView ID="GVProduct" runat="server" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" DataKeyNames="PID" OnSelectedIndexChanged ="GVProduct_SelectedIndexChanged" OnRowDeleting="GVProduct_RowDeleting">
                    <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                    <Columns>
                        <asp:BoundField HeaderText="ID" DataField="PID" ReadOnly="true"/>
                        <asp:ImageField HeaderText="Image" DataImageUrlField="filePath" NullImageUrl="~/images/insert image.png">
                        <ControlStyle Height="163px" Width="130px" />
                        </asp:ImageField>
                        <asp:BoundField HeaderText="Name" DataField="PName" ReadOnly="true"/>
                        <asp:BoundField HeaderText="Author" DataField="PAuthor" ReadOnly="true" />
                        <asp:BoundField HeaderText="Description" DataField="PDesc" ReadOnly="true" />
                        <asp:BoundField HeaderText="Category" DataField="CatDesc" ReadOnly="true" />
                        <asp:BoundField HeaderText="Price" DataField="PPrice" ReadOnly="true" />
                        <asp:BoundField HeaderText="Stock Quantity" DataField="stkQty" ReadOnly="true" />
                        <asp:CommandField SelectText="Edit" ShowSelectButton="true"/>
                        <asp:CommandField ShowDeleteButton="True"/>  
                    </Columns>
                    <EditRowStyle BackColor="#999999" />
                    <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                    <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                    <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
                    <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
                    <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                    <SortedAscendingCellStyle BackColor="#E9E7E2" />
                    <SortedAscendingHeaderStyle BackColor="#506C8C" />
                    <SortedDescendingCellStyle BackColor="#FFFDF8" />
                    <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
                </asp:GridView>
            </div>
        </div>

        <!-- Unused listGroup
        <div>
            <ul class="list-group">
              <li class="list-group-item ">
                    <div class="row">
                        <div class="col-lg-3 col-md-3 col-sm-3 col-xs-3">
                            <asp:Image ID="Image1" src="../../Images/harry%20potter.jpg" runat="server" class="img-thumbnail" />
                        </div>
                        <div class="col-lg-6 col-md-6 col-sm-6 col-xs-6" style="padding:0px">
                          <div class="short-div h5">Harry Potter and the Cursed Child</div>
                          <div class="short-div h6"><span>By: </span>J.K Rowling</div>
                          <div class="short-div"><span>Price: </span>$30.00</div>
                           <div class="short-div"><span>Stock: </span>15</div>
                          <hr />
                          <div class="short-div">The story begins nineteen years after the events of the 2007 novel Harry Potter and the Deathly Hallows and follows Harry Potter, now Head of the Department of Magical Law Enforcement at the Ministry of Magic, and his younger son, Albus Severus Potter, who is about to attend Hogwarts School of Witchcraft and Wizardry.</div>
                          <br /> 
                        </div>
                        <div class="col-lg-3 col-md-3 col-sm-3 col-xs-3">
                          <asp:Button ID="btnEdit" runat="server" Text="Edit" class="btn btn-success float-center btn-rounded" CausesValidation="False" UseSubmitBehavior="False"/>
                          <asp:Button ID="btnDel" runat="server" Text="Delete" class="btn btn-danger float-center btn-rounded" CausesValidation="False" />
                        </div>
                    </div>
              </li>
            </ul>
        </div>
        -->
    </div>
</asp:Content>
