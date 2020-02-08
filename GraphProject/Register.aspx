<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Main.Master" CodeBehind="Register.aspx.cs" Inherits="Login_Form.ForgotPassword" %>

<asp:Content ContentPlaceHolderID="ContentPlaceHolderLogin" runat="server">
    <style type="text/css">
        .footer,.header,.content,.pageContent
        {
            display:none;
        }
    </style>
    <div class="login" style="height:350px;">
        <%--<div class="errorMsg">
            <asp:Label ID="lblMessage" runat="server"></asp:Label>
        </div>--%>
        <div class="marginBotttom10">
            <asp:Label ID="lblUsername" runat="server" CssClass="lbl">Username</asp:Label>
            <asp:TextBox ID="txtUsername2" runat="server" CssClass="txt"></asp:TextBox>
        </div>
        <div class="marginBotttom10">
            <asp:Label ID="lblPassword" runat="server" CssClass="lbl">Password</asp:Label>
            <asp:TextBox ID="txtPassword2" runat="server" CssClass="txt" TextMode="Password"></asp:TextBox>
        </div>
        <div class="marginBotttom10">
            <asp:Label ID="lblEmail" runat="server" CssClass="lbl">Email Id</asp:Label>
            <asp:TextBox ID="txtEmail" runat="server" CssClass="txt"></asp:TextBox><br />
            <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ErrorMessage="Incorrect email Format" ControlToValidate="txtEmail" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" Display="Dynamic"></asp:RegularExpressionValidator>
        </div>
        <div class="marginTop20">
            <asp:Button ID="btnSubmit" CssClass="btn btnLogin" runat="server" Text="Submit" 
                onclick="btnSubmit_Click"/>
        </div>
        <div class="forgotPass">
            <a href="Login.aspx" style="color:#000000;text-decoration:none;">Back to Login</a> 
        </div>
        <%--<div class="successMsg">
            <asp:Label ID="lblSuccessMsg" runat="server"></asp:Label>
        </div>--%>
    </div>
</asp:Content>