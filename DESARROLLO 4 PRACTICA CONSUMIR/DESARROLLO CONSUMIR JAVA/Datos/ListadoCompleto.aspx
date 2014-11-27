<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="ListadoCompleto.aspx.cs" Inherits="Datos_ListadoCompleto" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" Runat="Server">
    <style type="text/css">
        .style7
        {
            color: #0000CC;
            font-size: x-large;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" Runat="Server">
    <p>
        <span class="style7"><strong>LISTADO</strong></span>
    </p>
    <p>
        <asp:Image ID="Image5" runat="server" Height="58px" 
            ImageUrl="~/Images/nombreanimado (1).gif" Width="413px" />
        <br />
    </p>
    <p>
    </p>
    <p>
    </p>
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
    
    </asp:UpdatePanel>
    <p>
    </p>
</asp:Content>

