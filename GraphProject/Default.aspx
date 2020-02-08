<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="GraphProject._Default" MasterPageFile="~/Admin.Master" %>

<asp:Content ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    Select structure you want..
    <div class="middle">
        <div>
            <asp:Button ID="btnA" runat="server" CssClass="btnGraphSelected" Text="A" />
        </div>
        <div>
            <br />
            <br />
        </div>
        <div>
            <asp:Button ID="btnA1" runat="server" CssClass="btnGraph" Text="A1" 
                onclick="btnA1_Click" />
            <asp:Button ID="btnA2" runat="server" CssClass="btnGraph" Text="A2" />
            <asp:Button ID="bntA3" runat="server" CssClass="btnGraph" Text="A3" />
            <asp:Button ID="btnA4" runat="server" CssClass="btnGraph" Text="A4" />
        </div>
        <div>
            <br />
            <br />
        </div>
        <div>
            <asp:Button ID="btnA11" runat="server" CssClass="btnGraph" Text="A11" />
            <asp:Button ID="btnA12" runat="server" CssClass="btnGraph" Text="A12" />
            <asp:Button ID="btnA21" runat="server" CssClass="btnGraph" Text="A21" />
            <asp:Button ID="btnA22" runat="server" CssClass="btnGraph" Text="A22" />
            <asp:Button ID="btnA31" runat="server" CssClass="btnGraph" Text="A31" />
            <asp:Button ID="btnA32" runat="server" CssClass="btnGraph" Text="A32" />
            <asp:Button ID="btnA41" runat="server" CssClass="btnGraph" Text="A41" />
            <asp:Button ID="btnA42" runat="server" CssClass="btnGraph" Text="A42" />
        </div>
        <div>
            <br />
            <br />
        </div>
        <div>
            <asp:Button ID="btnA111" runat="server" CssClass="btnGraph" Text="A111" />
            <asp:Button ID="btnA112" runat="server" CssClass="btnGraph" Text="A112" />
            <asp:Button ID="btnA121" runat="server" CssClass="btnGraph" Text="A121" />
            <asp:Button ID="btnA122" runat="server" CssClass="btnGraph" Text="A122" />
            <asp:Button ID="btnA211" runat="server" CssClass="btnGraph" Text="A211" />
            <asp:Button ID="btnA212" runat="server" CssClass="btnGraph" Text="A212" />
            <asp:Button ID="btnA221" runat="server" CssClass="btnGraph" Text="A221" />
            <asp:Button ID="btnA222" runat="server" CssClass="btnGraph" Text="A222" />
            <asp:Button ID="btnA311" runat="server" CssClass="btnGraph" Text="A311" />
            <asp:Button ID="btnA312" runat="server" CssClass="btnGraph" Text="A312" />
            <asp:Button ID="btnA321" runat="server" CssClass="btnGraph" Text="A321" />
            <asp:Button ID="btnA322" runat="server" CssClass="btnGraph" Text="A322" />
            <asp:Button ID="btnA411" runat="server" CssClass="btnGraph" Text="A411" />
            <asp:Button ID="btnA412" runat="server" CssClass="btnGraph" Text="A412" />
            <asp:Button ID="btnA421" runat="server" CssClass="btnGraph" Text="A421" />
            <asp:Button ID="btnA422" runat="server" CssClass="btnGraph" Text="A422" />
        </div>
        <br />
        <asp:Button ID="btnNext" runat="server" CssClass="btnSubmit" Text="Next" />
    </div>
</asp:Content>
