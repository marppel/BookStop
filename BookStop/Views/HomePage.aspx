<%@ Page Title="" Language="C#" MasterPageFile="~/Navbar.Master" AutoEventWireup="true" CodeBehind="Homepage.aspx.cs" Inherits="WebAssignment.Views.Homepage" %>
<%@ MasterType VirtualPath="~/Navbar.Master" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <!-- References:
    Bootstrap (n.d) Cards 4.0.0 [Source code]. https://getbootstrap.com/docs/4.0/components/card/
    --->
    <link rel="stylesheet" href="../CSS/Shared.css">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <!--Jumbotron-->
    <div class="jumbotron" style="background:#dadfe4">
      <h1 class="display-4">New Harry Potter Book Collection!</h1>
      <p class="lead">Discover the truth about magical beginnings and embark on an enthralling, unmissable adventure at Hogwarts School of Witchcraft and Wizardry with Harry Potter, Ron Weasley and Hermione Granger.</p>
      <hr class="my-4">
      <p>Find out about Harry Potter Series</p>
        <asp:Button ID="Button1" runat="server" Text="Learn more" class="btn btn-primary btn-lg btn-rounded" OnClick="Button1_Click" ToolTip="Learn more about this book series"/>
    </div>
    <br />

    <!--featured tag-->
    <div class="card container" style="margin:40px">
      <div class="card-header">
        Featured
      </div>
      <div class="card-body">
        <div class="card-deck">
            <asp:DataList ID="dlHome" runat="server" RepeatColumns="3" RepeatDirection="Horizontal" OnItemCommand="dlHome_ItemCommand">
                <ItemTemplate >
                    <div class="card text-center" style="width: 16.5rem; height: 25rem;">
                        <asp:Image ID="Image2" class="card-img-top" ImageUrl='<%# Bind("filePath", "{0}") %>' runat="server" height="211px"  width="262.5px"/>            
                        <br />
                        <div class="card-body">
                            <asp:LinkButton ID="lbTitle" runat="server" Text='<%# Bind("PName") %>' CommandName="CNHomeViewProd" CommandArgument='<%# Eval("PID") %>' ></asp:LinkButton>
                            <br />
                            <asp:Label ID="Label1" runat="server" Text='<%# Bind("PAuthor") %>'></asp:Label>
                            <br />
                            <asp:Label ID="Label2" runat="server" Text="$"></asp:Label>
                            <asp:Label ID="Label3" runat="server" Text='<%# Bind("PPrice") %>'></asp:Label>
                        </div>
                        </div>
                </ItemTemplate>
            </asp:DataList> 
        </div>
      </div>
    </div>
</asp:Content>
