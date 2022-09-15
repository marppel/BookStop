<%@ Page Title="" Language="C#" MasterPageFile="~/NavbarAdmin.Master" AutoEventWireup="true" CodeBehind="ListCategory.aspx.cs" Inherits="WebAssignment.Views.Admin.ListCategory" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">

        <!--Title-->
        <div>
            <h3 class="text-primary" style="margin-top:40px; display:inline-block;">Category List</h3> &nbsp;&nbsp;
            <span><asp:Button ID="btnAddNew" runat="server" Text="Add" class="btn btn-info" CausesValidation="False" OnClick="btnAddNew_Click" UseSubmitBehavior="False"/></span>
            <hr>
        </div>

        <!--Subtitle
        <div class="row" style="padding-left:10px">
            <div class="col-lg-4 col-md-4 col-sm-4 col-xs-4" >
                <label class="h5" style="padding-left:10px">Category ID</label>
            </div>
            <div class="col-lg-4 col-md-4 col-sm-4 col-xs-4" >
                <label class="h5">Description</label>
            </div>
            <div class="col-lg-4 col-md-4 col-sm-4 col-xs-4">
            </div>
        </div>-->

        <!--Content-->
        <!--GridView-->
        <div class="row">
            <asp:Label ID="lblNoItem" runat="server" Text="" class="text-center"></asp:Label>
            <div class="col-12">
                <asp:GridView ID="GVCategory" runat="server" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" DataKeyNames="uniqid" OnSelectedIndexChanged ="GVCategory_SelectedIndexChanged" OnRowDeleting="GVCategory_RowDeleting">
                    <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                    <Columns>
                        <asp:BoundField HeaderText="ID" DataField="uniqid" ReadOnly="true"/>
                        <asp:BoundField HeaderText="Category ID" DataField="ID" ReadOnly="true"/>
                        <asp:BoundField HeaderText="Description" DataField="Desc" ReadOnly="true" />
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

        <!-- Unused datalist
        <ul class="list-group">
        <asp:DataList ID="DLCategory" runat="server" Width="100%">
            <ItemTemplate>
                <li class="list-group-item ">
                    <div class="row">
                        <div class="col-lg-4 col-md-4 col-sm-4 col-xs-4">
                            <asp:Label ID="lblCatID" runat="server" Text='<%#Bind("ID")%>'></asp:Label>
                        </div>
                        <div class="col-lg-5 col-md-5 col-sm-5 col-xs-5">
                            <asp:Label ID="lblCatDesc" runat="server" Text='<%#Bind("Desc")%>'></asp:Label>
                        </div>
                        <div class="col-lg-3 col-md-3 col-sm-3 col-xs-3">
                            <asp:Button ID="btnCatEdit" runat="server" class="btn btn-success" Text="Edit"></asp:Button>
                            <asp:Button ID="btnCatDelete" runat="server" class="btn btn-danger" Text="Delete"></asp:Button>
                        </div>
                    </div>
               </li>
            </ItemTemplate>
        </asp:DataList>
        </ul>
        -->
    </div>
</asp:Content>
