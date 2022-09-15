<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LoginRegister.aspx.cs" Inherits="WebAssignment.Views.LoginRegister" %>

<!DOCTYPE html>

<!-- References:
BBBootstrap Team (2019) Bootstrap 5 simple tabbed login register form [Source code]. https://bbbootstrap.com/snippets/bootstrap-simple-tabbed-login-register-form-29443624
--->

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Login/Register</title>
    <link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/bootstrap@5.0.0-alpha1/dist/css/bootstrap.min.css" />
    <link rel="stylesheet" href="../CSS/LoginRegister.css" />
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.0.0-alpha1/dist/js/bootstrap.bundle.min.js"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/jquery/3.2.1/jquery.min.js"></script>
    <link rel="stylesheet" href="../CSS/Shared.css" />
</head>
<body>
    <!--Head title-->
    <div style="background-color:#f8f9fa">
        <h1 class="text-center"><a href="HomePage.aspx">BookStop</a></h1>
        <hr />
    </div>

    <!--Form-->
    <form id="form1" runat="server">
        <div class="d-flex justify-content-center align-items-center mt-5">
            <div class="card">

                <!--Tab control-->
                <ul class="nav nav-pills mb-3" id="pills-tab" role="tablist">
                    <li class="nav-item text-center"> <a class="nav-link active btl" id="pills-home-tab" data-toggle="pill" href="#pills-home" role="tab" aria-controls="pills-home" aria-selected="true">Login</a> </li>
                    <li class="nav-item text-center"> <a class="nav-link btr" id="pills-profile-tab" data-toggle="pill" href="#pills-profile" role="tab" aria-controls="pills-profile" aria-selected="false">Signup</a> </li>
                </ul>

                <div class="tab-content" id="pills-tabContent">

                    <!--Login tab-->
                    <div class="tab-pane fade show active" id="pills-home" role="tabpanel" aria-labelledby="pills-home-tab">
                        <div class="form px-4" style="height:fit-content"> 
                            <br />
                            <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ErrorMessage="This is not a valid email address" ForeColor="Red" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" ControlToValidate="txtEmail"></asp:RegularExpressionValidator>
                            <br />
                            <asp:Label ID="lblErrLogin" runat="server" ForeColor="Red"></asp:Label>
                            <asp:TextBox ID="txtEmail" class="form-control" placeholder="Enter email" runat="server"></asp:TextBox>
                            <asp:TextBox ID="txtPwd" class="form-control" placeholder="Enter password" runat="server" TextMode="Password"></asp:TextBox>
                            <asp:Button ID="btnLogin" class="btn btn-dark btn-block btn-rounded" runat="server" Text="Login" OnClick="btnLogin_Click"/>
                        </div>
                    </div>

                    <!--Register tab-->
                    <div class="tab-pane fade" id="pills-profile" role="tabpanel" aria-labelledby="pills-profile-tab">
                        <div class="form px-4" style="height:fit-content">
                            <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ErrorMessage="This is not a valid email address" ForeColor="Red" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" ControlToValidate="txtNewEmail"></asp:RegularExpressionValidator>
                            <br />
                            <asp:Label ID="lblErrRegister" runat="server" Text=""></asp:Label>
                            <asp:TextBox ID="txtNewName" class="form-control" placeholder="Enter your username" runat="server"></asp:TextBox>
                            <asp:TextBox ID="txtNewEmail" class="form-control" placeholder="Enter new email" runat="server"></asp:TextBox>
                            <asp:TextBox ID="txtNewPwd" class="form-control" placeholder="Enter new password" runat="server" TextMode="Password"></asp:TextBox>
                            <asp:Button ID="btnRegister" class="btn btn-dark btn-block btn-rounded" runat="server" Text="Signup" href="pills-profile" OnClick="btnRegister_Click"/>
                        </div>
                    </div>
                </div>

            </div>

        </div>
    </form>
</body>
</html>
