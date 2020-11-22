<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Query.aspx.cs" Inherits="ClubActivities.Pages.Query" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <br />
    <h1>Club Activities</h1>
    <br />
    <blockquote class="alert alert-info text-center">enter the starting date of the activity search (default to today) select a club and press Activities? To get a list of activities since the start date select an activity to maintain</blockquote>
    <br /><br />
    <div class="row">
        <div class="offset-3">
            <fieldset>
                <asp:Label ID="Label1" runat="server" Text="ClubID"></asp:Label>
                <asp:DropDownList ID="ClubList" runat="server" OnSelectedIndexChanged="ClubList_SelectedIndexChanged"></asp:DropDownList>
                <br />
                <asp:Label ID="Label2" runat="server" Text="Start Date"></asp:Label>
                <asp:TextBox ID="PartialStart" runat="server"></asp:TextBox>
                <br /><br />
                <asp:Button ID="Button1" runat="server" Text="Activities?" />
                <asp:GridView ID="ClubListGrid" runat="server"></asp:GridView>
            </fieldset>
        </div>
    </div>

</asp:Content>
