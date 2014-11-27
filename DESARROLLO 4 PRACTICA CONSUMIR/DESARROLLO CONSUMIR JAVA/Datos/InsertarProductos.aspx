<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="InsertarProductos.aspx.cs" Inherits="Datos_InsertarProductos" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" Runat="Server">
    <style type="text/css">
    .style7
    {
        font-size: large;
        text-align: center;
        color: #000000;
    }
    .style8
    {
        width: 100%;
        color: #FFFFB7;
        border-color: #FFFF99;
            background-color: #99CCFF;
        }
    .style9
    {
        width: 53px;
    }
    .style11
    {
        color: #000099;
        font-size: large;
    }
        .style13
        {
            width: 104px;
        }
        .style14
        {
            width: 104px;
            color: #000099;
            font-size: large;
        }
    .style15
    {
        color: #000099;
        font-size: x-large;
    }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" Runat="Server">
    <p class="style7">
    <strong><span class="style15">INGRESO </span>
    </strong>
</p>
    <p class="style7">
        <asp:Image ID="Image5" runat="server" Height="72px" 
            ImageUrl="~/Images/nombreanimado (1).gif" Width="387px" />
        <strong><br />
    </strong>
</p>
    <br />
    <br />
<br />
<asp:UpdatePanel ID="UpdatePanel1" runat="server">
    <ContentTemplate>
        <table class="style8">
            <tr>
                <td class="style9" rowspan="3">
                    <asp:Image ID="Image3" runat="server" Height="170px" 
                        ImageUrl="~/Images/icon-productos.gif" Width="178px" />
                </td>
                <td class="style13">
                    <span class="style11"><strong>Categoria:<br />
                    <asp:DropDownList ID="ddlCategorias" runat="server" Height="34px" 
                        style="font-size: large" Width="192px">
                    </asp:DropDownList>
                    <br />
                    </strong></span>
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                </td>
            </tr>
            <tr>
                <td class="style14">
                    <strong>Nombre:<br />
                    <br />
                    </strong>
                    <asp:TextBox ID="txtNombre" runat="server" style="font-size: large" 
                        Width="182px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style14">
                    <strong>Cantidad por Unidad:<br />
                    <asp:TextBox ID="txtCantidad" runat="server" style="font-size: large" 
                        Width="182px"></asp:TextBox>
                    </strong></td>
            </tr>
        </table>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;

<br />
    </ContentTemplate>
</asp:UpdatePanel>
<br />
<asp:Panel ID="Panel3" runat="server" BorderColor="Black" 
                            BorderStyle="Outset" BorderWidth="10px" Height="83px" HorizontalAlign="Center" 
                            style="margin-left: 197px" Width="665px">
                            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;<asp:ImageButton 
                                ID="btnNuevo0" runat="server" Height="49px" 
                                ImageUrl="~/Images/nuevo.png" ToolTip="Nuevo" Width="56px" 
                                onclick="btnNuevo0_Click" />
                            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                            <asp:ImageButton ID="btnGuardar0" runat="server" 
                                ImageUrl="~/Images/guardar.png" ToolTip="Guardar" 
                                onclick="btnGuardar0_Click" />
                            &nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;<br />
                            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp; Nuevo&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Guardar&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        </asp:Panel>
<br />
<br />
</asp:Content>

