<%@ Page Title="About" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="About.aspx.cs" Inherits="Tatagrico.About" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
  <h1>Create Request</h1>
<table border="5" class="table" >
                            <tr>
                            <th>REF_NO:</th>
                            <th><asp:TextBox ID="re" runat="server" /></th>
                            </tr>
                            <tr>
                            <th>Name:</th>
                            <th><asp:TextBox ID="Name1" runat="server" /></th>
                            </tr>
                            <tr>
                            <th>Category:</th>
                            <th><asp:DropDownList ID="Category1" runat="server">
                                <asp:ListItem>Category</asp:ListItem>
                                 <asp:ListItem>Discount</asp:ListItem>
                                 <asp:ListItem>Misc</asp:ListItem>
                                 <asp:ListItem>Custom</asp:ListItem>
                                </asp:DropDownList>
                            </th>
                            </tr>
                            <tr>
                                <th>Attachment:</th>
                                <th><asp:FileUpload ID="attachment" runat="server" />
                                    
                                </th>
                            </tr>
                            <tr>
                                <th>Comments:</th>
                                <th><asp:TextBox ID="Comment1" runat="server"></asp:TextBox></th>
                            </tr>
                               </table>
                            <asp:Button  ID ="Button1" runat="server" Text="Button" OnClick="Button1_Click1"/>
                           <h1> <asp:Label ID="Label1" runat="server"></asp:Label></h1>
   
</asp:Content>

