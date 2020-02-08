<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdminHome.aspx.cs" MasterPageFile="~/Admin.Master" Inherits="GraphProject.AdminHome" %>

<asp:Content ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div style="margin-top:20px;margin-bottom:20px;margin-left:10px;margin-right:10px;">
        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/SelectQs.aspx">Add Question</asp:HyperLink>
    </div>    
    <div runat="server" id="lblGrid" style="margin-left:10px;margin-right:10px;">
        List of questions whose answers are not set:
    </div>
    <div style="margin-left:10px;margin-right:10px;">
        <asp:GridView ID="gvInvalidQuestions" EmptyDataText="No questions without answers in list" OnRowCommand="gvInvalidQuestions_RowCommand" runat="server" Width="100%" AutoGenerateColumns="false">
            <Columns>
                <asp:BoundField HeaderText="Question Id" DataField="qid" ItemStyle-HorizontalAlign="Center" />
                <asp:BoundField HeaderText="Question Name" DataField="qname" ItemStyle-HorizontalAlign="Center"/>
                <asp:BoundField HeaderText="Question List" DataField="qlist" ItemStyle-HorizontalAlign="Center" ItemStyle-CssClass="adminGridQList" HeaderStyle-Width="500px"/>
                <asp:TemplateField ShowHeader="False" ItemStyle-HorizontalAlign="Center">
                    <ItemTemplate> 
                        <asp:Button ID="btnEdit" Width="140px" runat="server" Text="Add Answer" CssClass="btn" CommandName="Seen" CommandArgument='<%#Eval("qid") %>'/>
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
    </div>
</asp:Content>
