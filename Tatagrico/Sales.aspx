<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="Sales.aspx.cs" Inherits="Tatagrico.Sales" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <asp:GridView ID="GridView3" Height="315px" OnSelectedIndexChanged="GridView2_SelectedIndexChanged" Width="1287px"></asp:GridView>
    <asp:TextBox ID="Sales_comment" runat="server" Enabled="false" />
</asp:Content>