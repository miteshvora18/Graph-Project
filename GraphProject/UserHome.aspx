<%@ Page Language="C#" MasterPageFile="~/User.Master" AutoEventWireup="true" CodeBehind="UserHome.aspx.cs" Inherits="GraphProject.UserHome" %>

<asp:Content ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="center" style="margin-top:100px;">
        <asp:Button ID="btnTest" runat="server" Text="Start Test" CssClass="btn" 
            style="margin-left:570px;" onclick="btnTest_Click" />
    </div>
    <div style="margin-left:10px;margin-right:10px;">
        <asp:GridView ID="gvPreviousResults" runat="server" Width="100%" AutoGenerateColumns="false" EmptyDataText="No Previous Tests">
            <Columns>
                <asp:BoundField HeaderText="Total Questions" ItemStyle-HorizontalAlign="Center" DataField="totalQs" />
                <asp:BoundField HeaderText="Correct Answers" ItemStyle-HorizontalAlign="Center" DataField="correctAns" />
                <asp:BoundField HeaderText="Percentage" ItemStyle-HorizontalAlign="Center" DataField="percentage" />
                <asp:BoundField HeaderText="Test Time" ItemStyle-HorizontalAlign="Center" DataField="testTime" />
            </Columns>
        </asp:GridView>
    </div>
</asp:Content>
