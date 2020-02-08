<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Result.aspx.cs" MasterPageFile="~/User.Master" Inherits="GraphProject.Result" %>

<asp:Content ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
     <script type="text/javascript">
        window.history.forward();
        function noBack() { window.history.forward(); }
    </script>
    <div style="margin-left:10px;margin-right:10px;">
        <div style="padding-top:10px;">
            <asp:Label ID="lblPercent" runat="server" Text=""></asp:Label>
        </div>
        Below are your results:
        <br /><br />
        <div>
            <table width="100%" cellpadding="0" cellspacing="0" style="text-align:center;">
                <tr>
                    <th>
                        Questions
                    </th>
                    <th>
                        Correct
                    </th>
                </tr>
                <tr>
                    <td>
                        Question 1
                    </td>
                    <td>
                        <asp:Label ID="lblQ1" runat="server" Text=""></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>
                        Question 2
                    </td>
                    <td>
                        <asp:Label ID="lblQ2" runat="server" Text=""></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>
                        Question 3
                    </td>
                    <td>
                        <asp:Label ID="lblQ3" runat="server" Text=""></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>
                        Question 4
                    </td>
                    <td>
                        <asp:Label ID="lblQ4" runat="server" Text=""></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>
                        Question 5
                    </td>
                    <td>
                        <asp:Label ID="lblQ5" runat="server" Text=""></asp:Label>
                    </td>
                </tr>
            </table>
        </div>
        <div style="padding-top:30px;">
           <table width="100%" cellpadding="0" cellspacing="0" style="text-align:center;">
                <tr id="qh" runat="server">
                    <th>
                        Correct Answer Order
                    </th>
                </tr>
                <tr id="q1" runat="server">
                    <td>
                        <asp:Label ID="lblWQ1" runat="server" Text=""></asp:Label>
                    </td>
                </tr>
                <tr id="q2" runat="server">
                    <td>
                        <asp:Label ID="lblWQ2" runat="server" Text=""></asp:Label>
                    </td>
                </tr>
                <tr id="q3" runat="server">
                    <td>
                        <asp:Label ID="lblWQ3" runat="server" Text=""></asp:Label>
                    </td>
                </tr>
                <tr id="q4" runat="server">
                    <td>
                        <asp:Label ID="lblWQ4" runat="server" Text=""></asp:Label>
                    </td>
                </tr>
                <tr id="q5" runat="server">
                    <td>
                        <asp:Label ID="lblWQ5" runat="server" Text=""></asp:Label>
                    </td>
                </tr>
            </table>   
        </div>
        <div style="padding-top:10px;color:#373737;">
            BFS Facts..
        </div> 
        <div>
            <asp:Label ID="lblBfs" runat="server" Text=""></asp:Label>
        </div>
        <div style="padding-top:10px;color:#373737;">
            DFS Facts..
        </div>    
        <div>
            <asp:Label ID="lblDfs" runat="server" Text=""></asp:Label>
        </div>
        <div style="padding-top:10px;">
            <asp:HyperLink ID="hyHome" runat="server" NavigateUrl="~/UserHome.aspx">Back to Home Page</asp:HyperLink>
        </div>
    </div>
</asp:Content>