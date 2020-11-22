<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ClubActivities._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h1>Club Activites</h1>
    <div class="jumbotron">
        <asp:Image ID="SampleImg" runat="server" ImageUrl="~/Images/SampleImg.png"/>     
    </div>

    <div class="row">
        <div class="col-md-4">
            <h2>Known Bugs</h2>
            <p>
         <%-- Add known bugs --%>
            </p>
        </div>
        <div class="col-md-4">
            <h2>Form Description</h2>
            <p>
                    <%-- give description --%>
            </p>
        </div>
        <div class="col-md-4">
            <h2>Stored Procedures</h2>
            <p>
                    <%-- Add stored procedures --%>
            </p>
        </div>
    </div>

</asp:Content>
