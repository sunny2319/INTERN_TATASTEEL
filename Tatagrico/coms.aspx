<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true"  CodeBehind="coms.aspx.cs" Inherits="Tatagrico.coms" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="false" CssClass="table" Height="315px" OnSelectedIndexChanged="GridView2_SelectedIndexChanged" Width="1287px">

    </asp:GridView>
    <asp:TextBox ID="coms_comment" runat="server" Enabled="false" />

</asp:Content>