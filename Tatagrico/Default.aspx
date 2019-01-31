<%@ Page Title="Home Page" Language="C#"  AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Tatagrico._Default" %>
<!DOCTYPE html>

<html lang="en">
<head runat="server">
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
    <title><%: Page.Title %> - My ASP.NET Application</title>

    <asp:PlaceHolder runat="server">
        <%: Scripts.Render("~/bundles/modernizr") %>
    </asp:PlaceHolder>

    <webopt:bundlereference runat="server" path="~/Content/css" />
    <link href="~/favicon.ico" rel="shortcut icon" type="image/x-icon" />

</head>
<body>
    <form runat="server">
        <asp:ScriptManager runat="server">
            <Scripts>
                <%--To learn more about bundling scripts in ScriptManager see https://go.microsoft.com/fwlink/?LinkID=301884 --%>
                <%--Framework Scripts--%>
                <asp:ScriptReference Name="MsAjaxBundle" />
                <asp:ScriptReference Name="jquery" />
                <asp:ScriptReference Name="bootstrap" />
                <asp:ScriptReference Name="WebForms.js" Assembly="System.Web" Path="~/Scripts/WebForms/WebForms.js" />
                <asp:ScriptReference Name="WebUIValidation.js" Assembly="System.Web" Path="~/Scripts/WebForms/WebUIValidation.js" />
                <asp:ScriptReference Name="MenuStandards.js" Assembly="System.Web" Path="~/Scripts/WebForms/MenuStandards.js" />
                <asp:ScriptReference Name="GridView.js" Assembly="System.Web" Path="~/Scripts/WebForms/GridView.js" />
                <asp:ScriptReference Name="DetailsView.js" Assembly="System.Web" Path="~/Scripts/WebForms/DetailsView.js" />
                <asp:ScriptReference Name="TreeView.js" Assembly="System.Web" Path="~/Scripts/WebForms/TreeView.js" />
                <asp:ScriptReference Name="WebParts.js" Assembly="System.Web" Path="~/Scripts/WebForms/WebParts.js" />
                <asp:ScriptReference Name="Focus.js" Assembly="System.Web" Path="~/Scripts/WebForms/Focus.js" />
                <asp:ScriptReference Name="WebFormsBundle" />
                <%--Site Scripts--%>
            </Scripts>
        </asp:ScriptManager>

        <div class="navbar navbar-inverse navbar-fixed-top">
            <div class="container">
                <div class="navbar-header">
                    <button type="button" class="navbar-toggle" data-toggle="collapse" data-target=".navbar-collapse">
                        <span class="icon-bar"></span>
                        <span class="icon-bar"></span>
                        <span class="icon-bar"></span>
                        <span class="icon-bar"></span>
                        <span class="icon-bar"></span>
                    </button>
                    <a class="navbar-brand" runat="server" href="Default.aspx">TataAgrico</a>
                </div>
                <div class="navbar-collapse collapse">
                    <ul class="nav navbar-nav">
                        <li id="Home"><a  runat="server" href="Default.aspx">Home</a></li>
                        <li class="li"><%: DateTime.Now %></li>
                        <li><img src="Images/logo1.jpg"width="50px" height="50px" /></li>
                        <li id="Login"><a runat="server" href="~/Home">Login</a></li>
                    </ul>
                </div>
            </div>
        </div>

<div class="container body-content">
            
     <div id="myCarousel" class="carousel slide" data-ride="carousel" data-interval="6000">
    <ol class="carousel-indicators">
        <li data-target="#myCarousel" data-slide-to="0" class="active"></li>
        <li data-target="#myCarousel" data-slide-to="1"></li>
        <li data-target="#myCarousel" data-slide-to="2"></li>
    </ol>
    <div class="carousel-inner" role="listbox">
        <div class="item active">
            <img src="Images/Agrico Product CLuster.jpg" alt="ASP.NET" class="img-responsive" />
        </div>
        <div class="item">
            <img src="Images/logo1.jpg" alt="Visual Studio" class="img-responsive" />
        </div>
    </div>
    <a class="left carousel-control" href="#myCarousel" role="button" data-slide="prev">
        <span class="glyphicon glyphicon-chevron-left" aria-hidden="true"></span>
        <span class="sr-only">Previous</span>
    </a>
    <a class="right carousel-control" href="#myCarousel" role="button" data-slide="next">
        <span class="glyphicon glyphicon-chevron-right" aria-hidden="true"></span>
        <span class="sr-only">Next</span>
    </a>
</div>
            <hr />
            <footer class="footer">
                        <div class="container">
                            <div class="row">             
                                <div class="col-12 col-sm-8">
                                    <h5>Our Address</h5>
                                    <address>
                                    43,Tata Steel<br>
                                    Jawaharlal road <br>
                                    KOLKATA<br>
                                    Tel.: +91 852 1234<br>
                                    Fax: +91 287 659<br>
                                    Email: <a href="mailto:"></a>
                                    </address>
                                 </div>
                                <div class="col-12 col-sm align-self-center">
                                    <div class="text-center" >
                                        <a href="http://google.com/+">Google+</a>
                                        <a href="http://www.facebook.com/profile.php?id=">Facebook</a>
                                        <a href="http://www.linkedin.com/in/">LinkedIn</a>
                                        <a href="http://twitter.com/">Twitter</a>
                                        <a href="http://youtube.com/">YouTube</a>
                                        <a href="mailto:">Mail</a>
                                    </div>
                                </div>
                        </div>
                        <div class="row justify-content-center">             
                                <div class="col-auto align-self-center">
                                    <p>© Copyright 2018 SUNNY SHARMA</p>
                                </div>
                        </div>
                        </div>
            </footer>
        </div>
    </form>
</body>
</html>
